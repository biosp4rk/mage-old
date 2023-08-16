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

        public override Color MenuItemBorder => Color.Transparent;  //Border around the selection
        public override Color MenuBorder => theme.PrimaryOutline;   //Outline on the dropdown
        public override Color MenuItemPressedGradientBegin => theme.AccentColor;            //Color for pressed item
        public override Color MenuItemPressedGradientMiddle => MenuItemPressedGradientBegin;//
        public override Color MenuItemPressedGradientEnd => MenuItemPressedGradientBegin;   //
        public override Color MenuItemSelectedGradientBegin => theme.AccentColor;           //Color for selected item
        public override Color MenuItemSelectedGradientEnd => MenuItemSelectedGradientBegin; //
        public override Color CheckBackground => Color.FromArgb(0x3F, theme.AccentColor);
        public override Color GripLight => Color.Red;

        public override Color ToolStripDropDownBackground => theme.BackgroundColor;     //Dropdown Background
        public override Color MenuItemSelected => theme.AccentColor;  //Color for selected Item in Dropdown
        public override Color ImageMarginGradientBegin => ToolStripDropDownBackground;  //Weird left coloumn in dropdown
        public override Color ImageMarginGradientMiddle => ToolStripDropDownBackground; //
        public override Color ImageMarginGradientEnd => ToolStripDropDownBackground;    //
        public override Color SeparatorDark => theme.PrimaryOutline;    //Seperators
        public override Color SeparatorLight => Color.Transparent;      //
        public override Color ToolStripBorder => theme.SecondaryOutline;  //Bottom border of the toolstrip

        //Button colors
        public override Color ButtonSelectedGradientBegin => Color.FromArgb(0x3F, theme.AccentColor);   //Background color of the selected button
        public override Color ButtonSelectedGradientMiddle => ButtonSelectedGradientBegin;              //
        public override Color ButtonSelectedGradientEnd => ButtonSelectedGradientBegin;                 //
        public override Color ButtonSelectedBorder => Color.FromArgb(0x7F, theme.AccentColor);  //Border of the selected or checked button
        public override Color ButtonCheckedGradientBegin => Color.FromArgb(0x3F, theme.AccentColor);    //Background color of a checked button
        public override Color ButtonCheckedGradientMiddle => ButtonCheckedGradientBegin;                //
        public override Color ButtonCheckedGradientEnd => ButtonCheckedGradientBegin;                   //
        public override Color ButtonPressedGradientBegin => Color.FromArgb(0x7F, theme.AccentColor);    //Background color of a pressed button or while hovering over a checked button
        public override Color ButtonPressedGradientMiddle => ButtonPressedGradientBegin;                //
        public override Color ButtonPressedGradientEnd => ButtonPressedGradientBegin;                   //
    }
}
