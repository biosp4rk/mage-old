using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace mage
{
    public class ScrollList
    {
        // properties
        public bool Edited { get; set; }
        public int Count { get { return scrolls.Count; } }
        public byte AreaID { get; private set; }
        public byte RoomID { get; private set; }

        // data
        private List<Scroll> scrolls;
        public Scroll this[int i]
        {
            get { return scrolls[i]; }
            set { scrolls[i] = value; }
        }

        // drawing
        private Pen py;
        private Pen po;
        private SolidBrush by;
        private SolidBrush bo;
        private Dictionary<Point, int> corners;

        // meta
        public int pointer;
        public int addr;

        private ByteStream romStream;

        // constructor
        public ScrollList(byte areaID, byte roomID)
        {
            this.romStream = ROM.Stream;
            AreaID = areaID;
            RoomID = roomID;
            Edited = false;

            py = new Pen(Color.Yellow);
            po = new Pen(Color.Orange);
            by = new SolidBrush(Color.Yellow);
            bo = new SolidBrush(Color.Orange);

            GetData();
        }

        private void GetData()
        {
            scrolls = new List<Scroll>();
            int areaOffset = romStream.ReadPtr(Version.ScrollsOffset + AreaID * 4);
            int currOffset = romStream.ReadPtr(areaOffset);

            bool found = false;

            for (int i = 0; i < 0x100; i++)
            {
                byte curr = romStream.Read8(currOffset);
                if (curr == RoomID)
                {
                    found = true;
                    break;
                }
                else if (curr == 0xFF) { break; }

                areaOffset += 4;
                currOffset = romStream.ReadPtr(areaOffset);
            }

            if (!found)
            {
                pointer = 0;
                return;
            }

            pointer = areaOffset;
            romStream.Seek(currOffset + 1);
            byte length = romStream.Read8();

            for (int i = 0; i < length; i++)
            {
                Scroll sc = new Scroll();
                sc.xStart = romStream.Read8();
                sc.xEnd = romStream.Read8();
                sc.yStart = romStream.Read8();
                sc.yEnd = romStream.Read8();
                sc.xBreak = romStream.Read8();
                sc.yBreak = romStream.Read8();
                sc.replace = romStream.Read8();
                sc.newBound = romStream.Read8();
                scrolls.Add(sc);
            }
        }

        public void Draw(Graphics g, Rectangle rect)
        {
            int num = 0;
            corners = new Dictionary<Point, int>();
            
            foreach (Scroll sc in scrolls)
            {
                if (sc.DrawingBounds.IntersectsWith(rect))
                {
                    // extended bounds
                    if (sc.replace != 0xFF)
                    {
                        po.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                        switch (sc.replace)
                        {
                            case 0:
                                g.DrawRectangle(po, new Rectangle(sc.newBound * 16, sc.yStart * 16,
                                    (sc.xStart - sc.newBound) * 16, (sc.yEnd - sc.yStart) * 16 + 15));
                                DrawTL(g, bo, num, sc.newBound, sc.yStart);
                                DrawBL(g, bo, num, sc.newBound, sc.yEnd);
                                break;
                            case 1:
                                g.DrawRectangle(po, new Rectangle(sc.xEnd * 16 + 15, sc.yStart * 16,
                                    (sc.newBound - sc.xEnd) * 16, (sc.yEnd - sc.yStart) * 16 + 15));
                                DrawTR(g, bo, num, sc.newBound, sc.yStart);
                                DrawBR(g, bo, num, sc.newBound, sc.yEnd);
                                break;
                            case 2:
                                g.DrawRectangle(po, new Rectangle(sc.xStart * 16, sc.newBound * 16,
                                    (sc.xEnd - sc.xStart) * 16 + 15, (sc.yStart - sc.newBound) * 16));
                                DrawTL(g, bo, num, sc.xStart, sc.newBound);
                                DrawTR(g, bo, num, sc.xEnd, sc.newBound);
                                break;
                            case 3:
                                g.DrawRectangle(po, new Rectangle(sc.xStart * 16, sc.yEnd * 16 + 15,
                                    (sc.xEnd - sc.xStart) * 16 + 15, (sc.newBound - sc.yEnd) * 16));
                                DrawBL(g, bo, num, sc.xStart, sc.newBound);
                                DrawBR(g, bo, num, sc.xEnd, sc.newBound);
                                break;
                        }

                        // breakable block
                        if (sc.xBreak != 0xFF)
                        {
                            po.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                            g.DrawRectangle(po, new Rectangle(sc.xBreak * 16, sc.yBreak * 16, 15, 15));
                            g.DrawRectangle(po, new Rectangle(sc.xBreak * 16 + 1, sc.yBreak * 16 + 1, 13, 13));
                            AddCorner(num, sc.xBreak, sc.yBreak);
                        }
                    }

                    // outline
                    g.DrawRectangle(py, new Rectangle(sc.xStart * 16, sc.yStart * 16,
                        (sc.xEnd - sc.xStart) * 16 + 15, (sc.yEnd - sc.yStart) * 16 + 15));
                    // corners
                    DrawTL(g, by, num, sc.xStart, sc.yStart);
                    DrawTR(g, by, num, sc.xEnd, sc.yStart);
                    DrawBL(g, by, num, sc.xStart, sc.yEnd);
                    DrawBR(g, by, num, sc.xEnd, sc.yEnd);
                }
                num++;
            }

            Bitmap nums = Properties.Resources.scrollNums;
            foreach (KeyValuePair<Point, int> kvp in corners)
            {
                g.DrawImage(nums, new Rectangle(kvp.Key.X * 16 + 4, kvp.Key.Y * 16 + 4, 8, 8), 
                    new Rectangle(kvp.Value * 8 + 8, 0, 8, 8), GraphicsUnit.Pixel);
            }
        }

        private void DrawTL(Graphics g, SolidBrush b, int num, byte x, byte y)
        {
            g.FillRectangle(b, new Rectangle(x * 16, y * 16, 14, 3));
            g.FillRectangle(b, new Rectangle(x * 16, y * 16 + 3, 3, 11));
            AddCorner(num, x, y);
        }

        private void DrawTR(Graphics g, SolidBrush b, int num, byte x, byte y)
        {
            g.FillRectangle(b, new Rectangle(x * 16 + 2, y * 16, 14, 3));
            g.FillRectangle(b, new Rectangle(x * 16 + 13, y * 16 + 3, 3, 11));
            AddCorner(num, x, y);
        }

        private void DrawBL(Graphics g, SolidBrush b, int num, byte x, byte y)
        {
            g.FillRectangle(b, new Rectangle(x * 16, y * 16 + 2, 3, 14));
            g.FillRectangle(b, new Rectangle(x * 16 + 3, y * 16 + 13, 11, 3));
            AddCorner(num, x, y);
        }

        private void DrawBR(Graphics g, SolidBrush b, int num, byte x, byte y)
        {
            g.FillRectangle(b, new Rectangle(x * 16 + 13, y * 16 + 2, 3, 14));
            g.FillRectangle(b, new Rectangle(x * 16 + 2, y * 16 + 13, 11, 3));
            AddCorner(num, x, y);
        }

        private void AddCorner(int num, byte x, byte y)
        {
            Point pt = new Point(x, y);
            if (corners.ContainsKey(pt)) { corners[pt] = -1; }
            else { corners.Add(pt, num); }
        }

        public int FindScroll(Point p)
        {
            // returns scrollNum * 6 + cornerNum
            int num = 0;
            foreach (Scroll sc in scrolls)
            {
                if (p.X == sc.xStart && p.Y == sc.yStart) { return num; }
                else if (p.X == sc.xEnd && p.Y == sc.yStart) { return num + 1; }
                else if (p.X == sc.xStart && p.Y == sc.yEnd) { return num + 2; }
                else if (p.X == sc.xEnd && p.Y == sc.yEnd) { return num + 3; }
                else if (sc.replace != 0xFF)
                {
                    if (sc.replace <= 1 && p.X == sc.newBound && (p.Y == sc.yStart || p.Y == sc.yEnd))
                    {
                        return num + 4;
                    }
                    else if (p.Y == sc.newBound && (p.X == sc.xStart || p.X == sc.xEnd))
                    {
                        return num + 4;
                    }

                    if (p.X == sc.xBreak && p.Y == sc.yBreak)
                    {
                        return num + 5;
                    }
                }
                num += 6;
            }
            return -1;
        }

        public void AddScroll(Scroll sc, int num)
        {
            Edited = true;
            scrolls.Insert(num / 6, sc);
        }

        public void RemoveScroll(int num)
        {
            Edited = true;
            scrolls.RemoveAt(num / 6);
        }

        public void Export(ByteStream dst)
        {
            dst.Write8((byte)scrolls.Count);

            foreach (Scroll sc in scrolls)
            {
                dst.Write8(sc.xStart);
                dst.Write8(sc.xEnd);
                dst.Write8(sc.yStart);
                dst.Write8(sc.yEnd);
                dst.Write8(sc.xBreak);
                dst.Write8(sc.yBreak);
                dst.Write8(sc.replace);
                dst.Write8(sc.newBound);
            }
        }

        public void Import(ByteStream src)
        {
            byte length = src.Read8();
            scrolls = new List<Scroll>(length);

            for (int i = 0; i < length; i++)
            {
                Scroll sc = new Scroll();
                sc.xStart = src.Read8();
                sc.xEnd = src.Read8();
                sc.yStart = src.Read8();
                sc.yEnd = src.Read8();
                sc.xBreak = src.Read8();
                sc.yBreak = src.Read8();
                sc.replace = src.Read8();
                sc.newBound = src.Read8();
                scrolls.Add(sc);
            }
        }

        public static void Write()
        {
            ByteStream romStream = ROM.Stream;

            int numOfAreas = Version.AreaNames.Length;
            for (byte a = 0; a < numOfAreas; a++)  // for each area
            {
                // get edited scroll lists from each area
                List<ScrollList> editedSLs = ROM.GetAreaScrollLists(a);
                if (editedSLs.Count == 0) { continue; }

                // sort edited lists
                ScrollList[] bucket = new ScrollList[0x100];
                foreach (ScrollList sl in editedSLs)
                {
                    bucket[sl.RoomID] = sl;
                }
                editedSLs.Clear();
                foreach (ScrollList sl in bucket)
                {
                    if (sl != null) { editedSLs.Add(sl); }
                }

                int areaOffset = romStream.ReadPtr(Version.ScrollsOffset + a * 4);
                int currOffset = romStream.ReadPtr(areaOffset);

                // get list of all pointers
                List<int> listPtrs = new List<int>();
                int editedIndex = 0;
                int origNumLists = 0;

                for (int i = 0; i < 0x100; i++)  // for each entry
                {
                    byte roomID = romStream.Read8(currOffset);
                    if (roomID == 0xFF) { break; }

                    bool added = false;
                    for (int j = editedIndex; j < editedSLs.Count; j++)
                    {
                        ScrollList sl = editedSLs[j];

                        // add new lists that precede current (skip empty ones)
                        if (sl.RoomID < roomID)
                        {
                            if (sl.Count > 0)
                            {
                                ByteStream dataToWrite = WriteEntry(sl);
                                int newOffset = romStream.AddData(dataToWrite);
                                listPtrs.Add(newOffset);
                            }
                            editedIndex++;
                        }
                        // set list if edited
                        else if (sl.RoomID == roomID)
                        {
                            byte count = romStream.Read8(currOffset + 1);
                            int origLen = count * 8 + 2;
                            ByteStream dataToWrite = WriteEntry(sl);
                            // deletes entry if empty
                            romStream.Write2(dataToWrite, origLen, ref currOffset, false);
                            
                            if (sl.Count > 0)
                            {
                                listPtrs.Add(currOffset);
                            }
                            added = true;
                            editedIndex++;
                            break;
                        }
                        else { break; }
                    }

                    // add current list if not added
                    if (!added) { listPtrs.Add(currOffset); }

                    areaOffset += 4;
                    currOffset = romStream.ReadPtr(areaOffset);
                    origNumLists++;
                }

                // add remaining lists
                for (int k = editedIndex; k < editedSLs.Count; k++)
                {
                    ScrollList sl = editedSLs[k];
                    if (sl.Count > 0)
                    {
                        ByteStream dataToWrite = WriteEntry(sl);
                        int newOffset = romStream.AddData(dataToWrite);
                        listPtrs.Add(newOffset);
                    }
                }
                // add last entry
                listPtrs.Add(currOffset);

                // rewrite list of pointers
                ByteStream listOfPtrs = new ByteStream();
                foreach (int ptr in listPtrs)
                {
                    listOfPtrs.WritePtr(ptr);
                }

                int prevLen = (origNumLists + 1) * 4;
                int addr = Version.ScrollsOffset + a * 4;
                romStream.Write(listOfPtrs, prevLen, addr, false);
            }
        }

        private static ByteStream WriteEntry(ScrollList sl)
        {
            ByteStream dataToWrite = new ByteStream();
            if (sl.Count == 0) { return dataToWrite; }

            dataToWrite.Write8(sl.RoomID);
            dataToWrite.Write8((byte)sl.Count);

            foreach (Scroll sc in sl.scrolls)
            {
                dataToWrite.Write8(sc.xStart);
                dataToWrite.Write8(sc.xEnd);
                dataToWrite.Write8(sc.yStart);
                dataToWrite.Write8(sc.yEnd);
                dataToWrite.Write8(sc.xBreak);
                dataToWrite.Write8(sc.yBreak);
                dataToWrite.Write8(sc.replace);
                dataToWrite.Write8(sc.newBound);
            }

            return dataToWrite;
        }


    }
}
