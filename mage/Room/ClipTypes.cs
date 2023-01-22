using System;
using System.Drawing;

namespace mage
{
    public class ClipTypes
    {
        // fields
        private static Pen p_solid = Pens.Red;
        private static Pen p_door = Pens.Aqua;
        private static Pen p_item = Pens.Magenta;
        private static Pen p_samus = Pens.PaleGreen;
        private static Pen p_enemy = Pens.DarkOrange;
        private static Pen[] pens = new Pen[]
            { p_enemy, p_solid, p_solid, p_solid, p_solid, p_solid, p_solid, 
                p_solid, p_enemy, p_samus, p_item, p_door, p_enemy };

        private byte[,] clipType;

        private Bitmap genBG;

        private ByteStream romStream;
        private BG clip;

        // constructor
        public ClipTypes(BG clip)
        {
            this.romStream = ROM.Stream;
            this.clip = clip;

            clipType = new byte[clip.width, clip.height];

            GFX gfx = ROM.GenericBGgfx;
            genBG = gfx.Draw15bpp(ROM.GenericBGpalette, 0, true);
        }

        public void DrawCollision(Graphics g, Rectangle region)
        {
            int w = clip.width;
            int h = clip.height;
            int xStart = Math.Max(region.X / 16, 0);
            int xEnd = Math.Min(xStart + region.Width / 16 + 2, w);
            int yStart = Math.Max(region.Y / 16, 0);
            int yEnd = Math.Min(yStart + region.Height / 16 + 2, h);

            // get clip type values
            int offset = Version.ClipdataTypeOffset;
            for (int y = yStart; y < yEnd; y++)
            {
                for (int x = xStart; x < xEnd; x++)
                {
                    ushort clipVal = clip.blocks[x, y];
                    clipType[x, y] = romStream.Read8(offset + clipVal);
                }
            }

            // draw clipdata image
            for (int y = yStart; y < yEnd; y++)
            {
                for (int x = xStart; x < xEnd; x++)
                {
                    byte val = clipType[x, y];
                    if (val == 0) { continue; }  // air

                    int x1 = x * 16;
                    int y1 = y * 16;

                    if (val >= 2 && val <= 7)  // slopes
                    {
                        Point[] pts = new Point[4];
                        if (val == 3)  // steep /
                        {
                            pts[0] = new Point(x1, y1 + 15);
                            pts[1] = new Point(x1 + 15, y1);
                            pts[2] = new Point(x1, y1 + 16);
                            pts[3] = new Point(x1 + 15, y1 + 1);
                        }
                        else if (val == 2)  // steep \
                        {
                            pts[0] = new Point(x1, y1);
                            pts[1] = new Point(x1 + 15, y1 + 15);
                            pts[2] = new Point(x1, y1 + 1);
                            pts[3] = new Point(x1 + 15, y1 + 16);
                        }
                        else if (val == 6)  // lower slight /
                        {
                            pts[0] = new Point(x1, y1 + 15);
                            pts[1] = new Point(x1 + 15, y1 + 8);
                            pts[2] = new Point(x1, y1 + 16);
                            pts[3] = new Point(x1 + 15, y1 + 9);
                        }
                        else if (val == 7)  // upper slight /
                        {
                            pts[0] = new Point(x1, y1 + 7);
                            pts[1] = new Point(x1 + 15, y1);
                            pts[2] = new Point(x1, y1 + 8);
                            pts[3] = new Point(x1 + 15, y1 + 1);
                        }
                        else if (val == 4)  // upper slight \
                        {
                            pts[0] = new Point(x1, y1);
                            pts[1] = new Point(x1 + 15, y1 + 7);
                            pts[2] = new Point(x1, y1 + 1);
                            pts[3] = new Point(x1 + 15, y1 + 8);
                        }
                        else  // lower slight \
                        {
                            pts[0] = new Point(x1, y1 + 8);
                            pts[1] = new Point(x1 + 15, y1 + 15);
                            pts[2] = new Point(x1, y1 + 9);
                            pts[3] = new Point(x1 + 15, y1 + 16);
                        }

                        g.DrawLine(pens[val], pts[0], pts[1]);
                        g.DrawLine(pens[val], pts[2], pts[3]);
                        continue;
                    }

                    bool drawL, drawR, drawT, drawB;
                    bool drawTL, drawTR, drawBL, drawBR;
                    if (val == 1)
                    {
                        drawL = (x - 1 < 0 || (byte)(clipType[x - 1, y] - 1) > 6);
                        drawR = (x + 1 >= w || (byte)(clipType[x + 1, y] - 1) > 6);
                        drawT = (y - 1 < 0 || (byte)(clipType[x, y - 1] - 1) > 6);
                        drawB = (y + 1 >= h || (byte)(clipType[x, y + 1] - 1) > 6);
                        drawTL = !(drawT || drawL) && (byte)(clipType[x - 1, y - 1] - 1) > 6 && (byte)(clipType[x, y - 1] - 2) > 5;
                        drawTR = !(drawT || drawR) && (byte)(clipType[x + 1, y - 1] - 1) > 6 && (byte)(clipType[x, y - 1] - 2) > 5;
                    }
                    else
                    {
                        drawL = (x - 1 < 0 || clipType[x - 1, y] != val);
                        drawR = (x + 1 >= w || clipType[x + 1, y] != val);
                        drawT = (y - 1 < 0 || clipType[x, y - 1] != val);
                        drawB = (y + 1 >= h || clipType[x, y + 1] != val);
                        drawTL = !(drawT || drawL) && clipType[x - 1, y - 1] != val;
                        drawTR = !(drawT || drawR) && clipType[x + 1, y - 1] != val;
                    }
                    drawBL = !(drawB || drawL) && clipType[x - 1, y + 1] != val;
                    drawBR = !(drawB || drawR) && clipType[x + 1, y + 1] != val;

                    if (drawL)
                    {
                        g.DrawRectangle(pens[val], x1, y1, 1, 15);
                    }
                    if (drawR)
                    {
                        g.DrawRectangle(pens[val], x1 + 14, y1, 1, 15);
                    }
                    if (drawT)
                    {
                        g.DrawRectangle(pens[val], x1, y1, 15, 1);
                    }
                    if (drawB)
                    {
                        g.DrawRectangle(pens[val], x1, y1 + 14, 15, 1);
                    }
                    if (drawTL)
                    {
                        g.DrawRectangle(pens[val], x1, y1, 1, 1);
                    }
                    if (drawTR)
                    {
                        g.DrawRectangle(pens[val], x1 + 14, y1, 1, 1);
                    }
                    if (drawBL)
                    {
                        g.DrawRectangle(pens[val], x1, y1 + 14, 1, 1);
                    }
                    if (drawBR)
                    {
                        g.DrawRectangle(pens[val], x1 + 14, y1 + 14, 1, 1);
                    }
                }
            }
        }

        public void DrawBreakable(Graphics g, Rectangle region)
        {
            if (Version.IsMF) { DrawBreakableMF(g, region); }
            else { DrawBreakableZM(g, region); }
        }

        private void DrawBreakableMF(Graphics g, Rectangle region)
        {
            int w = clip.width;
            int h = clip.height;
            int xStart = Math.Max(region.X / 16, 0);
            int xEnd = Math.Min(xStart + region.Width / 16 + 2, w);
            int yStart = Math.Max(region.Y / 16, 0);
            int yEnd = Math.Min(yStart + region.Height / 16 + 2, h);

            for (int y = yStart; y < yEnd; y++)
            {
                for (int x = xStart; x < xEnd; x++)
                {
                    ushort clipVal = clip.blocks[x, y];
                    switch (clipVal)
                    {
                        case 0x50:
                        case 0x51:
                        case 0x52:
                        case 0x53:
                        case 0x5B:
                        case 0x5C:
                        case 0x5D:
                        case 0x60:
                        case 0x61:
                        case 0x6C:
                        case 0x6D:  // shot
                            g.DrawImage(genBG, x * 16, y * 16, new Rectangle(160, 16, 16, 16), GraphicsUnit.Pixel);
                            break;
                        case 0x54:
                        case 0x5E:  // missile
                            g.DrawImage(genBG, x * 16, y * 16, new Rectangle(112, 16, 16, 16), GraphicsUnit.Pixel);
                            break;
                        case 0x55:
                        case 0x56:
                        case 0x70:
                        case 0x71:
                        case 0x72:
                        case 0x73:
                        case 0x74:
                        case 0x75:
                        case 0x76:
                        case 0x77:  // bomb
                            g.DrawImage(genBG, x * 16, y * 16, new Rectangle(80, 16, 16, 16), GraphicsUnit.Pixel);
                            break;
                        case 0x57:  // power
                            g.DrawImage(genBG, x * 16, y * 16, new Rectangle(128, 16, 16, 16), GraphicsUnit.Pixel);
                            break;
                        case 0x58:
                        case 0x6B:  // speed
                            g.DrawImage(genBG, x * 16, y * 16, new Rectangle(96, 16, 16, 16), GraphicsUnit.Pixel);
                            break;
                        case 0x59:  // screw
                            g.DrawImage(genBG, x * 16, y * 16, new Rectangle(144, 16, 16, 16), GraphicsUnit.Pixel);
                            break;
                        case 0x5A:  // crumble
                            g.DrawImage(genBG, x * 16, y * 16, new Rectangle(64, 16, 16, 16), GraphicsUnit.Pixel);
                            break;
                        case 0x64:  // missile tank
                            g.DrawImage(genBG, x * 16, y * 16, new Rectangle(128, 0, 16, 8), GraphicsUnit.Pixel);
                            g.DrawImage(genBG, x * 16, y * 16 + 8, new Rectangle(144, 0, 16, 8), GraphicsUnit.Pixel);
                            break;
                        case 0x65:  // energy tank
                            g.DrawImage(genBG, x * 16, y * 16, new Rectangle(160, 0, 16, 8), GraphicsUnit.Pixel);
                            g.DrawImage(genBG, x * 16, y * 16 + 8, new Rectangle(176, 0, 16, 8), GraphicsUnit.Pixel);
                            break;
                        case 0x69:  // power tank
                            g.DrawImage(genBG, x * 16, y * 16, new Rectangle(192, 0, 16, 8), GraphicsUnit.Pixel);
                            g.DrawImage(genBG, x * 16, y * 16 + 8, new Rectangle(208, 0, 16, 8), GraphicsUnit.Pixel);
                            break;
                    }
                }
            }
        }

        private void DrawBreakableZM(Graphics g, Rectangle region)
        {
            int w = clip.width;
            int h = clip.height;
            int xStart = Math.Max(region.X / 16, 0);
            int xEnd = Math.Min(xStart + region.Width / 16 + 2, w);
            int yStart = Math.Max(region.Y / 16, 0);
            int yEnd = Math.Min(yStart + region.Height / 16 + 2, h);

            for (int y = yStart; y < yEnd; y++)
            {
                for (int x = xStart; x < xEnd; x++)
                {
                    ushort clipVal = clip.blocks[x, y];
                    switch (clipVal)
                    {
                        case 0x50:
                        case 0x51:
                        case 0x52:
                        case 0x53:
                        case 0x54:
                        case 0x55:
                        case 0x60:
                        case 0x61:
                        case 0x62:
                        case 0x63:
                        case 0x64:  // shot
                            g.DrawImage(genBG, x * 16, y * 16, new Rectangle(160, 16, 16, 16), GraphicsUnit.Pixel);
                            break;
                        case 0x56:  // crumble
                            g.DrawImage(genBG, x * 16, y * 16, new Rectangle(64, 16, 16, 16), GraphicsUnit.Pixel);
                            break;
                        case 0x57:
                        case 0x67:
                        case 0x70:
                        case 0x71:
                        case 0x72:
                        case 0x73:
                        case 0x74:
                        case 0x75:
                        case 0x76:
                        case 0x77:  // bomb
                            g.DrawImage(genBG, x * 16, y * 16, new Rectangle(80, 16, 16, 16), GraphicsUnit.Pixel);
                            break;
                        case 0x58:
                        case 0x68:  // missile
                            g.DrawImage(genBG, x * 16, y * 16, new Rectangle(112, 16, 16, 16), GraphicsUnit.Pixel);
                            break;
                        case 0x59:
                        case 0x69:  // super
                            g.DrawImage(genBG, x * 16, y * 16, new Rectangle(176, 16, 16, 16), GraphicsUnit.Pixel);
                            break;
                        case 0x5A:
                        case 0x6A:  // speed
                            g.DrawImage(genBG, x * 16, y * 16, new Rectangle(96, 16, 16, 16), GraphicsUnit.Pixel);
                            break;
                        case 0x5B:  // power
                            g.DrawImage(genBG, x * 16, y * 16, new Rectangle(128, 16, 16, 16), GraphicsUnit.Pixel);
                            break;
                        case 0x66:  // slow crumble
                            g.DrawImage(genBG, x * 16, y * 16, new Rectangle(0, 16, 16, 16), GraphicsUnit.Pixel);
                            break;
                        case 0x6B:  // screw
                            g.DrawImage(genBG, x * 16, y * 16, new Rectangle(144, 16, 16, 16), GraphicsUnit.Pixel);
                            break;
                        case 0x6C:  // energy tank
                            g.DrawImage(genBG, x * 16, y * 16, new Rectangle(40, 0, 16, 8), GraphicsUnit.Pixel);
                            g.DrawImage(genBG, x * 16, y * 16 + 8, new Rectangle(56, 0, 16, 8), GraphicsUnit.Pixel);
                            break;
                        case 0x6D:  // missile tank
                            g.DrawImage(genBG, x * 16, y * 16, new Rectangle(8, 0, 16, 8), GraphicsUnit.Pixel);
                            g.DrawImage(genBG, x * 16, y * 16 + 8, new Rectangle(24, 0, 16, 8), GraphicsUnit.Pixel);
                            break;
                        case 0x6E:  // super tank
                            g.DrawImage(genBG, x * 16, y * 16, new Rectangle(104, 0, 16, 8), GraphicsUnit.Pixel);
                            g.DrawImage(genBG, x * 16, y * 16 + 8, new Rectangle(120, 0, 16, 8), GraphicsUnit.Pixel);
                            break;
                        case 0x6F:  // power tank
                            g.DrawImage(genBG, x * 16, y * 16, new Rectangle(72, 0, 16, 8), GraphicsUnit.Pixel);
                            g.DrawImage(genBG, x * 16, y * 16 + 8, new Rectangle(88, 0, 16, 8), GraphicsUnit.Pixel);
                            break;
                    }
                }
            }
        }

        public void DrawValues(Graphics g, Rectangle region)
        {
            int w = clip.width;
            int h = clip.height;
            int xStart = Math.Max(region.X / 16, 0);
            int xEnd = Math.Min(xStart + region.Width / 16 + 2, w);
            int yStart = Math.Max(region.Y / 16, 0);
            int yEnd = Math.Min(yStart + region.Height / 16 + 2, h);

            Bitmap nums = Properties.Resources.clipNums;

            for (int y = yStart; y < yEnd; y++)
            {
                for (int x = xStart; x < xEnd; x++)
                {
                    int u = x * 16;
                    int v = y * 16;
                    ushort clipVal = clip.blocks[x, y];
                    // fill with color
                    SolidBrush sb = new SolidBrush(GetColorFromHue(clipVal));
                    g.FillRectangle(sb, u, v, 16, 16);
                    // draw value
                    int a = (clipVal >> 4) * 7;
                    int b = (clipVal & 0xF) * 7;
                    g.DrawImage(nums, new Rectangle(u + 2, v + 4, 7, 9), new Rectangle(a, 0, 7, 9), GraphicsUnit.Pixel);
                    g.DrawImage(nums, new Rectangle(u + 8, v + 4, 7, 9), new Rectangle(b, 0, 7, 9), GraphicsUnit.Pixel);
                }
            }
        }

        private Color GetColorFromHue(int val)
        {
            int x = (val % 43) * 6;
            switch (val % 6)
            {
                case 0:
                    return Color.FromArgb(64, 255, x, 0);
                case 1:
                    return Color.FromArgb(64, 255 - x, 255, 0);
                case 2:
                    return Color.FromArgb(64, 0, 255, x);
                case 3:
                    return Color.FromArgb(64, 0, 255 - x, 255);
                case 4:
                    return Color.FromArgb(64, x, 0, 255);
                case 5:
                    return Color.FromArgb(64, 255, 0, 255 - x);
                default:
                    throw new ArgumentException();
            }
        }

        public void ResizeClip(byte w, byte h)
        {
            clipType = new byte[w, h];
        }

        public void ConvertClip()
        {
            // get list of clipdata values
            string[] lines = Version.ConvertClipdata;

            ushort[] clipVals = new ushort[0x100];
            for (int i = 0; i < 0x100; i++)
            {
                clipVals[i] = Convert.ToUInt16(lines[i].Substring(3, 2), 16);
            }

            // convert all blocks in the room
            for (int y = 0; y < clip.height; y++)
            {
                for (int x = 0; x < clip.width; x++)
                {
                    ushort val = clip.blocks[x, y];
                    clip.blocks[x, y] = clipVals[val];
                }
            }
        }


    }
}
