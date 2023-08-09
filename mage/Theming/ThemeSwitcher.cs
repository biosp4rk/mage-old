using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace mage.Theming
{
    public static class ThemeSwitcher
    {
        public static void ChangeTheme(ColorTheme theme, Control.ControlCollection container, Control Base = null)
        {
            if (Base != null)
            {
                Base.BackColor = theme.BackColor;
                Base.ForeColor = theme.TextColor;
            }

            foreach (Control component in container)
            {
                component.BackColor = theme.BackColor;
                component.ForeColor = theme.TextColor;

                if (component.Controls.Count > 0)
                {
                    ChangeTheme(theme, component.Controls);
                }
            }
        }

        public static void InjectPaintOverrides(Control.ControlCollection container)
        {
            foreach (Control component in container)
            {
                if (component is GroupBox) component.Paint += DrawGroupBox;
            }
        }

        public static void DrawGroupBox(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            Graphics g = e.Graphics;
            Color textColor = box.ForeColor;
            Color borderColor = Color.DarkGray;

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
