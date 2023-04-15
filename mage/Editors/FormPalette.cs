using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace mage
{
    public enum PalFileType { Raw, YYCHR, TLP }

    public partial class FormPalette : Form
    {
        // fields
        private Color currColor;
        private byte red, green, blue;
        private Point pos;
        private bool noUpdate;
        private Pen wp, bp;

        private Palette palette;
        private int currOffset;
        private bool[,] modifiedColors;

        private FormMain main;
        private ByteStream romStream;
        private Status status;

        // constructor (tileset/sprite)
        public FormPalette(FormMain main, bool tileset, byte value)
        {
            InitializeComponent();

            this.main = main;
            Initialize();

            if (tileset)
            {
                comboBox_tileset.SelectedIndex = value;
            }
            else
            {
                comboBox_sprite.SelectedIndex = value;
            }
        }

        // constructor (offset)
        public FormPalette(FormMain main, int offset, int rows)
        {
            InitializeComponent();

            this.main = main;

            numericUpDown_rows.Value = rows;
            textBox_offset.Text = Hex.ToString(offset);
            Initialize();
            LoadPalette();
        }

        private void Initialize()
        {
            status = new Status(statusLabel_changes, button_apply);
            romStream = ROM.Stream;
            pos = new Point(-1, -1);

            // initialize pens
            wp = new Pen(Color.White);
            bp = new Pen(Color.Black);
            wp.DashPattern = bp.DashPattern = new float[] { 2, 2 };
            bp.DashOffset = 2;

            // set number base
            if (!Hex.ToHex)
            {
                numericUpDown_red.Hexadecimal = false;
                numericUpDown_green.Hexadecimal = false;
                numericUpDown_blue.Hexadecimal = false;
            }

            // initialize sprite and tileset lists
            int numOfSprites = Version.NumOfSprites1;
            for (int i = 0; i < numOfSprites; i++)
            {
                comboBox_sprite.Items.Add(Hex.ToString(i));
            }
            int numOfTilesets = Version.NumOfTilesets;
            for (int i = 0; i < numOfTilesets; i++)
            {
                comboBox_tileset.Items.Add(Hex.ToString(i));
            }
        }

        private void comboBox_tileset_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte ts = (byte)comboBox_tileset.SelectedIndex;
            int headerOffset = Version.TilesetOffset + ts * 0x14;
            int BGpaletteOffset = romStream.ReadPtr(headerOffset + 0x4);

            textBox_offset.Text = Hex.ToString(BGpaletteOffset);
            numericUpDown_rows.Value = 14;
            LoadPalette();
        }

        private void comboBox_sprite_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte spriteID = (byte)comboBox_sprite.SelectedIndex;
            if (spriteID < 0x10) { return; }

            // TODO: reuse code
            int addVal = (spriteID - 0x10) * 4;
            
            // get gfx rows
            int numGfxRows;
            if (Version.IsMF)
            {
                int offset = Version.SpriteGfxRowsOffset + addVal;
                numGfxRows = romStream.Read16(offset) / 0x800;
            }
            else
            {
                int offset = Version.SpriteGfxOffset + addVal;
                int gfxOffset = romStream.ReadPtr(offset);
                numGfxRows = Math.Max(romStream.Read16(gfxOffset + 1) / 0x800, 1);
            }

            // get palette
            int palPtr = Version.SpritePaletteOffset + addVal;
            int palOffset = romStream.ReadPtr(palPtr);
            // code to move ends here

            textBox_offset.Text = Hex.ToString(palOffset);
            numericUpDown_rows.Value = numGfxRows;
            LoadPalette();
        }

        private void button_go_Click(object sender, EventArgs e)
        {
            LoadPalette();
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            textBox_offset.Text = Hex.ToString(Hex.ToInt(textBox_offset.Text) + 0x20);
            LoadPalette();
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            textBox_offset.Text = Hex.ToString(Hex.ToInt(textBox_offset.Text) - 0x20);
            LoadPalette();
        }

        private void LoadPalette()
        {
            try
            {
                int offset = Hex.ToInt(textBox_offset.Text);
                int rows = (int)numericUpDown_rows.Value;

                palette = new Palette(romStream, offset, rows);
                modifiedColors = new bool[rows, 16];
                currOffset = offset;
                DrawPalette();
                status.LoadNew();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("The offset entered was not valid.\n\n" + ex.GetType().ToString() + '\n'
                //        + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(Properties.Resources.formGFX_OffsetNotValidErrorText + ex.GetType().ToString() + '\n'
                        + ex.Message, Properties.Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DrawPalette()
        {
            // reset info
            pos = new Point(-1, -1);
            pictureBox_palette.Image = null;
            pictureBox_chosenColor.Image = null;
            groupBox_color.Enabled = false;
            pictureBox_red.Image = null;
            pictureBox_green.Image = null;
            pictureBox_blue.Image = null;

            numericUpDown_red.Value = 0;
            numericUpDown_green.Value = 0;
            numericUpDown_blue.Value = 0;

            label_15bitVal.Text = "";
            label_24bitVal.Text = "";

            if (palette == null) { return; }

            int rows = palette.Rows;

            // display
            pictureBox_palette.Image = palette.Draw(16, 0, palette.Rows);
        }

        #region selected color drawing

        private void ColorChanged()
        {
            // return if no color selected
            if (pos.X == -1) { return; }

            // update palette
            currColor = Color.FromArgb(red * 8, green * 8, blue * 8);
            ushort argb = (ushort)((red << 10) | (green << 5) | blue);
            if (pos.X != 0) { argb |= 0x8000; }
            palette.SetARGB(pos.Y, pos.X, argb);
            modifiedColors[pos.Y, pos.X] = true;

            UpdateTextValues();

            // redraw color bars
            DrawColorBar();

            // redraw chosen color
            DrawChosenColor();

            // redraw on palette image
            RedrawSquare();
            DrawRectangle();

            status.ChangeMade();
        }

        private void UpdateTextValues()
        {
            // GBA
            int val = red + (green << 5) + (blue << 10);
            string temp = Convert.ToString(val, 16).ToUpper();
            while (temp.Length < 4)
            {
                temp = "0" + temp;
            }
            label_15bitVal.Text = "0x" + temp;

            // PC
            label_24bitVal.Text = (red * 8) + ", " + (green * 8) + ", " + (blue * 8);
        }

        private void DrawChosenColor()
        {
            pictureBox_chosenColor.Image = new Bitmap(40, 40);
            using (Graphics g = Graphics.FromImage(pictureBox_chosenColor.Image))
            {
                SolidBrush b = new SolidBrush(currColor);
                g.FillRectangle(b, new Rectangle(0, 0, 40, 40));
            }
        }

        private unsafe void DrawColorBar()
        {
            Bitmap imgR = new Bitmap(128, 20, PixelFormat.Format32bppRgb);
            Bitmap imgG = new Bitmap(128, 20, PixelFormat.Format32bppRgb);
            Bitmap imgB = new Bitmap(128, 20, PixelFormat.Format32bppRgb);

            Rectangle rect = new Rectangle(0, 0, 128, 20);
            BitmapData imgDataR = imgR.LockBits(rect, ImageLockMode.WriteOnly, imgR.PixelFormat);
            BitmapData imgDataG = imgG.LockBits(rect, ImageLockMode.WriteOnly, imgG.PixelFormat);
            BitmapData imgDataB = imgB.LockBits(rect, ImageLockMode.WriteOnly, imgB.PixelFormat);

            int baseR = (green << 11) | (blue << 3);
            int baseG = (red << 19) | (blue << 3);
            int baseB = (red << 19) | (green << 11);

            int* imgPtrR = (int*)imgDataR.Scan0;
            int* imgPtrG = (int*)imgDataG.Scan0;
            int* imgPtrB = (int*)imgDataB.Scan0;

            for (int i = 0; i < 20; i++)
            {
                for (int c = 0; c < 128; c++)
                {
                    *imgPtrR++ = baseR | (c << 17);
                    *imgPtrG++ = baseG | (c << 9);
                    *imgPtrB++ = baseB | (c << 1);
                }
            }

            DrawLine(imgDataR, red);
            DrawLine(imgDataG, green);
            DrawLine(imgDataB, blue);

            imgR.UnlockBits(imgDataR);
            imgG.UnlockBits(imgDataG);
            imgB.UnlockBits(imgDataB);

            pictureBox_red.Image = imgR;
            pictureBox_green.Image = imgG;
            pictureBox_blue.Image = imgB;
        }

        private unsafe void DrawLine(BitmapData imgData, int color)
        {
            int* imgPtr = (int*)imgData.Scan0 + color * 4;

            for (int y = 0; y < 10; y++)
            {
                int val = 0x111111 * (y + 6);
                for (int x = 0; x < 4; x++)
                {
                    *imgPtr++ = val;
                }
                imgPtr += 124;
            }
            for (int y = 0; y < 10; y++)
            {
                int val = 0x111111 * (15 - y);
                for (int x = 0; x < 4; x++)
                {
                    *imgPtr++ = val;
                }
                imgPtr += 124;
            }
        }

        private void RedrawSquare()
        {
            if (pos.X != -1)
            {
                using (Graphics g = Graphics.FromImage(pictureBox_palette.Image))
                {
                    SolidBrush b = new SolidBrush(currColor);
                    g.FillRectangle(b, new Rectangle(pos.X * 16 + pos.X + 1, pos.Y * 16 + pos.Y + 1, 16, 16));
                }
            }
        }

        private void DrawRectangle()
        {
            using (Graphics g = Graphics.FromImage(pictureBox_palette.Image))
            {
                g.DrawRectangle(bp, pos.X * 16 + pos.X + 1, pos.Y * 16 + pos.Y + 1, 15, 15);
                g.DrawRectangle(wp, pos.X * 16 + pos.X + 1, pos.Y * 16 + pos.Y + 1, 15, 15);
            }
            pictureBox_palette.Invalidate();
        }

        #endregion

        #region rgb control events

        private void pictureBox_palette_MouseClick(object sender, MouseEventArgs e)
        {
            Point newPos = new Point((e.X - 1) / 17, (e.Y - 1) / 17);
            if ((pos == newPos) || newPos.Y >= palette.Rows) { return; }

            // redraw previous and new selection
            RedrawSquare();
            pos = newPos;
            DrawRectangle();

            // set rgb values
            currColor = palette.GetOpaqueColor(pos.Y, pos.X);

            noUpdate = true;
            red = (byte)(currColor.R / 8);
            green = (byte)(currColor.G / 8);
            blue = (byte)(currColor.B / 8);

            numericUpDown_red.Value = red;
            numericUpDown_green.Value = green;
            numericUpDown_blue.Value = blue;
            noUpdate = false;

            // update color displays
            DrawColorBar();
            DrawChosenColor();

            UpdateTextValues();
            groupBox_color.Enabled = true;
        }

        private void numericUpDown_red_ValueChanged(object sender, EventArgs e)
        {
            red = (byte)numericUpDown_red.Value;
            if (!noUpdate) { ColorChanged(); }
        }

        private void numericUpDown_green_ValueChanged(object sender, EventArgs e)
        {
            green = (byte)numericUpDown_green.Value;
            if (!noUpdate) { ColorChanged(); }
        }

        private void numericUpDown_blue_ValueChanged(object sender, EventArgs e)
        {
            blue = (byte)numericUpDown_blue.Value;
            if (!noUpdate) { ColorChanged(); }
        }

        private void CheckUpdateColor(MouseEventArgs e, NumericUpDown nud)
        {
            if (e.Button == MouseButtons.Left)
            {
                byte newColor = (byte)(e.X / 4);
                if (newColor >= 0 && newColor < 32 && nud.Value != newColor)
                {
                    nud.Value = newColor;
                }
            }
        }

        private void pictureBox_red_MouseDown(object sender, MouseEventArgs e)
        {
            CheckUpdateColor(e, numericUpDown_red);
        }

        private void pictureBox_red_MouseMove(object sender, MouseEventArgs e)
        {
            CheckUpdateColor(e, numericUpDown_red);
        }

        private void pictureBox_green_MouseDown(object sender, MouseEventArgs e)
        {
            CheckUpdateColor(e, numericUpDown_green);
        }

        private void pictureBox_green_MouseMove(object sender, MouseEventArgs e)
        {
            CheckUpdateColor(e, numericUpDown_green);
        }

        private void pictureBox_blue_MouseDown(object sender, MouseEventArgs e)
        {
            CheckUpdateColor(e, numericUpDown_blue);
        }

        private void pictureBox_blue_MouseMove(object sender, MouseEventArgs e)
        {
            CheckUpdateColor(e, numericUpDown_blue);
        }

        #endregion

        private void button_apply_Click(object sender, EventArgs e)
        {
            // write
            palette.Write(romStream, modifiedColors);

            // update editors
            FormMain.UpdateEditors();

            status.Save();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region import/export

        private void statusStrip_importRaw_Click(object sender, EventArgs e)
        {
            Import(PalFileType.Raw);
        }

        private void statusStrip_importTLP_Click(object sender, EventArgs e)
        {
            Import(PalFileType.TLP);
        }

        private void statusStrip_importYY_Click(object sender, EventArgs e)
        {
            Import(PalFileType.YYCHR);
        }

        private void statusStrip_exportRaw_Click(object sender, EventArgs e)
        {
            Export(PalFileType.Raw);
        }

        private void statusStrip_exportTLP_Click(object sender, EventArgs e)
        {
            Export(PalFileType.TLP);
        }

        private void statusStrip_exportYY_Click(object sender, EventArgs e)
        {
            Export(PalFileType.YYCHR);
        }

        private void Import(PalFileType type)
        {
            OpenFileDialog import = new OpenFileDialog();
            import.Filter = GetFileFilter(type);
            if (import.ShowDialog() == DialogResult.OK)
            {
                palette.Import(import.FileName, type);
                palette.Write(romStream);
                DrawPalette();

                status.Import();
            }
        }

        private void Export(PalFileType type)
        {
            SaveFileDialog export = new SaveFileDialog();
            export.Filter = GetFileFilter(type);
            if (export.ShowDialog() == DialogResult.OK)
            {
                palette.Export(export.FileName, type);
            }
        }

        public static string GetFileFilter(PalFileType type)
        {
            //string allFiles = "All files (*.*)|*.*";
            string allFiles = Properties.Resources.form_AllFilterText;
            switch (type)
            {
                case PalFileType.Raw:
                    return allFiles;
                case PalFileType.YYCHR:
                    //return $"YY-CHR palette (*.pal)|*.pal|{allFiles}";
                    return $"{Properties.Resources.formPalette_YYCHRFilterText}|{allFiles}";
                case PalFileType.TLP:
                    //return $"Tile Layer Pro palette (*.tpl)|*.tpl|{allFiles}";
                    return $"{Properties.Resources.formPalette_TLPFilterText}|{allFiles}";
            }
            throw new FormatException();
        }

        #endregion

    }
}
