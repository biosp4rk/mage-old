using System;
using System.Drawing;
using System.Windows.Forms;

namespace mage
{
    public partial class FormRoomOptions : Form
    {
        // fields
        private FormMain main;
        private Room room;

        // constructor
        public FormRoomOptions(FormMain main)
        {
            InitializeComponent();

            this.main = main;
            this.room = main.Room;
            Initialize();
        }

        private void Initialize()
        {
            checkBox_bg0.Enabled = room.BG0.IsRLE;
            checkBox_bg1.Enabled = room.BG1.IsRLE;
            checkBox_bg2.Enabled = room.BG2.IsRLE;

            textBox_width.Text = Hex.ToString(room.Width);
            textBox_height.Text = Hex.ToString(room.Height);
        }

        private void UpdateText(TextBox textBox, Label label, int size)
        {
            try
            {
                double screen = Hex.ToByte(textBox.Text);
                screen = Math.Round((screen - 4) / size, 4);
                label.Text = screen.ToString();
                if (screen % 1 == 0 & screen > 0)
                {
                    label.ForeColor = Color.Black;
                }
                else
                {
                    label.ForeColor = Color.DarkRed;
                }
            }
            catch
            {
                label.Text = "–";
                label.ForeColor = Color.DarkRed;
            }
        }

        private void textBox_width_TextChanged(object sender, EventArgs e)
        {
            UpdateText(textBox_width, label_screenX, 15);
        }

        private void textBox_height_TextChanged(object sender, EventArgs e)
        {
            UpdateText(textBox_height, label_screenY, 10);
        }

        private void button_clearBG_Click(object sender, EventArgs e)
        {
            if (checkBox_bg0.Checked)
            {
                room.BG0.Clear();
                checkBox_bg0.Checked = false;
            }
            if (checkBox_bg1.Checked)
            {
                room.BG1.Clear();
                checkBox_bg1.Checked = false;
            }
            if (checkBox_bg2.Checked)
            {
                room.BG2.Clear();
                checkBox_bg2.Checked = false;
            }
            if (checkBox_clip.Checked)
            {
                room.Clip.Clear();
                checkBox_clip.Checked = false;
            }

            main.ReloadRoom(true);
            room = main.Room;
        }

        private void button_resize_Click(object sender, EventArgs e)
        {
            // get width and height
            byte width, height;
            try
            {
                width = Hex.ToByte(textBox_width.Text);
                height = Hex.ToByte(textBox_height.Text);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("One of the values entered was not valid.\n\n" + ex.Message, 
                    //"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(Properties.Resources.form_OneValueNotValidErrorText + ex.Message,
                    Properties.Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check if valid
            try
            {
                Room.CheckValidSize(width, height);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.Message, Properties.Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            room.backgrounds.ResizeRoom(width, height);
            main.ReloadRoom(true);
            room = main.Room;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
