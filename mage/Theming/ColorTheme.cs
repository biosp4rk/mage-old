using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.Json.Serialization;

namespace mage.Theming
{
    public class ColorTheme
    {
        const int disabledAlpha = 0x50;

        [JsonIgnore]
        public Color BackgroundColor => Colors["BackgroundColor"];
        [JsonIgnore]
        public Color TextColor => Colors["TextColor"];
        [JsonIgnore]
        public Color TextColorDisabled => Color.FromArgb(disabledAlpha, TextColor);
        [JsonIgnore]
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
        [JsonIgnore]
        public Color PrimaryOutline => Colors["PrimaryOutline"];
        [JsonIgnore]
        public Color PrimaryOutlineDisabled => Color.FromArgb(disabledAlpha, PrimaryOutline);
        [JsonIgnore]
        public Color SecondaryOutline => Colors["SecondaryOutline"];
        [JsonIgnore]
        public Color AccentColor => Colors["AccentColor"];

        [JsonInclude]
        public Dictionary<string, Color> Colors { get; set; } = new Dictionary<string, Color>();
    }
}
