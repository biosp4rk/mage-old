using System;

namespace mage
{
    public class AnimPalette
    {
        // fields
        public byte type;
        public byte delay;
        public byte rows;
        public Palette palette;

        public byte number;

        public AnimPalette(ByteStream bs, byte number)
        {
            this.number = number;

            int offset = Version.AnimPaletteOffset + number * 8;
            bs.Seek(offset);
            type = bs.Read8();
            delay = bs.Read8();
            rows = bs.Read8();
            int palOffset = bs.ReadPtr();
            palette = new Palette(bs, palOffset, rows);
        }


    }
}
