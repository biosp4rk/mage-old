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
            this.listBox_rows = new System.Windows.Forms.ListBox();
            this.groupBox_select = new System.Windows.Forms.GroupBox();
            this.comboBox_tileset = new System.Windows.Forms.ComboBox();
            this.groupBox_palette.SuspendLayout();
            this.groupBox_select.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_open
            // 
            resources.ApplyResources(this.button_open, "button_open");
            this.button_open.Name = "button_open";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
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
            // radioButton_choose
            // 
            resources.ApplyResources(this.radioButton_choose, "radioButton_choose");
            this.radioButton_choose.Name = "radioButton_choose";
            this.radioButton_choose.UseVisualStyleBackColor = true;
            // 
            // radioButton_current
            // 
            resources.ApplyResources(this.radioButton_current, "radioButton_current");
            this.radioButton_current.Name = "radioButton_current";
            this.radioButton_current.UseVisualStyleBackColor = true;
            // 
            // label_image
            // 
            resources.ApplyResources(this.label_image, "label_image");
            this.label_image.Name = "label_image";
            // 
            // checkBox_autoRows
            // 
            resources.ApplyResources(this.checkBox_autoRows, "checkBox_autoRows");
            this.checkBox_autoRows.Checked = true;
            this.checkBox_autoRows.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_autoRows.Name = "checkBox_autoRows";
            this.checkBox_autoRows.UseVisualStyleBackColor = true;
            this.checkBox_autoRows.CheckedChanged += new System.EventHandler(this.checkBox_autoRows_CheckedChanged);
            // 
            // checkBox_preserveData
            // 
            resources.ApplyResources(this.checkBox_preserveData, "checkBox_preserveData");
            this.checkBox_preserveData.Name = "checkBox_preserveData";
            this.checkBox_preserveData.UseVisualStyleBackColor = true;
            // 
            // groupBox_palette
            // 
            resources.ApplyResources(this.groupBox_palette, "groupBox_palette");
            this.groupBox_palette.Controls.Add(this.listBox_rows);
            this.groupBox_palette.Controls.Add(this.checkBox_autoRows);
            this.groupBox_palette.Name = "groupBox_palette";
            this.groupBox_palette.TabStop = false;
            // 
            // listBox_rows
            // 
            resources.ApplyResources(this.listBox_rows, "listBox_rows");
            this.listBox_rows.FormattingEnabled = true;
            this.listBox_rows.Items.AddRange(new object[] {
            resources.GetString("listBox_rows.Items"),
            resources.GetString("listBox_rows.Items1"),
            resources.GetString("listBox_rows.Items2"),
            resources.GetString("listBox_rows.Items3"),
            resources.GetString("listBox_rows.Items4"),
            resources.GetString("listBox_rows.Items5"),
            resources.GetString("listBox_rows.Items6"),
            resources.GetString("listBox_rows.Items7"),
            resources.GetString("listBox_rows.Items8"),
            resources.GetString("listBox_rows.Items9"),
            resources.GetString("listBox_rows.Items10"),
            resources.GetString("listBox_rows.Items11"),
            resources.GetString("listBox_rows.Items12")});
            this.listBox_rows.Name = "listBox_rows";
            this.listBox_rows.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            // 
            // groupBox_select
            // 
            resources.ApplyResources(this.groupBox_select, "groupBox_select");
            this.groupBox_select.Controls.Add(this.comboBox_tileset);
            this.groupBox_select.Controls.Add(this.radioButton_current);
            this.groupBox_select.Controls.Add(this.radioButton_choose);
            this.groupBox_select.Name = "groupBox_select";
            this.groupBox_select.TabStop = false;
            // 
            // comboBox_tileset
            // 
            resources.ApplyResources(this.comboBox_tileset, "comboBox_tileset");
            this.comboBox_tileset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tileset.FormattingEnabled = true;
            this.comboBox_tileset.Name = "comboBox_tileset";
            // 
            // FormImportRLEBG
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox_preserveData);
            this.Controls.Add(this.groupBox_select);
            this.Controls.Add(this.groupBox_palette);
            this.Controls.Add(this.label_image);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.button_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormImportRLEBG";
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
        private System.Windows.Forms.ComboBox comboBox_tileset;
        private System.Windows.Forms.ListBox listBox_rows;
    }
}