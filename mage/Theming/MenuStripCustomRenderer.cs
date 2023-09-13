using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.Versioning;

namespace mage.Theming
{
    [SupportedOSPlatform("windows")]
    /// <summary>
    /// Custom <see cref="ToolStripProfessionalRenderer"/>.
    /// Includes the custom <see cref="ProfessionalColorTable"/> <see cref="MenuStripColorTable"/>.
    /// </summary>
    public class MenuStripCustomRenderer : ToolStripProfessionalRenderer
    {
        ColorTheme Theme;

        public MenuStripCustomRenderer(ColorTheme theme) : this(new MenuStripColorTable(theme)) 
        { 
            Theme = theme; 
        }
        public MenuStripCustomRenderer(ProfessionalColorTable colorTable) : base(colorTable) 
        { 
            RoundedEdges = false; 
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            e.Item.ForeColor = Theme.TextColor;
            if (e.Item.Selected || e.Item.Pressed) e.Item.ForeColor = Theme.TextColorHighlight;
            base.OnRenderItemText(e);
        }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            e.ArrowColor = Theme.TextColor;
            if (e.Item.Selected || e.Item.Pressed) e.ArrowColor = Theme.TextColorHighlight;
            base.OnRenderArrow(e);
        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            if (e.ToolStrip is StatusStrip)
                e.Graphics.DrawLine(new Pen(Theme.SecondaryOutline), 0, 0, e.ToolStrip.Width, 0);
            else base.OnRenderToolStripBorder(e);
        }

        protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            var r = new Rectangle(e.ImageRectangle.Location, e.ImageRectangle.Size);
            r.Inflate(-4, -6);
            e.Graphics.DrawLines(new Pen(Theme.TextColor, 2), new Point[]{
            new Point(r.Left, r.Bottom - r.Height /2),
            new Point(r.Left + r.Width /3,  r.Bottom),
            new Point(r.Right, r.Top)});
        }
    }
}
