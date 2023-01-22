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
            this.label_export.AutoSize = true;
            this.label_export.Location = new System.Drawing.Point(12, 9);
            this.label_export.Name = "label_export";
            this.label_export.Size = new System.Drawing.Size(40, 13);
            this.label_export.TabIndex = 0;
            this.label_export.Text = "Export:";
            // 
            // radioButton_choose
            // 
            this.radioButton_choose.AutoSize = true;
            this.radioButton_choose.Location = new System.Drawing.Point(15, 50);
            this.radioButton_choose.Name = "radioButton_choose";
            this.radioButton_choose.Size = new System.Drawing.Size(59, 17);
            this.radioButton_choose.TabIndex = 1;
            this.radioButton_choose.Text = "Tileset:";
            this.radioButton_choose.UseVisualStyleBackColor = true;
            // 
            // radioButton_current
            // 
            this.radioButton_current.AutoSize = true;
            this.radioButton_current.Checked = true;
            this.radioButton_current.Location = new System.Drawing.Point(15, 27);
            this.radioButton_current.Name = "radioButton_current";
            this.radioButton_current.Size = new System.Drawing.Size(122, 17);
            this.radioButton_current.TabIndex = 0;
            this.radioButton_current.TabStop = true;
            this.radioButton_current.Text = "Current room\'s tileset";
            this.radioButton_current.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(147, 46);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(147, 17);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(75, 23);
            this.button_ok.TabIndex = 3;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // comboBox_tileset
            // 
            this.comboBox_tileset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tileset.FormattingEnabled = true;
            this.comboBox_tileset.Location = new System.Drawing.Point(80, 48);
            this.comboBox_tileset.Name = "comboBox_tileset";
            this.comboBox_tileset.Size = new System.Drawing.Size(49, 21);
            this.comboBox_tileset.TabIndex = 8;
            // 
            // FormExportTileset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 81);
            this.Controls.Add(this.comboBox_tileset);
            this.Controls.Add(this.label_export);
            this.Controls.Add(this.radioButton_choose);
            this.Controls.Add(this.radioButton_current);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormExportTileset";
            this.Text = "Export Tileset";
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