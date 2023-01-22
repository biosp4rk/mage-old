using mage.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

namespace mage
{
    public static class Version
    {
        public static string GameCode { get; private set; }
        private static ByteStream romStream;

        // project related
        private enum ProjectState { None, New, Exists }
        private static ProjectState project;
        private static string VersionCreated { get; set; }
        private static DateTime DateCreated { get; set; }
        private static string VersionModified { get; set; }
        private static DateTime DateModified { get; set; }

        public static void LoadProject(string filename)
        {
            project = ProjectState.None;
            string path = Path.ChangeExtension(filename, ".proj");
            if (!File.Exists(path)) { return; }

            try
            {
                StreamReader sr = new StreamReader(path);
                string line;

                // check gamecode
                bool found = false;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("GameCode="))
                    {
                        string code = line.Substring(9, 4);
                        if (code != GameCode) { return; }
                        found = true;
                        break;
                    }
                }
                if (!found) { return; }

                // get constants
                while ((line = sr.ReadLine()) != null)
                {
                    string[] items = line.Split('=');
                    if (items.Length < 2) { continue; }
                    Parse(items[0], items[1]);
                }

                sr.Close();
            }
            catch { return; }

            project = ProjectState.Exists;
        }

        public static void UpdateProject()
        {
            if (project == ProjectState.None)
            {
                project = ProjectState.New;
            }
        }

        public static bool SaveProject(string filename)
        {
            if (project == ProjectState.None) { return false; }

            VersionModified = Program.Version;
            DateModified = DateTime.Now;

            bool newProject = false;
            if (project == ProjectState.New)
            {
                VersionCreated = VersionModified;
                DateCreated = DateModified;
                newProject = true;
            }

            filename = Path.ChangeExtension(filename, ".proj");
            StreamWriter sw = new StreamWriter(filename);

            // meta data
            sw.WriteLine("[Meta]");
            sw.WriteLine("GameCode=" + GameCode);
            sw.WriteLine("VersionCreated=" + VersionCreated);
            sw.WriteLine("DateCreated=" + DateCreated.ToString("s"));
            sw.WriteLine("VersionModified=" + VersionModified);
            sw.WriteLine("DateModified=" + DateModified.ToString("s"));
            sw.WriteLine();

            // project data
            sw.WriteLine("[Project]");
            string line = "RoomsPerArea=";
            foreach (int n in RoomsPerArea)
            {
                line += Convert.ToString(n, 16).ToUpper() + ",";
            }
            line = line.TrimEnd(',');
            sw.WriteLine(line);
            sw.WriteLine("NumOfTilesets=" + Convert.ToString(NumOfTilesets, 16).ToUpper());
            sw.WriteLine("NumOfAnimTilesets=" + Convert.ToString(NumOfAnimTilesets, 16).ToUpper());
            sw.WriteLine("NumOfAnimGfx=" + Convert.ToString(NumOfAnimGfx, 16).ToUpper());
            sw.WriteLine("NumOfAnimPalettes=" + Convert.ToString(NumOfAnimPalettes, 16).ToUpper());
            sw.WriteLine("NumOfSpritesets=" + Convert.ToString(NumOfSpritesets, 16).ToUpper());

            sw.Close();
            project = ProjectState.Exists;
            return newProject;
        }

        #region game specific (public)
        public static bool IsMF { get; private set; }
        public static string[] AreaNames { get; private set; }
        public static byte[] RoomsPerArea { get; private set; }
        public static byte NumOfTilesets { get; set; }
        public static byte NumOfAnimTilesets { get; set; }
        public static byte NumOfAnimGfx { get; set; }
        public static byte NumOfAnimPalettes { get; set; }
        public static byte NumOfSprites1 { get; private set; }
        public static byte NumOfSprites2 { get; private set; }
        public static byte NumOfSpritesets { get; set; }
        public static byte NumOfMinimaps { get; private set; }
        public static byte NumOfDemos { get; private set; }
        public static int MetroidOffset { get; private set; }

        public static string[] Clipdata
        {
            get
            {
                string clip;
                if (IsMF) { clip = Resources.MF_clipdata; }
                else { clip = Resources.ZM_clipdata; }
                return clip.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
        public static string[] ConvertClipdata
        {
            get
            {
                string clip;
                if (IsMF) { clip = Resources.MF_clipFromZM; }
                else { clip = Resources.ZM_clipFromMF; }
                return clip.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
        public static string[] CharacterList
        {
            get
            {
                string chars;
                if (IsMF) { chars = Resources.MF_chars; }
                else { chars = Resources.ZM_chars; }
                return chars.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
        public static string TileTableLengths
        {
            get
            {
                if (IsMF) { return Resources.MF_U_tileTables; }
                else { return Resources.ZM_U_tileTables; }
            }
        }
        public static byte[] GenericTileTable
        {
            get
            {
                if (IsMF) { return Resources.MF_genTileTable; }
                else { return Resources.ZM_genTileTable; }
            }
        }
        #endregion

        #region region specific (public)
        public static int AreaHeaderOffset { get { return romStream.ReadPtr(AreaHeaderPtr); } }
        public static int TilesetOffset { get { return romStream.ReadPtr(TilesetPtr); } }
        public static int AnimTilesetOffset { get { return romStream.ReadPtr(AnimTilesetPtr); } }
        public static int AnimGfxOffset { get { return romStream.ReadPtr(AnimGfxPtr); } }
        public static int TankGfxOffset { get; private set; }
        public static int AnimPaletteOffset { get { return romStream.ReadPtr(AnimPalettePtr); } }
        public static int GenericBgGfxOffset { get; private set; }
        public static int GenericBgPaletteOffset { get; private set; }
        public static int GenericSpriteGfxOffset { get; private set; }
        public static int GenericSpritePaletteOffset { get; private set; }
        public static int SpriteGfxRowsOffset { get { return romStream.ReadPtr(SpriteGfxRowsPtr); } }
        public static int SpriteGfxOffset { get { return romStream.ReadPtr(SpriteGfxPtr); } }
        public static int SpritePaletteOffset { get { return romStream.ReadPtr(SpritePalettePtr); } }
        public static int SpriteStats1Offset { get { return romStream.ReadPtr(SpriteStats1Ptr); } }
        public static int SpriteStats2Offset { get { return romStream.ReadPtr(SpriteStats2Ptr); } }
        public static int SpriteAI1Offset { get { return romStream.ReadPtr(SpriteAI1Ptr); } }
        public static int SpriteAI2Offset { get { return romStream.ReadPtr(SpriteAI2Ptr); } }
        public static int SpritesetOffset { get { return romStream.ReadPtr(SpritesetPtr); } }
        public static int DoorsOffset { get { return romStream.ReadPtr(DoorsPtr); } }
        public static int AreaConnectionsOffset { get { return romStream.ReadPtr(AreaConnectionsPtr); } }
        public static int DoorEventsOffset { get { return romStream.ReadPtr(DoorEventsPtr); } }
        public static byte NumOfDoorEvents
        {
            get { return romStream.Read8(NumOfDoorEventsOffset); }
            set { romStream.Write8(NumOfDoorEventsOffset, value); }
        }
        public static int LocationNamesOffset { get { return romStream.ReadPtr(LocationNamesPtr); } }
        public static int HatchLockEventsOffset { get { return romStream.ReadPtr(HatchLockEventsPtr); } }
        public static int NumOfHatchLockEventsOffset { get; set; }
        public static byte NumOfHatchLockEvents
        {
            get { return (byte)(romStream.Read8(NumOfHatchLockEventsOffset) + 1); }
            set { romStream.Write8(NumOfHatchLockEventsOffset, (byte)(value - 1)); }
        }
        public static int ScrollsOffset { get { return romStream.ReadPtr(ScrollsPtr); } }
        public static int ClipdataTypeOffset { get { return romStream.ReadPtr(ClipdataTypePtr); } }
        public static int MinimapGfxOffset { get { return romStream.ReadPtr(MinimapGfxPtr); } }
        public static int MinimapPaletteOffset { get; private set; }
        public static int MinimapDataOffset { get { return romStream.ReadPtr(MinimapDataPtr); } }
        public static int TextGfxOffset { get { return romStream.ReadPtr(TextGfxPtr); } }
        public static int TextPaletteOffset { get; private set; }
        public static int CharacterWidthsOffset { get { return romStream.ReadPtr(CharacterWidthsPtr); } }
        public static string[] Languages { get; private set; }
        public static int DemoInputOffset { get { return romStream.ReadPtr(DemoInputPtr); } }
        public static int DemoRamOffset { get { return romStream.ReadPtr(DemoRamPtr); } }

        public static Dictionary<byte, int> PSpriteOAM { get; private set; }
        public static Dictionary<byte, Point> SpritePositions { get; private set; }
        public static Dictionary<byte, byte> SSpriteOwner { get; private set; }
        public static Dictionary<byte, int> SSpriteOAM { get; private set; }
        public static string WeaponData
        {
            get
            {
                switch (GameCode)
                {
                    case "AMTE":
                        return Resources.MF_U_weapons;
                    case "BMXE":
                        return Resources.ZM_U_weapons;
                    default:
                        return null;
                }
            }
        }
        public static Patch TestRoom
        {
            get
            {
                switch (GameCode)
                {
                    case "AMTE":
                        return new Patch(Resources.MF_U_testRoom);
                    case "BMXE":
                        return new Patch(Resources.ZM_U_testRoom);
                    default:
                        return null;
                }
            }
        }
        public static Patch TestDemo
        {
            get
            {
                switch (GameCode)
                {
                    case "AMTE":
                        return new Patch(Resources.MF_U_testDemo);
                    case "BMXE":
                        return new Patch(Resources.ZM_U_testDemo);
                    default:
                        return null;
                }
            }
        }
        public static Patch DoorEventCode
        {
            get
            {
                switch (GameCode)
                {
                    case "AMTE":
                        return new Patch(Resources.MF_U_eventConnections);
                    case "BMXE":
                        return new Patch(Resources.ZM_U_eventConnections);
                    default:
                        return null;
                }
            }
        }
        public static Patch LocationNameCode
        {
            get
            {
                switch (GameCode)
                {
                    case "AMTE":
                        return new Patch(Resources.MF_U_locationNames);
                    case "BMXE":
                        return new Patch(Resources.ZM_U_locationNames);
                    default:
                        return null;
                }
            }
        }
        public static string DemoRam
        {
            get
            {
                switch (GameCode)
                {
                    case "AMTE":
                        return Resources.MF_U_demoRAM;
                    case "BMXE":
                        return Resources.ZM_U_demoRAM;
                    default:
                        return null;
                }
            }
        }
        public static string[] PatchList
        {
            get
            {
                string patches = null;
                switch (GameCode)
                {
                    case "AMTE":
                        patches = Resources.MF_U_patches;
                        break;
                    case "BMXE":
                        patches = Resources.ZM_U_patches;
                        break;
                }
                return patches.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            }
        }
        #endregion

        #region region specific (private)
        private static int AreaHeaderPtr { get; set; }
        private static int TilesetPtr { get; set; }
        private static int AnimTilesetPtr { get; set; }
        private static int AnimGfxPtr { get; set; }
        private static int AnimPalettePtr { get; set; }
        private static int SpriteGfxRowsPtr { get; set; }
        private static int SpriteGfxPtr { get; set; }
        private static int SpritePalettePtr { get; set; }
        private static int SpriteStats1Ptr { get; set; }
        private static int SpriteStats2Ptr { get; set; }
        private static int SpriteAI1Ptr { get; set; }
        private static int SpriteAI2Ptr { get; set; }
        private static int SpritesetPtr { get; set; }
        private static int DoorsPtr { get; set; }
        private static int AreaConnectionsPtr { get; set; }
        private static int DoorEventsPtr { get; set; }
        private static int NumOfDoorEventsOffset { get; set; }
        private static int LocationNamesPtr { get; set; }
        private static int HatchLockEventsPtr { get; set; }
        private static int ScrollsPtr { get; set; }
        private static int ClipdataTypePtr { get; set; }
        private static int MinimapGfxPtr { get; set; }
        private static int MinimapDataPtr { get; set; }
        private static int TextGfxPtr { get; set; }
        private static int CharacterWidthsPtr { get; set; }
        private static int DemoInputPtr { get; set; }
        private static int DemoRamPtr { get; set; }
        #endregion

        public static bool IsValid(string gameCode)
        {
            switch (gameCode)
            {
                case "AMTE":
                case "_AMTP":
                case "_AMTJ":
                    IsMF = true;
                    break;
                case "BMXE":
                case "_BMXP":
                case "_BMXJ":
                    IsMF = false;
                    break;
                default:
                    Version.GameCode = null;
                    return false;
            }

            Version.GameCode = gameCode;
            return true;
        }

        public static void Initialize()
        {
            Version.romStream = ROM.Stream;

            StringReader sr;
            if (IsMF) { sr = new StringReader(Properties.Resources.MF_constants); }
            else { sr = new StringReader(Properties.Resources.ZM_constants); }
            string line;

            // get game constants
            while ((line = sr.ReadLine()) != null)
            {
                if (line.StartsWith("[")) { break; }
                string[] items = line.Split('=');
                if (items.Length < 2) { continue; }
                Parse(items[0], items[1]);
            }

            // get region constants
            while (!line.Contains(GameCode))
            {
                line = sr.ReadLine();
            }

            while ((line = sr.ReadLine()) != null)
            {
                if (line.StartsWith("[")) { break; }
                string[] items = line.Split('=');
                if (items.Length < 2) { continue; }
                Parse(items[0], items[1]);
            }

            sr.Close();

            // primary sprite graphics
            string text = "";
            if (GameCode == "AMTE")
            {
                text = Resources.MF_U_pSpriteOAM;
            }
            else if (GameCode == "BMXE")
            {
                text = Resources.ZM_U_pSpriteOAM;
            }
            MatchCollection mc = Regex.Matches(text, @"\w+");
            PSpriteOAM = new Dictionary<byte, int>();
            for (int i = 0; i < mc.Count; i += 2)
            {
                byte spriteID = Convert.ToByte(mc[i].Value, 16);
                int offset = Convert.ToInt32(mc[i + 1].Value, 16);
                PSpriteOAM.Add(spriteID, offset);
            }

            // sprite positions
            if (IsMF)
            {
                text = Resources.MF_spritePositions;
            }
            else
            {
                text = Resources.ZM_spritePositions;
            }
            mc = Regex.Matches(text, @"-?\w+");
            SpritePositions = new Dictionary<byte, Point>();
            for (int i = 0; i < mc.Count; i += 3)
            {
                byte spriteID = Convert.ToByte(mc[i].Value, 16);
                int x = int.Parse(mc[i + 1].Value);
                int y = int.Parse(mc[i + 2].Value);
                SpritePositions.Add(spriteID, new Point(x, y));
            }

            // secondary sprite graphics
            if (GameCode == "AMTE")
            {
                text = Resources.MF_U_sSpriteOAM;
            }
            else if (GameCode == "BMXE")
            {
                text = Resources.ZM_U_sSpriteOAM;
            }
            mc = Regex.Matches(text, @"\w+");
            SSpriteOwner = new Dictionary<byte, byte>();
            SSpriteOAM = new Dictionary<byte, int>();
            for (int i = 0; i < mc.Count; i += 3)
            {
                byte sSpriteID = Convert.ToByte(mc[i].Value, 16);
                byte pSpriteID = Convert.ToByte(mc[i + 1].Value, 16);
                int oamOffset = Convert.ToInt32(mc[i + 2].Value, 16);
                SSpriteOwner.Add(sSpriteID, pSpriteID);
                SSpriteOAM.Add(sSpriteID, oamOffset);
            }
        }

        public static void Parse(string name, string value)
        {
            var info = typeof(Version).GetProperty(name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
            if (info == null) { return; }

            if (info.PropertyType == typeof(byte))
            {
                byte b = Convert.ToByte(value, 16);
                info.SetValue(null, b, null);
            }
            else if (info.PropertyType == typeof(int))
            {
                int i = Convert.ToInt32(value, 16);
                info.SetValue(null, i, null);
            }
            else if (info.PropertyType == typeof(byte[]))
            {
                string[] items = value.Split(',');
                byte[] values = new byte[items.Length];
                for (int i = 0; i < items.Length; i++)
                {
                    values[i] = Convert.ToByte(items[i], 16);
                }
                info.SetValue(null, values, null);
            }
            else if (info.PropertyType == typeof(string))
            {
                info.SetValue(null, value, null);
            }
            else if (info.PropertyType == typeof(string[]))
            {
                string[] items = value.Split(',');
                info.SetValue(null, items, null);
            }
            else if (info.PropertyType == typeof(DateTime))
            {
                DateTime dt = DateTime.Parse(value);
                info.SetValue(null, dt, null);
            }
        }

    }
}
