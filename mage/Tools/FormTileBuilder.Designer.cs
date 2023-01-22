namespace mage
{
    partial class FormTileBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTileBuilder));
            this.checkBox_TL = new System.Windows.Forms.CheckBox();
            this.checkBox_TR = new System.Windows.Forms.CheckBox();
            this.checkBox_BL = new System.Windows.Forms.CheckBox();
            this.checkBox_BR = new System.Windows.Forms.CheckBox();
            this.comboBox_T = new System.Windows.Forms.ComboBox();
            this.comboBox_L = new System.Windows.Forms.ComboBox();
            this.comboBox_R = new System.Windows.Forms.ComboBox();
            this.comboBox_B = new System.Windows.Forms.ComboBox();
            this.comboBox_center = new System.Windows.Forms.ComboBox();
            this.panel_black = new System.Windows.Forms.Panel();
            this.comboBox_palette = new System.Windows.Forms.ComboBox();
            this.label_palette = new System.Windows.Forms.Label();
            this.button_apply = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.numericUpDown_tile = new System.Windows.Forms.NumericUpDown();
            this.label_tile = new System.Windows.Forms.Label();
            this.panel_black2 = new System.Windows.Forms.Panel();
            this.gfxView_tile = new mage.GfxView();
            this.gfxView_curr = new mage.GfxView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tile)).BeginInit();
            this.panel_black2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_TL
            // 
            this.checkBox_TL.AutoSize = true;
            this.checkBox_TL.Location = new System.Drawing.Point(52, 37);
            this.checkBox_TL.Name = "checkBox_TL";
            this.checkBox_TL.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_TL.Size = new System.Drawing.Size(57, 17);
            this.checkBox_TL.TabIndex = 0;
            this.checkBox_TL.Text = "Corner";
            this.checkBox_TL.UseVisualStyleBackColor = true;
            this.checkBox_TL.CheckedChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // checkBox_TR
            // 
            this.checkBox_TR.AutoSize = true;
            this.checkBox_TR.Location = new System.Drawing.Point(198, 37);
            this.checkBox_TR.Name = "checkBox_TR";
            this.checkBox_TR.Size = new System.Drawing.Size(57, 17);
            this.checkBox_TR.TabIndex = 1;
            this.checkBox_TR.Text = "Corner";
            this.checkBox_TR.UseVisualStyleBackColor = true;
            this.checkBox_TR.CheckedChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // checkBox_BL
            // 
            this.checkBox_BL.AutoSize = true;
            this.checkBox_BL.Location = new System.Drawing.Point(52, 140);
            this.checkBox_BL.Name = "checkBox_BL";
            this.checkBox_BL.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox_BL.Size = new System.Drawing.Size(57, 17);
            this.checkBox_BL.TabIndex = 2;
            this.checkBox_BL.Text = "Corner";
            this.checkBox_BL.UseVisualStyleBackColor = true;
            this.checkBox_BL.CheckedChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // checkBox_BR
            // 
            this.checkBox_BR.AutoSize = true;
            this.checkBox_BR.Location = new System.Drawing.Point(198, 140);
            this.checkBox_BR.Name = "checkBox_BR";
            this.checkBox_BR.Size = new System.Drawing.Size(57, 17);
            this.checkBox_BR.TabIndex = 3;
            this.checkBox_BR.Text = "Corner";
            this.checkBox_BR.UseVisualStyleBackColor = true;
            this.checkBox_BR.CheckedChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // comboBox_T
            // 
            this.comboBox_T.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_T.FormattingEnabled = true;
            this.comboBox_T.Location = new System.Drawing.Point(112, 12);
            this.comboBox_T.Name = "comboBox_T";
            this.comboBox_T.Size = new System.Drawing.Size(82, 21);
            this.comboBox_T.TabIndex = 5;
            this.comboBox_T.SelectedIndexChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // comboBox_L
            // 
            this.comboBox_L.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_L.FormattingEnabled = true;
            this.comboBox_L.Location = new System.Drawing.Point(12, 84);
            this.comboBox_L.Name = "comboBox_L";
            this.comboBox_L.Size = new System.Drawing.Size(92, 21);
            this.comboBox_L.TabIndex = 6;
            this.comboBox_L.SelectedIndexChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // comboBox_R
            // 
            this.comboBox_R.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_R.FormattingEnabled = true;
            this.comboBox_R.Location = new System.Drawing.Point(202, 84);
            this.comboBox_R.Name = "comboBox_R";
            this.comboBox_R.Size = new System.Drawing.Size(92, 21);
            this.comboBox_R.TabIndex = 7;
            this.comboBox_R.SelectedIndexChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // comboBox_B
            // 
            this.comboBox_B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_B.FormattingEnabled = true;
            this.comboBox_B.Location = new System.Drawing.Point(112, 161);
            this.comboBox_B.Name = "comboBox_B";
            this.comboBox_B.Size = new System.Drawing.Size(82, 21);
            this.comboBox_B.TabIndex = 8;
            this.comboBox_B.SelectedIndexChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // comboBox_center
            // 
            this.comboBox_center.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_center.FormattingEnabled = true;
            this.comboBox_center.Location = new System.Drawing.Point(100, 194);
            this.comboBox_center.Name = "comboBox_center";
            this.comboBox_center.Size = new System.Drawing.Size(106, 21);
            this.comboBox_center.TabIndex = 9;
            this.comboBox_center.SelectedIndexChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // panel_black
            // 
            this.panel_black.BackColor = System.Drawing.Color.Black;
            this.panel_black.Location = new System.Drawing.Point(112, 55);
            this.panel_black.Name = "panel_black";
            this.panel_black.Size = new System.Drawing.Size(82, 82);
            this.panel_black.TabIndex = 11;
            // 
            // comboBox_palette
            // 
            this.comboBox_palette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_palette.FormattingEnabled = true;
            this.comboBox_palette.Location = new System.Drawing.Point(248, 194);
            this.comboBox_palette.Name = "comboBox_palette";
            this.comboBox_palette.Size = new System.Drawing.Size(45, 21);
            this.comboBox_palette.TabIndex = 12;
            this.comboBox_palette.SelectedIndexChanged += new System.EventHandler(this.comboBox_palette_SelectedIndexChanged);
            // 
            // label_palette
            // 
            this.label_palette.AutoSize = true;
            this.label_palette.Location = new System.Drawing.Point(245, 178);
            this.label_palette.Name = "label_palette";
            this.label_palette.Size = new System.Drawing.Size(43, 13);
            this.label_palette.TabIndex = 13;
            this.label_palette.Text = "Palette:";
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(138, 224);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(75, 23);
            this.button_apply.TabIndex = 14;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(219, 224);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 15;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // numericUpDown_tile
            // 
            this.numericUpDown_tile.Hexadecimal = true;
            this.numericUpDown_tile.Location = new System.Drawing.Point(12, 194);
            this.numericUpDown_tile.Name = "numericUpDown_tile";
            this.numericUpDown_tile.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown_tile.TabIndex = 16;
            this.numericUpDown_tile.ValueChanged += new System.EventHandler(this.numericUpDown_tile_ValueChanged);
            // 
            // label_tile
            // 
            this.label_tile.AutoSize = true;
            this.label_tile.Location = new System.Drawing.Point(9, 178);
            this.label_tile.Name = "label_tile";
            this.label_tile.Size = new System.Drawing.Size(27, 13);
            this.label_tile.TabIndex = 17;
            this.label_tile.Text = "Tile:";
            // 
            // panel_black2
            // 
            this.panel_black2.BackColor = System.Drawing.Color.Black;
            this.panel_black2.Controls.Add(this.gfxView_curr);
            this.panel_black2.Location = new System.Drawing.Point(12, 221);
            this.panel_black2.Name = "panel_black2";
            this.panel_black2.Size = new System.Drawing.Size(26, 26);
            this.panel_black2.TabIndex = 20;
            // 
            // gfxView_tile
            // 
            this.gfxView_tile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gfxView_tile.Location = new System.Drawing.Point(113, 56);
            this.gfxView_tile.Name = "gfxView_tile";
            this.gfxView_tile.Size = new System.Drawing.Size(80, 80);
            this.gfxView_tile.TabIndex = 10;
            this.gfxView_tile.TabStop = false;
            // 
            // gfxView_curr
            // 
            this.gfxView_curr.BackColor = System.Drawing.SystemColors.Control;
            this.gfxView_curr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gfxView_curr.Location = new System.Drawing.Point(1, 1);
            this.gfxView_curr.Name = "gfxView_curr";
            this.gfxView_curr.Size = new System.Drawing.Size(24, 24);
            this.gfxView_curr.TabIndex = 19;
            this.gfxView_curr.TabStop = false;
            // 
            // FormTileBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 259);
            this.Controls.Add(this.label_tile);
            this.Controls.Add(this.numericUpDown_tile);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.label_palette);
            this.Controls.Add(this.comboBox_palette);
            this.Controls.Add(this.gfxView_tile);
            this.Controls.Add(this.comboBox_center);
            this.Controls.Add(this.comboBox_B);
            this.Controls.Add(this.comboBox_R);
            this.Controls.Add(this.comboBox_L);
            this.Controls.Add(this.comboBox_T);
            this.Controls.Add(this.checkBox_BR);
            this.Controls.Add(this.checkBox_BL);
            this.Controls.Add(this.checkBox_TR);
            this.Controls.Add(this.checkBox_TL);
            this.Controls.Add(this.panel_black);
            this.Controls.Add(this.panel_black2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTileBuilder";
            this.Text = "Minimap Tile Builder";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tile)).EndInit();
            this.panel_black2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_TL;
        private System.Windows.Forms.CheckBox checkBox_TR;
        private System.Windows.Forms.CheckBox checkBox_BL;
        private System.Windows.Forms.CheckBox checkBox_BR;
        private System.Windows.Forms.ComboBox comboBox_T;
        private System.Windows.Forms.ComboBox comboBox_L;
        private System.Windows.Forms.ComboBox comboBox_R;
        private System.Windows.Forms.ComboBox comboBox_B;
        private System.Windows.Forms.ComboBox comboBox_center;
        private GfxView gfxView_tile;
        private System.Windows.Forms.Panel panel_black;
        private System.Windows.Forms.ComboBox comboBox_palette;
        private System.Windows.Forms.Label label_palette;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.NumericUpDown numericUpDown_tile;
        private System.Windows.Forms.Label label_tile;
        private GfxView gfxView_curr;
        private System.Windows.Forms.Panel panel_black2;
    }
}