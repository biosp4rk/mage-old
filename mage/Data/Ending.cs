using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace mage
{
    public class Ending
    {
        // fields
        public string Requirements { get { return requirements; } }
        public Bitmap img;
        private Palette palette;
        private int number;

        private int gfxPtr1;
        private int gfxPtr2;
        private int ttbPtr1;
        private int ttbPtr2;
        private int palPtr;
        private string requirements;

        private int gfxCompLen1;
        private int gfxCompLen2;
        private int ttbCompLen1;
        private int ttbCompLen2;

        // constructor
        public Ending(ByteStream romStream, int number)
        {
            this.number = number;

            GetData(romStream);
        }

        private void GetData(ByteStream romStream)
        {
            // get pointers from list
            string gameCode = Version.GameCode;
            string[] lines = Properties.Resources.endings.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            
            int index = 0;
            while (!lines[index].Contains(gameCode))
            {
                index++;
            }
            index += number + 1;

            MatchCollection mc = Regex.Matches(lines[index], @"[^,]+");
            gfxPtr1 = Convert.ToInt32(mc[0].Value, 16);
            gfxPtr2 = Convert.ToInt32(mc[1].Value, 16);
            ttbPtr1 = Convert.ToInt32(mc[2].Value, 16);
            ttbPtr2 = Convert.ToInt32(mc[3].Value, 16);
            palPtr = Convert.ToInt32(mc[4].Value, 16);
            requirements = mc[5].Value.Replace(";", "\n");

            // get gfx data
            int gfxOffset1 = romStream.ReadPtr(gfxPtr1);
            romStream.Seek(gfxOffset1);
            ByteStream gfxData1 = new ByteStream(0x8000);
            gfxCompLen1 = Compress.DecompLZ77(romStream, gfxData1);

            int gfxOffset2 = romStream.ReadPtr(gfxPtr2);
            romStream.Seek(gfxOffset2);
            ByteStream gfxData2 = new ByteStream(0x5000);
            gfxCompLen2 = Compress.DecompLZ77(romStream, gfxData2);

            // get tile table data
            int ttbOffset1 = romStream.ReadPtr(ttbPtr1);
            romStream.Seek(ttbOffset1);
            ByteStream ttbData1 = new ByteStream(0x800);
            ttbCompLen1 = Compress.DecompLZ77(romStream, ttbData1);

            int ttbOffset2 = romStream.ReadPtr(ttbPtr2);
            romStream.Seek(ttbOffset2);
            ByteStream ttbData2 = new ByteStream(0x800);
            ttbCompLen2 = Compress.DecompLZ77(romStream, ttbData2);

            // get palette
            int palOffset = romStream.ReadPtr(palPtr);
            palette = new Palette(romStream, palOffset, 16);

            // draw
            img = new Bitmap(240, 416, PixelFormat.Format8bppIndexed);
            palette.SetBitmapPalette(img, 0, 16);
            Draw(ttbData1.Data, ttbData2.Data, gfxData1.Data, gfxData2.Data);
        }

        private unsafe void Draw(byte[] ttbData1, byte[] ttbData2, byte[] gfxData1, byte[] gfxData2)
        {
            Rectangle rect = new Rectangle(0, 0, img.Width, img.Height);
            BitmapData imgData = img.LockBits(rect, ImageLockMode.WriteOnly, img.PixelFormat);
            byte* imgPtr = (byte*)imgData.Scan0;

            byte[] ttbData = ttbData1;
            byte[] gfxData = gfxData1;
            int ttbIndex = 1;
            int gfxIndex = 0;

            for (int y = 0; y < 52; y++)
            {
                if (y == 32)
                {
                    ttbData = ttbData2;
                    gfxData = gfxData2;
                    ttbIndex = 1;
                    gfxIndex = 0;
                }

                for (int x = 0; x < 30; x++)
                {
                    int pal = ttbData[ttbIndex] & 0xF0;
                    ttbIndex += 2;

                    for (int r = 0; r < 8; r++)
                    {
                        for (int pp = 0; pp < 4; pp++)
                        {
                            byte val = gfxData[gfxIndex++];
                            *imgPtr++ = (byte)(pal | (val & 0xF));
                            *imgPtr++ = (byte)(pal | (val >> 4));
                        }
                        imgPtr += 232;
                    }
                    imgPtr -= 1912;
                }
                imgPtr += 1680;
                ttbIndex += 4;
                gfxIndex += 64;
            }

            img.UnlockBits(imgData);
        }

        public void SaveEnding(Quantize quantize)
        {
            // convert gfx data
            byte[] gfxData1 = new byte[0x8000];
            int oldIndex = 0;
            ConvertGfxData(quantize, gfxData1, ref oldIndex, 32);
            
            byte[] gfxData2 = new byte[0x5000];
            ConvertGfxData(quantize, gfxData2, ref oldIndex, 20);

            // convert tile table data
            byte[] ttbData1 = new byte[0x800];
            oldIndex = 0;
            ConvertTtbData(quantize, ttbData1, ref oldIndex, 32);
           
            byte[] ttbData2 = new byte[0x800];
            ConvertTtbData(quantize, ttbData2, ref oldIndex, 20);
            int newIndex = 0x500;
            for (int t = 0; t < 0x180; t++)
            {
                ttbData2[newIndex++] = 31;
                ttbData2[newIndex++] = 0;
            }

            // write
            ByteStream romStream = ROM.Stream;
            ByteStream uncompData, compData;

            // write gfx data
            compData = new ByteStream();
            uncompData = new ByteStream(gfxData1);
            Compress.CompLZ77(uncompData, 0x8000, compData);
            romStream.Write(compData, gfxCompLen1, gfxPtr1, false);
            gfxCompLen1 = compData.Length;

            compData = new ByteStream();
            uncompData = new ByteStream(gfxData2);
            Compress.CompLZ77(uncompData, 0x5000, compData);
            romStream.Write(compData, gfxCompLen2, gfxPtr2, false);
            gfxCompLen2 = compData.Length;

            // write tile table data
            compData = new ByteStream();
            uncompData = new ByteStream(ttbData1);
            Compress.CompLZ77(uncompData, 0x800, compData);
            romStream.Write(compData, ttbCompLen1, ttbPtr1, false);
            ttbCompLen1 = compData.Length;

            compData = new ByteStream();
            uncompData = new ByteStream(ttbData2);
            Compress.CompLZ77(uncompData, 0x800, compData);
            romStream.Write(compData, ttbCompLen2, ttbPtr2, false);
            ttbCompLen2 = compData.Length;

            // write palette
            int offset = romStream.ReadPtr(palPtr);
            romStream.Seek(offset);
            for (int r = 0; r < 16; r++)
            {
                romStream.Write16(0);
                for (int c = 0; c < 15; c++)
                {
                    ushort value = quantize.BGpalette[r, c].RawVal;
                    romStream.Write16(value);
                }
            }
        }

        private void ConvertGfxData(Quantize quantize, byte[] gfxData, ref int oldIndex, int rows)
        {
            int[] pixels = quantize.pixelAssignments;
            int newIndex = 0;
            for (int y = 0; y < rows; y++)
            {
                for (int pp = 0; pp < 0x3C0; pp++)
                {
                    int val1 = pixels[oldIndex++] + 1;
                    int val2 = pixels[oldIndex++] + 1;
                    gfxData[newIndex++] = (byte)(val1 | (val2 << 4));
                }
                for (int pp = 0; pp < 0x40; pp++)
                {
                    gfxData[newIndex++] = 0;
                }
            }
        }

        private void ConvertTtbData(Quantize quantize, byte[] ttbData, ref int oldIndex, int rows)
        {
            int[] tiles = quantize.tileAssignments;
            int newIndex = 0;
            for (int y = 0; y < rows; y++)
            {
                for (int t = 0; t < 30; t++)
                {
                    int val = (newIndex / 2) | (tiles[oldIndex++] << 12);
                    ttbData[newIndex++] = (byte)val;
                    ttbData[newIndex++] = (byte)(val >> 8);
                }
                ttbData[newIndex++] = 31;
                ttbData[newIndex++] = 0;
                ttbData[newIndex++] = 31;
                ttbData[newIndex++] = 0;
            }
        }


    }
}
