using System;
using System.Windows.Forms;

namespace mage
{
    public partial class FormTestRoom : Form
    {
        // fields
        private FormMain main;

        // constructor
        public FormTestRoom(FormMain main)
        {
            InitializeComponent();

            this.main = main;
        }

        private void button_go_Click(object sender, EventArgs e)
        {
            try
            {
                bool debug = checkBox_debug.Checked;
                byte xPos = Hex.ToByte(textBox_xPos.Text);
                byte yPos = Hex.ToByte(textBox_yPos.Text);
                Test.Room(main, debug, xPos, yPos);

                Close();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("One of the values entered was not valid.\n\n" + ex.Message,
                //    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(Properties.Resources.form_OneValueNotValidErrorText + ex.Message,
                    Properties.Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
