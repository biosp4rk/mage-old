using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace mage
{
    public partial class RoomView : ScrollableControl
    {
        // properties
        public bool HasSelection
        {
            get { return selRect.X != -1; }
        }
        public FormMain Main
        {
            set { main = value; }
        }
        public Room Room
        {
            set
            {
                room = value;
                this.BackgroundImage = new Bitmap(room.Width * 16, room.Height * 16, PixelFormat.Format16bppRgb555);
                this.Size = new Size(BackgroundImage.Width << zoom, BackgroundImage.Height << zoom);
            }
        }

        // fields
        public Rectangle redRect;
        public Rectangle selRect;
        private Pen rp, wp, bp;
        private int zoom;

        private FormMain main;
        private Room room;

        public RoomView()
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

        public bool UpdateZoom(int newZoom, bool resize)
        {
            if (zoom == newZoom) { return false; }

            zoom = newZoom;

            if (resize)
            {
                this.Size = new Size(BackgroundImage.Width << zoom, BackgroundImage.Height << zoom);
            }

            return true;
        }

        public void Reset()
        {
            int size = (16 << zoom) - 1;
            redRect = new Rectangle(-1, -1, size, size);
            selRect = new Rectangle(-1, -1, size, size);
        }

        public void MoveRed(int x, int y)
        {
            redRect.X = x << (4 + zoom);
            redRect.Y = y << (4 + zoom);
        }

        public void ResizeRed(int w, int h)
        {
            int shift = 4 + zoom;
            redRect.Width = (w << shift) - 1;
            redRect.Height = (h << shift) - 1;
        }

        public void ResizeSelection(Rectangle rect)
        {
            int shift = 4 + zoom;
            selRect = new Rectangle(rect.X << shift, rect.Y << shift, 
                (rect.Width << shift) - 1, (rect.Height << shift) - 1);
        }

        public void RedrawAll()
        {
            Redraw(new Rectangle(0, 0, BackgroundImage.Width, BackgroundImage.Height));
        }

        public unsafe void Redraw(Rectangle rect)
        {
            // get rectangles
            rect.X -= 16;
            rect.Y -= 16;
            rect.Width += 32;
            rect.Height += 32;
            Rectangle roomSize = new Rectangle(0, 0, BackgroundImage.Width, BackgroundImage.Height);
            rect.Intersect(roomSize);

            BitmapData dstData = ((Bitmap)this.BackgroundImage).LockBits(roomSize, ImageLockMode.WriteOnly, PixelFormat.Format16bppRgb555);
            int imgWidth = BackgroundImage.Width;
            int dstWidth = rect.Width;

            // fill with black
            ushort* dstPtr = (ushort*)dstData.Scan0;
            dstPtr += rect.Y * imgWidth + rect.X;
            for (int y = 0; y < rect.Height; y++)
            {
                for (int x = 0; x < dstWidth; x++)
                {
                    *dstPtr++ = 0;
                }
                dstPtr += imgWidth - dstWidth;
            }

            // backgrounds
            Rectangle region = new Rectangle(rect.X >> 4, rect.Y >> 4, rect.Width >> 4, rect.Height >> 4);
            Bitmap srcImg = room.vram.Image;
            BitmapData srcData = srcImg.LockBits(new Rectangle(0, 0, 256, srcImg.Height), ImageLockMode.ReadOnly, srcImg.PixelFormat);

            int nextLayer = 3;
            for (int i = 0; i < 4; i++)
            {
                bool drawSprites = room.backgrounds.DrawNextLayer(region, dstData, srcData, ref nextLayer);
                if (drawSprites && main.ViewSprites)
                {
                    room.enemyList.DrawSprites(rect, dstData, room.spritesets[main.EnemySet], room.vramObj);
                }
            }

            srcImg.UnlockBits(srcData);

            ((Bitmap)this.BackgroundImage).UnlockBits(dstData);

            using (Graphics g = Graphics.FromImage(this.BackgroundImage))
            {
                if (main.OutlineSprites)
                {
                    room.enemyList.DrawOutlines(g, rect);
                }
                if (main.OutlineDoors)
                {
                    room.doorList.Draw(g, rect);
                }
                if (main.OutlineScrolls)
                {
                    room.scrollList.Draw(g, rect);
                }
                if (main.ViewCollision)
                {
                    room.backgrounds.clipTypes.DrawCollision(g, rect);
                }
                else if (main.ViewBreakable)
                {
                    room.backgrounds.clipTypes.DrawBreakable(g, rect);
                }
                else if (main.ViewValues)
                {
                    room.backgrounds.clipTypes.DrawValues(g, rect);
                }
                if (main.OutlineScreens)
                {
                    DrawScreenOutlines(g, rect);
                }
            }

            rect.X <<= zoom;
            rect.Y <<= zoom;
            rect.Width <<= zoom;
            rect.Height <<= zoom;
            Invalidate(rect);
        }

        private void DrawScreenOutlines(Graphics g, Rectangle rect)
        {
            int xEnd = rect.X + rect.Width;
            int yEnd = rect.Y + rect.Height;
            Pen sp = new Pen(Color.White, 2);

            int pos = ((rect.X + 192) / 240) * 240 + 32;
            while (pos <= xEnd)
            {
                g.DrawLine(sp, pos, rect.Y, pos, yEnd);
                pos += 240;
            }
            pos = ((rect.Y + 112) / 160) * 160 + 32;
            while (pos <= yEnd)
            {
                g.DrawLine(sp, rect.X, pos, xEnd, pos);
                pos += 160;
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            if (room == null) { return; }

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

        public event EventHandler<MouseEventArgs> Scrolled;

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            Scrolled.Invoke(this, e);
            base.OnMouseWheel(e);
        }
    }
}
