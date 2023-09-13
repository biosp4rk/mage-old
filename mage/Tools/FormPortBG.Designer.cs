namespace mage
{
    partial class FormPortBG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPortBG));
            this.label_bg = new System.Windows.Forms.Label();
            this.comboBox_bg = new mage.Theming.CustomControls.FlatComboBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.checkBox_preserveData = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label_bg
            // 
            this.label_bg.AutoSize = true;
            this.label_bg.Location = new System.Drawing.Point(12, 15);
            this.label_bg.Name = "label_bg";
            this.label_bg.Size = new System.Drawing.Size(68, 13);
            this.label_bg.TabIndex = 0;
            this.label_bg.Text = "Background:";
            // 
            // comboBox_bg
            // 
            this.comboBox_bg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_bg.FormattingEnabled = true;
            this.comboBox_bg.Location = new System.Drawing.Point(86, 12);
            this.comboBox_bg.Name = "comboBox_bg";
            this.comboBox_bg.Size = new System.Drawing.Size(70, 21);
            this.comboBox_bg.TabIndex = 1;
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(168, 11);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 2;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(168, 40);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // checkBox_preserveData
            // 
            this.checkBox_preserveData.AutoSize = true;
            this.checkBox_preserveData.Location = new System.Drawing.Point(15, 37);
            this.checkBox_preserveData.Name = "checkBox_preserveData";
            this.checkBox_preserveData.Size = new System.Drawing.Size(130, 30);
            this.checkBox_preserveData.TabIndex = 9;
            this.checkBox_preserveData.Text = "Preserve existing data\r\n(if used by other BGs)";
            this.checkBox_preserveData.UseVisualStyleBackColor = true;
            // 
            // FormPortBG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 80);
            this.Controls.Add(this.checkBox_preserveData);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.comboBox_bg);
            this.Controls.Add(this.label_bg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPortBG";
            this.Text = "Port Background";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_bg;
        private mage.Theming.CustomControls.FlatComboBox comboBox_bg;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.CheckBox checkBox_preserveData;
    }
}