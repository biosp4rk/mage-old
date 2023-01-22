using System;
using System.Collections.Generic;

namespace mage
{
    public class Spriteset
    {
        // properties
        public int Offset { get { return addr; } }
        public byte GetSpriteID(int index)
        {
            if (index < spriteIDs.Count)
            {
                return spriteIDs[index];
            }
            return 0;
        }
        public byte GetGfxRow(int index)
        {
            if (index < gfxRows.Count)
            {
                return gfxRows[index];
            }
            return 0;
        }

        // data
        public List<byte> spriteIDs;
        public List<byte> gfxRows;

        // meta
        public byte number;
        private int addr;
        private int pointer;
        private int origLen;

        // constructor
        public Spriteset(ByteStream bs, byte number)
        {
            this.number = number;
            GetData(bs);
        }

        private void GetData(ByteStream bs)
        {
            int num = Math.Min(number, Version.NumOfSpritesets - 1);
            pointer = Version.SpritesetOffset + num * 4;
            addr = bs.ReadPtr(pointer);
            int offset = addr;
            bs.Seek(offset);

            spriteIDs = new List<byte>();
            gfxRows = new List<byte>();

            for (int i = 0; i <= 0xE; i++)
            {
                byte spriteID = bs.Read8();
                byte gfxSlot = bs.Read8();

                if (spriteID == 0) { break; }

                spriteIDs.Add(spriteID);
                gfxRows.Add(gfxSlot);
            }

            origLen = (spriteIDs.Count + 1) * 2;
        }

        public void Write(ByteStream dst, bool reset, bool export)
        {
            // convert spriteset to ByteStream
            ByteStream dataToWrite = new ByteStream();
            for (int i = 0; i < spriteIDs.Count; i++)
            {
                dataToWrite.Write8(spriteIDs[i]);
                dataToWrite.Write8(gfxRows[i]);
            }
            dataToWrite.Write16(0);

            // write
            if (export)
            {
                dst.Write(dataToWrite);
            }
            else
            {
                dst.Write(dataToWrite, origLen, pointer, false);
            }

            if (reset)
            {
                origLen = dataToWrite.Length;
            }
        }

        // TODO: reuse code
        public void Import(ByteStream src)
        {
            spriteIDs = new List<byte>();
            gfxRows = new List<byte>();

            for (int i = 0; i <= 0xE; i++)
            {
                byte spriteID = src.Read8();
                byte gfxSlot = src.Read8();

                if (spriteID == 0) { break; }

                spriteIDs.Add(spriteID);
                gfxRows.Add(gfxSlot);
            }
        }

    }
}
