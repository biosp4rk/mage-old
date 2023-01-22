namespace mage
{
    partial class FormPalette
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPalette));
            this.pictureBox_palette = new System.Windows.Forms.PictureBox();
            this.pictureBox_chosenColor = new System.Windows.Forms.PictureBox();
            this.comboBox_tileset = new System.Windows.Forms.ComboBox();
            this.groupBox_offset = new System.Windows.Forms.GroupBox();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_go = new System.Windows.Forms.Button();
            this.numericUpDown_rows = new System.Windows.Forms.NumericUpDown();
            this.label_numOfRows = new System.Windows.Forms.Label();
            this.textBox_offset = new System.Windows.Forms.TextBox();
            this.comboBox_sprite = new System.Windows.Forms.ComboBox();
            this.label_red = new System.Windows.Forms.Label();
            this.label_green = new System.Windows.Forms.Label();
            this.label_blue = new System.Windows.Forms.Label();
            this.numericUpDown_red = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_green = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_blue = new System.Windows.Forms.NumericUpDown();
            this.button_apply = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.label_15bit = new System.Windows.Forms.Label();
            this.label_15bitVal = new System.Windows.Forms.Label();
            this.pictureBox_red = new System.Windows.Forms.PictureBox();
            this.pictureBox_green = new System.Windows.Forms.PictureBox();
            this.pictureBox_blue = new System.Windows.Forms.PictureBox();
            this.groupBox_color = new System.Windows.Forms.GroupBox();
            this.groupBox_shortcuts = new System.Windows.Forms.GroupBox();
            this.label_sprite = new System.Windows.Forms.Label();
            this.label_tileset = new System.Windows.Forms.Label();
            this.label_24bitVal = new System.Windows.Forms.Label();
            this.label_24bit = new System.Windows.Forms.Label();
            this.groupBox_info = new System.Windows.Forms.GroupBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel_changes = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip_spring = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip_import = new System.Windows.Forms.ToolStripDropDownButton();
            this.statusStrip_importRaw = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_importTLP = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_importYY = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_export = new System.Windows.Forms.ToolStripDropDownButton();
            this.statusStrip_exportRaw = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_exportTLP = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_exportYY = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_palette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chosenColor)).BeginInit();
            this.groupBox_offset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_blue)).BeginInit();
            this.groupBox_color.SuspendLayout();
            this.groupBox_shortcuts.SuspendLayout();
            this.groupBox_info.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_palette
            // 
            this.pictureBox_palette.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_palette.Name = "pictureBox_palette";
            this.pictureBox_palette.Size = new System.Drawing.Size(273, 273);
            this.pictureBox_palette.TabIndex = 0;
            this.pictureBox_palette.TabStop = false;
            this.pictureBox_palette.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_palette_MouseClick);
            // 
            // pictureBox_chosenColor
            // 
            this.pictureBox_chosenColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_chosenColor.Location = new System.Drawing.Point(6, 18);
            this.pictureBox_chosenColor.Name = "pictureBox_chosenColor";
            this.pictureBox_chosenColor.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_chosenColor.TabIndex = 2;
            this.pictureBox_chosenColor.TabStop = false;
            // 
            // comboBox_tileset
            // 
            this.comboBox_tileset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tileset.FormattingEnabled = true;
            this.comboBox_tileset.Location = new System.Drawing.Point(53, 19);
            this.comboBox_tileset.Name = "comboBox_tileset";
            this.comboBox_tileset.Size = new System.Drawing.Size(45, 21);
            this.comboBox_tileset.TabIndex = 0;
            this.comboBox_tileset.SelectedIndexChanged += new System.EventHandler(this.comboBox_tileset_SelectedIndexChanged);
            // 
            // groupBox_offset
            // 
            this.groupBox_offset.Controls.Add(this.button_minus);
            this.groupBox_offset.Controls.Add(this.button_plus);
            this.groupBox_offset.Controls.Add(this.button_go);
            this.groupBox_offset.Controls.Add(this.numericUpDown_rows);
            this.groupBox_offset.Controls.Add(this.label_numOfRows);
            this.groupBox_offset.Controls.Add(this.textBox_offset);
            this.groupBox_offset.Location = new System.Drawing.Point(291, 12);
            this.groupBox_offset.Name = "groupBox_offset";
            this.groupBox_offset.Size = new System.Drawing.Size(155, 73);
            this.groupBox_offset.TabIndex = 0;
            this.groupBox_offset.TabStop = false;
            this.groupBox_offset.Text = "Offset";
            // 
            // button_minus
            // 
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minus.Location = new System.Drawing.Point(34, 43);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(22, 22);
            this.button_minus.TabIndex = 3;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_plus
            // 
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_plus.Location = new System.Drawing.Point(6, 43);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(22, 22);
            this.button_plus.TabIndex = 2;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_go
            // 
            this.button_go.Location = new System.Drawing.Point(92, 18);
            this.button_go.Name = "button_go";
            this.button_go.Size = new System.Drawing.Size(55, 22);
            this.button_go.TabIndex = 1;
            this.button_go.Text = "Go";
            this.button_go.UseVisualStyleBackColor = true;
            this.button_go.Click += new System.EventHandler(this.button_go_Click);
            // 
            // numericUpDown_rows
            // 
            this.numericUpDown_rows.Hexadecimal = true;
            this.numericUpDown_rows.Location = new System.Drawing.Point(104, 45);
            this.numericUpDown_rows.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDown_rows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_rows.Name = "numericUpDown_rows";
            this.numericUpDown_rows.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown_rows.TabIndex = 4;
            this.numericUpDown_rows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_numOfRows
            // 
            this.label_numOfRows.AutoSize = true;
            this.label_numOfRows.Location = new System.Drawing.Point(64, 47);
            this.label_numOfRows.Name = "label_numOfRows";
            this.label_numOfRows.Size = new System.Drawing.Size(37, 13);
            this.label_numOfRows.TabIndex = 0;
            this.label_numOfRows.Text = "Rows:";
            // 
            // textBox_offset
            // 
            this.textBox_offset.Location = new System.Drawing.Point(6, 19);
            this.textBox_offset.Name = "textBox_offset";
            this.textBox_offset.Size = new System.Drawing.Size(80, 20);
            this.textBox_offset.TabIndex = 0;
            // 
            // comboBox_sprite
            // 
            this.comboBox_sprite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sprite.FormattingEnabled = true;
            this.comboBox_sprite.Location = new System.Drawing.Point(53, 46);
            this.comboBox_sprite.Name = "comboBox_sprite";
            this.comboBox_sprite.Size = new System.Drawing.Size(45, 21);
            this.comboBox_sprite.TabIndex = 1;
            this.comboBox_sprite.SelectedIndexChanged += new System.EventHandler(this.comboBox_sprite_SelectedIndexChanged);
            // 
            // label_red
            // 
            this.label_red.AutoSize = true;
            this.label_red.Location = new System.Drawing.Point(6, 21);
            this.label_red.Name = "label_red";
            this.label_red.Size = new System.Drawing.Size(30, 13);
            this.label_red.TabIndex = 0;
            this.label_red.Text = "Red:";
            // 
            // label_green
            // 
            this.label_green.AutoSize = true;
            this.label_green.Location = new System.Drawing.Point(6, 50);
            this.label_green.Name = "label_green";
            this.label_green.Size = new System.Drawing.Size(39, 13);
            this.label_green.TabIndex = 0;
            this.label_green.Text = "Green:";
            // 
            // label_blue
            // 
            this.label_blue.AutoSize = true;
            this.label_blue.Location = new System.Drawing.Point(6, 79);
            this.label_blue.Name = "label_blue";
            this.label_blue.Size = new System.Drawing.Size(31, 13);
            this.label_blue.TabIndex = 0;
            this.label_blue.Text = "Blue:";
            // 
            // numericUpDown_red
            // 
            this.numericUpDown_red.Hexadecimal = true;
            this.numericUpDown_red.Location = new System.Drawing.Point(49, 19);
            this.numericUpDown_red.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown_red.Name = "numericUpDown_red";
            this.numericUpDown_red.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown_red.TabIndex = 0;
            this.numericUpDown_red.ValueChanged += new System.EventHandler(this.numericUpDown_red_ValueChanged);
            // 
            // numericUpDown_green
            // 
            this.numericUpDown_green.Hexadecimal = true;
            this.numericUpDown_green.Location = new System.Drawing.Point(49, 48);
            this.numericUpDown_green.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown_green.Name = "numericUpDown_green";
            this.numericUpDown_green.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown_green.TabIndex = 1;
            this.numericUpDown_green.ValueChanged += new System.EventHandler(this.numericUpDown_green_ValueChanged);
            // 
            // numericUpDown_blue
            // 
            this.numericUpDown_blue.Hexadecimal = true;
            this.numericUpDown_blue.Location = new System.Drawing.Point(49, 77);
            this.numericUpDown_blue.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown_blue.Name = "numericUpDown_blue";
            this.numericUpDown_blue.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown_blue.TabIndex = 2;
            this.numericUpDown_blue.ValueChanged += new System.EventHandler(this.numericUpDown_blue_ValueChanged);
            // 
            // button_apply
            // 
            this.button_apply.Enabled = false;
            this.button_apply.Location = new System.Drawing.Point(451, 211);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(70, 23);
            this.button_apply.TabIndex = 3;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(451, 239);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(70, 23);
            this.button_close.TabIndex = 4;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label_15bit
            // 
            this.label_15bit.AutoSize = true;
            this.label_15bit.Location = new System.Drawing.Point(40, 18);
            this.label_15bit.Name = "label_15bit";
            this.label_15bit.Size = new System.Drawing.Size(36, 13);
            this.label_15bit.TabIndex = 18;
            this.label_15bit.Text = "15-bit:";
            // 
            // label_15bitVal
            // 
            this.label_15bitVal.AutoSize = true;
            this.label_15bitVal.Location = new System.Drawing.Point(76, 18);
            this.label_15bitVal.Name = "label_15bitVal";
            this.label_15bitVal.Size = new System.Drawing.Size(42, 13);
            this.label_15bitVal.TabIndex = 19;
            this.label_15bitVal.Text = "0x0000";
            // 
            // pictureBox_red
            // 
            this.pictureBox_red.Location = new System.Drawing.Point(98, 19);
            this.pictureBox_red.Name = "pictureBox_red";
            this.pictureBox_red.Size = new System.Drawing.Size(128, 20);
            this.pictureBox_red.TabIndex = 21;
            this.pictureBox_red.TabStop = false;
            this.pictureBox_red.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_red_MouseDown);
            this.pictureBox_red.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_red_MouseMove);
            // 
            // pictureBox_green
            // 
            this.pictureBox_green.Location = new System.Drawing.Point(98, 48);
            this.pictureBox_green.Name = "pictureBox_green";
            this.pictureBox_green.Size = new System.Drawing.Size(128, 20);
            this.pictureBox_green.TabIndex = 22;
            this.pictureBox_green.TabStop = false;
            this.pictureBox_green.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_green_MouseDown);
            this.pictureBox_green.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_green_MouseMove);
            // 
            // pictureBox_blue
            // 
            this.pictureBox_blue.Location = new System.Drawing.Point(98, 77);
            this.pictureBox_blue.Name = "pictureBox_blue";
            this.pictureBox_blue.Size = new System.Drawing.Size(128, 20);
            this.pictureBox_blue.TabIndex = 23;
            this.pictureBox_blue.TabStop = false;
            this.pictureBox_blue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_blue_MouseDown);
            this.pictureBox_blue.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_blue_MouseMove);
            // 
            // groupBox_color
            // 
            this.groupBox_color.Controls.Add(this.label_red);
            this.groupBox_color.Controls.Add(this.pictureBox_blue);
            this.groupBox_color.Controls.Add(this.label_green);
            this.groupBox_color.Controls.Add(this.pictureBox_green);
            this.groupBox_color.Controls.Add(this.label_blue);
            this.groupBox_color.Controls.Add(this.pictureBox_red);
            this.groupBox_color.Controls.Add(this.numericUpDown_red);
            this.groupBox_color.Controls.Add(this.numericUpDown_green);
            this.groupBox_color.Controls.Add(this.numericUpDown_blue);
            this.groupBox_color.Enabled = false;
            this.groupBox_color.Location = new System.Drawing.Point(291, 91);
            this.groupBox_color.Name = "groupBox_color";
            this.groupBox_color.Size = new System.Drawing.Size(234, 109);
            this.groupBox_color.TabIndex = 2;
            this.groupBox_color.TabStop = false;
            this.groupBox_color.Text = "Color Selector";
            // 
            // groupBox_shortcuts
            // 
            this.groupBox_shortcuts.Controls.Add(this.label_sprite);
            this.groupBox_shortcuts.Controls.Add(this.label_tileset);
            this.groupBox_shortcuts.Controls.Add(this.comboBox_sprite);
            this.groupBox_shortcuts.Controls.Add(this.comboBox_tileset);
            this.groupBox_shortcuts.Location = new System.Drawing.Point(452, 12);
            this.groupBox_shortcuts.Name = "groupBox_shortcuts";
            this.groupBox_shortcuts.Size = new System.Drawing.Size(106, 73);
            this.groupBox_shortcuts.TabIndex = 1;
            this.groupBox_shortcuts.TabStop = false;
            this.groupBox_shortcuts.Text = "Shortcuts";
            // 
            // label_sprite
            // 
            this.label_sprite.AutoSize = true;
            this.label_sprite.Location = new System.Drawing.Point(6, 49);
            this.label_sprite.Name = "label_sprite";
            this.label_sprite.Size = new System.Drawing.Size(37, 13);
            this.label_sprite.TabIndex = 0;
            this.label_sprite.Text = "Sprite:";
            // 
            // label_tileset
            // 
            this.label_tileset.AutoSize = true;
            this.label_tileset.Location = new System.Drawing.Point(6, 22);
            this.label_tileset.Name = "label_tileset";
            this.label_tileset.Size = new System.Drawing.Size(41, 13);
            this.label_tileset.TabIndex = 0;
            this.label_tileset.Text = "Tileset:";
            // 
            // label_24bitVal
            // 
            this.label_24bitVal.AutoSize = true;
            this.label_24bitVal.Location = new System.Drawing.Point(76, 33);
            this.label_24bitVal.Name = "label_24bitVal";
            this.label_24bitVal.Size = new System.Drawing.Size(37, 13);
            this.label_24bitVal.TabIndex = 27;
            this.label_24bitVal.Text = "0, 0, 0";
            // 
            // label_24bit
            // 
            this.label_24bit.AutoSize = true;
            this.label_24bit.Location = new System.Drawing.Point(40, 33);
            this.label_24bit.Name = "label_24bit";
            this.label_24bit.Size = new System.Drawing.Size(36, 13);
            this.label_24bit.TabIndex = 26;
            this.label_24bit.Text = "24-bit:";
            // 
            // groupBox_info
            // 
            this.groupBox_info.Controls.Add(this.pictureBox_chosenColor);
            this.groupBox_info.Controls.Add(this.label_24bitVal);
            this.groupBox_info.Controls.Add(this.label_15bit);
            this.groupBox_info.Controls.Add(this.label_24bit);
            this.groupBox_info.Controls.Add(this.label_15bitVal);
            this.groupBox_info.Location = new System.Drawing.Point(291, 206);
            this.groupBox_info.Name = "groupBox_info";
            this.groupBox_info.Size = new System.Drawing.Size(154, 55);
            this.groupBox_info.TabIndex = 0;
            this.groupBox_info.TabStop = false;
            this.groupBox_info.Text = "Info";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_changes,
            this.statusStrip_spring,
            this.statusStrip_import,
            this.statusStrip_export});
            this.statusStrip.Location = new System.Drawing.Point(0, 288);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(570, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusLabel_changes
            // 
            this.statusLabel_changes.Name = "statusLabel_changes";
            this.statusLabel_changes.Size = new System.Drawing.Size(12, 17);
            this.statusLabel_changes.Text = "-";
            // 
            // statusStrip_spring
            // 
            this.statusStrip_spring.Name = "statusStrip_spring";
            this.statusStrip_spring.Size = new System.Drawing.Size(434, 17);
            this.statusStrip_spring.Spring = true;
            // 
            // statusStrip_import
            // 
            this.statusStrip_import.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusStrip_import.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip_importRaw,
            this.statusStrip_importTLP,
            this.statusStrip_importYY});
            this.statusStrip_import.Name = "statusStrip_import";
            this.statusStrip_import.Size = new System.Drawing.Size(56, 20);
            this.statusStrip_import.Text = "Import";
            // 
            // statusStrip_importRaw
            // 
            this.statusStrip_importRaw.Name = "statusStrip_importRaw";
            this.statusStrip_importRaw.Size = new System.Drawing.Size(154, 22);
            this.statusStrip_importRaw.Text = "Raw...";
            this.statusStrip_importRaw.Click += new System.EventHandler(this.statusStrip_importRaw_Click);
            // 
            // statusStrip_importTLP
            // 
            this.statusStrip_importTLP.Name = "statusStrip_importTLP";
            this.statusStrip_importTLP.Size = new System.Drawing.Size(154, 22);
            this.statusStrip_importTLP.Text = "Tile Layer Pro...";
            this.statusStrip_importTLP.Click += new System.EventHandler(this.statusStrip_importTLP_Click);
            // 
            // statusStrip_importYY
            // 
            this.statusStrip_importYY.Name = "statusStrip_importYY";
            this.statusStrip_importYY.Size = new System.Drawing.Size(154, 22);
            this.statusStrip_importYY.Text = "YY-CHR...";
            this.statusStrip_importYY.Click += new System.EventHandler(this.statusStrip_importYY_Click);
            // 
            // statusStrip_export
            // 
            this.statusStrip_export.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusStrip_export.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip_exportRaw,
            this.statusStrip_exportTLP,
            this.statusStrip_exportYY});
            this.statusStrip_export.Name = "statusStrip_export";
            this.statusStrip_export.Size = new System.Drawing.Size(53, 20);
            this.statusStrip_export.Text = "Export";
            // 
            // statusStrip_exportRaw
            // 
            this.statusStrip_exportRaw.Name = "statusStrip_exportRaw";
            this.statusStrip_exportRaw.Size = new System.Drawing.Size(154, 22);
            this.statusStrip_exportRaw.Text = "Raw...";
            this.statusStrip_exportRaw.Click += new System.EventHandler(this.statusStrip_exportRaw_Click);
            // 
            // statusStrip_exportTLP
            // 
            this.statusStrip_exportTLP.Name = "statusStrip_exportTLP";
            this.statusStrip_exportTLP.Size = new System.Drawing.Size(154, 22);
            this.statusStrip_exportTLP.Text = "Tile Layer Pro...";
            this.statusStrip_exportTLP.Click += new System.EventHandler(this.statusStrip_exportTLP_Click);
            // 
            // statusStrip_exportYY
            // 
            this.statusStrip_exportYY.Name = "statusStrip_exportYY";
            this.statusStrip_exportYY.Size = new System.Drawing.Size(154, 22);
            this.statusStrip_exportYY.Text = "YY-CHR...";
            this.statusStrip_exportYY.Click += new System.EventHandler(this.statusStrip_exportYY_Click);
            // 
            // FormPalette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 310);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox_info);
            this.Controls.Add(this.groupBox_shortcuts);
            this.Controls.Add(this.groupBox_color);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.groupBox_offset);
            this.Controls.Add(this.pictureBox_palette);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPalette";
            this.Text = "Palette Editor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_palette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_chosenColor)).EndInit();
            this.groupBox_offset.ResumeLayout(false);
            this.groupBox_offset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_blue)).EndInit();
            this.groupBox_color.ResumeLayout(false);
            this.groupBox_color.PerformLayout();
            this.groupBox_shortcuts.ResumeLayout(false);
            this.groupBox_shortcuts.PerformLayout();
            this.groupBox_info.ResumeLayout(false);
            this.groupBox_info.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_palette;
        private System.Windows.Forms.PictureBox pictureBox_chosenColor;
        private System.Windows.Forms.ComboBox comboBox_tileset;
        private System.Windows.Forms.GroupBox groupBox_offset;
        private System.Windows.Forms.Button button_go;
        private System.Windows.Forms.NumericUpDown numericUpDown_rows;
        private System.Windows.Forms.Label label_numOfRows;
        private System.Windows.Forms.TextBox textBox_offset;
        private System.Windows.Forms.ComboBox comboBox_sprite;
        private System.Windows.Forms.Label label_red;
        private System.Windows.Forms.Label label_green;
        private System.Windows.Forms.Label label_blue;
        private System.Windows.Forms.NumericUpDown numericUpDown_red;
        private System.Windows.Forms.NumericUpDown numericUpDown_green;
        private System.Windows.Forms.NumericUpDown numericUpDown_blue;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_15bit;
        private System.Windows.Forms.Label label_15bitVal;
        private System.Windows.Forms.PictureBox pictureBox_red;
        private System.Windows.Forms.PictureBox pictureBox_green;
        private System.Windows.Forms.PictureBox pictureBox_blue;
        private System.Windows.Forms.GroupBox groupBox_color;
        private System.Windows.Forms.GroupBox groupBox_shortcuts;
        private System.Windows.Forms.Label label_sprite;
        private System.Windows.Forms.Label label_tileset;
        private System.Windows.Forms.Label label_24bitVal;
        private System.Windows.Forms.Label label_24bit;
        private System.Windows.Forms.GroupBox groupBox_info;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_changes;
        private System.Windows.Forms.ToolStripDropDownButton statusStrip_import;
        private System.Windows.Forms.ToolStripDropDownButton statusStrip_export;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip_spring;
        private System.Windows.Forms.ToolStripMenuItem statusStrip_importTLP;
        private System.Windows.Forms.ToolStripMenuItem statusStrip_importRaw;
        private System.Windows.Forms.ToolStripMenuItem statusStrip_importYY;
        private System.Windows.Forms.ToolStripMenuItem statusStrip_exportRaw;
        private System.Windows.Forms.ToolStripMenuItem statusStrip_exportTLP;
        private System.Windows.Forms.ToolStripMenuItem statusStrip_exportYY;
    }
}