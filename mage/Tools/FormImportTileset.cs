using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace mage
{
    public partial class FormImportTileset : Form
    {
        // fields
        private string filename;
        private byte origNumber;

        private FormMain main;
        private Room room;

        // constructor
        public FormImportTileset(FormMain main, string filename)
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
            if (!header.Contains("MAGE") || !header.Contains("TILE"))
            {
                //MessageBox.Show("Wrong file type. File is not a MAGE tileset.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(Properties.Resources.formImportTileset_WrongFileText,
                    Properties.Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            byte game = Convert.ToByte(!Version.IsMF);
            if (headerArr[0x10] == game) { checkBox_genericTiles.Enabled = false; }
            else
            {
                radioButton_original.Enabled = false;
                checkBox_genericTiles.Checked = true;
            }
            origNumber = headerArr[0x11];

            // check first available by default
            if (radioButton_original.Enabled)
            {
                radioButton_original.Checked = true;
            }
            else { radioButton_current.Checked = true; }

            // initialize combobox
            for (int i = 0; i < Version.NumOfTilesets; i++)
            {
                comboBox_tileset.Items.Add(Hex.ToString(i));
            }
            comboBox_tileset.SelectedIndex = 0;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            // get tileset number
            byte tsNum = 0;

            if (radioButton_original.Checked)
            {
                if (origNumber >= Version.NumOfTilesets)
                {
                    //MessageBox.Show("Original tileset does not exist.",
                    //    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(Properties.Resources.formImportTileset_TilesetNotExistText,
                        Properties.Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                tsNum = origNumber;
            }
            else if (radioButton_current.Checked)
            {
                tsNum = room.tileset.number;
            }
            else
            {
                tsNum = (byte)comboBox_tileset.SelectedIndex;
            }

            // import tileset
            Tileset ts = new Tileset(ROM.Stream, tsNum);
            byte[] data = File.ReadAllBytes(filename);
            ByteStream src = new ByteStream(data);
            bool shared = !checkBox_preserveData.Checked;
            try
            {
                ts.Import(src, checkBox_genericTiles.Checked, shared);
            }
            catch
            {
                //MessageBox.Show("Tileset could not be imported. Data may be corrupt.\n\n",
                //    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(Properties.Resources.formImportTileset_DataCorruptText,
                    Properties.Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            // update editors
            FormMain.UpdateEditors();

            Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        

    }
}
