namespace mage
{
    partial class FormText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormText));
            this.comboBox_language = new System.Windows.Forms.ComboBox();
            this.label_language = new System.Windows.Forms.Label();
            this.label_number = new System.Windows.Forms.Label();
            this.comboBox_number = new System.Windows.Forms.ComboBox();
            this.pictureBox_text = new System.Windows.Forms.PictureBox();
            this.checkBox_newLine = new System.Windows.Forms.CheckBox();
            this.checkBox_wordWrap = new System.Windows.Forms.CheckBox();
            this.label_text = new System.Windows.Forms.Label();
            this.comboBox_text = new System.Windows.Forms.ComboBox();
            this.textBox_offsetVal = new System.Windows.Forms.TextBox();
            this.label_offset = new System.Windows.Forms.Label();
            this.panel_gfx = new System.Windows.Forms.Panel();
            this.groupBox_options = new System.Windows.Forms.GroupBox();
            this.label_charPos = new System.Windows.Forms.Label();
            this.label_pos = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.button_apply = new System.Windows.Forms.Button();
            this.groupBox_preview = new System.Windows.Forms.GroupBox();
            this.button_editGfx = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_editPalette = new System.Windows.Forms.Button();
            this.pictureBox_palette = new System.Windows.Forms.PictureBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel_changes = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_text)).BeginInit();
            this.panel_gfx.SuspendLayout();
            this.groupBox_options.SuspendLayout();
            this.groupBox_preview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_palette)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_language
            // 
            this.comboBox_language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_language.FormattingEnabled = true;
            this.comboBox_language.Location = new System.Drawing.Point(70, 46);
            this.comboBox_language.Name = "comboBox_language";
            this.comboBox_language.Size = new System.Drawing.Size(90, 21);
            this.comboBox_language.TabIndex = 1;
            this.comboBox_language.SelectedIndexChanged += new System.EventHandler(this.comboBox_language_SelectedIndexChanged);
            // 
            // label_language
            // 
            this.label_language.AutoSize = true;
            this.label_language.Location = new System.Drawing.Point(6, 49);
            this.label_language.Name = "label_language";
            this.label_language.Size = new System.Drawing.Size(58, 13);
            this.label_language.TabIndex = 0;
            this.label_language.Text = "Language:";
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Location = new System.Drawing.Point(6, 76);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(47, 13);
            this.label_number.TabIndex = 0;
            this.label_number.Text = "Number:";
            // 
            // comboBox_number
            // 
            this.comboBox_number.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_number.FormattingEnabled = true;
            this.comboBox_number.Location = new System.Drawing.Point(70, 73);
            this.comboBox_number.Name = "comboBox_number";
            this.comboBox_number.Size = new System.Drawing.Size(49, 21);
            this.comboBox_number.TabIndex = 2;
            this.comboBox_number.SelectedIndexChanged += new System.EventHandler(this.comboBox_number_SelectedIndexChanged);
            // 
            // pictureBox_text
            // 
            this.pictureBox_text.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_text.Name = "pictureBox_text";
            this.pictureBox_text.Size = new System.Drawing.Size(240, 80);
            this.pictureBox_text.TabIndex = 5;
            this.pictureBox_text.TabStop = false;
            // 
            // checkBox_newLine
            // 
            this.checkBox_newLine.AutoSize = true;
            this.checkBox_newLine.Location = new System.Drawing.Point(176, 46);
            this.checkBox_newLine.Name = "checkBox_newLine";
            this.checkBox_newLine.Size = new System.Drawing.Size(94, 17);
            this.checkBox_newLine.TabIndex = 4;
            this.checkBox_newLine.Text = "Mark newlines";
            this.checkBox_newLine.UseVisualStyleBackColor = true;
            this.checkBox_newLine.CheckedChanged += new System.EventHandler(this.checkBox_newLine_CheckedChanged);
            // 
            // checkBox_wordWrap
            // 
            this.checkBox_wordWrap.AutoSize = true;
            this.checkBox_wordWrap.Checked = true;
            this.checkBox_wordWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_wordWrap.Location = new System.Drawing.Point(176, 19);
            this.checkBox_wordWrap.Name = "checkBox_wordWrap";
            this.checkBox_wordWrap.Size = new System.Drawing.Size(78, 17);
            this.checkBox_wordWrap.TabIndex = 3;
            this.checkBox_wordWrap.Text = "Word wrap";
            this.checkBox_wordWrap.UseVisualStyleBackColor = true;
            this.checkBox_wordWrap.CheckedChanged += new System.EventHandler(this.checkBox_wordWrap_CheckedChanged);
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Location = new System.Drawing.Point(6, 22);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(31, 13);
            this.label_text.TabIndex = 0;
            this.label_text.Text = "Text:";
            // 
            // comboBox_text
            // 
            this.comboBox_text.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_text.FormattingEnabled = true;
            this.comboBox_text.Location = new System.Drawing.Point(70, 19);
            this.comboBox_text.Name = "comboBox_text";
            this.comboBox_text.Size = new System.Drawing.Size(90, 21);
            this.comboBox_text.TabIndex = 0;
            this.comboBox_text.SelectedIndexChanged += new System.EventHandler(this.comboBox_text_SelectedIndexChanged);
            // 
            // textBox_offsetVal
            // 
            this.textBox_offsetVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_offsetVal.Location = new System.Drawing.Point(50, 103);
            this.textBox_offsetVal.Name = "textBox_offsetVal";
            this.textBox_offsetVal.ReadOnly = true;
            this.textBox_offsetVal.Size = new System.Drawing.Size(55, 13);
            this.textBox_offsetVal.TabIndex = 0;
            this.textBox_offsetVal.TabStop = false;
            this.textBox_offsetVal.Text = "000000";
            // 
            // label_offset
            // 
            this.label_offset.AutoSize = true;
            this.label_offset.Location = new System.Drawing.Point(6, 103);
            this.label_offset.Name = "label_offset";
            this.label_offset.Size = new System.Drawing.Size(38, 13);
            this.label_offset.TabIndex = 0;
            this.label_offset.Text = "Offset:";
            // 
            // panel_gfx
            // 
            this.panel_gfx.AutoScroll = true;
            this.panel_gfx.Controls.Add(this.pictureBox_text);
            this.panel_gfx.Location = new System.Drawing.Point(6, 41);
            this.panel_gfx.Name = "panel_gfx";
            this.panel_gfx.Size = new System.Drawing.Size(257, 80);
            this.panel_gfx.TabIndex = 32;
            // 
            // groupBox_options
            // 
            this.groupBox_options.Controls.Add(this.label_charPos);
            this.groupBox_options.Controls.Add(this.label_pos);
            this.groupBox_options.Controls.Add(this.button_close);
            this.groupBox_options.Controls.Add(this.button_apply);
            this.groupBox_options.Controls.Add(this.comboBox_text);
            this.groupBox_options.Controls.Add(this.comboBox_language);
            this.groupBox_options.Controls.Add(this.textBox_offsetVal);
            this.groupBox_options.Controls.Add(this.label_language);
            this.groupBox_options.Controls.Add(this.label_offset);
            this.groupBox_options.Controls.Add(this.comboBox_number);
            this.groupBox_options.Controls.Add(this.label_text);
            this.groupBox_options.Controls.Add(this.label_number);
            this.groupBox_options.Controls.Add(this.checkBox_newLine);
            this.groupBox_options.Controls.Add(this.checkBox_wordWrap);
            this.groupBox_options.Location = new System.Drawing.Point(12, 12);
            this.groupBox_options.Name = "groupBox_options";
            this.groupBox_options.Size = new System.Drawing.Size(282, 127);
            this.groupBox_options.TabIndex = 0;
            this.groupBox_options.TabStop = false;
            this.groupBox_options.Text = "Options";
            // 
            // label_charPos
            // 
            this.label_charPos.AutoSize = true;
            this.label_charPos.Location = new System.Drawing.Point(173, 73);
            this.label_charPos.Name = "label_charPos";
            this.label_charPos.Size = new System.Drawing.Size(56, 13);
            this.label_charPos.TabIndex = 0;
            this.label_charPos.Text = "Character:";
            // 
            // label_pos
            // 
            this.label_pos.AutoSize = true;
            this.label_pos.Location = new System.Drawing.Point(235, 73);
            this.label_pos.Name = "label_pos";
            this.label_pos.Size = new System.Drawing.Size(13, 13);
            this.label_pos.TabIndex = 0;
            this.label_pos.Text = "0";
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(206, 98);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(70, 23);
            this.button_close.TabIndex = 6;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_apply
            // 
            this.button_apply.Enabled = false;
            this.button_apply.Location = new System.Drawing.Point(130, 98);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(70, 23);
            this.button_apply.TabIndex = 5;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // groupBox_preview
            // 
            this.groupBox_preview.Controls.Add(this.button_editGfx);
            this.groupBox_preview.Controls.Add(this.button_update);
            this.groupBox_preview.Controls.Add(this.button_editPalette);
            this.groupBox_preview.Controls.Add(this.pictureBox_palette);
            this.groupBox_preview.Controls.Add(this.panel_gfx);
            this.groupBox_preview.Location = new System.Drawing.Point(300, 12);
            this.groupBox_preview.Name = "groupBox_preview";
            this.groupBox_preview.Size = new System.Drawing.Size(335, 127);
            this.groupBox_preview.TabIndex = 1;
            this.groupBox_preview.TabStop = false;
            this.groupBox_preview.Text = "Preview";
            // 
            // button_editGfx
            // 
            this.button_editGfx.Location = new System.Drawing.Point(269, 100);
            this.button_editGfx.Name = "button_editGfx";
            this.button_editGfx.Size = new System.Drawing.Size(60, 21);
            this.button_editGfx.TabIndex = 2;
            this.button_editGfx.Text = "Edit GFX";
            this.button_editGfx.UseVisualStyleBackColor = true;
            this.button_editGfx.Click += new System.EventHandler(this.button_editGfx_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(269, 41);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(60, 55);
            this.button_update.TabIndex = 1;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_editPalette
            // 
            this.button_editPalette.Location = new System.Drawing.Point(269, 16);
            this.button_editPalette.Name = "button_editPalette";
            this.button_editPalette.Size = new System.Drawing.Size(60, 21);
            this.button_editPalette.TabIndex = 0;
            this.button_editPalette.Text = "Edit";
            this.button_editPalette.UseVisualStyleBackColor = true;
            this.button_editPalette.Click += new System.EventHandler(this.button_editPalette_Click);
            // 
            // pictureBox_palette
            // 
            this.pictureBox_palette.Location = new System.Drawing.Point(6, 18);
            this.pictureBox_palette.Name = "pictureBox_palette";
            this.pictureBox_palette.Size = new System.Drawing.Size(257, 17);
            this.pictureBox_palette.TabIndex = 35;
            this.pictureBox_palette.TabStop = false;
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(12, 145);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(623, 188);
            this.textBox.TabIndex = 0;
            this.textBox.TabStop = false;
            this.textBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseClick);
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyUp);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_changes});
            this.statusStrip.Location = new System.Drawing.Point(0, 336);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(647, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusLabel_changes
            // 
            this.statusLabel_changes.Name = "statusLabel_changes";
            this.statusLabel_changes.Size = new System.Drawing.Size(12, 17);
            this.statusLabel_changes.Text = "-";
            // 
            // FormText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 358);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox_preview);
            this.Controls.Add(this.groupBox_options);
            this.Controls.Add(this.textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(663, 397);
            this.Name = "FormText";
            this.Text = "Text Editor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_text)).EndInit();
            this.panel_gfx.ResumeLayout(false);
            this.groupBox_options.ResumeLayout(false);
            this.groupBox_options.PerformLayout();
            this.groupBox_preview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_palette)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_language;
        private System.Windows.Forms.Label label_language;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.ComboBox comboBox_number;
        private System.Windows.Forms.PictureBox pictureBox_text;
        private System.Windows.Forms.CheckBox checkBox_newLine;
        private System.Windows.Forms.CheckBox checkBox_wordWrap;
        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.ComboBox comboBox_text;
        private System.Windows.Forms.TextBox textBox_offsetVal;
        private System.Windows.Forms.Label label_offset;
        private System.Windows.Forms.Panel panel_gfx;
        private System.Windows.Forms.GroupBox groupBox_options;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.GroupBox groupBox_preview;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label_pos;
        private System.Windows.Forms.Label label_charPos;
        private System.Windows.Forms.Button button_editPalette;
        private System.Windows.Forms.PictureBox pictureBox_palette;
        private System.Windows.Forms.Button button_editGfx;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_changes;
    }
}