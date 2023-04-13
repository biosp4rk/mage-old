namespace mage
{
    partial class FormSprite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSprite));
            this.groupBox_vulnerability = new System.Windows.Forms.GroupBox();
            this.checkBox_powerBombs = new System.Windows.Forms.CheckBox();
            this.checkBox_beamAndBombs = new System.Windows.Forms.CheckBox();
            this.checkBox_chargeBeam = new System.Windows.Forms.CheckBox();
            this.checkBox_superMissiles = new System.Windows.Forms.CheckBox();
            this.checkBox_missiles = new System.Windows.Forms.CheckBox();
            this.checkBox_speedScrew = new System.Windows.Forms.CheckBox();
            this.checkBox_frozen = new System.Windows.Forms.CheckBox();
            this.groupBox_dropProbability = new System.Windows.Forms.GroupBox();
            this.label_totalProb = new System.Windows.Forms.Label();
            this.label_powerBomb = new System.Windows.Forms.Label();
            this.label_superMissile = new System.Windows.Forms.Label();
            this.label_missile = new System.Windows.Forms.Label();
            this.label_largeHealth = new System.Windows.Forms.Label();
            this.label_smallHealth = new System.Windows.Forms.Label();
            this.label_noDrop = new System.Windows.Forms.Label();
            this.textBox_powerBomb = new System.Windows.Forms.TextBox();
            this.textBox_superMissile = new System.Windows.Forms.TextBox();
            this.textBox_missile = new System.Windows.Forms.TextBox();
            this.textBox_largeHealth = new System.Windows.Forms.TextBox();
            this.textBox_smallHealth = new System.Windows.Forms.TextBox();
            this.textBox_noDrop = new System.Windows.Forms.TextBox();
            this.label_total = new System.Windows.Forms.Label();
            this.label_healthX = new System.Windows.Forms.Label();
            this.textBox_redX = new System.Windows.Forms.TextBox();
            this.label_missileX = new System.Windows.Forms.Label();
            this.textBox_missileX = new System.Windows.Forms.TextBox();
            this.label_redX = new System.Windows.Forms.Label();
            this.textBox_healthX = new System.Windows.Forms.TextBox();
            this.groupBox_stats = new System.Windows.Forms.GroupBox();
            this.label_health = new System.Windows.Forms.Label();
            this.comboBox_reduction = new System.Windows.Forms.ComboBox();
            this.label_reduction = new System.Windows.Forms.Label();
            this.textBox_damage = new System.Windows.Forms.TextBox();
            this.textBox_health = new System.Windows.Forms.TextBox();
            this.label_damage = new System.Windows.Forms.Label();
            this.button_apply = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.label_sprite = new System.Windows.Forms.Label();
            this.comboBox_sprite = new System.Windows.Forms.ComboBox();
            this.button_editPalette = new System.Windows.Forms.Button();
            this.label_type = new System.Windows.Forms.Label();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.pictureBox_preview = new System.Windows.Forms.PictureBox();
            this.groupBox_preview = new System.Windows.Forms.GroupBox();
            this.panel_preview = new System.Windows.Forms.Panel();
            this.textBox_gfxOffsetVal = new System.Windows.Forms.TextBox();
            this.label_gfxOffset = new System.Windows.Forms.Label();
            this.button_editGFX = new System.Windows.Forms.Button();
            this.label_palOffset = new System.Windows.Forms.Label();
            this.textBox_palOffsetVal = new System.Windows.Forms.TextBox();
            this.groupBox_graphics = new System.Windows.Forms.GroupBox();
            this.numericUpDown_gfxRows = new System.Windows.Forms.NumericUpDown();
            this.label_gfxRows = new System.Windows.Forms.Label();
            this.label_AI = new System.Windows.Forms.Label();
            this.textBox_AIoffset = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel_changes = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox_vulnerability.SuspendLayout();
            this.groupBox_dropProbability.SuspendLayout();
            this.groupBox_stats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).BeginInit();
            this.groupBox_preview.SuspendLayout();
            this.panel_preview.SuspendLayout();
            this.groupBox_graphics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_gfxRows)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_vulnerability
            // 
            resources.ApplyResources(this.groupBox_vulnerability, "groupBox_vulnerability");
            this.groupBox_vulnerability.Controls.Add(this.checkBox_powerBombs);
            this.groupBox_vulnerability.Controls.Add(this.checkBox_beamAndBombs);
            this.groupBox_vulnerability.Controls.Add(this.checkBox_chargeBeam);
            this.groupBox_vulnerability.Controls.Add(this.checkBox_superMissiles);
            this.groupBox_vulnerability.Controls.Add(this.checkBox_missiles);
            this.groupBox_vulnerability.Controls.Add(this.checkBox_speedScrew);
            this.groupBox_vulnerability.Controls.Add(this.checkBox_frozen);
            this.groupBox_vulnerability.Name = "groupBox_vulnerability";
            this.groupBox_vulnerability.TabStop = false;
            // 
            // checkBox_powerBombs
            // 
            resources.ApplyResources(this.checkBox_powerBombs, "checkBox_powerBombs");
            this.checkBox_powerBombs.Name = "checkBox_powerBombs";
            this.checkBox_powerBombs.UseVisualStyleBackColor = true;
            this.checkBox_powerBombs.CheckedChanged += new System.EventHandler(this.SpriteValueChanged);
            // 
            // checkBox_beamAndBombs
            // 
            resources.ApplyResources(this.checkBox_beamAndBombs, "checkBox_beamAndBombs");
            this.checkBox_beamAndBombs.Name = "checkBox_beamAndBombs";
            this.checkBox_beamAndBombs.UseVisualStyleBackColor = true;
            this.checkBox_beamAndBombs.CheckedChanged += new System.EventHandler(this.SpriteValueChanged);
            // 
            // checkBox_chargeBeam
            // 
            resources.ApplyResources(this.checkBox_chargeBeam, "checkBox_chargeBeam");
            this.checkBox_chargeBeam.Name = "checkBox_chargeBeam";
            this.checkBox_chargeBeam.UseVisualStyleBackColor = true;
            this.checkBox_chargeBeam.CheckedChanged += new System.EventHandler(this.SpriteValueChanged);
            // 
            // checkBox_superMissiles
            // 
            resources.ApplyResources(this.checkBox_superMissiles, "checkBox_superMissiles");
            this.checkBox_superMissiles.Name = "checkBox_superMissiles";
            this.checkBox_superMissiles.UseVisualStyleBackColor = true;
            this.checkBox_superMissiles.CheckedChanged += new System.EventHandler(this.SpriteValueChanged);
            // 
            // checkBox_missiles
            // 
            resources.ApplyResources(this.checkBox_missiles, "checkBox_missiles");
            this.checkBox_missiles.Name = "checkBox_missiles";
            this.checkBox_missiles.UseVisualStyleBackColor = true;
            this.checkBox_missiles.CheckedChanged += new System.EventHandler(this.SpriteValueChanged);
            // 
            // checkBox_speedScrew
            // 
            resources.ApplyResources(this.checkBox_speedScrew, "checkBox_speedScrew");
            this.checkBox_speedScrew.Name = "checkBox_speedScrew";
            this.checkBox_speedScrew.UseVisualStyleBackColor = true;
            this.checkBox_speedScrew.CheckedChanged += new System.EventHandler(this.SpriteValueChanged);
            // 
            // checkBox_frozen
            // 
            resources.ApplyResources(this.checkBox_frozen, "checkBox_frozen");
            this.checkBox_frozen.Name = "checkBox_frozen";
            this.checkBox_frozen.UseVisualStyleBackColor = true;
            this.checkBox_frozen.CheckedChanged += new System.EventHandler(this.SpriteValueChanged);
            // 
            // groupBox_dropProbability
            // 
            resources.ApplyResources(this.groupBox_dropProbability, "groupBox_dropProbability");
            this.groupBox_dropProbability.Controls.Add(this.label_totalProb);
            this.groupBox_dropProbability.Controls.Add(this.label_powerBomb);
            this.groupBox_dropProbability.Controls.Add(this.label_superMissile);
            this.groupBox_dropProbability.Controls.Add(this.label_missile);
            this.groupBox_dropProbability.Controls.Add(this.label_largeHealth);
            this.groupBox_dropProbability.Controls.Add(this.label_smallHealth);
            this.groupBox_dropProbability.Controls.Add(this.label_noDrop);
            this.groupBox_dropProbability.Controls.Add(this.textBox_powerBomb);
            this.groupBox_dropProbability.Controls.Add(this.textBox_superMissile);
            this.groupBox_dropProbability.Controls.Add(this.textBox_missile);
            this.groupBox_dropProbability.Controls.Add(this.textBox_largeHealth);
            this.groupBox_dropProbability.Controls.Add(this.textBox_smallHealth);
            this.groupBox_dropProbability.Controls.Add(this.textBox_noDrop);
            this.groupBox_dropProbability.Controls.Add(this.label_total);
            this.groupBox_dropProbability.Controls.Add(this.label_healthX);
            this.groupBox_dropProbability.Controls.Add(this.textBox_redX);
            this.groupBox_dropProbability.Controls.Add(this.label_missileX);
            this.groupBox_dropProbability.Controls.Add(this.textBox_missileX);
            this.groupBox_dropProbability.Controls.Add(this.label_redX);
            this.groupBox_dropProbability.Controls.Add(this.textBox_healthX);
            this.groupBox_dropProbability.Name = "groupBox_dropProbability";
            this.groupBox_dropProbability.TabStop = false;
            // 
            // label_totalProb
            // 
            resources.ApplyResources(this.label_totalProb, "label_totalProb");
            this.label_totalProb.Name = "label_totalProb";
            // 
            // label_powerBomb
            // 
            resources.ApplyResources(this.label_powerBomb, "label_powerBomb");
            this.label_powerBomb.Name = "label_powerBomb";
            // 
            // label_superMissile
            // 
            resources.ApplyResources(this.label_superMissile, "label_superMissile");
            this.label_superMissile.Name = "label_superMissile";
            // 
            // label_missile
            // 
            resources.ApplyResources(this.label_missile, "label_missile");
            this.label_missile.Name = "label_missile";
            // 
            // label_largeHealth
            // 
            resources.ApplyResources(this.label_largeHealth, "label_largeHealth");
            this.label_largeHealth.Name = "label_largeHealth";
            // 
            // label_smallHealth
            // 
            resources.ApplyResources(this.label_smallHealth, "label_smallHealth");
            this.label_smallHealth.Name = "label_smallHealth";
            // 
            // label_noDrop
            // 
            resources.ApplyResources(this.label_noDrop, "label_noDrop");
            this.label_noDrop.Name = "label_noDrop";
            // 
            // textBox_powerBomb
            // 
            resources.ApplyResources(this.textBox_powerBomb, "textBox_powerBomb");
            this.textBox_powerBomb.Name = "textBox_powerBomb";
            this.textBox_powerBomb.TextChanged += new System.EventHandler(this.textBox_dropProb_TextChanged);
            // 
            // textBox_superMissile
            // 
            resources.ApplyResources(this.textBox_superMissile, "textBox_superMissile");
            this.textBox_superMissile.Name = "textBox_superMissile";
            this.textBox_superMissile.TextChanged += new System.EventHandler(this.textBox_dropProb_TextChanged);
            // 
            // textBox_missile
            // 
            resources.ApplyResources(this.textBox_missile, "textBox_missile");
            this.textBox_missile.Name = "textBox_missile";
            this.textBox_missile.TextChanged += new System.EventHandler(this.textBox_dropProb_TextChanged);
            // 
            // textBox_largeHealth
            // 
            resources.ApplyResources(this.textBox_largeHealth, "textBox_largeHealth");
            this.textBox_largeHealth.Name = "textBox_largeHealth";
            this.textBox_largeHealth.TextChanged += new System.EventHandler(this.textBox_dropProb_TextChanged);
            // 
            // textBox_smallHealth
            // 
            resources.ApplyResources(this.textBox_smallHealth, "textBox_smallHealth");
            this.textBox_smallHealth.Name = "textBox_smallHealth";
            this.textBox_smallHealth.TextChanged += new System.EventHandler(this.textBox_dropProb_TextChanged);
            // 
            // textBox_noDrop
            // 
            resources.ApplyResources(this.textBox_noDrop, "textBox_noDrop");
            this.textBox_noDrop.Name = "textBox_noDrop";
            this.textBox_noDrop.TextChanged += new System.EventHandler(this.textBox_dropProb_TextChanged);
            // 
            // label_total
            // 
            resources.ApplyResources(this.label_total, "label_total");
            this.label_total.Name = "label_total";
            // 
            // label_healthX
            // 
            resources.ApplyResources(this.label_healthX, "label_healthX");
            this.label_healthX.Name = "label_healthX";
            // 
            // textBox_redX
            // 
            resources.ApplyResources(this.textBox_redX, "textBox_redX");
            this.textBox_redX.Name = "textBox_redX";
            this.textBox_redX.TextChanged += new System.EventHandler(this.textBox_dropProb_TextChanged);
            // 
            // label_missileX
            // 
            resources.ApplyResources(this.label_missileX, "label_missileX");
            this.label_missileX.Name = "label_missileX";
            // 
            // textBox_missileX
            // 
            resources.ApplyResources(this.textBox_missileX, "textBox_missileX");
            this.textBox_missileX.Name = "textBox_missileX";
            this.textBox_missileX.TextChanged += new System.EventHandler(this.textBox_dropProb_TextChanged);
            // 
            // label_redX
            // 
            resources.ApplyResources(this.label_redX, "label_redX");
            this.label_redX.Name = "label_redX";
            // 
            // textBox_healthX
            // 
            resources.ApplyResources(this.textBox_healthX, "textBox_healthX");
            this.textBox_healthX.Name = "textBox_healthX";
            this.textBox_healthX.TextChanged += new System.EventHandler(this.textBox_dropProb_TextChanged);
            // 
            // groupBox_stats
            // 
            resources.ApplyResources(this.groupBox_stats, "groupBox_stats");
            this.groupBox_stats.Controls.Add(this.label_health);
            this.groupBox_stats.Controls.Add(this.comboBox_reduction);
            this.groupBox_stats.Controls.Add(this.label_reduction);
            this.groupBox_stats.Controls.Add(this.textBox_damage);
            this.groupBox_stats.Controls.Add(this.textBox_health);
            this.groupBox_stats.Controls.Add(this.label_damage);
            this.groupBox_stats.Name = "groupBox_stats";
            this.groupBox_stats.TabStop = false;
            // 
            // label_health
            // 
            resources.ApplyResources(this.label_health, "label_health");
            this.label_health.Name = "label_health";
            // 
            // comboBox_reduction
            // 
            resources.ApplyResources(this.comboBox_reduction, "comboBox_reduction");
            this.comboBox_reduction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_reduction.FormattingEnabled = true;
            this.comboBox_reduction.Items.AddRange(new object[] {
            resources.GetString("comboBox_reduction.Items"),
            resources.GetString("comboBox_reduction.Items1"),
            resources.GetString("comboBox_reduction.Items2"),
            resources.GetString("comboBox_reduction.Items3")});
            this.comboBox_reduction.Name = "comboBox_reduction";
            this.comboBox_reduction.SelectedIndexChanged += new System.EventHandler(this.SpriteValueChanged);
            // 
            // label_reduction
            // 
            resources.ApplyResources(this.label_reduction, "label_reduction");
            this.label_reduction.Name = "label_reduction";
            // 
            // textBox_damage
            // 
            resources.ApplyResources(this.textBox_damage, "textBox_damage");
            this.textBox_damage.Name = "textBox_damage";
            this.textBox_damage.TextChanged += new System.EventHandler(this.SpriteValueChanged);
            // 
            // textBox_health
            // 
            resources.ApplyResources(this.textBox_health, "textBox_health");
            this.textBox_health.Name = "textBox_health";
            this.textBox_health.TextChanged += new System.EventHandler(this.SpriteValueChanged);
            // 
            // label_damage
            // 
            resources.ApplyResources(this.label_damage, "label_damage");
            this.label_damage.Name = "label_damage";
            // 
            // button_apply
            // 
            resources.ApplyResources(this.button_apply, "button_apply");
            this.button_apply.Name = "button_apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // button_close
            // 
            resources.ApplyResources(this.button_close, "button_close");
            this.button_close.Name = "button_close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label_sprite
            // 
            resources.ApplyResources(this.label_sprite, "label_sprite");
            this.label_sprite.Name = "label_sprite";
            // 
            // comboBox_sprite
            // 
            resources.ApplyResources(this.comboBox_sprite, "comboBox_sprite");
            this.comboBox_sprite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sprite.FormattingEnabled = true;
            this.comboBox_sprite.Name = "comboBox_sprite";
            this.comboBox_sprite.SelectedIndexChanged += new System.EventHandler(this.comboBox_sprite_SelectedIndexChanged);
            // 
            // button_editPalette
            // 
            resources.ApplyResources(this.button_editPalette, "button_editPalette");
            this.button_editPalette.Name = "button_editPalette";
            this.button_editPalette.UseVisualStyleBackColor = true;
            this.button_editPalette.Click += new System.EventHandler(this.button_editPalette_Click);
            // 
            // label_type
            // 
            resources.ApplyResources(this.label_type, "label_type");
            this.label_type.Name = "label_type";
            // 
            // comboBox_type
            // 
            resources.ApplyResources(this.comboBox_type, "comboBox_type");
            this.comboBox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            resources.GetString("comboBox_type.Items"),
            resources.GetString("comboBox_type.Items1")});
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.SelectedIndexChanged += new System.EventHandler(this.comboBox_type_SelectedIndexChanged);
            // 
            // pictureBox_preview
            // 
            resources.ApplyResources(this.pictureBox_preview, "pictureBox_preview");
            this.pictureBox_preview.Name = "pictureBox_preview";
            this.pictureBox_preview.TabStop = false;
            // 
            // groupBox_preview
            // 
            resources.ApplyResources(this.groupBox_preview, "groupBox_preview");
            this.groupBox_preview.Controls.Add(this.panel_preview);
            this.groupBox_preview.Name = "groupBox_preview";
            this.groupBox_preview.TabStop = false;
            // 
            // panel_preview
            // 
            resources.ApplyResources(this.panel_preview, "panel_preview");
            this.panel_preview.Controls.Add(this.pictureBox_preview);
            this.panel_preview.Name = "panel_preview";
            // 
            // textBox_gfxOffsetVal
            // 
            resources.ApplyResources(this.textBox_gfxOffsetVal, "textBox_gfxOffsetVal");
            this.textBox_gfxOffsetVal.Name = "textBox_gfxOffsetVal";
            this.textBox_gfxOffsetVal.TextChanged += new System.EventHandler(this.SpriteValueChanged);
            // 
            // label_gfxOffset
            // 
            resources.ApplyResources(this.label_gfxOffset, "label_gfxOffset");
            this.label_gfxOffset.Name = "label_gfxOffset";
            // 
            // button_editGFX
            // 
            resources.ApplyResources(this.button_editGFX, "button_editGFX");
            this.button_editGFX.Name = "button_editGFX";
            this.button_editGFX.UseVisualStyleBackColor = true;
            this.button_editGFX.Click += new System.EventHandler(this.button_editGFX_Click);
            // 
            // label_palOffset
            // 
            resources.ApplyResources(this.label_palOffset, "label_palOffset");
            this.label_palOffset.Name = "label_palOffset";
            // 
            // textBox_palOffsetVal
            // 
            resources.ApplyResources(this.textBox_palOffsetVal, "textBox_palOffsetVal");
            this.textBox_palOffsetVal.Name = "textBox_palOffsetVal";
            this.textBox_palOffsetVal.TextChanged += new System.EventHandler(this.SpriteValueChanged);
            // 
            // groupBox_graphics
            // 
            resources.ApplyResources(this.groupBox_graphics, "groupBox_graphics");
            this.groupBox_graphics.Controls.Add(this.numericUpDown_gfxRows);
            this.groupBox_graphics.Controls.Add(this.label_gfxOffset);
            this.groupBox_graphics.Controls.Add(this.label_gfxRows);
            this.groupBox_graphics.Controls.Add(this.label_palOffset);
            this.groupBox_graphics.Controls.Add(this.button_editPalette);
            this.groupBox_graphics.Controls.Add(this.textBox_palOffsetVal);
            this.groupBox_graphics.Controls.Add(this.textBox_gfxOffsetVal);
            this.groupBox_graphics.Controls.Add(this.button_editGFX);
            this.groupBox_graphics.Name = "groupBox_graphics";
            this.groupBox_graphics.TabStop = false;
            // 
            // numericUpDown_gfxRows
            // 
            resources.ApplyResources(this.numericUpDown_gfxRows, "numericUpDown_gfxRows");
            this.numericUpDown_gfxRows.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown_gfxRows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_gfxRows.Name = "numericUpDown_gfxRows";
            this.numericUpDown_gfxRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_gfxRows.ValueChanged += new System.EventHandler(this.SpriteValueChanged);
            // 
            // label_gfxRows
            // 
            resources.ApplyResources(this.label_gfxRows, "label_gfxRows");
            this.label_gfxRows.Name = "label_gfxRows";
            // 
            // label_AI
            // 
            resources.ApplyResources(this.label_AI, "label_AI");
            this.label_AI.Name = "label_AI";
            // 
            // textBox_AIoffset
            // 
            resources.ApplyResources(this.textBox_AIoffset, "textBox_AIoffset");
            this.textBox_AIoffset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_AIoffset.Name = "textBox_AIoffset";
            this.textBox_AIoffset.ReadOnly = true;
            this.textBox_AIoffset.TabStop = false;
            // 
            // statusStrip
            // 
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_changes});
            this.statusStrip.Name = "statusStrip";
            // 
            // statusLabel_changes
            // 
            resources.ApplyResources(this.statusLabel_changes, "statusLabel_changes");
            this.statusLabel_changes.Name = "statusLabel_changes";
            // 
            // FormSprite
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.textBox_AIoffset);
            this.Controls.Add(this.groupBox_graphics);
            this.Controls.Add(this.groupBox_preview);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.label_type);
            this.Controls.Add(this.comboBox_sprite);
            this.Controls.Add(this.label_sprite);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.groupBox_stats);
            this.Controls.Add(this.groupBox_dropProbability);
            this.Controls.Add(this.groupBox_vulnerability);
            this.Controls.Add(this.label_AI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSprite";
            this.groupBox_vulnerability.ResumeLayout(false);
            this.groupBox_vulnerability.PerformLayout();
            this.groupBox_dropProbability.ResumeLayout(false);
            this.groupBox_dropProbability.PerformLayout();
            this.groupBox_stats.ResumeLayout(false);
            this.groupBox_stats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).EndInit();
            this.groupBox_preview.ResumeLayout(false);
            this.panel_preview.ResumeLayout(false);
            this.groupBox_graphics.ResumeLayout(false);
            this.groupBox_graphics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_gfxRows)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_vulnerability;
        private System.Windows.Forms.CheckBox checkBox_beamAndBombs;
        private System.Windows.Forms.CheckBox checkBox_chargeBeam;
        private System.Windows.Forms.CheckBox checkBox_superMissiles;
        private System.Windows.Forms.CheckBox checkBox_missiles;
        private System.Windows.Forms.CheckBox checkBox_speedScrew;
        private System.Windows.Forms.CheckBox checkBox_frozen;
        private System.Windows.Forms.GroupBox groupBox_dropProbability;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label_healthX;
        private System.Windows.Forms.TextBox textBox_redX;
        private System.Windows.Forms.Label label_missileX;
        private System.Windows.Forms.TextBox textBox_missileX;
        private System.Windows.Forms.Label label_redX;
        private System.Windows.Forms.TextBox textBox_healthX;
        private System.Windows.Forms.GroupBox groupBox_stats;
        private System.Windows.Forms.Label label_health;
        private System.Windows.Forms.ComboBox comboBox_reduction;
        private System.Windows.Forms.Label label_reduction;
        private System.Windows.Forms.TextBox textBox_damage;
        private System.Windows.Forms.TextBox textBox_health;
        private System.Windows.Forms.Label label_damage;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_sprite;
        private System.Windows.Forms.ComboBox comboBox_sprite;
        private System.Windows.Forms.CheckBox checkBox_powerBombs;
        private System.Windows.Forms.Button button_editPalette;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.PictureBox pictureBox_preview;
        private System.Windows.Forms.GroupBox groupBox_preview;
        private System.Windows.Forms.TextBox textBox_gfxOffsetVal;
        private System.Windows.Forms.Label label_gfxOffset;
        private System.Windows.Forms.Label label_powerBomb;
        private System.Windows.Forms.Label label_superMissile;
        private System.Windows.Forms.Label label_missile;
        private System.Windows.Forms.Label label_largeHealth;
        private System.Windows.Forms.Label label_smallHealth;
        private System.Windows.Forms.Label label_noDrop;
        private System.Windows.Forms.TextBox textBox_powerBomb;
        private System.Windows.Forms.TextBox textBox_superMissile;
        private System.Windows.Forms.TextBox textBox_missile;
        private System.Windows.Forms.TextBox textBox_largeHealth;
        private System.Windows.Forms.TextBox textBox_smallHealth;
        private System.Windows.Forms.TextBox textBox_noDrop;
        private System.Windows.Forms.Panel panel_preview;
        private System.Windows.Forms.Button button_editGFX;
        private System.Windows.Forms.Label label_palOffset;
        private System.Windows.Forms.TextBox textBox_palOffsetVal;
        private System.Windows.Forms.GroupBox groupBox_graphics;
        private System.Windows.Forms.Label label_AI;
        private System.Windows.Forms.TextBox textBox_AIoffset;
        private System.Windows.Forms.Label label_totalProb;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_changes;
        private System.Windows.Forms.NumericUpDown numericUpDown_gfxRows;
        private System.Windows.Forms.Label label_gfxRows;
    }
}