using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;

namespace mage
{
    public class OAM
    {
        public struct Frame
        {
            public int duration;
            public List<Part> parts;
            public int numParts;

            public int width;
            public int height;
            public int xOffset;
            public int yOffset;

            public Frame(int duration, List<Part> parts, int numParts)
            {
                this.duration = duration;
                this.parts = parts;
                this.numParts = numParts;

                width = 0;
                height = 0;
                xOffset = 0;
                yOffset = 0;

                foreach (Part part in parts)
                {
                    width = Math.Max(part.Dimensions.Width, width);
                    height = Math.Max(part.Dimensions.Height, height);
                    xOffset = Math.Min(part.xPos, xOffset);
                    yOffset = Math.Min(part.yPos, yOffset);
                }
            }
        }

        public struct Part
        {
            public int xPos, yPos;
            public int shape;
            public int flip;
            public int size;
            public int tileNum;
            public int palRow;

            public Part(ushort attr0, ushort attr1, ushort attr2)
            {
                yPos = attr0 & 0xFF;
                if (yPos >= 128) { yPos -= 256; }
                xPos = attr1 & 0x1FF;
                if (xPos >= 256) { xPos -= 512; }
                shape = attr0 >> 14;
                flip = (attr1 >> 12) & 3;
                size = attr1 >> 14;
                tileNum = attr2 & 0x3FF;
                palRow = attr2 >> 12;
            }

            public bool Xflip { get { return (flip & 1) != 0; } }
            public bool Yflip { get { return (flip & 2) != 0; } }

            public Size Dimensions
            {
                get
                {
                    switch (shape * 4 + size)
                    {
                        case 0:
                            return new Size(8, 8);
                        case 1:
                            return new Size(16, 16);
                        case 2:
                            return new Size(32, 32);
                        case 3:
                            return new Size(64, 64);
                        case 4:
                            return new Size(16, 8);
                        case 5:
                            return new Size(32, 8);
                        case 6:
                            return new Size(32, 16);
                        case 7:
                            return new Size(64, 32);
                        case 8:
                            return new Size(8, 16);
                        case 9:
                            return new Size(8, 32);
                        case 10:
                            return new Size(16, 32);
                        case 11:
                            return new Size(32, 64);
                    }
                    throw new FormatException();
                }
            }
        }

        // data
        public int numFrames;
        public List<Frame> frames;

        private int origAddr;
        private ByteStream romStream;

        public OAM(int offset)
        {
            this.origAddr = offset;
            this.romStream = ROM.Stream;

            frames = new List<Frame>();
            while (true)
            {
                ushort duration = romStream.Read16(offset + 4);
                if (duration == 0) { break; }
                int attrOffset = romStream.ReadPtr(offset);

                romStream.Seek(attrOffset);
                int numAttrs = romStream.Read16();
                List<Part> parts = new List<Part>();
                for (int i = 0; i < numAttrs; i++)
                {
                    ushort attr0 = romStream.Read16();
                    ushort attr1 = romStream.Read16();
                    ushort attr2 = romStream.Read16();
                    Part attrs = new Part(attr0, attr1, attr2);
                    parts.Add(attrs);
                }

                Frame frame = new Frame(duration, parts, numAttrs);
                frames.Add(frame);

                offset += 8;
            }

            this.numFrames = frames.Count;
        }

        public Bitmap Draw(byte[] gfx, Palette pal, int row, int frameNum)
        {
            int xEnd = 0;
            int yEnd = 0;

            // get position offsets and max size
            Frame frame = frames[frameNum];
            foreach (Part part in frame.parts)
            {
                Size s = part.Dimensions;
                if (part.xPos + s.Width > xEnd) { xEnd = part.xPos + s.Width; }
                if (part.yPos + s.Height > yEnd) { yEnd = part.yPos + s.Height; }
            }

            xEnd -= frame.xOffset;
            yEnd -= frame.yOffset;

            // draw
            Bitmap spriteImg = new Bitmap(xEnd, yEnd, PixelFormat.Format16bppArgb1555);
            Rectangle dstRect = new Rectangle(0, 0, spriteImg.Width, spriteImg.Height);
            BitmapData spriteData = spriteImg.LockBits(dstRect, ImageLockMode.WriteOnly, spriteImg.PixelFormat);

            // for each part
            for (int i = frame.numParts - 1; i >= 0; i--)
            {
                Part part = frame.parts[i];

                // use coordinates >= 0
                int xPos = part.xPos - frame.xOffset;
                int yPos = part.yPos - frame.yOffset;

                // get bitmap of part
                int tileNum = (part.tileNum + row * 64) % 1024;
                int palRow = (part.palRow + row) % 16;
                Size s = part.Dimensions;
                Rectangle rect = new Rectangle(tileNum % 32, tileNum / 32, s.Width / 8, s.Height / 8);
                Bitmap gfxImg = DrawRegion(gfx, pal, palRow, rect);

                // draw
                DrawPart(gfxImg, spriteData, part.flip, xPos, yPos);
            }

            spriteImg.UnlockBits(spriteData);
            return spriteImg;
        }

        // TODO: combine functions?
        private unsafe Bitmap DrawRegion(byte[] gfx, Palette pal, int row, Rectangle region)
        {
            int w = region.Width * 8;
            int h = region.Height * 8;
            Bitmap img = new Bitmap(w, h, PixelFormat.Format16bppArgb1555);

            Rectangle rect = new Rectangle(0, 0, w, h);
            BitmapData imgData = img.LockBits(rect, ImageLockMode.WriteOnly, img.PixelFormat);

            int xEnd = region.X + region.Width;
            int yEnd = region.Y + region.Height;
            ushort[,] palette = pal.ARGBs;

            ushort* imgPtr = (ushort*)imgData.Scan0;

            for (int y = region.Y; y < yEnd; y++)  // for each tile down
            {
                for (int x = region.X; x < xEnd; x++)  // for each tile across
                {
                    int index = (y * 0x400 + x * 0x20) % 0x8000;

                    for (int r = 0; r < 8; r++)  // for each row in tile
                    {
                        for (int pp = 0; pp < 4; pp++)  // for each pixel pair
                        {
                            byte val = gfx[index++];
                            *imgPtr++ = palette[row, val & 0xF];
                            *imgPtr++ = palette[row, val >> 4];
                        }
                        imgPtr += (w - 8);
                    }
                    imgPtr -= (w * 8 - 8);
                }
                imgPtr += (w * 7);
            }

            img.UnlockBits(imgData);
            return img;
        }

        private unsafe void DrawPart(Bitmap src, BitmapData dstData, int flip, int x, int y)
        {
            int srcWidth = src.Width;
            int srcHeight = src.Height;
            int dstWidth = dstData.Stride / 2;

            Rectangle rect = new Rectangle(0, 0, srcWidth, srcHeight);
            BitmapData srcData = src.LockBits(rect, ImageLockMode.ReadOnly, src.PixelFormat);

            ushort* srcPtr = (ushort*)srcData.Scan0;
            ushort* dstPtr = (ushort*)dstData.Scan0;
            dstPtr += y * dstWidth + x;

            int i, j;
            switch (flip)
            {
                case 0:
                    i = 1;
                    j = 0;
                    break;
                case 1:
                    i = -1;
                    j = 2 * srcWidth;
                    srcPtr += srcWidth - 1;
                    break;
                case 2:
                    i = 1;
                    j = -2 * srcWidth;
                    srcPtr += srcWidth * (srcHeight - 1);
                    break;
                case 3:
                    i = -1;
                    j = 0;
                    srcPtr += srcWidth * srcHeight - 1;
                    break;
                default:
                    throw new ArgumentException("Invalid value for flip");
            }

            for (int v = 0; v < srcHeight; v++)
            {
                for (int u = 0; u < srcWidth; u++)
                {
                    ushort srcPx = *srcPtr;
                    srcPtr += i;

                    if (srcPx < 0x8000)
                    {
                        dstPtr++;
                    }
                    else
                    {
                        *dstPtr++ = srcPx;
                    }
                }
                srcPtr += j;
                dstPtr += dstWidth - srcWidth;
            }

            src.UnlockBits(srcData);
        }


    }
}
