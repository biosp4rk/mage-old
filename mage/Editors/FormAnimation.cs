using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace mage
{
    public partial class FormAnimation : Form, Editor
    {
        // fields
        private AnimTileset animTileset;
        private AnimGFX animGfx;
        private AnimPalette animPalette;

        // animation
        private int gfxState;
        private double gfxFrame;
        private int palState;
        private double palFrame;
        private Stopwatch sw;
        private Timer animTimer;

        private Palette grayPalette;
        private Bitmap gfxImg;
        private Palette palette;
        private FormMain main;
        private ByteStream romStream;
        private bool loading;

        private Status[] statuses;
        private string[] statusLabels;

        public FormAnimation(FormMain main, int window = 0, int number = 0)
        {
            InitializeComponent();

            this.main = main;
            this.romStream = ROM.Stream;

            Initialize(window, number);
        }

        public void UpdateEditor()
        {
            if (!statuses[0].UnsavedChanges)
            {
                LoadTileset();
            }
            if (!statuses[1].UnsavedChanges)
            {
                LoadGraphics();
            }
            if (!statuses[2].UnsavedChanges)
            {
                LoadPalette();
            }
        }

        private void Initialize(int window, int number)
        {
            // status
            statuses = new Status[3];
            statuses[0] = new Status(statusLabel_changes, button_tilesetApply);
            statuses[1] = new Status(statusLabel_changes, button_gfxApply);
            statuses[2] = new Status(statusLabel_changes, button_palApply);
            statusLabels = new string[] { "", "", "" };

            // initialize palettes to grayscale
            grayPalette = new Palette(1);
            for (int i = 1; i < 16; i++)
            {
                int val = 32 - i * 2;
                ushort argb = (ushort)(val | (val << 5) | (val << 10) | 0x8000);
                grayPalette.SetARGB(0, i, argb);
            }
            palette = grayPalette;

            // tileset
            int count = Version.NumOfAnimTilesets;
            for (int i = 0; i < count; i++)
            {
                comboBox_tilesetNum.Items.Add(Hex.ToString(i));
            }
            for (int i = 0; i < 16; i++)
            {
                comboBox_tilesetSlot.Items.Add(Hex.ToString(i));
            }          

            // graphics
            count = Version.NumOfAnimGfx;
            for (int i = 0; i < count; i++)
            {
                comboBox_tilesetGfxNum.Items.Add(Hex.ToString(i));
                comboBox_gfxNum.Items.Add(Hex.ToString(i));
            }
            comboBox_gfxView.SelectedIndex = 0;

            // palette
            count = Version.NumOfAnimPalettes;
            for (int i = 0; i < count; i++)
            {
                comboBox_palNum.Items.Add(Hex.ToString(i));
            }

            comboBox_tilesetNum.SelectedIndex = 0;
            comboBox_gfxNum.SelectedIndex = 0;
            comboBox_palNum.SelectedIndex = 0;

            tabControl.SelectedIndex = window;
            if (window == 0)
            {
                comboBox_tilesetNum.SelectedIndex = number;
            }
            else if (window == 1)
            {
                comboBox_gfxNum.SelectedIndex = number;
            }
            else
            {
                comboBox_palNum.SelectedIndex = number;
            }

            // animation
            ResetAnimation();
            sw = new Stopwatch();

            animTimer = new Timer();
            animTimer.Tick += new EventHandler(animTimer_Tick);
            animTimer.Interval = 33;
            animTimer.Start();
        }

        private void GetGfxPalette()
        {
            // palette offset
            try
            {
                int offset = Hex.ToInt(textBox_gfxPalOffset.Text);
                palette = new Palette(romStream, offset, 1);
            }
            catch
            {
                palette = grayPalette;
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            statusLabel_changes.Text = statusLabels[tabControl.SelectedIndex];
        }

        private void ResetAnimation()
        {
            gfxState = 0;
            gfxFrame = 0;
            palState = 0;
            palFrame = 0;
        }

        private void animTimer_Tick(object sender, EventArgs e)
        {
            double frames = sw.ElapsedMilliseconds * 0.06;
            sw.Reset();
            sw.Start();
            
            if (animGfx.type != 0 && animGfx.numStates > 0)
            {
                UpdateGraphics(frames);
            }

            if (animPalette.type != 0 && animPalette.rows > 0)
            {
                UpdatePalette(frames);
            }
        }

        private void UpdateGraphics(double frames)
        {
            gfxFrame += frames;
            if (gfxFrame > animGfx.delay)
            {
                gfxFrame %= animGfx.delay;
                if (animGfx.type == 1)
                {
                    gfxState = (gfxState + 1) % animGfx.numStates;
                    DrawGraphics(gfxState);
                }
                else if (animGfx.type == 4)
                {
                    gfxState = (gfxState + 1) % (animGfx.numStates * 2 - 2);
                    if (gfxState < animGfx.numStates)
                    {
                        DrawGraphics(gfxState);
                    }
                    else
                    {
                        int state = (animGfx.numStates * 2 - 2) - gfxState;
                        DrawGraphics(state);
                    }
                }
            }
        }

        private void UpdatePalette(double frames)
        {
            palFrame += frames;
            if (palFrame > animPalette.delay)
            {
                palFrame %= animPalette.delay;
                if (animPalette.type == 1)
                {
                    palState = (palState + 1) % animPalette.rows;
                    DrawPalette(palState);
                }
                else if (animPalette.type == 2)
                {
                    palState = (palState + 1) % (animPalette.rows * 2 - 1);
                    if (palState < animPalette.rows)
                    {
                        DrawPalette(palState);
                    }
                    else if (palState >= animPalette.rows + 1)
                    {
                        int row = (animPalette.rows * 2 - 1) - palState;
                        DrawPalette(row);
                    }
                }
            }
        }

        private void control_ValueChanged(object sender, EventArgs e)
        {
            if (loading) { return; }
            int tab = tabControl.SelectedIndex;
            statuses[tab].ChangeMade();
            statusLabels[tab] = statusLabel_changes.Text;
        }

        // tileset
        private void DrawTileset()
        {
            Bitmap image = new Bitmap(256, 16, PixelFormat.Format16bppRgb555);
            using (Graphics g = Graphics.FromImage(image))
            {
                for (int i = 0; i < 16; i++)
                {
                    int x = (i % 8) * 32;
                    int y = (i / 8) * 8;
                    Bitmap img = animTileset[i].gfx.Draw4bpp(palette, 0, true);
                    g.DrawImage(img, new Rectangle(x, y, 32, 8), new Rectangle(0, 0, 32, 8), GraphicsUnit.Pixel);
                }
            }
            pictureBox_tileset.Image = image;
        }

        private void comboBox_tilesetNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTileset();

            statuses[0].LoadNew();
            statusLabels[0] = statusLabel_changes.Text;
        }

        private void LoadTileset()
        {
            byte num = (byte)comboBox_tilesetNum.SelectedIndex;
            animTileset = new AnimTileset(romStream, num);
            DrawTileset();
            if (comboBox_tilesetSlot.SelectedIndex == 0)
            {
                UpdateTilesetSlot(0);
            }
            else
            {
                comboBox_tilesetSlot.SelectedIndex = 0;
            }
        }

        private void comboBox_tilesetSlot_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTilesetSlot(comboBox_tilesetSlot.SelectedIndex);
        }

        private void UpdateTilesetSlot(int index)
        {
            loading = true;
            int num = comboBox_tilesetSlot.SelectedIndex;
            comboBox_tilesetGfxNum.SelectedIndex = animTileset[num].number;
            loading = false;
        }

        private void comboBox_tilesetGfxNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) { return; }
            // update and redraw
            int slot = comboBox_tilesetSlot.SelectedIndex;
            byte num = (byte)comboBox_tilesetGfxNum.SelectedIndex;
            animTileset[slot] = new AnimGFX(romStream, num);
            DrawTileset();

            statuses[0].ChangeMade();
            statusLabels[0] = statusLabel_changes.Text;
        }

        private void button_tilesetApply_Click(object sender, EventArgs e)
        {
            int offset = Version.AnimTilesetOffset + animTileset.number * 0x30;

            for (int i = 0; i < 16; i++)
            {
                romStream.Write8(offset + i * 3, animTileset[i].number);
            }

            FormMain.UpdateEditors();
            statuses[0].Save();
            statusLabels[0] = statusLabel_changes.Text;
        }

        private void button_tilesetClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // graphics
        private void DrawGraphics(int state)
        {
            int offset = animGfx.gfx.Offset + 0x80 * state;
            GFX gfx;
            if (comboBox_gfxView.SelectedIndex == 0)
            {
                gfx = new GFX(romStream, offset, 2, 2);
                gfxView_gfx.Size = new Size(32, 32);
            }
            else
            {
                gfx = new GFX(romStream, offset, 4, 1);
                gfxView_gfx.Size = new Size(64, 16);
            }

            gfxView_gfx.BackgroundImage = gfx.Draw4bpp(palette, 0, true);
        }

        private void comboBox_gfxNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGraphics();

            statuses[1].LoadNew();
            statusLabels[1] = statusLabel_changes.Text;
        }

        private void LoadGraphics()
        {
            loading = true;

            byte num = (byte)comboBox_gfxNum.SelectedIndex;
            animGfx = new AnimGFX(romStream, num);

            // display info
            switch (animGfx.type)
            {
                case 1:
                    comboBox_gfxDirection.SelectedIndex = 1;
                    break;
                case 4:
                    comboBox_gfxDirection.SelectedIndex = 2;
                    break;
                default:
                    comboBox_gfxDirection.SelectedIndex = 0;
                    break;
            }
            textBox_gfxDelay.Text = Hex.ToString(animGfx.delay);
            textBox_gfxStates.Text = Hex.ToString(animGfx.numStates);

            // draw
            gfxImg = animGfx.gfx.Draw4bpp(palette, 0, true);
            DrawGraphics(0);
            ResetAnimation();

            loading = false;
        }

        private void comboBox_gfxView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (animGfx != null && animGfx.type == 0)
            {
                DrawGraphics(0);
            }
        }

        private void textBox_gfxPalOffset_TextChanged(object sender, EventArgs e)
        {
            GetGfxPalette();
            if (animGfx.type == 0)
            {
                DrawGraphics(0);
            }
        }

        private void button_gfxEdit_Click(object sender, EventArgs e)
        {
            int height = Math.Max(1, Math.Min(32, (int)animGfx.numStates));
            int palOffset = palette.Offset;
            if (palette.Offset == 0)
            {
                palOffset = Version.GenericBgPaletteOffset;
            }
            FormGraphics form = new FormGraphics(main, animGfx.gfx.Offset, 4, height, palOffset);
            form.Show();
        }

        private void button_gfxApply_Click(object sender, EventArgs e)
        {
            try
            {
                byte type = (byte)comboBox_gfxDirection.SelectedIndex;
                if (type == 2) { type = 4; }
                byte delay = Hex.ToByte(textBox_gfxDelay.Text);
                byte states = Hex.ToByte(textBox_gfxStates.Text);

                // write
                byte number = animGfx.number;
                int offset = Version.AnimGfxOffset + number * 8;
                romStream.Write8(offset, type);
                romStream.Write8(offset + 1, delay);
                romStream.Write8(offset + 2, states);

                animGfx = new AnimGFX(romStream, number);
                gfxImg = animGfx.gfx.Draw4bpp(palette, 0, true);
                // TODO: scale
                DrawGraphics(0);
                ResetAnimation();

                FormMain.UpdateEditors();
                statuses[1].Save();
                statusLabels[1] = statusLabel_changes.Text;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("One of the values entered was not valid.\n\n" + ex.Message,
                //        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(Properties.Resources.form_OneValueNotValidErrorText + ex.Message,
                        Properties.Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_gfxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // palette
        private void DrawPalette(int row)
        {
            pictureBox_pal.Image = animPalette.palette.Draw(15, row, 1);
            pictureBox_pal.Invalidate();
        }

        private void comboBox_paletteNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPalette();

            statuses[2].LoadNew();
            statusLabels[2] = statusLabel_changes.Text;
        }

        private void LoadPalette()
        {
            loading = true;

            byte num = (byte)comboBox_palNum.SelectedIndex;
            animPalette = new AnimPalette(romStream, num);

            // display info
            switch (animPalette.type)
            {
                case 1:
                    comboBox_palDirection.SelectedIndex = 1;
                    break;
                case 2:
                    comboBox_palDirection.SelectedIndex = 2;
                    break;
                default:
                    comboBox_palDirection.SelectedIndex = 0;
                    break;
            }
            textBox_palDelay.Text = Hex.ToString(animPalette.delay);
            textBox_palStates.Text = Hex.ToString(animPalette.rows);

            // draw
            DrawPalette(0);
            ResetAnimation();

            loading = false;
        }

        private void button_palEdit_Click(object sender, EventArgs e)
        {
            FormPalette form = new FormPalette(main, animPalette.palette.Offset, animPalette.rows);
            form.Show();
        }

        private void button_palApply_Click(object sender, EventArgs e)
        {
            try
            {
                byte type = (byte)comboBox_palDirection.SelectedIndex;
                byte delay = Hex.ToByte(textBox_palDelay.Text);
                byte rows = Hex.ToByte(textBox_palStates.Text);

                // write
                byte number = animPalette.number;
                int offset = Version.AnimPaletteOffset + number * 8;
                romStream.Write8(offset, type);
                romStream.Write8(offset + 1, delay);
                romStream.Write8(offset + 2, rows);

                animPalette = new AnimPalette(romStream, number);               
                DrawPalette(0);
                ResetAnimation();

                FormMain.UpdateEditors();
                statuses[2].Save();
                statusLabels[2] = statusLabel_changes.Text;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("One of the values entered was not valid.\n\n" + ex.Message,
                //        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(Properties.Resources.form_OneValueNotValidErrorText + ex.Message,
                        Properties.Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_palClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
