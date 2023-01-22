using System;
using System.Drawing;

namespace mage
{
    public class Scroll : RoomObject
    {
        // fields
        public byte xStart, xEnd;
        public byte yStart, yEnd;
        public byte xBreak, yBreak;
        public byte replace;
        public byte newBound;

        // constructor
        public Scroll()
        {

        }

        public override Rectangle DrawingBounds
        {
            get
            {
                // if scroll has extended bounds
                if (replace != 0xFF)
                {
                    Rectangle rect = new Rectangle();
                    switch (replace)
                    {
                        case 0:
                            rect = new Rectangle(newBound * 16, yStart * 16, (xEnd - newBound + 1) * 16, (yEnd - yStart + 1) * 16);
                            break;
                        case 1:
                            rect = new Rectangle(xStart * 16, yStart * 16, (newBound - xStart + 1) * 16, (yEnd - yStart + 1) * 16);
                            break;
                        case 2:
                            rect = new Rectangle(xStart * 16, newBound * 16, (xEnd - xStart + 1) * 16, (yEnd - newBound + 1) * 16);
                            break;
                        case 3:
                            rect = new Rectangle(xStart * 16, yStart * 16, (xEnd - xStart + 1) * 16, (newBound - yStart + 1) * 16);
                            break;
                    }
                    // if scroll has breakable block
                    if (xBreak != 0xFF)
                    {
                        Rectangle block = new Rectangle(xBreak * 16, yBreak * 16, 16, 16);
                        return Rectangle.Union(rect, block);
                    }
                    else { return rect; }
                }
                return new Rectangle(xStart * 16, yStart * 16, (xEnd - xStart + 1) * 16, (yEnd - yStart + 1) * 16);
            }
        }

        public override RoomObject Copy()
        {
            Scroll copy = new Scroll();
            copy.xStart = this.xStart;
            copy.xEnd = this.xEnd;
            copy.yStart = this.yStart;
            copy.yEnd = this.yEnd;
            copy.xBreak = this.xBreak;
            copy.yBreak = this.yBreak;
            copy.replace = this.replace;
            copy.newBound = this.newBound;
            return copy;
        }

        public override void SetValue(RoomObject newObj)
        {
            Scroll sc = (Scroll)newObj;
            this.xStart = sc.xStart;
            this.xEnd = sc.xEnd;
            this.yStart = sc.yStart;
            this.yEnd = sc.yEnd;
            this.xBreak = sc.xBreak;
            this.yBreak = sc.yBreak;
            this.replace = sc.replace;
            this.newBound = sc.newBound;
        }

        public override RoomObject Move(Point pos, int num)
        {
            Scroll copy = (Scroll)this.Copy();

            int corner = num % 6;
            switch (corner)
            {
                case 0:  // top left
                    if (pos.X >= xEnd || pos.Y >= yEnd) { return copy; }
                    if (replace == 0 && pos.X <= newBound) { return copy; }
                    if (replace == 2 && pos.Y <= newBound) { return copy; }
                    copy.xStart = (byte)pos.X;
                    copy.yStart = (byte)pos.Y;
                    break;
                case 1:  // top right
                    if (pos.X <= xStart || pos.Y >= yEnd) { return copy; }
                    if (replace == 1 && pos.X >= newBound) { return copy; }
                    if (replace == 2 && pos.Y <= newBound) { return copy; }
                    copy.xEnd = (byte)pos.X;
                    copy.yStart = (byte)pos.Y;
                    break;
                case 2:  // bottom left
                    if (pos.X >= xEnd || pos.Y <= yStart) { return copy; }
                    if (replace == 0 && pos.X <= newBound) { return copy; }
                    if (replace == 3 && pos.Y >= newBound) { return copy; }
                    copy.xStart = (byte)pos.X;
                    copy.yEnd = (byte)pos.Y;
                    break;
                case 3:  // bottom right
                    if (pos.X <= xStart || pos.Y <= yStart) { return copy; }
                    if (replace == 1 && pos.X >= newBound) { return copy; }
                    if (replace == 3 && pos.Y >= newBound) { return copy; }
                    copy.xEnd = (byte)pos.X;
                    copy.yEnd = (byte)pos.Y;
                    break;
                case 4:  // extended bounds
                    switch (replace)
                    {
                        case 0:
                            if (pos.X >= xStart) { return copy; }
                            copy.newBound = (byte)pos.X;
                            break;
                        case 1:
                            if (pos.X <= xEnd) { return copy; }
                            copy.newBound = (byte)pos.X;
                            break;
                        case 2:
                            if (pos.Y >= yStart) { return copy; }
                            copy.newBound = (byte)pos.Y;
                            break;
                        case 3:
                            if (pos.Y <= yEnd) { return copy; }
                            copy.newBound = (byte)pos.Y;
                            break;
                    }
                    break;
                case 5:  // breakable block
                    copy.xBreak = (byte)pos.X;
                    copy.yBreak = (byte)pos.Y;
                    break;
            }

            return copy;
        }

        public override void Add(Point pos)
        {
            xStart = (byte)pos.X;
            xEnd = (byte)(pos.X + 1);
            yStart = (byte)pos.Y;
            yEnd = (byte)(pos.Y + 1);
            xBreak = yBreak = replace = newBound = 0xFF;
        }


    }
}
