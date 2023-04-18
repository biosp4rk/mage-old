using System;
using System.Drawing;
using System.Windows.Forms;

namespace mage
{
    public partial class FormEditDoor : Form
    {
        // fields
        private int doorNum;
        private string[] areaNames;

        private FormMain main;
        private ByteStream romStream;
        private Room room;
        private Status status;
        private bool loading;

        // constructor
        public FormEditDoor(FormMain main, int doorNum)
        {
            InitializeComponent();

            this.main = main;
            this.romStream = ROM.Stream;
            this.doorNum = doorNum;

            this.room = main.Room;

            Initialize();
        }

        private void Initialize()
        {
            status = new Status(statusLabel_changes, button_apply);
            status.LoadNew();
            loading = true;

            Door door = room.doorList[doorNum];

            // type
            if (Version.IsMF)
            {
                //comboBox_type.Items.Add("Hatch (can lock)");
                comboBox_type.Items.Add(Properties.Resources.formEditDoor_HatchTypeLcok);
            }
            else
            {
                //comboBox_type.Items.Add("Closed hatch");
                //comboBox_type.Items.Add("Remove mother ship");
                //comboBox_type.Items.Add("Set mother ship");
                comboBox_type.Items.Add(Properties.Resources.formEditDoor_HatchTypeClose);
                comboBox_type.Items.Add(Properties.Resources.formEditDoor_HatchTypeRemove);
                comboBox_type.Items.Add(Properties.Resources.formEditDoor_HatchTypeSet);
            }
            comboBox_type.SelectedIndex = (door.type & 0xF) - 1;
            checkBox_event.Checked = ((door.type & 0x20) != 0);
            checkBox_location.Checked = ((door.type & 0x40) != 0);

            // other values
            textBox_width.Text = Hex.ToString(door.xEnd - door.xStart + 1);
            textBox_height.Text = Hex.ToString(door.yEnd - door.yStart + 1);
            textBox_ownerRoom.Text = Hex.ToString(door.srcRoom);
            textBox_connectedDoor.Text = Hex.ToString(door.dstDoor);
            textBox_xExitDistance.Text = Hex.ToString(door.xExitDistance);
            textBox_yExitDistance.Text = Hex.ToString(door.yExitDistance);

            DisplayInfo(door);

            loading = false;
        }

        private void DisplayInfo(Door src)
        {
            areaNames = Version.AreaNames;
            label_srcArea.Text = areaNames[src.areaID];
            label_srcRoom.Text = Hex.ToString(src.srcRoom);
            label_srcDoor.Text = Hex.ToString(src.doorNum);

            Door dst = DoorData.GetDestinationDoor(src);
            if (dst != null)
            {
                label_dstArea.Text = areaNames[dst.areaID];
                label_dstRoom.Text = Hex.ToString(dst.srcRoom);
                label_dstDoor.Text = Hex.ToString(src.dstDoor);
            }
            else
            {
                label_dstArea.Text = "–";
                label_dstRoom.Text = "–";
                label_dstDoor.Text = "–";
            }
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            if (!loading) { status.ChangeMade(); }
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            bool badArea = false;
            bool badEvent = false;
            bool badLocation = false;
            bool badDst = false;

            try
            {
                Door d = (Door)room.doorList[doorNum].Copy();

                int type;
                if (checkBox_event.Checked) { type = 0x20; }
                else { type = 0x10; }
                if (checkBox_location.Checked) { type |= 0x40; }
                type |= (comboBox_type.SelectedIndex + 1);

                d.type = (byte)type;
                d.dstDoor = Hex.ToByte(textBox_connectedDoor.Text);
                d.xExitDistance = Hex.ToByte(textBox_xExitDistance.Text);
                d.yExitDistance = Hex.ToByte(textBox_yExitDistance.Text);

                // update owner room
                byte srcRoom = Hex.ToByte(textBox_ownerRoom.Text);
                if (srcRoom != d.srcRoom)
                {
                    // set room and move to upper left corner
                    d.srcRoom = srcRoom;
                    d.xEnd -= d.xStart;
                    d.yEnd -= d.yStart;
                    d.xStart = 0; d.yStart = 0;
                }
                else
                {
                    byte width = Hex.ToByte(textBox_width.Text);
                    byte height = Hex.ToByte(textBox_height.Text);
                    if (width == 0 || height == 0)
                    {
                        //throw new FormatException("Width and height must be greater than 0.");
                        throw new FormatException(Properties.Resources.formEditDoor_WidthHeightError);
                    }
                    d.xEnd = (byte)(d.xStart + width - 1);
                    d.yEnd = (byte)(d.yStart + height - 1);
                }

                // check area connection
                byte dstArea = d.areaID;
                if ((d.type & 0xF) == 1)
                {
                    dstArea = DoorData.FindAreaConnection(d);
                    if (dstArea == 0xFF)
                    {
                        badArea = true;
                        dstArea = d.areaID;
                    }

                    // check not also event connection
                    if (checkBox_event.Checked)
                    {
                        //string message = "A door cannot be an area connection and an event connection.";
                        //message += " Only the area connection will apply.";
                        string message = Properties.Resources.formEditDoor_AreaEventText;
                        MessageBox.Show(message, Properties.Resources.form_WarningMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                // check event connection
                if (checkBox_event.Checked)
                {
                    // check if code changes have been applied
                    Patch p = Version.DoorEventCode;
                    if (!p.IsApplied())
                    {
                        p.Apply();
                    }

                    // TODO: move?
                    int offset = Version.DoorEventsOffset;
                    int numDoorEvents = Version.NumOfDoorEvents;
                    bool found = false;

                    for (int i = 0; i < numDoorEvents; i++)
                    {
                        if (d.areaID == romStream.Read8(offset) && d.doorNum == romStream.Read8(offset + 1))
                        {
                            found = true;
                            break;
                        }
                        offset += 4;
                    }

                    if (!found) { badEvent = true; }
                }

                // check location name
                if (checkBox_location.Checked)
                {
                    // check if code changes have been applied
                    Patch p = Version.LocationNameCode;
                    if (!p.IsApplied())
                    {
                        p.Apply();
                    }

                    // TODO: move?
                    int offset = Version.LocationNamesOffset;
                    bool found = false;

                    for (int i = 0; i < 0x100; i++)
                    {
                        byte currArea = romStream.Read8(offset);
                        if (currArea == 0xFF) { break; }

                        if (d.areaID == currArea && d.srcRoom == romStream.Read8(offset + 1))
                        {
                            found = true;
                            break;
                        }
                        offset += 3;
                    }

                    if (!found) { badLocation = true; }
                }

                // update source info
                label_srcArea.Text = areaNames[d.areaID];
                label_srcRoom.Text = Hex.ToString(d.srcRoom);
                label_srcDoor.Text = Hex.ToString(d.doorNum);

                // update destination
                Door dst = DoorData.GetDoor(dstArea, d.dstDoor);
                if (dst != null)
                {
                    // update connected room
                    if (checkBox_autoConnect.Checked && !badArea)
                    {
                        dst.dstDoor = d.doorNum;
                        dst.Edited = true;
                    }

                    label_dstArea.Text = areaNames[dst.areaID];
                    label_dstRoom.Text = Hex.ToString(dst.srcRoom);
                    label_dstDoor.Text = Hex.ToString(d.dstDoor);
                }
                else
                {
                    badDst = true;
                    label_dstArea.Text = "–";
                    label_dstRoom.Text = "–";
                    label_dstDoor.Text = "–";
                }

                EditRoomObject a = new EditRoomObject(d, doorNum, false);
                main.PerformAction(a);
                status.Save();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("One of the values entered was not valid.\n\n" + ex.Message,
                    //"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(Properties.Resources.form_OneValueNotValidErrorText + ex.Message,
                    Properties.Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check for problems
            if (badDst)
            {
                //string message = "The connected door does not exist.";
                //if (checkBox_autoConnect.Checked)
                //{
                //    message += "\n\nDoor could not be automatically connected.";
                //}
                //MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                string message = Properties.Resources.formEditDoor_ConnNotExistText;
                if (checkBox_autoConnect.Checked)
                {
                    message += Properties.Resources.formEditDoor_CannotAutoConnText;
                }
                MessageBox.Show(message, Properties.Resources.form_WarningMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (badArea)
            {
                //string message = "An area connection could not be found for this door.";
                //if (checkBox_autoConnect.Checked)
                //{
                //    message += "\n\nDoor could not be automatically connected.";
                //}
                //message += "\n\nWould you like to add one now?";
                //var result = MessageBox.Show(message, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                string message = Properties.Resources.formEditDoor_AreaNotExistText;
                if (checkBox_autoConnect.Checked)
                {
                    message += Properties.Resources.formEditDoor_CannotAutoConnText;
                }
                message += Properties.Resources.formEditDoor_AddOneConnMessage;
                var result = MessageBox.Show(message, Properties.Resources.form_WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    FormConnection form = new FormConnection(main, 0);
                    form.Show();
                }
            }
            else if (badEvent)
            {
                //string message = "An event based connection could not be found for this door.";
                //message += "\n\nWould you like to add one now?";
                //var result = MessageBox.Show(message, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                string message = Properties.Resources.formEditDoor_EventNotExistText;
                message += Properties.Resources.formEditDoor_AddOneConnMessage;
                var result = MessageBox.Show(message, Properties.Resources.form_WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    FormConnection form = new FormConnection(main, 1);
                    form.Show();
                }
            }
            else if (badLocation)
            {
                //string message = "A location name could not be found for this room.";
                //message += "\n\nWould you like to add one now?";
                //var result = MessageBox.Show(message, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                string message = Properties.Resources.formEditDoor_LocationNotExistText;
                message += Properties.Resources.formEditDoor_AddOneConnMessage;
                var result = MessageBox.Show(message, Properties.Resources.form_WarningMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    FormConnection form = new FormConnection(main, 2);
                    form.Show();
                }
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
