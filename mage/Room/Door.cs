using System;
using System.Drawing;

namespace mage
{
    public class Door : RoomObject
    {
        // properties
        public bool Edited { get; set; }
        
        // fields
        public byte doorNum;
        public byte areaID;

        public byte type;
        public byte srcRoom;
        public byte xStart, xEnd;
        public byte yStart, yEnd;
        public byte dstDoor;
        public byte xExitDistance;
        public byte yExitDistance;

        // constructor
        public Door()
        {

        }

        public override Rectangle DrawingBounds
        {
            get { return new Rectangle(xStart * 16, yStart * 16, (xEnd - xStart + 1) * 16, (yEnd - yStart + 1) * 16); }
        }

        public override RoomObject Copy()
        {
            Door copy = new Door();
            copy.doorNum = this.doorNum;
            copy.areaID = this.areaID;

            copy.type = this.type;
            copy.srcRoom = this.srcRoom;
            copy.xStart = this.xStart;
            copy.xEnd = this.xEnd;
            copy.yStart = this.yStart;
            copy.yEnd = this.yEnd;
            copy.dstDoor = this.dstDoor;
            copy.xExitDistance = this.xExitDistance;
            copy.yExitDistance = this.yExitDistance;
            return copy;
        }

        public override void SetValue(RoomObject newObj)
        {
            Door d = (Door)newObj;
            Edited = true;
            this.doorNum = d.doorNum;
            this.areaID = d.areaID;

            this.type = d.type;
            this.srcRoom = d.srcRoom;
            this.xStart = d.xStart;
            this.xEnd = d.xEnd;
            this.yStart = d.yStart;
            this.yEnd = d.yEnd;
            this.dstDoor = d.dstDoor;
            this.xExitDistance = d.xExitDistance;
            this.yExitDistance = d.yExitDistance;
        }

        public override RoomObject Move(Point diff, int num)
        {
            Door copy = (Door)this.Copy();
            if (xStart + diff.X < 0 || yStart + diff.Y < 0) { return copy; }

            copy.Edited = true;

            copy.xStart += (byte)diff.X;
            copy.xEnd += (byte)diff.X;
            copy.yStart += (byte)diff.Y;
            copy.yEnd += (byte)diff.Y;
            return copy;
        }

        public override void Add(Point pos)
        {
            Edited = true;
            type = 0x14;
            xStart = (byte)pos.X;
            xEnd = (byte)pos.X;
            yStart = (byte)pos.Y;
            yEnd = (byte)(pos.Y + 3);
            dstDoor = 0;
            xExitDistance = 0;
            yExitDistance = 0;
        }


    }
}
