namespace mage
{
    partial class FormCredits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCredits));
            this.textBox = new System.Windows.Forms.TextBox();
            this.panel_preview = new System.Windows.Forms.Panel();
            this.button_apply = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.label_lines = new System.Windows.Forms.Label();
            this.gfxView_preview = new mage.GfxView();
            this.panel_preview.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(12, 41);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(280, 320);
            this.textBox.TabIndex = 3;
            // 
            // panel_preview
            // 
            this.panel_preview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_preview.AutoScroll = true;
            this.panel_preview.Controls.Add(this.gfxView_preview);
            this.panel_preview.Location = new System.Drawing.Point(298, 41);
            this.panel_preview.Name = "panel_preview";
            this.panel_preview.Size = new System.Drawing.Size(497, 320);
            this.panel_preview.TabIndex = 5;
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(12, 12);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(75, 23);
            this.button_apply.TabIndex = 0;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(93, 12);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 1;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(308, 12);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 2;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            // 
            // label_lines
            // 
            this.label_lines.AutoSize = true;
            this.label_lines.Location = new System.Drawing.Point(202, 17);
            this.label_lines.Name = "label_lines";
            this.label_lines.Size = new System.Drawing.Size(44, 13);
            this.label_lines.TabIndex = 6;
            this.label_lines.Text = "Lines: 0";
            // 
            // gfxView_preview
            // 
            this.gfxView_preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gfxView_preview.Location = new System.Drawing.Point(0, 0);
            this.gfxView_preview.Name = "gfxView_preview";
            this.gfxView_preview.Size = new System.Drawing.Size(480, 320);
            this.gfxView_preview.TabIndex = 4;
            this.gfxView_preview.TabStop = false;
            // 
            // FormCredits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 373);
            this.Controls.Add(this.label_lines);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.panel_preview);
            this.Controls.Add(this.textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(823, 412);
            this.Name = "FormCredits";
            this.Text = "Credits Editor";
            this.panel_preview.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private GfxView gfxView_preview;
        private System.Windows.Forms.Panel panel_preview;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label_lines;
    }
}