using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace mage
{
    public partial class FormClipboard : Form
    {
        public FormClipboard()
        {
            InitializeComponent();
        }

        public unsafe void UpdateImage(Bitmap src, Rectangle selection)
        {
            int width = selection.Width * 16;
            int height = selection.Height * 16;
            Rectangle rect1 = new Rectangle(0, 0, width, height);
            Rectangle rect2 = new Rectangle(selection.X * 16, selection.Y * 16, width, height);
            Bitmap dst = new Bitmap(rect1.Width, rect1.Height, src.PixelFormat);
            
            BitmapData dstData = dst.LockBits(rect1, ImageLockMode.WriteOnly, dst.PixelFormat);
            BitmapData srcData = src.LockBits(rect2, ImageLockMode.ReadOnly, src.PixelFormat);

            ushort* dstPtr = (ushort*)dstData.Scan0;
            ushort* srcPtr = (ushort*)srcData.Scan0;
            ushort* dstEnd = dstPtr + width * height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    *dstPtr++ = *srcPtr++;
                }
                srcPtr += src.Width - width;
            }

            dst.UnlockBits(dstData);
            src.UnlockBits(srcData);

            pictureBox_clipboard.Size = dst.Size;
            pictureBox_clipboard.Image = dst;
        }

        public void Clear()
        {
            pictureBox_clipboard.Size = new Size(0, 0);
            pictureBox_clipboard.Image = null;
        }


    }
}
