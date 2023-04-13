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
            this.comboBox_tileset = new System.Windows.Forms.ComboBox();
            this.checkBox_preserveData = new System.Windows.Forms.CheckBox();
            this.groupBox_select = new System.Windows.Forms.GroupBox();
            this.groupBox_select.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_ok
            // 
            resources.ApplyResources(this.button_ok, "button_ok");
            this.button_ok.Name = "button_ok";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            resources.ApplyResources(this.button_cancel, "button_cancel");
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // radioButton_original
            // 
            resources.ApplyResources(this.radioButton_original, "radioButton_original");
            this.radioButton_original.Name = "radioButton_original";
            this.radioButton_original.UseVisualStyleBackColor = true;
            // 
            // radioButton_current
            // 
            resources.ApplyResources(this.radioButton_current, "radioButton_current");
            this.radioButton_current.Name = "radioButton_current";
            this.radioButton_current.UseVisualStyleBackColor = true;
            // 
            // radioButton_choose
            // 
            resources.ApplyResources(this.radioButton_choose, "radioButton_choose");
            this.radioButton_choose.Name = "radioButton_choose";
            this.radioButton_choose.UseVisualStyleBackColor = true;
            // 
            // checkBox_genericTiles
            // 
            resources.ApplyResources(this.checkBox_genericTiles, "checkBox_genericTiles");
            this.checkBox_genericTiles.Name = "checkBox_genericTiles";
            this.checkBox_genericTiles.UseVisualStyleBackColor = true;
            // 
            // comboBox_tileset
            // 
            resources.ApplyResources(this.comboBox_tileset, "comboBox_tileset");
            this.comboBox_tileset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tileset.FormattingEnabled = true;
            this.comboBox_tileset.Name = "comboBox_tileset";
            // 
            // checkBox_preserveData
            // 
            resources.ApplyResources(this.checkBox_preserveData, "checkBox_preserveData");
            this.checkBox_preserveData.Name = "checkBox_preserveData";
            this.checkBox_preserveData.UseVisualStyleBackColor = true;
            // 
            // groupBox_select
            // 
            resources.ApplyResources(this.groupBox_select, "groupBox_select");
            this.groupBox_select.Controls.Add(this.radioButton_original);
            this.groupBox_select.Controls.Add(this.comboBox_tileset);
            this.groupBox_select.Controls.Add(this.radioButton_choose);
            this.groupBox_select.Controls.Add(this.radioButton_current);
            this.groupBox_select.Name = "groupBox_select";
            this.groupBox_select.TabStop = false;
            // 
            // FormImportTileset
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_select);
            this.Controls.Add(this.checkBox_preserveData);
            this.Controls.Add(this.checkBox_genericTiles);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormImportTileset";
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
        private System.Windows.Forms.ComboBox comboBox_tileset;
        private System.Windows.Forms.CheckBox checkBox_preserveData;
        private System.Windows.Forms.GroupBox groupBox_select;
    }
}