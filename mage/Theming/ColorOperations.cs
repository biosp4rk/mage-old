using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace mage.Theming
{
    public static class ColorOperations
    {
        public static string ToHexString(Color c) => $"#{c.R:X2}{c.G:X2}{c.B:X2}";
    }
}
