namespace mage
{
    partial class FormImportLZ77BG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportLZ77BG));
            this.label_image = new System.Windows.Forms.Label();
            this.button_open = new System.Windows.Forms.Button();
            this.groupBox_palette = new System.Windows.Forms.GroupBox();
            this.checkBox_autoRows = new System.Windows.Forms.CheckBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.checkBox_preserveData = new System.Windows.Forms.CheckBox();
            this.radioButton_BG0 = new System.Windows.Forms.RadioButton();
            this.radioButton_BG3 = new System.Windows.Forms.RadioButton();
            this.checkBox_addToGraphics = new System.Windows.Forms.CheckBox();
            this.groupBox_options = new System.Windows.Forms.GroupBox();
            this.listBox_rows = new System.Windows.Forms.ListBox();
            this.groupBox_palette.SuspendLayout();
            this.groupBox_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_image
            // 
            this.label_image.AutoSize = true;
            this.label_image.Location = new System.Drawing.Point(93, 9);
            this.label_image.Name = "label_image";
            this.label_image.Size = new System.Drawing.Size(175, 26);
            this.label_image.TabIndex = 0;
            this.label_image.Text = "Image must have dimensions\r\n256 x 256, 512 x 256, or 256 x 512.";
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
            // groupBox_palette
            // 
            this.groupBox_palette.Controls.Add(this.listBox_rows);
            this.groupBox_palette.Controls.Add(this.checkBox_autoRows);
            this.groupBox_palette.Enabled = false;
            this.groupBox_palette.Location = new System.Drawing.Point(172, 41);
            this.groupBox_palette.Name = "groupBox_palette";
            this.groupBox_palette.Size = new System.Drawing.Size(156, 94);
            this.groupBox_palette.TabIndex = 1;
            this.groupBox_palette.TabStop = false;
            this.groupBox_palette.Text = "Palette";
            // 
            // checkBox_autoRows
            // 
            this.checkBox_autoRows.AutoSize = true;
            this.checkBox_autoRows.Checked = true;
            this.checkBox_autoRows.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_autoRows.Location = new System.Drawing.Point(6, 19);
            this.checkBox_autoRows.Name = "checkBox_autoRows";
            this.checkBox_autoRows.Size = new System.Drawing.Size(144, 17);
            this.checkBox_autoRows.TabIndex = 4;
            this.checkBox_autoRows.Text = "Automatically select rows";
            this.checkBox_autoRows.UseVisualStyleBackColor = true;
            this.checkBox_autoRows.CheckedChanged += new System.EventHandler(this.checkBox_autoRows_CheckedChanged);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(253, 141);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_ok
            // 
            this.button_ok.Enabled = false;
            this.button_ok.Location = new System.Drawing.Point(172, 141);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 2;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // checkBox_preserveData
            // 
            this.checkBox_preserveData.AutoSize = true;
            this.checkBox_preserveData.Location = new System.Drawing.Point(6, 88);
            this.checkBox_preserveData.Name = "checkBox_preserveData";
            this.checkBox_preserveData.Size = new System.Drawing.Size(130, 30);
            this.checkBox_preserveData.TabIndex = 8;
            this.checkBox_preserveData.Text = "Preserve existing data\r\n(if used by other BGs)";
            this.checkBox_preserveData.UseVisualStyleBackColor = true;
            // 
            // radioButton_BG0
            // 
            this.radioButton_BG0.AutoSize = true;
            this.radioButton_BG0.Location = new System.Drawing.Point(6, 19);
            this.radioButton_BG0.Name = "radioButton_BG0";
            this.radioButton_BG0.Size = new System.Drawing.Size(49, 17);
            this.radioButton_BG0.TabIndex = 9;
            this.radioButton_BG0.Text = "BG 0";
            this.radioButton_BG0.UseVisualStyleBackColor = true;
            // 
            // radioButton_BG3
            // 
            this.radioButton_BG3.AutoSize = true;
            this.radioButton_BG3.Checked = true;
            this.radioButton_BG3.Location = new System.Drawing.Point(6, 42);
            this.radioButton_BG3.Name = "radioButton_BG3";
            this.radioButton_BG3.Size = new System.Drawing.Size(49, 17);
            this.radioButton_BG3.TabIndex = 10;
            this.radioButton_BG3.TabStop = true;
            this.radioButton_BG3.Text = "BG 3";
            this.radioButton_BG3.UseVisualStyleBackColor = true;
            // 
            // checkBox_addToGraphics
            // 
            this.checkBox_addToGraphics.AutoSize = true;
            this.checkBox_addToGraphics.Location = new System.Drawing.Point(6, 65);
            this.checkBox_addToGraphics.Name = "checkBox_addToGraphics";
            this.checkBox_addToGraphics.Size = new System.Drawing.Size(138, 17);
            this.checkBox_addToGraphics.TabIndex = 11;
            this.checkBox_addToGraphics.Text = "Add to existing graphics";
            this.checkBox_addToGraphics.UseVisualStyleBackColor = true;
            // 
            // groupBox_options
            // 
            this.groupBox_options.Controls.Add(this.radioButton_BG0);
            this.groupBox_options.Controls.Add(this.checkBox_addToGraphics);
            this.groupBox_options.Controls.Add(this.checkBox_preserveData);
            this.groupBox_options.Controls.Add(this.radioButton_BG3);
            this.groupBox_options.Enabled = false;
            this.groupBox_options.Location = new System.Drawing.Point(12, 41);
            this.groupBox_options.Name = "groupBox_options";
            this.groupBox_options.Size = new System.Drawing.Size(150, 124);
            this.groupBox_options.TabIndex = 12;
            this.groupBox_options.TabStop = false;
            this.groupBox_options.Text = "Options";
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
            this.listBox_rows.TabIndex = 5;
            // 
            // FormImportLZ77BG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 177);
            this.Controls.Add(this.groupBox_options);
            this.Controls.Add(this.groupBox_palette);
            this.Controls.Add(this.label_image);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormImportLZ77BG";
            this.Text = "Import BG3";
            this.groupBox_palette.ResumeLayout(false);
            this.groupBox_palette.PerformLayout();
            this.groupBox_options.ResumeLayout(false);
            this.groupBox_options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_image;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.GroupBox groupBox_palette;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.CheckBox checkBox_autoRows;
        private System.Windows.Forms.CheckBox checkBox_preserveData;
        private System.Windows.Forms.RadioButton radioButton_BG0;
        private System.Windows.Forms.RadioButton radioButton_BG3;
        private System.Windows.Forms.CheckBox checkBox_addToGraphics;
        private System.Windows.Forms.GroupBox groupBox_options;
        private System.Windows.Forms.ListBox listBox_rows;
    }
}