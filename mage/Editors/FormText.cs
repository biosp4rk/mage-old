using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace mage
{
    public partial class FormText : Form, Editor
    {
        // fields
        private struct TextList
        {
            public string type;
            public int offset;
            public int count;
        }
        private List<TextList> textLists;

        private List<ushort> textVals;
        private int prevLen;
        private Bitmap textImg;
        private Palette palette;
        private string display;

        private Dictionary<ushort, string> chars;
        private Dictionary<string, ushort> codes;

        private FormMain main;
        private ByteStream romStream;
        private Status status;
        private bool loading;

        // constructor
        public FormText(FormMain main)
        {
            InitializeComponent();

            this.main = main;
            this.romStream = ROM.Stream;

            Initialize();
        }

        public void UpdateEditor()
        {
            palette = new Palette(romStream, Version.TextPaletteOffset, 1);
            pictureBox_palette.Image = palette.Draw(15, 0, 1);
            DrawText();
        }

        private void Initialize()
        {
            status = new Status(statusLabel_changes, button_apply);

            // initialize dictionaries
            chars = new Dictionary<ushort, string>();
            codes = new Dictionary<string, ushort>();

            string[] charList = Version.CharacterList;
            foreach (string s in charList)
            {
                string[] items = s.Split('\t');
                ushort val = Convert.ToUInt16(items[0], 16);

                chars.Add(val, items[1]);
                if (!codes.ContainsKey(items[1]))
                {
                    codes.Add(items[1], val);
                }
            }

            // initialize text options
            string gameCode = Version.GameCode;
            string[] lines = Properties.Resources.textLists.Split(
                new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            int index = 0;
            while (!lines[index].Contains(gameCode))
            {
                index++;
            }
            index++;

            textLists = new List<TextList>();
            while (index < lines.Length)
            {
                MatchCollection mc = Regex.Matches(lines[index++], @"[^,]+");
                if (mc.Count != 3) { break; }

                TextList tl;
                tl.offset = Convert.ToInt32(mc[0].Value, 16);
                tl.count = Convert.ToInt32(mc[1].Value, 16);
                tl.type = mc[2].Value;
                textLists.Add(tl);
            }

            // fill combo boxes
            foreach (TextList tl in textLists)
            {
                comboBox_text.Items.Add(tl.type);
            }
            comboBox_language.Items.AddRange(Version.Languages);

            // get palette and draw
            palette = new Palette(romStream, Version.TextPaletteOffset, 1);
            pictureBox_palette.Image = palette.Draw(15, 0, 1);
            
            comboBox_language.SelectedIndex = 2;
            comboBox_text.SelectedIndex = 0;
        }

        private void GetText()
        {
            // get offset
            int type = comboBox_text.SelectedIndex;
            int language = comboBox_language.SelectedIndex;
            int number = comboBox_number.SelectedIndex;

            int offset = romStream.ReadPtr(textLists[type].offset + language * 4);
            offset = romStream.ReadPtr(offset + number * 4);
            textBox_offsetVal.Text = Hex.ToString(offset);

            // get text
            textVals = new List<ushort>();
            while (true)
            {
                ushort val = romStream.Read16(offset);
                textVals.Add(val);
                if (val == 0xFF00) { break; }
                offset += 2;
            }
            prevLen = textVals.Count;

            DrawText();
            DisplayText();
            status.LoadNew();
        }

        private void DisplayText()
        {
            display = "";
            foreach (ushort val in textVals)
            {
                if (chars.ContainsKey(val))
                {
                    display += chars[val];
                }
                else
                {
                    int ctrl = val >> 8;
                    if (ctrl == 0x80) { display += "[INDENT=" + Hex.ToString((byte)val) + "]"; }
                    else if (ctrl == 0x81) { display += "[COLOR=" + Hex.ToString((byte)val % 0xF) + "]"; }
                    else if (val >> 12 == 9) { display += "[MUSIC=" + Hex.ToString(val & 0xFFF) + "]"; }
                    else if (ctrl == 0xE1) { display += "[DELAY=" + Hex.ToString((byte)val) + "]"; }
                    else if (ctrl == 0xFD) { display += "[NEXT]\r\n"; }
                    else if (ctrl == 0xFE)
                    {
                        if (checkBox_newLine.Checked) { display += "[NEWLINE]"; }
                        else { display += "\r\n"; }
                    }
                    else if (val >> 8 == 0xFF) { break; }
                    else { display += @"[\x" + Hex.ToString(val) + "]"; }
                }
            }

            // set text
            loading = true;
            textBox.Text = display;
            loading = false;
        }

        private unsafe void DrawText()
        {
            // get number of rows of text
            int rows = 1;
            foreach (ushort val in textVals)
            {
                if (val == 0xFB00 || val == 0xFD00 || val == 0xFE00) { rows++; }
            }

            // draw text
            textImg = new Bitmap(240, rows * 16, PixelFormat.Format8bppIndexed);
            palette.SetBitmapPalette(textImg, 0, 1);
            BitmapData imgData = textImg.LockBits(new Rectangle(0, 0, 240, rows * 16), ImageLockMode.WriteOnly, textImg.PixelFormat);

            int gfxOffset = Version.TextGfxOffset;
            int charWidthsOffset = Version.CharacterWidthsOffset;
            Point pos = new Point(8, 0);

            byte color, change;
            if (Version.IsMF) { color = change = 2; }
            else { color = change = 4; }

            byte* startPtr = (byte*)imgData.Scan0;
            byte* imgPtr;

            foreach (ushort val in textVals)
            {
                if (val < 0x8000)
                {
                    imgPtr = startPtr + pos.Y * 240 + pos.X;

                    int cw;
                    if (val < 0x4A0)
                    {
                        cw = romStream.Read8(charWidthsOffset + val);
                    }
                    else
                    {
                        cw = 10;
                    }

                    int w = (int)Math.Ceiling(cw / 8.0);
                    if (pos.X > 240 - w * 8) { continue; }
                    pos.X += cw;

                    for (int y = 0; y < 2; y++)  // for each tile down
                    {
                        int tOffset = gfxOffset + val * 0x20 + y * 0x400;

                        for (int x = 0; x < w; x++)  // for each tile across
                        {
                            for (int r = 0; r < 8; r++)  // for each row in tile
                            {
                                for (int pp = 0; pp < 4; pp++)  // for each pixel pair
                                {
                                    byte c = romStream.Read8(tOffset++);

                                    if ((c & 0xF) == change) { *imgPtr++ = color; }
                                    else { *imgPtr++ = (byte)(c & 0xF); }

                                    if ((c >> 4) == change) { *imgPtr++ = color; }
                                    else { *imgPtr++ = (byte)(c >> 4); }
                                }
                                imgPtr += 232;  // 240 - 8
                            }
                            imgPtr -= 1912;  // 240 * 8 - 8
                        }
                        imgPtr += (1920 - w * 8);  // 240 * 8 - w * 8
                    }
                }
                else if (val >> 8 == 0x80)
                {
                    pos.X += val & 0xFF;
                }
                else if (val >> 8 == 0x81)
                {
                    if (Version.IsMF) { color = (byte)((change + (val & 0xFF) * 2) % 0xF); }
                    else { color = (byte)Math.Max(4, (val & 0xFF) % 0xF); }
                }
                else if (val == 0xFB00 || val == 0xFD00 || val == 0xFE00)
                {
                    pos.X = 8;
                    pos.Y += 16;
                }
            }

            textImg.UnlockBits(imgData);

            pictureBox_text.BackColor = palette.GetOpaqueColor(0, 0);
            pictureBox_text.Image = textImg;
            pictureBox_text.Size = textImg.Size;
        }

        private bool ParseText()
        {
            textVals = new List<ushort>();
            string text = textBox.Text;
            int i = 0;

            try
            {
                for (; i < text.Length; i++)
                {
                    // bracketed expression
                    if (text[i] == '[')
                    {
                        string str = "[";
                        do
                        {
                            str += text[++i];
                        } while (text[i] != ']');

                        if (str[1] == '\\')  // raw char data
                        {
                            string tmp = str.Substring(3, str.Length - 4);
                            textVals.Add(Hex.ToUshort(tmp));
                        }
                        else if (codes.ContainsKey(str))  // special label
                        {
                            textVals.Add(codes[str]);
                        }
                        else if (str == "[NEWLINE]") { textVals.Add(0xFE00); }
                        else if (str == "[NEXT]")
                        {
                            textVals.Add(0xFD00);
                            // check for optional newline after [NEXT]
                            if (i + 2 < text.Length && text[i + 1] == '\r' && text[i + 2] == '\n') { i += 2; }
                        }
                        else  // label with value
                        {
                            string[] strs = str.Substring(1, str.Length - 2).Split('=');
                            if (strs[0] == "COLOR") { textVals.Add((ushort)(0x8100 + Hex.ToByte(strs[1]))); }
                            else if (strs[0] == "INDENT") { textVals.Add((ushort)(0x8000 + Hex.ToByte(strs[1]))); }
                            else if (strs[0] == "MUSIC") { textVals.Add((ushort)(0x9000 + Hex.ToUshort(strs[1]))); }
                            else if (strs[0] == "DELAY") { textVals.Add((ushort)(0xE100 + Hex.ToUshort(strs[1]))); }
                            else
                            {
                                //MessageBox.Show("Text could not be parsed.\r\nThe contents of the brackets at character " 
                                //    + Hex.ToString(i) + " are not valid.", "Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                MessageBox.Show(string.Format(Properties.Resources.formText_BracketNotValid, Hex.ToString(i)),
                                    Properties.Resources.formText_ParsingErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                    }
                    // new line
                    else if (text[i] == '\r')
                    {
                        if (text[++i] == '\n') { textVals.Add(0xFE00); }
                        else
                        {
                            //MessageBox.Show("Text could not be parsed.\r\nInvalid newline at character " 
                            //    + Hex.ToString(i) + ".", "Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show(string.Format(Properties.Resources.formText_InvalidNewLine, Hex.ToString(i)),
                                Properties.Resources.formText_ParsingErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    // escaped character
                    else if (text[i] == '\\') { textVals.Add(codes[text[++i].ToString()]); }
                    // normal character
                    else { textVals.Add(codes[text[i].ToString()]); }
                }

                textVals.Add(0xFF00);
            }
            catch (IndexOutOfRangeException)
            {
                //MessageBox.Show("Text could not be parsed.\r\nMake sure brackets are closed.", 
                //    "Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(Properties.Resources.formText_BracketNotClose,
                    Properties.Resources.formText_ParsingErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (KeyNotFoundException)
            {
                //MessageBox.Show("Text could not be parsed.\r\nCharacter " 
                //    + Hex.ToString(i) + " was not recognized.", "Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(string.Format(Properties.Resources.formText_CharNotRecognize, Hex.ToString(i)),
                    Properties.Resources.formText_ParsingErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (FormatException)
            {
                //MessageBox.Show("Text could not be parsed.\r\nThe value starting at character " 
                //    + Hex.ToString(i) + " is not valid.", "Parsing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(string.Format(Properties.Resources.formText_CharNotValid, Hex.ToString(i)),
                    Properties.Resources.formText_ParsingErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void comboBox_text_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = textLists[comboBox_text.SelectedIndex].count;

            comboBox_number.Items.Clear();
            for (int i = 0; i < count; i++)
            {
                comboBox_number.Items.Add(Hex.ToString(i));
            }

            comboBox_number.SelectedIndex = 0;
        }

        private void comboBox_language_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_text.SelectedIndex == -1) { return; }
            GetText();
        }

        private void comboBox_number_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetText();
        }

        private void checkBox_wordWrap_CheckedChanged(object sender, EventArgs e)
        {
            textBox.WordWrap = checkBox_wordWrap.Checked;
        }

        private void checkBox_newLine_CheckedChanged(object sender, EventArgs e)
        {
            if (ParseText()) { DisplayText(); }
        }

        private void button_editPalette_Click(object sender, EventArgs e)
        {
            FormPalette form = new FormPalette(main, Version.TextPaletteOffset, 1);
            form.Show();
        }

        private void button_editGfx_Click(object sender, EventArgs e)
        {
            FormGraphics form = new FormGraphics(main, Version.TextGfxOffset, 32, 32, Version.TextPaletteOffset);
            form.Show();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (ParseText()) { DrawText(); }
        }

        private void textBox_MouseClick(object sender, MouseEventArgs e)
        {
            label_pos.Text = Hex.ToString(textBox.SelectionStart);
        }

        private void textBox_KeyUp(object sender, KeyEventArgs e)
        {
            label_pos.Text = Hex.ToString(textBox.SelectionStart);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (loading) { return; }
            label_pos.Text = Hex.ToString(textBox.SelectionStart);
            status.ChangeMade();
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            if (!ParseText()) { return; }

            // get data
            ByteStream dataToWrite = new ByteStream();

            foreach (ushort val in textVals)
            {
                dataToWrite.Write16(val);
            }

            // get pointer
            int type = comboBox_text.SelectedIndex;
            int language = comboBox_language.SelectedIndex;
            int number = comboBox_number.SelectedIndex;
            int pointer = romStream.ReadPtr(textLists[type].offset + language * 4) + number * 4;
            
            // write new data
            romStream.Write(dataToWrite, prevLen * 2, pointer, false);

            // set new length
            prevLen = textVals.Count;

            DrawText();
            status.Save();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
