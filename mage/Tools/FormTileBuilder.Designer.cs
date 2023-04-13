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
            this.gfxView_curr = new mage.GfxView();
            this.gfxView_tile = new mage.GfxView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tile)).BeginInit();
            this.panel_black2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_TL
            // 
            resources.ApplyResources(this.checkBox_TL, "checkBox_TL");
            this.checkBox_TL.Name = "checkBox_TL";
            this.checkBox_TL.UseVisualStyleBackColor = true;
            this.checkBox_TL.CheckedChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // checkBox_TR
            // 
            resources.ApplyResources(this.checkBox_TR, "checkBox_TR");
            this.checkBox_TR.Name = "checkBox_TR";
            this.checkBox_TR.UseVisualStyleBackColor = true;
            this.checkBox_TR.CheckedChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // checkBox_BL
            // 
            resources.ApplyResources(this.checkBox_BL, "checkBox_BL");
            this.checkBox_BL.Name = "checkBox_BL";
            this.checkBox_BL.UseVisualStyleBackColor = true;
            this.checkBox_BL.CheckedChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // checkBox_BR
            // 
            resources.ApplyResources(this.checkBox_BR, "checkBox_BR");
            this.checkBox_BR.Name = "checkBox_BR";
            this.checkBox_BR.UseVisualStyleBackColor = true;
            this.checkBox_BR.CheckedChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // comboBox_T
            // 
            resources.ApplyResources(this.comboBox_T, "comboBox_T");
            this.comboBox_T.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_T.FormattingEnabled = true;
            this.comboBox_T.Name = "comboBox_T";
            this.comboBox_T.SelectedIndexChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // comboBox_L
            // 
            resources.ApplyResources(this.comboBox_L, "comboBox_L");
            this.comboBox_L.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_L.FormattingEnabled = true;
            this.comboBox_L.Name = "comboBox_L";
            this.comboBox_L.SelectedIndexChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // comboBox_R
            // 
            resources.ApplyResources(this.comboBox_R, "comboBox_R");
            this.comboBox_R.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_R.FormattingEnabled = true;
            this.comboBox_R.Name = "comboBox_R";
            this.comboBox_R.SelectedIndexChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // comboBox_B
            // 
            resources.ApplyResources(this.comboBox_B, "comboBox_B");
            this.comboBox_B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_B.FormattingEnabled = true;
            this.comboBox_B.Name = "comboBox_B";
            this.comboBox_B.SelectedIndexChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // comboBox_center
            // 
            resources.ApplyResources(this.comboBox_center, "comboBox_center");
            this.comboBox_center.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_center.FormattingEnabled = true;
            this.comboBox_center.Name = "comboBox_center";
            this.comboBox_center.SelectedIndexChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // panel_black
            // 
            resources.ApplyResources(this.panel_black, "panel_black");
            this.panel_black.BackColor = System.Drawing.Color.Black;
            this.panel_black.Name = "panel_black";
            // 
            // comboBox_palette
            // 
            resources.ApplyResources(this.comboBox_palette, "comboBox_palette");
            this.comboBox_palette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_palette.FormattingEnabled = true;
            this.comboBox_palette.Name = "comboBox_palette";
            this.comboBox_palette.SelectedIndexChanged += new System.EventHandler(this.comboBox_palette_SelectedIndexChanged);
            // 
            // label_palette
            // 
            resources.ApplyResources(this.label_palette, "label_palette");
            this.label_palette.Name = "label_palette";
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
            // numericUpDown_tile
            // 
            resources.ApplyResources(this.numericUpDown_tile, "numericUpDown_tile");
            this.numericUpDown_tile.Hexadecimal = true;
            this.numericUpDown_tile.Name = "numericUpDown_tile";
            this.numericUpDown_tile.ValueChanged += new System.EventHandler(this.numericUpDown_tile_ValueChanged);
            // 
            // label_tile
            // 
            resources.ApplyResources(this.label_tile, "label_tile");
            this.label_tile.Name = "label_tile";
            // 
            // panel_black2
            // 
            resources.ApplyResources(this.panel_black2, "panel_black2");
            this.panel_black2.BackColor = System.Drawing.Color.Black;
            this.panel_black2.Controls.Add(this.gfxView_curr);
            this.panel_black2.Name = "panel_black2";
            // 
            // gfxView_curr
            // 
            resources.ApplyResources(this.gfxView_curr, "gfxView_curr");
            this.gfxView_curr.BackColor = System.Drawing.SystemColors.Control;
            this.gfxView_curr.Name = "gfxView_curr";
            this.gfxView_curr.TabStop = false;
            // 
            // gfxView_tile
            // 
            resources.ApplyResources(this.gfxView_tile, "gfxView_tile");
            this.gfxView_tile.Name = "gfxView_tile";
            this.gfxView_tile.TabStop = false;
            // 
            // FormTileBuilder
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "FormTileBuilder";
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