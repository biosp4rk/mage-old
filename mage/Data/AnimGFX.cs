using System;

namespace mage
{
    public class AnimGFX
    {
        // fields
        public byte number;
        public byte type;
        public byte delay;
        public byte numStates;
        public GFX gfx;

        // constructor for tanks
        public AnimGFX(ByteStream romStream, int tank)
        {
            int offset = Version.TankGfxOffset;
            type = 1;
            delay = 5;
            numStates = 4;
            gfx = new GFX(romStream, offset + tank * 0x200, 8, 2);
        }

        // constructor
        public AnimGFX(ByteStream romStream, byte number)
        {
            this.number = number;

            int offset = Version.AnimGfxOffset + number * 8;
            romStream.Seek(offset);
            type = romStream.Read8();
            delay = romStream.Read8();
            numStates = romStream.Read8();
            int gfxOffset = romStream.ReadPtr();
            gfx = new GFX(romStream, gfxOffset, Math.Max(4, 4 * numStates), 1);
        }


    }
}
