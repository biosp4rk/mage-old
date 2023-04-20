using System;
using System.Collections.Generic;
using System.Text;

namespace mage
{
    public enum Corrupt { BG0, BG1, BG2, BG3, Clip, Enemy0, Enemy1, Enemy2, Scrolls, 
        RLEgfx, LZ77gfx, Minimap };

    public class CorruptDataException : Exception
    {
        public Corrupt DataType { get; private set; }

        public override string Message
        {
            get
            {
                switch (DataType)
                {
                    /*case Corrupt.BG0:
                        return "BG0 data was corrupt.";
                    case Corrupt.BG1:
                        return "BG1 data was corrupt.";
                    case Corrupt.BG2:
                        return "BG2 data was corrupt.";
                    case Corrupt.BG3:
                        return "BG3 data was corrupt.";
                    case Corrupt.Clip:
                        return "Clipdata was corrupt.";
                    case Corrupt.Enemy0:
                        return "Room sprites (default) data was corrupt.";
                    case Corrupt.Enemy1:
                        return "Room sprites (first) data was corrupt.";
                    case Corrupt.Enemy2:
                        return "Room sprites (second) data was corrupt.";
                    case Corrupt.Scrolls:
                        return "Room scrolls data was corrupt.";
                    case Corrupt.RLEgfx:
                        return "RLE graphics were corrupt.";
                    case Corrupt.LZ77gfx:
                        return "LZ77 graphics were corrupt.";
                    case Corrupt.Minimap:
                        return "Minimap data was corrupt.";
                    default:
                        return "";*/
                    case Corrupt.BG0:
                        return Properties.Resources.CorruptDataExceprion_BG0Text;
                    case Corrupt.BG1:
                        return Properties.Resources.CorruptDataExceprion_BG1Text;
                    case Corrupt.BG2:
                        return Properties.Resources.CorruptDataExceprion_BG2Text;
                    case Corrupt.BG3:
                        return Properties.Resources.CorruptDataExceprion_BG3Text;
                    case Corrupt.Clip:
                        return Properties.Resources.CorruptDataExceprion_ClipText;
                    case Corrupt.Enemy0:
                        return Properties.Resources.CorruptDataExceprion_Sprite0Text;
                    case Corrupt.Enemy1:
                        return Properties.Resources.CorruptDataExceprion_Sprite1Text;
                    case Corrupt.Enemy2:
                        return Properties.Resources.CorruptDataExceprion_Sprite2Text;
                    case Corrupt.Scrolls:
                        return Properties.Resources.CorruptDataExceprion_ScrollText;
                    case Corrupt.RLEgfx:
                        return Properties.Resources.CorruptDataExceprion_RLEText;
                    case Corrupt.LZ77gfx:
                        return Properties.Resources.CorruptDataExceprion_LZ77Text;
                    case Corrupt.Minimap:
                        return Properties.Resources.CorruptDataExceprion_MinimapText;
                    default:
                        return "";
                }
            }
        }

        public CorruptDataException(Corrupt dataType)
        {
            DataType = dataType;
        }

        public void TryHandle(int a, int r)
        {
            ByteStream romStream = ROM.Stream;

            switch (DataType)
            {
                case Corrupt.BG0:
                    Header.SetValue(a, r, HeaderData.BG0prop, 0);
                    break;
                case Corrupt.BG1:
                    Header.SetValue(a, r, HeaderData.BG1prop, 0);
                    break;
                case Corrupt.BG2:
                    Header.SetValue(a, r, HeaderData.BG2prop, 0);
                    break;
                case Corrupt.BG3:
                    int BG3offset = Add.BlankBgLZ77();
                    Header.SetValue(a, r, HeaderData.BG3ptr, BG3offset);
                    break;
                case Corrupt.Clip:
                    // get width and height
                    int BG1offset = Header.GetValue(a, r, HeaderData.BG1ptr);
                    byte w = romStream.Read8(BG1offset);
                    byte h = romStream.Read8(BG1offset + 1);
                    // get blank clipdata
                    int clipOffset = Add.BlankBgRLE(w, h);
                    Header.SetValue(a, r, HeaderData.ClipPtr, clipOffset);
                    break;
                case Corrupt.RLEgfx:
                    int tsNum1 = Header.GetValue(a, r, HeaderData.Tileset);
                    int rleGfxPtr = Version.TilesetOffset + tsNum1 * 0x14;
                    int rleGfxOffset = Add.BlankLZ77Gfx();
                    romStream.WritePtr(rleGfxPtr, rleGfxOffset);
                    break;
                case Corrupt.LZ77gfx:
                    int tsNum2 = Header.GetValue(a, r, HeaderData.Tileset);
                    int lz77gfxPtr = Version.TilesetOffset + tsNum2 * 0x14 + 8;
                    int lz77gfxOffset = Add.BlankLZ77Gfx();
                    romStream.WritePtr(lz77gfxPtr, lz77gfxOffset);
                    break;
            }
        }

    }
}
