using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace mage
{
    public class Demo
    {
        public List<ushort> inputs;
        public ByteStream ramData;

        public byte number;
        private int origLen;

        public Demo(ByteStream romStream, byte number)
        {
            this.number = number;

            Load(romStream);
        }

        private void Load(ByteStream romStream)
        {
            int demoNum = number;
            if (!Version.IsMF)
            {
                demoNum = romStream.Read8(0x363CE8 + demoNum);
            }

            // load inputs
            int offset = Version.DemoInputOffset + demoNum * 0x10;
            int inputsOffset = romStream.ReadPtr(offset);
            int numInputs = romStream.Read16(offset + 4);
            int durationsOffset = romStream.ReadPtr(offset + 8);
            int numDurations = romStream.Read16(offset + 0xC);

            origLen = Math.Min(numInputs, numDurations);
            int count = origLen / 2;
            inputs = new List<ushort>();

            for (int i = 0; i < count; i++)
            {
                ushort input = romStream.Read16(inputsOffset);
                inputsOffset += 2;
                ushort duration = romStream.Read16(durationsOffset);
                durationsOffset += 2;

                for (int j = 0; j < duration; j++)
                {
                    inputs.Add(input);
                }
            }

            // load ram
            int length;
            if (Version.IsMF)
            {
                offset = Version.DemoRamOffset + demoNum * 0x1C;
                length = 0x1C;
            }
            else
            {
                offset = romStream.ReadPtr(Version.DemoRamOffset + demoNum * 4);
                length = 0x280;
            }

            byte[] data = new byte[length];
            romStream.CopyToArray(offset, data, 0, data.Length);
            ramData = new ByteStream(data);
        }

        public void Write(ByteStream romStream, bool reset)
        {
            WriteInputs(romStream, reset);
            WriteRam(romStream);
        }

        private void GetInputsDurationsRaw(ByteStream inputData, ByteStream durationData)
        {
            ushort prevInput = inputs[0];
            ushort frames = 1;

            for (int i = 1; i < inputs.Count; i++)
            {
                ushort input = inputs[i];

                if (input == prevInput)
                {
                    frames++;
                }
                else
                {
                    inputData.Write16(prevInput);
                    durationData.Write16(frames);
                    prevInput = input;
                    frames = 1;
                }
            }

            // check if last input isn't start
            if ((prevInput & 8) == 0)
            {
                inputData.Write16(prevInput);
                durationData.Write16(frames);
            }
            inputData.Write16(8);
            durationData.Write16(1);
        }

        private void WriteInputs(ByteStream romStream, bool reset)
        {
            // get list of inputs and durations
            ByteStream inputData = new ByteStream();
            ByteStream durationData = new ByteStream();
            GetInputsDurationsRaw(inputData, durationData);

            int demoNum = number;
            if (!Version.IsMF)
            {
                demoNum = romStream.Read8(0x363CE8 + demoNum);
            }
            int offset = Version.DemoInputOffset + demoNum * 0x10;
            ushort newLen = (ushort)inputData.Length;
            // write inputs
            romStream.Write(inputData, origLen, offset, false);
            romStream.Write16(offset + 4, newLen);
            // write durations
            romStream.Write(durationData, origLen, offset + 8, false);
            romStream.Write16(offset + 0xC, newLen);

            if (reset)
            {
                origLen = newLen;
            }
        }

        private void WriteRam(ByteStream romStream)
        {
            int demoNum = number;
            int offset;
            if (Version.IsMF)
            {
                offset = Version.DemoRamOffset + demoNum * 0x1C;
            }
            else
            {
                demoNum = romStream.Read8(0x363CE8 + demoNum);
                offset = romStream.ReadPtr(Version.DemoRamOffset + demoNum * 4);
            }

            romStream.CopyFromArray(ramData.Data, 0, offset, ramData.Length);
        }

        // TODO: reuse code
        public void Import(ByteStream src)
        {
            // check game
            byte game = src.Read8(0x10);
            if (game != Convert.ToByte(!Version.IsMF))
            {
                //throw new FormatException("Demo must be from the same game.");
                throw new FormatException(Properties.Resources.Data_Demo_ExceptionText);
            }

            // get offsets
            src.Seek(0x20);
            int inputsOffset = src.Read32();
            int numInputs = src.Read16();
            int durationsOffset = src.Read32();
            int numDurations = src.Read16();
            int ramOffset = src.Read32();

            // load inputs
            int count = Math.Min(numInputs, numDurations) / 2;
            inputs = new List<ushort>();

            for (int i = 0; i < count; i++)
            {
                ushort input = src.Read16(inputsOffset);
                inputsOffset += 2;
                ushort duration = src.Read16(durationsOffset);
                durationsOffset += 2;

                for (int j = 0; j < duration; j++)
                {
                    inputs.Add(input);
                }
            }

            // load ram
            int length;
            if (Version.IsMF)
            {
                length = 0x1C;
            }
            else
            {
                length = 0x280;
            }

            byte[] data = new byte[length];
            src.CopyToArray(ramOffset, data, 0, data.Length);
            ramData = new ByteStream(data);
        }

        public void Export(string filename)
        {
            // file format:
            // 00 MAGE 1.4 DEMO
            // 10 Game# Demo#
            // 20 Demo header
            // 34 Data begins

            ByteStream dst = new ByteStream();

            // write file info
            dst.WriteASCII("MAGE " + Program.ShortVersion + " DEMO");
            dst.Seek(0x10);
            dst.Write8(Convert.ToByte(!Version.IsMF));
            dst.Write8(number);
            dst.Seek(0x34);

            // inputs and durations
            ByteStream inputData = new ByteStream();
            ByteStream durationData = new ByteStream();
            GetInputsDurationsRaw(inputData, durationData);
            ushort len = (ushort)inputData.Length;

            // inputs
            int inputsOffset = dst.Position;
            dst.Write(inputData);
            dst.Align(2);

            // durations
            int durationsOffset = dst.Position;
            dst.Write(durationData);
            dst.Align(4);

            // RAM
            int ramOffset = dst.Position;
            dst.Write(ramData);

            // write demo header
            dst.Seek(0x20);
            dst.Write32(inputsOffset);
            dst.Write16(len);
            dst.Write32(durationsOffset);
            dst.Write16(len);
            dst.Write32(ramOffset);

            dst.Export(filename);
        }


    }
}
