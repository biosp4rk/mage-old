using System;

namespace mage
{
    public class AnimTileset
    {
        // fields
        public byte number;
        private AnimGFX[] animTiles;

        public AnimGFX this[int i]
        {
            get { return animTiles[i]; }
            set { animTiles[i] = value; }
        }

        public AnimTileset(ByteStream romStream, byte number)
        {
            this.number = number;

            int offset = Version.AnimTilesetOffset + number * 0x30;
            animTiles = new AnimGFX[16];
            for (int i = 0; i < 16; i++)
            {
                byte gfxNum = romStream.Read8(offset + i * 3);
                animTiles[i] = new AnimGFX(romStream, gfxNum);
            }
        }


    }
}
