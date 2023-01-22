using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace mage
{
    public partial class FormCredits : Form
    {
        // fields
        private byte[] gfxData;
        private Palette palette;
        private ushort[] tileTable;
        private int ttbIndex;

        private Bitmap image;
        private ByteStream romStream;

        public FormCredits()
        {
            InitializeComponent();

            this.romStream = ROM.Stream;
            Initialize();
        }

        private void Initialize()
        {
            // get palette
            palette = new Palette(romStream, 0x7478A0, 3);

            // get graphics
            gfxData = new byte[0x2400];
            Array.Copy(romStream.Data, 0x747900, gfxData, 0, 0x1400);
            Array.Copy(romStream.Data, 0x748D00, gfxData, 0x1400, 0x1C0);
            Array.Copy(romStream.Data, 0x748EC0, gfxData, 0x1800, 0x240);
            Array.Copy(romStream.Data, 0x749100, gfxData, 0x1C00, 0x2C0);
            Array.Copy(romStream.Data, 0x7493C0, gfxData, 0x2000, 0x2C0);

            // get tile table
            int addr = 0x74B0B0;
            int position = 0;
            StringBuilder text = new StringBuilder();

            int lines = GetNumberOfLines(addr);
            label_lines.Text = "Lines: " + lines;
            tileTable = new ushort[lines * 0x20];

            bool reading = true;
            while (reading)
            {
                int offset = addr + position * 0x24;
                byte inst = romStream.Read8(offset++);

                switch (inst)
                {
                    case 0:
                        text.Append("[1B]");
                        ReadOneLine(text, offset, 0x1000);
                        break;
                    case 1:
                        text.Append("[1R]");
                        ReadOneLine(text, offset, 0x2000);
                        break;
                    case 2:
                        text.Append("[2W]");
                        ReadTwoLines(text, offset);
                        break;
                    case 5:
                        text.Append("[1]");
                        ttbIndex += 0x20;
                        break;
                    case 6:
                        text.Append("[END]");
                        reading = false;
                        break;
                    case 0xA:
                        text.Append("[Copyright1]");
                        ReadCopyright(0xE, 8, 0xA0);
                        break;
                    case 0xB:
                        text.Append("[Copyright2]");
                        ReadCopyright(0x12, 6, 0xC0);
                        break;
                    case 0xC:
                        text.Append("[Copyright3]");
                        ReadCopyright(0x16, 4, 0xE0);
                        break;
                    case 0xD:
                        text.Append("[Copyright4]");
                        ReadCopyright(0x12, 6, 0x100);
                        break;
                }

                text.Append("\r\n");
                position++;
            }

            textBox.Text = text.ToString();
            image = new Bitmap(240, tileTable.Length / 4 + 160, PixelFormat.Format8bppIndexed);
            Draw();
            gfxView_preview.Size = new Size(480, image.Height * 2);
            gfxView_preview.BackgroundImage = image;
        }

        private int GetNumberOfLines(int offset)
        {
            int lines = 0;

            while (true)
            {
                byte inst = romStream.Read8(offset);
                if (inst == 6) { break; }

                if (inst == 2) { lines += 2; }
                else { lines++; }
                offset += 0x24;
            }

            return lines;
        }

        private void ReadOneLine(StringBuilder text, int offset, ushort color)
        {
            int index = ttbIndex;

            while (true)
            {
                byte ch = romStream.Read8(offset++);
                if (0x41 <= ch && ch <= 0x5A)
                {
                    text.Append((char)ch);
                    tileTable[index] = (ushort)(color | (ch - 0x40));
                }
                else if (ch == 0x26)
                {
                    text.Append('&');
                    tileTable[index] = (ushort)(color | 0x1D);
                }
                else if (ch == 0x2C)
                {
                    text.Append(',');
                    tileTable[index] = (ushort)(color | 0x1C);
                }
                else if (ch == 0x2E)
                {
                    text.Append('.');
                    tileTable[index] = (ushort)(color | 0x1D);
                }
                else if (ch == 0)
                {
                    break;
                }
                else
                {
                    text.Append(' ');
                }

                index++;
            }

            ttbIndex += 0x20;
        }

        private void ReadTwoLines(StringBuilder text, int offset)
        {
            int index = ttbIndex;

            while (true)
            {
                byte ch = romStream.Read8(offset++);
                if (0x41 <= ch && ch <= 0x5A)
                {
                    text.Append((char)ch);
                    tileTable[index] = (ushort)(ch - 0x21);
                    tileTable[index + 0x20] = (ushort)(ch - 1);
                }
                else if (0x61 <= ch && ch <= 0x7A)
                {
                    text.Append((char)ch);
                    tileTable[index] = (ushort)(ch - 1);
                    tileTable[index + 0x20] = (ushort)(ch + 0x1F);
                }
                else if (ch == 0x2B)
                {
                    text.Append('í');
                    tileTable[index] = 0x7A;
                    tileTable[index + 0x20] = 0x9A;
                }
                else if (ch == 0x2C)
                {
                    text.Append(',');
                    tileTable[index + 0x20] = 0x5C;
                }
                else if (ch == 0x2D)
                {
                    text.Append('\'');
                    tileTable[index + 0x20] = 0x3A;
                }
                else if (ch == 0x2E)
                {
                    text.Append('.');
                    tileTable[index + 0x20] = 0x5B;
                }
                else if (ch == 0)
                {
                    break;
                }
                else
                {
                    text.Append(' ');
                }

                index++;
            }

            ttbIndex += 0x40;
        }

        private void ReadCopyright(int len, int indent, ushort value)
        {
            for (int i = 0; i < len; i++)
            {
                tileTable[ttbIndex + indent + i] = (ushort)(value + i);
            }
            ttbIndex += 0x20;
        }

        private unsafe void Draw()
        {
            int w = image.Width;
            int index = 0;
            palette.SetBitmapPalette(image, 0, 3);

            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
            BitmapData imgData = image.LockBits(rect, ImageLockMode.WriteOnly, image.PixelFormat);

            byte* startPtr = (byte*)imgData.Scan0;
            startPtr += w * 160;
            byte* imgPtr = startPtr;

            for (int t = 0; t < tileTable.Length; t++)
            {
                if (t % 32 >= 30)
                {
                    index++;
                    continue;
                }

                int x = (t % 32) * 8;
                int y = (t / 32) * 8;
                imgPtr = startPtr + y * w + x;

                ushort currTile = tileTable[index++];
                int tileNum = (currTile & 0x3FF) * 0x20;
                int pal = (currTile >> 12) << 4;
                int flip = (currTile >> 10) & 3;

                switch (flip)
                {
                    // no flip
                    case 0:
                        for (int r = 0; r < 8; r++)
                        {
                            for (int pp = 0; pp < 4; pp++)
                            {
                                byte val = gfxData[tileNum++];
                                *imgPtr++ = (byte)(pal | val & 0xF);
                                *imgPtr++ = (byte)(pal | val >> 4);
                            }
                            // end of row
                            imgPtr += (w - 8);
                        }
                        break;
                    // x flip
                    case 1:
                        imgPtr += 7;
                        for (int r = 0; r < 8; r++)
                        {
                            for (int pp = 0; pp < 4; pp++)
                            {
                                byte val = gfxData[tileNum++];
                                *imgPtr-- = (byte)(pal | val & 0xF);
                                *imgPtr-- = (byte)(pal | val >> 4);
                            }
                            // end of row
                            imgPtr += (w + 8);
                        }
                        break;
                    // y flip
                    case 2:
                        imgPtr += (w * 7);
                        for (int r = 0; r < 8; r++)
                        {
                            for (int pp = 0; pp < 4; pp++)
                            {
                                byte val = gfxData[tileNum++];
                                *imgPtr++ = (byte)(pal | val & 0xF);
                                *imgPtr++ = (byte)(pal | val >> 4);
                            }
                            // end of row
                            imgPtr -= (w + 8);
                        }
                        break;
                    // xy flip
                    case 3:
                        imgPtr += (w * 7 + 7);
                        for (int r = 0; r < 8; r++)
                        {
                            for (int pp = 0; pp < 4; pp++)
                            {
                                byte val = gfxData[tileNum++];
                                *imgPtr-- = (byte)(pal | val & 0xF);
                                *imgPtr-- = (byte)(pal | val >> 4);
                            }
                            // end of row
                            imgPtr -= (w - 8);
                        }
                        break;
                }
            }

            image.UnlockBits(imgData);
        }


    }
}
