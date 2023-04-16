using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mage
{
    public partial class FormAdd : Form
    {
        // fields
        private FormMain main;
        private ByteStream romStream;

        // constructor
        public FormAdd(FormMain main, int tab)
        {
            InitializeComponent();

            this.main = main;
            this.romStream = ROM.Stream;

            foreach (TabPage page in tabControl.TabPages)
            {
                page.Tag = false;
            }

            tabControl.SelectedIndex = tab;
            InitializeTab();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeTab();
        }

        private void InitializeTab()
        {
            int tab = tabControl.SelectedIndex;

            // check to enable add button
            switch (tab)
            {
                case 0:  // background
                    button_add.Enabled = radioButton_bgBlank.Checked || radioButton_bgCopy.Checked;
                    break;
                case 1:  // room sprites
                    button_add.Enabled = radioButton_enemyBlank.Checked || radioButton_enemyCopy.Checked;
                    break;
                case 2:  // room
                    button_add.Enabled = radioButton_roomBlank.Checked || radioButton_roomCopy.Checked;
                    break;
                case 3:  // tileset
                    button_add.Enabled = radioButton_tilesetBlank.Checked || radioButton_tilesetCopy.Checked;
                    break;
                case 4:  // spriteset
                    button_add.Enabled = radioButton_spritesetBlank.Checked || radioButton_spritesetCopy.Checked;
                    break;
                case 5:  // animation
                    button_add.Enabled = radioButton_animBlank.Checked || radioButton_animCopy.Checked;
                    break;
            }

            if ((bool)tabControl.TabPages[tab].Tag) { return; }

            switch (tab)
            {
                case 0:  // background
                    comboBox_bg.SelectedIndex = 0;
                    break;
                case 1:  // room sprites
                    comboBox_enemySet.SelectedIndex = 0;
                    break;
                case 2:  // room
                    comboBox_roomArea.Items.AddRange(Version.AreaNames);
                    comboBox_roomArea.SelectedIndex = 0;
                    comboBox_roomCopyArea.Items.AddRange(Version.AreaNames);
                    comboBox_roomCopyArea.SelectedIndex = 0;
                    break;
                case 3:  // tileset
                    AdjustNumOfItems(comboBox_tileset, Version.NumOfTilesets);
                    break;
                case 4:  // spriteset
                    AdjustNumOfItems(comboBox_spriteset, Version.NumOfSpritesets);
                    break;
                case 5:  // animation
                    radioButton_animTileset.Checked = true;
                    break;
            }

            tabControl.TabPages[tab].Tag = true;
        }

        // background
        private void comboBox_bg_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_bg.SelectedIndex)
            {
                case 1:
                case 2:
                case 4:
                    radioButton_bgRLE.Enabled = true;
                    radioButton_bgLZ77.Enabled = false;
                    radioButton_bgRLE.Checked = true;
                    break;
                case 0:
                    radioButton_bgRLE.Enabled = true;
                    radioButton_bgLZ77.Enabled = true;
                    radioButton_bgRLE.Checked = true;
                    break;
                case 3:
                    radioButton_bgRLE.Enabled = false;
                    radioButton_bgLZ77.Enabled = true;
                    radioButton_bgLZ77.Checked = true;
                    break;
            }
        }

        private void AddBackground()
        {
            Room room = main.Room;
            bool rle = radioButton_bgRLE.Checked;

            int offset;
            if (radioButton_bgBlank.Checked)
            {
                // blank data
                if (rle)
                {
                    offset = Add.BlankBgRLE(room.Width, room.Height);
                }
                else
                {
                    offset = Add.BlankBgLZ77();
                }
            }
            else
            {
                // copy
                try
                {
                    offset = Hex.ToInt(textBox_bgOffset.Text);
                }
                catch (Exception ex)
                {
                    DisplayError(ex.Message);
                    return;
                }
                if (rle)
                {
                    offset = Add.BgRleCopy(offset);
                }
            }

            // fix property
            Header.FixBgProp(room.AreaID, room.RoomID, comboBox_bg.SelectedIndex, rle);

            // get background pointer
            int ptr = Header.GetBgPointer(room.AreaID, room.RoomID, comboBox_bg.SelectedIndex);

            romStream.WritePtr(ptr, offset);
            main.ReloadRoom(true);
        }
        
        // room sprites
        private void AddRoomSprites()
        {
            Room room = main.Room;

            int offset;
            if (radioButton_enemyBlank.Checked)
            {
                // blank
                offset = Add.BlankEnemySet();
            }
            else
            {
                // copy
                try
                {
                    offset = Hex.ToInt(textBox_enemyOffset.Text);
                }
                catch (Exception ex)
                {
                    DisplayError(ex.Message);
                    return;
                }
                offset = Add.EnemySetCopy(offset);
            }

            // get enemyset pointer
            int ptr = romStream.ReadPtr(Version.AreaHeaderOffset + room.AreaID * 4) + (room.RoomID * 0x3C);
            ptr += (0x20 + comboBox_enemySet.SelectedIndex * 8);

            romStream.WritePtr(ptr, offset);
            main.ReloadRoom(true);
        }

        // room
        private void comboBox_roomCopyArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            int area = comboBox_roomCopyArea.SelectedIndex;
            int numOfRooms = Version.RoomsPerArea[area];
            AdjustNumOfItems(comboBox_roomCopyRoom, numOfRooms);
        }
        
        private void AddRoom()
        {
            byte area = (byte)comboBox_roomArea.SelectedIndex;
            byte numRooms = Version.RoomsPerArea[area];
            if (numRooms >= 0xFF)
            {
                //DisplayLimitError(Version.AreaNames[area] + " room");
                DisplayLimitError(Version.AreaNames[area] + Properties.Resources.formAdd_LimitErrorRoom);
                return;
            }

            if (radioButton_roomBlank.Checked)
            {
                byte width, height;                
                try
                {
                    // get width and height
                    width = Hex.ToByte(textBox_roomWidth.Text);
                    height = Hex.ToByte(textBox_roomHeight.Text);
                    // check if valid
                    Room.CheckValidSize(width, height);
                }
                catch (Exception ex)
                {
                    DisplayError(ex.Message);
                    return;
                }

                Add.BlankRoom(area, width, height);
            }
            else if (radioButton_roomCopy.Checked)
            {
                byte copyArea = (byte)comboBox_roomCopyArea.SelectedIndex;
                byte copyRoom = (byte)comboBox_roomCopyRoom.SelectedIndex;
                Add.RoomCopy(area, copyArea, copyRoom);
            }
            
            main.LoadAddedRoom(area);
            main.Focus();
        }        

        // tileset
        private void AddTileset()
        {
            byte numTilesets = Version.NumOfTilesets;
            if (numTilesets >= 0xFF)
            {
                //DisplayLimitError("Tileset");
                DisplayLimitError(Properties.Resources.formAdd_LimitErrorTileset);
                return;
            }

            if (radioButton_tilesetBlank.Checked)
            {
                Add.BlankTileset();
            }
            else if (radioButton_tilesetCopy.Checked)
            {
                byte tsNum = (byte)comboBox_tileset.SelectedIndex;
                Add.TilesetCopy(tsNum);
            }

            main.FindOpenForm(typeof(FormTileset), true);
            FormTileset form = new FormTileset(main, numTilesets);
            form.Show();
        }

        // spriteset
        private void AddSpriteset()
        {
            byte numSpritesets = Version.NumOfSpritesets;
            if (numSpritesets >= 0xFF)
            {
                //DisplayLimitError("Spriteset");
                DisplayLimitError(Properties.Resources.formAdd_LimitErrorSpriteset);
                return;
            }

            if (radioButton_spritesetBlank.Checked)
            {
                Add.BlankSpriteset();
            }
            else if (radioButton_spritesetCopy.Checked)
            {
                byte ssNum = (byte)comboBox_spriteset.SelectedIndex;
                Add.SpritesetCopy(ssNum);
            }

            main.FindOpenForm(typeof(FormSpriteset), true);
            FormSpriteset form = new FormSpriteset(main, numSpritesets);
            form.Show();
        }

        // animation
        private void radioButton_animation_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_animTileset.Checked)
            {
                AdjustNumOfItems(comboBox_animNum, Version.NumOfAnimTilesets);
            }
            else if (radioButton_animGfx.Checked)
            {
                AdjustNumOfItems(comboBox_animNum, Version.NumOfAnimGfx);
            }
            else if (radioButton_animPalette.Checked)
            {
                AdjustNumOfItems(comboBox_animNum, Version.NumOfAnimPalettes);
            }
        }

        private void AddAnimation()
        {
            byte animNum = (byte)comboBox_animNum.SelectedIndex;
            int window = 0;
            int number = 0;

            if (radioButton_animTileset.Checked)
            {
                window = 0;
                number = Version.NumOfAnimTilesets;
                if (number >= 0xFF)
                {
                    //DisplayLimitError("Animated tileset");
                    DisplayLimitError(Properties.Resources.formAdd_LimitErrorAnimatedTileset);
                    return;
                }

                if (radioButton_animBlank.Checked)
                {
                    Add.BlankAnimTileset();
                }
                else if (radioButton_animCopy.Checked)
                {
                    Add.AnimTilesetCopy(animNum);
                }
            }
            else if (radioButton_animGfx.Checked)
            {
                window = 1;
                number = Version.NumOfAnimGfx;
                if (number >= 0xFF)
                {
                    //DisplayLimitError("Animated graphics");
                    DisplayLimitError(Properties.Resources.formAdd_LimitErrorAnimatedGFX);
                    return;
                }

                if (radioButton_animBlank.Checked)
                {
                    Add.BlankAnimGfx();
                }
                else if (radioButton_animCopy.Checked)
                {
                    Add.AnimGfxCopy(animNum);
                }
            }
            else if (radioButton_animPalette.Checked)
            {
                window = 2;
                number = Version.NumOfAnimPalettes;
                if (number >= 0xFF)
                {
                    //DisplayLimitError("Animated palette");
                    DisplayLimitError(Properties.Resources.formAdd_LimitErrorAnimatedPalette);
                    return;
                }

                if (radioButton_animBlank.Checked)
                {
                    Add.BlankAnimPalette();
                }
                else if (radioButton_animCopy.Checked)
                {
                    Add.AnimPaletteCopy(animNum);
                }
            }

            main.FindOpenForm(typeof(FormAnimation), true);
            FormAnimation form = new FormAnimation(main, window, number);
            form.Show();
        }


        private void AdjustNumOfItems(ComboBox comboBox, int newNum)
        {
            int currNum = comboBox.Items.Count;
            if (newNum > currNum)
            {
                for (int i = currNum; i < newNum; i++)
                {
                    comboBox.Items.Add(Hex.ToString(i));
                }
            }
            else if (newNum < currNum)
            {
                for (int i = currNum - 1; i >= newNum; i--)
                {
                    comboBox.Items.RemoveAt(i);
                }
            }

            comboBox.SelectedIndex = 0;
        }
        
        private void radioButton_option_CheckedChanged(object sender, EventArgs e)
        {
            button_add.Enabled = true;
        }

        private void DisplayError(string message)
        {
            //MessageBox.Show("One of the values entered was not valid.\n\n" + message,
            //            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show(Properties.Resources.form_OneValueNotValidErrorText + message,
                        Properties.Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DisplayLimitError(string dataType)
        {
            //string text = dataType + " limit reached. No more can be added.";
            //MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            string text = dataType + Properties.Resources.formAdd_LimitErrorText;
            MessageBox.Show(text, Properties.Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    AddBackground();
                    break;
                case 1:
                    AddRoomSprites();
                    break;
                case 2:
                    AddRoom();
                    break;
                case 3:
                    AddTileset();
                    break;
                case 4:
                    AddSpriteset();
                    break;
                case 5:
                    AddAnimation();
                    break;
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
