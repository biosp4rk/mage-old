using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mage.Theming
{
    public class MenuStripColorTable : ProfessionalColorTable
    {
        ColorTheme theme;
        public MenuStripColorTable(ColorTheme theme)
        {
            this.theme = theme;
        }

        public override Color MenuItemBorder => Color.Transparent;
        public override Color MenuBorder => theme.PrimaryOutline;
        public override Color MenuItemPressedGradientBegin => ColorTranslator.FromHtml("#0078d7");
        public override Color MenuItemPressedGradientEnd => MenuItemPressedGradientBegin;
        public override Color MenuItemSelectedGradientBegin => ColorTranslator.FromHtml("#0078d7");
        public override Color MenuItemSelectedGradientEnd => MenuItemSelectedGradientBegin;


        public override Color ToolStripContentPanelGradientBegin => Color.Red;
        public override Color ToolStripDropDownBackground => theme.BackgroundColor;
    }
}
