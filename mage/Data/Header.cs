using System;

namespace mage
{
    public enum HeaderData
    {
        Tileset, BG0prop, BG1prop, BG2prop, BG3prop,
        BG0ptr, BG1ptr, BG2ptr, BG3ptr, ClipPtr, EnemyList0ptr, EnemyList1ptr, EnemyList2ptr
    }

    public class Header
    {
        // fields
        public byte tileset;
        public byte BG0prop, BG1prop, BG2prop, BG3prop;
        public int BG0ptr, BG1ptr, BG2ptr, BG3ptr, clipPtr;
        public byte BG3scroll;
        public byte transparency;
        public int enemyList0ptr, enemyList1ptr, enemyList2ptr;
        public byte spriteset0, spriteset1, spriteset2;
        public byte spriteset1event, spriteset2event;
        public byte mapX, mapY;
        public byte effect, effectY;
        public ushort music;

        public byte areaID;
        public byte roomID;

        // constructor
        public Header(ByteStream bs, byte areaID, byte roomID)
        {
            this.areaID = areaID;
            this.roomID = roomID;

            GetHeaderData(bs);
        }

        private void GetHeaderData(ByteStream bs)
        {
            int addr = bs.ReadPtr(Version.AreaHeaderOffset + areaID * 4) + (roomID * 0x3C);
            bs.Seek(addr);

            tileset = bs.Read8();
            BG0prop = bs.Read8();
            BG1prop = bs.Read8();
            BG2prop = bs.Read8();
            BG3prop = bs.Read8();
            BG0ptr = bs.ReadPtr();
            BG1ptr = bs.ReadPtr();
            BG2ptr = bs.ReadPtr();
            clipPtr = bs.ReadPtr();
            BG3ptr = bs.ReadPtr();
            BG3scroll = bs.Read8();
            transparency = bs.Read8();

            enemyList0ptr = bs.ReadPtr();
            spriteset0 = bs.Read8();
            spriteset1event = bs.Read8();
            enemyList1ptr = bs.ReadPtr();
            spriteset1 = bs.Read8();
            spriteset2event = bs.Read8();
            enemyList2ptr = bs.ReadPtr();
            spriteset2 = bs.Read8();

            mapX = bs.Read8();
            mapY = bs.Read8();
            effect = bs.Read8();
            effectY = bs.Read8();
            music = bs.Read16();
        }

        public static int GetValue(int a, int r, HeaderData data)
        {
            ByteStream romStream = ROM.Stream;
            int offset = romStream.ReadPtr(Version.AreaHeaderOffset + a * 4) + (r * 0x3C);
            switch (data)
            {
                case HeaderData.Tileset:
                    return romStream.Read8(offset);
                case HeaderData.BG0prop:
                    return romStream.Read8(offset + 1);
                case HeaderData.BG1prop:
                    return romStream.Read8(offset + 2);
                case HeaderData.BG2prop:
                    return romStream.Read8(offset + 3);
                case HeaderData.BG3prop:
                    return romStream.Read8(offset + 4);
                case HeaderData.BG0ptr:
                    return romStream.ReadPtr(offset + 8);
                case HeaderData.BG1ptr:
                    return romStream.ReadPtr(offset + 0xC);
                case HeaderData.BG2ptr:
                    return romStream.ReadPtr(offset + 0x10);
                case HeaderData.BG3ptr:
                    return romStream.ReadPtr(offset + 0x18);
                case HeaderData.ClipPtr:
                    return romStream.ReadPtr(offset + 0x14);
                case HeaderData.EnemyList0ptr:
                    return romStream.ReadPtr(offset + 0x20);
                case HeaderData.EnemyList1ptr:
                    return romStream.ReadPtr(offset + 0x28);
                case HeaderData.EnemyList2ptr:
                    return romStream.ReadPtr(offset + 0x30);
                default:
                    return 0;
            }
        }

        public static void SetValue(int a, int r, HeaderData data, int val)
        {
            ByteStream romStream = ROM.Stream;
            int offset = romStream.ReadPtr(Version.AreaHeaderOffset + a * 4) + (r * 0x3C);
            switch (data)
            {
                case HeaderData.Tileset:
                    romStream.Write8(offset, (byte)val);
                    break;
                case HeaderData.BG0prop:
                    romStream.Write8(offset + 1, (byte)val);
                    break;
                case HeaderData.BG1prop:
                    romStream.Write8(offset + 2, (byte)val);
                    break;
                case HeaderData.BG2prop:
                    romStream.Write8(offset + 3, (byte)val);
                    break;
                case HeaderData.BG3prop:
                    romStream.Write8(offset + 4, (byte)val);
                    break;
                case HeaderData.BG0ptr:
                    romStream.WritePtr(offset + 8, val);
                    break;
                case HeaderData.BG1ptr:
                    romStream.WritePtr(offset + 0xC, val);
                    break;
                case HeaderData.BG2ptr:
                    romStream.WritePtr(offset + 0x10, val);
                    break;
                case HeaderData.BG3ptr:
                    romStream.WritePtr(offset + 0x18, val);
                    break;
                case HeaderData.ClipPtr:
                    romStream.WritePtr(offset + 0x14, val);
                    break;
                case HeaderData.EnemyList0ptr:
                    romStream.WritePtr(offset + 0x20, val);
                    break;
                case HeaderData.EnemyList1ptr:
                    romStream.WritePtr(offset + 0x28, val);
                    break;
                case HeaderData.EnemyList2ptr:
                    romStream.WritePtr(offset + 0x30, val);
                    break;
            }
        }

        public static int GetBgPointer(int a, int r, int bg)
        {
            ByteStream romStream = ROM.Stream;
            int offset = romStream.ReadPtr(Version.AreaHeaderOffset + a * 4) + (r * 0x3C);
            switch (bg)
            {
                case 0:
                    return offset + 8;
                case 1:
                    return offset + 0xC;
                case 2:
                    return offset + 0x10;
                case 3:
                    return offset + 0x18;
                case 4:  // clipdata
                    return offset + 0x14;
                default:
                    throw new ArgumentException();
            }
        }

        public static byte FixBgProp(int a, int r, int bg, bool rle)
        {
            // return if clipdata
            if (bg == 4) { return 0x10; }

            ByteStream romStream = ROM.Stream;
            int offset = romStream.ReadPtr(Version.AreaHeaderOffset + a * 4) + (r * 0x3C);
            offset += 1 + bg;

            byte prop;
            if (rle) { prop = 0x10; }
            else { prop = 0x40; }
            byte prevProp = romStream.Read8(offset);
            if ((prop & prevProp) == 0)
            {
                romStream.Write8(offset, prop);
                return prop;
            }
            return prevProp;
        }


    }
}
