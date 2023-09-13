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
            this.textBox_powerBomb = new mage.Theming.CustomControls.FlatTextBox();
            this.textBox_superMissile = new mage.Theming.CustomControls.FlatTextBox();
            this.textBox_missile = new mage.Theming.CustomControls.FlatTextBox();
            this.textBox_largeHealth = new mage.Theming.CustomControls.FlatTextBox();
            this.textBox_smallHealth = new mage.Theming.CustomControls.FlatTextBox();
            this.textBox_noDrop = new mage.Theming.CustomControls.FlatTextBox();
            this.label_total = new System.Windows.Forms.Label();
            this.label_healthX = new System.Windows.Forms.Label();
            this.textBox_redX = new mage.Theming.CustomControls.FlatTextBox();
            this.label_missileX = new System.Windows.Forms.Label();
            this.textBox_missileX = new mage.Theming.CustomControls.FlatTextBox();
            this.label_redX = new System.Windows.Forms.Label();
            this.textBox_healthX = new mage.Theming.CustomControls.FlatTextBox();
            this.groupBox_stats = new System.Windows.Forms.GroupBox();
            this.label_health = new System.Windows.Forms.Label();
            this.comboBox_reduction = new mage.Theming.CustomControls.FlatComboBox();
            this.label_reduction = new System.Windows.Forms.Label();
            this.textBox_damage = new mage.Theming.CustomControls.FlatTextBox();
            this.textBox_health = new mage.Theming.CustomControls.FlatTextBox();
            this.label_damage = new System.Windows.Forms.Label();
            this.button_apply = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.label_sprite = new System.Windows.Forms.Label();
            this.comboBox_sprite = new mage.Theming.CustomControls.FlatComboBox();
            this.button_editPalette = new System.Windows.Forms.Button();
            this.label_type = new System.Windows.Forms.Label();
            this.comboBox_type = new mage.Theming.CustomControls.FlatComboBox();
            this.pictureBox_preview = new System.Windows.Forms.PictureBox();
            this.groupBox_preview = new System.Windows.Forms.GroupBox();
            this.panel_preview = new System.Windows.Forms.Panel();
            this.textBox_gfxOffsetVal = new mage.Theming.CustomControls.FlatTextBox();
            this.label_gfxOffset = new System.Windows.Forms.Label();
            this.button_editGFX = new System.Windows.Forms.Button();
            this.label_palOffset = new System.Windows.Forms.Label();
            this.textBox_palOffsetVal = new mage.Theming.CustomControls.FlatTextBox();
            this.groupBox_graphics = new System.Windows.Forms.GroupBox();
            this.label_AI = new System.Windows.Forms.Label();
            this.textBox_AIoffset = new mage.Theming.CustomControls.FlatTextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel_changes = new System.Windows.Forms.ToolStripStatusLabel();
            this.label_gfxRows = new System.Windows.Forms.Label();
            this.numericUpDown_gfxRows = new mage.Theming.CustomControls.FlatNumericUpDown();
            this.groupBox_vulnerability.SuspendLayout();
            this.groupBox_dropProbability.SuspendLayout();
            this.groupBox_stats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).BeginInit();
            this.groupBox_preview.SuspendLayout();
            this.panel_preview.SuspendLayout();
            this.groupBox_graphics.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_gfxRows)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_vulnerability
            // 
            this.groupBox_vulnerability.Controls.Add(this.checkBox_powerBombs);
            this.groupBox_vulnerability.Controls.Add(this.checkBox_beamAndBombs);
            this.groupBox_vulnerability.Controls.Add(this.checkBox_chargeBeam);
            this.groupBox_vulnerability.Controls.Add(this.checkBox_superMissiles);
            this.groupBox_vulnerability.Controls.Add(this.checkBox_missiles);
            this.groupBox_vulnerability.Controls.Add(this.checkBox_speedScrew);
            this.groupBox_vulnerability.Controls.Add(this.checkBox_frozen);
            this.groupBox_vulnerability.Location = new System.Drawing.Point(149, 161);
            this.groupBox_vulnerability.Name = "groupBox_vulnerability";
            this.groupBox_vulnerability.Size = new System.Drawing.Size(226, 111);
            this.groupBox_vulnerability.TabIndex = 5;
            this.groupBox_vulnerability.TabStop = false;
            this.groupBox_vulnerability.Text = "Vulnerability";
            // 
            // checkBox_powerBombs
            // 
            this.checkBox_powerBombs.AutoSize = true;
            this.checkBox_powerBombs.Location = new System.Drawing.Point(127, 19);
            this.checkBox_powerBombs.Name = "checkBox_powerBombs";
            this.checkBox_powerBombs.Size = new System.Drawing.Size(90, 17);
            this.checkBox_powerBombs.TabIndex = 4;
            this.checkBox_powerBombs.Text = "Power bombs";
            this.checkBox_powerBombs.UseVisualStyleBackColor = true;
            this.checkBox_powerBombs.CheckedChanged += new System.EventHandler(this.SpriteValueChanged);
            // 
            // checkBox_beamAndBombs
            // 
            this.checkBox_beamAndBombs.AutoSize = true;
            this.checkBox_beamAndBombs.Location = new System.Drawing.Point(9, 19);
            this.checkBox_beamAndBombs.Name = "checkBox_beamAndBombs";
            this.checkBox_beamAndBombs.Size = new System.Drawing.Size(108, 17);
            this.checkBox_beamAndBombs.TabIndex = 0;
            this.checkBox_beamAndBombs.Text = "Beam and bombs";
            this.checkBox_beamAndBombs.UseVisualStyleBackColor = true;
            this.checkBox_beamAndBombs.CheckedChanged += new System.EventHandler(this.SpriteValueChanged);
            // 
            // checkBox_chargeBeam
            // 
            this.checkBox_chargeBeam.AutoSize = true;
            this.checkBox_chargeBeam.Location = new System.Drawing.Point(9, 42);
            this.checkBox_chargeBeam.Name = "checkBox_chargeBeam";
            this.checkBox_chargeBeam.Size = new System.Drawing.Size(89, 17);
            this.checkBox_chargeBeam.TabIndex = 1;
            this.checkBox_chargeBeam.Text = "Charge beam";
            this.checkBox_chargeBeam.UseVisualStyleBackColor = true;
            this.checkBox_chargeBeam.CheckedChanged += new System.EventHandler(this.SpriteValueChanged);
            // 
            // checkBox_superMissiles
            // 
            this.checkBox_superMissiles.AutoSize = true;
            this.checkBox_superMissiles.Location = new System.Drawing.Point(9, 88);
            this.checkBox_superMissiles.Name = "checkBox_superMissiles";
            this.checkBox_superMissiles.Size = new System.Drawing.Size(92, 17);
            this.checkBox_superMissiles.TabIndex = 3;
            this.checkBox_superMissiles.Text = "Super missiles";
            this.checkBox_superMissiles.UseVisualStyleBackColor = true;
            this.checkBox_superMissiles.CheckedChanged += new System.EventHandler(this.SpriteValueChanged);
            // 
            // checkBox_missiles
            // 
            this.checkBox_missiles.AutoSize = true;
            this.checkBox_missiles.Location = new System.Drawing.Point(9, 65);
            this.checkBox_missiles.Name = "checkBox_missiles";
            this.checkBox_missiles.Size = new System.Drawing.Size(62, 17);
            this.checkBox_missiles.TabIndex = 2;
            this.checkBox_missiles.Text = "Missiles";
            this.checkBox_missiles.UseVisualStyleBackColor = true;
            this.checkBox_missiles.CheckedChanged += new System.EventHandler(this.SpriteValueChanged);
            // 
            // checkBox_speedScrew
            // 
            this.checkBox_speedScrew.AutoSize = true;
            this.checkBox_speedScrew.Location = new System.Drawing.Point(127, 47);
            this.checkBox_speedScrew.Name = "checkBox_speedScrew";
            this.checkBox_speedScrew.Size = new System.Drawing.Size(95, 30);
            this.checkBox_speedScrew.TabIndex = 5;
            this.checkBox_speedScrew.Text = "Speed booster\r\nScrew attack";
            this.checkBox_speedScrew.UseVisualStyleBackColor = true;
            this.checkBox_speedScrew.CheckedChanged += new System.EventHandler(this.SpriteValueChanged);
            // 
            // checkBox_frozen
            // 
            this.checkBox_frozen.AutoSize = true;
            this.checkBox_frozen.Location = new System.Drawing.Point(127, 88);
            this.checkBox_frozen.Name = "checkBox_frozen";
            this.checkBox_frozen.Size = new System.Drawing.Size(92, 17);
            this.checkBox_frozen.TabIndex = 6;
            this.checkBox_frozen.Text = "Can be frozen";
            this.checkBox_frozen.UseVisualStyleBackColor = true;
            this.checkBox_frozen.CheckedChanged += new System.EventHandler(this.SpriteValueChanged);
            // 
            // groupBox_dropProbability
            // 
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
            this.groupBox_dropProbability.Location = new System.Drawing.Point(381, 40);
            this.groupBox_dropProbability.Name = "groupBox_dropProbability";
            this.groupBox_dropProbability.Size = new System.Drawing.Size(135, 267);
            this.groupBox_dropProbability.TabIndex = 3;
            this.groupBox_dropProbability.TabStop = false;
            this.groupBox_dropProbability.Text = "Drop Probability";
            // 
            // label_totalProb
            // 
            this.label_totalProb.AutoSize = true;
            this.label_totalProb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalProb.Location = new System.Drawing.Point(46, 19);
            this.label_totalProb.Name = "label_totalProb";
            this.label_totalProb.Size = new System.Drawing.Size(25, 13);
            this.label_totalProb.TabIndex = 9;
            this.label_totalProb.Text = "400";
            // 
            // label_powerBomb
            // 
            this.label_powerBomb.AutoSize = true;
            this.label_powerBomb.Location = new System.Drawing.Point(7, 242);
            this.label_powerBomb.Name = "label_powerBomb";
            this.label_powerBomb.Size = new System.Drawing.Size(69, 13);
            this.label_powerBomb.TabIndex = 0;
            this.label_powerBomb.Text = "Power bomb:";
            // 
            // label_superMissile
            // 
            this.label_superMissile.AutoSize = true;
            this.label_superMissile.Location = new System.Drawing.Point(7, 217);
            this.label_superMissile.Name = "label_superMissile";
            this.label_superMissile.Size = new System.Drawing.Size(71, 13);
            this.label_superMissile.TabIndex = 0;
            this.label_superMissile.Text = "Super missile:";
            // 
            // label_missile
            // 
            this.label_missile.AutoSize = true;
            this.label_missile.Location = new System.Drawing.Point(7, 192);
            this.label_missile.Name = "label_missile";
            this.label_missile.Size = new System.Drawing.Size(41, 13);
            this.label_missile.TabIndex = 0;
            this.label_missile.Text = "Missile:";
            // 
            // label_largeHealth
            // 
            this.label_largeHealth.AutoSize = true;
            this.label_largeHealth.Location = new System.Drawing.Point(7, 167);
            this.label_largeHealth.Name = "label_largeHealth";
            this.label_largeHealth.Size = new System.Drawing.Size(69, 13);
            this.label_largeHealth.TabIndex = 0;
            this.label_largeHealth.Text = "Large health:";
            // 
            // label_smallHealth
            // 
            this.label_smallHealth.AutoSize = true;
            this.label_smallHealth.Location = new System.Drawing.Point(7, 142);
            this.label_smallHealth.Name = "label_smallHealth";
            this.label_smallHealth.Size = new System.Drawing.Size(67, 13);
            this.label_smallHealth.TabIndex = 0;
            this.label_smallHealth.Text = "Small health:";
            // 
            // label_noDrop
            // 
            this.label_noDrop.AutoSize = true;
            this.label_noDrop.Location = new System.Drawing.Point(7, 117);
            this.label_noDrop.Name = "label_noDrop";
            this.label_noDrop.Size = new System.Drawing.Size(48, 13);
            this.label_noDrop.TabIndex = 0;
            this.label_noDrop.Text = "No drop:";
            // 
            // textBox_powerBomb
            // 
            this.textBox_powerBomb.Location = new System.Drawing.Point(84, 239);
            this.textBox_powerBomb.Name = "textBox_powerBomb";
            this.textBox_powerBomb.Size = new System.Drawing.Size(40, 20);
            this.textBox_powerBomb.TabIndex = 8;
            this.textBox_powerBomb.TextChanged += new System.EventHandler(this.textBox_dropProb_TextChanged);
            // 
            // textBox_superMissile
            // 
            this.textBox_superMissile.Location = new System.Drawing.Point(84, 214);
            this.textBox_superMissile.Name = "textBox_superMissile";
            this.textBox_superMissile.Size = new System.Drawing.Size(40, 20);
            this.textBox_superMissile.TabIndex = 7;
            this.textBox_superMissile.TextChanged += new System.EventHandler(this.textBox_dropProb_TextChanged);
            // 
            // textBox_missile
            // 
            this.textBox_missile.Location = new System.Drawing.Point(84, 189);
            this.textBox_missile.Name = "textBox_missile";
            this.textBox_missile.Size = new System.Drawing.Size(40, 20);
            this.textBox_missile.TabIndex = 6;
            this.textBox_missile.TextChanged += new System.EventHandler(this.textBox_dropProb_TextChanged);
            // 
            // textBox_largeHealth
            // 
            this.textBox_largeHealth.Location = new System.Drawing.Point(84, 164);
            this.textBox_largeHealth.Name = "textBox_largeHealth";
            this.textBox_largeHealth.Size = new System.Drawing.Size(40, 20);
            this.textBox_largeHealth.TabIndex = 5;
            this.textBox_largeHealth.TextChanged += new System.EventHandler(this.textBox_dropProb_TextChanged);
            // 
            // textBox_smallHealth
            // 
            this.textBox_smallHealth.Location = new System.Drawing.Point(84, 139);
            this.textBox_smallHealth.Name = "textBox_smallHealth";
            this.textBox_smallHealth.Size = new System.Drawing.Size(40, 20);
            this.textBox_smallHealth.TabIndex = 4;
            this.textBox_smallHealth.TextChanged += new System.EventHandler(this.textBox_dropProb_TextChanged);
            // 
            // textBox_noDrop
            // 
            this.textBox_noDrop.Location = new System.Drawing.Point(84, 114);
            this.textBox_noDrop.Name = "textBox_noDrop";
            this.textBox_noDrop.Size = new System.Drawing.Size(40, 20);
            this.textBox_noDrop.TabIndex = 3;
            this.textBox_noDrop.TextChanged += new System.EventHandler(this.textBox_dropProb_TextChanged);
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(6, 19);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(34, 13);
            this.label_total.TabIndex = 0;
            this.label_total.Text = "Total:";
            // 
            // label_healthX
            // 
            this.label_healthX.AutoSize = true;
            this.label_healthX.Location = new System.Drawing.Point(6, 42);
            this.label_healthX.Name = "label_healthX";
            this.label_healthX.Size = new System.Drawing.Size(51, 13);
            this.label_healthX.TabIndex = 0;
            this.label_healthX.Text = "Health X:";
            // 
            // textBox_redX
            // 
            this.textBox_redX.Location = new System.Drawing.Point(84, 89);
            this.textBox_redX.Name = "textBox_redX";
            this.textBox_redX.Size = new System.Drawing.Size(40, 20);
            this.textBox_redX.TabIndex = 2;
            this.textBox_redX.TextChanged += new System.EventHandler(this.textBox_dropProb_TextChanged);
            // 
            // label_missileX
            // 
            this.label_missileX.AutoSize = true;
            this.label_missileX.Location = new System.Drawing.Point(6, 67);
            this.label_missileX.Name = "label_missileX";
            this.label_missileX.Size = new System.Drawing.Size(51, 13);
            this.label_missileX.TabIndex = 0;
            this.label_missileX.Text = "Missile X:";
            // 
            // textBox_missileX
            // 
            this.textBox_missileX.Location = new System.Drawing.Point(84, 64);
            this.textBox_missileX.Name = "textBox_missileX";
            this.textBox_missileX.Size = new System.Drawing.Size(40, 20);
            this.textBox_missileX.TabIndex = 1;
            this.textBox_missileX.TextChanged += new System.EventHandler(this.textBox_dropProb_TextChanged);
            // 
            // label_redX
            // 
            this.label_redX.AutoSize = true;
            this.label_redX.Location = new System.Drawing.Point(6, 92);
            this.label_redX.Name = "label_redX";
            this.label_redX.Size = new System.Drawing.Size(40, 13);
            this.label_redX.TabIndex = 0;
            this.label_redX.Text = "Red X:";
            // 
            // textBox_healthX
            // 
            this.textBox_healthX.Location = new System.Drawing.Point(84, 39);
            this.textBox_healthX.Name = "textBox_healthX";
            this.textBox_healthX.Size = new System.Drawing.Size(40, 20);
            this.textBox_healthX.TabIndex = 0;
            this.textBox_healthX.TextChanged += new System.EventHandler(this.textBox_dropProb_TextChanged);
            // 
            // groupBox_stats
            // 
            this.groupBox_stats.Controls.Add(this.label_health);
            this.groupBox_stats.Controls.Add(this.comboBox_reduction);
            this.groupBox_stats.Controls.Add(this.label_reduction);
            this.groupBox_stats.Controls.Add(this.textBox_damage);
            this.groupBox_stats.Controls.Add(this.textBox_health);
            this.groupBox_stats.Controls.Add(this.label_damage);
            this.groupBox_stats.Location = new System.Drawing.Point(262, 40);
            this.groupBox_stats.Name = "groupBox_stats";
            this.groupBox_stats.Size = new System.Drawing.Size(113, 115);
            this.groupBox_stats.TabIndex = 2;
            this.groupBox_stats.TabStop = false;
            this.groupBox_stats.Text = "Stats";
            // 
            // label_health
            // 
            this.label_health.AutoSize = true;
            this.label_health.Location = new System.Drawing.Point(6, 18);
            this.label_health.Name = "label_health";
            this.label_health.Size = new System.Drawing.Size(41, 13);
            this.label_health.TabIndex = 0;
            this.label_health.Text = "Health:";
            // 
            // comboBox_reduction
            // 
            this.comboBox_reduction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_reduction.FormattingEnabled = true;
            this.comboBox_reduction.Items.AddRange(new object[] {
            "30% and 10%",
            "60% and 30%",
            "80% and 10%",
            "90% and 80%"});
            this.comboBox_reduction.Location = new System.Drawing.Point(9, 86);
            this.comboBox_reduction.Name = "comboBox_reduction";
            this.comboBox_reduction.Size = new System.Drawing.Size(95, 21);
            this.comboBox_reduction.TabIndex = 2;
            this.comboBox_reduction.SelectedIndexChanged += new System.EventHandler(this.SpriteValueChanged);
            // 
            // label_reduction
            // 
            this.label_reduction.AutoSize = true;
            this.label_reduction.Location = new System.Drawing.Point(6, 70);
            this.label_reduction.Name = "label_reduction";
            this.label_reduction.Size = new System.Drawing.Size(75, 13);
            this.label_reduction.TabIndex = 0;
            this.label_reduction.Text = "Suit reduction:";
            // 
            // textBox_damage
            // 
            this.textBox_damage.Location = new System.Drawing.Point(62, 41);
            this.textBox_damage.Name = "textBox_damage";
            this.textBox_damage.Size = new System.Drawing.Size(42, 20);
            this.textBox_damage.TabIndex = 1;
            this.textBox_damage.TextChanged += new System.EventHandler(this.SpriteValueChanged);
            // 
            // textBox_health
            // 
            this.textBox_health.Location = new System.Drawing.Point(62, 15);
            this.textBox_health.Name = "textBox_health";
            this.textBox_health.Size = new System.Drawing.Size(42, 20);
            this.textBox_health.TabIndex = 0;
            this.textBox_health.TextChanged += new System.EventHandler(this.SpriteValueChanged);
            // 
            // label_damage
            // 
            this.label_damage.AutoSize = true;
            this.label_damage.Location = new System.Drawing.Point(6, 44);
            this.label_damage.Name = "label_damage";
            this.label_damage.Size = new System.Drawing.Size(50, 13);
            this.label_damage.TabIndex = 0;
            this.label_damage.Text = "Damage:";
            // 
            // button_apply
            // 
            this.button_apply.Enabled = false;
            this.button_apply.Location = new System.Drawing.Point(219, 278);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(75, 23);
            this.button_apply.TabIndex = 6;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(300, 278);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 7;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label_sprite
            // 
            this.label_sprite.AutoSize = true;
            this.label_sprite.Location = new System.Drawing.Point(262, 16);
            this.label_sprite.Name = "label_sprite";
            this.label_sprite.Size = new System.Drawing.Size(37, 13);
            this.label_sprite.TabIndex = 0;
            this.label_sprite.Text = "Sprite:";
            // 
            // comboBox_sprite
            // 
            this.comboBox_sprite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sprite.FormattingEnabled = true;
            this.comboBox_sprite.Location = new System.Drawing.Point(303, 13);
            this.comboBox_sprite.Name = "comboBox_sprite";
            this.comboBox_sprite.Size = new System.Drawing.Size(55, 21);
            this.comboBox_sprite.TabIndex = 0;
            this.comboBox_sprite.SelectedIndexChanged += new System.EventHandler(this.comboBox_sprite_SelectedIndexChanged);
            // 
            // button_editPalette
            // 
            this.button_editPalette.Location = new System.Drawing.Point(65, 103);
            this.button_editPalette.Name = "button_editPalette";
            this.button_editPalette.Size = new System.Drawing.Size(60, 22);
            this.button_editPalette.TabIndex = 3;
            this.button_editPalette.Text = "Edit";
            this.button_editPalette.UseVisualStyleBackColor = true;
            this.button_editPalette.Click += new System.EventHandler(this.button_editPalette_Click);
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(399, 16);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(34, 13);
            this.label_type.TabIndex = 0;
            this.label_type.Text = "Type:";
            // 
            // comboBox_type
            // 
            this.comboBox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "Primary",
            "Secondary"});
            this.comboBox_type.Location = new System.Drawing.Point(439, 13);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(77, 21);
            this.comboBox_type.TabIndex = 1;
            this.comboBox_type.SelectedIndexChanged += new System.EventHandler(this.comboBox_type_SelectedIndexChanged);
            // 
            // pictureBox_preview
            // 
            this.pictureBox_preview.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_preview.Name = "pictureBox_preview";
            this.pictureBox_preview.Size = new System.Drawing.Size(215, 101);
            this.pictureBox_preview.TabIndex = 34;
            this.pictureBox_preview.TabStop = false;
            // 
            // groupBox_preview
            // 
            this.groupBox_preview.Controls.Add(this.panel_preview);
            this.groupBox_preview.Location = new System.Drawing.Point(12, 12);
            this.groupBox_preview.Name = "groupBox_preview";
            this.groupBox_preview.Size = new System.Drawing.Size(244, 143);
            this.groupBox_preview.TabIndex = 0;
            this.groupBox_preview.TabStop = false;
            this.groupBox_preview.Text = "Preview";
            // 
            // panel_preview
            // 
            this.panel_preview.AutoScroll = true;
            this.panel_preview.Controls.Add(this.pictureBox_preview);
            this.panel_preview.Location = new System.Drawing.Point(6, 19);
            this.panel_preview.Name = "panel_preview";
            this.panel_preview.Size = new System.Drawing.Size(232, 118);
            this.panel_preview.TabIndex = 0;
            // 
            // textBox_gfxOffsetVal
            // 
            this.textBox_gfxOffsetVal.Location = new System.Drawing.Point(7, 34);
            this.textBox_gfxOffsetVal.Name = "textBox_gfxOffsetVal";
            this.textBox_gfxOffsetVal.Size = new System.Drawing.Size(52, 20);
            this.textBox_gfxOffsetVal.TabIndex = 0;
            this.textBox_gfxOffsetVal.TextChanged += new System.EventHandler(this.SpriteValueChanged);
            // 
            // label_gfxOffset
            // 
            this.label_gfxOffset.AutoSize = true;
            this.label_gfxOffset.Location = new System.Drawing.Point(6, 18);
            this.label_gfxOffset.Name = "label_gfxOffset";
            this.label_gfxOffset.Size = new System.Drawing.Size(60, 13);
            this.label_gfxOffset.TabIndex = 0;
            this.label_gfxOffset.Text = "GFX offset:";
            // 
            // button_editGFX
            // 
            this.button_editGFX.Location = new System.Drawing.Point(65, 33);
            this.button_editGFX.Name = "button_editGFX";
            this.button_editGFX.Size = new System.Drawing.Size(60, 22);
            this.button_editGFX.TabIndex = 1;
            this.button_editGFX.Text = "Edit";
            this.button_editGFX.UseVisualStyleBackColor = true;
            this.button_editGFX.Click += new System.EventHandler(this.button_editGFX_Click);
            // 
            // label_palOffset
            // 
            this.label_palOffset.AutoSize = true;
            this.label_palOffset.Location = new System.Drawing.Point(6, 88);
            this.label_palOffset.Name = "label_palOffset";
            this.label_palOffset.Size = new System.Drawing.Size(72, 13);
            this.label_palOffset.TabIndex = 0;
            this.label_palOffset.Text = "Palette offset:";
            // 
            // textBox_palOffsetVal
            // 
            this.textBox_palOffsetVal.Location = new System.Drawing.Point(7, 104);
            this.textBox_palOffsetVal.Name = "textBox_palOffsetVal";
            this.textBox_palOffsetVal.Size = new System.Drawing.Size(52, 20);
            this.textBox_palOffsetVal.TabIndex = 2;
            this.textBox_palOffsetVal.TextChanged += new System.EventHandler(this.SpriteValueChanged);
            // 
            // groupBox_graphics
            // 
            this.groupBox_graphics.Controls.Add(this.numericUpDown_gfxRows);
            this.groupBox_graphics.Controls.Add(this.label_gfxOffset);
            this.groupBox_graphics.Controls.Add(this.label_gfxRows);
            this.groupBox_graphics.Controls.Add(this.label_palOffset);
            this.groupBox_graphics.Controls.Add(this.button_editPalette);
            this.groupBox_graphics.Controls.Add(this.textBox_palOffsetVal);
            this.groupBox_graphics.Controls.Add(this.textBox_gfxOffsetVal);
            this.groupBox_graphics.Controls.Add(this.button_editGFX);
            this.groupBox_graphics.Location = new System.Drawing.Point(12, 161);
            this.groupBox_graphics.Name = "groupBox_graphics";
            this.groupBox_graphics.Size = new System.Drawing.Size(131, 131);
            this.groupBox_graphics.TabIndex = 4;
            this.groupBox_graphics.TabStop = false;
            this.groupBox_graphics.Text = "Graphics";
            // 
            // label_AI
            // 
            this.label_AI.AutoSize = true;
            this.label_AI.Location = new System.Drawing.Point(149, 275);
            this.label_AI.Name = "label_AI";
            this.label_AI.Size = new System.Drawing.Size(49, 13);
            this.label_AI.TabIndex = 0;
            this.label_AI.Text = "AI offset:";
            // 
            // textBox_AIoffset
            // 
            this.textBox_AIoffset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_AIoffset.Location = new System.Drawing.Point(152, 291);
            this.textBox_AIoffset.Name = "textBox_AIoffset";
            this.textBox_AIoffset.ReadOnly = true;
            this.textBox_AIoffset.Size = new System.Drawing.Size(55, 13);
            this.textBox_AIoffset.TabIndex = 0;
            this.textBox_AIoffset.TabStop = false;
            this.textBox_AIoffset.Text = "000000";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_changes});
            this.statusStrip.Location = new System.Drawing.Point(0, 310);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(528, 22);
            this.statusStrip.TabIndex = 8;
            // 
            // statusLabel_changes
            // 
            this.statusLabel_changes.Name = "statusLabel_changes";
            this.statusLabel_changes.Size = new System.Drawing.Size(12, 17);
            this.statusLabel_changes.Text = "-";
            // 
            // label_gfxRows
            // 
            this.label_gfxRows.AutoSize = true;
            this.label_gfxRows.Location = new System.Drawing.Point(6, 63);
            this.label_gfxRows.Name = "label_gfxRows";
            this.label_gfxRows.Size = new System.Drawing.Size(56, 13);
            this.label_gfxRows.TabIndex = 9;
            this.label_gfxRows.Text = "GFX rows:";
            // 
            // numericUpDown_gfxRows
            // 
            this.numericUpDown_gfxRows.Location = new System.Drawing.Point(68, 61);
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
            this.numericUpDown_gfxRows.Size = new System.Drawing.Size(35, 20);
            this.numericUpDown_gfxRows.TabIndex = 10;
            this.numericUpDown_gfxRows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_gfxRows.ValueChanged += new System.EventHandler(this.SpriteValueChanged);
            // 
            // FormSprite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 332);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.textBox_AIoffset);
            this.Controls.Add(this.label_AI);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSprite";
            this.Text = "Sprite Editor";
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
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_gfxRows)).EndInit();
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
        private mage.Theming.CustomControls.FlatTextBox textBox_redX;
        private System.Windows.Forms.Label label_missileX;
        private mage.Theming.CustomControls.FlatTextBox textBox_missileX;
        private System.Windows.Forms.Label label_redX;
        private mage.Theming.CustomControls.FlatTextBox textBox_healthX;
        private System.Windows.Forms.GroupBox groupBox_stats;
        private System.Windows.Forms.Label label_health;
        private mage.Theming.CustomControls.FlatComboBox comboBox_reduction;
        private System.Windows.Forms.Label label_reduction;
        private mage.Theming.CustomControls.FlatTextBox textBox_damage;
        private mage.Theming.CustomControls.FlatTextBox textBox_health;
        private System.Windows.Forms.Label label_damage;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_sprite;
        private mage.Theming.CustomControls.FlatComboBox comboBox_sprite;
        private System.Windows.Forms.CheckBox checkBox_powerBombs;
        private System.Windows.Forms.Button button_editPalette;
        private System.Windows.Forms.Label label_type;
        private mage.Theming.CustomControls.FlatComboBox comboBox_type;
        private System.Windows.Forms.PictureBox pictureBox_preview;
        private System.Windows.Forms.GroupBox groupBox_preview;
        private mage.Theming.CustomControls.FlatTextBox textBox_gfxOffsetVal;
        private System.Windows.Forms.Label label_gfxOffset;
        private System.Windows.Forms.Label label_powerBomb;
        private System.Windows.Forms.Label label_superMissile;
        private System.Windows.Forms.Label label_missile;
        private System.Windows.Forms.Label label_largeHealth;
        private System.Windows.Forms.Label label_smallHealth;
        private System.Windows.Forms.Label label_noDrop;
        private mage.Theming.CustomControls.FlatTextBox textBox_powerBomb;
        private mage.Theming.CustomControls.FlatTextBox textBox_superMissile;
        private mage.Theming.CustomControls.FlatTextBox textBox_missile;
        private mage.Theming.CustomControls.FlatTextBox textBox_largeHealth;
        private mage.Theming.CustomControls.FlatTextBox textBox_smallHealth;
        private mage.Theming.CustomControls.FlatTextBox textBox_noDrop;
        private System.Windows.Forms.Panel panel_preview;
        private System.Windows.Forms.Button button_editGFX;
        private System.Windows.Forms.Label label_palOffset;
        private mage.Theming.CustomControls.FlatTextBox textBox_palOffsetVal;
        private System.Windows.Forms.GroupBox groupBox_graphics;
        private System.Windows.Forms.Label label_AI;
        private mage.Theming.CustomControls.FlatTextBox textBox_AIoffset;
        private System.Windows.Forms.Label label_totalProb;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_changes;
        private mage.Theming.CustomControls.FlatNumericUpDown numericUpDown_gfxRows;
        private System.Windows.Forms.Label label_gfxRows;
    }
}