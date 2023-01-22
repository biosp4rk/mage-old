namespace mage
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.label_mage = new System.Windows.Forms.Label();
            this.label_version = new System.Windows.Forms.Label();
            this.label_bugs = new System.Windows.Forms.Label();
            this.linkLabel_forum = new System.Windows.Forms.LinkLabel();
            this.label_silk = new System.Windows.Forms.Label();
            this.linkLabel_silk = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label_mage
            // 
            this.label_mage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mage.Location = new System.Drawing.Point(32, 21);
            this.label_mage.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_mage.Name = "label_mage";
            this.label_mage.Size = new System.Drawing.Size(640, 62);
            this.label_mage.TabIndex = 0;
            this.label_mage.Text = "Metroid Advance Game Editor";
            this.label_mage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_version
            // 
            this.label_version.Location = new System.Drawing.Point(32, 83);
            this.label_version.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(640, 155);
            this.label_version.TabIndex = 5;
            this.label_version.Text = "Version 1.4.0\r\n2023-01-22\r\n\r\nCreated by biospark";
            this.label_version.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_bugs
            // 
            this.label_bugs.Location = new System.Drawing.Point(32, 238);
            this.label_bugs.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_bugs.Name = "label_bugs";
            this.label_bugs.Size = new System.Drawing.Size(640, 31);
            this.label_bugs.TabIndex = 6;
            this.label_bugs.Text = "Report bugs and other problems here:";
            this.label_bugs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkLabel_forum
            // 
            this.linkLabel_forum.Location = new System.Drawing.Point(32, 269);
            this.linkLabel_forum.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.linkLabel_forum.Name = "linkLabel_forum";
            this.linkLabel_forum.Size = new System.Drawing.Size(640, 93);
            this.linkLabel_forum.TabIndex = 7;
            this.linkLabel_forum.TabStop = true;
            this.linkLabel_forum.Text = "http://forum.metroidconstruction.com/index.php/topic,3969.0.html";
            this.linkLabel_forum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabel_forum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_forum_LinkClicked);
            // 
            // label_silk
            // 
            this.label_silk.Location = new System.Drawing.Point(32, 362);
            this.label_silk.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label_silk.Name = "label_silk";
            this.label_silk.Size = new System.Drawing.Size(640, 31);
            this.label_silk.TabIndex = 8;
            this.label_silk.Text = "Silk icon set by Mark James";
            this.label_silk.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkLabel_silk
            // 
            this.linkLabel_silk.Location = new System.Drawing.Point(32, 393);
            this.linkLabel_silk.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.linkLabel_silk.Name = "linkLabel_silk";
            this.linkLabel_silk.Size = new System.Drawing.Size(640, 31);
            this.linkLabel_silk.TabIndex = 9;
            this.linkLabel_silk.TabStop = true;
            this.linkLabel_silk.Text = "http://www.famfamfam.com/lab/icons/silk/";
            this.linkLabel_silk.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabel_silk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_silk_LinkClicked);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 446);
            this.Controls.Add(this.linkLabel_silk);
            this.Controls.Add(this.label_silk);
            this.Controls.Add(this.linkLabel_forum);
            this.Controls.Add(this.label_bugs);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.label_mage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.Text = "About MAGE";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_mage;
        private System.Windows.Forms.Label label_version;
        private System.Windows.Forms.Label label_bugs;
        private System.Windows.Forms.LinkLabel linkLabel_forum;
        private System.Windows.Forms.Label label_silk;
        private System.Windows.Forms.LinkLabel linkLabel_silk;
    }
}