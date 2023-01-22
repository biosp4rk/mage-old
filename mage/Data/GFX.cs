using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;

namespace mage
{
    public class GFX
    {
        // properties
        public int Offset { get { return addr; } }

        // fields
        public byte[] data;
        public int origLen;
        public int width;
        public int height;

        private int addr;
        private bool compressed;

        // constructor (uncompressed)
        public GFX(ByteStream bs, int offset, int width, int height)
        {
            this.addr = offset;
            this.width = width;
            this.height = height;
            this.compressed = false;

            GetData(bs);
        }

        // constructor (compressed)
        public GFX(ByteStream bs, int offset, int width = 32)
        {
            this.addr = offset;
            this.width = width;
            this.compressed = true;

            GetData(bs);
        }

        // constructor (blank)
        public GFX(byte[] data, int width)
        {
            this.data = data;
            this.width = width;
            double h = (double)data.Length / (width * 0x20);
            height = (int)Math.Ceiling(h);
        }

        // constructor (replace)
        public GFX(GFX prev, byte[] data)
        {
            this.addr = prev.addr;
            this.compressed = prev.compressed;
            this.origLen = prev.origLen;
            this.width = prev.width;
            this.height = Math.Max(data.Length / (width * 0x20), 1);

            this.data = data;
        }

        private void GetData(ByteStream src)
        {
            if (compressed)
            {
                if (src.Read8(addr) != 0x10)
                {
                    throw new FormatException();
                }
                int size = src.Read32(addr) >> 8;
                double h = (double)size / (width * 0x20);
                height = (int)Math.Ceiling(h);

                try
                {
                    src.Seek(addr);
                    ByteStream decomp = new ByteStream(size);
                    origLen = Compress.DecompLZ77(src, decomp);
                    data = new byte[size];
                    decomp.CopyToArray(0, data, 0, size);
                }
                catch
                {
                    data = new byte[0];
                    origLen = 0;
                }
            }
            else
            {
                data = new byte[width * height * 0x20];
                src.CopyToArray(addr, data, 0, data.Length);
                origLen = data.Length;
            }
        }

        public unsafe Bitmap Draw15bpp(Palette pal, int row, bool opaque)
        {
            int w = width * 8;
            int h = height * 8;
            Bitmap img;
            if (opaque)
            {
                img = new Bitmap(w, h, PixelFormat.Format16bppRgb555);
            }
            else
            {
                img = new Bitmap(w, h, PixelFormat.Format16bppArgb1555);
            }

            Rectangle rect = new Rectangle(0, 0, w, h);
            BitmapData imgData = img.LockBits(rect, ImageLockMode.WriteOnly, img.PixelFormat);

            ushort[,] palette = pal.ARGBs;
            if (opaque)
            {
                palette[row, 0] |= 0x8000;
            }

            int tileNum = 0;
            int numTiles = data.Length / 0x20;
            int index = 0;
            ushort* imgPtr = (ushort*)imgData.Scan0;

            for (int y = 0; y < height; y++)  // for each tile down
            {
                for (int x = 0; x < width; x++)  // for each tile across
                {
                    if (tileNum >= numTiles) { goto End; }
                    tileNum++;

                    for (int r = 0; r < 8; r++)  // for each row in tile
                    {
                        for (int pp = 0; pp < 4; pp++)  // for each pixel pair
                        {
                            byte val = data[index++];
                            *imgPtr++ = palette[row, val & 0xF];
                            *imgPtr++ = palette[row, val >> 4];
                        }
                        imgPtr += (w - 8);
                    }
                    imgPtr -= (w * 8 - 8);
                }
                imgPtr += (w * 7);
            }

        End:
            if (opaque)
            {
                palette[row, 0] &= 0x7FFF;
            }

            img.UnlockBits(imgData);
            return img;
        }

        public unsafe Bitmap Draw4bpp(Palette pal, int row, bool opaque)
        {
            int w = width * 8;
            int h = height * 8;
            Bitmap img = new Bitmap(w, h, PixelFormat.Format4bppIndexed);
            pal.SetBitmapPalette(img, row, 1);

            if (!opaque)
            {
                ColorPalette cp = img.Palette;
                cp.Entries[0] = Color.Transparent;
                img.Palette = cp;
            }

            Rectangle rect = new Rectangle(0, 0, w, h);
            BitmapData imgData = img.LockBits(rect, ImageLockMode.WriteOnly, img.PixelFormat);

            w /= 2;
            int tileNum = 0;
            int numTiles = data.Length / 0x20;
            int index = 0;
            byte* imgPtr = (byte*)imgData.Scan0;

            for (int y = 0; y < height; y++)  // for each tile down
            {
                for (int x = 0; x < width; x++)  // for each tile across
                {
                    if (tileNum >= numTiles) { goto End; }
                    tileNum++;

                    for (int r = 0; r < 8; r++)  // for each row in tile
                    {
                        for (int pp = 0; pp < 4; pp++)  // for each pixel pair
                        {
                            byte val = data[index++];
                            *imgPtr++ = (byte)(((val & 0xF) << 4) | (val >> 4));
                        }
                        imgPtr += (w - 4);
                    }
                    imgPtr -= (w * 8 - 4);
                }
                imgPtr += (w * 7);
            }

        End:
            img.UnlockBits(imgData);
            return img;
        }

        public unsafe Bitmap Draw4bppSpriteset(Palette pal, int row, int drawHeight)
        {
            int w = width * 8;
            int h = drawHeight * 8;
            Bitmap img = new Bitmap(w, h, PixelFormat.Format4bppIndexed);
            pal.SetBitmapPalette(img, row, 1);

            Rectangle rect = new Rectangle(0, 0, w, h);
            BitmapData imgData = img.LockBits(rect, ImageLockMode.WriteOnly, img.PixelFormat);

            w /= 2;
            int tileNum = 0;
            int numTiles = data.Length / 0x20;
            int index = row * 0x800;
            byte* imgPtr = (byte*)imgData.Scan0;

            for (int y = 0; y < drawHeight; y++)  // for each tile down
            {
                for (int x = 0; x < width; x++)  // for each tile across
                {
                    if (tileNum >= numTiles) { goto End; }
                    tileNum++;

                    for (int r = 0; r < 8; r++)  // for each row in tile
                    {
                        for (int pp = 0; pp < 4; pp++)  // for each pixel pair
                        {
                            byte val = data[index++];
                            *imgPtr++ = (byte)(((val & 0xF) << 4) | (val >> 4));
                        }
                        imgPtr += (w - 4);
                    }
                    imgPtr -= (w * 8 - 4);
                }
                imgPtr += (w * 7);
            }

        End:
            img.UnlockBits(imgData);
            return img;
        }

        public unsafe Bitmap DrawSpriteRegion(Palette pal, int row, Rectangle region)
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
                    int index = y * 0x400 + x * 0x20;

                    for (int r = 0; r < 8; r++)  // for each row in tile
                    {
                        for (int pp = 0; pp < 4; pp++)  // for each pixel pair
                        {
                            byte val = data[index++];
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

        public void Write(ByteStream dst, bool export)
        {
            int newLen;
            ByteStream dataToWrite;
            ByteStream uncomp = new ByteStream(data);

            if (compressed)
            {
                int size = data.Length;
                dataToWrite = new ByteStream();
                newLen = Compress.CompLZ77(uncomp, size, dataToWrite);
            }
            else
            {
                newLen = data.Length;
                dataToWrite = uncomp;
            }

            // write
            if (export)
            {
                dst.Write(dataToWrite);
            }
            else
            {
                dst.Write2(dataToWrite, origLen, ref addr, true);
                origLen = newLen;
            }
        }


    }
}
