using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace mage
{
    public class Backgrounds
    {
        // properties
        public byte width;
        public byte height;

        public bool[] GetExists()
        {
            return new bool[4] { bg0.Exists, bg1.Exists, bg2.Exists, bg3.Exists };
        }
        public bool[] View
        {
            get { return viewBG; }
            set { viewBG = value; }
        }
        public Block GetBlock(int x, int y)
        {
            Block b;
            if (bg0.IsRLE) { b.BG0 = bg0.blocks[x, y]; }
            else { b.BG0 = 0xFFFF; }
            if (bg1.Exists) { b.BG1 = bg1.blocks[x, y]; }
            else { b.BG1 = 0xFFFF; }
            if (bg2.Exists) { b.BG2 = bg2.blocks[x, y]; }
            else { b.BG2 = 0xFFFF; }
            b.CLP = clip.blocks[x, y];
            return b;
        }
        public void SetBlock(Block b, int x, int y)
        {
            if (bg0.IsRLE) { bg0.blocks[x, y] = b.BG0; }
            if (bg1.Exists) { bg1.blocks[x, y] = b.BG1; }
            if (bg2.Exists) { bg2.blocks[x, y] = b.BG2; }
            clip.blocks[x, y] = b.CLP;
        }

        // fields
        public BG bg0;
        public BG bg1;
        public BG bg2;
        public BG bg3;
        public BG clip;
        public BG this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return bg0;
                    case 1:
                        return bg1;
                    case 2:
                        return bg2;
                    case 3:
                        return clip;
                    default:
                        return null;
                }
            }
        }

        public ClipTypes clipTypes;
        private bool[] viewBG;
        public Bitmap BG0img;
        public Bitmap BG3img;

        // transparency related
        private int layerUnderBG0;
        private bool BG0overSprites;
        private byte alphaHigh;
        private byte alphaLow;

        private Room room;
        private Header header;

        // constructor
        public Backgrounds(Room room)
        {
            this.room = room;
            this.header = room.header;

            Initialize();
        }

        public void Initialize()
        {
            GetTransInfo();

            byte a = room.AreaID;
            byte r = room.RoomID;
            try { bg0 = ROM.LoadBG(a, r, Layer.BG0); }
            catch { throw new CorruptDataException(Corrupt.BG0); }
            try { bg1 = ROM.LoadBG(a, r, Layer.BG1); }
            catch { throw new CorruptDataException(Corrupt.BG1); }
            try { bg2 = ROM.LoadBG(a, r, Layer.BG2); }
            catch { throw new CorruptDataException(Corrupt.BG2); }
            try { clip = ROM.LoadBG(a, r, Layer.Clip); }
            catch { throw new CorruptDataException(Corrupt.Clip); }
            try { bg3 = ROM.LoadBG(a, r, Layer.BG3); }
            catch { throw new CorruptDataException(Corrupt.BG3); }

            bg1 = ROM.LoadBG(a, r, Layer.BG1);
            bg2 = ROM.LoadBG(a, r, Layer.BG2);
            clip = ROM.LoadBG(a, r, Layer.Clip);
            bg3 = ROM.LoadBG(a, r, Layer.BG3);

            clipTypes = new ClipTypes(clip);
            viewBG = new bool[4] { bg0.Exists, bg1.Exists, bg2.Exists, bg3.Exists };

            try
            {
                if (bg0.IsLZ77) { DrawLZ77(bg0); }
            }
            catch { throw new CorruptDataException(Corrupt.BG0); }
            try { DrawLZ77(bg3); }
            catch { throw new CorruptDataException(Corrupt.BG3); }
            

            width = clip.width;
            height = clip.height;
        }

        private void GetTransInfo()
        {
            byte trans = header.transparency;

            // find BG under BG0
            if (trans < 4 || trans >= 0x34)
            {
                layerUnderBG0 = 1;
                BG0overSprites = true;
            }
            else
            {
                switch (trans % 4)
                {
                    case 0:
                        layerUnderBG0 = 1;
                        BG0overSprites = true;
                        break;
                    case 1:
                        layerUnderBG0 = 2;
                        BG0overSprites = true;
                        break;
                    case 2:
                        layerUnderBG0 = 2;
                        BG0overSprites = false;
                        break;
                    case 3:
                        layerUnderBG0 = 3;
                        BG0overSprites = false;
                        break;
                }
            }

            // get alpha coefficients
            alphaHigh = 16;
            alphaLow = 0;
            if (trans < 8) { return; }

            if (trans < 0x18)
            {
                alphaLow = (byte)(7 + ((trans - 8) / 4) * 3);
            }
            else if (trans < 0x34)
            {
                int slot = (trans - 0x18) / 4;
                switch (slot)
                {
                    case 0:
                        alphaHigh = 0; break;
                    case 1:
                        alphaHigh = 3; break;
                    case 2:
                        alphaHigh = 6; break;
                    case 3:
                        alphaHigh = 9; break;
                    case 4:
                        alphaHigh = 11; break;
                    case 5:
                        alphaHigh = 13; break;
                    case 6:
                        alphaHigh = 16; break;
                }
                alphaLow = (byte)(16 - alphaHigh);
            }
        }

        public bool DrawNextLayer(Rectangle region, BitmapData dstData, BitmapData srcData, ref int drawNext)
        {
            switch (drawNext)
            {
                case 0:
                    #region draw BG0
                    if (viewBG[0])
                    {
                        if (bg0.IsRLE)
                        {
                            if (header.transparency < 8)
                            {
                                bg0.DrawRLE(region, srcData, dstData);
                            }
                            else
                            {
                                DrawTransparency(region, srcData, dstData);
                            }
                        }
                        else
                        {
                            if (header.effectY != 0xFF)
                            {
                                DrawLiquid(region, dstData);
                            }
                            else
                            {
                                TileBG0(region, dstData);
                            }
                        }
                    }
                    #endregion
                    if (layerUnderBG0 == 3) { drawNext = 2; }
                    else { drawNext = 1; }
                    //return (layerUnderBG0 == 2 && !BG0overSprites);
                    return false;
                case 1:
                    if (viewBG[1]) { bg1.DrawRLE(region, srcData, dstData); }
                    drawNext = 0;
                    //return false;
                    return true;
                case 2:
                    if (viewBG[2]) { bg2.DrawRLE(region, srcData, dstData); }
                    if (layerUnderBG0 == 2) { drawNext = 0; }
                    else { drawNext = 1; }
                    //return (layerUnderBG0 != 2 || BG0overSprites);
                    return false;
                case 3:
                    if (viewBG[3]) { TileBG3(region, dstData); }
                    if (layerUnderBG0 == 3) { drawNext = 0; }
                    else { drawNext = 2; }
                    return false;
            }

            return false;
        }

        public void Draw(Rectangle region, BitmapData dstData)
        {
            Bitmap srcImg = room.vram.Image;
            BitmapData srcData = srcImg.LockBits(new Rectangle(0, 0, 256, srcImg.Height), ImageLockMode.ReadOnly, srcImg.PixelFormat);

            for (int i = 3; i >= 1; i--)
            {
                if (viewBG[i])
                {
                    if (i == 3) { TileBG3(region, dstData); }
                    else { this[i].DrawRLE(region, srcData, dstData); }
                }
                if (viewBG[0] && layerUnderBG0 == i)
                {
                    if (bg0.IsRLE)
                    {
                        if (header.transparency < 8)
                        {
                            bg0.DrawRLE(region, srcData, dstData);
                        }
                        else
                        {
                            DrawTransparency(region, srcData, dstData);
                        }
                    }
                    else
                    {
                        if (header.effectY != 0xFF)
                        {
                            DrawLiquid(region, dstData);
                        }
                        else
                        {
                            TileBG0(region, dstData);
                        }
                    }
                }
            }
            srcImg.UnlockBits(srcData);
        }

        private unsafe void DrawTransparency(Rectangle region, BitmapData srcData, BitmapData dstData)
        {
            int numTiles = srcData.Height;
            int imgWidth = dstData.Stride / 2;
            int dstWidth = region.Width << 4;

            ushort* srcStart = (ushort*)srcData.Scan0;
            ushort* srcPtr;
            ushort* dstPtr = (ushort*)dstData.Scan0;
            dstPtr += (region.Y << 4) * imgWidth + (region.X << 4);

            int xEnd = region.X + region.Width;
            int yEnd = region.Y + region.Height;

            // blend
            for (int y = region.Y; y < yEnd; y++)
            {
                for (int x = region.X; x < xEnd; x++)
                {
                    // skip if block is empty
                    ushort tileNum = bg0.blocks[x, y];
                    if (tileNum == 0 || tileNum >= numTiles)
                    {
                        dstPtr += 16;
                        continue;
                    }
                    srcPtr = srcStart + (tileNum / 16) * 4096 + (tileNum % 16) * 16;

                    for (int v = 0; v < 16; v++)
                    {
                        for (int u = 0; u < 16; u++)
                        {
                            // find non-transparent pixels
                            ushort srcPx = *srcPtr++;
                            if (srcPx < 0x8000)
                            {
                                dstPtr++;
                                continue;
                            }

                            ushort dstPx = *dstPtr;
                            int red = Math.Min(0x7C00, (((srcPx & 0x7C00) * alphaLow >> 4) & 0x7C00) + (((dstPx & 0x7C00) * alphaHigh >> 4) & 0x7C00));
                            int green = Math.Min(0x3E0, (((srcPx & 0x3E0) * alphaLow >> 4) & 0x3E0) + (((dstPx & 0x3E0) * alphaHigh >> 4) & 0x3E0));
                            int blue = Math.Min(0x1F, ((srcPx & 0x1F) * alphaLow >> 4) + ((dstPx & 0x1F) * alphaHigh >> 4));
                            *dstPtr++ = (ushort)(0x8000 | red | green | blue);
                        }
                        srcPtr += 240;
                        dstPtr += (imgWidth - 16);
                    }
                    dstPtr -= (imgWidth * 16 - 16);
                }
                dstPtr += (imgWidth * 16 - dstWidth);
            }
        }

        private unsafe void DrawLiquid(Rectangle region, BitmapData dstData)
        {
            BitmapData srcData = BG0img.LockBits(new Rectangle(0, 0, BG0img.Width, BG0img.Height), ImageLockMode.ReadOnly, BG0img.PixelFormat);

            int xStart = region.X << 4;
            int yStart = region.Y << 4;
            int xEnd = (region.X + region.Width) << 4;
            int yEnd = (region.Y + region.Height) << 4;
            int effectY = room.header.effectY << 4;
            int w, h;

            int srcWidth = srcData.Width;
            int imgWidth = dstData.Stride / 2;

            for (int y = Math.Max(yStart, effectY - 8); y < yEnd; y += h)
            {
                int v;
                // check if top of water
                if (y == effectY - 8)
                {
                    v = 504;
                    h = 8;
                }
                else
                {
                    v = (y - effectY) % 256;
                    h = Math.Min(yEnd - y, 256 - v);
                }
                int vEnd = v + h;

                for (int x = xStart; x < xEnd; x += w)
                {
                    int u = x % BG0img.Width;
                    w = Math.Min(xEnd - x, BG0img.Width - u);
                    int uEnd = u + w;

                    ushort* srcPtr = (ushort*)srcData.Scan0 + v * srcWidth + u;
                    ushort* dstPtr = (ushort*)dstData.Scan0 + y * imgWidth + x;

                    for (int j = v; j < vEnd; j++)
                    {
                        for (int i = u; i < uEnd; i++)
                        {
                            // find non-transparent pixels
                            ushort srcPx = *srcPtr++;
                            if (srcPx < 0x8000)
                            {
                                dstPtr++;
                                continue;
                            }

                            ushort dstPx = *dstPtr;
                            int red = Math.Min(0x7C00, (((srcPx & 0x7C00) * alphaLow >> 4) & 0x7C00) + (((dstPx & 0x7C00) * alphaHigh >> 4) & 0x7C00));
                            int green = Math.Min(0x3E0, (((srcPx & 0x3E0) * alphaLow >> 4) & 0x3E0) + (((dstPx & 0x3E0) * alphaHigh >> 4) & 0x3E0));
                            int blue = Math.Min(0x1F, ((srcPx & 0x1F) * alphaLow >> 4) + ((dstPx & 0x1F) * alphaHigh >> 4));
                            *dstPtr++ = (ushort)(0x8000 | red | green | blue);
                        }
                        srcPtr += srcWidth - w;
                        dstPtr += imgWidth - w;
                    }
                }
            }

            BG0img.UnlockBits(srcData);
        }

        public void DrawLZ77(BG bg)
        {
            // get BG dimensions
            int BGwidth, BGheight;
            if (bg.size == 0) { BGwidth = 32; BGheight = 32; }
            else if (bg.size == 1) { BGwidth = 64; BGheight = 32; }
            else { BGwidth = 32; BGheight = 64; }

            // draw BG
            Bitmap img = new Bitmap(BGwidth * 8, BGheight * 8, PixelFormat.Format16bppArgb1555);
            Rectangle rect = new Rectangle(0, 0, img.Width, img.Height);
            BitmapData imgData = img.LockBits(rect, ImageLockMode.WriteOnly, img.PixelFormat);

            DrawLZ77part(imgData, bg, 0, 0, 0);
            if (bg.size == 1) { DrawLZ77part(imgData, bg, 0x400, 32, 0); }
            else if (bg.size == 2) { DrawLZ77part(imgData, bg, 0x400, 0, 32); }

            img.UnlockBits(imgData);
            if (bg.layer == Layer.BG0) { BG0img = img; }
            else if (bg.layer == Layer.BG3) { BG3img = img; }
        }

        private unsafe void DrawLZ77part(BitmapData imgData, BG bg, int index, int xStart, int yStart)
        {
            int xEnd = xStart + 32;
            int yEnd = yStart + 32;

            ushort* imgPtr = (ushort*)imgData.Scan0;
            int imgWidth = imgData.Width;
            imgPtr += (yStart * 8 * imgWidth) + (xStart * 8);

            ushort[] tileTable = bg.tileTable;
            ushort[,] palette = room.vram.BGpalette.ARGBs;
            byte[] BGtiles = room.vram.BGtiles;

            for (int y = yStart; y < yEnd; y++)
            {
                for (int x = xStart; x < xEnd; x++)
                {
                    ushort* blockPtr = imgPtr;
                    int currTile = tileTable[index++];

                    int tileNum = ((currTile & 0x3FF) + 0x200) * 0x20;
                    int pal = currTile >> 12;
                    int flip = (currTile >> 10) & 3;

                    switch (flip)
                    {
                        case 0:  // no flip
                            for (int r = 0; r < 8; r++)
                            {
                                for (int pp = 0; pp < 4; pp++)
                                {
                                    byte val = BGtiles[tileNum++];
                                    *imgPtr++ = palette[pal, val & 0xF];
                                    *imgPtr++ = palette[pal, val >> 4];
                                }
                                // end of row
                                imgPtr += (imgWidth - 8);
                            }
                            break;

                        case 1:  // x flip
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
                                imgPtr += (imgWidth + 8);
                            }
                            break;

                        case 2:  // y flip
                            imgPtr += (imgWidth * 7);
                            for (int r = 0; r < 8; r++)
                            {
                                for (int pp = 0; pp < 4; pp++)
                                {
                                    byte val = BGtiles[tileNum++];
                                    *imgPtr++ = palette[pal, val & 0xF];
                                    *imgPtr++ = palette[pal, val >> 4];
                                }
                                // end of row
                                imgPtr -= (imgWidth + 8);
                            }
                            break;

                        case 3:  // xy flip
                            imgPtr += (imgWidth * 7 + 7);
                            for (int r = 0; r < 8; r++)
                            {
                                for (int pp = 0; pp < 4; pp++)
                                {
                                    byte val = BGtiles[tileNum++];
                                    *imgPtr-- = palette[pal, val & 0xF];
                                    *imgPtr-- = palette[pal, val >> 4];
                                }
                                // end of row
                                imgPtr -= (imgWidth - 8);
                            }
                            break;
                    }
                    // end of tile
                    imgPtr = blockPtr + 8;
                }
                // end of block row
                if (bg.size == 1) { imgPtr += (imgWidth / 2 * 15); }
                else { imgPtr += (imgWidth * 7); }
            }
        }

        public unsafe void TileBG0(Rectangle region, BitmapData dstData)
        {
            int xStart = region.X << 4;
            int yStart = region.Y << 4;
            int xEnd = xStart + (region.Width << 4);
            int yEnd = yStart + (region.Height << 4);
            int w, h;

            BitmapData srcData = BG0img.LockBits(new Rectangle(0, 0, BG0img.Width, BG0img.Height), ImageLockMode.ReadOnly, BG0img.PixelFormat);
            int srcWidth = srcData.Width;
            int imgWidth = dstData.Stride / 2;

            for (int y = yStart; y < yEnd; y += h)
            {
                int v = y % BG0img.Height;
                h = Math.Min(yEnd - y, BG0img.Height - v);
                int vEnd = v + h;

                for (int x = xStart; x < xEnd; x += w)
                {
                    int u = x % srcWidth;
                    w = Math.Min(xEnd - x, srcWidth - u);
                    int uEnd = u + w;

                    ushort* srcPtr = (ushort*)srcData.Scan0 + v * srcWidth + u;
                    ushort* dstPtr = (ushort*)dstData.Scan0 + y * imgWidth + x;

                    for (int j = v; j < vEnd; j++)
                    {
                        for (int i = u; i < uEnd; i++)
                        {
                            // find non-transparent pixels
                            ushort srcPx = *srcPtr++;
                            if (srcPx < 0x8000)
                            {
                                dstPtr++;
                                continue;
                            }

                            ushort dstPx = *dstPtr;
                            int red = Math.Min(0x7C00, (((srcPx & 0x7C00) * alphaLow >> 4) & 0x7C00) + (((dstPx & 0x7C00) * alphaHigh >> 4) & 0x7C00));
                            int green = Math.Min(0x3E0, (((srcPx & 0x3E0) * alphaLow >> 4) & 0x3E0) + (((dstPx & 0x3E0) * alphaHigh >> 4) & 0x3E0));
                            int blue = Math.Min(0x1F, ((srcPx & 0x1F) * alphaLow >> 4) + ((dstPx & 0x1F) * alphaHigh >> 4));
                            *dstPtr++ = (ushort)(0x8000 | red | green | blue);
                        }
                        srcPtr += srcWidth - w;
                        dstPtr += imgWidth - w;
                    }
                }
            }

            BG0img.UnlockBits(srcData);
        }

        public unsafe void TileBG3(Rectangle region, BitmapData dstData)
        {
            int xStart = region.X << 4;
            int yStart = region.Y << 4;
            int xEnd = xStart + (region.Width << 4);
            int yEnd = yStart + (region.Height << 4);
            int w, h;

            BitmapData srcData = BG3img.LockBits(new Rectangle(0, 0, BG3img.Width, BG3img.Height), ImageLockMode.ReadOnly, BG3img.PixelFormat);
            int srcWidth = srcData.Width;
            int imgWidth = dstData.Stride / 2;

            for (int y = yStart; y < yEnd; y += h)
            {
                int v = (y + BG3img.Height - 32) % BG3img.Height;
                h = Math.Min(yEnd - y, BG3img.Height - v);
                int vEnd = v + h;

                for (int x = xStart; x < xEnd; x += w)
                {
                    int u = x % srcWidth;
                    w = Math.Min(xEnd - x, srcWidth - u);
                    int uEnd = u + w;

                    ushort* srcPtr = (ushort*)srcData.Scan0 + v * srcWidth + u;
                    ushort* dstPtr = (ushort*)dstData.Scan0 + y * imgWidth + x;

                    for (int j = v; j < vEnd; j++)
                    {
                        for (int i = u; i < uEnd; i++)
                        {
                            *dstPtr++ = *srcPtr++;
                        }
                        srcPtr += srcWidth - w;
                        dstPtr += imgWidth - w;
                    }
                }
            }

            BG3img.UnlockBits(srcData);
        }

        public void ResizeRoom(byte w, byte h)
        {
            // BG0-2, clip
            for (int i = 0; i < 4; i++)
            {
                this[i].Resize(w, h);
            }
            
            // clipdata
            clipTypes.ResizeClip(w, h);

            width = w;
            height = h;
        }

        public int[] Export(ByteStream dst)
        {
            ByteStream romStream = ROM.Stream;
            int[] offsets = new int[5];

            BG[] tempBGs = new BG[] { bg0, bg1, bg2, clip, bg3 };
            for (int i = 0; i < 5; i++)
            {
                if (tempBGs[i].Exists)
                {
                    offsets[i] = (int)dst.Position;
                    tempBGs[i].Export(dst);
                    dst.Align(4);
                }
            }

            return offsets;
        }

        public void Import(bool convertClip)
        {
            width = clip.width;
            height = clip.height;
            GetTransInfo();

            clipTypes = new ClipTypes(clip);
            if (convertClip) { clipTypes.ConvertClip(); }

            viewBG = new bool[4] { bg0.Exists, bg1.Exists, bg2.Exists, bg3.Exists };
        }


    }
}
