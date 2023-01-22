using System;
using System.Windows.Forms;

namespace mage
{
    public partial class FormEditScroll : Form
    {
        private int scrollNum;

        private FormMain main;
        private Room room;
        private Status status;
        private bool loading;

        public FormEditScroll(FormMain main, int scrollNum)
        {
            InitializeComponent();

            this.main = main;
            this.scrollNum = scrollNum;

            this.room = main.Room;

            Initialize();
        }

        private void Initialize()
        {
            status = new Status(statusLabel_changes, button_apply);
            status.LoadNew();
            loading = true;

            Scroll scroll = room.scrollList[scrollNum / 6];
            checkBox_breakable.Checked = (scroll.xBreak != 0xFF);

            if (scroll.replace == 0xFF)
            {
                comboBox_direction.SelectedIndex = 0;
            }
            else
            {
                comboBox_direction.SelectedIndex = scroll.replace + 1;
            }

            loading = false;
        }

        private void comboBox_direction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_direction.SelectedIndex > 0)
            {
                checkBox_breakable.Enabled = true;
            }
            else
            {
                checkBox_breakable.Enabled = false;
                checkBox_breakable.Checked = false;
            }

            if (!loading) { status.ChangeMade(); }
        }

        private void checkBox_breakable_CheckedChanged(object sender, EventArgs e)
        {
            if (!loading) { status.ChangeMade(); }
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            Scroll scroll = (Scroll)room.scrollList[scrollNum / 6].Copy();
            int index = comboBox_direction.SelectedIndex;
            if (index == 0)
            {
                scroll.replace = 0xFF;
            }
            else if (index - 1 != scroll.replace)
            {
                scroll.replace = (byte)(index - 1);
                switch (scroll.replace)
                {
                    case 0:
                        scroll.newBound = (byte)(scroll.xStart - 1);
                        break;
                    case 1:
                        scroll.newBound = (byte)(scroll.xEnd + 1);
                        break;
                    case 2:
                        scroll.newBound = (byte)(scroll.yStart - 1);
                        break;
                    case 3:
                        scroll.newBound = (byte)(scroll.yEnd + 1);
                        break;
                }
            }
            if (checkBox_breakable.Checked)
            {
                if (scroll.xBreak == 0xFF)
                {
                    switch (scroll.replace)
                    {
                        case 0:
                            scroll.xBreak = (byte)scroll.xStart;
                            scroll.yBreak = (byte)(scroll.yStart + 1);
                            break;
                        case 1:
                            scroll.xBreak = (byte)scroll.xEnd;
                            scroll.yBreak = (byte)(scroll.yStart + 1);
                            break;
                        case 2:
                            scroll.xBreak = (byte)(scroll.xStart + 1);
                            scroll.yBreak = (byte)scroll.yStart;
                            break;
                        case 3:
                            scroll.xBreak = (byte)(scroll.xStart + 1);
                            scroll.yBreak = (byte)scroll.yEnd;
                            break;
                    }
                }
            }
            else
            {
                scroll.xBreak = 0xFF;
                scroll.yBreak = 0xFF;
            }

            EditRoomObject a = new EditRoomObject(scroll, scrollNum, false);
            main.PerformAction(a);

            status.Save();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
