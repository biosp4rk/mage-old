using System;
using System.Drawing;
using System.Windows.Forms;

namespace mage
{
    public partial class TileView : Control
    {
        // properties
        public bool HasSelection
        {
            get { return selRect.X != -1; }
        }
        public override Image BackgroundImage
        {
            get
            {
                return base.BackgroundImage;
            }
            set
            {
                this.BackColor = gray;
                base.BackgroundImage = value;
                this.Size = base.BackgroundImage.Size;
            }
        }

        // fields
        public Rectangle redRect;
        public Rectangle selRect;
        private Color gray;
        private Pen rp, wp, bp;

        public TileView()
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            BackgroundImageLayout = ImageLayout.None;
            TabStop = false;

            gray = Color.FromArgb(32, 32, 32);
            rp = new Pen(Color.Red);
            wp = new Pen(Color.White);
            bp = new Pen(Color.Black);
            wp.DashPattern = bp.DashPattern = new float[] { 2, 3 };
            bp.DashOffset = 2;
        }

        public void Reset()
        {
            redRect = new Rectangle(-1, -1, 15, 15);
            selRect = new Rectangle(-1, -1, 15, 15);
        }

        public void MoveRed(int x, int y)
        {
            redRect.X = x << 4;
            redRect.Y = y << 4;
        }

        public void ResizeSelection(Rectangle rect)
        {
            selRect = new Rectangle(rect.X << 4, rect.Y << 4,
                (rect.Width << 4) - 1, (rect.Height << 4) - 1);
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


    }
}
