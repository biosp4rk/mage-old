using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace mage
{
    public partial class FormTileTable : Form, Editor
    {
        // fields
        private ushort[] tileTable;
        private byte[] gfxData;
        private Palette palette;

        private int ttbOffset;
        private int origLen;
        private int numOfTiles;
        private int[] tileNums;

        private Label[] labels_tile;
        private Button[] buttons_pal;
        private Button[] buttons_hflip;
        private Button[] buttons_vflip;

        private bool blank;
        private FormMain main;
        private ByteStream romStream;
        private Status status;

        // constructor
        public FormTileTable(FormMain main, int tsNum)
        {
            InitializeComponent();

            this.main = main;
            this.romStream = ROM.Stream;
            Initialize(tsNum);
        }

        public void UpdateEditor()
        {
            if (!status.UnsavedChanges)
            {
                switch (tabControl.SelectedIndex)
                {
                    case 0:
                        InitializeTileset();
                        break;
                    case 1:
                        InitializeBackground();
                        break;
                    case 2:
                        InitializeOffset();
                        break;
                }
            }
        }

        private void Initialize(int tsNum)
        {
            status = new Status(statusLabel_changes, button_apply);

            gfxView_gfx.Initialize(1, 8);
            gfxView_result.Initialize(0, 16);

            // fill comboboxes
            comboBox_area.Items.AddRange(Version.AreaNames);

            int numTilesets = Version.NumOfTilesets;
            for (int i = 0; i < numTilesets; i++)
            {
                comboBox_tileset.Items.Add(Hex.ToString(i));
            }

            for (int i = 0; i < 16; i++)
            {
                comboBox_palette.Items.Add(Hex.ToString(i));
            }

            // get control arrays
            labels_tile = new Label[] { label_tileTL, label_tileTR, label_tileBL, label_tileBR };
            buttons_pal = new Button[] { button_palTL, button_palTR, button_palBL, button_palBR };
            buttons_hflip = new Button[] { button_hflipTL, button_hflipTR, button_hflipBL, button_hflipBR };
            buttons_vflip = new Button[] { button_vflipTL, button_vflipTR, button_vflipBL, button_vflipBR };

            comboBox_tileset.SelectedIndex = tsNum;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reset();
            status.LoadNew();
        }

        private void Reset()
        {
            ResetTile();

            // gfx
            gfxView_gfx.BackgroundImage = null;
            gfxView_gfx.Size = new Size(0, 0);

            // result
            gfxView_result.BackgroundImage = null;
            gfxView_result.Size = new Size(0, 0);

            comboBox_palette.SelectedIndex = -1;
            comboBox_palette.Enabled = false;
            comboBox_size.SelectedIndex = -1;
            comboBox_size.Enabled = false;
            numericUpDown_height.Enabled = false;

            blank = true;
        }

        private void ResetTile()
        {
            for (int i = 0; i < 4; i++)
            {
                labels_tile[i].Text = "–";
                buttons_pal[i].Text = "";
                buttons_hflip[i].Image = null;
                buttons_vflip[i].Image = null;
            }

            gfxView_tile.BackgroundImage = null;
            tileNums = null;

            // reset cursors and selections
            resCursor = resSelection = new Point(-1, -1);
            gfxCursor = gfxSelection = new Point(-1, -1);
            gfxView_result.Reset();
            gfxView_gfx.Reset();
        }

        // tileset
        private void comboBox_tileset_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeTileset();
            status.LoadNew();
        }

        private void InitializeTileset()
        {
            blank = true;

            // get tileset and vram
            Tileset tileset = new Tileset(romStream, (byte)comboBox_tileset.SelectedIndex);
            VramBG vram = new VramBG(tileset, false);
            gfxData = new byte[0x8000];
            Array.Copy(vram.BGtiles, gfxData, 0x8000);
            palette = vram.BGpalette;

            // initialize tiletable
            tileTable = new ushort[0x1000];
            ushort[] origTileTable = tileset.tileTable;
            numOfTiles = origTileTable.Length;
            origLen = numOfTiles;

            origTileTable.CopyTo(tileTable, 0);
            for (int i = numOfTiles; i < 0x1000; i++)
            {
                tileTable[i] = 0x40;
            }

            // set gfx image
            comboBox_palette.Enabled = true;
            if (comboBox_palette.SelectedIndex == 0)
            {
                DrawGfx();
            }
            else
            {
                comboBox_palette.SelectedIndex = 0;
            }

            // set tileset image
            int height = numOfTiles / 64;
            numericUpDown_height.Enabled = true;
            numericUpDown_height.Value = height;
            SetResultImage(256, numOfTiles / 4);

            ResetTile();
            blank = false;
        }

        private void numericUpDown_height_ValueChanged(object sender, EventArgs e)
        {
            if (blank) { return; }
            numOfTiles = (int)numericUpDown_height.Value * 64;
            SetResultImage(256, numOfTiles / 4);
            status.ChangeMade();
        }

        // backgrounds
        private void comboBox_area_SelectedIndexChanged(object sender, EventArgs e)
        {
            int area = comboBox_area.SelectedIndex;
            int numOfRooms = Version.RoomsPerArea[area];
            int currNum = comboBox_room.Items.Count;

            if (numOfRooms > currNum)
            {
                for (int i = currNum; i < numOfRooms; i++)
                {
                    comboBox_room.Items.Add(Hex.ToString(i));
                }
            }
            else if (numOfRooms < currNum)
            {
                for (int i = currNum - 1; i >= numOfRooms; i--)
                {
                    comboBox_room.Items.RemoveAt(i);
                }
            }

            comboBox_room.SelectedIndex = 0;
        }

        private void comboBox_bg_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeBackground();
            status.LoadNew();
        }

        private void InitializeBackground()
        {
            blank = true;

            int room = comboBox_room.SelectedIndex;
            if (room == -1)
            {
                Reset();
                return;
            }
            int bg = comboBox_bg.SelectedIndex;
            if (bg == -1)
            {
                Reset();
                return;
            }

            // get tile table
            int area = comboBox_area.SelectedIndex;
            int offset = romStream.ReadPtr(Version.AreaHeaderOffset + area * 4) + (room * 0x3C);
            int addr;
            if (bg == 0)
            {
                byte prop = romStream.Read8(offset + 1);
                if ((prop & 0x40) == 0)
                {
                    Reset();
                    return;
                }
                addr = romStream.ReadPtr(offset + 8);
            }
            else
            {
                addr = romStream.ReadPtr(offset + 0x18);
            }

            int size = romStream.Read8(addr);
            int length = romStream.Read32(addr + 4) >> 8;
            ByteStream ttb = new ByteStream(length);
            try
            {
                romStream.Seek(addr + 4);
                origLen = Compress.DecompLZ77(romStream, ttb);
            }
            catch
            {
                Reset();
                return;
            }

            tileTable = new ushort[0x800];
            ttb.CopyToArray(0, tileTable, 0, ttb.Length);
            if (size == 0)
            {
                for (int i = 0x400; i < 0x800; i++)
                {
                    tileTable[i] = 0x3FF;
                }
            }

            // get tileset and vram
            byte tsNum = romStream.Read8(offset);
            Tileset tileset = new Tileset(romStream, tsNum);
            VramBG vram = new VramBG(tileset, false);
            gfxData = new byte[0x8000];
            Array.Copy(vram.BGtiles, 0x4000, gfxData, 0, 0x8000);
            palette = vram.BGpalette;

            // set gfx image
            comboBox_palette.Enabled = true;
            if (comboBox_palette.SelectedIndex == 0)
            {
                DrawGfx();
            }
            else
            {
                comboBox_palette.SelectedIndex = 0;
            }

            // set result image
            comboBox_size.Enabled = true;
            comboBox_size.SelectedIndex = size;
            SetBackgroundSize();
            
            ResetTile();
            blank = false;
        }

        private void SetBackgroundSize()
        {
            int size = comboBox_size.SelectedIndex;
            if (size == -1) { return; }

            int width = 256;
            int height = 256;
            numOfTiles = 0x400;
            if (size == 1)
            {
                width = 512;
                numOfTiles = 0x800;
            }
            else if (size == 2)
            {
                height = 512;
                numOfTiles = 0x800;
            }
            SetResultImage(width, height);
        }

        private void comboBox_size_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (blank) { return; }
            SetBackgroundSize();
            status.ChangeMade();
        }

        // offset
        private void button_go_Click(object sender, EventArgs e)
        {
            InitializeOffset();
            status.LoadNew();
        }

        private void InitializeOffset()
        {
            try
            {
                blank = true;

                ttbOffset = Hex.ToInt(textBox_ttb.Text);
                int gfxOffset = Hex.ToInt(textBox_gfx.Text);
                int palOffset = Hex.ToInt(textBox_pal.Text);

                // gfx
                ByteStream temp = new ByteStream();
                romStream.Seek(gfxOffset);
                Compress.DecompLZ77(romStream, temp);
                gfxData = temp.Data;

                // tile table
                temp = new ByteStream();
                romStream.Seek(ttbOffset);
                origLen = Compress.DecompLZ77(romStream, temp);
                numOfTiles = temp.Length / 2;
                tileTable = new ushort[numOfTiles];
                temp.CopyToArray(0, tileTable, 0, temp.Length);

                // palette
                palette = new Palette(romStream, palOffset, 16);

                // set gfx image
                if (comboBox_palette.SelectedIndex == 0)
                {
                    DrawGfx();
                }
                else
                {
                    comboBox_palette.SelectedIndex = 0;
                }
                blank = false;

                // set result image
                SetResultImage(256, numOfTiles / 4);
            }
            catch
            {
                Reset();
                return;
            }

            ResetTile();
            comboBox_palette.Enabled = true;
        }

        // drawing
        private void GetTileNumbers()
        {
            int x = resSelection.X;
            int y = resSelection.Y;

            switch (tabControl.SelectedIndex)
            {
                case 0:
                    int t = (y * 16 + x) * 4;
                    tileNums = new int[] { t, t + 1, t + 2, t + 3 };
                    break;
                case 1:
                    switch (comboBox_size.SelectedIndex)
                    {
                        case 0:
                        case 2:
                            t = y * 64 + x * 2;
                            tileNums = new int[] { t, t + 1, t + 32, t + 33 };
                            break;
                        case 1:
                            t = (x / 16) * 0x400 + y * 64 + (x % 16) * 2;
                            tileNums = new int[] { t, t + 1, t + 32, t + 33 };
                            break;
                    }
                    break;
                case 2:
                    t = y * 64 + x * 2;
                    tileNums = new int[] { t, t + 1, t + 32, t + 33 };
                    break;
            }
        }

        private unsafe void DrawTileChange(int index, int corner)
        {
            ushort val = tileTable[index];

            // get gfx and bitmap for tile            
            byte[] data = new byte[0x20];
            int tileNum = (val & 0x3FF) - (int)numericUpDown_shift.Value;
            if (tileNum < 0) { return; }

            Array.Copy(gfxData, tileNum * 0x20, data, 0, 0x20);
            GFX gfx = new GFX(data, 1);
            Bitmap tile = gfx.Draw15bpp(palette, val >> 12, false);

            // flip tile
            int flip = (val >> 10) & 3;
            if (flip != 0) { Draw.Flip15bpp(tile, flip); }

            // draw on tile
            int x = (corner % 2) * 8;
            int y = (corner / 2) * 8;
            SolidBrush sb = new SolidBrush(Color.FromArgb(32, 32, 32));
            using (Graphics g = Graphics.FromImage(gfxView_tile.BackgroundImage))
            {
                g.FillRectangle(sb, x, y, 8, 8);
                g.DrawImage(tile, x, y);
            }
            gfxView_tile.Invalidate();

            // draw on result
            x += resSelection.X * 16;
            y += resSelection.Y * 16;
            using (Graphics g = Graphics.FromImage(gfxView_result.BackgroundImage))
            {
                g.FillRectangle(sb, x, y, 8, 8);
                g.DrawImage(tile, x, y);
            }

            gfxView_result.Invalidate();
            status.ChangeMade();
        }

        private void InitializeSelectedTile()
        {
            GetTileNumbers();

            // set button info
            for (int t = 0; t < 4; t++)
            {
                int index = tileNums[t];
                ushort val = tileTable[index];

                // tile number
                labels_tile[t].Text = Hex.ToString(val & 0x3FF);
                // palette
                buttons_pal[t].Text = Hex.ToString(val >> 12);
                // horizontal flip
                if ((val & 0x400) == 0) { buttons_hflip[t].Image = null; }
                else { buttons_hflip[t].Image = Properties.Resources.flip_h; }
                // vertical flip
                if ((val & 0x800) == 0) { buttons_vflip[t].Image = null; }
                else { buttons_vflip[t].Image = Properties.Resources.flip_v; }
            }

            // draw tile
            Bitmap tile = new Bitmap(16, 16);
            using (Graphics g = Graphics.FromImage(tile))
            {
                g.FillRectangle(new SolidBrush(Color.FromArgb(32, 32, 32)), 0, 0, 16, 16);
                g.DrawImage(gfxView_result.BackgroundImage, new Rectangle(0, 0, 16, 16),
                    new Rectangle(resSelection.X * 16, resSelection.Y * 16, 16, 16), GraphicsUnit.Pixel);
            }
            gfxView_tile.BackgroundImage = tile;
        }

        private void SetResultImage(int width, int height)
        {
            gfxView_result.BackColor = Color.FromArgb(32, 32, 32);
            Bitmap resultImg = new Bitmap(width, height, PixelFormat.Format16bppArgb1555);
            DrawResult(resultImg);
            gfxView_result.Size = resultImg.Size;
            gfxView_result.BackgroundImage = new Bitmap(resultImg);
        }

        private unsafe void DrawResult(Bitmap image)
        {
            int w = image.Width;
            int index = 0;
            ushort[,] _palette = palette.ARGBs;

            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
            BitmapData imgData = image.LockBits(rect, ImageLockMode.WriteOnly, image.PixelFormat);

            ushort* startPtr = (ushort*)imgData.Scan0;
            ushort* imgPtr = startPtr;

            for (int t = 0; t < numOfTiles; t++)
            {
                int x = 0, y = 0;
                switch (tabControl.SelectedIndex)
                {
                    case 0:
                        x = ((t % 64) / 4) * 16 + (t % 2) * 8;
                        y = (t / 64) * 16 + ((t % 4) / 2) * 8;
                        break;
                    case 1:
                        switch (comboBox_size.SelectedIndex)
                        {
                            case 0:
                            case 2:
                                x = (t % 32) * 8;
                                y = (t / 32) * 8;
                                break;
                            case 1:
                                x = (t / 0x400) * 256 + (t % 32) * 8;
                                y = ((t / 32) % 32) * 8;
                                break;
                        }
                        break;
                    case 2:
                        x = (t % 32) * 8;
                        y = (t / 32) * 8;
                        break;
                }
                imgPtr = startPtr + y * w + x;

                ushort currTile = tileTable[index++];
                int tileNum = currTile & 0x3FF;
                // check for valid tile number
                if (tabControl.SelectedIndex == 2)
                {
                    tileNum -= (int)numericUpDown_shift.Value;
                    if (tileNum < 0) { continue; }
                }
                tileNum *= 0x20;
                if (tileNum >= gfxData.Length) { continue; }
                int pal = currTile >> 12;
                int flip = (currTile >> 10) & 3;

                switch (flip)
                {
                    // no flip
                    case 0:
                        for (int r = 0; r < 8; r++)
                        {
                            for (int pp = 0; pp < 4; pp++)
                            {
                                byte val = gfxData[tileNum++];
                                *imgPtr++ = _palette[pal, val & 0xF];
                                *imgPtr++ = _palette[pal, val >> 4];
                            }
                            // end of row
                            imgPtr += (w - 8);
                        }
                        break;
                    // x flip
                    case 1:
                        imgPtr += 7;
                        for (int r = 0; r < 8; r++)
                        {
                            for (int pp = 0; pp < 4; pp++)
                            {
                                byte val = gfxData[tileNum++];
                                *imgPtr-- = _palette[pal, val & 0xF];
                                *imgPtr-- = _palette[pal, val >> 4];
                            }
                            // end of row
                            imgPtr += (w + 8);
                        }
                        break;
                    // y flip
                    case 2:
                        imgPtr += (w * 7);
                        for (int r = 0; r < 8; r++)
                        {
                            for (int pp = 0; pp < 4; pp++)
                            {
                                byte val = gfxData[tileNum++];
                                *imgPtr++ = _palette[pal, val & 0xF];
                                *imgPtr++ = _palette[pal, val >> 4];
                            }
                            // end of row
                            imgPtr -= (w + 8);
                        }
                        break;
                    // xy flip
                    case 3:
                        imgPtr += (w * 7 + 7);
                        for (int r = 0; r < 8; r++)
                        {
                            for (int pp = 0; pp < 4; pp++)
                            {
                                byte val = gfxData[tileNum++];
                                *imgPtr-- = _palette[pal, val & 0xF];
                                *imgPtr-- = _palette[pal, val >> 4];
                            }
                            // end of row
                            imgPtr -= (w - 8);
                        }
                        break;
                }
            }

            image.UnlockBits(imgData);
        }

        private void DrawGfx()
        {
            GFX gfx = new GFX(gfxData, 32);
            Bitmap gfxImg = gfx.Draw15bpp(palette, comboBox_palette.SelectedIndex, false);
            gfxView_gfx.BackColor = Color.FromArgb(32, 32, 32);
            gfxView_gfx.Size = new Size(gfxImg.Width * 2, gfxImg.Height * 2);
            gfxView_gfx.BackgroundImage = gfxImg;
        }

        private void comboBox_palette_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_palette.SelectedIndex == -1) { return; }
            DrawGfx();
        }

        // mouse events
        private Point gfxCursor;
        private Point resCursor;

        private Point gfxSelection;
        private Point resSelection;

        private void gfxView_result_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                // set new selection
                resSelection = resCursor;

                InitializeSelectedTile();
            }
        }

        private void gfxView_result_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X >> 4;
            int y = e.Y >> 4;
            if (x == resCursor.X && y == resCursor.Y) { return; }
            int w = gfxView_result.Width / 16;
            int h = gfxView_result.Height / 16;
            if (x < 0 || x >= w || y < 0 || y >= h) { return; }

            resCursor.X = x;
            resCursor.Y = y;

            // redraw red rectangle
            Rectangle rect = gfxView_result.redRect;
            gfxView_result.MoveRed(x, y);
            rect = Draw.Union(rect, gfxView_result.redRect);
            gfxView_result.Invalidate(rect);
        }

        private void gfxView_gfx_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                // set new selection
                gfxSelection = gfxCursor;

                // remove previous selection if necessary
                Rectangle rect = new Rectangle(gfxSelection.X * 16, gfxSelection.Y * 16, 16, 16);
                if (gfxView_gfx.selRect.X != -1)
                {
                    rect = Draw.Union(rect, gfxView_gfx.selRect);
                }
                gfxView_gfx.ResizeSelection(new Rectangle(gfxSelection.X, gfxSelection.Y, 1, 1));
                gfxView_gfx.Invalidate(rect);
            }
        }

        private void gfxView_gfx_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X >> 4;
            int y = e.Y >> 4;
            if (x == gfxCursor.X && y == gfxCursor.Y) { return; }
            if (x < 0 || x >= 32 || y < 0 || y >= gfxView_gfx.Height / 16) { return; }

            gfxCursor.X = x;
            gfxCursor.Y = y;

            // redraw red rectangle
            Rectangle rect = gfxView_gfx.redRect;
            gfxView_gfx.MoveRed(x, y);
            rect = Draw.Union(rect, gfxView_gfx.redRect);
            gfxView_gfx.Invalidate(rect);

            // tile number
            string text = "Tile: " + Hex.ToString(y * 32 + x);
            statusLabel_tile.Text = text;
        }

        #region tile events

        private void UpdatePalette(int corner, int delta)
        {
            int index = tileNums[corner];

            // set new palette number
            ushort tile = tileTable[index];
            int pal = ((tile >> 12) + delta) % 16;
            tileTable[index] = (ushort)(tile + 0x1000 * delta);

            // update text
            buttons_pal[corner].Text = Hex.ToString(pal);

            DrawTileChange(index, corner);
        }

        private void UpdateFlipX(int corner)
        {
            int index = tileNums[corner];

            // set new flip value
            ushort tile = tileTable[index];
            if ((tile & 0x400) == 0)
            {
                tileTable[index] = (ushort)(tile | 0x400);
                buttons_hflip[corner].Image = Properties.Resources.flip_h;
            }
            else
            {
                tileTable[index] = (ushort)(tile - 0x400);
                buttons_hflip[corner].Image = null;
            }

            DrawTileChange(index, corner);
        }

        private void UpdateFlipY(int corner)
        {
            int index = tileNums[corner];

            // set new flip value
            ushort tile = tileTable[index];
            if ((tile & 0x800) == 0)
            {
                tileTable[index] = (ushort)(tile | 0x800);
                buttons_vflip[corner].Image = Properties.Resources.flip_v;
            }
            else
            {
                tileTable[index] = (ushort)(tile - 0x800);
                buttons_vflip[corner].Image = null;
            }

            DrawTileChange(index, corner);
        }

        private void button_pal_MouseUp(object sender, MouseEventArgs e)
        {
            if (tileNums == null) { return; }

            int delta;
            if (e.Button == MouseButtons.Left)
            {
                delta = 1;
            }
            else if (e.Button == MouseButtons.Right)
            {
                delta = -1;
            }
            else { return; }

            int index = Array.IndexOf(buttons_pal, sender);
            UpdatePalette(index, delta);
        }

        private void button_hflip_Click(object sender, EventArgs e)
        {
            if (tileNums == null) { return; }

            int index = Array.IndexOf(buttons_hflip, sender);
            UpdateFlipX(index);
        }

        private void button_vflip_Click(object sender, EventArgs e)
        {
            if (tileNums == null) { return; }

            int index = Array.IndexOf(buttons_vflip, sender);
            UpdateFlipY(index);
        }

        private void gfxView_tile_MouseDown(object sender, MouseEventArgs e)
        {
            if (tileNums == null) { return; }
            if (gfxSelection.X == -1) { return;}

            // get corner
            int corner = 0;
            if (e.X >= 40) { corner++; }
            if (e.Y >= 40) { corner += 2; }
            int index = tileNums[corner];

            // set new tile value
            ushort tile = tileTable[index];
            int gfxNum = gfxSelection.Y * 32 + gfxSelection.X;
            gfxNum = (gfxNum + (int)numericUpDown_shift.Value) & 0x3FF;
            labels_tile[corner].Text = Hex.ToString(gfxNum);

            if (checkBox_copyPalette.Checked)
            {
                int pal = comboBox_palette.SelectedIndex;
                buttons_pal[corner].Text = Hex.ToString(pal);
                tileTable[index] = (ushort)(tile & 0xC00 | (pal << 12) | gfxNum);
            }
            else
            {
                tileTable[index] = (ushort)(tile & 0xFC00 | gfxNum);
            }

            DrawTileChange(index, corner);
        }

        #endregion

        private void Save()
        {
            bool shared = !checkBox_preserveData.Checked;

            if (tabControl.SelectedIndex == 0)
            {
                // tileset
                ByteStream dataToWrite = new ByteStream();
                dataToWrite.Write8(2);
                dataToWrite.Write8((byte)(numOfTiles / 64));

                foreach (ushort tile in tileTable)
                {
                    dataToWrite.Write16(tile);
                }

                int ptr = Version.TilesetOffset + comboBox_tileset.SelectedIndex * 0x14 + 0xC;
                romStream.Write(dataToWrite, origLen * 2 + 2, ptr, shared);
            }
            else if (tabControl.SelectedIndex == 1)
            {
                // background
                int length = tileTable.Length * 2;
                byte[] uncompTemp = new byte[length];
                Buffer.BlockCopy(tileTable, 0, uncompTemp, 0, length);
                ByteStream uncompData = new ByteStream(uncompTemp);

                // compress by LZ77
                ByteStream compData = new ByteStream();
                compData.Write32(comboBox_size.SelectedIndex);
                int newCompLen = Compress.CompLZ77(uncompData, length, compData);

                // get pointer
                int area = comboBox_area.SelectedIndex;
                int room = comboBox_room.SelectedIndex;
                int bg = comboBox_bg.SelectedIndex;
                int ptr = romStream.ReadPtr(Version.AreaHeaderOffset + area * 4) + (room * 0x3C);
                if (bg == 0)
                {
                    ptr += 8;
                }
                else
                {
                    ptr += 0x18;
                }

                // write data
                romStream.Write(compData, origLen, ptr, shared);
            }
            else if (tabControl.SelectedIndex == 2)
            {
                // offset
                int length = tileTable.Length * 2;
                byte[] uncompTemp = new byte[length];
                Buffer.BlockCopy(tileTable, 0, uncompTemp, 0, length);
                ByteStream uncompData = new ByteStream(uncompTemp);

                // compress by LZ77
                ByteStream compData = new ByteStream();
                int newCompLen = Compress.CompLZ77(uncompData, length, compData);

                // write data
                int prevOffset = ttbOffset;
                romStream.Write2(compData, origLen, ref ttbOffset, true);
                textBox_ttb.Text = Hex.ToString(ttbOffset);

                if (prevOffset != ttbOffset)
                {
                    //string message = "Tile table was repointed to " + Hex.ToString(ttbOffset);
                    //MessageBox.Show(message, "Repointed Tile Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string message = Properties.Resources.formTileTable_RepointMessage + Hex.ToString(ttbOffset);
                    MessageBox.Show(message, Properties.Resources.formTileTable_RepointTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            FormMain.UpdateEditors();
            status.Save();
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void statusStrip_importTileTable_Click(object sender, EventArgs e)
        {
            if (blank) { return; }

            OpenFileDialog openRaw = new OpenFileDialog();
            //openRaw.Filter = "All files (*.*)|*.*";
            openRaw.Filter = Properties.Resources.form_AllFilterText;
            if (openRaw.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] temp = System.IO.File.ReadAllBytes(openRaw.FileName);
                    numOfTiles = temp.Length / 2;
                    Array.Resize(ref tileTable, numOfTiles);
                    Buffer.BlockCopy(temp, 0, tileTable, 0, temp.Length);
                    Save();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.Message, Properties.Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                status.ChangeMade();
                status.Save();
            }
        }

        private void statusStrip_exportTileTable_Click(object sender, EventArgs e)
        {
            if (blank) { return; }

            SaveFileDialog saveRaw = new SaveFileDialog();
            //saveRaw.Filter = "All files (*.*)|*.*";
            saveRaw.Filter = Properties.Resources.form_AllFilterText;
            if (saveRaw.ShowDialog() == DialogResult.OK)
            {
                ByteStream output = new ByteStream();
                for (int i = 0; i < numOfTiles; i++)
                {
                    output.Write16(tileTable[i]);
                }

                output.Export(saveRaw.FileName);
            }
        }


    }
}
