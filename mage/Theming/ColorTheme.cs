using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace mage.Theming
{
    public class ColorTheme
    {
        const int disabledAlpha = 0x50;

		private Color backgroundColor;
		public Color BackgroundColor
        {
            get => backgroundColor;
            set { backgroundColor = value; }
        }

        private Color textColor;
        public Color TextColor
        {
            get => textColor;
            set { textColor = value; }
        }
        public Color TextColorDisabled => Color.FromArgb(disabledAlpha, TextColor);

        private Color primaryOutline;
        public Color PrimaryOutline
        {
            get => primaryOutline;
            set { primaryOutline = value; }
        }

        private Color secondaryOutline;
        public Color SecondaryOutline
        {
            get => secondaryOutline;
            set { secondaryOutline = value; }
        }

        private Color accentColor;
        public Color AccentColor
        {
            get => accentColor;
            set { accentColor = value; }
        }
    }
}
