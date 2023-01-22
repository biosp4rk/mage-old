namespace mage
{
    partial class FormEditScroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditScroll));
            this.label_direction = new System.Windows.Forms.Label();
            this.comboBox_direction = new System.Windows.Forms.ComboBox();
            this.button_close = new System.Windows.Forms.Button();
            this.button_apply = new System.Windows.Forms.Button();
            this.checkBox_breakable = new System.Windows.Forms.CheckBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel_changes = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_direction
            // 
            this.label_direction.AutoSize = true;
            this.label_direction.Location = new System.Drawing.Point(12, 15);
            this.label_direction.Name = "label_direction";
            this.label_direction.Size = new System.Drawing.Size(93, 13);
            this.label_direction.TabIndex = 0;
            this.label_direction.Text = "Extended bounds:";
            // 
            // comboBox_direction
            // 
            this.comboBox_direction.FormattingEnabled = true;
            this.comboBox_direction.Items.AddRange(new object[] {
            "None",
            "Left",
            "Right",
            "Top",
            "Bottom"});
            this.comboBox_direction.Location = new System.Drawing.Point(111, 12);
            this.comboBox_direction.Name = "comboBox_direction";
            this.comboBox_direction.Size = new System.Drawing.Size(70, 21);
            this.comboBox_direction.TabIndex = 1;
            this.comboBox_direction.SelectedIndexChanged += new System.EventHandler(this.comboBox_direction_SelectedIndexChanged);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(106, 71);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 3;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_apply
            // 
            this.button_apply.Enabled = false;
            this.button_apply.Location = new System.Drawing.Point(25, 71);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(75, 23);
            this.button_apply.TabIndex = 2;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // checkBox_breakable
            // 
            this.checkBox_breakable.AutoSize = true;
            this.checkBox_breakable.Location = new System.Drawing.Point(15, 41);
            this.checkBox_breakable.Name = "checkBox_breakable";
            this.checkBox_breakable.Size = new System.Drawing.Size(164, 17);
            this.checkBox_breakable.TabIndex = 4;
            this.checkBox_breakable.Text = "Triggered by breakable block";
            this.checkBox_breakable.UseVisualStyleBackColor = true;
            this.checkBox_breakable.CheckedChanged += new System.EventHandler(this.checkBox_breakable_CheckedChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_changes});
            this.statusStrip.Location = new System.Drawing.Point(0, 97);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(193, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel_changes
            // 
            this.statusLabel_changes.Name = "statusLabel_changes";
            this.statusLabel_changes.Size = new System.Drawing.Size(12, 17);
            this.statusLabel_changes.Text = "-";
            // 
            // FormEditScroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 119);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.checkBox_breakable);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.comboBox_direction);
            this.Controls.Add(this.label_direction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditScroll";
            this.Text = "Edit Scroll";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_direction;
        private System.Windows.Forms.ComboBox comboBox_direction;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.CheckBox checkBox_breakable;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_changes;
    }
}