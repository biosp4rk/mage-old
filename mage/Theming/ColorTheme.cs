using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace mage.Theming
{
    public class ColorTheme
    {
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

        private Color primaryColor;
        public Color PrimaryColor
        {
            get => primaryColor;
            set { primaryColor = value; }
        }

        private Color secondaryColor;
        public Color SecondaryColor
        {
            get => secondaryColor;
            set { secondaryColor = value; }
        }

        private Color accentColor;
        public Color AccentColor
        {
            get => accentColor;
            set { accentColor = value; }
        }
    }
}
