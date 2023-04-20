using System;
using System.Collections.Generic;
using System.IO;

namespace mage
{
    public class Room
    {
        // properties
        public byte AreaID { get; private set; }
        public byte RoomID { get; private set; }
        public byte Width { get { return backgrounds.width; } }
        public byte Height { get { return backgrounds.height; } }

        public BG BG0 { get { return backgrounds.bg0; } }
        public BG BG1 { get { return backgrounds.bg1; } }
        public BG BG2 { get { return backgrounds.bg2; } }
        public BG BG3 { get { return backgrounds.bg3; } }
        public BG Clip { get { return backgrounds.clip; } }

        // fields
        public Header header;
        public Tileset tileset;
        public Spriteset[] spritesets;
        public EnemyList[] enemyLists;
        public EnemyList enemyList;
        public DoorList doorList;
        public ScrollList scrollList;

        public Backgrounds backgrounds;
        public VramBG vram;
        public VramObj vramObj;
        public UndoRedo undoRedo;

        // constructor
        public Room(int areaID, int roomID)
        {
            this.AreaID = (byte)areaID;
            this.RoomID = (byte)roomID;

            GetData();
        }

        private void GetData()
        {
            ByteStream romStream = ROM.Stream;

            // get header data
            header = new Header(romStream, AreaID, RoomID);

            // tileset
            tileset = new Tileset(romStream, header.tileset);
            vram = new VramBG(tileset, true);

            // get background data
            backgrounds = new Backgrounds(this);

            // spritesets and enemylists
            spritesets = new Spriteset[3];
            enemyLists = new EnemyList[3];
            spritesets[0] = ROM.LoadSpriteset(header.spriteset0);
            enemyLists[0] = ROM.LoadEnemyList(AreaID, RoomID, 0);
            if (header.spriteset1event > 0)
            {
                spritesets[1] = ROM.LoadSpriteset(header.spriteset1);
                enemyLists[1] = ROM.LoadEnemyList(AreaID, RoomID, 1);
            }
            if (header.spriteset2event > 0)
            {
                spritesets[2] = ROM.LoadSpriteset(header.spriteset2);
                enemyLists[2] = ROM.LoadEnemyList(AreaID, RoomID, 2);
            }

            vramObj = new VramObj(spritesets[0]);

            // default enemyList
            enemyList = enemyLists[0];

            // get door data
            doorList = new DoorList(this);

            // get scroll list
            scrollList = ROM.LoadScrollList(AreaID, RoomID);

            // get undo/redo stack
            undoRedo = ROM.LoadUndoRedo(AreaID, RoomID);
        }

        public bool IsEdited()
        {
            if (BG0.Edited) { return true; }
            if (BG1.Edited) { return true; }
            if (BG2.Edited) { return true; }
            if (BG3.Edited) { return true; }
            if (Clip.Edited) { return true; }
            if (enemyLists[0].Edited) { return true; }
            if (header.spriteset1event > 0 && enemyLists[1].Edited) { return true; }
            if (header.spriteset2event > 0 && enemyLists[2].Edited) { return true; }
            if (doorList.Edited) { return true; }
            if (scrollList.Edited) { return true; }

            return false;
        }

        public void SetEnemyList(int num)
        {
            enemyList = enemyLists[num];
        }

        public void SaveObjects()
        {
            // backgrounds
            if (BG0.Edited) { ROM.SaveBG(BG0); }
            if (BG1.Edited) { ROM.SaveBG(BG1); }
            if (BG2.Edited) { ROM.SaveBG(BG2); }
            if (BG3.Edited) { ROM.SaveBG(BG3); }
            if (Clip.Edited) { ROM.SaveBG(Clip); }

            // enemy lists
            if (enemyLists[0].Edited)
            {
                ROM.SaveEnemyList(enemyLists[0]);
            }
            if (header.spriteset1event > 0 && enemyLists[1].Edited)
            {
                ROM.SaveEnemyList(enemyLists[1]);
            }
            if (header.spriteset2event > 0 && enemyLists[2].Edited)
            {
                ROM.SaveEnemyList(enemyLists[2]);
            }

            // scroll list
            if (scrollList.Edited)
            {
                ROM.SaveScrollList(scrollList);
            }

            // undo/redo stack
            ROM.SaveUndoRedo(undoRedo, this);
        }

        public int GetHatchNumber(byte doorNum)
        {
            // get ordered array of doors
            Door[] doors = new Door[doorList.Count];
            int[] doorNums = new int[doorList.Count];
            for (int i = 0; i < doorList.Count; i++)
            {
                Door d = doorList[i];
                doors[i] = d;
                doorNums[i] = d.doorNum;
            }

            Array.Sort(doorNums, doors);

            if (Version.IsMF)
            {
                int closedNum = 0;
                int openNum = 5;

                foreach (Door d in doors)
                {
                    int type = d.type & 0xF;
                    if (type != 4) { continue; }

                    bool closed = IsHatchClipdata(d.xStart - 1, d.yStart) || IsHatchClipdata(d.xStart + 1, d.yStart);
                    if (closed)
                    {
                        if (d.doorNum == doorNum) { return closedNum; }
                        closedNum++;
                    }
                    else
                    {
                        if (d.doorNum == doorNum) { return openNum; }
                        openNum--;
                    }
                }
            }
            else
            {
                int number = 0;

                foreach (Door d in doors)
                {
                    int type = d.type & 0xF;
                    if (type != 3 && type != 4) { continue; }

                    if (d.doorNum == doorNum) { return number; }
                    number++;
                }
            }

            return -1;
        }

        private bool IsHatchClipdata(int x, int y)
        {
            if (x < 0 || x >= Width) { return false; }
            ushort clip = Clip.blocks[x, y];
            return (clip >= 0x30) && (clip <= 0x4E);
        }

        public void Export(string filename)
        {
            // file format:
            // 00 MAGE 1.4 ROOM
            // 10 Game# Area# Room#
            // 20 Room header, doors/scrolls pointers
            // 64 Data begins

            ByteStream romStream = ROM.Stream;
            ByteStream dst = new ByteStream();

            // write file info
            dst.WriteASCII("MAGE " + Program.ShortVersion + " ROOM");
            dst.Seek(0x10);
            dst.Write8(Convert.ToByte(!Version.IsMF));
            dst.Write8(AreaID);
            dst.Write8(RoomID);
            dst.Seek(0x64);

            // backgrounds
            int[] BGoffsets = backgrounds.Export(dst);

            // enemy data
            int enemyList0offset = dst.Position;
            enemyLists[0].Export(dst);

            int enemyList1offset = 0;
            if (header.spriteset1event > 0)
            {
                enemyList1offset = dst.Position;
                enemyLists[1].Export(dst);
            }

            int enemyList2offset = 0;
            if (header.spriteset2event > 0)
            {
                enemyList2offset = dst.Position;
                enemyLists[2].Export(dst);
            }

            // doors
            int doorListOffset = dst.Position;
            doorList.Export(dst);

            // scrolls
            int scrollListOffset = dst.Position;
            scrollList.Export(dst);

            // copy header
            int hOffset = romStream.ReadPtr(Version.AreaHeaderOffset + AreaID * 4) + (RoomID * 0x3C);
            dst.CopyFromArray(romStream.Data, hOffset, 0x20, 0x3C);

            // fix pointers
            dst.Seek(0x28);
            for (int i = 0; i < 5; i++)
            {
                dst.Write32(BGoffsets[i]);
            }

            dst.Seek(0x40);
            dst.Write32(enemyList0offset);  // enemy0
            dst.Seek(0x48);
            dst.Write32(enemyList1offset);  // enemy1
            dst.Seek(0x50);
            dst.Write32(enemyList2offset);  // enemy2

            dst.Seek(0x5C);
            dst.Write32(doorListOffset);    // doors
            dst.Write32(scrollListOffset);  // scrolls

            dst.Export(filename);
        }

        public void Import(ByteStream src, bool[] items, bool diffGame, bool convertClip, bool shared)
        {
            ByteStream romStream = ROM.Stream;
            int addr = romStream.ReadPtr(Version.AreaHeaderOffset + AreaID * 4) + (RoomID * 0x3C);
            int start = 0x20;

            if (!diffGame)
            {
                byte _mapX = src.Read8(start + 0x35);
                byte _mapY = src.Read8(start + 0x36);
                ushort _music = src.Read16(start + 0x3A);

                romStream.Write8(addr + 0x35, _mapX);
                romStream.Write8(addr + 0x36, _mapY);
                romStream.Write16(addr + 0x3A, _music);
            }

            // load BG data
            if (items[0])
            {
                src.Seek(start);
                byte _tileset = src.Read8();
                tileset = new Tileset(romStream, _tileset);

                byte _BG0comp = src.Read8();
                byte _BG1comp = src.Read8();
                byte _BG2comp = src.Read8();
                byte _BG3comp = src.Read8();   

                int _BG0offset = src.Read32();
                int _BG1offset = src.Read32();
                int _BG2offset = src.Read32();
                int _clipOffset = src.Read32();
                int _BG3offset = src.Read32();
                byte _BG3scroll = src.Read8();
                byte _trans = src.Read8();
                header.transparency = _trans;

                src.Seek(_BG0offset);
                BG0.ImportFromRoom(src, _BG0comp, shared);
                src.Seek(_BG1offset);
                BG1.ImportFromRoom(src, _BG1comp, shared);
                src.Seek(_BG2offset);
                BG2.ImportFromRoom(src, _BG2comp, shared);
                src.Seek(_BG3offset);
                BG3.ImportFromRoom(src, _BG3comp, shared);
                src.Seek(_clipOffset);
                Clip.ImportFromRoom(src, 0x10, shared);

                backgrounds.Import(convertClip);

                romStream.Write8(addr, _tileset);
                romStream.Write8(addr + 1, _BG0comp);
                romStream.Write8(addr + 2, _BG1comp);
                romStream.Write8(addr + 3, _BG2comp);
                romStream.Write8(addr + 4, _BG3comp);
                romStream.Write8(addr + 0x1C, _BG3scroll);
                romStream.Write8(addr + 0x1D, _trans);
            }

            // room sprites
            if (items[1])
            {
                src.Seek(start + 0x20);
                int _spritedata0offset = src.Read32();
                byte _spriteset0 = src.Read8();
                byte _spriteset1event = src.Read8();

                int _spritedata1offset = src.Read32();
                byte _spriteset1 = src.Read8();
                byte _spriteset2event = src.Read8();

                int _spritedata2offset = src.Read32();
                byte _spriteset2 = src.Read8();

                header.spriteset1event = _spriteset1event;
                header.spriteset2event = _spriteset2event;
                romStream.Write8(addr + 0x24, _spriteset0);
                romStream.Write8(addr + 0x25, _spriteset1event);
                romStream.Write8(addr + 0x2C, _spriteset1);
                romStream.Write8(addr + 0x2D, _spriteset2event);
                romStream.Write8(addr + 0x34, _spriteset2);

                // default spriteset
                spritesets[0] = ROM.LoadSpriteset(_spriteset0);
                src.Seek(_spritedata0offset);
                enemyLists[0].Import(src);

                // first spriteset
                if (header.spriteset1event > 0)
                {
                    spritesets[1] = ROM.LoadSpriteset(_spriteset1);
                    if (enemyLists[1] == null)
                    {
                        enemyLists[1] = new EnemyList(romStream, AreaID, RoomID, 1);
                    }
                    src.Seek(_spritedata1offset);
                    enemyLists[1].Import(src);
                }
                else
                {
                    spritesets[1] = null;
                    enemyLists[1] = null;
                }

                // second spriteset
                if (header.spriteset2event > 0)
                {
                    spritesets[2] = ROM.LoadSpriteset(_spriteset2);
                    if (enemyLists[2] == null)
                    {
                        enemyLists[2] = new EnemyList(romStream, AreaID, RoomID, 2);
                    }
                    src.Seek(_spritedata2offset);
                    enemyLists[2].Import(src);
                }
                else
                {
                    spritesets[2] = null;
                    enemyLists[2] = null;
                }
            }

            // get pointers
            src.Seek(0x5C);
            int doorListOffset = src.Read32();
            int scrollListOffset = src.Read32();

            // doors doors
            if (items[2])
            {
                src.Seek(doorListOffset);
                doorList.Import(src);
            }
            
            // scrolls
            if (items[3])
            {
                src.Seek(scrollListOffset);
                scrollList.Import(src);
            }

            // misc
            src.Seek(start + 0x37);
            byte _effect = src.Read8();
            byte _effectY = src.Read8();
            romStream.Write8(addr + 0x37, _effect);
            romStream.Write8(addr + 0x38, _effectY);

            // finalize
            if (items[0])
            {
                if (backgrounds.bg0.IsRLE)
                {
                    ROM.SaveBG(backgrounds.bg0);
                }
                if (backgrounds.bg1.IsRLE)
                {
                    ROM.SaveBG(backgrounds.bg1);
                }
                if (backgrounds.bg2.IsRLE)
                {
                    ROM.SaveBG(backgrounds.bg2);
                }
                ROM.SaveBG(backgrounds.clip);
            }
            if (items[1])
            {
                ROM.SaveEnemyList(enemyLists[0]);
                if (header.spriteset1event > 0)
                {
                    ROM.SaveEnemyList(enemyLists[1]);
                }
                if (header.spriteset2event > 0)
                {
                    ROM.SaveEnemyList(enemyLists[2]);
                }
            }
            if (items[2])
            {
                for (int i = 0; i < doorList.Count; i++)
                {
                    DoorData.ImportDoor(doorList[i]);
                }
            }
            if (items[3])
            {
                ROM.SaveScrollList(scrollList);
            }
        }

        public static void CheckValidSize(byte width, byte height)
        {
            if (width == 0 || height == 0)
            {
                //throw new ArgumentOutOfRangeException(null, "Width and height must be greater than 0.");
                throw new ArgumentOutOfRangeException(null, Properties.Resources.Room_Room_ZeroExceptionText);
            }
            if (width * height > 0x1800)
            {
                //throw new ArgumentOutOfRangeException(null, "Room is too large. Width times height must be less than 0x1800.");
                throw new ArgumentOutOfRangeException(null, Properties.Resources.Room_Room_LargeExceptionText);
            }
        }


    }
}
