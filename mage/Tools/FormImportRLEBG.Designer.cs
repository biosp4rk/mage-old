namespace mage
{
    partial class FormImportRLEBG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportRLEBG));
            this.button_open = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.radioButton_choose = new System.Windows.Forms.RadioButton();
            this.radioButton_current = new System.Windows.Forms.RadioButton();
            this.label_image = new System.Windows.Forms.Label();
            this.checkBox_autoRows = new System.Windows.Forms.CheckBox();
            this.checkBox_preserveData = new System.Windows.Forms.CheckBox();
            this.groupBox_palette = new System.Windows.Forms.GroupBox();
            this.groupBox_select = new System.Windows.Forms.GroupBox();
            this.comboBox_tileset = new mage.Theming.CustomControls.FlatComboBox();
            this.listBox_rows = new System.Windows.Forms.ListBox();
            this.groupBox_palette.SuspendLayout();
            this.groupBox_select.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(12, 12);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(75, 23);
            this.button_open.TabIndex = 0;
            this.button_open.Text = "Open";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_ok
            // 
            this.button_ok.Enabled = false;
            this.button_ok.Location = new System.Drawing.Point(152, 164);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 5;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(233, 164);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 6;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // radioButton_choose
            // 
            this.radioButton_choose.AutoSize = true;
            this.radioButton_choose.Location = new System.Drawing.Point(6, 44);
            this.radioButton_choose.Name = "radioButton_choose";
            this.radioButton_choose.Size = new System.Drawing.Size(59, 17);
            this.radioButton_choose.TabIndex = 1;
            this.radioButton_choose.Text = "Tileset:";
            this.radioButton_choose.UseVisualStyleBackColor = true;
            // 
            // radioButton_current
            // 
            this.radioButton_current.AutoSize = true;
            this.radioButton_current.Location = new System.Drawing.Point(6, 19);
            this.radioButton_current.Name = "radioButton_current";
            this.radioButton_current.Size = new System.Drawing.Size(122, 17);
            this.radioButton_current.TabIndex = 0;
            this.radioButton_current.Text = "Current room\'s tileset";
            this.radioButton_current.UseVisualStyleBackColor = true;
            // 
            // label_image
            // 
            this.label_image.AutoSize = true;
            this.label_image.Location = new System.Drawing.Point(93, 9);
            this.label_image.Name = "label_image";
            this.label_image.Size = new System.Drawing.Size(215, 26);
            this.label_image.TabIndex = 0;
            this.label_image.Text = "Image must be 32 bpp, have a width of 256,\r\nand have a height divisible by 16.";
            // 
            // checkBox_autoRows
            // 
            this.checkBox_autoRows.AutoSize = true;
            this.checkBox_autoRows.Checked = true;
            this.checkBox_autoRows.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_autoRows.Location = new System.Drawing.Point(6, 19);
            this.checkBox_autoRows.Name = "checkBox_autoRows";
            this.checkBox_autoRows.Size = new System.Drawing.Size(144, 17);
            this.checkBox_autoRows.TabIndex = 1;
            this.checkBox_autoRows.Text = "Automatically select rows";
            this.checkBox_autoRows.UseVisualStyleBackColor = true;
            this.checkBox_autoRows.CheckedChanged += new System.EventHandler(this.checkBox_autoRows_CheckedChanged);
            // 
            // checkBox_preserveData
            // 
            this.checkBox_preserveData.AutoSize = true;
            this.checkBox_preserveData.Enabled = false;
            this.checkBox_preserveData.Location = new System.Drawing.Point(12, 141);
            this.checkBox_preserveData.Name = "checkBox_preserveData";
            this.checkBox_preserveData.Size = new System.Drawing.Size(246, 17);
            this.checkBox_preserveData.TabIndex = 7;
            this.checkBox_preserveData.Text = "Preserve existing data (if used by other tilesets)";
            this.checkBox_preserveData.UseVisualStyleBackColor = true;
            // 
            // groupBox_palette
            // 
            this.groupBox_palette.Controls.Add(this.listBox_rows);
            this.groupBox_palette.Controls.Add(this.checkBox_autoRows);
            this.groupBox_palette.Enabled = false;
            this.groupBox_palette.Location = new System.Drawing.Point(152, 41);
            this.groupBox_palette.Name = "groupBox_palette";
            this.groupBox_palette.Size = new System.Drawing.Size(156, 94);
            this.groupBox_palette.TabIndex = 7;
            this.groupBox_palette.TabStop = false;
            this.groupBox_palette.Text = "Palette";
            // 
            // groupBox_select
            // 
            this.groupBox_select.Controls.Add(this.comboBox_tileset);
            this.groupBox_select.Controls.Add(this.radioButton_current);
            this.groupBox_select.Controls.Add(this.radioButton_choose);
            this.groupBox_select.Enabled = false;
            this.groupBox_select.Location = new System.Drawing.Point(12, 41);
            this.groupBox_select.Name = "groupBox_select";
            this.groupBox_select.Size = new System.Drawing.Size(134, 94);
            this.groupBox_select.TabIndex = 8;
            this.groupBox_select.TabStop = false;
            this.groupBox_select.Text = "Select";
            // 
            // comboBox_tileset
            // 
            this.comboBox_tileset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tileset.FormattingEnabled = true;
            this.comboBox_tileset.Location = new System.Drawing.Point(71, 43);
            this.comboBox_tileset.Name = "comboBox_tileset";
            this.comboBox_tileset.Size = new System.Drawing.Size(49, 21);
            this.comboBox_tileset.TabIndex = 9;
            // 
            // listBox_rows
            // 
            this.listBox_rows.Enabled = false;
            this.listBox_rows.FormattingEnabled = true;
            this.listBox_rows.Items.AddRange(new object[] {
            "Row 1",
            "Row 2",
            "Row 3",
            "Row 4",
            "Row 5",
            "Row 6",
            "Row 7",
            "Row 8",
            "Row 9",
            "Row A",
            "Row B",
            "Row C",
            "Row D"});
            this.listBox_rows.Location = new System.Drawing.Point(6, 42);
            this.listBox_rows.Name = "listBox_rows";
            this.listBox_rows.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_rows.Size = new System.Drawing.Size(144, 43);
            this.listBox_rows.TabIndex = 6;
            // 
            // FormImportRLEBG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 199);
            this.Controls.Add(this.checkBox_preserveData);
            this.Controls.Add(this.groupBox_select);
            this.Controls.Add(this.groupBox_palette);
            this.Controls.Add(this.label_image);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormImportRLEBG";
            this.Text = "Import Tileset";
            this.groupBox_palette.ResumeLayout(false);
            this.groupBox_palette.PerformLayout();
            this.groupBox_select.ResumeLayout(false);
            this.groupBox_select.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.RadioButton radioButton_choose;
        private System.Windows.Forms.RadioButton radioButton_current;
        private System.Windows.Forms.Label label_image;
        private System.Windows.Forms.CheckBox checkBox_autoRows;
        private System.Windows.Forms.CheckBox checkBox_preserveData;
        private System.Windows.Forms.GroupBox groupBox_palette;
        private System.Windows.Forms.GroupBox groupBox_select;
        private mage.Theming.CustomControls.FlatComboBox comboBox_tileset;
        private System.Windows.Forms.ListBox listBox_rows;
    }
}