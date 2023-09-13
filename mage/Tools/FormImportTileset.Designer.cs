namespace mage
{
    partial class FormImportTileset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportTileset));
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.radioButton_original = new System.Windows.Forms.RadioButton();
            this.radioButton_current = new System.Windows.Forms.RadioButton();
            this.radioButton_choose = new System.Windows.Forms.RadioButton();
            this.checkBox_genericTiles = new System.Windows.Forms.CheckBox();
            this.comboBox_tileset = new mage.Theming.CustomControls.FlatComboBox();
            this.checkBox_preserveData = new System.Windows.Forms.CheckBox();
            this.groupBox_select = new System.Windows.Forms.GroupBox();
            this.groupBox_select.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(152, 54);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 5;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(152, 83);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 6;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // radioButton_original
            // 
            this.radioButton_original.AutoSize = true;
            this.radioButton_original.Location = new System.Drawing.Point(6, 19);
            this.radioButton_original.Name = "radioButton_original";
            this.radioButton_original.Size = new System.Drawing.Size(90, 17);
            this.radioButton_original.TabIndex = 1;
            this.radioButton_original.Text = "Original tileset";
            this.radioButton_original.UseVisualStyleBackColor = true;
            // 
            // radioButton_current
            // 
            this.radioButton_current.AutoSize = true;
            this.radioButton_current.Location = new System.Drawing.Point(6, 42);
            this.radioButton_current.Name = "radioButton_current";
            this.radioButton_current.Size = new System.Drawing.Size(122, 17);
            this.radioButton_current.TabIndex = 2;
            this.radioButton_current.Text = "Current room\'s tileset";
            this.radioButton_current.UseVisualStyleBackColor = true;
            // 
            // radioButton_choose
            // 
            this.radioButton_choose.AutoSize = true;
            this.radioButton_choose.Location = new System.Drawing.Point(6, 65);
            this.radioButton_choose.Name = "radioButton_choose";
            this.radioButton_choose.Size = new System.Drawing.Size(59, 17);
            this.radioButton_choose.TabIndex = 3;
            this.radioButton_choose.Text = "Tileset:";
            this.radioButton_choose.UseVisualStyleBackColor = true;
            // 
            // checkBox_genericTiles
            // 
            this.checkBox_genericTiles.AutoSize = true;
            this.checkBox_genericTiles.Location = new System.Drawing.Point(12, 111);
            this.checkBox_genericTiles.Name = "checkBox_genericTiles";
            this.checkBox_genericTiles.Size = new System.Drawing.Size(176, 17);
            this.checkBox_genericTiles.TabIndex = 0;
            this.checkBox_genericTiles.Text = "Use current game\'s generic tiles";
            this.checkBox_genericTiles.UseVisualStyleBackColor = true;
            // 
            // comboBox_tileset
            // 
            this.comboBox_tileset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tileset.FormattingEnabled = true;
            this.comboBox_tileset.Location = new System.Drawing.Point(71, 64);
            this.comboBox_tileset.Name = "comboBox_tileset";
            this.comboBox_tileset.Size = new System.Drawing.Size(49, 21);
            this.comboBox_tileset.TabIndex = 7;
            // 
            // checkBox_preserveData
            // 
            this.checkBox_preserveData.AutoSize = true;
            this.checkBox_preserveData.Location = new System.Drawing.Point(12, 134);
            this.checkBox_preserveData.Name = "checkBox_preserveData";
            this.checkBox_preserveData.Size = new System.Drawing.Size(139, 30);
            this.checkBox_preserveData.TabIndex = 8;
            this.checkBox_preserveData.Text = "Preserve existing data\r\n(if used by other tilesets)";
            this.checkBox_preserveData.UseVisualStyleBackColor = true;
            // 
            // groupBox_select
            // 
            this.groupBox_select.Controls.Add(this.radioButton_original);
            this.groupBox_select.Controls.Add(this.radioButton_current);
            this.groupBox_select.Controls.Add(this.comboBox_tileset);
            this.groupBox_select.Controls.Add(this.radioButton_choose);
            this.groupBox_select.Location = new System.Drawing.Point(12, 12);
            this.groupBox_select.Name = "groupBox_select";
            this.groupBox_select.Size = new System.Drawing.Size(134, 93);
            this.groupBox_select.TabIndex = 9;
            this.groupBox_select.TabStop = false;
            this.groupBox_select.Text = "Select";
            // 
            // FormImportTileset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 176);
            this.Controls.Add(this.groupBox_select);
            this.Controls.Add(this.checkBox_preserveData);
            this.Controls.Add(this.checkBox_genericTiles);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormImportTileset";
            this.Text = "Import Tileset";
            this.groupBox_select.ResumeLayout(false);
            this.groupBox_select.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.RadioButton radioButton_original;
        private System.Windows.Forms.RadioButton radioButton_current;
        private System.Windows.Forms.RadioButton radioButton_choose;
        private System.Windows.Forms.CheckBox checkBox_genericTiles;
        private mage.Theming.CustomControls.FlatComboBox comboBox_tileset;
        private System.Windows.Forms.CheckBox checkBox_preserveData;
        private System.Windows.Forms.GroupBox groupBox_select;
    }
}