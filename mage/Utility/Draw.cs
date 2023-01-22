using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace mage
{
    public static class Draw
    {
        public unsafe static void Flip4bpp(Bitmap src, int flip)
        {
            int width = src.Width;
            int height = src.Height;

            Rectangle rect = new Rectangle(0, 0, width, height);
            BitmapData srcData = src.LockBits(rect, ImageLockMode.ReadOnly, src.PixelFormat);

            width /= 2;
            byte[] data = new byte[width * height];
            System.Runtime.InteropServices.Marshal.Copy(srcData.Scan0, data, 0, data.Length);
            int srcPtr = 0;
            byte* dstPtr = (byte*)srcData.Scan0;

            int i, j;
            switch (flip)
            {
                case 1:
                    i = -1;
                    j = 2 * width;
                    srcPtr += width - 1;
                    break;
                case 2:
                    i = 1;
                    j = -2 * width;
                    srcPtr += width * (height - 1);
                    break;
                default:
                    i = -1;
                    j = 0;
                    srcPtr += width * height - 1;
                    break;
            }
            bool xflip = (flip & 1) == 1;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    byte srcPx = data[srcPtr];
                    if (xflip)
                    {
                        *dstPtr++ = (byte)((srcPx >> 4) | ((srcPx & 0xF) << 4));
                    }
                    else
                    {
                        *dstPtr++ = srcPx;
                    }
                    srcPtr += i;
                }
                srcPtr += j;
            }

            src.UnlockBits(srcData);
        }

        public unsafe static void Flip15bpp(Bitmap src, int flip)
        {
            int width = src.Width;
            int height = src.Height;

            Rectangle rect = new Rectangle(0, 0, width, height);
            BitmapData srcData = src.LockBits(rect, ImageLockMode.ReadOnly, src.PixelFormat);

            short[] data = new short[width * height];
            System.Runtime.InteropServices.Marshal.Copy(srcData.Scan0, data, 0, data.Length);
            int srcPtr = 0;
            short* dstPtr = (short*)srcData.Scan0;

            int i, j;
            switch (flip)
            {
                case 1:
                    i = -1;
                    j = 2 * width;
                    srcPtr += width - 1;
                    break;
                case 2:
                    i = 1;
                    j = -2 * width;
                    srcPtr += width * (height - 1);
                    break;
                default:
                    i = -1;
                    j = 0;
                    srcPtr += width * height - 1;
                    break;
            }

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    *dstPtr++ = data[srcPtr];
                    srcPtr += i;
                }
                srcPtr += j;
            }

            src.UnlockBits(srcData);
        }

        public unsafe static void Combine15bpp(Bitmap src, BitmapData dstData, int x, int y)
        {
            Rectangle srcRect = new Rectangle(0, 0, src.Width, src.Height);
            BitmapData srcData = src.LockBits(srcRect, ImageLockMode.ReadOnly, src.PixelFormat);
            
            int xStart = Math.Max(0, x);
            int yStart = Math.Max(0, y);
            int width = Math.Min(x + src.Width, dstData.Width) - xStart;
            int height = Math.Min(y + src.Height, dstData.Height) - yStart;

            ushort* srcPtr = (ushort*)srcData.Scan0;
            ushort* dstPtr = (ushort*)dstData.Scan0;

            int srcWidth = srcData.Stride / 2;
            int dstWidth = dstData.Stride / 2;
            srcPtr += (yStart - y) * srcWidth + (xStart - x);
            dstPtr += yStart * dstWidth + xStart;

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    ushort srcPx = *srcPtr++;
                    if (srcPx < 0x8000)
                    {
                        dstPtr++;
                    }
                    else
                    {
                        *dstPtr++ = srcPx;
                    }
                }
                srcPtr += srcWidth - width;
                dstPtr += dstWidth - width;
            }

            src.UnlockBits(srcData);
        }

        public unsafe static void SemiCombine15bpp(Bitmap src, BitmapData dstData, int x, int y)
        {
            Rectangle srcRect = new Rectangle(0, 0, src.Width, src.Height);
            BitmapData srcData = src.LockBits(srcRect, ImageLockMode.ReadOnly, src.PixelFormat);

            int xStart = Math.Max(0, x);
            int yStart = Math.Max(0, y);
            int width = Math.Min(x + src.Width, dstData.Width) - xStart;
            int height = Math.Min(y + src.Height, dstData.Height) - yStart;

            ushort* srcPtr = (ushort*)srcData.Scan0;
            ushort* dstPtr = (ushort*)dstData.Scan0;

            int srcWidth = srcData.Stride / 2;
            int dstWidth = dstData.Stride / 2;
            srcPtr += (yStart - y) * srcWidth + (xStart - x);
            dstPtr += yStart * dstWidth + xStart;

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    ushort srcPx = *srcPtr++;
                    if (srcPx < 0x8000)
                    {
                        dstPtr++;
                    }
                    else
                    {
                        ushort dstPx = *dstPtr;

                        int red = ((srcPx & 0x7C00) + (dstPx & 0x7C00)) >> 1 & 0x7C00;
                        int green = ((srcPx & 0x3E0) + (dstPx & 0x3E0)) >> 1 & 0x3E0;
                        int blue = ((srcPx & 0x1F) + (dstPx & 0x1F)) >> 1;
                        *dstPtr++ = (ushort)(0x8000 | red | green | blue);
                    }
                }
                srcPtr += srcWidth - width;
                dstPtr += dstWidth - width;
            }

            src.UnlockBits(srcData);
        }

        public static Rectangle Union(Rectangle rect1, Rectangle rect2)
        {
            int i = Math.Min(rect1.X, rect2.X);
            int j = Math.Min(rect1.Y, rect2.Y);
            int w = Math.Max(rect1.X + rect1.Width, rect2.X + rect2.Width) - i + 1;
            int h = Math.Max(rect1.Y + rect1.Height, rect2.Y + rect2.Height) - j + 1;
            return new Rectangle(i, j, w, h);
        }


    }
}
