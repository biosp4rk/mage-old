using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;

namespace mage
{
    public class VramBG
    {
        public Bitmap Image { get { return image; } }

        public byte[] BGtiles;
        public Palette BGpalette;
        private Bitmap image;

        private AnimGFX[] animTanks;
        private int numTanks;

        private Tileset tileset;

        public VramBG(Tileset tileset, bool draw)
        {
            this.tileset = tileset;

            GetBGtiles();
            GetBGpalette();

            if (draw) { DrawTileset(); }
        }

        private void GetBGtiles()
        {
            BGtiles = new byte[0xC000];

            // copy tileset graphics
            byte[] levelData = tileset.RLEgfx.data;
            Array.Copy(levelData, 0, BGtiles, 0x1800, levelData.Length);
            byte[] bg3Data = tileset.LZ77gfx.data;
            Array.Copy(bg3Data, 0, BGtiles, 0xBDE0 - bg3Data.Length, bg3Data.Length);

            // copy generic tiles
            Array.Copy(ROM.GenericBGgfx.data, 0, BGtiles, 0x800, 0x1000);

            // copy animated tiles
            for (int i = 0; i < 16; i++)
            {
                Array.Copy(tileset.animTileset[i].gfx.data, 0, BGtiles, i * 0x80, 0x80);
            }

            // copy to end of BG3 gfx
            Array.Copy(BGtiles, 0x600, BGtiles, 0xBDE0, 0x200);
        }

        private void GetBGpalette()
        {
            BGpalette = new Palette(16);

            // copy tileset palette
            BGpalette.Copy(tileset.palette, 1, 3, 13);

            // copy generic palette
            BGpalette.Copy(ROM.GenericBGpalette, 0, 0, 3);

            // copy animated palette
            if (tileset.animPalette.type != 0 && ROM.useAnimPalette)
            {
                BGpalette.Copy(tileset.animPalette.palette, 0, 15, 1);
            }
        }

        public unsafe void DrawTileset()
        {
            ushort[] tileTable = tileset.tileTable;
            int tilesetHeight = tileTable.Length / 64;
            image = new Bitmap(256, tilesetHeight * 16, PixelFormat.Format16bppArgb1555);

            // lock bitmap
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
            BitmapData imgData = image.LockBits(rect, ImageLockMode.WriteOnly, image.PixelFormat);

            int index = 0;
            ushort[,] palette = BGpalette.ARGBs;
            ushort* imgPtr = (ushort*)imgData.Scan0;

            for (int y = 0; y < tilesetHeight; y++)  // for each block down
            {
                for (int x = 0; x < 16; x++)  // for each block across
                {
                    ushort* blockPtr = imgPtr;

                    for (int t = 0; t < 4; t++)  // for each tile
                    {
                        ushort currTile = tileTable[index++];
                        int tileNum = (currTile & 0x3FF) * 0x20;
                        int pal = currTile >> 12;
                        int flip = (currTile >> 10) & 3;

                        switch (flip)
                        {
                            // no flip
                            case 0:
                                for (int r = 0; r < 8; r++)
                                {
                                    for (int pp = 0; pp < 4; pp++)
                                    {
                                        byte val = BGtiles[tileNum++];
                                        *imgPtr++ = palette[pal, val & 0xF];
                                        *imgPtr++ = palette[pal, val >> 4];
                                    }
                                    // end of row
                                    imgPtr += 248;
                                }
                                break;
                            // x flip
                            case 1:
                                imgPtr += 7;
                                for (int r = 0; r < 8; r++)
                                {
                                    for (int pp = 0; pp < 4; pp++)
                                    {
                                        byte val = BGtiles[tileNum++];
                                        *imgPtr-- = palette[pal, val & 0xF];
                                        *imgPtr-- = palette[pal, val >> 4];
                                    }
                                    // end of row
                                    imgPtr += 264;
                                }
                                break;
                            // y flip
                            case 2:
                                imgPtr += 1792;
                                for (int r = 0; r < 8; r++)
                                {
                                    for (int pp = 0; pp < 4; pp++)
                                    {
                                        byte val = BGtiles[tileNum++];
                                        *imgPtr++ = palette[pal, val & 0xF];
                                        *imgPtr++ = palette[pal, val >> 4];
                                    }
                                    // end of row
                                    imgPtr -= 264;
                                }
                                break;
                            // xy flip
                            case 3:
                                imgPtr += 1799;
                                for (int r = 0; r < 8; r++)
                                {
                                    for (int pp = 0; pp < 4; pp++)
                                    {
                                        byte val = BGtiles[tileNum++];
                                        *imgPtr-- = palette[pal, val & 0xF];
                                        *imgPtr-- = palette[pal, val >> 4];
                                    }
                                    // end of row
                                    imgPtr -= 248;
                                }
                                break;
                        }
                        switch (t)
                        {
                            case 0:
                                imgPtr = blockPtr + 8;
                                break;
                            case 1:
                                imgPtr = blockPtr + 2048;
                                break;
                            case 2:
                                imgPtr = blockPtr + 2056;
                                break;
                            case 3:
                                imgPtr = blockPtr + 16;
                                break;
                        }
                    }
                }
                // end of block row
                imgPtr += 3840;
            }

            image.UnlockBits(imgData);
        }


    }
}
