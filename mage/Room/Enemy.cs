using System;
using System.Drawing;

namespace mage
{
    public class Enemy : RoomObject
    {
        public byte SlotNum { get { return (byte)((prop & 0xF) - 1); } }
        public byte Property { get { return (byte)(prop >> 4); } }

        // fields
        public byte xPos;
        public byte yPos;
        public byte prop;

        public Rectangle bounds;

        // constructor
        public Enemy()
        {

        }

        public override Rectangle DrawingBounds
        {
            get { return bounds; }
        }

        public override RoomObject Copy()
        {
            Enemy copy = new Enemy();
            copy.xPos = this.xPos;
            copy.yPos = this.yPos;
            copy.prop = this.prop;
            copy.bounds = this.bounds;
            return copy;
        }

        public override void SetValue(RoomObject newObj)
        {
            Enemy en = (Enemy)newObj;
            this.xPos = en.xPos;
            this.yPos = en.yPos;
            this.prop = en.prop;
        }

        public override RoomObject Move(Point diff, int num)
        {
            Enemy copy = (Enemy)this.Copy();
            copy.xPos += (byte)diff.X;
            copy.yPos += (byte)diff.Y;
            return copy;
        }

        public override void Add(Point pos)
        {
            xPos = (byte)pos.X;
            yPos = (byte)pos.Y;
            prop = 0x21;
        }


    }
}
