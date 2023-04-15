using System;
using System.Drawing;
using System.Windows.Forms;

namespace mage
{
    public partial class FormSprite : Form, Editor
    {
        // fields
        private SpriteGFX currGfx;
        private SpriteStats currStats;

        private byte sprite1ID;
        private byte sprite2ID;
        private VramObj vramObj;

        private FormMain main;
        private ByteStream romStream;
        private Status status;
        private bool loading;

        // constructor
        public FormSprite(FormMain main, byte spriteID)
        {
            InitializeComponent();

            this.main = main;
            this.sprite1ID = spriteID;
            this.sprite2ID = 0;
            this.romStream = ROM.Stream;

            if (Version.IsMF)
            {
                EnableZMdrops(false);
            }
            else
            {
                EnableMFdrops(false);
                comboBox_reduction.Enabled = false;
                numericUpDown_gfxRows.Enabled = false;
            }

            status = new Status(statusLabel_changes, button_apply);
            comboBox_type.SelectedIndex = 0;
        }

        public void UpdateEditor()
        {
            if (!status.UnsavedChanges)
            {
                byte id = (byte)comboBox_sprite.SelectedIndex;
                LoadSprite(id);
            }
        }

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            loading = true;

            byte spriteID;
            if (comboBox_type.SelectedIndex == 0)
            {
                if (Version.IsMF)
                {
                    EnableMFdrops(true);
                }
                UpdateNumOfSprites(Version.NumOfSprites1);
                spriteID = sprite1ID;
            }
            else
            {
                if (Version.IsMF)
                {
                    EnableMFdrops(false);
                    ClearDropsText();
                }
                UpdateNumOfSprites(Version.NumOfSprites2);
                spriteID = sprite2ID;
            }

            if (comboBox_sprite.SelectedIndex == spriteID)
            {
                LoadSprite(spriteID);
            }
            else
            {
                comboBox_sprite.SelectedIndex = spriteID;
            }
        }
        
        private void comboBox_sprite_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSprite((byte)comboBox_sprite.SelectedIndex);
        }

        private void LoadSprite(byte spriteID)
        {
            loading = true;

            // primary
            if (comboBox_type.SelectedIndex == 0)
            {
                sprite1ID = spriteID;
                currStats = new SpriteStats(sprite1ID, true);
                vramObj = new VramObj(sprite1ID, true);
                currGfx = new SpriteGFX(vramObj, 0, sprite1ID, true);
                UpdateGraphics();
                int AIoffset = romStream.ReadPtr(Version.SpriteAI1Offset + sprite1ID * 4);
                textBox_AIoffset.Text = Hex.ToString(AIoffset);
            }
            // secondary
            else
            {
                sprite2ID = spriteID;
                currStats = new SpriteStats(sprite2ID, false);
                vramObj = new VramObj(sprite2ID, false);
                currGfx = new SpriteGFX(vramObj, 0, sprite2ID, false);
                UpdateGraphics();
                int AIoffset = romStream.ReadPtr(Version.SpriteAI2Offset + sprite2ID * 4);
                textBox_AIoffset.Text = Hex.ToString(AIoffset);
            }

            ShowStats();
            loading = false;
            status.LoadNew();
        }

        private void UpdateNumOfSprites(byte numOfSprites)
        {
            int currNum = comboBox_sprite.Items.Count;
            if (numOfSprites > currNum)
            {
                for (int i = currNum; i < numOfSprites; i++)
                {
                    comboBox_sprite.Items.Add(Hex.ToString(i));
                }
            }
            else if (numOfSprites < currNum)
            {
                for (int i = currNum - 1; i >= numOfSprites; i--)
                {
                    comboBox_sprite.Items.RemoveAt(i);
                }
            }
        }

        private void EnableMFdrops(bool enable)
        {
            textBox_healthX.Enabled = enable;
            textBox_missileX.Enabled = enable;
            textBox_redX.Enabled = enable;
        }

        private void EnableZMdrops(bool enable)
        {
            textBox_noDrop.Enabled = enable;
            textBox_smallHealth.Enabled = enable;
            textBox_largeHealth.Enabled = enable;
            textBox_missile.Enabled = enable;
            textBox_superMissile.Enabled = enable;
            textBox_powerBomb.Enabled = enable;
        }

        private void ClearDropsText()
        {
            label_totalProb.Text = "–";
            textBox_healthX.Text = "";
            textBox_missileX.Text = "";
            textBox_redX.Text = "";
        }

        private void ShowStats()
        {
            textBox_health.Text = Hex.ToString(currStats.health);
            textBox_damage.Text = Hex.ToString(currStats.damage);

            // vulnerability
            byte vul = currStats.vulnerability;
            checkBox_chargeBeam.Checked = ((vul & 1) != 0);
            checkBox_beamAndBombs.Checked = ((vul & 2) != 0);
            checkBox_superMissiles.Checked = ((vul & 4) != 0);
            checkBox_missiles.Checked = ((vul & 8) != 0);
            checkBox_powerBombs.Checked = ((vul & 0x10) != 0);
            checkBox_speedScrew.Checked = ((vul & 0x20) != 0);
            checkBox_frozen.Checked = ((vul & 0x40) != 0);

            // drop probability
            if (Version.IsMF)
            {
                if (currStats.reduction == 0x11) { comboBox_reduction.SelectedIndex = 1; }
                else if (currStats.reduction == 0x12) { comboBox_reduction.SelectedIndex = 2; }
                else if (currStats.reduction == 0x13) { comboBox_reduction.SelectedIndex = 3; }
                else { comboBox_reduction.SelectedIndex = 0; }

                if (currStats.primary)
                {
                    textBox_healthX.Text = Hex.ToString(currStats.healthX);
                    textBox_missileX.Text = Hex.ToString(currStats.missileX);
                    textBox_redX.Text = Hex.ToString(currStats.redX);
                }
            }
            else
            {
                textBox_noDrop.Text = Hex.ToString(currStats.noDrop);
                textBox_smallHealth.Text = Hex.ToString(currStats.smallHealth);
                textBox_largeHealth.Text = Hex.ToString(currStats.largeHealth);
                textBox_missile.Text = Hex.ToString(currStats.missile);
                textBox_superMissile.Text = Hex.ToString(currStats.superMissile);
                textBox_powerBomb.Text = Hex.ToString(currStats.powerBomb);
            }
        }

        private void UpdateGraphics()
        {
            if (currGfx.pSpriteID < 0x10)
            {
                groupBox_graphics.Enabled = false;
                textBox_gfxOffsetVal.Text = "";
                textBox_palOffsetVal.Text = "";
                numericUpDown_gfxRows.Minimum = 0;
                numericUpDown_gfxRows.Value = 0;
                pictureBox_preview.Image = null;
                return;
            }

            if (currGfx.primary)
            {
                groupBox_graphics.Enabled = true;
                int addVal = (sprite1ID - 0x10) * 4;
                int offset = Version.SpriteGfxOffset + addVal;
                int gfxOffset = romStream.ReadPtr(offset);
                offset = Version.SpritePaletteOffset + addVal;
                int palOffset = romStream.ReadPtr(offset);
                textBox_gfxOffsetVal.Text = Hex.ToString(gfxOffset);
                textBox_palOffsetVal.Text = Hex.ToString(palOffset);
                numericUpDown_gfxRows.Minimum = 1;
                numericUpDown_gfxRows.Value = currGfx.NumGfxRows;
            }
            else
            {
                groupBox_graphics.Enabled = false;
                textBox_gfxOffsetVal.Text = "";
                textBox_palOffsetVal.Text = "";
                numericUpDown_gfxRows.Minimum = 0;
                numericUpDown_gfxRows.Value = 0;
            }

            if (currGfx.previewImg == null)
            {
                pictureBox_preview.Size = new Size(0, 0);
                pictureBox_preview.Image = null;
            }
            else
            {
                pictureBox_preview.Size = currGfx.previewImg.Size;
                pictureBox_preview.Image = currGfx.previewImg;
            }
        }

        private void UpdateDropTotal()
        {
            if (Version.IsMF && comboBox_type.SelectedIndex == 1) { return; }

            var controls = groupBox_dropProbability.Controls;
            int total = 0;

            try
            {
                foreach (Control ctrl in controls)
                {
                    if (ctrl is TextBox && ctrl.Enabled)
                    {
                        total += Hex.ToUshort(ctrl.Text);
                    }
                }
            }
            catch
            {
                label_totalProb.Text = "–";
                label_totalProb.ForeColor = Color.DarkRed;
                return;
            }

            label_totalProb.Text = Hex.ToString(total);
            if (total == 0x400 || total == 0)
            {
                label_totalProb.ForeColor = Color.Black;
            }
            else
            {
                label_totalProb.ForeColor = Color.DarkRed;
                if (total < 0x400)
                {
                    //label_totalProb.Text += " (too low)";
                    label_totalProb.Text += Properties.Resources.formSprite_label_totalProbLow;
                }
                else
                {
                    //label_totalProb.Text += " (too high)";
                    label_totalProb.Text += Properties.Resources.formSprite_label_totalProbHigh;
                }
            }
        }

        private void textBox_dropProb_TextChanged(object sender, EventArgs e)
        {
            UpdateDropTotal();
            if (!loading) { status.ChangeMade(); }
        }

        private void SpriteValueChanged(object sender, EventArgs e)
        {
            if (!loading) { status.ChangeMade(); }
        }

        private void button_editGFX_Click(object sender, EventArgs e)
        {
            FormGraphics formGfx;
            if (Version.IsMF)
            {
                formGfx = new FormGraphics(main, currGfx.GfxOffset, 32, currGfx.NumGfxRows * 2, currGfx.PalOffset);
            }
            else
            {
                formGfx = new FormGraphics(main, currGfx.GfxOffset, 0, 0, currGfx.PalOffset);
            }
            formGfx.Show();
        }

        private void button_editPalette_Click(object sender, EventArgs e)
        {
            FormPalette form = new FormPalette(main, false, (byte)comboBox_sprite.SelectedIndex);
            form.Show();
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            try
            {
                // set values
                currStats.health = Hex.ToUshort(textBox_health.Text);
                currStats.damage = Hex.ToUshort(textBox_damage.Text);

                byte vul = 0;
                if (checkBox_chargeBeam.Checked) { vul |= 0x1; }
                if (checkBox_beamAndBombs.Checked) { vul |= 0x2; }
                if (checkBox_superMissiles.Checked) { vul |= 0x4; }
                if (checkBox_missiles.Checked) { vul |= 0x8; }
                if (checkBox_powerBombs.Checked) { vul |= 0x10; }
                if (checkBox_speedScrew.Checked) { vul |= 0x20; }
                if (checkBox_frozen.Checked) { vul |= 0x40; }
                currStats.vulnerability = vul;

                if (Version.IsMF)
                {
                    if (comboBox_reduction.SelectedIndex == 0) { currStats.reduction = 0x10; }
                    else if (comboBox_reduction.SelectedIndex == 1) { currStats.reduction = 0x11; }
                    else if (comboBox_reduction.SelectedIndex == 2) { currStats.reduction = 0x12; }
                    else { currStats.reduction = 0x13; }

                    if (currStats.primary)
                    {
                        currStats.healthX = Hex.ToUshort(textBox_healthX.Text);
                        currStats.missileX = Hex.ToUshort(textBox_missileX.Text);
                        currStats.redX = Hex.ToUshort(textBox_redX.Text);
                    }
                }
                else
                {
                    currStats.noDrop = Hex.ToUshort(textBox_noDrop.Text);
                    currStats.smallHealth = Hex.ToUshort(textBox_smallHealth.Text);
                    currStats.largeHealth = Hex.ToUshort(textBox_largeHealth.Text);
                    currStats.missile = Hex.ToUshort(textBox_missile.Text);
                    currStats.superMissile = Hex.ToUshort(textBox_superMissile.Text);
                    currStats.powerBomb = Hex.ToUshort(textBox_powerBomb.Text);
                }

                // write stats
                currStats.Write();

                // write graphics
                if (currStats.primary && currGfx.pSpriteID > 0x10)
                {
                    int gfxOffset = Hex.ToInt(textBox_gfxOffsetVal.Text);
                    int palOffset = Hex.ToInt(textBox_palOffsetVal.Text);
                    int gfxRows = (int)numericUpDown_gfxRows.Value;

                    currGfx.Write(gfxOffset, palOffset, gfxRows);
                    pictureBox_preview.Image = currGfx.previewImg;
                }

                FormMain.UpdateEditors();
                status.Save();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("One of the values entered was not valid.\n\n" + ex.Message, 
                //    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(Properties.Resources.form_OneValueNotValidErrorText + ex.Message,
                    Properties.Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
