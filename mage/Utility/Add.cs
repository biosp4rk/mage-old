using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace mage
{
    public static class Add
    {
        // background
        public static int BlankBgRLE(byte width, byte height)
        {
            int size = width * height * 2;
            byte[] uncompData = new byte[size];
            ByteStream uncomp = new ByteStream(uncompData);

            ByteStream comp = new ByteStream();
            comp.Write8(width);
            comp.Write8(height);
            Compress.CompRLE(uncomp, size, comp);

            ByteStream romStream = ROM.Stream;
            int offset = romStream.AddData(comp);
            return offset;
        }

        public static int BgRleCopy(int offset)
        {
            ByteStream romStream = ROM.Stream;
            romStream.Seek(offset + 2);
            int length = Compress.DecompRLE(romStream, new ByteStream());

            byte[] compData = new byte[length + 2];
            romStream.CopyToArray(offset, compData, 0, compData.Length);
            ByteStream copy = new ByteStream(compData);
            int addr = romStream.AddData(copy);
            return addr;
        }

        public static int BlankBgLZ77()
        {
            int size = 0x800;
            byte[] uncompData = new byte[size];
            for (int i = 0; i < size; i += 2)
            {
                uncompData[i] = 0xFF;
                uncompData[i + 1] = 3;
            }
            ByteStream uncomp = new ByteStream(uncompData);

            ByteStream comp = new ByteStream();
            comp.Write32(0);
            Compress.CompLZ77(uncomp, size, comp);

            ByteStream romStream = ROM.Stream;
            int offset = romStream.AddData(comp);
            return offset;
        }

        // room sprites
        public static int BlankEnemySet()
        {
            byte[] blankSet = new byte[3] { 0xFF, 0xFF, 0xFF };
            ByteStream src = new ByteStream(blankSet);

            ByteStream romStream = ROM.Stream;
            int offset = romStream.AddData(src);
            return offset;
        }

        public static int EnemySetCopy(int offset)
        {
            ByteStream romStream = ROM.Stream;
            romStream.Seek(offset);
            ByteStream copy = new ByteStream();

            while (true)
            {
                byte yPos = romStream.Read8();
                byte xPos = romStream.Read8();
                byte prop = romStream.Read8();

                copy.Write8(yPos);
                copy.Write8(xPos);
                copy.Write8(prop);

                if (yPos == 0xFF && xPos == 0xFF && prop == 0xFF) { break; }
            }

            int addr = romStream.AddData(copy);
            return addr;
        }

        // room
        public static void BlankRoom(byte area, byte width, byte height)
        {
            // get list of headers
            ByteStream romStream = ROM.Stream;
            int areaHeadersPtr = Version.AreaHeaderOffset + area * 4;
            int areaHeadersOffset = romStream.ReadPtr(areaHeadersPtr);
            int numRooms = Version.RoomsPerArea[area];

            int origLen = numRooms * 0x3C;
            byte[] data = new byte[origLen];
            romStream.CopyToArray(areaHeadersOffset, data, 0, origLen);

            // get blank data
            int bg0offset = BlankBgRLE(width, height);
            int bg1offset = BlankBgRLE(width, height);
            int bg2offset = BlankBgRLE(width, height);
            int clipOffset = BlankBgRLE(width, height);
            int bg3offset = BlankBgLZ77();

            int enemy0offset = BlankEnemySet();
            int enemy1offset = BlankEnemySet();
            int enemy2offset = BlankEnemySet();

            // write new header
            ByteStream headers = new ByteStream(data);
            headers.Seek(origLen);
            headers.Write8(0);
            headers.Write8(0x10);
            headers.Write8(0x10);
            headers.Write8(0x10);
            headers.Write8(0x40);
            headers.WritePtr(bg0offset);
            headers.WritePtr(bg1offset);
            headers.WritePtr(bg2offset);
            headers.WritePtr(clipOffset);
            headers.WritePtr(bg3offset);
            headers.Write8(0);
            headers.Write8(0);

            headers.WritePtr(enemy0offset);
            headers.Write8(0);
            headers.Write8(0);
            headers.WritePtr(enemy1offset);
            headers.Write8(0);
            headers.Write8(0);
            headers.WritePtr(enemy2offset);
            headers.Write8(0);

            headers.Write8(0);
            headers.Write8(0);
            headers.Write8(0);
            headers.Write8(0xFF);
            headers.Write16(0);

            romStream.Write(headers, origLen, areaHeadersPtr, false);
            Version.RoomsPerArea[area]++;
            Version.UpdateProject();
        }

        public static void RoomCopy(byte area, byte copyArea, byte copyRoom)
        {
            // get list of headers
            ByteStream romStream = ROM.Stream;
            int areaHeadersPtr = Version.AreaHeaderOffset + area * 4;
            int areaHeadersOffset = romStream.ReadPtr(areaHeadersPtr);
            int numRooms = Version.RoomsPerArea[area];

            int origLen = numRooms * 0x3C;
            byte[] data = new byte[origLen];
            romStream.CopyToArray(areaHeadersOffset, data, 0, origLen);
            ByteStream headers = new ByteStream(data);

            // get copy data
            Header copy = new Header(romStream, copyArea, copyRoom);
            int bg0offset = copy.BG0ptr;
            if ((copy.BG0prop & 0x10) != 0) { bg0offset = Add.BgRleCopy(bg0offset); }
            int bg1offset = copy.BG1ptr;
            if ((copy.BG1prop & 0x10) != 0) { bg1offset = Add.BgRleCopy(bg1offset); }
            int bg2offset = copy.BG2ptr;
            if ((copy.BG2prop & 0x10) != 0) { bg2offset = Add.BgRleCopy(bg2offset); }
            int clipOffset = Add.BgRleCopy(copy.clipPtr);
            int bg3offset = copy.BG3ptr;

            int enemy0offset = Add.EnemySetCopy(copy.enemyList0ptr);
            int enemy1offset = copy.enemyList1ptr;
            if (copy.spriteset1event > 0) { enemy1offset = Add.EnemySetCopy(enemy1offset); }
            int enemy2offset = copy.enemyList2ptr;
            if (copy.spriteset2event > 0) { enemy2offset = Add.EnemySetCopy(enemy2offset); }

            // write new header
            headers.Seek(origLen);
            headers.Write8(copy.tileset);
            headers.Write8(copy.BG0prop);
            headers.Write8(copy.BG1prop);
            headers.Write8(copy.BG2prop);
            headers.Write8(copy.BG3prop);
            headers.WritePtr(bg0offset);
            headers.WritePtr(bg1offset);
            headers.WritePtr(bg2offset);
            headers.WritePtr(clipOffset);
            headers.WritePtr(bg3offset);
            headers.Write8(copy.BG3scroll);
            headers.Write8(copy.transparency);

            headers.WritePtr(enemy0offset);
            headers.Write8(copy.spriteset0);
            headers.Write8(copy.spriteset1event);
            headers.WritePtr(enemy1offset);
            headers.Write8(copy.spriteset1);
            headers.Write8(copy.spriteset2event);
            headers.WritePtr(enemy2offset);
            headers.Write8(copy.spriteset2);

            headers.Write8(copy.mapX);
            headers.Write8(copy.mapY);
            headers.Write8(copy.effect);
            headers.Write8(copy.effectY);
            headers.Write16(copy.music);

            romStream.Write(headers, origLen, areaHeadersPtr, false);
            Version.RoomsPerArea[area]++;
            Version.UpdateProject();
        }

        // tileset
        public static int BlankLZ77Gfx()
        {
            int size = 0x20;
            byte[] uncompData = new byte[size];
            ByteStream uncomp = new ByteStream(uncompData);

            ByteStream comp = new ByteStream();
            Compress.CompLZ77(uncomp, size, comp);

            ByteStream romStream = ROM.Stream;
            int offset = romStream.AddData(comp);
            return offset;
        }

        private static int LZ77GfxCopy(int offset)
        {
            ByteStream romStream = ROM.Stream;
            romStream.Seek(offset);
            int length = Compress.DecompLZ77(romStream, new ByteStream());

            byte[] compData = new byte[length];
            romStream.CopyToArray(offset, compData, 0, compData.Length);
            ByteStream copy = new ByteStream(compData);
            int addr = romStream.AddData(copy);
            return addr;
        }

        private static int BlankPalette(int rows)
        {
            ByteStream romStream = ROM.Stream;
            byte[] data = new byte[rows * 32];
            ByteStream blank = new ByteStream(data);
            int offset = romStream.AddData(blank);
            return offset;
        }

        private static int PaletteCopy(int offset, int rows)
        {
            ByteStream romStream = ROM.Stream;
            byte[] data = new byte[rows * 32];
            romStream.CopyToArray(offset, data, 0, data.Length);
            ByteStream copy = new ByteStream(data);
            int addr = romStream.AddData(copy);
            return addr;
        }

        public static int BlankTileTable()
        {
            int len = Version.GenericTileTable.Length;
            byte[] tileTable = new byte[len + 2];
            tileTable[0] = 2;
            tileTable[1] = (byte)(len / 0x80);
            Array.Copy(Version.GenericTileTable, 0, tileTable, 2, len);

            ByteStream ttb = new ByteStream(tileTable);
            ByteStream romStream = ROM.Stream;
            int offset = romStream.AddData(ttb);
            return offset;
        }

        private static int TileTableCopy(int offset)
        {
            // get length
            ByteStream romStream = ROM.Stream;
            byte rows = romStream.Read8(offset + 1);
            if (rows == 0)
            {
                rows = 0x40;
                StringReader sr = new StringReader(Version.TileTableLengths);
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] items = line.Split('=');
                    if (items.Length != 2) { continue; }

                    if (offset == Convert.ToInt32(items[0], 16))
                    {
                        rows = Convert.ToByte(items[1], 16);
                        break;
                    }
                }

                sr.Close();
            }
            int length = rows * 0x80 + 2;

            // copy data
            byte[] data = new byte[length];
            romStream.CopyToArray(offset, data, 0, length);
            data[1] = rows;
            ByteStream copy = new ByteStream(data);
            int addr = romStream.AddData(copy);
            return addr;
        }

        public static void BlankTileset()
        {
            // get list of tilesets
            ByteStream romStream = ROM.Stream;
            int tilesetOffset = Version.TilesetOffset;

            int origLen = Version.NumOfTilesets * 0x14;
            byte[] data = new byte[origLen];
            romStream.CopyToArray(tilesetOffset, data, 0, origLen);

            // get blank data
            int rleGfxOffset = Add.BlankLZ77Gfx();
            int paletteOffset = Add.BlankPalette(14);
            int lz77GfxOffset = Add.BlankLZ77Gfx();
            int ttbOffset = Add.BlankTileTable();

            // write new tileset
            ByteStream tilesets = new ByteStream(data);
            tilesets.Seek(origLen);
            tilesets.WritePtr(rleGfxOffset);
            tilesets.WritePtr(paletteOffset);
            tilesets.WritePtr(lz77GfxOffset);
            tilesets.WritePtr(ttbOffset);
            tilesets.Write8(0);
            tilesets.Write8(0);

            romStream.Write2(tilesets, origLen, ref tilesetOffset, true);
            Version.NumOfTilesets++;
            Version.UpdateProject();
        }

        public static void TilesetCopy(byte tsNum)
        {
            // get list of tilesets
            ByteStream romStream = ROM.Stream;
            int tilesetOffset = Version.TilesetOffset;
            int origLen = Version.NumOfTilesets * 0x14;
            byte[] data = new byte[origLen];
            romStream.CopyToArray(tilesetOffset, data, 0, origLen);

            // copy data
            int offset = Version.TilesetOffset + tsNum * 0x14;
            romStream.Seek(offset);

            int rleGfxOffset = romStream.ReadPtr();
            int paletteOffset = romStream.ReadPtr();
            int lz77GfxOffset = romStream.ReadPtr();
            int ttbOffset = romStream.ReadPtr();
            byte animTileset = romStream.Read8();
            byte animPalette = romStream.Read8();

            rleGfxOffset = Add.LZ77GfxCopy(rleGfxOffset);
            paletteOffset = Add.PaletteCopy(paletteOffset, 14);
            lz77GfxOffset = Add.LZ77GfxCopy(lz77GfxOffset);
            ttbOffset = Add.TileTableCopy(ttbOffset);

            // write new tileset
            ByteStream tilesets = new ByteStream(data);
            tilesets.Seek(origLen);
            tilesets.WritePtr(rleGfxOffset);
            tilesets.WritePtr(paletteOffset);
            tilesets.WritePtr(lz77GfxOffset);
            tilesets.WritePtr(ttbOffset);
            tilesets.Write8(animTileset);
            tilesets.Write8(animPalette);

            romStream.Write2(tilesets, origLen, ref tilesetOffset, true);
            Version.NumOfTilesets++;
            Version.UpdateProject();
        }

        // spriteset
        private static void AddSpriteset(ByteStream newData)
        {
            ByteStream romStream = ROM.Stream;
            int offset = romStream.AddData(newData);

            // get list of spriteset pointers
            int origLen = Version.NumOfSpritesets * 4;
            byte[] data = new byte[origLen];
            int spritesetOffset = Version.SpritesetOffset;
            romStream.CopyToArray(spritesetOffset, data, 0, origLen);

            // write new pointer
            ByteStream pointers = new ByteStream(data);
            pointers.Seek(origLen);
            pointers.WritePtr(offset);

            romStream.Write2(pointers, origLen, ref spritesetOffset, true);
            Version.NumOfSpritesets++;
            Version.UpdateProject();

            // fix code
            int codeOffset = -1;
            switch (Version.GameCode)
            {
                case "AMTE":
                    codeOffset = 0xF7C8;
                    break;
                case "BMXE":
                    codeOffset = 0xDFB0;
                    break;
            }

            byte limit = (byte)(Version.NumOfSpritesets - 1);
            romStream.Write8(codeOffset, limit);
            romStream.Write16(codeOffset + 4, 0xE003);
            romStream.Write8(codeOffset + 0xE, limit);
        }

        public static void BlankSpriteset()
        {
            ByteStream blank = new ByteStream();
            blank.Write16(0);
            AddSpriteset(blank);
        }

        public static void SpritesetCopy(byte ssNum)
        {
            ByteStream romStream = ROM.Stream;
            int offset = romStream.ReadPtr(Version.SpritesetOffset + ssNum * 4);
            romStream.Seek(offset);
            ByteStream copy = new ByteStream();

            while (true)
            {
                ushort val = romStream.Read16();
                copy.Write16(val);

                if (val == 0) { break; }
            }

            AddSpriteset(copy);
        }

        // animated tileset
        public static void BlankAnimTileset()
        {
            int origLen = Version.NumOfAnimTilesets * 0x30;
            byte[] data = new byte[origLen + 0x30];
            ByteStream romStream = ROM.Stream;
            int offset = Version.AnimTilesetOffset;
            romStream.CopyToArray(offset, data, 0, origLen);

            ByteStream tilesets = new ByteStream(data);
            romStream.Write2(tilesets, origLen, ref offset, true);
            Version.NumOfAnimTilesets++;
            Version.UpdateProject();
        }

        public static void AnimTilesetCopy(byte animTilesetNum)
        {
            int origLen = Version.NumOfAnimTilesets * 0x30;
            byte[] data = new byte[origLen + 0x30];
            int animTilesetOffset = Version.AnimTilesetOffset;

            ByteStream romStream = ROM.Stream;
            romStream.CopyToArray(animTilesetOffset, data, 0, origLen);
            int offset = animTilesetNum * 0x30;

            for (int i = 0; i < 0x30; i++)
            {
                data[origLen + i] = data[offset + i];
            }

            ByteStream tilesets = new ByteStream(data);
            romStream.Write2(tilesets, origLen, ref animTilesetOffset, true);
            Version.NumOfAnimTilesets++;
            Version.UpdateProject();
        }

        // animated graphics
        private static void AddAnimGfx(ByteStream newData)
        {
            // get list of animated gfx
            ByteStream romStream = ROM.Stream;
            int animGfxOffset = Version.AnimGfxOffset;
            int origLen = Version.NumOfAnimGfx * 8;
            byte[] temp = new byte[origLen + 8];
            romStream.CopyToArray(animGfxOffset, temp, 0, origLen);
            ByteStream animGfx = new ByteStream(temp);

            // write new data
            animGfx.Seek(origLen);
            for (int i = 0; i < newData.Length; i++)
            {
                byte val = newData.Read8(i);
                animGfx.Write8(val);
            }

            romStream.Write2(animGfx, origLen, ref animGfxOffset, true);
            Version.NumOfAnimGfx++;
            Version.UpdateProject();
        }

        private static int GfxCopy(int offset, int numTiles)
        {
            ByteStream romStream = ROM.Stream;
            byte[] temp = new byte[numTiles * 0x20];
            romStream.CopyToArray(offset, temp, 0, temp.Length);
            ByteStream gfx = new ByteStream(temp);
            int addr = romStream.AddData(gfx);
            return addr;
        }

        public static void BlankAnimGfx()
        {
            // get gfx
            ByteStream romStream = ROM.Stream;
            int offset = romStream.ReadPtr(Version.AnimGfxOffset + 4);
            int gfxPtr = GfxCopy(offset, 4);

            // write new data
            ByteStream blank = new ByteStream();
            blank.Write8(0);
            blank.Write8(0);
            blank.Write8(1);
            blank.WritePtr(gfxPtr);
            AddAnimGfx(blank);
        }

        public static void AnimGfxCopy(byte animGfxNum)
        {
            ByteStream romStream = ROM.Stream;
            int offset = Version.AnimGfxOffset + animGfxNum * 8;

            byte type = romStream.Read8(offset);
            byte delay = romStream.Read8(offset + 1);
            byte numStates = romStream.Read8(offset + 2);
            int gfxPtr = romStream.ReadPtr(offset + 4);
            gfxPtr = GfxCopy(gfxPtr, numStates * 4);

            ByteStream copy = new ByteStream();
            copy.Write8(type);
            copy.Write8(delay);
            copy.Write8(numStates);
            copy.WritePtr(gfxPtr);
            AddAnimGfx(copy);
        }

        // animated palette
        private static void AddAnimPalette(ByteStream newData)
        {
            // get list of animated palettes
            ByteStream romStream = ROM.Stream;
            int animPaletteOffset = Version.AnimPaletteOffset;
            int origLen = Version.NumOfAnimPalettes * 8;
            byte[] temp = new byte[origLen + 8];
            romStream.CopyToArray(animPaletteOffset, temp, 0, origLen);
            ByteStream animPalette = new ByteStream(temp);

            // write new data
            animPalette.Seek(origLen);
            for (int i = 0; i < newData.Length; i++)
            {
                byte val = newData.Read8(i);
                animPalette.Write8(val);
            }

            romStream.Write2(animPalette, origLen, ref animPaletteOffset, true);
            Version.NumOfAnimPalettes++;
            Version.UpdateProject();
        }

        public static void BlankAnimPalette()
        {
            // get palette
            int palettePtr = BlankPalette(1);

            // write new data
            ByteStream blank = new ByteStream();
            blank.Write8(0);
            blank.Write8(0);
            blank.Write8(1);
            blank.WritePtr(palettePtr);
            AddAnimPalette(blank);
        }

        public static void AnimPaletteCopy(byte animPaletteNum)
        {
            ByteStream romStream = ROM.Stream;
            int offset = Version.AnimPaletteOffset + animPaletteNum * 8;

            byte type = romStream.Read8(offset);
            byte delay = romStream.Read8(offset + 1);
            byte numStates = romStream.Read8(offset + 2);
            int palettePtr = romStream.ReadPtr(offset + 4);
            palettePtr = PaletteCopy(palettePtr, numStates);

            ByteStream copy = new ByteStream();
            copy.Write8(type);
            copy.Write8(delay);
            copy.Write8(numStates);
            copy.WritePtr(palettePtr);
            AddAnimPalette(copy);
        }

        // minimap
        public static int BlankMinimap()
        {
            int size = 0x800;
            byte[] uncompData = new byte[size];
            ushort tile;
            if (Version.IsMF) { tile = 0xA0; }
            else { tile = 0x140; }
            for (int i = 0; i < size; i += 2)
            {
                uncompData[i] = (byte)tile;
                uncompData[i + 1] = (byte)(tile >> 8);
            }
            ByteStream uncomp = new ByteStream(uncompData);

            ByteStream comp = new ByteStream();
            Compress.CompLZ77(uncomp, size, comp);

            ByteStream romStream = ROM.Stream;
            int offset = romStream.AddData(comp);
            return offset;
        }


    }
}
