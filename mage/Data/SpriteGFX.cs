using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace mage
{
    public class SpriteGFX
    {
        public int GfxOffset
        {
            get
            {
                int addVal = (pSpriteID - 0x10) * 4;
                int offset = Version.SpriteGfxOffset + addVal;
                return romStream.ReadPtr(offset);
            }
        }
        public int PalOffset
        {
            get
            {
                int addVal = (pSpriteID - 0x10) * 4;
                int offset = Version.SpritePaletteOffset + addVal;
                return romStream.ReadPtr(offset);
            }
        }
        public int NumGfxRows
        {
            get
            {
                int addVal = (pSpriteID - 0x10) * 4;
                int rows;
                if (Version.IsMF)
                {
                    int offset = Version.SpriteGfxRowsOffset + addVal;
                    rows = romStream.Read16(offset) / 0x800;
                }
                else
                {
                    int offset = Version.SpriteGfxOffset + addVal;
                    offset = romStream.ReadPtr(offset);
                    rows = romStream.Read16(offset + 1) / 0x800;
                    return Math.Max(romStream.Read16(offset + 1) / 0x800, 1);
                }
                if (rows < 1) { return 1; }
                if (rows > 8) { return 8; }
                return rows;
            }
        }

        // sprite preview
        public Bitmap previewImg;
        public int xOffset;
        public int yOffset;

        public byte pSpriteID;
        public byte sSpriteID;
        public bool primary;
        private ByteStream romStream;

        // constructor
        public SpriteGFX(VramObj vramObj, int gfxRow, byte spriteID, bool primary)
        {
            this.romStream = ROM.Stream;
            this.primary = primary;
            if (primary)
            {
                this.pSpriteID = spriteID;
            }
            else
            {
                this.sSpriteID = spriteID;
                byte temp;
                if (Version.SSpriteOwner.TryGetValue(sSpriteID, out temp))
                {
                    this.pSpriteID = temp;
                }
            }

            DrawPreview(vramObj, gfxRow);
        }

        private void DrawPreview(VramObj vramObj, int gfxRow)
        {
            if (pSpriteID < 0x10) { return; }

            int offset = 0;
            if (primary)
            {
                if (!Version.PSpriteOAM.TryGetValue(pSpriteID, out offset)) { return; }
            }
            else
            {
                if (!Version.SSpriteOAM.TryGetValue(sSpriteID, out offset)) { return; }
            }

            gfxRow &= 7;

            OAM oam = new OAM(offset);
            previewImg = oam.Draw(vramObj.objTiles, vramObj.palette, gfxRow, 0);
            xOffset = oam.frames[0].xOffset;
            yOffset = oam.frames[0].yOffset;

            Point p;
            if (primary && Version.SpritePositions.TryGetValue(pSpriteID, out p))
            {
                xOffset += p.X;
                yOffset += p.Y;
            }
        }

        public void Write(int gfxOffset, int palOffset, int gfxRows)
        {
            int addVal = (pSpriteID - 0x10) * 4;
            int offset = Version.SpriteGfxOffset + addVal;
            romStream.WritePtr(offset, gfxOffset);

            offset = Version.SpritePaletteOffset + addVal;
            romStream.WritePtr(offset, palOffset);

            if (Version.IsMF)
            {
                offset = Version.SpriteGfxRowsOffset + addVal;
                ushort len = (ushort)(gfxRows * 0x800);
                romStream.Write16(offset, len);
            }

            // TODO: fix
            //GetGfxData();
        }


    }
}
