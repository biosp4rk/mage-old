namespace mage
{
    partial class FormWeapon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWeapon));
            this.treeView = new System.Windows.Forms.TreeView();
            this.button_gfx = new System.Windows.Forms.Button();
            this.button_palette = new System.Windows.Forms.Button();
            this.button_apply = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.textBox_value = new System.Windows.Forms.TextBox();
            this.textBox_gfx = new System.Windows.Forms.TextBox();
            this.textBox_palette = new System.Windows.Forms.TextBox();
            this.textBox_valOffset = new System.Windows.Forms.TextBox();
            this.label_value = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel_changes = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            resources.ApplyResources(this.treeView, "treeView");
            this.treeView.HideSelection = false;
            this.treeView.Name = "treeView";
            this.treeView.TabStop = false;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // button_gfx
            // 
            resources.ApplyResources(this.button_gfx, "button_gfx");
            this.button_gfx.Name = "button_gfx";
            this.button_gfx.UseVisualStyleBackColor = true;
            this.button_gfx.Click += new System.EventHandler(this.button_gfx_Click);
            // 
            // button_palette
            // 
            resources.ApplyResources(this.button_palette, "button_palette");
            this.button_palette.Name = "button_palette";
            this.button_palette.UseVisualStyleBackColor = true;
            this.button_palette.Click += new System.EventHandler(this.button_palette_Click);
            // 
            // button_apply
            // 
            resources.ApplyResources(this.button_apply, "button_apply");
            this.button_apply.Name = "button_apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // button_close
            // 
            resources.ApplyResources(this.button_close, "button_close");
            this.button_close.Name = "button_close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // textBox_value
            // 
            resources.ApplyResources(this.textBox_value, "textBox_value");
            this.textBox_value.Name = "textBox_value";
            this.textBox_value.TextChanged += new System.EventHandler(this.textBox_value_TextChanged);
            // 
            // textBox_gfx
            // 
            resources.ApplyResources(this.textBox_gfx, "textBox_gfx");
            this.textBox_gfx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_gfx.Name = "textBox_gfx";
            this.textBox_gfx.ReadOnly = true;
            this.textBox_gfx.TabStop = false;
            // 
            // textBox_palette
            // 
            resources.ApplyResources(this.textBox_palette, "textBox_palette");
            this.textBox_palette.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_palette.Name = "textBox_palette";
            this.textBox_palette.ReadOnly = true;
            this.textBox_palette.TabStop = false;
            // 
            // textBox_valOffset
            // 
            resources.ApplyResources(this.textBox_valOffset, "textBox_valOffset");
            this.textBox_valOffset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_valOffset.Name = "textBox_valOffset";
            this.textBox_valOffset.ReadOnly = true;
            this.textBox_valOffset.TabStop = false;
            // 
            // label_value
            // 
            resources.ApplyResources(this.label_value, "label_value");
            this.label_value.Name = "label_value";
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
            // FormWeapon
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.textBox_valOffset);
            this.Controls.Add(this.textBox_palette);
            this.Controls.Add(this.textBox_gfx);
            this.Controls.Add(this.textBox_value);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.button_palette);
            this.Controls.Add(this.button_gfx);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.label_value);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormWeapon";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button button_gfx;
        private System.Windows.Forms.Button button_palette;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.TextBox textBox_value;
        private System.Windows.Forms.TextBox textBox_gfx;
        private System.Windows.Forms.TextBox textBox_palette;
        private System.Windows.Forms.TextBox textBox_valOffset;
        private System.Windows.Forms.Label label_value;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_changes;
    }
}