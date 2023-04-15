using System;
using System.Windows.Forms;

namespace mage
{
    public partial class FormHeader : Form
    {
        // fields
        private string[] areaNames;
        private byte[] roomsPerArea;

        private FormMain main;
        private ByteStream romStream;
        private bool loading;
        private Status status;

        // constructor
        public FormHeader(FormMain main)
        {
            InitializeComponent();

            this.main = main;
            this.romStream = ROM.Stream;
            status = new Status(statusLabel_changes, button_apply);

            // get area names and rooms per area
            areaNames = Version.AreaNames;
            roomsPerArea = Version.RoomsPerArea;
            for (int i = 0; i < areaNames.Length; i++)
            {
                comboBox_area.Items.Add(areaNames[i]);
            }

            comboBox_area.SelectedIndex = main.Room.AreaID;
            comboBox_room.SelectedIndex = main.Room.RoomID;
        }

        private void comboBox_area_SelectedIndexChanged(object sender, EventArgs e)
        {
            // update number of rooms in area
            int area = comboBox_area.SelectedIndex;
            int numOfRooms = roomsPerArea[area];
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

            if (comboBox_room.SelectedIndex == 0)
            {
                FillValues();
            }
            else { comboBox_room.SelectedIndex = 0; }
        }

        private void comboBox_room_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillValues();
        }

        public void FillValues()
        {
            loading = true;

            int a = comboBox_area.SelectedIndex;
            int r = comboBox_room.SelectedIndex;
            int offset = romStream.ReadPtr(Version.AreaHeaderOffset + a * 4) + (r * 0x3C);

            // get values
            byte tileset = romStream.Read8(offset);
            byte BG0comp = romStream.Read8(offset + 0x1);
            byte BG1comp = romStream.Read8(offset + 0x2);
            byte BG2comp = romStream.Read8(offset + 0x3);
            byte BG3comp = romStream.Read8(offset + 0x4);
            int BG0offset = romStream.ReadPtr(offset + 0x8);
            int BG1offset = romStream.ReadPtr(offset + 0xC);
            int BG2offset = romStream.ReadPtr(offset + 0x10);
            int clipOffset = romStream.ReadPtr(offset + 0x14);
            int BG3offset = romStream.ReadPtr(offset + 0x18);
            byte BG3scroll = romStream.Read8(offset + 0x1C);
            byte transparency = romStream.Read8(offset + 0x1D);
            int sprite0offset = romStream.ReadPtr(offset + 0x20);
            byte sprite0 = romStream.Read8(offset + 0x24);
            byte sprite1event = romStream.Read8(offset + 0x25);
            int sprite1offset = romStream.ReadPtr(offset + 0x28);
            byte sprite1 = romStream.Read8(offset + 0x2C);
            byte sprite2event = romStream.Read8(offset + 0x2D);
            int sprite2offset = romStream.ReadPtr(offset + 0x30);
            byte sprite2 = romStream.Read8(offset + 0x34);
            byte mapX = romStream.Read8(offset + 0x35);
            byte mapY = romStream.Read8(offset + 0x36);
            byte effect = romStream.Read8(offset + 0x37);
            byte effectY = romStream.Read8(offset + 0x38);
            ushort music = romStream.Read16(offset + 0x3A);

            // set text
            textBox_tileset.Text = Hex.ToString(tileset);
            textBox_BG0prop.Text = Hex.ToString(BG0comp);
            textBox_BG1prop.Text = Hex.ToString(BG1comp);
            textBox_BG2prop.Text = Hex.ToString(BG2comp);
            textBox_BG3prop.Text = Hex.ToString(BG3comp);
            textBox_BG0pointer.Text = Hex.ToString(BG0offset);
            textBox_BG1pointer.Text = Hex.ToString(BG1offset);
            textBox_BG2pointer.Text = Hex.ToString(BG2offset);
            textBox_CLPpointer.Text = Hex.ToString(clipOffset);
            textBox_BG3pointer.Text = Hex.ToString(BG3offset);
            textBox_BG3scroll.Text = Hex.ToString(BG3scroll);
            textBox_transparency.Text = Hex.ToString(transparency);

            textBox_defaultSpriteset.Text = Hex.ToString(sprite0);
            textBox_firstSpriteset.Text = Hex.ToString(sprite1);
            textBox_secondSpriteset.Text = Hex.ToString(sprite2);
            textBox_defaultPointer.Text = Hex.ToString(sprite0offset);
            textBox_firstPointer.Text = Hex.ToString(sprite1offset);
            textBox_secondPointer.Text = Hex.ToString(sprite2offset);
            textBox_firstEvent.Text = Hex.ToString(sprite1event);
            textBox_secondEvent.Text = Hex.ToString(sprite2event);

            textBox_mapX.Text = Hex.ToString(mapX);
            textBox_mapY.Text = Hex.ToString(mapY);
            textBox_effect.Text = Hex.ToString(effect);
            textBox_effectYpos.Text = Hex.ToString(effectY);
            textBox_music.Text = Hex.ToString(music);

            textBox_offsetVal.Text = Hex.ToString(offset);

            loading = false;
            status.LoadNew();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (loading) { return; }
            status.ChangeMade();
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            int a = comboBox_area.SelectedIndex;
            int r = comboBox_room.SelectedIndex;

            try
            {
                // get all values
                byte tileset = Hex.ToByte(textBox_tileset.Text);
                byte BG0comp = Hex.ToByte(textBox_BG0prop.Text);
                byte BG1comp = Hex.ToByte(textBox_BG1prop.Text);
                byte BG2comp = Hex.ToByte(textBox_BG2prop.Text);
                byte BG3comp = Hex.ToByte(textBox_BG3prop.Text);
                int BG0offset = Hex.ToInt(textBox_BG0pointer.Text);
                int BG1offset = Hex.ToInt(textBox_BG1pointer.Text);
                int BG2offset = Hex.ToInt(textBox_BG2pointer.Text);
                int clipOffset = Hex.ToInt(textBox_CLPpointer.Text);
                int BG3offset = Hex.ToInt(textBox_BG3pointer.Text);
                byte BG3scroll = Hex.ToByte(textBox_BG3scroll.Text);
                byte transparency = Hex.ToByte(textBox_transparency.Text);

                byte sprite0 = Hex.ToByte(textBox_defaultSpriteset.Text);
                byte sprite1 = Hex.ToByte(textBox_firstSpriteset.Text);
                byte sprite2 = Hex.ToByte(textBox_secondSpriteset.Text);
                int sprite0offset = Hex.ToInt(textBox_defaultPointer.Text);
                int sprite1offset = Hex.ToInt(textBox_firstPointer.Text);
                int sprite2offset = Hex.ToInt(textBox_secondPointer.Text);
                byte sprite1event = Hex.ToByte(textBox_firstEvent.Text);
                byte sprite2event = Hex.ToByte(textBox_secondEvent.Text);

                byte mapX = Hex.ToByte(textBox_mapX.Text);
                byte mapY = Hex.ToByte(textBox_mapY.Text);
                byte effect = Hex.ToByte(textBox_effect.Text);
                byte effectY = Hex.ToByte(textBox_effectYpos.Text);
                ushort music = Hex.ToUshort(textBox_music.Text);
     
                int offset = romStream.ReadPtr(Version.AreaHeaderOffset + a * 4) + (r * 0x3C);

                // write all values
                romStream.Write8(offset, tileset);
                romStream.Write8(offset + 0x1, BG0comp);
                romStream.Write8(offset + 0x2, BG1comp);
                romStream.Write8(offset + 0x3, BG2comp);
                romStream.Write8(offset + 0x4, BG3comp);
                romStream.WritePtr(offset + 0x8, BG0offset);
                romStream.WritePtr(offset + 0xC, BG1offset);
                romStream.WritePtr(offset + 0x10, BG2offset);
                romStream.WritePtr(offset + 0x14, clipOffset);
                romStream.WritePtr(offset + 0x18, BG3offset);
                romStream.Write8(offset + 0x1C, BG3scroll);
                romStream.Write8(offset + 0x1D, transparency);

                romStream.WritePtr(offset + 0x20, sprite0offset);
                romStream.Write8(offset + 0x24, sprite0);
                romStream.Write8(offset + 0x25, sprite1event);
                romStream.WritePtr(offset + 0x28, sprite1offset);
                romStream.Write8(offset + 0x2C, sprite1);
                romStream.Write8(offset + 0x2D, sprite2event);
                romStream.WritePtr(offset + 0x30, sprite2offset);
                romStream.Write8(offset + 0x34, sprite2);

                romStream.Write8(offset + 0x35, mapX);
                romStream.Write8(offset + 0x36, mapY);
                romStream.Write8(offset + 0x37, effect);
                romStream.Write8(offset + 0x38, effectY);
                romStream.Write16(offset + 0x3A, music);

                status.Save();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("One of the values entered was not valid.\n\n" + ex.Message,
                //        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(Properties.Resources.form_OneValueNotValidErrorText + ex.Message,
                        Properties.Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // redrawing
            Room room = main.Room;
            if (room.AreaID == a && room.RoomID == r)
            {
                main.ReloadRoom(true);
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
