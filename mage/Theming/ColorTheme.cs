using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace mage.Theming
{
    public class ColorTheme
    {
        const int disabledAlpha = 0x50;

        public Color BackgroundColor => Colors["BackgroundColor"];

        public Color TextColor => Colors["TextColor"];
        public Color TextColorDisabled => Color.FromArgb(disabledAlpha, TextColor);
        public Color TextColorHighlight { 
            get
            {
                double contrast = 0;
                string color = "AccentColor";
                foreach(KeyValuePair<string, Color> p in Colors)
                {
                    if (p.Value.Contrast(AccentColor) > contrast)
                    {
                        contrast = p.Value.Contrast(AccentColor);
                        color = p.Key;
                    }
                }
                return Colors[color];
            } 
        }

        public Color PrimaryOutline => Colors["PrimaryOutline"];
        public Color PrimaryOutlineDisabled => Color.FromArgb(disabledAlpha, PrimaryOutline);

        public Color SecondaryOutline => Colors["SecondaryOutline"];

        public Color AccentColor => Colors["AccentColor"];

        public Dictionary<string, Color> Colors { get; set; } = new Dictionary<string, Color>();
    }
}
