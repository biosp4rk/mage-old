using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace mage
{
    public partial class FormImportLZ77BG : Form
    {
        // fields
        private PortImage pi;

        private FormMain main;
        private Room room;

        // constructor
        public FormImportLZ77BG(FormMain main)
        {
            InitializeComponent();

            this.main = main;
            this.room = main.Room;
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog bg3File = new OpenFileDialog();
            //bg3File.Filter = "Bitmaps (*.png, *.bmp, *.gif, *.jpeg, *.jpg, *.tif, *.tiff)|*.png;*.bmp;*.gif;*.jpeg;*.jpg;*.tif;*.tiff";
            bg3File.Filter = Properties.Resources.form_BitmapFilterText;
            if (bg3File.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(bg3File.FileName);

                // check dimensions
                bool valid = false;
                if (image.Width == 256 && image.Height == 256) { valid = true; }
                else if (image.Width == 512 && image.Height == 256) { valid = true; }
                else if (image.Width == 256 && image.Height == 512) { valid = true; }
                if (!valid)
                {
                    //MessageBox.Show("Invalid dimensions. Image must be 256 x 256, 512 x 256, or 256 x 512.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(Properties.Resources.formImportLZ77BG_InvalidSizeText,
                        Properties.Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    image.Dispose();
                    return;
                }

                try
                {
                    pi = new PortImage(image);
                }
                catch (FormatException ex)
                {
                    //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.Message, Properties.Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                groupBox_options.Enabled = true;
                groupBox_palette.Enabled = true;
                button_ok.Enabled = true;
            }
        }

        private void checkBox_autoRows_CheckedChanged(object sender, EventArgs e)
        {
            listBox_rows.Enabled = !checkBox_autoRows.Checked;
        }

        private List<int> GetPaletteRows(Tileset ts)
        {
            List<int> rows = new List<int>();

            if (checkBox_autoRows.Checked)
            {
                // find rows used in tileset
                bool[] rowsUsed = new bool[16];
                foreach (ushort tile in room.tileset.tileTable)
                {
                    int pal = tile >> 12;
                    rowsUsed[pal] = true;
                }

                // find rows used in BG0 or BG3
                if (checkBox_addToGraphics.Checked)
                {
                    if (radioButton_BG0.Checked)
                    {
                        foreach (ushort tile in room.BG3.tileTable)
                        {
                            int pal = tile >> 12;
                            rowsUsed[pal] = true;
                        }
                    }
                    else
                    {
                        if (room.BG0.IsLZ77)
                        {
                            foreach (ushort tile in room.BG0.tileTable)
                            {
                                int pal = tile >> 12;
                                rowsUsed[pal] = true;
                            }
                        }
                    }
                }

                for (int i = 1; i < 14; i++)
                {
                    if (!rowsUsed[i + 2])
                    {
                        rows.Add(i);
                    }
                }
            }
            else
            {
                foreach (int r in listBox_rows.SelectedIndices)
                {
                    rows.Add(r + 1);
                }
            }

            return rows;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            // get rows
            List<int> rows = GetPaletteRows(room.tileset);

            // try getting data
            try
            {
                bool addToGfx = checkBox_addToGraphics.Checked;
                pi.GetData(room.vram, rows, false, addToGfx);
            }
            catch (FormatException ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message, Properties.Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // write data
            Tileset ts = room.tileset;
            bool shared = !checkBox_preserveData.Checked;
            int bgPtr, ttbLen;
            if (radioButton_BG0.Checked)
            {
                bgPtr = Header.GetBgPointer(room.AreaID, room.RoomID, 0);
                ttbLen = room.BG0.origLen;
            }
            else
            {
                bgPtr = Header.GetBgPointer(room.AreaID, room.RoomID, 3);
                ttbLen = room.BG3.origLen;
            }
            pi.WritePalette(ts.addr + 4, shared);
            pi.WriteGfx(ts.addr + 8, ts.LZ77gfx.origLen, shared);
            pi.WriteTileTable(bgPtr, ttbLen, shared);

            // fix BG0 propery if necessary
            if (radioButton_BG0.Checked)
            {
                Header.FixBgProp(room.AreaID, room.RoomID, 0, false);
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
