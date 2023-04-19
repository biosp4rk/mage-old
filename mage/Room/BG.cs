using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;

namespace mage
{
    public struct Block
    {
        public ushort BG0;
        public ushort BG1;
        public ushort BG2;
        public ushort CLP;

        public ushort this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return BG0;
                    case 1:
                        return BG1;
                    case 2:
                        return BG2;
                    default:
                        return CLP;
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        BG0 = value;
                        break;
                    case 1:
                        BG1 = value;
                        break;
                    case 2:
                        BG2 = value;
                        break;
                    case 3:
                        CLP = value;
                        break;
                }
            }
        }

        public override string ToString()
        {
            string s0 = "BG0: " + (BG0 != 0xFFFF ? Hex.ToString(BG0) : "–") + '\n';
            string s1 = "BG1: " + (BG1 != 0xFFFF ? Hex.ToString(BG1) : "–") + '\n';
            string s2 = "BG2: " + (BG2 != 0xFFFF ? Hex.ToString(BG2) : "–") + '\n';
            //string s3 = "Clip: " + (CLP != 0xFFFF ? Hex.ToString(CLP) : "–");
            string s3 = Properties.Resources.RoomBG_BlockToStringText + (CLP != 0xFFFF ? Hex.ToString(CLP) : "–");
            return s0 + s1 + s2 + s3;
        }
    }

    public enum Layer { BG0, BG1, BG2, BG3, Clip };

    public class BG
    {
        // properties
        public bool Edited { get; set; }
        public bool Exists { get; set; }
        public byte AreaID { get; private set; }
        public byte RoomID { get; private set; }
        public bool IsRLE
        {
            get { return (prop & 0x10) != 0; }
        }
        public bool IsLZ77
        {
            get { return (prop & 0x40) != 0; }
        }

        // RLE specific
        public byte width;
        public byte height;
        public ushort[,] blocks;

        // LZ77 specific
        public byte size;
        public ushort[] tileTable;

        // meta
        public Layer layer;
        public int origLen;

        private byte prop;
        private ByteStream romStream;

        // constructor
        public BG(ByteStream romStream, byte areaID, byte roomID, Layer layer)
        {
            this.romStream = romStream;
            this.AreaID = areaID;
            this.RoomID = roomID;
            this.layer = layer;
            Edited = false;

            GetProp();
            GetBGdata();
        }

        private int GetPointer()
        {
            int bg = (int)layer;
            return Header.GetBgPointer(AreaID, RoomID, bg);
        }

        private void GetProp()
        {
            if (layer == Layer.Clip)
            {
                prop = 0x10;
            }
            else
            {
                int offset = romStream.ReadPtr(Version.AreaHeaderOffset + AreaID * 4) + (RoomID * 0x3C);
                prop = romStream.Read8(offset + 1 + (int)layer);
            }
        }

        private void GetBGdata()
        {
            Edited = false;
            Exists = true;

            int ptr = GetPointer();
            int addr = romStream.ReadPtr(ptr);
            romStream.Seek(addr);
            
            if (layer == Layer.BG3 || (layer == Layer.BG0 && IsLZ77))
            {
                size = (byte)(romStream.Read32() & 3);

                ByteStream BGdata = new ByteStream();
                origLen = Compress.DecompLZ77(romStream, BGdata);
                origLen += 4;
                tileTable = new ushort[BGdata.Length / 2];
                BGdata.CopyToArray(0, tileTable, 0, BGdata.Length);
            }
            else if (IsRLE)
            {
                width = romStream.Read8();
                height = romStream.Read8();
                CheckValidSize();

                ByteStream BGdata = new ByteStream();
                origLen = Compress.DecompRLE(romStream, BGdata);
                origLen += 2;
                CopyIntoBlocks(BGdata.Data);
            }
            else
            {
                Exists = false;
                origLen = 0;
            }
        }

        private void CheckValidSize()
        {
            if (width == 0 || height == 0 || (width * height > 0x1800))
            {
                switch (layer)
                {
                    case Layer.BG0:
                        throw new CorruptDataException(Corrupt.BG0);
                    case Layer.BG1:
                        throw new CorruptDataException(Corrupt.BG1);
                    case Layer.BG2:
                        throw new CorruptDataException(Corrupt.BG2);
                    case Layer.Clip:
                        throw new CorruptDataException(Corrupt.Clip);
                }
            }
        }

        public void Import(ByteStream src, bool rle, byte roomWidth, byte roomHeight, bool shared)
        {
            // fix property
            prop = Header.FixBgProp(AreaID, RoomID, (int)layer, rle);

            if (rle)
            {
                ImportRLE(src);
                // resize if necessary
                if (roomWidth != width || roomHeight != height)
                {
                    Resize(roomWidth, roomHeight);
                }
            }
            else { ImportLZ77(src, shared); }
        }

        public void ImportFromRoom(ByteStream src, byte comp, bool shared)
        {
            this.prop = comp;

            if (IsRLE) { ImportRLE(src); }
            else if (IsLZ77) { ImportLZ77(src, shared); }
            else { Exists = false; }
        }

        public void Export(ByteStream dst)
        {
            if (IsRLE) { WriteRLE(dst, false, true); }
            else if (IsLZ77) { WriteLZ77(dst, false, false, true); }
        }

        // RLE methods
        private void CopyIntoBlocks(byte[] BGdata)
        {
            blocks = new ushort[width, height];
            int index = 0;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    blocks[x, y] = (ushort)(BGdata[index] + (BGdata[index + 1] << 8));
                    index += 2;
                }
            }
        }

        public unsafe void DrawRLE(Rectangle region, BitmapData srcData, BitmapData dstData)
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

            for (int y = region.Y; y < yEnd; y++)
            {
                for (int x = region.X; x < xEnd; x++)
                {
                    ushort tileNum = blocks[x, y];
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
                            ushort srcPx = *srcPtr++;
                            if (srcPx < 0x8000)
                            {
                                dstPtr++;
                            }
                            else
                            {
                                *dstPtr++ = srcPx;
                            }
                        }
                        srcPtr += 240;
                        dstPtr += (imgWidth - 16);
                    }
                    dstPtr -= (imgWidth * 16 - 16);
                }
                dstPtr += (imgWidth * 16 - dstWidth);
            }
        }

        public void Clear()
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    blocks[x, y] = 0;
                }
            }

            Edited = true;
        }

        public void Resize(byte w, byte h)
        {
            ushort val;
            if (Exists)
            {
                val = 0;
                Edited = true;
            }
            else { val = 0xFFFF; }

            ushort[,] tempBlocks = new ushort[w, h];
            for (int y = 0; y < h; y++)
            {
                for (int x = 0; x < w; x++)
                {
                    if (x >= width || y >= height)
                    {
                        tempBlocks[x, y] = val;
                    }
                    else
                    {
                        tempBlocks[x, y] = blocks[x, y];
                    }
                }
            }

            blocks = tempBlocks;
            width = w;
            height = h;
        }

        public void WriteRLE(ByteStream dst, bool reset, bool export)
        {
            int length = width * height * 2;

            // convert blocks to byte array
            ByteStream uncompData = new ByteStream(length);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    ushort val = blocks[x, y];
                    uncompData.Write8((byte)val);
                    uncompData.Write8((byte)(val >> 8));
                }
            }
            
            // compress by RLE
            ByteStream compData = new ByteStream();
            compData.Write8(width);
            compData.Write8(height);
            int newCompLen = Compress.CompRLE(uncompData, length, compData);

            // write data
            if (export)
            {
                dst.Write(compData);
            }
            else
            {
                int ptr = GetPointer();
                dst.Write(compData, origLen, ptr, false);
            }

            if (reset)
            {
                origLen = newCompLen + 2;
            }
        }

        private void ImportRLE(ByteStream src)
        {
            Exists = true;
            Edited = true;

            // decompress
            width = src.Read8();
            height = src.Read8();

            ByteStream blockData = new ByteStream();
            Compress.DecompRLE(src, blockData);
            CopyIntoBlocks(blockData.Data);
        }

        public void WriteLZ77(ByteStream dst, bool shared, bool reset, bool export)
        {
            int length = tileTable.Length * 2;
            byte[] uncompTemp = new byte[length];
            Buffer.BlockCopy(tileTable, 0, uncompTemp, 0, length);
            ByteStream uncompData = new ByteStream(uncompTemp);

            // compress by LZ77
            ByteStream compData = new ByteStream();
            compData.Write32(size);
            int newCompLen = Compress.CompLZ77(uncompData, length, compData);

            // write data
            if (export)
            {
                dst.Write(compData);
            }
            else
            {
                int ptr = GetPointer();
                dst.Write(compData, origLen, ptr, shared);
            }

            if (reset)
            {
                origLen = newCompLen + 4;
            }
        }

        private void ImportLZ77(ByteStream src, bool shared)
        {
            Exists = true;

            // decompress
            size = (byte)src.Read32();
            ByteStream ttbData = new ByteStream();
            Compress.DecompLZ77(src, ttbData);

            tileTable = new ushort[ttbData.Length / 2];
            ttbData.CopyToArray(0, tileTable, 0, ttbData.Length);

            // write to rom
            WriteLZ77(romStream, shared, true, false);
        }


    }
}
