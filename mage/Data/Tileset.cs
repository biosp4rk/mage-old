using System;
using System.Collections.Generic;
using System.IO;

namespace mage
{
    public class Tileset
    {
        // data
        public GFX RLEgfx;
        public Palette palette;
        public GFX LZ77gfx;
        public ushort[] tileTable;
        public AnimTileset animTileset;
        public AnimPalette animPalette;

        public byte number;
        public int addr;

        // constructor
        public Tileset(ByteStream bs, byte tilesetNum)
        {
            this.number = tilesetNum;
            this.addr = Version.TilesetOffset + tilesetNum * 0x14;

            GetRLEgfx(bs);
            GetBGpalette(bs);
            GetLZ77gfx(bs);
            GetTileTable(bs);
            GetAnimTileset(bs);
            GetAnimPalette(bs);
        }

        private void GetRLEgfx(ByteStream bs)
        {
            try
            {
                int RLEgfxOffset = bs.ReadPtr(addr);
                RLEgfx = new GFX(bs, RLEgfxOffset);
            }
            catch { throw new CorruptDataException(Corrupt.RLEgfx); }
        }

        private void GetBGpalette(ByteStream bs)
        {
            int paletteOffset = bs.ReadPtr(addr + 4);
            palette = new Palette(bs, paletteOffset, 14);
        }

        private void GetLZ77gfx(ByteStream bs)
        {
            try
            {
                int LZ77gfxOffset = bs.ReadPtr(addr + 8);
                LZ77gfx = new GFX(bs, LZ77gfxOffset);
            }
            catch { throw new CorruptDataException(Corrupt.LZ77gfx); }
        }

        private void GetTileTable(ByteStream bs)
        {
            // get length of tile table
            int ttbOffset = bs.ReadPtr(addr + 0xC);
            byte rows = bs.Read8(ttbOffset + 1);
            if (rows == 0)
            {
                rows = 0x40;
                StringReader sr = new StringReader(Version.TileTableLengths);
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] items = line.Split('=');
                    if (items.Length != 2) { continue; }

                    if (ttbOffset == Convert.ToInt32(items[0], 16))
                    {
                        rows = Convert.ToByte(items[1], 16);
                        break;
                    }
                }

                sr.Close();
            }

            // copy tile table
            ttbOffset += 2;
            tileTable = new ushort[rows * 0x40];
            bs.CopyToArray(ttbOffset, tileTable, 0, rows * 0x80);
        }

        private void GetAnimTileset(ByteStream bs)
        {
            byte animTilesetNum = bs.Read8(addr + 0x10);
            animTileset = new AnimTileset(bs, animTilesetNum);
        }

        private void GetAnimPalette(ByteStream bs)
        {
            byte animPalNum = bs.Read8(addr + 0x11);
            animPalette = new AnimPalette(bs, animPalNum);
        }

        public void Export(string filename)
        {
            // file format:
            // 00 MAGE 1.4 TILE
            // 10 Game# Tileset#
            // 20 Tileset header
            // 34 Data begins

            ByteStream dst = new ByteStream();
            byte[] romData = ROM.Stream.Data;

            // write file info
            dst.WriteASCII("MAGE " + Program.ShortVersion + " TILE");
            dst.Seek(0x10);
            dst.Write8(Convert.ToByte(!Version.IsMF));
            dst.Write8(number);
            dst.Seek(0x34);

            // level GFX
            int levelGfxOffset = dst.Position;
            RLEgfx.Write(dst, true);
            dst.Align(2);

            // palette
            int paletteOffset = dst.Position;
            palette.Write(dst, paletteOffset);
            dst.Align(4);

            // BG3 GFX
            int BG3gfxOffset = dst.Position;
            LZ77gfx.Write(dst, true);
            dst.Align(2);

            // tile table
            int tileTableOffset = dst.Position;
            byte rows = (byte)(tileTable.Length / 0x40);
            dst.Write8(2);
            dst.Write8(rows);
            foreach (ushort tile in tileTable)
            {
                dst.Write16(tile);
            }    

            // write tileset header
            dst.Seek(0x20);
            dst.Write32(levelGfxOffset);
            dst.Write32(paletteOffset);
            dst.Write32(BG3gfxOffset);
            dst.Write32(tileTableOffset);
            dst.Write8(animTileset.number);
            dst.Write8(animPalette.number);

            dst.Export(filename);
        }

        public void Import(ByteStream src, bool useGenTtb, bool shared)
        {
            src.Seek(0x20);
            int levelGfxOffset = src.Read32();
            int paletteOffset = src.Read32();
            int BG3gfxOffset = src.Read32();
            int tileTableOffset = src.Read32();
            byte animTileNum = src.Read8();
            byte animPalNum = src.Read8();

            ByteStream romStream = ROM.Stream;

            // level GFX
            byte[] data = new byte[paletteOffset - levelGfxOffset];
            src.CopyToArray(levelGfxOffset, data, 0, data.Length);
            romStream.Write(new ByteStream(data), RLEgfx.origLen, addr, shared);

            // palette
            data = new byte[0x1C0];
            src.CopyToArray(paletteOffset, data, 0, 0x1C0);
            romStream.Write(new ByteStream(data), 0x1C0, addr + 4, shared);

            // BG3 GFX
            data = new byte[tileTableOffset - BG3gfxOffset];
            src.CopyToArray(BG3gfxOffset, data, 0, data.Length);
            romStream.Write(new ByteStream(data), LZ77gfx.origLen, addr + 8, shared);

            // tile table
            int rows = src.Read8(tileTableOffset + 1);
            int length = 2 + rows * 0x80;
            data = new byte[length];
            src.CopyToArray(tileTableOffset, data, 0, data.Length);
            // check if tile parts should be replaced
            if (useGenTtb)
            {
                byte[] genTtb = Version.GenericTileTable;
                Array.Copy(genTtb, 0, data, 2, genTtb.Length);
            }
            romStream.Write(new ByteStream(data), 2 + tileTable.Length * 2, addr + 0xC, shared);

            // animated tiles
            romStream.Write8(addr + 0x10, animTileNum);

            // animated palette
            romStream.Write8(addr + 0x11, animPalNum);
        }


    }
}
