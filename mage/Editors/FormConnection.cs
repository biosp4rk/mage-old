using mage.Properties;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace mage
{
    public partial class FormConnection : Form
    {
        // fields
        private struct AreaConnection
        {
            public byte srcArea;
            public byte srcDoor;
            public byte dstArea;
        }
        private List<AreaConnection> areaConnections;
        private int numAreaConnections;
        
        private struct DoorEvent
        {
            public byte srcArea;
            public byte srcDoor;
            public byte eventVal;
            public byte dstDoor;
        }
        private List<DoorEvent> doorEvents;
        private int numDoorEvents;

        private struct LocationName
        {
            public byte dstArea;
            public byte dstRoom;
            public byte textVal;
        }
        private List<LocationName> locationNames;
        private int numLocationNames;
        private Dictionary<ushort, string> chars;
        private int textPtr;
        private int textOffset;
        private int textCount;

        private struct HatchLockEvent
        {
            public byte dstArea;
            public byte dstRoom;
            public byte eventVal;
            public byte hatchesToLock;
            public bool before;
        }
        private List<HatchLockEvent> hatchLockEvents;

        private string[] areaNames;
        private FormMain main;
        private ByteStream romStream;

        private Status[] statuses;
        private string[] statusLabels;

        // constructor
        public FormConnection(FormMain main, int tab)
        {
            InitializeComponent();

            this.main = main;
            this.romStream = ROM.Stream;
            areaNames = Version.AreaNames;

            statuses = new Status[4];
            statusLabels = new string[4] { "", "", "", "" };

            tabControl.SelectedIndex = tab;
            InitializeTab(tab);
        }

        private void InitializeTab(int tab)
        {
            statusLabel_changes.Text = statusLabels[tabControl.SelectedIndex];

            switch (tab)
            {
                case 0:
                    if (areaConnections != null) { return; }
                    comboBox_areaSrcArea.Items.AddRange(areaNames);
                    comboBox_areaDstArea.Items.AddRange(areaNames);
                    GetAreaConnections();
                    FillAreaConnections();
                    statuses[0] = new Status(statusLabel_changes, button_areaApply);
                    return;
                case 1:
                    if (doorEvents != null) { return; }
                    comboBox_eventSrcArea.Items.AddRange(areaNames);
                    GetDoorEvents();
                    FillDoorEvents();
                    statuses[1] = new Status(statusLabel_changes, button_eventApply);
                    return;
                case 2:
                    if (locationNames != null) { return; }
                    comboBox_locDstArea.Items.AddRange(areaNames);
                    comboBox_locLanguage.Items.AddRange(Version.Languages);
                    GetLocationNames();
                    GetLocationTextPtr();
                    FillLocationNames();
                    statuses[2] = new Status(statusLabel_changes, button_locApply);
                    return;
                case 3:
                    if (hatchLockEvents != null) { return; }
                    comboBox_lockArea.Items.AddRange(areaNames);
                    if (Version.IsMF)
                    {
                        // remove "When" column
                        int width = listView_lockHatches.Columns[2].Width;
                        listView_lockHatches.Columns.RemoveAt(2);
                        listView_lockHatches.Columns[2].Width += width;
                        // hide radio buttons
                        radioButton_lockBefore.Visible = false;
                        radioButton_lockAfter.Visible = false;
                    }
                    else
                    {
                        //listBox_lockHatches.Items.AddRange(new string[] { "Hatch 6", "Hatch 7" });
                        listBox_lockHatches.Items.AddRange(new string[] { Resources.formConn_lockHatchesItems6, Resources.formConn_lockHatchesItems7 });
                    }
                    GetHatchLockEvents();
                    FillHatchLockEvents();
                    statuses[3] = new Status(statusLabel_changes, button_lockApply);
                    return;
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeTab(tabControl.SelectedIndex);
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        // area connection methods
        private void GetAreaConnections()
        {
            int offset = Version.AreaConnectionsOffset;
            areaConnections = new List<AreaConnection>();
            numAreaConnections = 0;

            for (int i = 0; i < 0x100; i++)
            {
                byte srcArea = romStream.Read8(offset++);
                if (srcArea == 0xFF) { break; }

                AreaConnection ac;
                ac.srcArea = srcArea;
                ac.srcDoor = romStream.Read8(offset++);
                ac.dstArea = romStream.Read8(offset++);
                numAreaConnections++;

                // check for valid source and destination
                Door src = DoorData.GetDoor(ac.srcArea, ac.srcDoor);
                if (src == null) { continue; }

                Door dst = DoorData.GetDoor(ac.dstArea, src.dstDoor);
                if (dst == null) { continue; }

                areaConnections.Add(ac);
            }
        }

        private void FillAreaConnections()
        {
            foreach (AreaConnection ac in areaConnections)
            {
                Door src = DoorData.GetDoor(ac.srcArea, ac.srcDoor);
                string area = areaNames[ac.srcArea] + ", ";
                string room = Resources.formConn_StringRoom+" " + Hex.ToString(src.srcRoom) + ", ";
                string door = Resources.formConn_StringDoor+" " + Hex.ToString(ac.srcDoor);
                ListViewItem item = new ListViewItem(area + room + door);

                Door dst = DoorData.GetDoor(ac.dstArea, src.dstDoor);
                area = areaNames[ac.dstArea] + ", ";
                room = Resources.formConn_StringRoom+" " + Hex.ToString(dst.srcRoom) + ", ";
                door = Resources.formConn_StringDoor+" " + Hex.ToString(dst.doorNum);
                item.SubItems.Add(area + room + door);

                listView_areaConnections.Items.Add(item);
            }
        }

        private void listView_areaConnections_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_areaRemove.Enabled = listView_areaConnections.SelectedIndices.Count == 1;
        }

        private void button_areaAdd_Click(object sender, EventArgs e)
        {
            if (!TryUpdateAreaInfo()) { return; }

            // get values
            byte srcArea = (byte)comboBox_areaSrcArea.SelectedIndex;
            string srcRoom = label_areaSrcRoom.Text;
            byte srcDoor = Hex.ToByte(textBox_areaSrcDoor.Text);

            byte dstArea = (byte)comboBox_areaDstArea.SelectedIndex;
            string dstRoom = label_areaDstRoom.Text;
            string dstDoor = label_areaDstDoor.Text;

            // add area connection to list
            AreaConnection ac;
            ac.srcArea = srcArea;
            ac.srcDoor = srcDoor;
            ac.dstArea = dstArea;
            areaConnections.Add(ac);

            // display
            Door src = DoorData.GetDoor(srcArea, srcDoor);
            string area = areaNames[srcArea] + ", ";
            string room = Resources.formConn_StringRoom+" " + Hex.ToString(src.srcRoom) + ", ";
            string door = Resources.formConn_StringDoor+" " + Hex.ToString(srcDoor);
            ListViewItem item = new ListViewItem(area + room + door);

            Door dst = DoorData.GetDoor(dstArea, Hex.ToByte(dstDoor));
            area = areaNames[dstArea] + ", ";
            room = Resources.formConn_StringRoom+" " + Hex.ToString(dst.srcRoom) + ", ";
            door = Resources.formConn_StringDoor+" " + Hex.ToString(dst.doorNum);
            item.SubItems.Add(area + room + door);

            listView_areaConnections.Items.Add(item);
            item.EnsureVisible();

            // clear controls
            textBox_areaSrcDoor.Text = "";
            comboBox_areaSrcArea.SelectedIndex = -1;
            comboBox_areaDstArea.SelectedIndex = -1;

            statuses[0].ChangeMade();
            statusLabels[0] = statusLabel_changes.Text;
        }

        private void button_areaRemove_Click(object sender, EventArgs e)
        {
            int index = listView_areaConnections.SelectedIndices[0];
            areaConnections.RemoveAt(index);
            listView_areaConnections.Items.RemoveAt(index);

            button_areaRemove.Enabled = false;

            statuses[0].ChangeMade();
            statusLabels[0] = statusLabel_changes.Text;
        }

        private bool TryUpdateAreaInfo()
        {
            int srcArea = comboBox_areaSrcArea.SelectedIndex;
            int dstArea = comboBox_areaDstArea.SelectedIndex;
            if (srcArea == -1 || dstArea == -1) { return false; }

            try
            {
                Door src = DoorData.GetDoor((byte)srcArea, Hex.ToByte(textBox_areaSrcDoor.Text));
                string srcRoom = Hex.ToString(src.srcRoom);

                Door dst = DoorData.GetDoor((byte)dstArea, src.dstDoor);
                string dstRoom = Hex.ToString(dst.srcRoom);
                string dstDoor = Hex.ToString(dst.doorNum);

                label_areaSrcRoom.Text = srcRoom;
                label_areaDstRoom.Text = dstRoom;
                label_areaDstDoor.Text = dstDoor;
                button_areaAdd.Enabled = true;
                return true;
            }
            catch
            {
                label_areaSrcRoom.Text = "–";
                label_areaDstRoom.Text = "–";
                label_areaDstDoor.Text = "–";
                button_areaAdd.Enabled = false;
                return false;
            }
        }

        private void control_areaInfo_Changed(object sender, EventArgs e)
        {
            TryUpdateAreaInfo();
        }

        private void button_areaApply_Click(object sender, EventArgs e)
        {
            // get all area connections
            ByteStream dataToWrite = new ByteStream();

            foreach (AreaConnection ac in areaConnections)
            {
                dataToWrite.Write8(ac.srcArea);
                dataToWrite.Write8(ac.srcDoor);
                dataToWrite.Write8(ac.dstArea);
            }
            dataToWrite.Write8(0xFF);
            dataToWrite.Write8(0xFF);
            dataToWrite.Write8(0xFF);

            // save to rom
            int offset = Version.AreaConnectionsOffset;
            int prevLen = (numAreaConnections + 1) * 3;
            numAreaConnections = areaConnections.Count;
            romStream.Write2(dataToWrite, prevLen, ref offset, true);

            statuses[0].Save();
            statusLabels[0] = statusLabel_changes.Text;
        }

        // event connection methods
        private void GetDoorEvents()
        {
            // check if code changes have been applied
            Patch p = Version.DoorEventCode;
            if (!p.IsApplied())
            {
                p.Apply();
            }

            int offset = Version.DoorEventsOffset;
            numDoorEvents = Version.NumOfDoorEvents;
            doorEvents = new List<DoorEvent>();

            for (int i = 0; i < numDoorEvents; i++)
            {
                DoorEvent de;
                de.srcArea = romStream.Read8(offset++);
                de.srcDoor = romStream.Read8(offset++);
                de.eventVal = romStream.Read8(offset++);
                de.dstDoor = romStream.Read8(offset++);

                // check for valid source and destination
                Door src = DoorData.GetDoor(de.srcArea, de.srcDoor);
                if (src == null) { continue; }

                Door dst = DoorData.GetDoor(de.srcArea, de.dstDoor);
                if (dst == null) { continue; }

                doorEvents.Add(de);
            }
        }

        private void FillDoorEvents()
        {
            foreach (DoorEvent de in doorEvents)
            {
                Door src = DoorData.GetDoor(de.srcArea, de.srcDoor);
                string area = areaNames[de.srcArea] + ", ";
                string room = Resources.formConn_StringRoom+" " + Hex.ToString(src.srcRoom) + ", ";
                string door = Resources.formConn_StringDoor+" " + Hex.ToString(de.srcDoor);
                ListViewItem item = new ListViewItem(area + room + door);

                item.SubItems.Add(Hex.ToString(de.eventVal));

                Door dst = DoorData.GetDoor(de.srcArea, de.dstDoor);
                room = Resources.formConn_StringRoom+" " + Hex.ToString(dst.srcRoom) + ", ";
                door = Resources.formConn_StringDoor+" " + Hex.ToString(de.dstDoor);
                item.SubItems.Add(area + room + door);

                listView_doorEvents.Items.Add(item);
            }
        }

        private void listView_doorEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_eventRemove.Enabled = listView_doorEvents.SelectedIndices.Count == 1;
        }

        private void button_eventAdd_Click(object sender, EventArgs e)
        {
            if (!TryUpdateEventInfo()) { return; }

            // get values
            byte srcArea = (byte)comboBox_eventSrcArea.SelectedIndex;
            string srcRoom = label_eventSrcRoom.Text;
            byte srcDoor = Hex.ToByte(textBox_eventSrcDoor.Text);

            string dstRoom = label_eventDstRoom.Text;
            byte dstDoor = Hex.ToByte(textBox_eventDstDoor.Text);

            byte eventVal = Hex.ToByte(textBox_event.Text);

            // add event connection to list
            DoorEvent de;
            de.srcArea = srcArea;
            de.srcDoor = srcDoor;
            de.eventVal = eventVal;
            de.dstDoor = dstDoor;
            doorEvents.Add(de);

            // display in list view
            Door src = DoorData.GetDoor(srcArea, srcDoor);
            string area = areaNames[srcArea] + ", ";
            string room = Resources.formConn_StringRoom+" " + Hex.ToString(src.srcRoom) + ", ";
            string door = Resources.formConn_StringDoor+" " + Hex.ToString(srcDoor);
            ListViewItem item = new ListViewItem(area + room + door);

            item.SubItems.Add(Hex.ToString(eventVal));

            Door dst = DoorData.GetDoor(srcArea, dstDoor);
            room = Resources.formConn_StringRoom+" " + Hex.ToString(dst.srcRoom) + ", ";
            door = Resources.formConn_StringDoor+" " + Hex.ToString(dstDoor);
            item.SubItems.Add(area + room + door);

            listView_doorEvents.Items.Add(item);
            item.EnsureVisible();

            // clear controls
            textBox_eventSrcDoor.Text = "";
            textBox_eventDstDoor.Text = "";
            textBox_event.Text = "";
            comboBox_eventSrcArea.SelectedIndex = -1;

            statuses[1].ChangeMade();
            statusLabels[1] = statusLabel_changes.Text;
        }

        private void button_eventRemove_Click(object sender, EventArgs e)
        {
            int index = listView_doorEvents.SelectedIndices[0];
            doorEvents.RemoveAt(index);
            listView_doorEvents.Items.RemoveAt(index);

            button_eventRemove.Enabled = false;

            statuses[1].ChangeMade();
            statusLabels[1] = statusLabel_changes.Text;
        }

        private bool TryUpdateEventInfo()
        {
            int srcArea = comboBox_eventSrcArea.SelectedIndex;
            if (srcArea == -1) { return false; }

            // check area and door numbers
            try
            {
                Door src = DoorData.GetDoor((byte)srcArea, Hex.ToByte(textBox_eventSrcDoor.Text));
                string srcRoom = Hex.ToString(src.srcRoom);

                byte dstDoor = Hex.ToByte(textBox_eventDstDoor.Text);
                Door dst = DoorData.GetDoor((byte)srcArea, dstDoor);
                string dstRoom = Hex.ToString(dst.srcRoom);

                label_eventSrcRoom.Text = srcRoom;
                label_eventDstArea.Text = areaNames[srcArea];
                label_eventDstRoom.Text = dstRoom;
            }
            catch
            {
                label_eventSrcRoom.Text = "–";
                label_eventDstArea.Text = "–";
                label_eventDstRoom.Text = "–";
                button_eventAdd.Enabled = false;
                return false;
            }

            // check event number
            try
            {
                Hex.ToByte(textBox_event.Text);
            }
            catch
            {
                button_eventAdd.Enabled = false;
                return false;
            }

            button_eventAdd.Enabled = true;
            return true;
        }

        private void control_eventInfo_Changed(object sender, EventArgs e)
        {
            TryUpdateEventInfo();
        }

        private void button_eventApply_Click(object sender, EventArgs e)
        {
            // get all event connections
            ByteStream dataToWrite = new ByteStream();

            foreach (DoorEvent de in doorEvents)
            {
                dataToWrite.Write8(de.srcArea);
                dataToWrite.Write8(de.srcDoor);
                dataToWrite.Write8(de.eventVal);
                dataToWrite.Write8(de.dstDoor);
            }

            // write to rom
            int offset = Version.DoorEventsOffset;
            int prevLen = numDoorEvents * 4;
            numDoorEvents = doorEvents.Count;
            romStream.Write2(dataToWrite, prevLen, ref offset, true);

            // write new length
            Version.NumOfDoorEvents = (byte)numDoorEvents;

            statuses[1].Save();
            statusLabels[1] = statusLabel_changes.Text;
        }

        // location name methods
        private void GetLocationNames()
        {
            // check if code changes have been applied
            Patch p = Version.LocationNameCode;
            if (!p.IsApplied())
            {
                p.Apply();
            }

            int offset = Version.LocationNamesOffset;
            locationNames = new List<LocationName>();
            numLocationNames = 0;

            for (int i = 0; i < 0x100; i++)
            {
                byte dstArea = romStream.Read8(offset++);
                if (dstArea == 0xFF) { break; }

                LocationName ln;
                ln.dstArea = dstArea;
                ln.dstRoom = romStream.Read8(offset++);
                ln.textVal = romStream.Read8(offset++);
                numLocationNames++;

                // check for valid area
                if (dstArea > Version.AreaNames.Length) { continue; }
                
                locationNames.Add(ln);
            }
        }

        private void FillLocationNames()
        {
            foreach (LocationName ln in locationNames)
            {
                string area = areaNames[ln.dstArea] + ", ";
                string room = Resources.formConn_StringRoom+" " + Hex.ToString(ln.dstRoom);
                ListViewItem item = new ListViewItem(area + room);

                item.SubItems.Add(Hex.ToString(ln.textVal));

                item.SubItems.Add("");

                listView_locNames.Items.Add(item);
            }

            comboBox_locLanguage.SelectedIndex = 2;
        }

        private void GetLocationTextPtr()
        {
            // initialize dictionary
            chars = new Dictionary<ushort, string>();
            string[] charList = Version.CharacterList;
            foreach (string s in charList)
            {
                string[] items = s.Split('\t');
                ushort val = Convert.ToUInt16(items[0], 16);
                chars.Add(val, items[1]);
            }

            // get pointer and length of location names
            string gameCode = Version.GameCode;
            string[] lines = Properties.Resources.textLists.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            int index = 0;
            while (!lines[index].Contains(gameCode))
            {
                index++;
            }

            //orignal code
            /*index++;

            while (index < lines.Length)
            {
                MatchCollection mc = Regex.Matches(lines[index++], @"[^\t,]+");
                if (mc[2].Value == "Locations")
                {
                    textPtr = Convert.ToInt32(mc[0].Value, 16);
                    textCount = Convert.ToInt32(mc[1].Value, 16);
                    break;
                }
            }*/

            //adjust for localization. fusion game code is AMT?, zero mission game code is BMX? (? is region code, E-USA J-Japan P-Europe C-China)
            //make index point to Locations line
            index += gameCode.StartsWith("AM") ? 4 : 3;
            MatchCollection mc = Regex.Matches(lines[index], @"[^\t,]+");
            textPtr = Convert.ToInt32(mc[0].Value, 16);
            textCount = Convert.ToInt32(mc[1].Value, 16);

        }

        private void listView_locNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_locRemove.Enabled = listView_locNames.SelectedIndices.Count == 1;
        }

        private void button_locAdd_Click(object sender, EventArgs e)
        {
            if (!TryUpdateLocationInfo()) { return; }

            // get values
            byte dstArea = (byte)comboBox_locDstArea.SelectedIndex;
            byte dstRoom = Hex.ToByte(textBox_locDstRoom.Text);
            byte textVal = Hex.ToByte(textBox_locText.Text);

            // add location name to list
            LocationName ln;
            ln.dstArea = dstArea;
            ln.dstRoom = dstRoom;
            ln.textVal = textVal;
            locationNames.Add(ln);

            // display
            string area = areaNames[dstArea] + ", ";
            string room = Resources.formConn_StringRoom+" " + Hex.ToString(dstRoom);
            ListViewItem item = new ListViewItem(area + room);

            item.SubItems.Add(Hex.ToString(textVal));

            string display = GetLocationText(textVal);
            item.SubItems.Add(display);

            listView_locNames.Items.Add(item);
            item.EnsureVisible();

            // clear controls
            textBox_locDstRoom.Text = "";
            textBox_locText.Text = "";
            comboBox_locDstArea.SelectedIndex = -1;

            statuses[2].ChangeMade();
            statusLabels[2] = statusLabel_changes.Text;
        }

        private void button_locRemove_Click(object sender, EventArgs e)
        {
            int index = listView_locNames.SelectedIndices[0];
            locationNames.RemoveAt(index);
            listView_locNames.Items.RemoveAt(index);

            button_locRemove.Enabled = false;

            statuses[2].ChangeMade();
            statusLabels[2] = statusLabel_changes.Text;
        }

        private bool TryUpdateLocationInfo()
        {
            // check text number
            try
            {
                byte textVal = Hex.ToByte(textBox_locText.Text);
                if (textVal >= textCount) { throw new ArgumentOutOfRangeException(); }

                label_locName.Text = GetLocationText(textVal);
            }
            catch
            {
                label_locName.Text = "–";
                button_eventAdd.Enabled = false;
                return false;
            }

            int dstArea = comboBox_locDstArea.SelectedIndex;
            if (dstArea == -1) { return false; }

            try
            {
                byte dstRoom = Hex.ToByte(textBox_locDstRoom.Text);
                if (dstRoom >= Version.RoomsPerArea[dstArea])
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch
            {
                button_locAdd.Enabled = false;
                return false;
            }

            button_locAdd.Enabled = true;
            return true;
        }

        private void control_locInfo_Changed(object sender, EventArgs e)
        {
            TryUpdateLocationInfo();
        }

        private string GetLocationText(byte textVal)
        {
            int offset = romStream.ReadPtr(textOffset + textVal * 4);

            // get text data
            List<ushort> textVals = new List<ushort>();
            while (true)
            {
                ushort val = romStream.Read16(offset);
                textVals.Add(val);
                if (val == 0xFF00) { break; }
                offset += 2;
            }

            // get text string
            string display = "";
            foreach (ushort val in textVals)
            {
                if (chars.ContainsKey(val))
                {
                    display += chars[val];
                }
                else if (val >> 8 == 0xFF) { break; }
            }

            return display;
        }

        private void UpdateNameLanguage()
        {
            for (int i = 0; i < locationNames.Count; i++)
            {
                string display = GetLocationText(locationNames[i].textVal);
                ListViewItem item = listView_locNames.Items[i];
                item.SubItems[2].Text = display;
            }
        }
        
        private void comboBox_locLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            textOffset = romStream.ReadPtr(textPtr + comboBox_locLanguage.SelectedIndex * 4);
            UpdateNameLanguage();
        }

        private void button_locApply_Click(object sender, EventArgs e)
        {
            // get all location names
            ByteStream dataToWrite = new ByteStream();

            foreach (LocationName ln in locationNames)
            {
                dataToWrite.Write8(ln.dstArea);
                dataToWrite.Write8(ln.dstRoom);
                dataToWrite.Write8(ln.textVal);
            }
            dataToWrite.Write8(0xFF);
            dataToWrite.Write8(0xFF);
            dataToWrite.Write8(0xFF);

            // write to rom
            int offset = Version.LocationNamesOffset;
            int prevLen = (numLocationNames + 1) * 3;
            numLocationNames = locationNames.Count;
            romStream.Write2(dataToWrite, prevLen, ref offset, true);

            statuses[2].Save();
            statusLabels[2] = statusLabel_changes.Text;
        }

        // hatch lock event methods
        private void GetHatchLockEvents()
        {
            hatchLockEvents = new List<HatchLockEvent>();

            if (Version.IsMF)
            {
                GetHatchLockEventsMF();
            }
            else
            {
                GetHatchLockEventsZM();
            }
        }

        private void GetHatchLockEventsMF()
        {
            int offset = Version.HatchLockEventsOffset;
            int count = Version.NumOfHatchLockEvents;

            for (int i = 0; i < count; i++)
            {
                HatchLockEvent hle;
                hle.before = false;
                hle.eventVal = romStream.Read8(offset++);
                hle.dstArea = romStream.Read8(offset++);
                hle.dstRoom = (byte)(romStream.Read8(offset++) - 1);
                hle.hatchesToLock = romStream.Read8(offset++);

                if (hle.dstArea >= areaNames.Length) { continue; }
                if (hle.dstRoom >= Version.RoomsPerArea[hle.dstArea]) { continue; }                

                hatchLockEvents.Add(hle);
            }
        }

        private void GetHatchLockEventsZM()
        {
            int countOffset = Version.NumOfHatchLockEventsOffset;
            int ptrOffset = Version.HatchLockEventsOffset;

            for (byte area = 0; area < areaNames.Length; area++)
            {
                int count = romStream.Read16(countOffset);
                countOffset += 2;
                int offset = romStream.ReadPtr(ptrOffset);
                ptrOffset += 4;

                for (int c = 0; c < count; c++)
                {
                    HatchLockEvent hle;
                    hle.dstRoom = romStream.Read8(offset);
                    hle.eventVal = romStream.Read8(offset + 1);
                    hle.before = Convert.ToBoolean(romStream.Read8(offset + 2));
                    hle.hatchesToLock = romStream.Read8(offset + 3);
                    hle.dstArea = area;
                    offset += 8; 
                    
                    if (hle.dstRoom >= Version.RoomsPerArea[area]) { continue; }

                    hatchLockEvents.Add(hle);
                }
            }
        }

        private void FillHatchLockEvents()
        {
            foreach (HatchLockEvent hle in hatchLockEvents)
            {
                string area = areaNames[hle.dstArea] + ", ";
                string room = Resources.formConn_StringRoom+" " + Hex.ToString(hle.dstRoom);
                ListViewItem item = new ListViewItem(area + room);

                item.SubItems.Add(Hex.ToString(hle.eventVal));

                if (!Version.IsMF)
                {
                    if (hle.before) { item.SubItems.Add(Resources.formConn_StringBefore); }
                    else { item.SubItems.Add(Resources.formConn_StringAfter); }
                }

                string hatches = GetLockedHatchesText(hle.hatchesToLock);
                item.SubItems.Add(hatches);

                listView_lockHatches.Items.Add(item);
            }
        }

        private void listView_lockHatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_lockRemove.Enabled = listView_lockHatches.SelectedIndices.Count == 1;
        }

        private void button_lockAdd_Click(object sender, EventArgs e)
        {
            // get values
            byte dstArea = (byte)comboBox_lockArea.SelectedIndex;
            byte dstRoom = Hex.ToByte(textBox_lockRoom.Text);
            byte eventVal = Hex.ToByte(textBox_lockEvent.Text);
            bool before = radioButton_lockBefore.Checked;
            byte hatchesToLock = 0;
            foreach (int i in listBox_lockHatches.SelectedIndices)
            {
                hatchesToLock |= (byte)(1 << i);
            }

            // get index
            int index = 0;
            if (Version.IsMF)
            {
                while (index < hatchLockEvents.Count && eventVal >= hatchLockEvents[index].eventVal)
                {
                    index++;
                }
            }
            else
            {
                while (index < hatchLockEvents.Count && dstArea > hatchLockEvents[index].dstArea)
                {
                    index++;
                }
                while (index < hatchLockEvents.Count && 
                    dstArea == hatchLockEvents[index].dstArea &&
                    dstRoom >= hatchLockEvents[index].dstRoom)
                {
                    index++;
                }
            }
            

            // add hatch lock event to list
            HatchLockEvent hle;
            hle.dstArea = dstArea;
            hle.dstRoom = dstRoom;
            hle.eventVal = eventVal;
            hle.before = before;
            hle.hatchesToLock = hatchesToLock;
            hatchLockEvents.Insert(index, hle);

            // display
            string area = areaNames[dstArea] + ", ";
            string room = Resources.formConn_StringRoom+" " + Hex.ToString(dstRoom);
            ListViewItem item = new ListViewItem(area + room);

            item.SubItems.Add(Hex.ToString(eventVal));

            if (!Version.IsMF)
            {
                if (before) { item.SubItems.Add(Resources.formConn_StringBefore); }
                else { item.SubItems.Add(Resources.formConn_StringAfter); }
            }

            string hatches = GetLockedHatchesText(hle.hatchesToLock);
            item.SubItems.Add(hatches);

            listView_lockHatches.Items.Insert(index, item);
            item.EnsureVisible();

            // clear controls
            textBox_lockRoom.Text = "";
            textBox_lockEvent.Text = "";
            radioButton_lockBefore.Checked = false;
            radioButton_lockAfter.Checked = false;
            listBox_lockHatches.ClearSelected();
            comboBox_lockArea.SelectedIndex = -1;

            statuses[3].ChangeMade();
            statusLabels[3] = statusLabel_changes.Text;
        }

        private void button_lockRemove_Click(object sender, EventArgs e)
        {
            int index = listView_lockHatches.SelectedIndices[0];
            hatchLockEvents.RemoveAt(index);
            listView_lockHatches.Items.RemoveAt(index);

            button_lockRemove.Enabled = false;

            statuses[3].ChangeMade();
            statusLabels[3] = statusLabel_changes.Text;
        }

        private string GetLockedHatchesText(byte hatchesToLock)
        {
            string hatches = "";
            for (int i = 0; i <= 6; i++)
            {
                if ((hatchesToLock >> i & 1) == 1)
                {
                    hatches += i + ", ";
                }
            }
            return hatches.TrimEnd(',', ' ');
        }

        private void control_lockInfo_Changed(object sender, EventArgs e)
        {
            // check area
            int dstArea = comboBox_lockArea.SelectedIndex;
            if (dstArea == -1) { return; }

            // check before/after
            if (!Version.IsMF && !radioButton_lockBefore.Checked && !radioButton_lockAfter.Checked) { return; }

            try
            {
                // check room
                byte dstRoom = Hex.ToByte(textBox_lockRoom.Text);
                if (dstRoom >= Version.RoomsPerArea[dstArea])
                {
                    throw new ArgumentOutOfRangeException();
                }

                // check event
                Hex.ToByte(textBox_lockEvent.Text);
            }
            catch
            {
                button_lockAdd.Enabled = false;
                return;
            }

            // check hatches selected
            if (listBox_lockHatches.SelectedIndices.Count == 0)
            {
                button_lockAdd.Enabled = false;
                return;
            }

            button_lockAdd.Enabled = true;
        }

        private void button_lockApply_Click(object sender, EventArgs e)
        {
            if (Version.IsMF)
            {
                ByteStream dataToWrite = new ByteStream();

                foreach (HatchLockEvent hle in hatchLockEvents)
                {
                    dataToWrite.Write8(hle.eventVal);
                    dataToWrite.Write8(hle.dstArea);
                    dataToWrite.Write8((byte)(hle.dstRoom + 1));
                    dataToWrite.Write8(hle.hatchesToLock);
                }
                dataToWrite.Write8(0xF0);
                dataToWrite.Write8(0xF0);

                // write to rom
                int offset = Version.HatchLockEventsOffset;
                byte count = Version.NumOfHatchLockEvents;
                int prevLen = count * 4 + 2;
                Version.NumOfHatchLockEvents = (byte)hatchLockEvents.Count;
                romStream.Write2(dataToWrite, prevLen, ref offset, true);
            }
            else
            {
                int countOffset = Version.NumOfHatchLockEventsOffset;
                int ptrOffset = Version.HatchLockEventsOffset;
                int index = 0;

                for (byte area = 0; area < areaNames.Length; area++)
                {
                    ByteStream dataToWrite = new ByteStream();
                    ushort newCount = 0;

                    while (index < hatchLockEvents.Count && hatchLockEvents[index].dstArea == area)
                    {
                        HatchLockEvent hle = hatchLockEvents[index];
                        dataToWrite.Write8(hle.dstRoom);
                        dataToWrite.Write8(hle.eventVal);
                        dataToWrite.Write8(Convert.ToByte(hle.before));
                        dataToWrite.Write8(hle.hatchesToLock);
                        dataToWrite.Write8(0);
                        dataToWrite.Write8(0);
                        dataToWrite.Write8(0);
                        dataToWrite.Write8(0);
                        index++;
                        newCount++;
                    }

                    // write to rom
                    int count = romStream.Read16(countOffset);
                    int prevLen = count * 8;
                    romStream.Write16(countOffset, newCount);
                    romStream.Write(dataToWrite, prevLen, ptrOffset, false);

                    countOffset += 2;
                    ptrOffset += 4;
                }
            }

            statuses[3].Save();
            statusLabels[3] = statusLabel_changes.Text;
        }


    }
}
