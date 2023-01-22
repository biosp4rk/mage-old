using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace mage
{
    public class Palette
    {
        // properties
        public ushort[,] ARGBs { get { return palette; } }
        public int Offset { get { return addr; } }
        public int Rows { get { return palette.Length / 16; } }

        // fields
        private ushort[,] palette;
        private int addr;

        // constructor
        public Palette(int len)
        {
            palette = new ushort[len, 16];
        }

        public Palette(ByteStream bs, int offset, int len)
        {
            this.addr = offset;
            palette = new ushort[len, 16];
            Load(bs, 0, len);
        }

        private void Load(ByteStream bs, int dst, int len)
        {
            bs.Seek(addr);

            for (int r = 0; r < len; r++)  // for each entry
            {
                for (int c = 0; c < 16; c++)  // for each color
                {
                    ushort curr = bs.Read16();
                    int red = (curr & 0x1F) << 10;
                    int green = curr & 0x3E0;
                    int blue = (curr & 0x7C00) >> 10;

                    ushort val = (ushort)(0x8000 | red | green | blue);
                    palette[dst, c] = val;
                }
                palette[dst, 0] &= 0x7FFF;
                dst++;
            }
        }

        public ushort GetARGB(int r, int c)
        {
            return palette[r, c];
        }

        public ushort GetOpaqueARGB(int r, int c)
        {
            return (ushort)(palette[r, c] | 0x8000);
        }

        public Color GetOpaqueColor(int r, int c)
        {
            ushort val = palette[r, c];
            int blue = (val & 0x1F) << 3;
            int green = (val & 0x3E0) >> 2;
            int red = (val & 0x7C00) >> 7;

            return Color.FromArgb(red, green, blue);
        }

        public void SetARGB(int r, int c, ushort argb)
        {
            palette[r, c] = argb;
        }

        public void SetBitmapPalette(Bitmap img, int row, int len)
        {
            ColorPalette cp = img.Palette;

            int index = 0;
            for (int r = 0; r < len; r++)
            {
                for (int c = 0; c < 16; c++)
                {
                    cp.Entries[index++] = GetOpaqueColor(row, c);
                }
                row++;
            }

            img.Palette = cp;
        }

        public Bitmap Draw(int size, int row, int len)
        {
            Bitmap img = new Bitmap(16 * size + 17, len * size + len + 1, PixelFormat.Format16bppRgb555);

            using (Graphics g = Graphics.FromImage(img))
            {
                // fill to make grid
                SolidBrush b = new SolidBrush(Color.FromArgb(0xD8, 0xD8, 0xD8));
                g.FillRectangle(b, new Rectangle(0, 0, img.Width, img.Height));

                // draw individual colors
                for (int r = 0; r < len; r++)
                {
                    for (int c = 0; c < 16; c++)
                    {
                        Color bc = GetOpaqueColor(row, c);
                        SolidBrush sb = new SolidBrush(bc);
                        g.FillRectangle(sb, new Rectangle(c * size + c + 1, r * size + r + 1, size, size));
                    }
                    row++;
                }
            }

            return img;
        }

        public void Write(ByteStream bs, int offset = -1)
        {
            if (offset == -1)
            {
                bs.Seek(addr);
            }
            else
            {
                bs.Seek(offset);
            }
            
            int len = Rows;

            for (int r = 0; r < len; r++)  // for each entry
            {
                for (int c = 0; c < 16; c++)  // for each color
                {
                    ushort curr = palette[r, c];
                    int blue = (curr & 0x1F) << 10;
                    int green = curr & 0x3E0;
                    int red = (curr & 0x7C00) >> 10;

                    ushort val = (ushort)(red | green | blue);
                    bs.Write16(val);
                }
            }
        }

        public void Write(ByteStream bs, bool[,] modifiedColors)
        {
            int offset = addr;
            int len = Rows;

            for (int r = 0; r < len; r++)  // for each entry
            {
                for (int c = 0; c < 16; c++)  // for each color
                {
                    if (modifiedColors[r, c])
                    {
                        ushort curr = palette[r, c];
                        int blue = (curr & 0x1F) << 10;
                        int green = curr & 0x3E0;
                        int red = (curr & 0x7C00) >> 10;

                        ushort val = (ushort)(red | green | blue);
                        bs.Write16(offset, val);
                    }

                    offset += 2;
                }
            }
        }

        public void Copy(Palette source, int src, int dst, int len)
        {
            for (int r = 0; r < len; r++)  // for each entry
            {
                for (int c = 0; c < 16; c++)  // for each color
                {
                    palette[dst, c] = source.palette[src, c];
                }
                src++;
                dst++;
            }
        }

        public void Export(string path, PalFileType type)
        {
            ByteStream bs = new ByteStream();
           
            if (type == PalFileType.TLP)
            {
                bs.WriteASCII("TPL");
                bs.Write8(2); // 15-bit format
            }

            for (int r = 0; r < Rows; r++)
            {
                for (int c = 0; c < 16; c++)
                {
                    if (type == PalFileType.YYCHR)
                    {
                        Color col = GetOpaqueColor(r, c);
                        bs.Write8(col.R);
                        bs.Write8(col.G);
                        bs.Write8(col.B);
                    }
                    else
                    {
                        ushort curr = palette[r, c];
                        int blue = (curr & 0x1F) << 10;
                        int green = curr & 0x3E0;
                        int red = (curr & 0x7C00) >> 10;
                        ushort val = (ushort)(red | green | blue);
                        bs.Write16(val);
                    }
                }
            }

            bs.Export(path);
        }

        public void Import(string path, PalFileType type)
        {
            BinaryReader br = new BinaryReader(File.OpenRead(path));

            if (type == PalFileType.TLP)
            {
                br.ReadInt32();
            }

            try
            {
                for (int r = 0; r < Rows; r++)  // for each entry
                {
                    for (int c = 0; c < 16; c++)  // for each color
                    {
                        if (type == PalFileType.YYCHR)
                        {
                            byte red = br.ReadByte();
                            byte green = br.ReadByte();
                            byte blue = br.ReadByte();
                            ushort val = (ushort)(0x8000 |
                                ((red / 8) << 10) |
                                ((green / 8) << 5) |
                                (blue / 8));
                            palette[r, c] = val;
                        }
                        else
                        {
                            ushort curr = br.ReadUInt16();
                            int red = (curr & 0x1F) << 10;
                            int green = curr & 0x3E0;
                            int blue = (curr & 0x7C00) >> 10;

                            ushort val = (ushort)(0x8000 | red | green | blue);
                            palette[r, c] = val;
                        }
                    }
                    palette[r, 0] &= 0x7FFF;
                }
            }
            catch { }

            br.Close();
        }

    }
}
