using System;
using System.Drawing;
using System.Windows.Forms;

namespace mage
{
    public partial class GfxView : Control
    {
        // fields
        public Rectangle redRect;
        public Rectangle selRect;
        private Pen rp, wp, bp;
        private int zoom;
        private int size;

        public GfxView()
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            BackgroundImageLayout = ImageLayout.Stretch;
            TabStop = false;

            rp = new Pen(Color.Red);
            wp = new Pen(Color.White);
            bp = new Pen(Color.Black);
            wp.DashPattern = bp.DashPattern = new float[] { 2, 3 };
            bp.DashOffset = 2;
        }

        public void Initialize(int zoom, int size)
        {
            this.zoom = zoom;
            this.size = size;
            Reset();
        }

        public void Reset()
        {
            int side = (size << zoom) - 1;
            redRect = new Rectangle(-1, -1, side, side);
            selRect = redRect;
        }

        public void MoveRed(int x, int y)
        {
            redRect.X = (size * x) << zoom;
            redRect.Y = (size * y) << zoom;
        }

        public void ResizeRed(int w, int h)
        {
            redRect.Width = ((size * w) << zoom) - 1;
            redRect.Height = ((size * h) << zoom) - 1;
        }

        public void ResizeSelection(Rectangle rect)
        {
            selRect = new Rectangle((size * rect.X) << zoom, (size * rect.Y) << zoom,
                ((size * rect.Width) << zoom) - 1, ((size * rect.Height) << zoom) - 1);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            if (redRect.X != -1)
            {
                pe.Graphics.DrawRectangle(rp, redRect);
            }
            if (selRect.X != -1 && selRect.IntersectsWith(pe.ClipRectangle))
            {
                pe.Graphics.DrawRectangle(bp, selRect);
                pe.Graphics.DrawRectangle(wp, selRect);
            }
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            pevent.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.Half;
            pevent.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            base.OnPaintBackground(pevent);
        }


    }
}
