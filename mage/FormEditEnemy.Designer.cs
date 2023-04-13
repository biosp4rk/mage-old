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
            this.comboBox_prop = new System.Windows.Forms.ComboBox();
            this.label_prop = new System.Windows.Forms.Label();
            this.groupBox_edit = new System.Windows.Forms.GroupBox();
            this.label_IDval = new System.Windows.Forms.Label();
            this.button_editSprite = new System.Windows.Forms.Button();
            this.label_ID = new System.Windows.Forms.Label();
            this.comboBox_slot = new System.Windows.Forms.ComboBox();
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
            // comboBox_prop
            // 
            resources.ApplyResources(this.comboBox_prop, "comboBox_prop");
            this.comboBox_prop.FormattingEnabled = true;
            this.comboBox_prop.Items.AddRange(new object[] {
            resources.GetString("comboBox_prop.Items"),
            resources.GetString("comboBox_prop.Items1"),
            resources.GetString("comboBox_prop.Items2"),
            resources.GetString("comboBox_prop.Items3"),
            resources.GetString("comboBox_prop.Items4"),
            resources.GetString("comboBox_prop.Items5"),
            resources.GetString("comboBox_prop.Items6"),
            resources.GetString("comboBox_prop.Items7"),
            resources.GetString("comboBox_prop.Items8"),
            resources.GetString("comboBox_prop.Items9"),
            resources.GetString("comboBox_prop.Items10"),
            resources.GetString("comboBox_prop.Items11"),
            resources.GetString("comboBox_prop.Items12"),
            resources.GetString("comboBox_prop.Items13"),
            resources.GetString("comboBox_prop.Items14"),
            resources.GetString("comboBox_prop.Items15")});
            this.comboBox_prop.Name = "comboBox_prop";
            this.comboBox_prop.SelectedIndexChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label_prop
            // 
            resources.ApplyResources(this.label_prop, "label_prop");
            this.label_prop.Name = "label_prop";
            // 
            // groupBox_edit
            // 
            resources.ApplyResources(this.groupBox_edit, "groupBox_edit");
            this.groupBox_edit.Controls.Add(this.comboBox_prop);
            this.groupBox_edit.Controls.Add(this.label_IDval);
            this.groupBox_edit.Controls.Add(this.label_prop);
            this.groupBox_edit.Controls.Add(this.button_editSprite);
            this.groupBox_edit.Controls.Add(this.label_ID);
            this.groupBox_edit.Controls.Add(this.comboBox_slot);
            this.groupBox_edit.Controls.Add(this.label_slot);
            this.groupBox_edit.Name = "groupBox_edit";
            this.groupBox_edit.TabStop = false;
            // 
            // label_IDval
            // 
            resources.ApplyResources(this.label_IDval, "label_IDval");
            this.label_IDval.Name = "label_IDval";
            // 
            // button_editSprite
            // 
            resources.ApplyResources(this.button_editSprite, "button_editSprite");
            this.button_editSprite.Name = "button_editSprite";
            this.button_editSprite.UseVisualStyleBackColor = true;
            this.button_editSprite.Click += new System.EventHandler(this.button_editSprite_Click);
            // 
            // label_ID
            // 
            resources.ApplyResources(this.label_ID, "label_ID");
            this.label_ID.Name = "label_ID";
            // 
            // comboBox_slot
            // 
            resources.ApplyResources(this.comboBox_slot, "comboBox_slot");
            this.comboBox_slot.FormattingEnabled = true;
            this.comboBox_slot.Items.AddRange(new object[] {
            resources.GetString("comboBox_slot.Items"),
            resources.GetString("comboBox_slot.Items1"),
            resources.GetString("comboBox_slot.Items2"),
            resources.GetString("comboBox_slot.Items3"),
            resources.GetString("comboBox_slot.Items4"),
            resources.GetString("comboBox_slot.Items5"),
            resources.GetString("comboBox_slot.Items6"),
            resources.GetString("comboBox_slot.Items7"),
            resources.GetString("comboBox_slot.Items8"),
            resources.GetString("comboBox_slot.Items9"),
            resources.GetString("comboBox_slot.Items10"),
            resources.GetString("comboBox_slot.Items11"),
            resources.GetString("comboBox_slot.Items12"),
            resources.GetString("comboBox_slot.Items13"),
            resources.GetString("comboBox_slot.Items14")});
            this.comboBox_slot.Name = "comboBox_slot";
            this.comboBox_slot.SelectedIndexChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label_slot
            // 
            resources.ApplyResources(this.label_slot, "label_slot");
            this.label_slot.Name = "label_slot";
            // 
            // groupBox_preview
            // 
            resources.ApplyResources(this.groupBox_preview, "groupBox_preview");
            this.groupBox_preview.Controls.Add(this.panel1);
            this.groupBox_preview.Name = "groupBox_preview";
            this.groupBox_preview.TabStop = false;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.pictureBox_preview);
            this.panel1.Name = "panel1";
            // 
            // pictureBox_preview
            // 
            resources.ApplyResources(this.pictureBox_preview, "pictureBox_preview");
            this.pictureBox_preview.Name = "pictureBox_preview";
            this.pictureBox_preview.TabStop = false;
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
            // FormEditEnemy
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox_preview);
            this.Controls.Add(this.groupBox_edit);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_apply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditEnemy";
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
        private System.Windows.Forms.ComboBox comboBox_prop;
        private System.Windows.Forms.Label label_prop;
        private System.Windows.Forms.GroupBox groupBox_edit;
        private System.Windows.Forms.Label label_IDval;
        private System.Windows.Forms.Button button_editSprite;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.ComboBox comboBox_slot;
        private System.Windows.Forms.Label label_slot;
        private System.Windows.Forms.GroupBox groupBox_preview;
        private System.Windows.Forms.PictureBox pictureBox_preview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_changes;
    }
}