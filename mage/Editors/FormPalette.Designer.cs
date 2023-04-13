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
            resources.ApplyResources(this.pictureBox_palette, "pictureBox_palette");
            this.pictureBox_palette.Name = "pictureBox_palette";
            this.pictureBox_palette.TabStop = false;
            this.pictureBox_palette.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_palette_MouseClick);
            // 
            // pictureBox_chosenColor
            // 
            resources.ApplyResources(this.pictureBox_chosenColor, "pictureBox_chosenColor");
            this.pictureBox_chosenColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_chosenColor.Name = "pictureBox_chosenColor";
            this.pictureBox_chosenColor.TabStop = false;
            // 
            // comboBox_tileset
            // 
            resources.ApplyResources(this.comboBox_tileset, "comboBox_tileset");
            this.comboBox_tileset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tileset.FormattingEnabled = true;
            this.comboBox_tileset.Name = "comboBox_tileset";
            this.comboBox_tileset.SelectedIndexChanged += new System.EventHandler(this.comboBox_tileset_SelectedIndexChanged);
            // 
            // groupBox_offset
            // 
            resources.ApplyResources(this.groupBox_offset, "groupBox_offset");
            this.groupBox_offset.Controls.Add(this.button_minus);
            this.groupBox_offset.Controls.Add(this.button_plus);
            this.groupBox_offset.Controls.Add(this.button_go);
            this.groupBox_offset.Controls.Add(this.numericUpDown_rows);
            this.groupBox_offset.Controls.Add(this.label_numOfRows);
            this.groupBox_offset.Controls.Add(this.textBox_offset);
            this.groupBox_offset.Name = "groupBox_offset";
            this.groupBox_offset.TabStop = false;
            // 
            // button_minus
            // 
            resources.ApplyResources(this.button_minus, "button_minus");
            this.button_minus.Name = "button_minus";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_plus
            // 
            resources.ApplyResources(this.button_plus, "button_plus");
            this.button_plus.Name = "button_plus";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_go
            // 
            resources.ApplyResources(this.button_go, "button_go");
            this.button_go.Name = "button_go";
            this.button_go.UseVisualStyleBackColor = true;
            this.button_go.Click += new System.EventHandler(this.button_go_Click);
            // 
            // numericUpDown_rows
            // 
            resources.ApplyResources(this.numericUpDown_rows, "numericUpDown_rows");
            this.numericUpDown_rows.Hexadecimal = true;
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
            this.numericUpDown_rows.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_numOfRows
            // 
            resources.ApplyResources(this.label_numOfRows, "label_numOfRows");
            this.label_numOfRows.Name = "label_numOfRows";
            // 
            // textBox_offset
            // 
            resources.ApplyResources(this.textBox_offset, "textBox_offset");
            this.textBox_offset.Name = "textBox_offset";
            // 
            // comboBox_sprite
            // 
            resources.ApplyResources(this.comboBox_sprite, "comboBox_sprite");
            this.comboBox_sprite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sprite.FormattingEnabled = true;
            this.comboBox_sprite.Name = "comboBox_sprite";
            this.comboBox_sprite.SelectedIndexChanged += new System.EventHandler(this.comboBox_sprite_SelectedIndexChanged);
            // 
            // label_red
            // 
            resources.ApplyResources(this.label_red, "label_red");
            this.label_red.Name = "label_red";
            // 
            // label_green
            // 
            resources.ApplyResources(this.label_green, "label_green");
            this.label_green.Name = "label_green";
            // 
            // label_blue
            // 
            resources.ApplyResources(this.label_blue, "label_blue");
            this.label_blue.Name = "label_blue";
            // 
            // numericUpDown_red
            // 
            resources.ApplyResources(this.numericUpDown_red, "numericUpDown_red");
            this.numericUpDown_red.Hexadecimal = true;
            this.numericUpDown_red.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown_red.Name = "numericUpDown_red";
            this.numericUpDown_red.ValueChanged += new System.EventHandler(this.numericUpDown_red_ValueChanged);
            // 
            // numericUpDown_green
            // 
            resources.ApplyResources(this.numericUpDown_green, "numericUpDown_green");
            this.numericUpDown_green.Hexadecimal = true;
            this.numericUpDown_green.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown_green.Name = "numericUpDown_green";
            this.numericUpDown_green.ValueChanged += new System.EventHandler(this.numericUpDown_green_ValueChanged);
            // 
            // numericUpDown_blue
            // 
            resources.ApplyResources(this.numericUpDown_blue, "numericUpDown_blue");
            this.numericUpDown_blue.Hexadecimal = true;
            this.numericUpDown_blue.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDown_blue.Name = "numericUpDown_blue";
            this.numericUpDown_blue.ValueChanged += new System.EventHandler(this.numericUpDown_blue_ValueChanged);
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
            // label_15bit
            // 
            resources.ApplyResources(this.label_15bit, "label_15bit");
            this.label_15bit.Name = "label_15bit";
            // 
            // label_15bitVal
            // 
            resources.ApplyResources(this.label_15bitVal, "label_15bitVal");
            this.label_15bitVal.Name = "label_15bitVal";
            // 
            // pictureBox_red
            // 
            resources.ApplyResources(this.pictureBox_red, "pictureBox_red");
            this.pictureBox_red.Name = "pictureBox_red";
            this.pictureBox_red.TabStop = false;
            this.pictureBox_red.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_red_MouseDown);
            this.pictureBox_red.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_red_MouseMove);
            // 
            // pictureBox_green
            // 
            resources.ApplyResources(this.pictureBox_green, "pictureBox_green");
            this.pictureBox_green.Name = "pictureBox_green";
            this.pictureBox_green.TabStop = false;
            this.pictureBox_green.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_green_MouseDown);
            this.pictureBox_green.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_green_MouseMove);
            // 
            // pictureBox_blue
            // 
            resources.ApplyResources(this.pictureBox_blue, "pictureBox_blue");
            this.pictureBox_blue.Name = "pictureBox_blue";
            this.pictureBox_blue.TabStop = false;
            this.pictureBox_blue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_blue_MouseDown);
            this.pictureBox_blue.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_blue_MouseMove);
            // 
            // groupBox_color
            // 
            resources.ApplyResources(this.groupBox_color, "groupBox_color");
            this.groupBox_color.Controls.Add(this.label_red);
            this.groupBox_color.Controls.Add(this.pictureBox_blue);
            this.groupBox_color.Controls.Add(this.label_green);
            this.groupBox_color.Controls.Add(this.pictureBox_green);
            this.groupBox_color.Controls.Add(this.label_blue);
            this.groupBox_color.Controls.Add(this.pictureBox_red);
            this.groupBox_color.Controls.Add(this.numericUpDown_red);
            this.groupBox_color.Controls.Add(this.numericUpDown_green);
            this.groupBox_color.Controls.Add(this.numericUpDown_blue);
            this.groupBox_color.Name = "groupBox_color";
            this.groupBox_color.TabStop = false;
            // 
            // groupBox_shortcuts
            // 
            resources.ApplyResources(this.groupBox_shortcuts, "groupBox_shortcuts");
            this.groupBox_shortcuts.Controls.Add(this.label_sprite);
            this.groupBox_shortcuts.Controls.Add(this.comboBox_sprite);
            this.groupBox_shortcuts.Controls.Add(this.comboBox_tileset);
            this.groupBox_shortcuts.Controls.Add(this.label_tileset);
            this.groupBox_shortcuts.Name = "groupBox_shortcuts";
            this.groupBox_shortcuts.TabStop = false;
            // 
            // label_sprite
            // 
            resources.ApplyResources(this.label_sprite, "label_sprite");
            this.label_sprite.Name = "label_sprite";
            // 
            // label_tileset
            // 
            resources.ApplyResources(this.label_tileset, "label_tileset");
            this.label_tileset.Name = "label_tileset";
            // 
            // label_24bitVal
            // 
            resources.ApplyResources(this.label_24bitVal, "label_24bitVal");
            this.label_24bitVal.Name = "label_24bitVal";
            // 
            // label_24bit
            // 
            resources.ApplyResources(this.label_24bit, "label_24bit");
            this.label_24bit.Name = "label_24bit";
            // 
            // groupBox_info
            // 
            resources.ApplyResources(this.groupBox_info, "groupBox_info");
            this.groupBox_info.Controls.Add(this.label_15bitVal);
            this.groupBox_info.Controls.Add(this.pictureBox_chosenColor);
            this.groupBox_info.Controls.Add(this.label_24bitVal);
            this.groupBox_info.Controls.Add(this.label_15bit);
            this.groupBox_info.Controls.Add(this.label_24bit);
            this.groupBox_info.Name = "groupBox_info";
            this.groupBox_info.TabStop = false;
            // 
            // statusStrip
            // 
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_changes,
            this.statusStrip_spring,
            this.statusStrip_import,
            this.statusStrip_export});
            this.statusStrip.Name = "statusStrip";
            // 
            // statusLabel_changes
            // 
            resources.ApplyResources(this.statusLabel_changes, "statusLabel_changes");
            this.statusLabel_changes.Name = "statusLabel_changes";
            // 
            // statusStrip_spring
            // 
            resources.ApplyResources(this.statusStrip_spring, "statusStrip_spring");
            this.statusStrip_spring.Name = "statusStrip_spring";
            this.statusStrip_spring.Spring = true;
            // 
            // statusStrip_import
            // 
            resources.ApplyResources(this.statusStrip_import, "statusStrip_import");
            this.statusStrip_import.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusStrip_import.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip_importRaw,
            this.statusStrip_importTLP,
            this.statusStrip_importYY});
            this.statusStrip_import.Name = "statusStrip_import";
            // 
            // statusStrip_importRaw
            // 
            resources.ApplyResources(this.statusStrip_importRaw, "statusStrip_importRaw");
            this.statusStrip_importRaw.Name = "statusStrip_importRaw";
            this.statusStrip_importRaw.Click += new System.EventHandler(this.statusStrip_importRaw_Click);
            // 
            // statusStrip_importTLP
            // 
            resources.ApplyResources(this.statusStrip_importTLP, "statusStrip_importTLP");
            this.statusStrip_importTLP.Name = "statusStrip_importTLP";
            this.statusStrip_importTLP.Click += new System.EventHandler(this.statusStrip_importTLP_Click);
            // 
            // statusStrip_importYY
            // 
            resources.ApplyResources(this.statusStrip_importYY, "statusStrip_importYY");
            this.statusStrip_importYY.Name = "statusStrip_importYY";
            this.statusStrip_importYY.Click += new System.EventHandler(this.statusStrip_importYY_Click);
            // 
            // statusStrip_export
            // 
            resources.ApplyResources(this.statusStrip_export, "statusStrip_export");
            this.statusStrip_export.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusStrip_export.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip_exportRaw,
            this.statusStrip_exportTLP,
            this.statusStrip_exportYY});
            this.statusStrip_export.Name = "statusStrip_export";
            // 
            // statusStrip_exportRaw
            // 
            resources.ApplyResources(this.statusStrip_exportRaw, "statusStrip_exportRaw");
            this.statusStrip_exportRaw.Name = "statusStrip_exportRaw";
            this.statusStrip_exportRaw.Click += new System.EventHandler(this.statusStrip_exportRaw_Click);
            // 
            // statusStrip_exportTLP
            // 
            resources.ApplyResources(this.statusStrip_exportTLP, "statusStrip_exportTLP");
            this.statusStrip_exportTLP.Name = "statusStrip_exportTLP";
            this.statusStrip_exportTLP.Click += new System.EventHandler(this.statusStrip_exportTLP_Click);
            // 
            // statusStrip_exportYY
            // 
            resources.ApplyResources(this.statusStrip_exportYY, "statusStrip_exportYY");
            this.statusStrip_exportYY.Name = "statusStrip_exportYY";
            this.statusStrip_exportYY.Click += new System.EventHandler(this.statusStrip_exportYY_Click);
            // 
            // FormPalette
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox_info);
            this.Controls.Add(this.groupBox_shortcuts);
            this.Controls.Add(this.groupBox_color);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.groupBox_offset);
            this.Controls.Add(this.pictureBox_palette);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPalette";
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