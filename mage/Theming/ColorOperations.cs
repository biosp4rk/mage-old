using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace mage.Theming
{
    public static class ColorOperations
    {
        public static string ToHexString(Color c) => $"#{c.R:X2}{c.G:X2}{c.B:X2}";

        public static float GetValue(this Color c)
        {
            int max = Math.Max(c.R, Math.Max(c.G, c.B));
            return max / 255f;
        }

        public static double GetRelativeLuminance(this Color c)
        {
            double r = c.R / 255.0;
            double g = c.G / 255.0;
            double b = c.B / 255.0;

            // Calculate gamma-corrected RGB values
            double gammaR = (r <= 0.03928) ? r / 12.92 : Math.Pow((r + 0.055) / 1.055, 2.4);
            double gammaG = (g <= 0.03928) ? g / 12.92 : Math.Pow((g + 0.055) / 1.055, 2.4);
            double gammaB = (b <= 0.03928) ? b / 12.92 : Math.Pow((b + 0.055) / 1.055, 2.4);

            // Calculate relative luminance
            double luminance = 0.2126 * gammaR + 0.7152 * gammaG + 0.0722 * gammaB;
            return luminance;
        }

        public static double Contrast(this Color c1, Color c2)
        {
            double luminance1 = c1.GetRelativeLuminance();
            double luminance2 = c2.GetRelativeLuminance();

            // The contrast ratio formula: (L1 + 0.05) / (L2 + 0.05), where L1 is the lighter color's luminance
            double contrastRatio = (Math.Max(luminance1, luminance2) + 0.05) / (Math.Min(luminance1, luminance2) + 0.05);

            return contrastRatio;
        }
    }
}
