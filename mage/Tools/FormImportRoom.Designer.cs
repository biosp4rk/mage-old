namespace mage
{
    partial class FormImportRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportRoom));
            this.radioButton_current = new System.Windows.Forms.RadioButton();
            this.radioButton_original = new System.Windows.Forms.RadioButton();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.checkBox_convertClip = new System.Windows.Forms.CheckBox();
            this.checkBox_BGs = new System.Windows.Forms.CheckBox();
            this.checkBox_sprites = new System.Windows.Forms.CheckBox();
            this.checkBox_doors = new System.Windows.Forms.CheckBox();
            this.checkBox_scrolls = new System.Windows.Forms.CheckBox();
            this.groupBox_replace = new System.Windows.Forms.GroupBox();
            this.groupBox_import = new System.Windows.Forms.GroupBox();
            this.checkBox_preserveData = new System.Windows.Forms.CheckBox();
            this.groupBox_replace.SuspendLayout();
            this.groupBox_import.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton_current
            // 
            this.radioButton_current.AutoSize = true;
            this.radioButton_current.Location = new System.Drawing.Point(6, 19);
            this.radioButton_current.Name = "radioButton_current";
            this.radioButton_current.Size = new System.Drawing.Size(85, 17);
            this.radioButton_current.TabIndex = 1;
            this.radioButton_current.Text = "Current room";
            this.radioButton_current.UseVisualStyleBackColor = true;
            // 
            // radioButton_original
            // 
            this.radioButton_original.AutoSize = true;
            this.radioButton_original.Location = new System.Drawing.Point(6, 42);
            this.radioButton_original.Name = "radioButton_original";
            this.radioButton_original.Size = new System.Drawing.Size(86, 17);
            this.radioButton_original.TabIndex = 2;
            this.radioButton_original.Text = "Original room";
            this.radioButton_original.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(205, 112);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 8;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(205, 83);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 7;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // checkBox_convertClip
            // 
            this.checkBox_convertClip.AutoSize = true;
            this.checkBox_convertClip.Location = new System.Drawing.Point(12, 83);
            this.checkBox_convertClip.Name = "checkBox_convertClip";
            this.checkBox_convertClip.Size = new System.Drawing.Size(103, 17);
            this.checkBox_convertClip.TabIndex = 0;
            this.checkBox_convertClip.Text = "Convert clipdata";
            this.checkBox_convertClip.UseVisualStyleBackColor = true;
            // 
            // checkBox_BGs
            // 
            this.checkBox_BGs.AutoSize = true;
            this.checkBox_BGs.Location = new System.Drawing.Point(6, 19);
            this.checkBox_BGs.Name = "checkBox_BGs";
            this.checkBox_BGs.Size = new System.Drawing.Size(89, 17);
            this.checkBox_BGs.TabIndex = 3;
            this.checkBox_BGs.Text = "Backgrounds";
            this.checkBox_BGs.UseVisualStyleBackColor = true;
            // 
            // checkBox_sprites
            // 
            this.checkBox_sprites.AutoSize = true;
            this.checkBox_sprites.Location = new System.Drawing.Point(6, 42);
            this.checkBox_sprites.Name = "checkBox_sprites";
            this.checkBox_sprites.Size = new System.Drawing.Size(58, 17);
            this.checkBox_sprites.TabIndex = 5;
            this.checkBox_sprites.Text = "Sprites";
            this.checkBox_sprites.UseVisualStyleBackColor = true;
            // 
            // checkBox_doors
            // 
            this.checkBox_doors.AutoSize = true;
            this.checkBox_doors.Location = new System.Drawing.Point(101, 42);
            this.checkBox_doors.Name = "checkBox_doors";
            this.checkBox_doors.Size = new System.Drawing.Size(54, 17);
            this.checkBox_doors.TabIndex = 6;
            this.checkBox_doors.Text = "Doors";
            this.checkBox_doors.UseVisualStyleBackColor = true;
            // 
            // checkBox_scrolls
            // 
            this.checkBox_scrolls.AutoSize = true;
            this.checkBox_scrolls.Location = new System.Drawing.Point(101, 19);
            this.checkBox_scrolls.Name = "checkBox_scrolls";
            this.checkBox_scrolls.Size = new System.Drawing.Size(57, 17);
            this.checkBox_scrolls.TabIndex = 4;
            this.checkBox_scrolls.Text = "Scrolls";
            this.checkBox_scrolls.UseVisualStyleBackColor = true;
            // 
            // groupBox_replace
            // 
            this.groupBox_replace.Controls.Add(this.radioButton_current);
            this.groupBox_replace.Controls.Add(this.radioButton_original);
            this.groupBox_replace.Location = new System.Drawing.Point(12, 12);
            this.groupBox_replace.Name = "groupBox_replace";
            this.groupBox_replace.Size = new System.Drawing.Size(98, 65);
            this.groupBox_replace.TabIndex = 9;
            this.groupBox_replace.TabStop = false;
            this.groupBox_replace.Text = "Replace";
            // 
            // groupBox_import
            // 
            this.groupBox_import.Controls.Add(this.checkBox_BGs);
            this.groupBox_import.Controls.Add(this.checkBox_sprites);
            this.groupBox_import.Controls.Add(this.checkBox_doors);
            this.groupBox_import.Controls.Add(this.checkBox_scrolls);
            this.groupBox_import.Location = new System.Drawing.Point(116, 12);
            this.groupBox_import.Name = "groupBox_import";
            this.groupBox_import.Size = new System.Drawing.Size(164, 65);
            this.groupBox_import.TabIndex = 10;
            this.groupBox_import.TabStop = false;
            this.groupBox_import.Text = "Import";
            // 
            // checkBox_preserveData
            // 
            this.checkBox_preserveData.AutoSize = true;
            this.checkBox_preserveData.Location = new System.Drawing.Point(12, 106);
            this.checkBox_preserveData.Name = "checkBox_preserveData";
            this.checkBox_preserveData.Size = new System.Drawing.Size(130, 30);
            this.checkBox_preserveData.TabIndex = 11;
            this.checkBox_preserveData.Text = "Preserve existing data\r\n(if used by other BGs)";
            this.checkBox_preserveData.UseVisualStyleBackColor = true;
            // 
            // FormImportRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 148);
            this.Controls.Add(this.checkBox_preserveData);
            this.Controls.Add(this.groupBox_import);
            this.Controls.Add(this.groupBox_replace);
            this.Controls.Add(this.checkBox_convertClip);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormImportRoom";
            this.Text = "Import Room";
            this.groupBox_replace.ResumeLayout(false);
            this.groupBox_replace.PerformLayout();
            this.groupBox_import.ResumeLayout(false);
            this.groupBox_import.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_current;
        private System.Windows.Forms.RadioButton radioButton_original;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.CheckBox checkBox_convertClip;
        private System.Windows.Forms.CheckBox checkBox_BGs;
        private System.Windows.Forms.CheckBox checkBox_sprites;
        private System.Windows.Forms.CheckBox checkBox_doors;
        private System.Windows.Forms.CheckBox checkBox_scrolls;
        private System.Windows.Forms.GroupBox groupBox_replace;
        private System.Windows.Forms.GroupBox groupBox_import;
        private System.Windows.Forms.CheckBox checkBox_preserveData;
    }
}