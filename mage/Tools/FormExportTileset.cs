using System;
using System.Windows.Forms;

namespace mage
{
    public partial class FormExportTileset : Form
    {
        // fields
        private FormMain main;

        public FormExportTileset(FormMain main)
        {
            InitializeComponent();

            this.main = main;

            for (int i = 0; i < Version.NumOfTilesets; i++)
            {
                comboBox_tileset.Items.Add(Hex.ToString(i));
            }
            comboBox_tileset.SelectedIndex = 0;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            // get filename
            SaveFileDialog tilesetFile = new SaveFileDialog();
            //tilesetFile.Filter = "MAGE tileset (*.mgt)|*.mgt";
            tilesetFile.Filter = Properties.Resources.form_TilesetFilterText;
            if (tilesetFile.ShowDialog() == DialogResult.OK)
            {
                // get tileset
                byte tsNum;

                if (radioButton_current.Checked)
                {
                    tsNum = main.Room.tileset.number;
                }
                else
                {
                    tsNum = (byte)comboBox_tileset.SelectedIndex;
                }

                Tileset ts = new Tileset(ROM.Stream, tsNum);
                ts.Export(tilesetFile.FileName);

                Close();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
