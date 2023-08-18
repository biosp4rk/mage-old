using mage.Theming.CustomControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.Versioning;
using System.Text;
using System.Windows.Forms;

namespace mage.Theming
{
    [SupportedOSPlatform("windows")]
    public static class ThemeSwitcher
    {
        /// <summary>
        /// Project Wide dictionary with all Color Themes
        /// </summary>
        public static Dictionary<string, ColorTheme> Themes = new Dictionary<string, ColorTheme>()
        { };

        public const string StandardThemeName = "Mage Old";
        /// <summary>
        /// The old color scheme of MAGE
        /// </summary>
        public static ColorTheme StandardTheme { get; } = new ColorTheme() {
            Colors = new Dictionary<string, Color>() {
            {"TextColor",  ColorTranslator.FromHtml("#000000")},
            {"BackgroundColor",  ColorTranslator.FromHtml("#F0F0F0")},
            {"PrimaryOutline",  ColorTranslator.FromHtml("#BCBCBC")},
            {"SecondaryOutline",  ColorTranslator.FromHtml("#DCDCDC")},
            {"AccentColor",  ColorTranslator.FromHtml("#0078D7")},
            }
        };

        public const string StandardDarkThemeName = "Mage Dark";
        /// <summary>
        /// A new dark color scheme for MAGE, currently based on Visual Studio 2022
        /// </summary>
        public static ColorTheme StandardDarkTheme { get; } = new ColorTheme()
        {
            Colors = new Dictionary<string, Color>() {
            {"TextColor",  ColorTranslator.FromHtml("#DCDCDC")},
            {"BackgroundColor",  ColorTranslator.FromHtml("#1E1E1E")},
            {"PrimaryOutline",  ColorTranslator.FromHtml("#5F5F5F")},
            {"SecondaryOutline",  ColorTranslator.FromHtml("#3D3D3D")},
            {"AccentColor",  ColorTranslator.FromHtml("#7160e8")},
            }
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
                if (!Themes.ContainsKey(value))
                {
                    if (value == ThemeSwitcher.StandardThemeName) Themes.Add(ThemeSwitcher.StandardThemeName, StandardTheme);
                    else if (value == ThemeSwitcher.StandardDarkThemeName) Themes.Add(ThemeSwitcher.StandardDarkThemeName, StandardDarkTheme);
                    else 
                    {
                        ProjectThemeName = ThemeSwitcher.StandardThemeName;
                        value = ThemeSwitcher.StandardThemeName;
                    }
                }
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
                ThemeChanged?.Invoke(null, EventArgs.Empty);
            }
        }

        public static event EventHandler<EventArgs> ThemeChanged;
        

        /// <summary>
        /// Changes the properties of all Controls in <paramref name="container"/> to reflect the current theme
        /// selected in the <see cref="ThemeSwitcher.ProjectTheme"/>. Changes the background color of <paramref name="Base"/> if given.
        /// </summary>
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

                if (component is FlatTabControl)
                {
                    FlatTabControl tab = component as FlatTabControl;
                    tab.BorderColor = theme.SecondaryOutline;
                }

                if (component is LinkLabel)
                {
                    LinkLabel lbl = component as LinkLabel;
                    lbl.LinkColor = theme.AccentColor;
                    lbl.VisitedLinkColor = theme.AccentColor;
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
                if (component is Label) component.Paint += DrawLabel;
                if (component is RadioButton) component.Paint += DrawRadioButton;
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
                e.Graphics.DrawLines(new Pen(ProjectTheme.TextColorHighlight, 2), new Point[]{
                new Point(r.Left, r.Bottom - r.Height /2),
                new Point(r.Left + r.Width /3,  r.Bottom),
                new Point(r.Right, r.Top)});
            }

            //Draw Text
            Brush textBrush = box.Enabled ? new SolidBrush(ProjectTheme.TextColor) : new SolidBrush(ProjectTheme.TextColorDisabled);
            e.Graphics.DrawString(box.Text, box.Font, textBrush, box.Padding.Left + 16, box.Padding.Top);
        }

        public static void DrawRadioButton(object sender, PaintEventArgs e)
        {
            RadioButton box = sender as RadioButton;

            Point pt = new Point(e.ClipRectangle.Left, e.ClipRectangle.Top);
            Rectangle rect = new Rectangle(pt, new Size(13, 13));

            e.Graphics.Clear(ProjectTheme.BackgroundColor);

            //Drawing box
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (Brush b = box.Checked ? new SolidBrush(ProjectTheme.AccentColor) : new SolidBrush(ProjectTheme.BackgroundColor)) e.Graphics.FillEllipse(b, rect);
            Pen p = box.Checked ? new Pen(ProjectTheme.AccentColor) : box.Enabled ? new Pen(ProjectTheme.PrimaryOutline) : new Pen(ProjectTheme.PrimaryOutlineDisabled) { Alignment = PenAlignment.Inset };
            e.Graphics.DrawEllipse(p, rect);

            if (box.Checked)
            {
                //Drawing the check
                rect.Inflate(-3, -3);
                using (Brush b = new SolidBrush(ProjectTheme.TextColorHighlight)) e.Graphics.FillEllipse(b, rect);
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

        public static void DrawLabel(object sender, PaintEventArgs e)
        {
            Label l = sender as Label;

            if (l.Enabled) return;

            Rectangle r = new Rectangle(Point.Empty, l.Size);
            e.Graphics.Clear(ProjectTheme.BackgroundColor);
            using (Brush b = new SolidBrush(ProjectTheme.TextColorDisabled))
                e.Graphics.DrawString(l.Text, l.Font, b, r);
        }
    }
}
