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
            this.comboBox_number = new mage.Theming.CustomControls.FlatComboBox();
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
            this.pictureBox_ending.Location = new System.Drawing.Point(6, 19);
            this.pictureBox_ending.Name = "pictureBox_ending";
            this.pictureBox_ending.Size = new System.Drawing.Size(240, 416);
            this.pictureBox_ending.TabIndex = 0;
            this.pictureBox_ending.TabStop = false;
            // 
            // groupBox_image
            // 
            this.groupBox_image.Controls.Add(this.pictureBox_ending);
            this.groupBox_image.Location = new System.Drawing.Point(143, 12);
            this.groupBox_image.Name = "groupBox_image";
            this.groupBox_image.Size = new System.Drawing.Size(252, 441);
            this.groupBox_image.TabIndex = 0;
            this.groupBox_image.TabStop = false;
            this.groupBox_image.Text = "Image";
            // 
            // comboBox_number
            // 
            this.comboBox_number.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_number.FormattingEnabled = true;
            this.comboBox_number.Location = new System.Drawing.Point(54, 13);
            this.comboBox_number.Name = "comboBox_number";
            this.comboBox_number.Size = new System.Drawing.Size(40, 21);
            this.comboBox_number.TabIndex = 0;
            this.comboBox_number.SelectedIndexChanged += new System.EventHandler(this.comboBox_number_SelectedIndexChanged);
            // 
            // label_ending
            // 
            this.label_ending.AutoSize = true;
            this.label_ending.Location = new System.Drawing.Point(8, 16);
            this.label_ending.Name = "label_ending";
            this.label_ending.Size = new System.Drawing.Size(40, 13);
            this.label_ending.TabIndex = 0;
            this.label_ending.Text = "Ending";
            // 
            // label_requirements
            // 
            this.label_requirements.AutoSize = true;
            this.label_requirements.Location = new System.Drawing.Point(8, 41);
            this.label_requirements.Name = "label_requirements";
            this.label_requirements.Size = new System.Drawing.Size(75, 13);
            this.label_requirements.TabIndex = 0;
            this.label_requirements.Text = "Requirements:";
            // 
            // label_stats
            // 
            this.label_stats.AutoSize = true;
            this.label_stats.Location = new System.Drawing.Point(8, 61);
            this.label_stats.Name = "label_stats";
            this.label_stats.Size = new System.Drawing.Size(10, 13);
            this.label_stats.TabIndex = 0;
            this.label_stats.Text = "-";
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(8, 121);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(75, 23);
            this.button_open.TabIndex = 1;
            this.button_open.Text = "Open";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_go
            // 
            this.button_go.Location = new System.Drawing.Point(6, 49);
            this.button_go.Name = "button_go";
            this.button_go.Size = new System.Drawing.Size(75, 23);
            this.button_go.TabIndex = 0;
            this.button_go.Text = "Go";
            this.button_go.UseVisualStyleBackColor = true;
            this.button_go.Click += new System.EventHandler(this.button_go_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Repeat until image\r\nis acceptable";
            // 
            // button_apply
            // 
            this.button_apply.Enabled = false;
            this.button_apply.Location = new System.Drawing.Point(62, 287);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(75, 23);
            this.button_apply.TabIndex = 2;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(62, 316);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 3;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // groupBox_select
            // 
            this.groupBox_select.Controls.Add(this.label_image);
            this.groupBox_select.Controls.Add(this.label_ending);
            this.groupBox_select.Controls.Add(this.comboBox_number);
            this.groupBox_select.Controls.Add(this.label_requirements);
            this.groupBox_select.Controls.Add(this.label_stats);
            this.groupBox_select.Controls.Add(this.button_open);
            this.groupBox_select.Location = new System.Drawing.Point(12, 12);
            this.groupBox_select.Name = "groupBox_select";
            this.groupBox_select.Size = new System.Drawing.Size(125, 183);
            this.groupBox_select.TabIndex = 0;
            this.groupBox_select.TabStop = false;
            this.groupBox_select.Text = "Select";
            // 
            // label_image
            // 
            this.label_image.AutoSize = true;
            this.label_image.Location = new System.Drawing.Point(8, 147);
            this.label_image.Name = "label_image";
            this.label_image.Size = new System.Drawing.Size(69, 26);
            this.label_image.TabIndex = 0;
            this.label_image.Text = "Image must\r\nbe 240 x 416";
            // 
            // groupBox_convert
            // 
            this.groupBox_convert.Controls.Add(this.label1);
            this.groupBox_convert.Controls.Add(this.button_go);
            this.groupBox_convert.Enabled = false;
            this.groupBox_convert.Location = new System.Drawing.Point(12, 201);
            this.groupBox_convert.Name = "groupBox_convert";
            this.groupBox_convert.Size = new System.Drawing.Size(125, 80);
            this.groupBox_convert.TabIndex = 1;
            this.groupBox_convert.TabStop = false;
            this.groupBox_convert.Text = "Convert";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 456);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(407, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 14;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(102, 17);
            this.statusLabel.Text = "No image opened";
            // 
            // FormImportEnding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 478);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox_convert);
            this.Controls.Add(this.groupBox_select);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.groupBox_image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormImportEnding";
            this.Text = "Import Ending";
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
        private mage.Theming.CustomControls.FlatComboBox comboBox_number;
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