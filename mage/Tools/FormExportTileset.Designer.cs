namespace mage
{
    partial class FormExportTileset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExportTileset));
            this.label_export = new System.Windows.Forms.Label();
            this.radioButton_choose = new System.Windows.Forms.RadioButton();
            this.radioButton_current = new System.Windows.Forms.RadioButton();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.comboBox_tileset = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_export
            // 
            resources.ApplyResources(this.label_export, "label_export");
            this.label_export.Name = "label_export";
            // 
            // radioButton_choose
            // 
            resources.ApplyResources(this.radioButton_choose, "radioButton_choose");
            this.radioButton_choose.Name = "radioButton_choose";
            this.radioButton_choose.UseVisualStyleBackColor = true;
            // 
            // radioButton_current
            // 
            resources.ApplyResources(this.radioButton_current, "radioButton_current");
            this.radioButton_current.Checked = true;
            this.radioButton_current.Name = "radioButton_current";
            this.radioButton_current.TabStop = true;
            this.radioButton_current.UseVisualStyleBackColor = true;
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
            // comboBox_tileset
            // 
            resources.ApplyResources(this.comboBox_tileset, "comboBox_tileset");
            this.comboBox_tileset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tileset.FormattingEnabled = true;
            this.comboBox_tileset.Name = "comboBox_tileset";
            // 
            // FormExportTileset
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox_tileset);
            this.Controls.Add(this.label_export);
            this.Controls.Add(this.radioButton_choose);
            this.Controls.Add(this.radioButton_current);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormExportTileset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_export;
        private System.Windows.Forms.RadioButton radioButton_choose;
        private System.Windows.Forms.RadioButton radioButton_current;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.ComboBox comboBox_tileset;
    }
}