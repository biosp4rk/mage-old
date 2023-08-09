using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace mage.Theming
{
    public class ColorTheme
    {
		private Color backColor;
		public Color BackColor
		{
			get => backColor;
			set { backColor = value; }
		}

        private Color textColor;
        public Color TextColor
        {
            get => textColor;
            set { textColor = value; }
        }
    }
}
