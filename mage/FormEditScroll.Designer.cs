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
            resources.ApplyResources(this.label_direction, "label_direction");
            this.label_direction.Name = "label_direction";
            // 
            // comboBox_direction
            // 
            resources.ApplyResources(this.comboBox_direction, "comboBox_direction");
            this.comboBox_direction.FormattingEnabled = true;
            this.comboBox_direction.Items.AddRange(new object[] {
            resources.GetString("comboBox_direction.Items"),
            resources.GetString("comboBox_direction.Items1"),
            resources.GetString("comboBox_direction.Items2"),
            resources.GetString("comboBox_direction.Items3"),
            resources.GetString("comboBox_direction.Items4")});
            this.comboBox_direction.Name = "comboBox_direction";
            this.comboBox_direction.SelectedIndexChanged += new System.EventHandler(this.comboBox_direction_SelectedIndexChanged);
            // 
            // button_close
            // 
            resources.ApplyResources(this.button_close, "button_close");
            this.button_close.Name = "button_close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_apply
            // 
            resources.ApplyResources(this.button_apply, "button_apply");
            this.button_apply.Name = "button_apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // checkBox_breakable
            // 
            resources.ApplyResources(this.checkBox_breakable, "checkBox_breakable");
            this.checkBox_breakable.Name = "checkBox_breakable";
            this.checkBox_breakable.UseVisualStyleBackColor = true;
            this.checkBox_breakable.CheckedChanged += new System.EventHandler(this.checkBox_breakable_CheckedChanged);
            // 
            // statusStrip
            // 
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_changes});
            this.statusStrip.Name = "statusStrip";
            // 
            // statusLabel_changes
            // 
            resources.ApplyResources(this.statusLabel_changes, "statusLabel_changes");
            this.statusLabel_changes.Name = "statusLabel_changes";
            // 
            // FormEditScroll
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.checkBox_breakable);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.comboBox_direction);
            this.Controls.Add(this.label_direction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditScroll";
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