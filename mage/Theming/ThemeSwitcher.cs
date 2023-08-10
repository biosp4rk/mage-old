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
        static ColorTheme ProjectTheme { get; set; }

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
            }
        }

        /// <summary>
        /// This injects new paint events into existing controls to allow for custom colors
        /// </summary>
        public static void InjectPaintOverrides(Control.ControlCollection container)
        {
            foreach (Control component in container)
            {
                if (component.Controls.Count > 0) InjectPaintOverrides(component.Controls);

                if (component is GroupBox) component.Paint += DrawGroupBox;
                if (component is ComboBox)
                {
                    ComboBox box = component as ComboBox;
                    box.DrawMode = DrawMode.OwnerDrawFixed;
                    box.DrawItem += DrawComboboxItem;
                    component.Paint += DrawComboBox;
                }
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
            Color borderColor = ProjectTheme.SecondaryColor;

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

        public static void DrawComboBox(object sender, PaintEventArgs e)
        {
            ComboBox box = sender as ComboBox;
            Graphics g = e.Graphics;

            g.Clear(box.BackColor);
        }

        public static void DrawComboboxItem(object sender, DrawItemEventArgs e)
        {
            ComboBox box = sender as ComboBox;

            Graphics g = e.Graphics;
            int index = e.Index >= 0 ? e.Index : -1;
            Brush brush = ((e.State & DrawItemState.Selected) > 0) ? SystemBrushes.HighlightText : new SolidBrush(box.ForeColor);
            //g.Clear(box.BackColor);
            e.DrawBackground();
            if (index != -1)
            {
                e.Graphics.DrawString(box.Items[index].ToString(), e.Font, brush, e.Bounds, StringFormat.GenericDefault);
            }
            e.DrawFocusRectangle();
        }
    }
}
