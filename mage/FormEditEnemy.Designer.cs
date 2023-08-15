namespace mage
{
    partial class FormEditEnemy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditEnemy));
            this.button_apply = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.comboBox_prop = new mage.Theming.CustomControls.FlatComboBox();
            this.label_prop = new System.Windows.Forms.Label();
            this.groupBox_edit = new System.Windows.Forms.GroupBox();
            this.label_IDval = new System.Windows.Forms.Label();
            this.button_editSprite = new System.Windows.Forms.Button();
            this.label_ID = new System.Windows.Forms.Label();
            this.comboBox_slot = new mage.Theming.CustomControls.FlatComboBox();
            this.label_slot = new System.Windows.Forms.Label();
            this.groupBox_preview = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_preview = new System.Windows.Forms.PictureBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel_changes = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox_edit.SuspendLayout();
            this.groupBox_preview.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_apply
            // 
            this.button_apply.Enabled = false;
            this.button_apply.Location = new System.Drawing.Point(245, 127);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(75, 23);
            this.button_apply.TabIndex = 0;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(326, 127);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 1;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // comboBox_prop
            // 
            this.comboBox_prop.FormattingEnabled = true;
            this.comboBox_prop.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.comboBox_prop.Location = new System.Drawing.Point(61, 46);
            this.comboBox_prop.Name = "comboBox_prop";
            this.comboBox_prop.Size = new System.Drawing.Size(35, 21);
            this.comboBox_prop.TabIndex = 1;
            this.comboBox_prop.SelectedIndexChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label_prop
            // 
            this.label_prop.AutoSize = true;
            this.label_prop.Location = new System.Drawing.Point(6, 49);
            this.label_prop.Name = "label_prop";
            this.label_prop.Size = new System.Drawing.Size(49, 13);
            this.label_prop.TabIndex = 0;
            this.label_prop.Text = "Property:";
            // 
            // groupBox_edit
            // 
            this.groupBox_edit.Controls.Add(this.comboBox_prop);
            this.groupBox_edit.Controls.Add(this.label_IDval);
            this.groupBox_edit.Controls.Add(this.label_prop);
            this.groupBox_edit.Controls.Add(this.button_editSprite);
            this.groupBox_edit.Controls.Add(this.label_ID);
            this.groupBox_edit.Controls.Add(this.comboBox_slot);
            this.groupBox_edit.Controls.Add(this.label_slot);
            this.groupBox_edit.Location = new System.Drawing.Point(207, 12);
            this.groupBox_edit.Name = "groupBox_edit";
            this.groupBox_edit.Size = new System.Drawing.Size(194, 77);
            this.groupBox_edit.TabIndex = 0;
            this.groupBox_edit.TabStop = false;
            this.groupBox_edit.Text = "Edit";
            // 
            // label_IDval
            // 
            this.label_IDval.AutoSize = true;
            this.label_IDval.Location = new System.Drawing.Point(139, 22);
            this.label_IDval.Name = "label_IDval";
            this.label_IDval.Size = new System.Drawing.Size(13, 13);
            this.label_IDval.TabIndex = 0;
            this.label_IDval.Text = "0";
            // 
            // button_editSprite
            // 
            this.button_editSprite.Location = new System.Drawing.Point(113, 45);
            this.button_editSprite.Name = "button_editSprite";
            this.button_editSprite.Size = new System.Drawing.Size(75, 23);
            this.button_editSprite.TabIndex = 2;
            this.button_editSprite.Text = "Edit sprite";
            this.button_editSprite.UseVisualStyleBackColor = true;
            this.button_editSprite.Click += new System.EventHandler(this.button_editSprite_Click);
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(112, 22);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(21, 13);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "ID:";
            // 
            // comboBox_slot
            // 
            this.comboBox_slot.FormattingEnabled = true;
            this.comboBox_slot.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.comboBox_slot.Location = new System.Drawing.Point(61, 19);
            this.comboBox_slot.Name = "comboBox_slot";
            this.comboBox_slot.Size = new System.Drawing.Size(35, 21);
            this.comboBox_slot.TabIndex = 0;
            this.comboBox_slot.SelectedIndexChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label_slot
            // 
            this.label_slot.AutoSize = true;
            this.label_slot.Location = new System.Drawing.Point(6, 22);
            this.label_slot.Name = "label_slot";
            this.label_slot.Size = new System.Drawing.Size(28, 13);
            this.label_slot.TabIndex = 0;
            this.label_slot.Text = "Slot:";
            // 
            // groupBox_preview
            // 
            this.groupBox_preview.Controls.Add(this.panel1);
            this.groupBox_preview.Location = new System.Drawing.Point(12, 12);
            this.groupBox_preview.Name = "groupBox_preview";
            this.groupBox_preview.Size = new System.Drawing.Size(189, 138);
            this.groupBox_preview.TabIndex = 0;
            this.groupBox_preview.TabStop = false;
            this.groupBox_preview.Text = "Preview";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox_preview);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 113);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox_preview
            // 
            this.pictureBox_preview.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_preview.Name = "pictureBox_preview";
            this.pictureBox_preview.Size = new System.Drawing.Size(160, 96);
            this.pictureBox_preview.TabIndex = 34;
            this.pictureBox_preview.TabStop = false;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_changes});
            this.statusStrip.Location = new System.Drawing.Point(0, 153);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(413, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel_changes
            // 
            this.statusLabel_changes.Name = "statusLabel_changes";
            this.statusLabel_changes.Size = new System.Drawing.Size(12, 17);
            this.statusLabel_changes.Text = "-";
            // 
            // FormEditEnemy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 175);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox_preview);
            this.Controls.Add(this.groupBox_edit);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_apply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditEnemy";
            this.Text = "Edit Sprite";
            this.groupBox_edit.ResumeLayout(false);
            this.groupBox_edit.PerformLayout();
            this.groupBox_preview.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_preview)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Button button_close;
        private mage.Theming.CustomControls.FlatComboBox comboBox_prop;
        private System.Windows.Forms.Label label_prop;
        private System.Windows.Forms.GroupBox groupBox_edit;
        private System.Windows.Forms.Label label_IDval;
        private System.Windows.Forms.Button button_editSprite;
        private System.Windows.Forms.Label label_ID;
        private mage.Theming.CustomControls.FlatComboBox comboBox_slot;
        private System.Windows.Forms.Label label_slot;
        private System.Windows.Forms.GroupBox groupBox_preview;
        private System.Windows.Forms.PictureBox pictureBox_preview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_changes;
    }
}