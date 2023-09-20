using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace mage
{
    public class EnemyList
    {
        // properties
        public int Count { get { return enemies.Count; } }
        public bool Edited { get; set; }
        public byte AreaID { get; private set; }
        public byte RoomID { get; private set; }

        // data
        private List<Enemy> enemies;
        public Enemy this[int i]
        {
            get { return enemies[i]; }
            set { enemies[i] = value; }
        }

        // meta
        public int number;
        public int origLen;
        private int pointer;      

        // constructor
        public EnemyList(ByteStream romStream, byte areaID, byte roomID, int number)
        {
            this.AreaID = areaID;
            this.RoomID = roomID;
            this.number = number;
            Edited = false;

            GetEnemyData(romStream);
        }

        private int GetPointer(ByteStream romStream)
        {
            int offset = romStream.ReadPtr(Version.AreaHeaderOffset + AreaID * 4) + (RoomID * 0x3C);
            return offset + 0x20 + number * 8;
        }

        private void GetEnemyData(ByteStream romStream)
        {
            // get sprite data
            enemies = new List<Enemy>();
            pointer = GetPointer(romStream);
            int offset = romStream.ReadPtr(pointer);
            romStream.Seek(offset);

            for (int i = 0; i < 24; i++)
            {
                byte yPos = romStream.Read8();
                byte xPos = romStream.Read8();
                byte prop = romStream.Read8();

                if (yPos == 0xFF && xPos == 0xFF && prop == 0xFF) { break; }

                Enemy rs = new Enemy();
                rs.xPos = xPos;
                rs.yPos = yPos;
                rs.prop = prop;
                enemies.Add(rs);
            }

            origLen = (enemies.Count + 1) * 3;
        }

        public SpriteGFX SetEnemyBounds(Enemy en, Spriteset spriteset, VramObj vramObj)
        {
            byte spriteID = spriteset.GetSpriteID(en.SlotNum);
            int gfxRow = spriteset.GetGfxRow(en.SlotNum);
            SpriteGFX sp = new SpriteGFX(vramObj, gfxRow, spriteID, true);

            int xPos = en.xPos * 16;
            int yPos = en.yPos * 16;

            // draw sprite
            if (sp.previewImg != null && en.prop >= 0x10)
            {
                Point corner = new Point(xPos + sp.xOffset + 8, yPos + sp.yOffset + 16);

                int xStart = Math.Min(xPos, corner.X);
                int yStart = Math.Min(yPos, corner.Y);
                int xEnd = Math.Max(xPos + 16, corner.X + sp.previewImg.Width);
                int yEnd = Math.Max(yPos + 16, corner.Y + sp.previewImg.Height);
                en.bounds = new Rectangle(xStart, yStart, xEnd - xStart, yEnd - yStart);
            }
            else
            {
                en.bounds = new Rectangle(xPos, yPos, 16, 16);
            }

            return sp;
        }

        public void DrawSprites(Rectangle rect, BitmapData dstData, Spriteset spriteset, VramObj vramObj)
        {
            foreach (Enemy en in enemies)
            {
                SpriteGFX sp = SetEnemyBounds(en, spriteset, vramObj);

                if (en.bounds.IntersectsWith(rect))
                {
                    // draw sprite
                    if (sp.previewImg != null && en.prop >= 0x10)
                    {
                        int x = en.xPos * 16 + sp.xOffset + 8;
                        int y = en.yPos * 16 + sp.yOffset + 16;

                        if (Version.IsMF && en.prop >= 0x90)
                        {
                            // make image semi-transparent
                            Draw.SemiCombine15bpp(sp.previewImg, dstData, x, y);
                        }
                        else
                        {
                            Draw.Combine15bpp(sp.previewImg, dstData, x, y);
                        }
                    }
                }
            }
        }

        public void DrawOutlines(Graphics g, Rectangle rect)
        {
            Pen p = Pens.Lime;
            foreach (Enemy en in enemies)
            {
                if (en.bounds.IntersectsWith(rect))
                {
                    g.DrawRectangle(p, new Rectangle(en.xPos * 16, en.yPos * 16, 15, 15));
                    g.DrawRectangle(p, new Rectangle(en.xPos * 16 + 1, en.yPos * 16 + 1, 13, 13));
                }
            }
        }

        public int FindEnemy(Point p)
        {
            int num = 0;
            foreach (Enemy en in enemies)
            {
                if (en.xPos == p.X && en.yPos == p.Y)
                {
                    return num;
                }
                num++;
            }
            return -1;
        }

        public void AddEnemy(Enemy en, int num)
        {
            Edited = true;
            enemies.Insert(num, en);
        }

        public void RemoveEnemy(int num)
        {
            Edited = true;
            enemies.RemoveAt(num);
        }

        public void Export(ByteStream dst)
        {
            foreach (Enemy rs in enemies)
            {
                dst.Write8(rs.yPos);
                dst.Write8(rs.xPos);
                dst.Write8(rs.prop);
            }
            dst.Write8(0xFF);
            dst.Write8(0xFF);
            dst.Write8(0xFF);
        }

        public void Import(ByteStream src)
        {
            enemies = new List<Enemy>();

            for (int i = 0; i < 24; i++)
            {
                byte yPos = src.Read8();
                byte xPos = src.Read8();
                byte prop = src.Read8();

                if (yPos == 0xFF && xPos == 0xFF && prop == 0xFF) { break; }

                Enemy rs = new Enemy();
                rs.xPos = xPos;
                rs.yPos = yPos;
                rs.prop = prop;
                enemies.Add(rs);
            }
        }

        public void Write(ByteStream dst, bool reset)
        {
            ByteStream dataToWrite = new ByteStream();

            foreach (Enemy rs in enemies)
            {
                dataToWrite.Write8(rs.yPos);
                dataToWrite.Write8(rs.xPos);
                dataToWrite.Write8(rs.prop);
            }
            dataToWrite.Write8(0xFF);
            dataToWrite.Write8(0xFF);
            dataToWrite.Write8(0xFF);

            dst.Write(dataToWrite, origLen, pointer, false);

            if (reset)
            {
                origLen = dataToWrite.Length;
            }
        }

        public void Clear()
        {
            Edited = true;
            enemies.Clear();
        }
    }
}
