using mage.Theming.CustomControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace mage.Theming
{
    public static class ThemeSwitcher
    {
        /// <summary>
        /// Project Wide dictionary with all Color Themes
        /// </summary>
        public static Dictionary<string, ColorTheme> Themes = new Dictionary<string, ColorTheme>()
        {
            {"Mage Old", new ColorTheme()
            {
                Colors = new Dictionary<string, Color>() {
                {"TextColor",  ColorTranslator.FromHtml("#000000")},
                {"BackgroundColor",  ColorTranslator.FromHtml("#F0F0F0")},
                {"PrimaryOutline",  ColorTranslator.FromHtml("#BCBCBC")},
                {"SecondaryOutline",  ColorTranslator.FromHtml("#DCDCDC")},
                {"AccentColor",  ColorTranslator.FromHtml("#0078D7")},
            } } },

            {"Visual Studio Dark", new ColorTheme()
            {
                Colors = new Dictionary<string, Color>() {
                {"TextColor",  ColorTranslator.FromHtml("#DCDCDC")},
                {"BackgroundColor",  ColorTranslator.FromHtml("#1E1E1E")},
                {"PrimaryOutline",  ColorTranslator.FromHtml("#5F5F5F")},
                {"SecondaryOutline",  ColorTranslator.FromHtml("#3D3D3D")},
                {"AccentColor",  ColorTranslator.FromHtml("#7160e8")},
            } } },

            {"Jet Brains Light", new ColorTheme()
            {
                Colors = new Dictionary<string, Color>() {
                {"TextColor",  ColorTranslator.FromHtml("#080808")},
                {"BackgroundColor",  ColorTranslator.FromHtml("#FFFFFF")},
                {"PrimaryOutline",  ColorTranslator.FromHtml("#c9ccd6")},
                {"SecondaryOutline",  ColorTranslator.FromHtml("#ebecf0")},
                {"AccentColor",  ColorTranslator.FromHtml("#3574f0")},
            } } },
        };

        /// <summary>
        /// The currently used Color Theme
        /// </summary>
        private static ColorTheme projectTheme;
        private static string projectThemeName;
        public static string ProjectThemeName 
        {
            get => projectThemeName;
            set
            {
                if (!Themes.ContainsKey(value)) return;
                projectThemeName = value;
                ProjectTheme = Themes[value];
            }
        }
        public static ColorTheme ProjectTheme 
        {
            get => projectTheme;
            set
            {
                projectTheme = value;
                foreach (Form frm in Application.OpenForms)
                {
                    ChangeTheme(frm.Controls, frm);
                }
            }
        }

        public static void ChangeTheme(Control.ControlCollection container, Control Base = null)
        {
            Base?.SuspendLayout();

            ColorTheme theme = ProjectTheme;

            if (Base != null)
            {
                Base.BackColor = theme.BackgroundColor;
                Base.ForeColor = theme.TextColor;
            }

            foreach (Control component in container)
            {
                //excludes
                if (component is TileView ||
                    component is RoomView)
                    continue;

                //base change
                component.BackColor = theme.BackgroundColor;
                component.ForeColor = theme.TextColor;
                component.Invalidate();
                if (component.Tag?.ToString() == "accent") component.BackColor = theme.AccentColor;

                if (component.Controls.Count > 0)
                {
                    ChangeTheme(component.Controls);
                }

                //Special handeling for special controls
                if (component is FlatComboBox)
                {
                    FlatComboBox box = component as FlatComboBox;
                    box.BorderColor = theme.PrimaryOutline;
                    box.ButtonColor = theme.BackgroundColor;
                }

                if (component is ToolStrip)
                {
                    ToolStrip strip = component as ToolStrip;
                    strip.Renderer = new MenuStripCustomRenderer(theme);
                }

                if (component is Button)
                {
                    Button btn = component as Button;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = theme.PrimaryOutline;
                    btn.FlatAppearance.MouseOverBackColor = theme.AccentColor;
                    btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(0x7F, theme.AccentColor);
                }

                if (component is FlatTextBox)
                {
                    FlatTextBox box = component as FlatTextBox;
                    box.BorderColor = theme.PrimaryOutline;
                }

                if (component is FlatNumericUpDown)
                {
                    FlatNumericUpDown num = component as FlatNumericUpDown;
                    num.BorderStyle = BorderStyle.FixedSingle;
                    num.BorderColor = theme.PrimaryOutline;
                    num.ButtonHighlightColor = theme.AccentColor;
                }
            }

            Base?.ResumeLayout();
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
                if (component is CheckBox) component.Paint += DrawCheckBox;
                if (component is FlatTextBox)
                {
                    FlatTextBox box = component as FlatTextBox;
                    box.Enter += FocusTextBox;
                    box.Leave += FocusTextBox;
                }
                if (component is Button) component.Paint += DrawButton;
            }
        }

        /// <summary>
        /// Custom Paint event for GroupBoxes
        /// </summary>
        public static void DrawGroupBox(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            Graphics g = e.Graphics;
            Color textColor = box.Enabled ? ProjectTheme.TextColor : ProjectTheme.TextColorDisabled;
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

        public static void DrawCheckBox(object sender, PaintEventArgs e)
        {
            CheckBox box = sender as CheckBox;

            Point pt = new Point(e.ClipRectangle.Left, e.ClipRectangle.Top);
            Rectangle rect = new Rectangle(pt, new Size(13, 13));

            e.Graphics.Clear(ProjectTheme.BackgroundColor);

            //Drawing box
            using (Brush b = box.Checked ? new SolidBrush(ProjectTheme.AccentColor) : new SolidBrush(ProjectTheme.BackgroundColor)) e.Graphics.FillRectangle(b, rect);
            Pen p = box.Checked ? new Pen(ProjectTheme.AccentColor) : box.Enabled ? new Pen(ProjectTheme.PrimaryOutline) : new Pen(ProjectTheme.PrimaryOutlineDisabled) { Alignment = PenAlignment.Inset };
            e.Graphics.DrawRectangle(p, rect);

            if (box.Checked)
            {
                //Drawing the check
                Rectangle r = rect;
                r.Inflate(-3, -3);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawLines(new Pen(ProjectTheme.TextColor, 1), new Point[]{
                new Point(r.Left, r.Bottom - r.Height /2),
                new Point(r.Left + r.Width /3,  r.Bottom),
                new Point(r.Right, r.Top)});
            }

            //Draw Text
            Brush textBrush = box.Enabled ? new SolidBrush(ProjectTheme.TextColor) : new SolidBrush(ProjectTheme.TextColorDisabled);
            e.Graphics.DrawString(box.Text, box.Font, textBrush, box.Padding.Left + 16, box.Padding.Top);
        }

        public static void DrawButton(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Enabled) return;
            e.Graphics.Clear(ProjectTheme.BackgroundColor);

            Pen outlinePen = new Pen(ProjectTheme.PrimaryOutlineDisabled);
            Rectangle buttonRect = new Rectangle(Point.Empty, btn.Size);
            buttonRect.Width--; buttonRect.Height--;
            e.Graphics.DrawRectangle(outlinePen, buttonRect);

            StringFormat s = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center,
            };

            using (Brush b = new SolidBrush(ProjectTheme.TextColorDisabled)) 
                e.Graphics.DrawString(btn.Text, btn.Font, b, buttonRect, s);
        }

        public static void FocusTextBox(object sender, EventArgs e)
        {
            FlatTextBox box = sender as FlatTextBox;
            box.BorderColor = box.Focused ? ProjectTheme.AccentColor : ProjectTheme.PrimaryOutline;
        }
    }
}
