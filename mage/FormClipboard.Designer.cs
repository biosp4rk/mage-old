namespace mage
{
    partial class FormClipboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClipboard));
            this.pictureBox_clipboard = new System.Windows.Forms.PictureBox();
            this.panel_clipboard = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clipboard)).BeginInit();
            this.panel_clipboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_clipboard
            // 
            this.pictureBox_clipboard.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_clipboard.Name = "pictureBox_clipboard";
            this.pictureBox_clipboard.Size = new System.Drawing.Size(256, 256);
            this.pictureBox_clipboard.TabIndex = 0;
            this.pictureBox_clipboard.TabStop = false;
            // 
            // panel_clipboard
            // 
            this.panel_clipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_clipboard.AutoScroll = true;
            this.panel_clipboard.Controls.Add(this.pictureBox_clipboard);
            this.panel_clipboard.Location = new System.Drawing.Point(12, 12);
            this.panel_clipboard.Name = "panel_clipboard";
            this.panel_clipboard.Size = new System.Drawing.Size(273, 273);
            this.panel_clipboard.TabIndex = 1;
            // 
            // FormClipboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 297);
            this.Controls.Add(this.panel_clipboard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormClipboard";
            this.Text = "Clipboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_clipboard)).EndInit();
            this.panel_clipboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_clipboard;
        private System.Windows.Forms.Panel panel_clipboard;
    }
}