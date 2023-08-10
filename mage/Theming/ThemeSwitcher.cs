using mage.Theming.CustomControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mage.Theming
{
    public static class ThemeSwitcher
    {
        //Project wide variables
        public static ColorTheme ProjectTheme { get; set; }

        public static void ChangeTheme(ColorTheme theme, Control.ControlCollection container, Control Base = null)
        {
            ProjectTheme = theme;

            if (Base != null)
            {
                Base.BackColor = theme.BackgroundColor;
                Base.ForeColor = theme.TextColor;
            }

            foreach (Control component in container)
            {
                component.BackColor = theme.BackgroundColor;
                component.ForeColor = theme.TextColor;
                if (component.Tag?.ToString() == "accent") component.BackColor = theme.AccentColor;

                if (component.Controls.Count > 0)
                {
                    ChangeTheme(theme, component.Controls);
                }

                //Special handeling for special controls
                if (component is FlatComboBox)
                {
                    FlatComboBox box = component as FlatComboBox;
                    box.BorderColor = theme.PrimaryOutline;
                    box.ButtonColor = theme.BackgroundColor;
                }

                if (component is MenuStrip)
                {
                    MenuStrip strip = component as MenuStrip;
                    strip.Renderer = new ToolStripProfessionalRenderer(new MenuStripColorTable(ProjectTheme));
                    foreach (ToolStripMenuItem tsmi in strip.Items)
                    {
                        tsmi.DropDown.Renderer = new ToolStripProfessionalRenderer(new MenuStripColorTable(ProjectTheme));
                        foreach (ToolStripItem item in tsmi.DropDownItems)
                        {
                            item.ForeColor = theme.TextColor;
                        }
                    } 
                }
            }
        }

        /// <summary>
        /// This injects new paint events into existing controls to allow for custom colors
        /// </summary>
        public static void InjectPaintOverrides(Control.ControlCollection container)
        {
            foreach (Control component in container)
            {
                //recursively inject the overrides in every child control
                if (component.Controls.Count > 0) InjectPaintOverrides(component.Controls);

                //Special handeling for special controls
                if (component is GroupBox) component.Paint += DrawGroupBox;
            }
        }

        /// <summary>
        /// Custom Paint event for GroupBoxes
        /// </summary>
        public static void DrawGroupBox(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            Graphics g = e.Graphics;
            Color textColor = box.ForeColor;
            Color borderColor = ProjectTheme.SecondaryOutline;

            Brush textBrush = new SolidBrush(textColor);
            Brush borderBrush = new SolidBrush(borderColor);
            Pen borderPen = new Pen(borderBrush);
            SizeF strSize = g.MeasureString(box.Text, box.Font);
            Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                           box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                           box.ClientRectangle.Width - 1,
                                           box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

            // Clear text and border
            g.Clear(box.BackColor);

            // Draw text
            g.DrawString(box.Text, box.Font, textBrush, box.Padding.Left, 0);

            // Drawing Border
            //Left
            g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
            //Right
            g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
            //Bottom
            g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
            //Top1
            g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
            //Top2
            g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
        }
    }
}
