using System;
using System.Windows.Forms;

namespace mage
{
    public partial class FormTileset : Form
    {
        // fields
        private FormMain main;
        private ByteStream romStream;
        private bool loading;
        private Status status;

        // constructor
        public FormTileset(FormMain main, byte tsNum)
        {
            InitializeComponent();

            this.main = main;
            romStream = ROM.Stream;
            status = new Status(statusLabel_changes, button_apply);

            byte numTilesets = Version.NumOfTilesets;
            for (int i = 0; i < numTilesets; i++)
            {
                comboBox_tileset.Items.Add(Hex.ToString(i));
            }

            comboBox_tileset.SelectedIndex = tsNum;
        }

        private void comboBox_tileset_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillValues();
        }

        private void FillValues()
        {
            loading = true;

            int num = comboBox_tileset.SelectedIndex;
            int offset = Version.TilesetOffset + num * 0x14;
            textBox_offsetVal.Text = Hex.ToString(offset);

            textBox_rleGfx.Text = Hex.ToString(romStream.ReadPtr(offset));
            textBox_palette.Text = Hex.ToString(romStream.ReadPtr(offset + 4));
            textBox_lz77gfx.Text = Hex.ToString(romStream.ReadPtr(offset + 8));
            textBox_tileTable.Text = Hex.ToString(romStream.ReadPtr(offset + 0xC));
            textBox_animTileset.Text = Hex.ToString(romStream.Read8(offset + 0x10));
            textBox_animPalette.Text = Hex.ToString(romStream.Read8(offset + 0x11));

            loading = false;
            status.LoadNew();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (loading) { return; }
            status.ChangeMade();
        }

        private void button_editRLE_Click(object sender, EventArgs e)
        {
            try
            {
                int gfxOffset = Hex.ToInt(textBox_rleGfx.Text);
                int palOffset = Hex.ToInt(textBox_palette.Text) + 0x20;
                FormGraphics form = new FormGraphics(main, gfxOffset, 32, 0, palOffset);
                form.Show();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("The value entered was not valid.\n\n" + ex.GetType().ToString() + '\n'
                //        + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(Properties.Resources.form_ValueNotValidErrorText + ex.GetType().ToString() + '\n'
                        + ex.Message, Properties.Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_editPalette_Click(object sender, EventArgs e)
        {
            FormPalette form = new FormPalette(main, true, (byte)comboBox_tileset.SelectedIndex);
            form.Show();
        }

        private void button_editLZ77_Click(object sender, EventArgs e)
        {
            try
            {
                int gfxOffset = Hex.ToInt(textBox_lz77gfx.Text);
                int palOffset = Hex.ToInt(textBox_palette.Text) + 0x20;
                FormGraphics form = new FormGraphics(main, gfxOffset, 32, 0, palOffset);
                form.Show();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("The value entered was not valid.\n\n" + ex.GetType().ToString() + '\n'
                //        + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(Properties.Resources.form_ValueNotValidErrorText + ex.GetType().ToString() + '\n'
                        + ex.Message, Properties.Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_editTileTable_Click(object sender, EventArgs e)
        {
            FormTileTable form = new FormTileTable(main, comboBox_tileset.SelectedIndex);
            form.Show();
        }

        private void button_editAnimTileset_Click(object sender, EventArgs e)
        {
            try
            {
                byte animTileset = Hex.ToByte(textBox_animTileset.Text);

                if (animTileset >= Version.NumOfAnimTilesets)
                {
                    throw new IndexOutOfRangeException();
                }

                FormAnimation form = new FormAnimation(main, 0, animTileset);
                form.Show();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("The value entered was not valid.\n\n" + ex.GetType().ToString() + '\n'
                //        + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(Properties.Resources.form_ValueNotValidErrorText + ex.GetType().ToString() + '\n'
                        + ex.Message, Properties.Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_editAnimPalette_Click(object sender, EventArgs e)
        {
            try
            {
                byte animPalette = Hex.ToByte(textBox_animPalette.Text);

                if (animPalette >= Version.NumOfAnimPalettes)
                {
                    throw new IndexOutOfRangeException();
                }

                FormAnimation form = new FormAnimation(main, 2, animPalette);
                form.Show();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("The value entered was not valid.\n\n" + ex.GetType().ToString() + '\n'
                //        + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(Properties.Resources.form_ValueNotValidErrorText + ex.GetType().ToString() + '\n'
                        + ex.Message, Properties.Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            int num = comboBox_tileset.SelectedIndex;

            try
            {
                int offset = Version.TilesetOffset + num * 0x14;

                romStream.WritePtr(offset, Hex.ToInt(textBox_rleGfx.Text));
                romStream.WritePtr(offset + 4, Hex.ToInt(textBox_palette.Text));
                romStream.WritePtr(offset + 8, Hex.ToInt(textBox_lz77gfx.Text));
                romStream.WritePtr(offset + 0xC, Hex.ToInt(textBox_tileTable.Text));
                romStream.Write8(offset + 0x10, Hex.ToByte(textBox_animTileset.Text));
                romStream.Write8(offset + 0x11, Hex.ToByte(textBox_animPalette.Text));

                FormMain.UpdateEditors();
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

            // update current room
            Room room = main.Room;
            if (room.tileset.number == num)
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
