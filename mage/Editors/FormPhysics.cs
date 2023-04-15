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
    public partial class FormPhysics : Form
    {
        // fields
        private ByteStream romStream;

        public FormPhysics()
        {
            InitializeComponent();

            this.romStream = ROM.Stream;
            Initialize();
        }
        
        private void Initialize()
        {
            string text;
            if (Version.IsMF) { text = Properties.Resources.MF_U_physics; }
            else { text = Properties.Resources.ZM_U_physics; }
            StringReader sr = new StringReader(text);

            listView_physics.BeginUpdate();
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.StartsWith("["))
                {
                    string section = line.Substring(1, line.Length - 2);
                    ListViewItem item = new ListViewItem(section);
                    item.Font = new Font(item.Font, FontStyle.Bold);
                    listView_physics.Items.Add(item);
                }
                else
                {
                    string[] items = line.Split(';');
                    if (items.Length < 3) { continue; }

                    // get name
                    ListViewItem entry = new ListViewItem(items[0]);
                    // get offsets
                    List<int> offsets = new List<int>();
                    foreach (string s in items[1].Split(','))
                    {
                        offsets.Add(Convert.ToInt32(s, 16));
                    }
                    string off = Hex.ToString(offsets[0]);
                    for (int i = 1; i < offsets.Count; i++)
                    {
                        off += ", " + Hex.ToString(offsets[1]);
                    }
                    entry.SubItems.Add(off);
                    // get size
                    entry.SubItems.Add(items[2]);
                    // get value
                    if (items[2] == "1")
                    {
                        byte value = romStream.Read8(offsets[0]);
                        entry.SubItems.Add(Hex.ToString(value));
                    }
                    else
                    {
                        ushort value = romStream.Read16(offsets[0]);
                        entry.SubItems.Add(Hex.ToString(value));
                    }

                    listView_physics.Items.Add(entry);
                }
            }

            listView_physics.EndUpdate();
            sr.Close();
        }

        private void listView_physics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_physics.SelectedIndices.Count == 0) { return; }
            int index = listView_physics.SelectedIndices[0];
            ListViewItem item = listView_physics.Items[index];

            if (item.SubItems.Count < 4)
            {
                button_apply.Enabled = false;
                textBox_value.Enabled = false;
                textBox_value.Text = "";
            }
            else
            {
                button_apply.Enabled = true;
                textBox_value.Enabled = true;
                textBox_value.Text = item.SubItems[3].Text;
            }
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listView_physics.SelectedIndices[0];
                ListViewItem item = listView_physics.Items[index];

                string[] offsets = item.SubItems[1].Text.Split(',');
                if (item.SubItems[2].Text == "1")
                {
                    byte value = Hex.ToByte(textBox_value.Text);
                    foreach (string off in offsets)
                    {
                        int offset = Hex.ToInt(off.Trim());
                        romStream.Write8(offset, value);
                    }
                    item.SubItems[3].Text = Hex.ToString(value);
                }
                else
                {
                    ushort value = Hex.ToUshort(textBox_value.Text);
                    foreach (string off in offsets)
                    {
                        int offset = Hex.ToInt(off);
                        romStream.Write16(offset, value);
                    }
                    item.SubItems[3].Text = Hex.ToString(value);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("The value entered was not valid.\n\n" + ex.Message,
                //    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(Properties.Resources.form_ValueNotValidErrorText + ex.Message,
                    Properties.Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
