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
            this.textBox_value = new mage.Theming.CustomControls.FlatTextBox();
            this.textBox_gfx = new mage.Theming.CustomControls.FlatTextBox();
            this.textBox_palette = new mage.Theming.CustomControls.FlatTextBox();
            this.textBox_valOffset = new mage.Theming.CustomControls.FlatTextBox();
            this.label_value = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel_changes = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.HideSelection = false;
            this.treeView.Location = new System.Drawing.Point(12, 12);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(196, 267);
            this.treeView.TabIndex = 0;
            this.treeView.TabStop = false;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // button_gfx
            // 
            this.button_gfx.Enabled = false;
            this.button_gfx.Location = new System.Drawing.Point(214, 31);
            this.button_gfx.Name = "button_gfx";
            this.button_gfx.Size = new System.Drawing.Size(75, 23);
            this.button_gfx.TabIndex = 0;
            this.button_gfx.Text = "Edit GFX";
            this.button_gfx.UseVisualStyleBackColor = true;
            this.button_gfx.Click += new System.EventHandler(this.button_gfx_Click);
            // 
            // button_palette
            // 
            this.button_palette.Enabled = false;
            this.button_palette.Location = new System.Drawing.Point(214, 93);
            this.button_palette.Name = "button_palette";
            this.button_palette.Size = new System.Drawing.Size(75, 23);
            this.button_palette.TabIndex = 1;
            this.button_palette.Text = "Edit palette";
            this.button_palette.UseVisualStyleBackColor = true;
            this.button_palette.Click += new System.EventHandler(this.button_palette_Click);
            // 
            // button_apply
            // 
            this.button_apply.Enabled = false;
            this.button_apply.Location = new System.Drawing.Point(214, 181);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(75, 23);
            this.button_apply.TabIndex = 3;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(214, 257);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 4;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // textBox_value
            // 
            this.textBox_value.Enabled = false;
            this.textBox_value.Location = new System.Drawing.Point(256, 155);
            this.textBox_value.Name = "textBox_value";
            this.textBox_value.Size = new System.Drawing.Size(32, 20);
            this.textBox_value.TabIndex = 2;
            this.textBox_value.TextChanged += new System.EventHandler(this.textBox_value_TextChanged);
            // 
            // textBox_gfx
            // 
            this.textBox_gfx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_gfx.Location = new System.Drawing.Point(216, 12);
            this.textBox_gfx.Name = "textBox_gfx";
            this.textBox_gfx.ReadOnly = true;
            this.textBox_gfx.Size = new System.Drawing.Size(55, 13);
            this.textBox_gfx.TabIndex = 0;
            this.textBox_gfx.TabStop = false;
            this.textBox_gfx.Text = "–";
            // 
            // textBox_palette
            // 
            this.textBox_palette.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_palette.Location = new System.Drawing.Point(216, 74);
            this.textBox_palette.Name = "textBox_palette";
            this.textBox_palette.ReadOnly = true;
            this.textBox_palette.Size = new System.Drawing.Size(55, 13);
            this.textBox_palette.TabIndex = 0;
            this.textBox_palette.TabStop = false;
            this.textBox_palette.Text = "–";
            // 
            // textBox_valOffset
            // 
            this.textBox_valOffset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_valOffset.Location = new System.Drawing.Point(216, 136);
            this.textBox_valOffset.Name = "textBox_valOffset";
            this.textBox_valOffset.ReadOnly = true;
            this.textBox_valOffset.Size = new System.Drawing.Size(55, 13);
            this.textBox_valOffset.TabIndex = 0;
            this.textBox_valOffset.TabStop = false;
            this.textBox_valOffset.Text = "–";
            // 
            // label_value
            // 
            this.label_value.AutoSize = true;
            this.label_value.Location = new System.Drawing.Point(213, 158);
            this.label_value.Name = "label_value";
            this.label_value.Size = new System.Drawing.Size(37, 13);
            this.label_value.TabIndex = 0;
            this.label_value.Text = "Value:";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_changes});
            this.statusStrip.Location = new System.Drawing.Point(0, 283);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(301, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel_changes
            // 
            this.statusLabel_changes.Name = "statusLabel_changes";
            this.statusLabel_changes.Size = new System.Drawing.Size(12, 17);
            this.statusLabel_changes.Text = "-";
            // 
            // FormWeapon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 305);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.label_value);
            this.Controls.Add(this.textBox_valOffset);
            this.Controls.Add(this.textBox_palette);
            this.Controls.Add(this.textBox_gfx);
            this.Controls.Add(this.textBox_value);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.button_palette);
            this.Controls.Add(this.button_gfx);
            this.Controls.Add(this.treeView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWeapon";
            this.Text = "Weapon Editor";
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
        private mage.Theming.CustomControls.FlatTextBox textBox_value;
        private mage.Theming.CustomControls.FlatTextBox textBox_gfx;
        private mage.Theming.CustomControls.FlatTextBox textBox_palette;
        private mage.Theming.CustomControls.FlatTextBox textBox_valOffset;
        private System.Windows.Forms.Label label_value;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_changes;
    }
}