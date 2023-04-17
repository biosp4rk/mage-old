using System;
using System.Windows.Forms;
using mage.Properties;

namespace mage
{
    public partial class FormTileBuilder : Form
    {
        private GFX tileGFX;
        private Palette palette;
        private int number;

        private ComboBox[] sides;
        private bool loading;

        private FormMain main;
        private ByteStream romStream;

        public FormTileBuilder(FormMain main, int number = 0)
        {
            InitializeComponent();

            this.main = main;
            this.romStream = ROM.Stream;
            this.number = number;

            Initialize();
        }

        private void Initialize()
        {
            sides = new ComboBox[] { comboBox_T, comboBox_B, comboBox_L, comboBox_R };

            // fill in comboboxes
            //string[] allSides = new string[] { "Nothing", "Wall", "Connection" };
            string[] allSides = new string[] { Resources.formTileBuilder_ComboBoxItem0, Resources.formTileBuilder_ComboBoxSideWall, Resources.formTileBuilder_ComboBoxSideConn };
            comboBox_T.Items.AddRange(allSides);
            comboBox_B.Items.AddRange(allSides);
            comboBox_L.Items.AddRange(allSides);
            comboBox_R.Items.AddRange(allSides);

            //string[] allCenter = new string[] { "Nothing", "Unobtained tank", "Obtained tank" };
            string[] allCenter = new string[] { Resources.formTileBuilder_ComboBoxItem0, Resources.formTileBuilder_ComboBoxCenterUn, Resources.formTileBuilder_ComboBoxCenterObtain };
            comboBox_center.Items.AddRange(allCenter);

            comboBox_palette.Items.AddRange(new object[] { 0, 1, 2 });

            numericUpDown_tile.Maximum = 0x1FF;

            if (Version.IsMF)
            {
                //string[] hatches = new string[] { "Blue hatch", "Green hatch", "Yellow hatch", "Red hatch" };
                string[] hatches = new string[] { Resources.formTileBuilder_ComboBoxSideBlue, Resources.formTileBuilder_ComboBoxSideGreen,
                    Resources.formTileBuilder_ComboBoxSideYellow, Resources.formTileBuilder_ComboBoxSideRed };
                comboBox_L.Items.AddRange(hatches);
                comboBox_R.Items.AddRange(hatches);

                //string[] center = new string[] { "Navigation room", "Save room", "Recharge room", "Data room" };
                string[] center = new string[] { Resources.formTileBuilder_ComboBoxCenterSave, Resources.formTileBuilder_ComboBoxCenterNav,
                    Resources.formTileBuilder_ComboBoxCenterRe, Resources.formTileBuilder_ComboBoxCenterData };
                comboBox_center.Items.AddRange(center);

                Patch p = new Patch(Properties.Resources.MF_U_addMinimapTiles);
                if (!p.IsApplied()) { numericUpDown_tile.Maximum = 0x1BF; }
            }
            else
            {
                //string[] hatches = new string[] { "Normal hatch", "Missile hatch", "Super missile hatch", "Power bomb hatch" };
                string[] hatches = new string[] { Resources.formTileBuilder_ComboBoxSideNormal, Resources.formTileBuilder_ComboBoxSideMissile,
                    Resources.formTileBuilder_ComboBoxSideSuper, Resources.formTileBuilder_ComboBoxSidePower };
                comboBox_L.Items.AddRange(hatches);
                comboBox_R.Items.AddRange(hatches);

                //string[] center = new string[] { "Save room", "Map room", "Item room", "Chozo statue" };
                string[] center = new string[] { Resources.formTileBuilder_ComboBoxCenterSave, Resources.formTileBuilder_ComboBoxCenterMap,
                    Resources.formTileBuilder_ComboBoxCenterItem, Resources.formTileBuilder_ComboBoxCenterChozo };
                comboBox_center.Items.AddRange(center);

                comboBox_palette.Items.AddRange(new object[] { 3, 4 });

                Patch p = new Patch(Properties.Resources.ZM_U_addMinimapTiles);
                if (!p.IsApplied()) { numericUpDown_tile.Maximum = 0x17F; }
            }

            loading = true;
            comboBox_T.SelectedIndex = 0;
            comboBox_B.SelectedIndex = 0;
            comboBox_L.SelectedIndex = 0;
            comboBox_R.SelectedIndex = 0;
            comboBox_center.SelectedIndex = 0;
            comboBox_palette.SelectedIndex = 1;
            loading = false;

            // get tile graphics
            palette = new Palette(romStream, Version.MinimapPaletteOffset, 5);
            if (numericUpDown_tile.Value == number)
            {
                LoadTile();
            }
            else
            {
                numericUpDown_tile.Value = number;
            }
        }

        private void RedrawTile()
        {
            byte[] data = tileGFX.data;
            for (int i = 0; i < 0x20; i++)
            {
                data[i] = 0x33;
            }

            // corners
            if (checkBox_TL.Checked) { SetPixel(1, 0, 0); }
            if (checkBox_TR.Checked) { SetPixel(1, 7, 0); }
            if (checkBox_BL.Checked) { SetPixel(1, 0, 7); }
            if (checkBox_BR.Checked) { SetPixel(1, 7, 7); }

            // sides
            for (byte w = 0; w < 4; w++)
            {
                /*switch (sides[w].Text)
                {
                    case "Wall":
                        DrawWall(w);
                        break;
                    case "Connection":
                        DrawConnection(w);
                        break;
                    case "Blue hatch":
                        DrawHatchMF(8, w);
                        break;
                    case "Green hatch":
                        DrawHatchMF(9, w);
                        break;
                    case "Yellow hatch":
                        DrawHatchMF(0xB, w);
                        break;
                    case "Red hatch":
                        DrawHatchMF(0xA, w);
                        break;
                    case "Normal hatch":
                        DrawHatchZM(8, w);
                        break;
                    case "Missile hatch":
                        DrawHatchZM(0xA, w);
                        break;
                    case "Super missile hatch":
                        DrawHatchZM(0x9, w);
                        break;
                    case "Power bomb hatch":
                        DrawHatchZM(0xB, w);
                        break;
                }*/

                // use SelectIndex avoid hard code 
                switch (sides[w].SelectedIndex)
                {
                    case 1:
                        DrawWall(w);
                        break;
                    case 2:
                        DrawConnection(w);
                        break;
                    case 3: //MF -> blue hatch, ZM -> normal hatch
                        if (Version.IsMF) DrawHatchMF(8, w);
                        else DrawHatchZM(8, w);
                        break;
                    case 4: //MF -> green hatch, ZM -> missile hatch
                        if (Version.IsMF) DrawHatchMF(9, w);
                        else DrawHatchZM(0xA, w);
                        break;
                    case 5: //MF -> yellow hatch, ZM -> super missile hatch
                        if (Version.IsMF) DrawHatchMF(0xB, w);
                        else DrawHatchZM(0x9, w);
                        break;
                    case 6: //MF -> red hatch, ZM -> power bomb hatch
                        if (Version.IsMF) DrawHatchMF(0xA, w);
                        else DrawHatchZM(0xB, w);
                        break;
                }
            }

            // center
            /*switch (comboBox_center.Text)
            {
                case "Unobtained tank":
                    DrawUnobtainedTank();
                    break;
                case "Obtained tank":
                    DrawObtainedTank();
                    break;
                case "Navigation room":
                    DrawNavRoom();
                    break;
                case "Save room":
                    DrawSaveRoom();
                    break;
                case "Recharge room":
                    DrawRechargeRoom();
                    break;
                case "Data room":
                    DrawDataRoom();
                    break;
                case "Map room":
                    DrawMapRoom();
                    break;
                case "Item room":
                    DrawItemRoom();
                    break;
                case "Chozo statue":
                    DrawChozoStatue();
                    break;
            }*/

            // use SelectIndex avoid hard code 
            switch (comboBox_center.SelectedIndex)
            {
                case 1:
                    DrawUnobtainedTank();
                    break;
                case 2:
                    DrawObtainedTank();
                    break;
                case 3:
                    DrawSaveRoom();
                    break;
                case 4:
                    if(Version.IsMF) DrawNavRoom();
                    else DrawMapRoom();
                    break;
                case 5:
                    if(Version.IsMF) DrawRechargeRoom();
                    else DrawItemRoom();
                    break;
                case 6:
                    if(Version.IsMF) DrawDataRoom();
                    else DrawChozoStatue();
                    break;
            }

            // draw
            int pal = comboBox_palette.SelectedIndex;
            gfxView_tile.BackgroundImage = tileGFX.Draw4bpp(palette, pal, true);
        }

        private void SetPixel(byte val, byte x, byte y)
        {
            int index = (y * 8 + x) / 2;
            if (x % 2 == 0)
            {
                tileGFX.data[index] = (byte)(tileGFX.data[index] & 0xF0 | val);
            }
            else
            {
                tileGFX.data[index] = (byte)(tileGFX.data[index] & 0xF | (val << 4));
            }
        }

        private void DrawWall(byte wall)
        {
            // 0 = T; 1 = B; 2 = L; 3 = R
            byte k = 0;
            if (wall % 2 == 1)
            {
                k = 7;
            }

            if (wall < 2)
            {
                for (byte x = 0; x < 8; x++)
                {
                    SetPixel(1, x, k);
                }
            }
            else
            {
                for (byte y = 0; y < 8; y++)
                {
                    SetPixel(1, k, y);
                }
            }
        }

        private void DrawConnection(byte wall)
        {
            DrawWall(wall);

            if (wall == 0)
            {
                SetPixel(2, 3, 0);
                SetPixel(2, 4, 0);
            }
            else if (wall == 1)
            {
                SetPixel(2, 3, 7);
                SetPixel(2, 4, 7);
            }
            else if (wall == 2)
            {
                SetPixel(2, 0, 3);
                SetPixel(2, 0, 4);
            }
            else
            {
                SetPixel(2, 7, 3);
                SetPixel(2, 7, 4);
            }
        }

        private void DrawHatchMF(byte val, byte wall)
        {
            DrawWall(wall);

            byte val2 = (byte)(val + 4);
            if (wall == 2)
            {
                SetPixel(val, 0, 3);
                SetPixel(val, 0, 4);
                SetPixel(val2, 1, 2);
                SetPixel(val2, 1, 3);
                SetPixel(val2, 1, 4);
                SetPixel(val2, 1, 5);
            }
            else
            {
                SetPixel(val, 7, 3);
                SetPixel(val, 7, 4);
                SetPixel(val2, 6, 2);
                SetPixel(val2, 6, 3);
                SetPixel(val2, 6, 4);
                SetPixel(val2, 6, 5);
            }
        }

        private void DrawHatchZM(byte val, byte wall)
        {
            DrawWall(wall);

            byte val2 = (byte)(val + 4);
            if (wall == 2)
            {
                SetPixel(val, 0, 3);
                SetPixel(val, 0, 4);
                SetPixel(6, 1, 2);
                SetPixel(val2, 1, 3);
                SetPixel(val2, 1, 4);
                SetPixel(6, 1, 5);
            }
            else
            {
                SetPixel(val, 7, 3);
                SetPixel(val, 7, 4);
                SetPixel(6, 6, 2);
                SetPixel(val2, 6, 3);
                SetPixel(val2, 6, 4);
                SetPixel(6, 6, 5);
            }
        }

        private void DrawUnobtainedTank()
        {
            SetPixel(6, 3, 2);
            SetPixel(6, 4, 2);
            SetPixel(6, 3, 5);
            SetPixel(6, 4, 5);
            SetPixel(6, 2, 3);
            SetPixel(6, 2, 4);
            SetPixel(6, 5, 3);
            SetPixel(6, 5, 4);
        }

        private void DrawObtainedTank()
        {
            SetPixel(6, 3, 3);
            SetPixel(6, 3, 4);
            SetPixel(6, 4, 3);
            SetPixel(6, 4, 4);
        }

        private void DrawRoom()
        {
            // draw top and bottom
            for (byte x = 0; x < 8; x++)
            {
                SetPixel(0xA, x, 0);
                SetPixel(0xA, x, 7);
            }
            SetPixel(0xA, 0, 1);
            SetPixel(0xA, 7, 1);
            SetPixel(0xA, 0, 6);
            SetPixel(0xA, 7, 6);

            // check for walls
            if (comboBox_L.SelectedIndex == 1)
            {
                for (byte y = 2; y < 6; y++)
                {
                    SetPixel(0xA, 0, y);
                }
            }
            else
            {
                for (byte y = 2; y < 6; y++)
                {
                    SetPixel(3, 1, y);
                }
            }
            // check for walls
            if (comboBox_R.SelectedIndex == 1)
            {
                for (byte y = 2; y < 6; y++)
                {
                    SetPixel(0xA, 7, y);
                }
            }
            else
            {
                for (byte y = 2; y < 6; y++)
                {
                    SetPixel(3, 6, y);
                }
            }
        }

        private void DrawNavRoom()
        {
            DrawRoom();

            // draw "N"
            for (byte y = 2; y < 6; y++)
            {
                SetPixel(7, 2, y);
                SetPixel(7, 5, y);
            }
            SetPixel(7, 3, 3);
            SetPixel(7, 4, 4);
        }

        private void DrawSaveRoom()
        {
            DrawRoom();

            // draw "S"
            SetPixel(7, 3, 2);
            SetPixel(7, 4, 2);
            SetPixel(7, 5, 2);
            SetPixel(7, 2, 3);
            SetPixel(7, 3, 4);
            SetPixel(7, 4, 4);
            SetPixel(7, 5, 5);
            SetPixel(7, 2, 6);
            SetPixel(7, 3, 6);
            SetPixel(7, 4, 6);
        }

        private void DrawRechargeRoom()
        {
            DrawRoom();

            // draw "R"
            SetPixel(7, 2, 2);
            SetPixel(7, 3, 2);
            SetPixel(7, 4, 2);
            SetPixel(7, 2, 3);
            SetPixel(7, 5, 3);
            SetPixel(7, 2, 4);
            SetPixel(7, 3, 4);
            SetPixel(7, 4, 4);
            SetPixel(7, 2, 5);
            SetPixel(7, 5, 5);
        }

        private void DrawDataRoom()
        {
            DrawRoom();

            // draw "D"
            for (byte x = 2; x < 5; x++)
            {
                SetPixel(7, x, 2);
                SetPixel(7, x, 5);
            }
            SetPixel(7, 2, 3);
            SetPixel(7, 2, 4);
            SetPixel(7, 5, 3);
            SetPixel(7, 5, 4);
        }

        private void DrawMapRoom()
        {
            DrawRoom();

            // draw "M"
            for (byte y = 2; y < 6; y++)
            {
                SetPixel(7, 1, y);
                SetPixel(7, 5, y);
            }
            SetPixel(7, 2, 3);
            SetPixel(7, 3, 4);
            SetPixel(7, 4, 3);
        }

        private void DrawItemRoom()
        {
            SetPixel(6, 3, 1);
            SetPixel(6, 4, 1);

            SetPixel(3, 1, 2);
            SetPixel(6, 2, 2);
            SetPixel(0xC, 3, 2);
            SetPixel(0xC, 4, 2);
            SetPixel(6, 5, 2);
            SetPixel(3, 6, 2);

            SetPixel(6, 1, 3);
            SetPixel(0xC, 2, 3);
            SetPixel(6, 3, 3);
            SetPixel(0xC, 4, 3);
            SetPixel(0xC, 5, 3);
            SetPixel(6, 6, 3);

            SetPixel(6, 1, 4);
            SetPixel(0xC, 2, 4);
            SetPixel(0xC, 3, 4);
            SetPixel(0xC, 4, 4);
            SetPixel(0xC, 5, 4);
            SetPixel(6, 6, 4);

            SetPixel(3, 1, 5);
            SetPixel(6, 2, 5);
            SetPixel(0xC, 3, 5);
            SetPixel(0xC, 4, 5);
            SetPixel(6, 5, 5);
            SetPixel(3, 6, 5);

            SetPixel(6, 3, 6);
            SetPixel(6, 4, 6);
        }

        private void DrawChozoStatue()
        {
            SetPixel(6, 2, 1);
            SetPixel(6, 3, 1);
            SetPixel(6, 4, 1);

            SetPixel(6, 1, 2);
            SetPixel(0xE, 2, 2);
            SetPixel(0xE, 3, 2);
            SetPixel(0xE, 4, 2);
            SetPixel(6, 5, 2);
            SetPixel(3, 6, 2);

            SetPixel(0xE, 1, 3);
            SetPixel(0xE, 2, 3);
            SetPixel(6, 3, 3);
            SetPixel(0xE, 4, 3);
            SetPixel(0xE, 5, 3);
            SetPixel(6, 6, 3);

            SetPixel(0xE, 1, 4);
            SetPixel(0xE, 2, 4);
            SetPixel(0xE, 3, 4);
            SetPixel(0xE, 4, 4);
            SetPixel(0xE, 5, 4);
            SetPixel(6, 6, 4);

            SetPixel(0xE, 1, 5);
            SetPixel(6, 2, 5);
            SetPixel(0xE, 3, 5);
            SetPixel(0xE, 4, 5);
            SetPixel(0xE, 5, 5);
            SetPixel(6, 6, 5);

            SetPixel(6, 1, 6);
            SetPixel(6, 2, 6);
            SetPixel(0xE, 3, 6);
            SetPixel(0xE, 4, 6);
            SetPixel(0xE, 5, 6);
            SetPixel(6, 6, 6);
        }

        private void control_ValueChanged(object sender, EventArgs e)
        {
            if (loading) { return; }
            RedrawTile();
        }

        private void LoadTile()
        {
            number = (int)numericUpDown_tile.Value;
            int offset = Version.MinimapGfxOffset + number * 0x20;
            tileGFX = new GFX(romStream, offset, 1, 1);

            int row = comboBox_palette.SelectedIndex;
            gfxView_curr.BackgroundImage = tileGFX.Draw4bpp(palette, row, true);
            RedrawTile();
        }

        private void numericUpDown_tile_ValueChanged(object sender, EventArgs e)
        {
            LoadTile();
        }

        private void comboBox_palette_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loading) { return; }
            int pal = comboBox_palette.SelectedIndex;
            gfxView_tile.BackgroundImage = tileGFX.Draw4bpp(palette, pal, true);
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            tileGFX.Write(romStream, false);
            LoadTile();
            FormMain.UpdateEditors();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
