using System;

namespace mage
{
    public static class Hex
    {
        // fields
        public static bool ToHex
        {
            get { return radix == 16; }
            set
            {
                if (value) { radix = 16; }
                else { radix = 10; }
            }
        }

        public static int radix = 16;

        // methods
        public static string ToString(int value)
        {
            return Convert.ToString(value, radix).ToUpper();
        }

        public static byte ToByte(string text)
        {
            return Convert.ToByte(text, radix);
        }

        public static ushort ToUshort(string text)
        {
            return Convert.ToUInt16(text, radix);
        }

        public static int ToInt(string text)
        {
            return Convert.ToInt32(text, radix);
        }

    }
}
