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
            resources.ApplyResources(this.label_mage, "label_mage");
            this.label_mage.Name = "label_mage";
            // 
            // label_version
            // 
            resources.ApplyResources(this.label_version, "label_version");
            this.label_version.Name = "label_version";
            // 
            // label_bugs
            // 
            resources.ApplyResources(this.label_bugs, "label_bugs");
            this.label_bugs.Name = "label_bugs";
            // 
            // linkLabel_forum
            // 
            resources.ApplyResources(this.linkLabel_forum, "linkLabel_forum");
            this.linkLabel_forum.Name = "linkLabel_forum";
            this.linkLabel_forum.TabStop = true;
            this.linkLabel_forum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_forum_LinkClicked);
            // 
            // label_silk
            // 
            resources.ApplyResources(this.label_silk, "label_silk");
            this.label_silk.Name = "label_silk";
            // 
            // linkLabel_silk
            // 
            resources.ApplyResources(this.linkLabel_silk, "linkLabel_silk");
            this.linkLabel_silk.Name = "linkLabel_silk";
            this.linkLabel_silk.TabStop = true;
            this.linkLabel_silk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_silk_LinkClicked);
            // 
            // FormAbout
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabel_silk);
            this.Controls.Add(this.label_silk);
            this.Controls.Add(this.linkLabel_forum);
            this.Controls.Add(this.label_bugs);
            this.Controls.Add(this.label_version);
            this.Controls.Add(this.label_mage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
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