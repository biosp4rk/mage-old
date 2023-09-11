using mage.Theming;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mage
{
    public partial class FormEditDoorPresets : Form
    {
        public byte Result { get; set; }

        public FormEditDoorPresets(bool isX)
        {
            InitializeComponent();

            ThemeSwitcher.ChangeTheme(this.Controls, this);
            ThemeSwitcher.InjectPaintOverrides(this.Controls);

            if (isX)
            {
                button_y1.Enabled = false;
                button_y2.Enabled = false;
                button_y_n1.Enabled = false;
                button_y_n2.Enabled = false;
            }
            else
            {
                button_x1.Enabled = false;
                button_x2.Enabled = false;
                button_x_n1.Enabled = false;
                button_x_n2.Enabled = false;
            }
        }

        private void button_x1_Click(object sender, EventArgs e)
        {
            Result = 0x10;
            clickedButton();
        }

        private void button_x2_Click(object sender, EventArgs e)
        {
            Result = 0x20;
            clickedButton();
        }

        private void button_x_n1_Click(object sender, EventArgs e)
        {
            Result = 0xF0;
            clickedButton();
        }

        private void button_x_n2_Click(object sender, EventArgs e)
        {
            Result = 0xE0;
            clickedButton();
        }

        private void clickedButton()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
