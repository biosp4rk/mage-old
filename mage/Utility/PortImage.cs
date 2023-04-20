using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;

namespace mage
{
    public class PortImage
    {
        // fields
        private List<int> rows;
        private bool isTileset;
        private int gfxOffset;

        // image data
        private int width;
        private int height;
        private ushort[] imgData;

        // data
        public byte[] gfxData;
        private List<ushort> tileTable;
        private ushort[,] palette;
        
        // constructor
        public PortImage(Bitmap img)
        {
            this.width = img.Width;
            this.height = img.Height;

            if (width % 8 != 0 || height % 8 != 0)
            {
                //throw new FormatException("Invalid dimensions.");
                throw new FormatException(Properties.Resources.Utility_PortImage_InvalidDimText);
            }

            // check for valid pixel format
            try
            {
                img.GetPixel(0, 0);
            }
            catch
            {
                //throw new FormatException("Invalid pixel format.");
                throw new FormatException(Properties.Resources.Utility_PortImage_InvalidPixelText);
            }

            GetImageData(img);
        }

        private void GetImageData(Bitmap img)
        {
            imgData = new ushort[img.Width * img.Height];
            int index = 0;

            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    Color c = img.GetPixel(x, y);
                    int argb = ((c.R >> 3) << 10) | ((c.G >> 3) << 5) | (c.B >> 3);
                    if (c.A == 0xFF) { argb |= 0x8000; }
                    imgData[index++] = (ushort)argb;
                }
            }
        }

        // gfx
        public void GetGfx(Palette pal, bool trimBlankTiles)
        {
            // create dictionary of palette colors
            Dictionary<ushort, int> palIndecies = new Dictionary<ushort, int>();
            ushort[] colors = new ushort[16];

            for (int c = 0; c < 16; c++)
            {
                ushort argb = (ushort)(pal.GetARGB(0, c) & 0x7FFF);
                colors[c] = argb;

                if (!palIndecies.ContainsKey(argb))
                {
                    palIndecies.Add(argb, c);
                }
            }

            // find closest matches for each color
            int w = width / 8;
            int h = height / 8;

            gfxData = new byte[w * h * 0x20];
            int src = 0;
            int dst = 0;

            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    for (int v = 0; v < 8; v++)
                    {
                        for (int pp = 0; pp < 8; pp += 2)
                        {
                            ushort argb1 = (ushort)(imgData[src++] & 0x7FFF);
                            ushort argb2 = (ushort)(imgData[src++] & 0x7FFF);

                            // find matches
                            int index1;
                            if (!palIndecies.TryGetValue(argb1, out index1))
                            {
                                index1 = ClosestColor(colors, argb1);
                                palIndecies.Add(argb1, index1);
                            }
                            int index2;
                            if (!palIndecies.TryGetValue(argb2, out index2))
                            {
                                index2 = ClosestColor(colors, argb2);
                                palIndecies.Add(argb2, index2);
                            }

                            gfxData[dst++] = (byte)(index1 | (index2 << 4));
                        }

                        src += (width - 8);
                    }

                    src -= (width * 8 - 8);
                }

                src += (width * 7);
            }

            // trim blank tiles
            if (trimBlankTiles)
            {
                int blankPairs = 0;
                for (int i = gfxData.Length - 1; i >= 0; i--)
                {
                    if (gfxData[i] == 0) { blankPairs++; }
                    else { break; }
                }

                int blankTiles = blankPairs / 0x20;
                int numTiles = width * height - blankTiles;
                Array.Resize(ref gfxData, numTiles * 0x20);
            }
        }

        private int ClosestColor(ushort[] colors, ushort rgb)
        {
            double closestDist = 10000;
            int closestColor = 0;

            int r = (rgb & 0x7C00) >> 10;
            int g = (rgb & 0x3E0) >> 5;
            int b = rgb & 0x1F;

            for (int c = 0; c < 16; c++)
            {
                int argb2 = colors[c];
                int Rdiff = r - ((argb2 & 0x7C00) >> 10);
                int Gdiff = g - ((argb2 & 0x3E0) >> 5);
                int Bdiff = b - (argb2 & 0x1F);
                double dist = (Rdiff * Rdiff) + (Gdiff * Gdiff) + (Bdiff * Bdiff);

                if (dist < closestDist)
                {
                    closestDist = dist;
                    closestColor = c;
                }
            }

            return closestColor;
        }

        // level gfx
        public void GetData(VramBG vram, List<int> rows, bool isTileset, bool addToGfx)
        {
            this.rows = rows;
            this.isTileset = isTileset;

            InitializePalette(vram.BGpalette);
            InitializeGfxData(vram.BGtiles, addToGfx);
            tileTable = new List<ushort>();

            // for each tile in the image
            int numOfTiles = imgData.Length / 64;
            for (int tile = 0; tile < numOfTiles; tile++)
            {
                // get all unique colors in tile
                ushort[] tilePalette = GetUniqueColors(tile);

                // check palette against existing palettes
                int assignedRow = FindPaletteMatch(ref tilePalette);
                bool newPalette = false;

                // compare against each existing tile
                FindTileMatch(tile, tilePalette, assignedRow, newPalette);
            }
        }

        private void InitializePalette(Palette pal)
        {
            palette = new ushort[16, 15];

            // copy palette
            ushort[,] curr = pal.ARGBs;
            for (int r = 0; r < 16; r++)
            {
                for (int c = 0; c < 15; c++)
                {
                    // skip transparent color
                    palette[r, c] = curr[r, c + 1];
                }
            }
        }

        private void InitializeGfxData(byte[] gfx, bool addToGfx)
        {
            gfxData = new byte[0x8000];

            if (!isTileset)
            {
                if (!addToGfx)
                {
                    Array.Copy(gfx, 0xBDE0, gfxData, 0x7DE0, 0x220);
                    gfxOffset = 0x7DC0;
                    return;
                }

                // find beginning of blank gfx
                gfxOffset = 0xBDC0;
                while (gfxOffset >= 0x4000)
                {
                    bool blank = true;
                    for (int i = 0; i < 0x20; i++)
                    {
                        if (gfx[gfxOffset + i] != 0)
                        {
                            blank = false;
                            break;
                        }
                    }
                    if (blank) { break; }
                    gfxOffset -= 0x20;
                }

                if (gfxOffset < 0x4000)
                {
                    //throw new FormatException("No more space remaining for new graphics.");
                    throw new FormatException(Properties.Resources.Utility_PortImage_NoSpaceText);
                }

                Array.Copy(gfx, gfxOffset, gfxData, gfxOffset - 0x4000, 0xC000 - gfxOffset);
                gfxOffset -= 0x4000;
            }
            else
            {
                Array.Copy(gfx, gfxData, 0x1800);
                gfxOffset = 0x1800;
            }
        }

        private int GetPixelDataOffset(int tile)
        {
            int offset;
            if (!isTileset)
            {
                if (width == 512)
                {
                    offset = (tile / 1024) * 256 + (tile % 1024 / 32) * 4096 + (tile % 32) * 8;
                }
                else { offset = (tile / 32) * 2048 + (tile % 32) * 8; }
            }
            else
            {
                offset = (tile / 64) * 4096 + ((tile % 4) / 2) * 2048 + ((tile % 64) / 4) * 16 + (tile % 2) * 8;
            }

            return offset;
        }

        private ushort[] GetUniqueColors(int tile)
        {
            int offset = GetPixelDataOffset(tile);
            ushort[] tilePalette = new ushort[15];
            int colors = 0;

            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    ushort val = imgData[offset++];

                    // check for transparent pixel
                    if ((val >> 15) == 0) { continue; }

                    int index = Array.IndexOf(tilePalette, val);
                    // add to palette if color not found
                    if (index == -1)
                    {
                        // check for too many colors
                        if (colors == 15)
                        {
                            //throw new FormatException("Tile " + Hex.ToString(tile) + " has more than 15 colors");
                            throw new FormatException(string.Format(Properties.Resources.Utility_PortImage_TooMangyColorText, Hex.ToString(tile)));
                        }

                        tilePalette[colors++] = val;
                    }
                }
                offset += (width - 8);
            }

            return tilePalette;
        }

        private int FindPaletteMatch(ref ushort[] tilePalette)
        {
            ushort emptyColor = 0;

            for (int r = 0; r < 16; r++)
            {
                // skip rows getting overwritten
                if (rows.Contains(r - 2)) { continue; }

                // create copy of row
                ushort[] row = new ushort[15];
                for (int c = 0; c < 15; c++) { row[c] = palette[r, c]; }

                // breaks if the row is full and different
                bool match = true;
                for (int c = 0; c < 15; c++)
                {
                    ushort color = tilePalette[c];

                    // if end of row reached, all colors have been checked
                    if (color == emptyColor) { break; }

                    // if row doesn't contain the color
                    if (Array.IndexOf(row, color) == -1)
                    {
                        int index = Array.IndexOf(row, emptyColor);
                        // check if row has an empty slot
                        if (index != -1)
                        {
                            row[index] = color;
                        }
                        else
                        {
                            match = false;
                            break;
                        }
                    }
                }

                // if a match was found
                if (match)
                {
                    for (int c = 0; c < 15; c++) { palette[r, c] = row[c]; }
                    // reassign palette since it was modified
                    tilePalette = row;
                    return r;
                }
            }

            // if no match was found
            if (rows.Count == 0)
            {
                //throw new FormatException("Image has too many palettes");
                throw new FormatException(Properties.Resources.Utility_PortImage_TooMangyPalText);
            }

            // add new palette, leave tile gfx data untouched
            int assigned = rows[0] + 2;
            rows.RemoveAt(0);
            for (int c = 0; c < 15; c++) { palette[assigned, c] = tilePalette[c]; }
            return assigned;
        }

        private byte[] GetTileGfx(int tile, ushort[] tilePalette)
        {
            int offset = GetPixelDataOffset(tile);
            byte[] tileGfx = new byte[32];
            int i = 0;

            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x += 2)
                {
                    ushort val1 = imgData[offset++];
                    ushort val2 = imgData[offset++];
                    int index1;
                    int index2;

                    if ((val1 >> 15) == 0)
                    {
                        index1 = 0;
                    }
                    else
                    {
                        index1 = Array.IndexOf(tilePalette, val1) + 1;
                    }
                    if ((val2 >> 15) == 0)
                    {
                        index2 = 0;
                    }
                    else
                    {
                        index2 = Array.IndexOf(tilePalette, val2) + 1;
                    }

                    tileGfx[i++] = (byte)(index1 | (index2 << 4));
                }
                offset += (width - 8);
            }

            return tileGfx;
        }

        private void FindTileMatch(int tile, ushort[] tilePalette, int assignedRow, bool newPalette)
        {
            int t;
            int diff;
            if (!isTileset)
            {
                t = 0x7FE0;
                diff = -32;
            }
            else
            {
                t = 0;
                diff = 32;
            }
            int flip = 0;
            bool match = false;
            byte[] tileGfx = GetTileGfx(tile, tilePalette);

            // compare against tiles already written
            while (t != gfxOffset)
            {
                for (flip = 0; flip < 4; flip++)
                {
                    match = CheckTileMatch(flip, t, tileGfx);
                    if (match) { goto End; }
                }
                // TODO: new palette
                t += diff;
            }

        End:
            int tileNum = t / 0x20;
            if (!match)
            {
                // check number of tiles and if tile isn't blank
                if ((!isTileset && tileNum < 0) || (isTileset && tileNum == 0x400) || (gfxData[t] != 0))
                {
                    //throw new FormatException("Image has too many unique tiles.");
                    throw new FormatException(Properties.Resources.Utility_PortImage_TooMangyTileText);
                }
                // add new gfx data
                Array.Copy(tileGfx, 0, gfxData, gfxOffset, 0x20);
                gfxOffset += diff;

                flip = 0;
            }

            tileTable.Add((ushort)((assignedRow << 12) | (flip << 10) | tileNum));
        }

        private bool CheckTileMatch(int flip, int t, byte[] tileGfx)
        {
            switch (flip)
            {
                case 0:
                    // no flip
                    for (int pp = 0; pp < 32; pp++)
                    {
                        if (gfxData[t + pp] != tileGfx[pp]) { return false; }
                    }
                    return true;
                case 1:
                    // x flip
                    for (int pp = 0; pp < 32; pp++)
                    {
                        byte val1 = gfxData[t + pp];
                        byte val2 = tileGfx[pp + 3 - (pp % 4) * 2];
                        if ((val1 >> 4) != (val2 & 0xF) || (val1 & 0xF) != (val2 >> 4)) { return false; }
                    }
                    return true;
                case 2:
                    // y flip
                    for (int pp = 0; pp < 32; pp++)
                    {
                        if (gfxData[t + pp] != tileGfx[28 - pp + (pp % 4) * 2]) { return false; }
                    }
                    return true;
                case 3:
                    // xy flip
                    for (int pp = 0; pp < 32; pp++)
                    {
                        byte val1 = gfxData[t + pp];
                        byte val2 = tileGfx[31 - pp];
                        if ((val1 >> 4) != (val2 & 0xF) || (val1 & 0xF) != (val2 >> 4)) { return false; }
                    }
                    return true;
                default:
                    throw new ArgumentException();
            }
        }

        public void WritePalette(int palettePtr, bool shared)
        {
            // copy to original palette
            ByteStream romStream = ROM.Stream;
            int offset = romStream.ReadPtr(palettePtr);
            Palette orig = new Palette(romStream, offset, 14);

            for (int r = 1; r < 14; r++)
            {
                for (int c = 0; c < 15; c++)
                {
                    ushort argb = palette[r + 2, c];
                    orig.SetARGB(r, c + 1, argb);
                }
            }

            ByteStream bs = new ByteStream();
            orig.Write(bs, 0);
            romStream.Write(bs, 0x1C0, palettePtr, shared);
        }

        public void WriteGfx(int gfxPtr, int origLen, bool shared)
        {
            ByteStream romStream = ROM.Stream;
            ByteStream compData = new ByteStream();
            byte[] uncompTemp;

            if (!isTileset)
            {
                int length = 0x7DC0 - gfxOffset;
                uncompTemp = new byte[length];
                Array.Copy(gfxData, gfxOffset + 0x20, uncompTemp, 0, length);
            }
            else
            {
                int length = gfxOffset - 0x1800;
                uncompTemp = new byte[length];
                Array.Copy(gfxData, 0x1800, uncompTemp, 0, length);
            }

            // compress by LZ77
            ByteStream uncompData = new ByteStream(uncompTemp);
            Compress.CompLZ77(uncompData, uncompTemp.Length, compData);
            romStream.Write(compData, origLen, gfxPtr, shared);
        }

        public void WriteTileTable(int ttbPtr, int origLen, bool shared)
        {
            ByteStream romStream = ROM.Stream;

            if (!isTileset)
            {
                // copy to bytestream
                int length = tileTable.Count * 2;
                ByteStream uncompData = new ByteStream(length);
                foreach (ushort tile in tileTable)
                {
                    uncompData.Write16(tile);
                }

                // get size
                byte size = 0;
                if (width == 512) { size = 1; }
                else if (height == 512) { size = 2; }

                // compress by LZ77
                ByteStream compData = new ByteStream();
                compData.Write32(size);
                Compress.CompLZ77(uncompData, length, compData);

                romStream.Write(compData, origLen, ttbPtr, shared);
            }
            else
            {
                ByteStream ttb = new ByteStream();
                byte rows = (byte)(tileTable.Count / 0x40);
                ttb.Write8(2);
                ttb.Write8(rows);

                foreach (ushort tile in tileTable)
                {
                    ttb.Write16(tile);
                }                

                romStream.Write(ttb, origLen, ttbPtr, shared);
            }
        }

        public static Bitmap Export(Bitmap img, PixelFormat format)
        {
            if (img.PixelFormat == format)
            {
                return img;
            }

            Bitmap output = new Bitmap(img.Width, img.Height, format);
            using (Graphics g = Graphics.FromImage(output))
            {
                g.DrawImage(img, 0, 0);
            }

            return output;
        }


    }
}
