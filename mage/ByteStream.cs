using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace mage
{
    public class ByteStream
    {
        // properties
        public byte[] Data { get { return data; } }
        public int Position { get { return pos; } }
        public int Length { get { return length; } }
        private int Capacity
        {
            get { return data.Length; }
            set { Array.Resize(ref data, value); }
        }

        // fields
        private const int size32mb = 0x2000000;

        private byte[] data;
        private int pos;
        private int length;

        // constructors
        public ByteStream(int capacity = 4)
        {
            data = new byte[capacity];
            pos = 0;
            length = 0;
        }

        public ByteStream(byte[] data)
        {
            this.data = data;
            pos = 0;
            length = data.Length;
        }

        // methods
        private void Resize()
        {
            // double capacity until greater than length
            int newCapacity = Capacity * 2;
            while (length > newCapacity)
            {
                newCapacity *= 2;
            }

            // check if over 32 MB
            if (newCapacity > size32mb)
            {
                if (length <= size32mb)
                {
                    newCapacity = size32mb;
                }
                else
                {
                    // TODO: throw exception
                    return;
                }
            }

            Capacity = newCapacity;
        }

        public void Seek(int offset)
        {
            pos = offset;
        }

        public void Align(int remainder = 4)
        {
            while (pos % remainder != 0)
            {
                pos++;
            }
        }

        #region value read/write

        public byte Read8()
        {
            return data[pos++];
        }

        public ushort Read16()
        {
            if (pos % 2 != 0) { pos++; }

            ushort val = (ushort)(data[pos] | (data[pos + 1] << 8));
            pos += 2;
            return val;
        }

        public int Read32()
        {
            int remainder = pos % 4;
            if (remainder != 0)
            {
                pos += 4 - remainder;
            }

            int val = data[pos] | (data[pos + 1] << 8) | (data[pos + 2] << 16) | (data[pos + 3] << 24);
            pos += 4;
            return val;
        }

        public int ReadPtr()
        {
            int remainder = pos % 4;
            if (remainder != 0)
            {
                pos += 4 - remainder;
            }

            int val = data[pos] | (data[pos + 1] << 8) | (data[pos + 2] << 16) | ((data[pos + 3] - 8) << 24);
            pos += 4;
            return val;
        }

        public string ReadASCII(int len)
        {
            byte[] text = new byte[len];
            Array.Copy(data, pos, text, 0, len);
            string str = Encoding.ASCII.GetString(text);

            pos += len;
            return str;
        }

        public void Write8(byte val)
        {
            if (pos >= length)
            {
                length = pos + 1;
                if (length > Capacity)
                {
                    Resize();
                }
            }

            data[pos++] = val; 
        }

        public void Write16(ushort val)
        {
            if (pos % 2 != 0) { Write8(0); }

            if (pos + 2 > length)
            {
                length = pos + 2;
                if (length > Capacity)
                {
                    Resize();
                }
            }

            data[pos] = (byte)val;
            data[pos + 1] = (byte)(val >> 8);
            pos += 2;
        }

        public void Write32(int val, bool align = true)
        {
            if (align)
            {
                while (pos % 4 != 0) { Write8(0); }
            }

            if (pos + 4 > length)
            {
                length = pos + 4;
                if (length > Capacity)
                {
                    Resize();
                }
            }

            data[pos] = (byte)val;
            data[pos + 1] = (byte)(val >> 8);
            data[pos + 2] = (byte)(val >> 16);
            data[pos + 3] = (byte)(val >> 24);
            pos += 4;
        }

        public void WritePtr(int val)
        {
            while (pos % 4 != 0) { Write8(0); }

            if (pos + 4 > length)
            {
                length = pos + 4;
                if (length > Capacity)
                {
                    Resize();
                }
            }

            data[pos] = (byte)val;
            data[pos + 1] = (byte)(val >> 8);
            data[pos + 2] = (byte)(val >> 16);
            data[pos + 3] = (byte)((val >> 24) + 8);
            pos += 4;
        }

        public void WriteASCII(string str)
        {
            byte[] text = Encoding.ASCII.GetBytes(str);
            int textLen = text.Length;

            if (pos + textLen > length)
            {
                length = pos + textLen;
                if (length > Capacity)
                {
                    Resize();
                }
            }

            Array.Copy(text, 0, data, pos, textLen);
            pos += textLen;
        }

        #endregion

        #region value read/write (offset)

        public byte Read8(int offset)
        {
            return data[offset];
        }

        public ushort Read16(int offset)
        {
            return (ushort)(data[offset] | (data[offset + 1] << 8));
        }

        public int Read32(int offset)
        {
            return data[offset] | (data[offset + 1] << 8) | (data[offset + 2] << 16) | (data[offset + 3] << 24);
        }

        public int ReadPtr(int offset)
        {
            return data[offset] | (data[offset + 1] << 8) | (data[offset + 2] << 16) | ((data[offset + 3] - 8) << 24);
        }

        public string ReadASCII(int offset, int len)
        {
            byte[] text = new byte[len];
            Array.Copy(data, offset, text, 0, len);
            return Encoding.ASCII.GetString(text);
        }

        public void Write8(int offset, byte val)
        {
            data[offset] = val;
        }

        public void Write16(int offset, ushort val)
        {
            data[offset] = (byte)val;
            data[offset + 1] = (byte)(val >> 8);
        }

        public void Write32(int offset, int val)
        {
            data[offset] = (byte)val;
            data[offset + 1] = (byte)(val >> 8);
            data[offset + 2] = (byte)(val >> 16);
            data[offset + 3] = (byte)(val >> 24);
        }

        public void WritePtr(int offset, int val)
        {
            data[offset] = (byte)val;
            data[offset + 1] = (byte)(val >> 8);
            data[offset + 2] = (byte)(val >> 16);
            data[offset + 3] = (byte)((val >> 24) + 8);
        }

        public void WriteASCII(int offset, string str)
        {
            byte[] text = Encoding.ASCII.GetBytes(str);
            Array.Copy(text, 0, data, offset, text.Length);
        }

        #endregion

        #region data read/write

        public void CopyToArray(int srcOffset, Array dstData, int dstOffset, int len)
        {
            Buffer.BlockCopy(data, srcOffset, dstData, dstOffset, len);
        }

        public void CopyFromArray(Array srcData, int srcOffset, int dstOffset, int len)
        {
            Buffer.BlockCopy(srcData, srcOffset, data, dstOffset, len);
        }

        public void OverlappingCopy(int amount, int window)
        {
            if (pos + amount > length)
            {
                length = pos + amount;
                if (length > Capacity)
                {
                    Resize();
                }
            }

            for (int i = 0; i < amount; i++)
            {
                data[pos] = data[pos - window];
                pos++;
            }
        }

        // NOTICE: This function searches the entire rom for the provided
        // address. There is a small chance that it will match bytes that are
        // not actually a pointer, thus corrupting data when written to.
        // Ideally, mage should have a file containing all valid pointers
        public List<int> GetPointers(int offset)
        {
            byte byte0 = (byte)offset;
            byte byte1 = (byte)(offset >> 8);
            byte byte2 = (byte)(offset >> 16);
            byte byte3 = (byte)((offset >> 24) + 8);

            List<int> ptrs = new List<int>();

            for (int i = 0; i < length; i += 4)
            {
                if (data[i] == byte0 && data[i + 1] == byte1 && data[i + 2] == byte2 && data[i + 3] == byte3)
                {
                    ptrs.Add(i);
                }
            }

            return ptrs;
        }

        private int FindEndOfData()
        {
            int endOfData;

            if (Version.IsMF)
            {
                endOfData = length;
                FindEndOfRun(ref endOfData);
            }
            else
            {
                endOfData = Version.MetroidOffset;
                FindEndOfRun(ref endOfData);
                if (Version.MetroidOffset - endOfData < 8)
                {
                    endOfData = length;
                    FindEndOfRun(ref endOfData);
                }
            }

            // should always be 4 byte aligned
            return endOfData;
        }

        private void FindEndOfRun(ref int endOfData)
        {
            while (endOfData > 0)
            {
                endOfData--;
                if (data[endOfData] != 0xFF) { break; }
            }
            endOfData++;
        }

        private int CheckFreeSpaceAfter(int offset)
        {
            int end = offset;

            while (offset % 4 != 0)
            {
                if (data[offset++] != 0) { return end; }
            }

            string str = ReadASCII(offset, 4);
            if (str == "mage")
            {
                ushort len = Read16(offset + 4);
                // erase mage and length
                for (int i = end; i < offset + 6; i++)
                {
                    data[i] = 0xFF;
                }
                return offset + len;
            }
            else { return end; }
        }

        private void MarkFreeSpace(int addr, int prevLen, int newLen)
        {
            // find end of data
            int endOfData = FindEndOfData();
            int dataEnd = addr + prevLen;

            bool atEnd = true;
            if (dataEnd + 4 >= endOfData)
            {
                while (dataEnd < endOfData)
                {
                    if (data[dataEnd++] != 0)
                    {
                        atEnd = false;
                        break;
                    }
                }
            }
            else { atEnd = false; }

            int eraseOffset = addr + newLen;
            if (atEnd)
            {
                // write 0 if last byte is FF
                if (data[eraseOffset - 1] == 0xFF)
                {
                    data[eraseOffset++] = 0;
                }
                // align
                while (eraseOffset % 4 != 0)
                {
                    data[eraseOffset++] = 0;
                }

                // erase
                while (eraseOffset < endOfData)
                {
                    data[eraseOffset++] = 0xFF;
                }
            }
            else
            {
                // check if "mage" was written after
                int end = CheckFreeSpaceAfter(addr + prevLen);

                // try to align, if there's space
                if (eraseOffset < end)
                {
                    // write 0 if last byte is FF
                    if (data[eraseOffset - 1] == 0xFF)
                    {
                        data[eraseOffset++] = 0;
                    }
                    // align
                    while (eraseOffset % 4 != 0 && eraseOffset < end)
                    {
                        data[eraseOffset++] = 0;
                    }
                }

                // erase
                int eraseStart = eraseOffset;
                while (eraseOffset < end)
                {
                    data[eraseOffset++] = 0xFF;
                }

                // write remaining space
                int len = end - eraseStart;
                if (len < 6) { return; }

                Seek(eraseStart);
                WriteASCII("mage");
                Write16((ushort)len);
            }
        }

        private bool AllocateSpace(ref int offset, int newLen)
        {
            int endOfData = FindEndOfData();

            // find free space before end of data
            for (int i = 0xA0000; i < endOfData; i += 4)
            {
                if (data[i] == 0x6D && data[i + 1] == 0x61 && data[i + 2] == 0x67 && data[i + 3] == 0x65)
                {
                    // check if space is long enough
                    int space = Read16(i + 4);
                    if (space < newLen) { continue; }

                    // check if space is valid
                    bool valid = true;
                    for (int j = 6; j < space; j++)
                    {
                        if (data[i + j] != 0xFF)
                        {
                            valid = false;
                            break;
                        }
                    }
                    if (valid)
                    {
                        // write remaining length
                        int remainStart = i + newLen;
                        while (remainStart % 4 != 0) { remainStart++; }
                        int remaining = i + space - remainStart;
                        if (remaining >= 6) 
                        {
                            Seek(i + newLen);
                            while (pos % 4 != 0) { data[pos++] = 0; }
                            WriteASCII("mage");
                            Write16((ushort)remaining);
                        }

                        offset = i;
                        return false;
                    }
                }
            }

            // no free space found
            if (!Version.IsMF && endOfData < Version.MetroidOffset && endOfData + newLen > Version.MetroidOffset)
            {
                endOfData = Capacity;
                FindEndOfRun(ref endOfData);
            }
            // check if rom needs to be resized
            if (endOfData + newLen > Capacity && Capacity < size32mb)
            {
                Capacity *= 2;
                length = Capacity;
                for (int i = length / 2; i < length; i++)
                {
                    data[i] = 0xFF;
                }
            }

            offset = endOfData;
            return true;
        }

        // no pointer provided
        public void Write2(ByteStream src, int origLen, ref int offset, bool fixPtrs)
        {
            int newLen = src.length;

            if (newLen <= origLen)
            {
                // overwrite, mark free space, and return
                Array.Copy(src.data, 0, data, offset, newLen);
                MarkFreeSpace(offset, origLen, newLen);
                return;
            }

            // delete and mark remaining free space
            MarkFreeSpace(offset, origLen, 0);

            // allocate space
            int prevOffset = offset;
            bool atEnd = AllocateSpace(ref offset, newLen);

            // write to new location
            Array.Copy(src.data, 0, data, offset, newLen);

            // align if at end of data
            if (atEnd)
            {
                int end = offset + newLen;
                if (data[end - 1] == 0xFF)
                {
                    data[end++] = 0;
                }
                while (end % 4 != 0)
                {
                    data[end++] = 0;
                }
            }

            // fix all pointers
            if (fixPtrs)
            {
                List<int> pointers = GetPointers(prevOffset);
                foreach (int p in pointers)
                {
                    WritePtr(p, offset);
                }
            }
        }

        // pointer provided
        public void Write(ByteStream src, int origLen, int ptr, bool shared)
        {
            int offset = ReadPtr(ptr);
            List<int> pointers = GetPointers(offset);

            int newLen = src.length;
            bool bigger = newLen > origLen;
            bool onePtr = pointers.Count == 1;

            if (!bigger && (onePtr || shared))
            {
                // overwrite, mark remaining free space, and return
                Array.Copy(src.data, 0, data, offset, newLen);
                MarkFreeSpace(offset, origLen, newLen);
                return;
            }
            if (bigger && (onePtr || shared))
            {
                // delete, mark free space
                MarkFreeSpace(offset, origLen, 0);
            }

            // allocate space
            bool atEnd = AllocateSpace(ref offset, newLen);

            // write to new location
            Array.Copy(src.data, 0, data, offset, newLen);

            // align if at end of data
            if (atEnd)
            {
                int end = offset + newLen;
                if (data[end - 1] == 0xFF)
                {
                    data[end++] = 0;
                }
                while (end % 4 != 0)
                {
                    data[end++] = 0;
                }
            }

            if (shared)
            {
                // fix all pointers
                foreach (int p in pointers)
                {
                    WritePtr(p, offset);
                }
            }
            else
            {
                // fix original
                WritePtr(ptr, offset);
            }
        }

        // no data management
        public void Write(ByteStream src)
        {
            int srcLen = src.length;

            if (pos + srcLen > length)
            {
                length = pos + srcLen;
                if (length > Capacity)
                {
                    Resize();
                }
            }

            Array.Copy(src.data, 0, data, pos, srcLen);
            pos += srcLen;
        }

        public int AddData(ByteStream src)
        {
            int newLen = src.length;

            // allocate space
            int offset = 0;
            bool atEnd = AllocateSpace(ref offset, newLen);

            // write to new location
            Array.Copy(src.data, 0, data, offset, newLen);

            // align if at end of data
            if (atEnd)
            {
                int end = offset + newLen;
                if (data[end - 1] == 0xFF)
                {
                    data[end++] = 0;
                }
                while (end % 4 != 0)
                {
                    data[end++] = 0;
                }
            }

            return offset;
        }

        public void Export(string outputFile)
        {
            BinaryWriter bw = new BinaryWriter(File.Open(outputFile, FileMode.Create));
            bw.Write(data, 0, length);
            bw.Close();
        }

        #endregion

    }
}
