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
            this.listBox_rows = new System.Windows.Forms.ListBox();
            this.checkBox_autoRows = new System.Windows.Forms.CheckBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.checkBox_preserveData = new System.Windows.Forms.CheckBox();
            this.radioButton_BG0 = new System.Windows.Forms.RadioButton();
            this.radioButton_BG3 = new System.Windows.Forms.RadioButton();
            this.checkBox_addToGraphics = new System.Windows.Forms.CheckBox();
            this.groupBox_options = new System.Windows.Forms.GroupBox();
            this.groupBox_palette.SuspendLayout();
            this.groupBox_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_image
            // 
            resources.ApplyResources(this.label_image, "label_image");
            this.label_image.Name = "label_image";
            // 
            // button_open
            // 
            resources.ApplyResources(this.button_open, "button_open");
            this.button_open.Name = "button_open";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
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
            // checkBox_autoRows
            // 
            resources.ApplyResources(this.checkBox_autoRows, "checkBox_autoRows");
            this.checkBox_autoRows.Checked = true;
            this.checkBox_autoRows.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_autoRows.Name = "checkBox_autoRows";
            this.checkBox_autoRows.UseVisualStyleBackColor = true;
            this.checkBox_autoRows.CheckedChanged += new System.EventHandler(this.checkBox_autoRows_CheckedChanged);
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
            // checkBox_preserveData
            // 
            resources.ApplyResources(this.checkBox_preserveData, "checkBox_preserveData");
            this.checkBox_preserveData.Name = "checkBox_preserveData";
            this.checkBox_preserveData.UseVisualStyleBackColor = true;
            // 
            // radioButton_BG0
            // 
            resources.ApplyResources(this.radioButton_BG0, "radioButton_BG0");
            this.radioButton_BG0.Name = "radioButton_BG0";
            this.radioButton_BG0.UseVisualStyleBackColor = true;
            // 
            // radioButton_BG3
            // 
            resources.ApplyResources(this.radioButton_BG3, "radioButton_BG3");
            this.radioButton_BG3.Checked = true;
            this.radioButton_BG3.Name = "radioButton_BG3";
            this.radioButton_BG3.TabStop = true;
            this.radioButton_BG3.UseVisualStyleBackColor = true;
            // 
            // checkBox_addToGraphics
            // 
            resources.ApplyResources(this.checkBox_addToGraphics, "checkBox_addToGraphics");
            this.checkBox_addToGraphics.Name = "checkBox_addToGraphics";
            this.checkBox_addToGraphics.UseVisualStyleBackColor = true;
            // 
            // groupBox_options
            // 
            resources.ApplyResources(this.groupBox_options, "groupBox_options");
            this.groupBox_options.Controls.Add(this.radioButton_BG0);
            this.groupBox_options.Controls.Add(this.checkBox_addToGraphics);
            this.groupBox_options.Controls.Add(this.checkBox_preserveData);
            this.groupBox_options.Controls.Add(this.radioButton_BG3);
            this.groupBox_options.Name = "groupBox_options";
            this.groupBox_options.TabStop = false;
            // 
            // FormImportLZ77BG
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox_options);
            this.Controls.Add(this.groupBox_palette);
            this.Controls.Add(this.label_image);
            this.Controls.Add(this.button_open);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormImportLZ77BG";
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