namespace mage
{
    partial class FormImportEnding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImportEnding));
            this.pictureBox_ending = new System.Windows.Forms.PictureBox();
            this.groupBox_image = new System.Windows.Forms.GroupBox();
            this.comboBox_number = new System.Windows.Forms.ComboBox();
            this.label_ending = new System.Windows.Forms.Label();
            this.label_requirements = new System.Windows.Forms.Label();
            this.label_stats = new System.Windows.Forms.Label();
            this.button_open = new System.Windows.Forms.Button();
            this.button_go = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_apply = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.groupBox_select = new System.Windows.Forms.GroupBox();
            this.label_image = new System.Windows.Forms.Label();
            this.groupBox_convert = new System.Windows.Forms.GroupBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ending)).BeginInit();
            this.groupBox_image.SuspendLayout();
            this.groupBox_select.SuspendLayout();
            this.groupBox_convert.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_ending
            // 
            resources.ApplyResources(this.pictureBox_ending, "pictureBox_ending");
            this.pictureBox_ending.Name = "pictureBox_ending";
            this.pictureBox_ending.TabStop = false;
            // 
            // groupBox_image
            // 
            resources.ApplyResources(this.groupBox_image, "groupBox_image");
            this.groupBox_image.Controls.Add(this.pictureBox_ending);
            this.groupBox_image.Name = "groupBox_image";
            this.groupBox_image.TabStop = false;
            // 
            // comboBox_number
            // 
            resources.ApplyResources(this.comboBox_number, "comboBox_number");
            this.comboBox_number.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_number.FormattingEnabled = true;
            this.comboBox_number.Name = "comboBox_number";
            this.comboBox_number.SelectedIndexChanged += new System.EventHandler(this.comboBox_number_SelectedIndexChanged);
            // 
            // label_ending
            // 
            resources.ApplyResources(this.label_ending, "label_ending");
            this.label_ending.Name = "label_ending";
            // 
            // label_requirements
            // 
            resources.ApplyResources(this.label_requirements, "label_requirements");
            this.label_requirements.Name = "label_requirements";
            // 
            // label_stats
            // 
            resources.ApplyResources(this.label_stats, "label_stats");
            this.label_stats.Name = "label_stats";
            // 
            // button_open
            // 
            resources.ApplyResources(this.button_open, "button_open");
            this.button_open.Name = "button_open";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_go
            // 
            resources.ApplyResources(this.button_go, "button_go");
            this.button_go.Name = "button_go";
            this.button_go.UseVisualStyleBackColor = true;
            this.button_go.Click += new System.EventHandler(this.button_go_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
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
            // groupBox_select
            // 
            resources.ApplyResources(this.groupBox_select, "groupBox_select");
            this.groupBox_select.Controls.Add(this.label_image);
            this.groupBox_select.Controls.Add(this.label_ending);
            this.groupBox_select.Controls.Add(this.comboBox_number);
            this.groupBox_select.Controls.Add(this.label_requirements);
            this.groupBox_select.Controls.Add(this.label_stats);
            this.groupBox_select.Controls.Add(this.button_open);
            this.groupBox_select.Name = "groupBox_select";
            this.groupBox_select.TabStop = false;
            // 
            // label_image
            // 
            resources.ApplyResources(this.label_image, "label_image");
            this.label_image.Name = "label_image";
            // 
            // groupBox_convert
            // 
            resources.ApplyResources(this.groupBox_convert, "groupBox_convert");
            this.groupBox_convert.Controls.Add(this.label1);
            this.groupBox_convert.Controls.Add(this.button_go);
            this.groupBox_convert.Name = "groupBox_convert";
            this.groupBox_convert.TabStop = false;
            // 
            // statusStrip
            // 
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.SizingGrip = false;
            // 
            // statusLabel
            // 
            resources.ApplyResources(this.statusLabel, "statusLabel");
            this.statusLabel.Name = "statusLabel";
            // 
            // FormImportEnding
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox_convert);
            this.Controls.Add(this.groupBox_select);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.groupBox_image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormImportEnding";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ending)).EndInit();
            this.groupBox_image.ResumeLayout(false);
            this.groupBox_select.ResumeLayout(false);
            this.groupBox_select.PerformLayout();
            this.groupBox_convert.ResumeLayout(false);
            this.groupBox_convert.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_ending;
        private System.Windows.Forms.GroupBox groupBox_image;
        private System.Windows.Forms.ComboBox comboBox_number;
        private System.Windows.Forms.Label label_ending;
        private System.Windows.Forms.Label label_requirements;
        private System.Windows.Forms.Label label_stats;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Button button_go;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.GroupBox groupBox_select;
        private System.Windows.Forms.GroupBox groupBox_convert;
        private System.Windows.Forms.Label label_image;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}