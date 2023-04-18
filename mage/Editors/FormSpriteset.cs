using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace mage
{
    public partial class FormSpriteset : Form, Editor
    {
        // fields
        private Spriteset spriteset;
        private List<byte> spriteIDs;
        private List<byte> gfxRows;
        private List<SpriteGFX> spriteGfx;

        private VramObj vramObj;
        private Bitmap gfxImg;
        private Bitmap paletteImg;
        private Label[] gfxLabels;
        private Label[] palLabels;
        private bool updateGraphics;

        private FormMain main;
        private ByteStream romStream;
        private Status status;
        private bool loading;

        // constructor
        public FormSpriteset(FormMain main, byte spritesetNum)
        {
            InitializeComponent();

            this.main = main;
            this.romStream = ROM.Stream;

            Initialize(spritesetNum);
        }

        public void UpdateEditor()
        {
            // assumes that only graphics are changed, not sprite list
            if (!status.UnsavedChanges)
            {
                LoadSpriteset();
            }
        }

        private void Initialize(byte spritesetNum)
        {
            status = new Status(statusLabel_changes, button_apply);

            // labels
            gfxLabels = new Label[] { label_gfx0, label_gfx1, label_gfx2, label_gfx3, label_gfx4, label_gfx5, label_gfx6, label_gfx7 };
            palLabels = new Label[] { label_pal0, label_pal1, label_pal2, label_pal3, label_pal4, label_pal5, label_pal6, label_pal7 };

            // number of sprites
            byte numOfSprites = Version.NumOfSprites1;
            for (int i = 0x10; i < numOfSprites; i++)
            {
                comboBox_sprite.Items.Add(Hex.ToString(i));
            }

            // number of spritesets
            byte numOfSpritesets = Version.NumOfSpritesets;
            for (int i = 0; i < numOfSpritesets; i++)
            {
                comboBox_spriteset.Items.Add(Hex.ToString(i));
            }
            if (spritesetNum > numOfSpritesets) { comboBox_spriteset.SelectedIndex = numOfSpritesets - 1; }
            else { comboBox_spriteset.SelectedIndex = spritesetNum; }
        }

        private void comboBox_spriteset_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get spriteset and list of sprites
            byte ss = (byte)comboBox_spriteset.SelectedIndex;
            spriteset = ROM.LoadSpriteset(ss);
            LoadSpriteset();

            // show offset
            textBox_spritesetOffsetVal.Text = Hex.ToString(spriteset.Offset);

            status.LoadNew();
        }

        private void LoadSpriteset()
        {
            loading = true;

            spriteIDs = spriteset.spriteIDs;
            gfxRows = spriteset.gfxRows;

            vramObj = new VramObj(spriteset);
            spriteGfx = new List<SpriteGFX>();
            for (int i = 0; i < spriteIDs.Count; i++)
            {
                byte spID = spriteIDs[i];
                byte gfxRow = gfxRows[i];
                SpriteGFX sp = new SpriteGFX(vramObj, gfxRow, spID, true);
                spriteGfx.Add(sp);
            }

            // set number of slots
            comboBox_slot.Items.Clear();
            for (int i = 0; i < spriteIDs.Count; i++)
            {
                comboBox_slot.Items.Add(Hex.ToString(i));
            }
            if (spriteIDs.Count > 0)
            {
                comboBox_slot.SelectedIndex = 0;
            }
            else
            {
                comboBox_slot.SelectedIndex = -1;
                comboBox_slot.Text = "";
            }

            NumOfSlotsChanged();
            DrawGraphics();
            loading = false;
        }

        private void comboBox_slot_SelectedIndexChanged(object sender, EventArgs e)
        {
            loading = true;
            SlotChanged();
            loading = false;
        }

        private void SlotChanged()
        {
            int slot = comboBox_slot.SelectedIndex;
            updateGraphics = false;
            comboBox_sprite.SelectedIndex = spriteIDs[slot] - 0x10;
            comboBox_gfxRow.SelectedIndex = gfxRows[slot];
            updateGraphics = true;
            DrawPreview();
        }

        private void DrawGraphics()
        {
            // find height of gfx and palette
            int rows = 0;
            for (int i = 0; i < gfxRows.Count; i++)
            {
                int temp = (gfxRows[i] & 7) + spriteGfx[i].NumGfxRows;
                if (temp > rows) { rows = temp; }
            }

            rows = Math.Min(rows, 8);
            if (rows == 0)
            {
                pictureBox_tiles.Image = null;
                pictureBox_palette.Image = null;
                pictureBox_preview.Image = null;
                return;
            }

            // draw gfx
            gfxImg = vramObj.DrawSpriteset(rows, spriteIDs, gfxRows, spriteGfx);

            // palette image
            paletteImg = vramObj.palette.Draw(15, 8, rows);

            // display
            pictureBox_tiles.Image = gfxImg;
            pictureBox_palette.Image = paletteImg;
        }

        private void DrawPreview()
        {
            // preview image
            SpriteGFX curr = spriteGfx[comboBox_slot.SelectedIndex];
            if (curr.previewImg == null)
            {
                pictureBox_preview.Size = new Size();
                pictureBox_preview.Image = null;
            }
            else
            {
                pictureBox_preview.Size = curr.previewImg.Size;
                pictureBox_preview.Image = curr.previewImg;
            }
        }

        private void UpdateBoldLabel()
        {
            for (int i = 0; i < 8; i++)
            {
                gfxLabels[i].Font = new Font(gfxLabels[i].Font, FontStyle.Regular);
                palLabels[i].Font = new Font(gfxLabels[i].Font, FontStyle.Regular);
            }

            int gfxSlot = comboBox_gfxRow.SelectedIndex;
            if (gfxSlot >= 0 && gfxSlot < 8)
            {
                gfxLabels[gfxSlot].Font = new Font(gfxLabels[gfxSlot].Font, FontStyle.Bold);
                palLabels[gfxSlot].Font = new Font(gfxLabels[gfxSlot].Font, FontStyle.Bold);
            }
        }

        private void NumOfSlotsChanged()
        {
            if (spriteIDs.Count == 0)
            {
                comboBox_sprite.SelectedIndex = -1;
                comboBox_gfxRow.SelectedIndex = -1;
                comboBox_slot.Enabled = false;
                button_addSlot.Enabled = true;
                button_removeSlot.Enabled = false;
                groupBox_edit.Enabled = false;
            }
            else
            {
                comboBox_slot.Enabled = true;
                button_addSlot.Enabled = spriteIDs.Count < 0xF;
                button_removeSlot.Enabled = true;
                groupBox_edit.Enabled = true;
            }
        }

        private void button_addSlot_Click(object sender, EventArgs e)
        {
            spriteIDs.Add(0x12);
            gfxRows.Add(0);
            SpriteGFX sp = new SpriteGFX(vramObj, 0, 0x12, true);
            spriteGfx.Add(sp);

            comboBox_slot.Items.Add(Hex.ToString(spriteIDs.Count - 1));
            comboBox_slot.SelectedIndex = spriteIDs.Count - 1;
            NumOfSlotsChanged();
            DrawGraphics();
            status.ChangeMade();
        }

        private void button_removeSlot_Click(object sender, EventArgs e)
        {
            int slot = comboBox_slot.SelectedIndex;
            spriteIDs.RemoveAt(slot);
            gfxRows.RemoveAt(slot);
            spriteGfx.RemoveAt(slot);

            if (spriteIDs.Count > 0)
            {
                slot = Math.Min(spriteIDs.Count - 1, slot);
                if (slot == comboBox_slot.SelectedIndex)
                {
                    SlotChanged();
                }
                else
                {
                    comboBox_slot.SelectedIndex = slot;
                }
            }

            comboBox_slot.Items.RemoveAt(spriteIDs.Count);
            DrawGraphics();
            NumOfSlotsChanged();
            status.ChangeMade();
        }

        private void button_editSprite_Click(object sender, EventArgs e)
        {
            byte spriteID = (byte)(comboBox_sprite.SelectedIndex + 0x10);
            FormSprite form = new FormSprite(main, spriteID);
            form.Show();
        }

        private void comboBox_sprite_SelectedIndexChanged(object sender, EventArgs e)
        {
            int slot = comboBox_slot.SelectedIndex;
            if (slot == -1) { return; }

            if (!loading)
            {
                byte spriteID = (byte)(comboBox_sprite.SelectedIndex + 0x10);
                spriteIDs[slot] = spriteID;
                vramObj = new VramObj(spriteset);
                SpriteGFX sp = new SpriteGFX(vramObj, gfxRows[slot], spriteID, true);
                spriteGfx[slot] = sp;
            }

            if (updateGraphics)
            {
                DrawGraphics();
                DrawPreview();
            }

            if (!loading) { status.ChangeMade(); }
        }

        private void comboBox_gfxRow_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBoldLabel();
            int gfxSlot = comboBox_gfxRow.SelectedIndex;
            if (gfxSlot == -1) { return; }

            int slot = comboBox_slot.SelectedIndex;
            gfxRows[slot] = (byte)gfxSlot;
            vramObj = new VramObj(spriteset);
            SpriteGFX sp = new SpriteGFX(vramObj, gfxRows[slot], spriteIDs[slot], true);
            spriteGfx[slot] = sp;

            if (updateGraphics)
            {
                DrawGraphics();
                DrawPreview();
            }

            if (!loading) { status.ChangeMade(); }
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            // copy lists to spriteset
            spriteset.spriteIDs = spriteIDs;
            spriteset.gfxRows = gfxRows;
            ROM.SaveSpriteset(spriteset);

            // update current room
            if (spriteset.number == main.SpritesetNum)
            {
                main.ReloadRoom(false);
            }

            // check for sufficient graphics slots
            List<int> overlapping = new List<int>();
            for (int slot = 0; slot < spriteIDs.Count; slot++)
            {
                int gfxSlot = gfxRows[slot];
                if (gfxSlot == 8) { continue; }
                gfxSlot &= 7;
                
                int end = gfxSlot + spriteGfx[slot].NumGfxRows;
                if (end > 8)
                {
                    //MessageBox.Show("There are not enough graphics rows for the sprite in slot " + slot +
                    //    ". It may not appear correctly in-game.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show(string.Format(Properties.Resources.formSpriteset_NoEnoughRows, slot),
                        Properties.Resources.form_WarningMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // check for overlapping graphics
                else
                {
                    for (int s = 0; s < spriteIDs.Count; s++)
                    {
                        if (overlapping.Contains(s)) { continue; }

                        int t1 = gfxRows[s];
                        int t2 = t1 + spriteGfx[s].NumGfxRows - 1;
                        if ((t1 >= gfxSlot && t1 < end) || (t2 >= gfxSlot && t2 < end))
                        {
                            if (spriteGfx[slot].GfxOffset == spriteGfx[s].GfxOffset) { continue; }
                            overlapping.Add(slot);
                            //MessageBox.Show("The graphics of the sprite in slot " + slot + " overlap the graphics of the sprite in slot " + s
                            //    + ". One of them may not appear correctly in-game.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            MessageBox.Show(string.Format(Properties.Resources.formSpriteset_SpriteOverlap, slot, s),
                                Properties.Resources.form_WarningMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                    }
                }
            }

            status.Save();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void statusStrip_importRaw_Click(object sender, EventArgs e)
        {
            OpenFileDialog openRaw = new OpenFileDialog();
            //openRaw.Filter = "All files (*.*)|*.*";
            openRaw.Filter = Properties.Resources.form_AllFilterText;
            if (openRaw.ShowDialog() == DialogResult.OK)
            {
                byte[] temp = System.IO.File.ReadAllBytes(openRaw.FileName);
                ByteStream input = new ByteStream(temp);
                spriteset.Import(input);
                LoadSpriteset();

                status.ChangeMade();
                button_apply_Click(null, null);
            }
        }

        private void statusStrip_exportRaw_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveRaw = new SaveFileDialog();
            //saveRaw.Filter = "All files (*.*)|*.*";
            saveRaw.Filter = Properties.Resources.form_AllFilterText;
            if (saveRaw.ShowDialog() == DialogResult.OK)
            {
                ByteStream output = new ByteStream();
                spriteset.Write(output, false, true);
                output.Export(saveRaw.FileName);
            }
        }


    }
}
