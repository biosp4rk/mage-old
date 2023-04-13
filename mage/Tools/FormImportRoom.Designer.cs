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
            resources.ApplyResources(this.radioButton_current, "radioButton_current");
            this.radioButton_current.Name = "radioButton_current";
            this.radioButton_current.UseVisualStyleBackColor = true;
            // 
            // radioButton_original
            // 
            resources.ApplyResources(this.radioButton_original, "radioButton_original");
            this.radioButton_original.Name = "radioButton_original";
            this.radioButton_original.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            resources.ApplyResources(this.button_cancel, "button_cancel");
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_ok
            // 
            resources.ApplyResources(this.button_ok, "button_ok");
            this.button_ok.Name = "button_ok";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // checkBox_convertClip
            // 
            resources.ApplyResources(this.checkBox_convertClip, "checkBox_convertClip");
            this.checkBox_convertClip.Name = "checkBox_convertClip";
            this.checkBox_convertClip.UseVisualStyleBackColor = true;
            // 
            // checkBox_BGs
            // 
            resources.ApplyResources(this.checkBox_BGs, "checkBox_BGs");
            this.checkBox_BGs.Name = "checkBox_BGs";
            this.checkBox_BGs.UseVisualStyleBackColor = true;
            // 
            // checkBox_sprites
            // 
            resources.ApplyResources(this.checkBox_sprites, "checkBox_sprites");
            this.checkBox_sprites.Name = "checkBox_sprites";
            this.checkBox_sprites.UseVisualStyleBackColor = true;
            // 
            // checkBox_doors
            // 
            resources.ApplyResources(this.checkBox_doors, "checkBox_doors");
            this.checkBox_doors.Name = "checkBox_doors";
            this.checkBox_doors.UseVisualStyleBackColor = true;
            // 
            // checkBox_scrolls
            // 
            resources.ApplyResources(this.checkBox_scrolls, "checkBox_scrolls");
            this.checkBox_scrolls.Name = "checkBox_scrolls";
            this.checkBox_scrolls.UseVisualStyleBackColor = true;
            // 
            // groupBox_replace
            // 
            resources.ApplyResources(this.groupBox_replace, "groupBox_replace");
            this.groupBox_replace.Controls.Add(this.radioButton_current);
            this.groupBox_replace.Controls.Add(this.radioButton_original);
            this.groupBox_replace.Name = "groupBox_replace";
            this.groupBox_replace.TabStop = false;
            // 
            // groupBox_import
            // 
            resources.ApplyResources(this.groupBox_import, "groupBox_import");
            this.groupBox_import.Controls.Add(this.checkBox_BGs);
            this.groupBox_import.Controls.Add(this.checkBox_sprites);
            this.groupBox_import.Controls.Add(this.checkBox_doors);
            this.groupBox_import.Controls.Add(this.checkBox_scrolls);
            this.groupBox_import.Name = "groupBox_import";
            this.groupBox_import.TabStop = false;
            // 
            // checkBox_preserveData
            // 
            resources.ApplyResources(this.checkBox_preserveData, "checkBox_preserveData");
            this.checkBox_preserveData.Name = "checkBox_preserveData";
            this.checkBox_preserveData.UseVisualStyleBackColor = true;
            // 
            // FormImportRoom
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox_preserveData);
            this.Controls.Add(this.groupBox_import);
            this.Controls.Add(this.groupBox_replace);
            this.Controls.Add(this.checkBox_convertClip);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormImportRoom";
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