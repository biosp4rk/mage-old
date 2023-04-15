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
    public partial class FormDemo : Form
    {
        // fields
        private struct RamItem
        {
            public int offset;
            public byte size;
        }

        private Demo currDemo;
        private ByteStream ramData;
        private ushort[] clipboard;
        private bool selecting;

        private ByteStream romStream;
        private Status status;

        public FormDemo()
        {
            InitializeComponent();

            this.romStream = ROM.Stream;

            status = new Status(statusLabel_changes, button_apply);

            // fill in combobox
            int count = Version.NumOfDemos;
            for (int i = 0; i < count; i++)
            {
                comboBox_demo.Items.Add(Hex.ToString(i));
            }

            InitializeRamTree();
            comboBox_demo.SelectedIndex = 0;
        }

        private void comboBox_demo_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte demoNum = (byte)comboBox_demo.SelectedIndex;
            currDemo = ROM.LoadDemo(demoNum);
            LoadInputs();
            LoadRAM();

            status.LoadNew();
        }

        // inputs
        private void LoadInputs()
        {
            listView_input.BeginUpdate();
            listView_input.Items.Clear();

            foreach (ushort input in currDemo.inputs)
            {
                string inputText = StringFromInput(input);
                AddInputToEnd(inputText);
            }

            listView_input.EndUpdate();
        }

        private void AddInputToEnd(string inputText)
        {
            string frame = listView_input.Items.Count.ToString();
            ListViewItem item = new ListViewItem(frame);
            item.SubItems.Add(inputText);
            listView_input.Items.Add(item);
        }

        private string StringFromInput(ushort input)
        {
            string text = "";
            if ((input & 0x001) != 0) { text += 'A'; }
            if ((input & 0x002) != 0) { text += 'B'; }
            if ((input & 0x004) != 0) { text += 's'; }
            if ((input & 0x008) != 0) { text += 'S'; }
            if ((input & 0x010) != 0) { text += '>'; }
            if ((input & 0x020) != 0) { text += '<'; }
            if ((input & 0x040) != 0) { text += '^'; }
            if ((input & 0x080) != 0) { text += 'v'; }
            if ((input & 0x100) != 0) { text += 'R'; }
            if ((input & 0x200) != 0) { text += 'L'; }
            return text;
        }

        private ushort InputFromString(string text)
        {
            ushort input = 0;
            if (text.Contains("A")) { input |= 1; }
            if (text.Contains("B")) { input |= 2; }
            if (text.Contains("s")) { input |= 4; }
            if (text.Contains("S")) { input |= 8; }
            if (text.Contains(">")) { input |= 0x10; }
            if (text.Contains("<")) { input |= 0x20; }
            if (text.Contains("^")) { input |= 0x40; }
            if (text.Contains("v")) { input |= 0x80; }
            if (text.Contains("R")) { input |= 0x100; }
            if (text.Contains("L")) { input |= 0x200; }
            return input;
        }

        private void listView_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_input.SelectedItems.Count > 0)
            {
                selecting = true;
                textBox_input.Text = listView_input.SelectedItems[0].SubItems[1].Text;
                selecting = false;
            }
        }

        private void textBox_input_TextChanged(object sender, EventArgs e)
        {
            if (selecting) { return; }

            ushort input = InputFromString(textBox_input.Text);
            string inputText = StringFromInput(input);
            foreach (ListViewItem item in listView_input.SelectedItems)
            {
                item.SubItems[1].Text = inputText;
            }

            status.ChangeMade();
        }

        private void RenumberInputs(int index)
        {
            while (index < listView_input.Items.Count)
            {
                listView_input.Items[index].Text = index.ToString();
                index++;
            }
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (listView_input.SelectedItems.Count == 0)
            {
                e.Cancel = true;
            }
            else
            {
                bool canPaste = clipboard != null;
                menuItem_pasteInsert.Enabled = canPaste;
                menuItem_pasteWrite.Enabled = canPaste;
            }
        }

        private void menuItem_insert_Click(object sender, EventArgs e)
        {
            if (listView_input.SelectedItems.Count == 0) { return; }

            listView_input.BeginUpdate();
            int index = listView_input.SelectedIndices[0];
            for (int i = 0; i < listView_input.SelectedItems.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add("");
                listView_input.Items.Insert(index, item);
            }
            RenumberInputs(index);
            listView_input.EndUpdate();
            status.ChangeMade();
        }

        private void menuItem_delete_Click(object sender, EventArgs e)
        {
            if (listView_input.SelectedItems.Count == 0) { return; }

            listView_input.BeginUpdate();
            int index = listView_input.SelectedIndices[0];
            foreach (ListViewItem item in listView_input.SelectedItems)
            {
                listView_input.Items.Remove(item);
            }
            RenumberInputs(index);
            listView_input.EndUpdate();
            textBox_input.Text = "";
            status.ChangeMade();
        }

        private void menuItem_cut_Click(object sender, EventArgs e)
        {
            if (listView_input.SelectedItems.Count == 0) { return; }

            menuItem_copy_Click(sender, e);
            menuItem_delete_Click(sender, e);
        }

        private void menuItem_copy_Click(object sender, EventArgs e)
        {
            if (listView_input.SelectedItems.Count == 0) { return; }

            clipboard = new ushort[listView_input.SelectedItems.Count];
            for (int i = 0; i < clipboard.Length; i++)
            {
                ListViewItem item = listView_input.SelectedItems[i];
                ushort input = InputFromString(item.SubItems[1].Text);
                clipboard[i] = input;
            }
        }

        private void menuItem_pasteInsert_Click(object sender, EventArgs e)
        {
            if (listView_input.SelectedItems.Count == 0) { return; }
            if (clipboard == null) { return; }

            listView_input.BeginUpdate();
            int startIndex = listView_input.SelectedIndices[0];
            int index = startIndex;
            foreach (ushort input in clipboard)
            {
                ListViewItem item = new ListViewItem();
                string inputText = StringFromInput(input);
                item.SubItems.Add(inputText);
                listView_input.Items.Insert(index, item);
                index++;
            }

            RenumberInputs(startIndex);
            listView_input.EndUpdate();
            status.ChangeMade();
        }

        private void menuItem_pasteWrite_Click(object sender, EventArgs e)
        {
            if (listView_input.SelectedItems.Count == 0) { return; }
            if (clipboard == null) { return; }

            listView_input.BeginUpdate();
            int index = listView_input.SelectedIndices[0];
            foreach (ushort input in clipboard)
            {
                string inputText = StringFromInput(input);

                if (index >= listView_input.Items.Count)
                {
                    AddInputToEnd(inputText);
                }
                else
                {
                    ListViewItem item = listView_input.Items[index];
                    item.SubItems[1].Text = inputText;
                }
                index++;
            }
            listView_input.EndUpdate();
            status.ChangeMade();
        }

        private void SaveInputs()
        {
            List<ushort> inputs = new List<ushort>();
            ushort input = 0;

            for (int i = 0; i < listView_input.Items.Count; i++)
            {
                string inputText = listView_input.Items[i].SubItems[1].Text;
                input = InputFromString(inputText);
                inputs.Add(input);
            }

            // check if last input is start
            if ((input & 8) == 0)
            {
                inputs.Add(8);
            }

            currDemo.inputs = inputs;
        }

        // ram
        private void InitializeRamTree()
        {
            treeView_ram.BeginUpdate();
            StringReader sr = new StringReader(Version.DemoRam);

            string line;
            TreeNode currNode = new TreeNode();
            int level = 0;
            while ((line = sr.ReadLine()) != null)
            {
                int tabs = 0;
                while (line[tabs] == '\t')
                {
                    tabs++;
                }
                line = line.Remove(0, tabs);

                // set current node
                if (tabs > level)
                {
                    if (level == 0)
                    {
                        currNode = treeView_ram.Nodes[treeView_ram.Nodes.Count - 1];
                    }
                    else
                    {
                        currNode = currNode.LastNode;
                    }
                }
                else if (tabs < level)
                {
                    for (int i = tabs; i < level; i++)
                    {
                        currNode = currNode.Parent;
                    }
                }

                // get node
                TreeNode node;
                string[] items = line.Split(',');
                if (items.Length == 1)
                {
                    node = new TreeNode(line);
                }
                else if (items.Length == 2)
                {
                    node = new TreeNode(items[1]);
                    string s = items[0];
                    int off = Convert.ToInt32(s.Substring(0, s.Length - 2), 16);
                    int bit = Convert.ToInt32(s.Substring(s.Length - 1, 1));
                    RamItem ri;
                    ri.offset = off * 8 + bit;
                    ri.size = 1;
                    node.Tag = ri;
                }
                else
                {
                    RamItem ri;
                    ri.offset = Convert.ToInt32(items[0], 16) * 8;
                    ri.size = (byte)(Convert.ToByte(items[1]) * 8);
                    node = new TreeNode(items[2]);
                    node.Tag = ri;
                }

                // add to tree
                if (tabs == 0)
                {
                    treeView_ram.Nodes.Add(node);
                }
                else
                {
                    currNode.Nodes.Add(node);
                }

                level = tabs;
            }

            sr.Close();
            treeView_ram.EndUpdate();
        }

        private void LoadRAM()
        {
            ramData = currDemo.ramData;

            // display values
            treeView_ram.BeginUpdate();
            DisplayRamValues(treeView_ram.Nodes);
            treeView_ram.EndUpdate();

            button_set.Enabled = false;
        }

        private void DisplayRamValues(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Tag is RamItem)
                {
                    RamItem ri = (RamItem)node.Tag;
                    int val = GetRamValue(ri);
                    SetLabelValue(node, val);
                }
                else
                {
                    DisplayRamValues(node.Nodes);
                }
            }
        }

        private void SetLabelValue(TreeNode node, int val)
        {
            string s = node.Text;
            int index = s.IndexOf(" (");
            if (index != -1)
            {
                s = s.Remove(index);
            }
            node.Text = s + " (" + Hex.ToString(val) + ")";
        }

        private void treeView_ram_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is RamItem)
            {
                RamItem ri = (RamItem)e.Node.Tag;
                int offset = ri.offset / 8;
                int val = 0;
                switch (ri.size)
                {
                    case 1:
                        val = ramData.Read8(offset);
                        int bitIndex = ri.offset % 8;
                        val = (val >> bitIndex) & 1;
                        break;
                    case 8:
                        val = ramData.Read8(offset);
                        break;
                    case 16:
                        val = ramData.Read16(offset);
                        break;
                }

                button_set.Enabled = true;
                textBox_ramVal.Text = Hex.ToString(val);
            }
            else
            {
                button_set.Enabled = false;
            }
        }

        private int GetRamValue(RamItem ri)
        {
            int offset = ri.offset / 8;
            int val = 0;
            switch (ri.size)
            {
                case 1:
                    val = ramData.Read8(offset);
                    int bitIndex = ri.offset % 8;
                    val = (val >> bitIndex) & 1;
                    break;
                case 8:
                    val = ramData.Read8(offset);
                    break;
                case 16:
                    val = ramData.Read16(offset);
                    break;
            }

            return val;
        }

        private void CheckValidRam()
        {
            TreeNode node = treeView_ram.SelectedNode;
            if (node == null)
            {
                button_set.Enabled = false;
                return;
            }

            try
            {
                RamItem ri = (RamItem)node.Tag;
                switch (ri.size)
                {
                    case 1:
                        byte val = Hex.ToByte(textBox_ramVal.Text);
                        if (val > 1)
                        {
                            button_set.Enabled = false;
                            return;
                        }
                        break;
                    case 8:
                        Hex.ToByte(textBox_ramVal.Text);
                        break;
                    case 16:
                        Hex.ToUshort(textBox_ramVal.Text);
                        break;
                }
            }
            catch
            {
                button_set.Enabled = false;
                return;
            }

            button_set.Enabled = true;
        }

        private void textBox_ramVal_TextChanged(object sender, EventArgs e)
        {
            CheckValidRam();
        }

        private void button_set_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView_ram.SelectedNode;
            RamItem ri = (RamItem)node.Tag;
            int val = 0;

            switch (ri.size)
            {
                case 1:
                    val = Hex.ToByte(textBox_ramVal.Text);
                    byte prev = ramData.Read8(ri.offset / 8);
                    int mask = 1 << (ri.offset % 8);
                    if (val == 0)
                    {
                        prev &= (byte)~mask;
                    }
                    else if (val == 1)
                    {
                        prev |= (byte)mask;
                    }
                    else
                    {
                        // TODO
                        return;
                    }
                    ramData.Write8(ri.offset / 8, prev);
                    break;
                case 8:
                    val = Hex.ToByte(textBox_ramVal.Text);
                    ramData.Write8(ri.offset / 8, (byte)val);
                    break;
                case 16:
                    val = Hex.ToUshort(textBox_ramVal.Text);
                    ramData.Write16(ri.offset / 8, (ushort)val);
                    break;
            }

            SetLabelValue(node, val);
            status.ChangeMade();
        }

        private void SaveRam()
        {
            // create new bytestream so additional changes are separate
            byte[] data = (byte[])ramData.Data.Clone();
            currDemo.ramData = new ByteStream(data);
        }

        private void ApplyChanges()
        {
            SaveInputs();
            SaveRam();
            ROM.SaveDemo(currDemo);

            status.Save();
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            ApplyChanges();
        }

        private void button_testDemo_Click(object sender, EventArgs e)
        {
            if (status.UnsavedChanges)
            {
                ApplyChanges();
            }
            Test.Demo((byte)comboBox_demo.SelectedIndex);
        }

        private void statusStrip_importDemo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDemo = new OpenFileDialog();
            //openDemo.Filter = "MAGE demo (*.mgd)|*.mgd";
            openDemo.Filter = Properties.Resources.formDemo_FilterText;
            if (openDemo.ShowDialog() == DialogResult.OK)
            {
                byte[] temp = System.IO.File.ReadAllBytes(openDemo.FileName);
                ByteStream input = new ByteStream(temp);

                try
                {
                    currDemo.Import(input);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.Message, Properties.Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LoadInputs();
                LoadRAM();

                status.ChangeMade();
                ROM.SaveDemo(currDemo);
                status.Save();
            }
        }

        private void statusStrip_exportDemo_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDemo = new SaveFileDialog();
            //saveDemo.Filter = "MAGE demo (*.mgd)|*.mgd";
            saveDemo.Filter = Properties.Resources.formDemo_FilterText;
            if (saveDemo.ShowDialog() == DialogResult.OK)
            {
                currDemo.Export(saveDemo.FileName);
            }
        }


    }
}
