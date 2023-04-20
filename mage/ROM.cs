using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace mage
{
    public static class ROM
    {
        // properties
        public static ByteStream Stream { get { return stream; } }

        // fields
        private static ByteStream stream;
        private const int size8mb = 0x800000;
        private const int size16mb = 0x1000000;
        private const int size32mb = 0x2000000;

        // TODO: move?
        public static Palette GenericBGpalette
        {
            get
            {
                int offset = Version.GenericBgPaletteOffset;
                if (useMotherShipHatches) { offset += 0x200; }
                Palette pal = new Palette(stream, offset, 3);
                pal.SetARGB(0, 0, 0);
                return pal;
            }
        }
        public static GFX GenericBGgfx
        {
            get
            {
                int offset = Version.GenericBgGfxOffset;
                if (useMotherShipHatches) { offset += 0x1000; }
                return new GFX(stream, offset, 32, 4);
            }
        }
        public static Palette GenericSpritePalette
        {
            get { return new Palette(stream, Version.GenericSpritePaletteOffset, 6); }
        }
        public static GFX GenericSpriteGfx
        {
            get { return new GFX(stream, Version.GenericSpriteGfxOffset, 32, 14); }
        }
        public static bool useAnimPalette = true;
        public static bool useMotherShipHatches = false;

        // lists of edited objects
        private static Dictionary<int, BG> editedBGs;                  // key = AreaID * 0x500 + RoomID * 5 + Layer
        private static Dictionary<int, Spriteset> editedSpritesets;    // key < 0xFF
        private static Dictionary<int, EnemyList> editedEnemyLists;    // key = AreaID * 0x300 + RoomID * 3 + Number
        private static Dictionary<int, ScrollList> editedScrollLists;  // key = AreaID * 0x100 + RoomID
        private static Dictionary<int, Minimap> editedMinimaps;        // key = AreaID
        private static Dictionary<int, Demo> editedDemos;              // key < 0xFF
        private static Dictionary<int, UndoRedo> undoRedoStacks;       // key = AreaID * 0x100 + RoomID

        #region get and set methods

        public static BG LoadBG(byte areaID, byte roomID, Layer layer)
        {
            int key = areaID * 0x500 + roomID * 5 + (int)layer;
            if (editedBGs.ContainsKey(key))
            {
                return editedBGs[key];
            }
            return new BG(stream, areaID, roomID, layer);
        }
        public static void SaveBG(BG bg)
        {
            bg.Edited = false;
            int key = bg.AreaID * 0x500 + bg.RoomID * 5 + (int)bg.layer;
            editedBGs[key] = bg;
        }

        public static Spriteset LoadSpriteset(byte ss)
        {
            if (editedSpritesets.ContainsKey(ss))
            {
                return editedSpritesets[ss];
            }
            return new Spriteset(stream, ss);
        }
        public static void SaveSpriteset(Spriteset ss)
        {
            editedSpritesets[ss.number] = ss;
        }

        public static EnemyList LoadEnemyList(byte areaID, byte roomID, int number)
        {
            int key = areaID * 0x300 + roomID * 3 + number;
            if (editedEnemyLists.ContainsKey(key))
            {
                return editedEnemyLists[key];
            }
            return new EnemyList(stream, areaID, roomID, number);
        }
        public static void SaveEnemyList(EnemyList el)
        {
            el.Edited = false;
            int key = el.AreaID * 0x300 + el.RoomID * 3 + el.number;
            editedEnemyLists[key] = el;
        }

        public static ScrollList LoadScrollList(byte areaID, byte roomID)
        {
            int key = areaID * 0x100 + roomID;
            if (editedScrollLists.ContainsKey(key))
            {
                return editedScrollLists[key];
            }
            return new ScrollList(areaID, roomID);
        }
        public static void SaveScrollList(ScrollList sl)
        {
            sl.Edited = false;
            int key = sl.AreaID * 0x100 + sl.RoomID;
            editedScrollLists[key] = sl;
        }
        public static List<ScrollList> GetAreaScrollLists(byte areaID)
        {
            List<ScrollList> areaScrollLists = new List<ScrollList>();
            foreach (ScrollList sl in editedScrollLists.Values)
            {
                if (sl.AreaID == areaID) { areaScrollLists.Add(sl); }
            }
            return areaScrollLists;
        }

        public static Minimap LoadMinimap(byte areaID)
        {
            if (editedMinimaps.ContainsKey(areaID))
            {
                return editedMinimaps[areaID];
            }
            return new Minimap(stream, areaID);
        }
        public static void SaveMinimap(Minimap mm)
        {
            mm.Edited = false;
            if (editedMinimaps.ContainsKey(mm.areaID))
            {
                editedMinimaps[mm.areaID] = mm;
            }
            else { editedMinimaps.Add(mm.areaID, mm); }
        }

        public static Demo LoadDemo(byte demo)
        {
            if (editedDemos.ContainsKey(demo))
            {
                return editedDemos[demo];
            }
            return new Demo(stream, demo);
        }
        public static void SaveDemo(Demo demo)
        {
            editedDemos[demo.number] = demo;
        }

        public static UndoRedo LoadUndoRedo(byte areaID, byte roomID)
        {
            int key = areaID * 0x100 + roomID;
            if (undoRedoStacks.ContainsKey(key))
            {
                return undoRedoStacks[key];
            }
            return new UndoRedo();
        }
        public static void SaveUndoRedo(UndoRedo ur, Room room)
        {
            int key = room.AreaID * 0x100 + room.RoomID;
            if (undoRedoStacks.ContainsKey(key))
            {
                undoRedoStacks[key] = ur;
            }
            else { undoRedoStacks.Add(key, ur); }
        }

        #endregion

        public static void Initialize(byte[] file)
        {
            // check rom size
            int size = file.Length;
            if (size <= size8mb)
            {
                SetRomSize(file, size8mb);
            }
            else if (size <= size16mb)
            {
                SetRomSize(file, size16mb);
            }
            else if (size <= size32mb)
            {
                SetRomSize(file, size32mb);
            }

            // set version
            Version.Initialize();

            // load doors
            DoorData.GetData();
        }

        private static void SetRomSize(byte[] file, int properSize)
        {
            int size = file.Length;

            if (size == properSize)
            {
                stream = new ByteStream(file);
            }
            else
            {
                byte[] temp = new byte[properSize];
                Array.Copy(file, temp, size);

                for (int i = size; i < properSize; i++)
                {
                    temp[i] = 0xFF;
                }

                stream = new ByteStream(temp);
            }
        }

        public static bool CheckROM(byte[] file, out string result)
        {
            // check rom length
            if (file.Length > size32mb)
            {
                //result = "ROM is larger than 32 MB.";
                result = Properties.Resources.ROM_CheckROM_TooLargeText;
                return false;
            }

            // check game code
            byte[] array = new byte[4];
            Array.Copy(file, 0xAC, array, 0, 4);
            result = Encoding.ASCII.GetString(array);
            if (!Version.IsValid(result))
            {
                //result = "File is not a valid ROM.";
                result = Properties.Resources.ROM_CheckROM_NotValidText;
                return false;
            }

            return true;
        }

        public static byte[] BackupData()
        {
            byte[] backup = new byte[stream.Data.Length];
            Array.Copy(stream.Data, backup, backup.Length);
            return backup;
        }

        // TODO: resize if necessary
        public static void RestoreData(byte[] backup)
        {
            Array.Copy(backup, stream.Data, backup.Length);
        }

        public static void SaveROM(string filename, bool reset)
        {
            foreach (BG bg in editedBGs.Values)
            {
                if (bg.IsRLE) { bg.WriteRLE(stream, reset, false); }
                else if (bg.IsLZ77) { bg.WriteLZ77(stream, false, reset, false); }
            }

            foreach (Spriteset ss in editedSpritesets.Values) { ss.Write(stream, reset, false); }

            foreach (EnemyList el in editedEnemyLists.Values) { el.Write(stream, reset); }

            DoorData.Write();

            ScrollList.Write();

            foreach (Minimap mm in editedMinimaps.Values) { mm.Write(stream, reset, false); }

            foreach (Demo demo in editedDemos.Values) { demo.Write(stream, reset); }

            stream.Export(filename);

            if (reset) { ResetEditedLists(); }
        }

        public static bool IsEdited()
        {
            if (editedBGs.Count > 0) { return true; }
            if (editedSpritesets.Count > 0) { return true; }
            if (editedEnemyLists.Count > 0) { return true; }
            if (DoorData.IsEdited()) { return true; }
            if (editedScrollLists.Count > 0) { return true; }
            if (editedMinimaps.Count > 0) { return true; }

            return false;
        }

        public static void ResetEditedLists()
        {
            editedBGs = new Dictionary<int, BG>();
            editedSpritesets = new Dictionary<int, Spriteset>();
            editedEnemyLists = new Dictionary<int, EnemyList>();
            DoorData.ResetEdited();
            editedScrollLists = new Dictionary<int, ScrollList>();
            editedMinimaps = new Dictionary<int, Minimap>();
            editedDemos = new Dictionary<int, Demo>();
            undoRedoStacks = new Dictionary<int, UndoRedo>();
        }


    }
}
