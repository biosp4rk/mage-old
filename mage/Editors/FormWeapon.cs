using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace mage
{
    public partial class FormWeapon : Form
    {
        // fields
        private class WeaponInfo
        {
            public int graphics;
            public int palette;
            public int width;
            public int height;
            public int value;
        }
        
        private int gfxOffset;
        private int palOffset;
        private int width;
        private int height;
        private int value;

        private FormMain main;
        private ByteStream romStream;
        private Status status;
        private bool loading;

        // constuctor
        public FormWeapon(FormMain main)
        {
            InitializeComponent();

            this.main = main;
            this.romStream = ROM.Stream;

            statusLabel_changes.Text = "";
            status = new Status(statusLabel_changes, button_apply);
            
            InitializeTree();
        }

        private void InitializeTree()
        {
            string[] lines = Version.WeaponData.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            int level = 0;
            TreeNode currNode = new TreeNode();

            foreach (string line in lines)
            {
                if (line.Contains("["))
                {
                    if (level == 0)
                    {
                        currNode = new TreeNode();
                        currNode.Tag = new WeaponInfo();
                        treeView.Nodes.Add(currNode);
                    }
                    else
                    {
                        TreeNode t = new TreeNode();
                        t.Tag = new WeaponInfo();
                        currNode.Nodes.Add(t);
                        currNode = t;
                    }
                    level++;
                }
                else if (line.Contains("]"))
                {
                    currNode = currNode.Parent;
                    level--;
                }
                else
                {
                    MatchCollection mc = Regex.Matches(line, @"[^\t=]+");
                    string label = mc[0].Value;
                    string val = mc[1].Value;
                    WeaponInfo info = (WeaponInfo)currNode.Tag;

                    switch (label)
                    {
                        case "Name":
                            currNode.Text = val;
                            break;
                        case "Graphics":
                            info.graphics = Convert.ToInt32(val, 16);
                            break;
                        case "Palette":
                            info.palette = Convert.ToInt32(val, 16);
                            break;
                        case "Width":
                            info.width = Convert.ToInt32(val, 16);
                            break;
                        case "Height":
                            info.height = Convert.ToInt32(val, 16);
                            break;
                        case "Value":
                            info.value = Convert.ToInt32(val, 16);
                            break;
                    }
                }
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            gfxOffset = 0;
            palOffset = 0;
            width = 0;
            height = 0;
            value = 0;

            TreeNode node = e.Node;
            while (node != null)
            {
                WeaponInfo info = (WeaponInfo)node.Tag;

                if (gfxOffset == 0) { gfxOffset = info.graphics; }
                if (palOffset == 0) { palOffset = info.palette; }
                if (width == 0) { width = info.width; }
                if (height == 0) { height = info.height; }
                if (value == 0) { value = info.value; }

                node = node.Parent;
            }

            loading = true;
            if (value != 0)
            {
                textBox_valOffset.Text = Hex.ToString(value);
                textBox_value.Text = Hex.ToString(romStream.Read8(value));
                textBox_value.Enabled = true;
            }
            else
            {
                textBox_valOffset.Text = "–";
                textBox_value.Text = "";
                textBox_value.Enabled = button_apply.Enabled = false;
            }
            loading = false;

            if (gfxOffset != 0)
            {
                textBox_gfx.Text = Hex.ToString(gfxOffset);
                button_gfx.Enabled = true;
            }
            else
            {
                textBox_gfx.Text = "–";
                button_gfx.Enabled = false;
            }

            if (palOffset != 0)
            {
                textBox_palette.Text = Hex.ToString(palOffset);
                button_palette.Enabled = true;
            }
            else
            {
                textBox_palette.Text = "–";
                button_palette.Enabled = false;
            }

            status.LoadNew();
        }

        private void button_gfx_Click(object sender, EventArgs e)
        {
            FormGraphics form = new FormGraphics(main, gfxOffset, width, height, palOffset);
            form.Show();
        }

        private void button_palette_Click(object sender, EventArgs e)
        {
            FormPalette form = new FormPalette(main, palOffset, 1);
            form.Show();
        }

        private void textBox_value_TextChanged(object sender, EventArgs e)
        {
            if (loading) { return; }
            status.ChangeMade();
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            try
            {
                byte val = Hex.ToByte(textBox_value.Text);
                romStream.Write8(value, val);
                status.Save();
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
