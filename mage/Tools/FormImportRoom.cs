using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace mage
{
    public partial class FormImportRoom : Form
    {
        // fields        
        private string filename;
        private bool diffGame;
        private byte areaID;
        private byte roomID;

        private FormMain main;
        private Room room;

        // constructor
        public FormImportRoom(FormMain main, string filename)
        {
            InitializeComponent();

            this.main = main;
            this.room = main.Room;
            this.filename = filename;

            Initialize();
        }

        private void Initialize()
        {
            // check header
            BinaryReader reader = new BinaryReader(File.Open(filename, FileMode.Open));
            byte[] headerArr = reader.ReadBytes(0x20);
            reader.Close();

            string header = Encoding.ASCII.GetString(headerArr, 0, 0x10);
            if (!header.Contains("MAGE") || !header.Contains("ROOM"))
            {
                //MessageBox.Show("Wrong file type. File is not a MAGE room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(Properties.Resources.formImportRoom_WrongFileText,
                    Properties.Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            byte game = Convert.ToByte(!Version.IsMF);
            diffGame = (headerArr[0x10] != game);
            if (diffGame)
            {
                radioButton_original.Enabled = false;
                checkBox_convertClip.Checked = true;
            }
            else
            {
                checkBox_convertClip.Enabled = false;
                checkBox_sprites.Checked = true;
                checkBox_doors.Checked = true;
            }
            radioButton_current.Checked = true;
            checkBox_BGs.Checked = true;
            checkBox_scrolls.Checked = true;

            areaID = headerArr[0x11];
            roomID = headerArr[0x12];
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (radioButton_current.Checked)
            {
                areaID = room.AreaID;
                roomID = room.RoomID;
            }
            else
            {
                if (areaID >= Version.AreaNames.Length || roomID >= Version.RoomsPerArea[areaID])
                {
                    //MessageBox.Show("Original room does not exist.",
                        //"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(Properties.Resources.formImportRoom_RoomNotExistText,
                        Properties.Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // import room
            bool[] items = new bool[4];
            items[0] = checkBox_BGs.Checked;
            items[1] = checkBox_sprites.Checked;
            items[2] = checkBox_doors.Checked;
            items[3] = checkBox_scrolls.Checked;
            bool shared = !checkBox_preserveData.Checked;

            Room rm = new Room(areaID, roomID);
            byte[] data = File.ReadAllBytes(filename);
            ByteStream src = new ByteStream(data);
            try
            {
                rm.Import(src, items, diffGame, checkBox_convertClip.Checked, shared);
            }
            catch
            {
                //MessageBox.Show("Room could not be imported. Data may be corrupt.\n\n",
                //    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(Properties.Resources.formImportRoom_DataCorruptText,
                    Properties.Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            // update current room if necessary
            if (room.AreaID == areaID && room.RoomID == roomID)
            {
                main.Room = rm;
                main.ReloadRoom(true);
            }

            Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
