using System;

namespace mage
{
    public class SpriteStats
    {
        // data
        public ushort health;
        public ushort damage;
        public byte vulnerability;
        // MF only
        public byte reduction;
        public ushort healthX;
        public ushort missileX;
        public ushort redX;
        // ZM only
        public ushort noDrop;
        public ushort smallHealth;
        public ushort largeHealth;
        public ushort missile;
        public ushort superMissile;
        public ushort powerBomb;

        // meta
        public byte spriteID;
        public bool primary;

        private ByteStream romStream;

        // constructor
        public SpriteStats(byte spriteID, bool primary)
        {
            this.romStream = ROM.Stream;
            this.spriteID = spriteID;
            this.primary = primary;

            GetStats();
        }

        private void GetStats()
        {
            int offset;
            if (Version.IsMF)
            {
                if (primary)
                {
                    offset = Version.SpriteStats1Offset + (spriteID * 0xE);

                    healthX = romStream.Read16(offset + 8);
                    missileX = romStream.Read16(offset + 0xA);
                    redX = romStream.Read16(offset + 0xC);
                }
                else
                {
                    offset = Version.SpriteStats2Offset + (spriteID * 8);
                }

                reduction = romStream.Read8(offset + 4);
                vulnerability = romStream.Read8(offset + 6);
            }
            else
            {
                if (primary)
                {
                    offset = Version.SpriteStats1Offset + (spriteID * 0x12);
                }
                else
                {
                    offset = Version.SpriteStats2Offset + (spriteID * 0x12);
                }

                vulnerability = romStream.Read8(offset + 4);
                noDrop = romStream.Read16(offset + 6);
                smallHealth = romStream.Read16(offset + 8);
                largeHealth = romStream.Read16(offset + 0xA);
                missile = romStream.Read16(offset + 0xC);
                superMissile = romStream.Read16(offset + 0xE);
                powerBomb = romStream.Read16(offset + 0x10);
            }

            health = romStream.Read16(offset);
            damage = romStream.Read16(offset + 2);
        }

        public void Write()
        {
            int offset;
            if (Version.IsMF)
            {
                if (primary)
                {
                    offset = Version.SpriteStats1Offset + (spriteID * 0xE);

                    romStream.Write16(offset + 8, healthX);
                    romStream.Write16(offset + 0xA, missileX);
                    romStream.Write16(offset + 0xC, redX);
                }
                else
                {
                    offset = Version.SpriteStats2Offset + (spriteID * 8);
                }

                romStream.Write8(offset + 4, reduction);
                romStream.Write8(offset + 6, vulnerability);
            }
            else
            {
                if (primary)
                {
                    offset = Version.SpriteStats1Offset + (spriteID * 0x12);
                }
                else
                {
                    offset = Version.SpriteStats2Offset + (spriteID * 0x12);
                }

                romStream.Write8(offset + 4, vulnerability);
                romStream.Write16(offset + 6, noDrop);
                romStream.Write16(offset + 8, smallHealth);
                romStream.Write16(offset + 0xA, largeHealth);
                romStream.Write16(offset + 0xC, missile);
                romStream.Write16(offset + 0xE, superMissile);
                romStream.Write16(offset + 0x10, powerBomb);
            }

            romStream.Write16(offset, health);
            romStream.Write16(offset + 2, damage);
        }


    }
}
