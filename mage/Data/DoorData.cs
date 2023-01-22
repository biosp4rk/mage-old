using System;
using System.Collections.Generic;

namespace mage
{
    public static class DoorData
    {
        // fields
        private static List<Door>[] doors;

        private static ByteStream romStream;

        // methods
        public static void GetData()
        {
            DoorData.romStream = ROM.Stream;
            int numOfAreas = Version.AreaNames.Length;

            doors = new List<Door>[numOfAreas];
            for (byte a = 0; a < numOfAreas; a++)
            {
                List<Door> areaDoors = new List<Door>();
                int offset = romStream.ReadPtr(Version.DoorsOffset + a * 4);
                romStream.Seek(offset);
                byte areaDoorNum = 0;

                while (true)
                {
                    byte val = romStream.Read8();
                    if (val == 0) { break; }

                    Door d = new Door();
                    d.areaID = a;
                    d.doorNum = areaDoorNum;

                    d.type = val;
                    d.srcRoom = romStream.Read8();
                    d.xStart = romStream.Read8();
                    d.xEnd = romStream.Read8();
                    d.yStart = romStream.Read8();
                    d.yEnd = romStream.Read8();
                    d.dstDoor = romStream.Read8();
                    d.xExitDistance = romStream.Read8();
                    d.yExitDistance = romStream.Read8();
                    areaDoors.Add(d);

                    areaDoorNum++;
                    romStream.Align();
                }

                doors[a] = areaDoors;
            }
        }

        public static Door GetDoor(byte areaID, byte doorNum)
        {
            try
            {
                Door d = doors[areaID][doorNum];
                if (d.srcRoom == 0xFF) { return null; }
                return d;
            }
            catch { return null; }
        }

        public static Door GetDestinationDoor(Door d)
        {
            int dstArea = d.areaID;
            if ((d.type & 0xF) == 1)
            {
                dstArea = DoorData.FindAreaConnection(d);
                if (dstArea == 0xFF) { dstArea = d.areaID; }
            }

            return GetDoor((byte)dstArea, d.dstDoor);
        }

        public static byte FindAreaConnection(Door d)
        {
            int offset = Version.AreaConnectionsOffset;
            romStream.Seek(offset);

            for (int i = 0; i < 0x1000; i++)
            {
                byte srcArea = romStream.Read8();
                if (srcArea == 0xFF) { return 0xFF; }

                byte srcDoor = romStream.Read8();
                byte dstArea = romStream.Read8();

                if (srcArea == d.areaID && srcDoor == d.doorNum)
                {
                    return dstArea;
                }
            }

            return 0xFF;
        }

        public static List<Door> GetRoomDoors(byte areaID, byte roomID)
        {
            List<Door> roomDoors = new List<Door>();

            foreach (Door d in doors[areaID])
            {
                if (d.srcRoom == roomID)
                {
                    roomDoors.Add(d);
                }
            }

            return roomDoors;
        }

        public static Door NewDoor(byte areaID, byte roomID)
        {
            // check for previously removed doors
            foreach (Door d in doors[areaID])
            {
                if (d.srcRoom == 0xFF)
                {
                    return d;
                }
            }

            // if none found, return new door
            Door newDoor = new Door();
            newDoor.areaID = areaID;
            newDoor.srcRoom = roomID;
            newDoor.doorNum = (byte)doors[areaID].Count;
            doors[areaID].Add(newDoor);
            return newDoor;
        }

        public static bool CanAddDoor(byte areaID)
        {
            // check for previously removed doors
            foreach (Door d in doors[areaID])
            {
                if (d.srcRoom == 0xFF)
                {
                    return true;
                }
            }

            return doors[areaID].Count < 0xFF;
        }

        public static bool IsEdited()
        {
            foreach (List<Door> doorList in doors)
            {
                foreach (Door d in doorList)
                {
                    if (d.Edited) { return true; }
                }
            }

            return false;
        }

        public static void ResetEdited()
        {
            foreach (List<Door> doorList in doors)
            {
                foreach (Door d in doorList)
                {
                    d.Edited = false;
                }
            }
        }

        private static byte GetOrigNumOfDoors(byte areaID)
        {
            int offset = romStream.ReadPtr(Version.DoorsOffset + areaID * 4);
            byte numOfDoors = 0;

            while (romStream.Read8(offset) != 0)
            {
                numOfDoors++;
                offset += 12;
            }

            return numOfDoors;
        }

        public static void ImportDoor(Door d)
        {
            List<Door> areaDoors = doors[d.areaID];
            byte count = (byte)areaDoors.Count;

            while (count <= d.doorNum)
            {
                Door empty = new Door();
                empty.Edited = true;
                empty.srcRoom = 0xFF;
                empty.doorNum = count++;
                areaDoors.Add(empty);
            }

            areaDoors[d.doorNum] = d;
        }

        public static void Write()
        {
            // for each area
            for (byte a = 0; a < doors.Length; a++)
            {
                List<Door> areaDoors = doors[a];

                // check if area list was edited
                bool areaEdited = false;
                foreach (Door d in areaDoors)
                {
                    if (d.Edited)
                    {
                        areaEdited = true;
                        break;
                    }
                }
                if (!areaEdited) { continue; }

                int areaPtr = Version.DoorsOffset + a * 4;
                int areaOffset = romStream.ReadPtr(areaPtr);

                // get previous length
                int prevNumDoors = GetOrigNumOfDoors(a);
                int prevLen = prevNumDoors * 12;

                // create stream with previous data
                byte[] prevData = new byte[prevLen];
                romStream.CopyToArray(areaOffset, prevData, 0, prevLen);
                ByteStream dataToWrite = new ByteStream(prevData);

                // write edited doors
                foreach (Door d in areaDoors)
                {
                    if (d.Edited)
                    {
                        int offset = d.doorNum * 12;
                        dataToWrite.Seek(offset);
                        dataToWrite.Write8(d.type);
                        dataToWrite.Write8(d.srcRoom);
                        dataToWrite.Write8(d.xStart);
                        dataToWrite.Write8(d.xEnd);
                        dataToWrite.Write8(d.yStart);
                        dataToWrite.Write8(d.yEnd);
                        dataToWrite.Write8(d.dstDoor);
                        dataToWrite.Write8(d.xExitDistance);
                        dataToWrite.Write8(d.yExitDistance);
                        dataToWrite.Write8(0);
                        dataToWrite.Write8(0);
                        dataToWrite.Write8(0);
                    }
                }

                // fill end with 0
                dataToWrite.Seek(dataToWrite.Length);
                for (int i = 0; i < 12; i++)
                {
                    dataToWrite.Write8(0);
                }

                // write to ROM
                romStream.Write(dataToWrite, prevLen + 12, areaPtr, false);
            }
        }


    }
}
