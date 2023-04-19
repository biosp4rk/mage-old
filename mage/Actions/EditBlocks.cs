using System;
using System.Collections.Generic;
using System.Drawing;

namespace mage
{
    public class EditBlocks : RoomAction
    {
        // fields
        private Dictionary<Point, Block> blocks;
        private Rectangle region;

        // constructor
        public EditBlocks(Backgrounds backgrounds, Block[,] clipboard, Point ptDst, int bgNum, ushort clipVal, bool combine)
        {
            this.combine = combine;

            int width = Math.Min(clipboard.GetLength(0), backgrounds.width - ptDst.X);
            int height = Math.Min(clipboard.GetLength(1), backgrounds.height - ptDst.Y);
            region = new Rectangle(ptDst.X * 16, ptDst.Y * 16, width * 16, height * 16);

            bool updateClip = (clipVal != 0xFFFF);
            blocks = new Dictionary<Point, Block>();

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    // get source and destination blocks
                    Block src = clipboard[x, y];
                    int u = ptDst.X + x;
                    int v = ptDst.Y + y;
                    Block dst = backgrounds.GetBlock(u, v);

                    // give destination block new values
                    if (bgNum != -1) { dst[bgNum] = src[bgNum]; }
                    if (updateClip)
                    {
                        if (clipVal == 0xFFFE) { dst.CLP = src.CLP; }
                        else { dst.CLP = clipVal; }
                    }
                    blocks.Add(new Point(u, v), dst);
                }
            }

            // mark backgrounds edited
            if (bgNum != -1)
            {
                backgrounds[bgNum].Edited = true;
            }

            if (updateClip)
            {
                backgrounds.clip.Edited = true;
            }
        }

        public override void Do(Room room)
        {
            Dictionary<Point, Block> backup = new Dictionary<Point, Block>();

            foreach (KeyValuePair<Point, Block> kvp in blocks)
            {
                Point p = kvp.Key;
                Block b = room.backgrounds.GetBlock(p.X, p.Y);
                backup.Add(p, b);
                room.backgrounds.SetBlock(kvp.Value, p.X, p.Y);
            }

            blocks = backup;
        }

        public override void Undo(Room room)
        {
            Do(room);
        }

        public override Rectangle AffectedRegion
        {
            get { return region; }
        }

        public override string ActionText
        {
            //get { return "Edit blocks"; }
            get { return Properties.Resources.Action_EditBlocksText; }
        }

        public override bool TryCombine(Action a)
        {
            EditBlocks newer = a as EditBlocks;
            if (newer == null) { return false; }

            // resize region
            region = Rectangle.Union(region, newer.region);

            // copy blocks
            foreach (KeyValuePair<Point, Block> kvp in newer.blocks)
            {
                if (!blocks.ContainsKey(kvp.Key))
                {
                    blocks.Add(kvp.Key, kvp.Value);
                }
            }

            return true;
        }


    }
}
