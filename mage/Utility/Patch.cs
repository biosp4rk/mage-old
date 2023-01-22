using System;

namespace mage
{
    public class Patch
    {
        // fields
        private byte[] data;

        // constructor
        public Patch(byte[] data)
        {
            this.data = data;
        }

        public void Apply()
        {
            // check sig
            int patchLen = data.Length;
            if (patchLen < 8 || data[0] != 'P' || data[1] != 'A' || data[2] != 'T' || data[3] != 'C' || data[4] != 'H')
            {
                throw new Exception("Not a valid IPS file.");
            }

            ByteStream romStream = ROM.Stream;

            // records
            int offset = 5;
            while (offset + 2 < patchLen)
            {
                int writeOffset = (data[offset] << 16) | (data[offset + 1] << 8) | data[offset + 2];
                if (writeOffset == 0x454F46)
                {
                    // EOF
                    return;
                }
                offset += 3;
                if (offset + 1 >= patchLen)
                {
                    throw new Exception("Abrupt end to IPS file, entry cut off before size.");
                }
                int size = (data[offset] << 8) | data[offset + 1];
                offset += 2;
                if (size == 0)
                {
                    // RLE
                    if (offset + 1 >= patchLen)
                    {
                        throw new Exception("Abrupt end to IPS file, entry cut off before RLE size.");
                    }
                    int rleSize = (data[offset] << 8) | data[offset + 1];
                    if (writeOffset + rleSize > romStream.Length)
                    {
                        throw new Exception("Trying to patch data past the end of the ROM file.");
                    }
                    offset += 2;
                    if (offset >= patchLen)
                    {
                        throw new Exception("Abrupt end to IPS file, entry cut off before RLE byte.");
                    }
                    byte rleByte = data[offset++];
                    for (int i = writeOffset; i < writeOffset + rleSize; i++)
                    {
                        romStream.Write8(i, rleByte);
                    }
                }
                else
                {
                    if (offset + size > patchLen)
                    {
                        throw new FormatException("Abrupt end to IPS file, entry cut off before end of data block.");
                    }
                    if (writeOffset + size > romStream.Length)
                    {
                        throw new FormatException("Trying to patch data past the end of the ROM file");
                    }
                    romStream.CopyFromArray(data, offset, writeOffset, size);
                    offset += size;
                }
            }
            throw new FormatException("Improperly terminated IPS file.");
        }

        // TODO
        // public void CreatePatch()

        public bool IsApplied()
        {
            ByteStream romStream = ROM.Stream;

            int index = 0xA;
            if (data[8] + data[9] == 0) { index += 2; }

            int addr = (data[5] << 16) + (data[6] << 8) + data[7];
            if (data[index] == romStream.Read8(addr))
            {
                return true;
            }
            return false;
        }


    }
}
