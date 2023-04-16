using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace mage
{
    public partial class FormPortBG : Form
    {
        private byte[] data;
        private FormMain main;
        private Room room;
        private int action;

        public FormPortBG(FormMain main, int action)
        {
            InitializeComponent();

            this.main = main;
            this.room = main.Room;
            this.action = action;

            // open file if importing
            if (action < 2)
            {
                //string filter = "All files (*.*)|*.*";
                //if (action == 0) { filter = "RLE compressed backgrounds (*.rlebg)|*.rlebg|" + filter; }
                //else if (action == 1) { filter = "LZ77 compressed backgrounds (*.lzbg)|*.lzbg|" + filter; }
                string filter = Properties.Resources.form_AllFilterText;
                if (action == 0) { filter = Properties.Resources.formPortBG_RLEFilter + filter; }
                else if (action == 1) { filter = Properties.Resources.formPortBG_LZ77Filter + filter; }

                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = filter;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    data = File.ReadAllBytes(openFile.FileName);
                }
                else
                {
                    Close();
                    return;
                }
            }

            // set up form
            if (action == 0)
            {
                // import RLE
                //this.Text = "Import Background";
                this.Text = Properties.Resources.formPortBG_TitleImport;
                checkBox_preserveData.Visible = false;
                comboBox_bg.Items.Add("BG 0");
                comboBox_bg.Items.Add("BG 1");
                comboBox_bg.Items.Add("BG 2");
                //comboBox_bg.Items.Add("Clipdata");
                comboBox_bg.Items.Add(Properties.Resources.formPortBG_CheckboxItemClip);
            }
            else if (action == 1)
            {
                // import LZ77
                //this.Text = "Import Background";
                this.Text = Properties.Resources.formPortBG_TitleImport;
                comboBox_bg.Items.Add("BG 0");
                comboBox_bg.Items.Add("BG 3");
            }
            else if (action == 2)
            {
                // export
                //this.Text = "Export Background";
                this.Text = Properties.Resources.formPortBG_TitleExport;
                checkBox_preserveData.Visible = false;
                bool[] exists = room.backgrounds.GetExists();
                for (int bg = 0; bg < 4; bg++)
                {
                    if (exists[bg]) { comboBox_bg.Items.Add("BG " + bg); }
                }
                //comboBox_bg.Items.Add("Clipdata");
                comboBox_bg.Items.Add(Properties.Resources.formPortBG_CheckboxItemClip);
            }

            comboBox_bg.SelectedIndex = 0;
        }

        private BG GetBackground()
        {
            string s = comboBox_bg.SelectedItem.ToString();

            /*switch (s)
            {
                case "BG 0":
                    return room.BG0;
                case "BG 1":
                    return room.BG1;
                case "BG 2":
                    return room.BG2;
                case "BG 3":
                    return room.BG3;
                case "Clipdata":
                    return room.Clip;
                default:
                    return null;
            }*/

            // for "Clipdata" localization
            if (s == Properties.Resources.formPortBG_CheckboxItemClip )
                return room.Clip;
            else
            {
                switch (s)
                {
                    case "BG 0":
                        return room.BG0;
                    case "BG 1":
                        return room.BG1;
                    case "BG 2":
                        return room.BG2;
                    case "BG 3":
                        return room.BG3;
                    default:
                        return null;
                }
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            BG bg = GetBackground();

            if (action < 2)
            {
                ByteStream source = new ByteStream(data);
                bool rle = (action == 0);
                bool shared = !checkBox_preserveData.Checked;
                bg.Import(source, rle, room.Width, room.Height, shared);

                FormMain.UpdateEditors();
            }
            else if (action == 2)
            {
                // export background
                //string filter = "All files (*.*)|*.*";
                //if (bg.IsRLE) { filter = "RLE compressed backgrounds (*.rlebg)|*.rlebg|" + filter; }
                //else if (bg.IsLZ77) { filter = "LZ77 compressed backgrounds (*.lzbg)|*.lzbg|" + filter; }
                string filter = Properties.Resources.form_AllFilterText;
                if (bg.IsRLE) { filter = Properties.Resources.formPortBG_RLEFilter + filter; }
                else if (bg.IsLZ77) { filter = Properties.Resources.formPortBG_LZ77Filter + filter; }

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = filter;
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    ByteStream outputStream = new ByteStream();
                    if (bg.IsRLE)
                    {
                        bg.WriteRLE(outputStream, false, true);
                    }
                    else if (bg.IsLZ77)
                    {
                        bg.WriteLZ77(outputStream, false, false, true);
                    }

                    outputStream.Export(saveFile.FileName);
                }
            }

            Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
