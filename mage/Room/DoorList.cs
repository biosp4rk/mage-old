using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace mage
{
    public class DoorList
    {
        // properties
        public int Count
        {
            get { return doors.Count; }
        }
        public int NumOfDoors
        {
            get
            {
                int numOfDoors = 0;
                foreach (Door d in doors)
                {
                    if (d.srcRoom != 0xFF) { numOfDoors++; }
                }
                return numOfDoors;
            }
        }
        public bool Edited { get; set; }

        // fields
        private List<Door> doors;
        public Door this[int i]
        {
            get { return doors[i]; }
            set { doors[i] = value; }
        }

        private Room room;

        // constructor
        public DoorList(Room room)
        {
            this.room = room;
            Edited = false;

            doors = DoorData.GetRoomDoors(room.AreaID, room.RoomID);
        }

        public void Draw(Graphics g, Rectangle rect)
        {
            Pen p = Pens.Blue;
            foreach (Door d in doors)
            {
                if (d.DrawingBounds.IntersectsWith(rect) && d.srcRoom == room.RoomID)
                {
                    int xSize = d.xEnd - d.xStart + 1;
                    int ySize = d.yEnd - d.yStart + 1;
                    g.DrawRectangle(p, new Rectangle(d.xStart * 16, d.yStart * 16,
                        xSize * 16 - 1, ySize * 16 - 1));
                    g.DrawRectangle(p, new Rectangle(d.xStart * 16 + 1, d.yStart * 16 + 1,
                        xSize * 16 - 3, ySize * 16 - 3));
                }
            }
        }

        //public unsafe void Draw(Rectangle rect, BitmapData dstData)
        //{
        //    ushort* startPtr = (ushort*)dstData.Scan0;
        //    int dstWidth = dstData.Width;

        //    foreach (Door d in doors)
        //    {
        //        if (d.DrawingBounds.IntersectsWith(rect) && d.srcRoom == room.RoomID)
        //        {
        //            int w = (d.xEnd - d.xStart + 1) * 16;
        //            int h = (d.yEnd - d.yStart + 1) * 16;

        //            ushort* dstPtr = startPtr + d.yStart * 16 * dstWidth + d.xStart * 16;
        //            ushort* end = dstPtr + w;
        //            int a = (h - 2) * dstWidth;
        //            int b = a + dstWidth;
        //            while (dstPtr < end)
        //            {
        //                *dstPtr = 0x801F;
        //                *(dstPtr + dstWidth) = 0x801F;
        //                *(dstPtr + a) = 0x801F;
        //                *(dstPtr + b) = 0x801F;
        //                dstPtr++;
        //            }

        //            dstPtr = dstPtr - w + 2 * dstWidth;
        //            end = dstPtr + (h - 4) * dstWidth;
        //            int j = w - 2;
        //            int k = j + 1;
        //            while (dstPtr < end)
        //            {
        //                *dstPtr = 0x801F;
        //                *(dstPtr + 1) = 0x801F;
        //                *(dstPtr + j) = 0x801F;
        //                *(dstPtr + k) = 0x801F;
        //                dstPtr += dstWidth;
        //            }
        //        }
        //    }
        //}

        public int FindDoor(Point p)
        {
            int num = 0;
            foreach (Door d in doors)
            {
                if (p.X >= d.xStart && p.X <= d.xEnd && p.Y >= d.yStart && p.Y <= d.yEnd)
                {
                    return num;
                }
                num++;
            }
            return -1;
        }

        public void AddDoor(Door d, int num)
        {
            Edited = true;
            d.Edited = true;
            d.srcRoom = room.RoomID;
            doors.Insert(num, d);
        }

        public void RemoveDoor(int num)
        {
            Edited = true;
            doors[num].Edited = true;
            doors[num].srcRoom = 0xFF;
            doors.RemoveAt(num);
        }

        public void Clear()
        {
            Edited = true;
            foreach(Door d in doors)
            {
                d.Edited = true;
                d.srcRoom = 0xFF;
            }
            doors.Clear();
        }

        public void Export(ByteStream dst)
        {
            dst.Write8((byte)NumOfDoors);

            foreach (Door d in doors)
            {
                if (d.srcRoom != 0xFF)
                {
                    dst.Write8(d.type);
                    dst.Write8(d.srcRoom);
                    dst.Write8(d.xStart);
                    dst.Write8(d.xEnd);
                    dst.Write8(d.yStart);
                    dst.Write8(d.yEnd);
                    dst.Write8(d.dstDoor);
                    dst.Write8(d.xExitDistance);
                    dst.Write8(d.yExitDistance);
                    dst.Write8(d.doorNum);
                    dst.Write8((byte)0);
                    dst.Write8((byte)0);
                }
            }
        }

        public void Import(ByteStream src)
        {
            int numOfDoors = src.Read8();
            doors = new List<Door>(numOfDoors);

            for (int i = 0; i < numOfDoors; i++)
            {
                Door d = new Door();
                d.Edited = true;
                d.areaID = room.AreaID;

                d.type = src.Read8();
                d.srcRoom = room.RoomID;
                src.Read8();
                d.xStart = src.Read8();
                d.xEnd = src.Read8();
                d.yStart = src.Read8();
                d.yEnd = src.Read8();
                d.dstDoor = src.Read8();
                d.xExitDistance = src.Read8();
                d.yExitDistance = src.Read8();
                d.doorNum = src.Read8();

                doors.Add(d);
                src.Seek(src.Position + 2);
            }
        }


    }
}
