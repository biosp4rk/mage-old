using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace mage
{
    public class Minimap
    {
        // properties
        public ushort GetSquare(Point pos) { return map[pos.X, pos.Y]; }
        public void SetSquare(Point pos, ushort val) { map[pos.X, pos.Y] = val; }
        public Boolean Edited { get; set; }

        // fields
        private ushort[,] map;

        private bool isMF;
        public byte areaID;
        private int pointer;
        private int origLen;

        // constructor
        public Minimap(ByteStream romStream, byte area)
        {
            this.areaID = area;
            Edited = false;

            Initialize(romStream);
        }

        private void Initialize(ByteStream src)
        {
            try
            {
                isMF = Version.IsMF;

                // decompress map data
                pointer = Version.MinimapDataOffset + areaID * 4;
                int mapDataOffset = src.ReadPtr(pointer);
                ByteStream mapSquares = new ByteStream();
                src.Seek(mapDataOffset);
                origLen = Compress.DecompLZ77(src, mapSquares);

                // convert to 2D ushort array
                map = new ushort[32, 32];
                mapSquares.Seek(0);
                for (int y = 0; y < 32; y++)
                {
                    for (int x = 0; x < 32; x++)
                    {
                        map[x, y] = mapSquares.Read16();
                    }
                }
            }
            catch { throw new CorruptDataException(Corrupt.Minimap); }
        }

        public Bitmap Draw(ByteStream romStream, Palette palette, int view)
        {
            // view
            // 0 = Explored
            // 1 = Downloaded
            // 2 = start

            int gfxOffset = Version.MinimapGfxOffset;
            Bitmap image = new Bitmap(256, 256, PixelFormat.Format16bppRgb555);

            using (Graphics g = Graphics.FromImage(image))
            {
                for (int y = 0; y < 32; y++)
                {
                    for (int x = 0; x < 32; x++)
                    {
                        ushort val = map[x, y];
                        int squareNum = val & 0x3FF;
                        int pal = val >> 12;

                        GetSquareDisplayInfo(view, ref pal, ref squareNum, isMF);

                        int offset = gfxOffset + squareNum * 0x20;
                        GFX gfx = new GFX(romStream, offset, 1, 1);
                        Bitmap square = gfx.Draw4bpp(palette, pal, true);

                        ColorPalette cp = square.Palette;
                        cp.Entries[0] = Color.Black;
                        square.Palette = cp;

                        int flip = (val >> 10) & 3;

                        switch (flip)
                        {
                            case 0:  // no flip
                                g.DrawImage(square, x * 8, y * 8);
                                break;
                            case 1:  // x flip
                                g.DrawImage(square, x * 8 + 8, y * 8, -8, 8);
                                break;
                            case 2:  // y flip
                                g.DrawImage(square, x * 8, y * 8 + 8, 8, -8);
                                break;
                            case 3:  // xy flip
                                g.DrawImage(square, x * 8 + 8, y * 8 + 8, -8, -8);
                                break;
                        }
                    }
                }
            }

            return image;
        }

        public static void GetSquareDisplayInfo(int view, ref int pal, ref int squareNum, bool isMF)
        {
            if (isMF)
            {
                // explored, normal
                if (view == 0 && pal == 0) { pal = 1; }
                // downloaded, hidden
                else if (view == 1 && pal == 2) { squareNum = 0xA0; }
            }
            else  // zero mission
            {
                // explored
                if (view == 0)
                {
                    // start
                    if (pal == 0) { pal = 1; }
                }
                else
                {
                    // downloaded, hidden
                    if (view == 1 && pal >= 3) { squareNum = 0x140; }
                    // start, normal/hidden
                    else if (view == 2 && pal >= 1) { squareNum = 0x140; }
                    pal = 0;
                }
            }
        }

        public void Write(ByteStream dst, bool reset, bool export)
        {
            // convert map squares to ByteStream
            ByteStream uncomp = new ByteStream();
            for (int y = 0; y < 32; y++)
            {
                for (int x = 0; x < 32; x++)
                {
                    uncomp.Write16(map[x, y]);
                }
            }

            // compress by LZ77
            uncomp.Seek(0);
            ByteStream dataToWrite = new ByteStream();
            int newCompLen = Compress.CompLZ77(uncomp, 0x800, dataToWrite);

            // write new data
            if (export)
            {
                dst.Write(dataToWrite);
            }
            else
            {
                dst.Write(dataToWrite, origLen, pointer, false);
            }

            if (reset)
            {
                origLen = dataToWrite.Length;
            }
        }

        // TODO: reuse code
        public void Import(ByteStream src)
        {
            // decompress map data
            ByteStream mapSquares = new ByteStream();
            Compress.DecompLZ77(src, mapSquares);

            // fill in values
            mapSquares.Seek(0);
            for (int y = 0; y < 32; y++)
            {
                for (int x = 0; x < 32; x++)
                {
                    map[x, y] = mapSquares.Read16();
                }
            }

            Edited = true;
        }


    }
}
