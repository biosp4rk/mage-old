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
            comboBox_language = new Theming.CustomControls.FlatComboBox();
            label_language = new System.Windows.Forms.Label();
            label_number = new System.Windows.Forms.Label();
            comboBox_number = new Theming.CustomControls.FlatComboBox();
            pictureBox_text = new System.Windows.Forms.PictureBox();
            checkBox_newLine = new System.Windows.Forms.CheckBox();
            checkBox_wordWrap = new System.Windows.Forms.CheckBox();
            label_text = new System.Windows.Forms.Label();
            comboBox_text = new Theming.CustomControls.FlatComboBox();
            textBox_offsetVal = new Theming.CustomControls.FlatTextBox();
            label_offset = new System.Windows.Forms.Label();
            panel_gfx = new System.Windows.Forms.Panel();
            groupBox_options = new System.Windows.Forms.GroupBox();
            label_charPos = new System.Windows.Forms.Label();
            label_pos = new System.Windows.Forms.Label();
            button_close = new System.Windows.Forms.Button();
            button_apply = new System.Windows.Forms.Button();
            groupBox_preview = new System.Windows.Forms.GroupBox();
            button_editGfx = new System.Windows.Forms.Button();
            button_update = new System.Windows.Forms.Button();
            button_editPalette = new System.Windows.Forms.Button();
            pictureBox_palette = new System.Windows.Forms.PictureBox();
            textBox = new Theming.CustomControls.FlatTextBox();
            statusStrip = new System.Windows.Forms.StatusStrip();
            statusLabel_changes = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox_text).BeginInit();
            panel_gfx.SuspendLayout();
            groupBox_options.SuspendLayout();
            groupBox_preview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_palette).BeginInit();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox_language
            // 
            comboBox_language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_language.FormattingEnabled = true;
            comboBox_language.Location = new System.Drawing.Point(82, 53);
            comboBox_language.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox_language.Name = "comboBox_language";
            comboBox_language.Size = new System.Drawing.Size(104, 23);
            comboBox_language.TabIndex = 1;
            comboBox_language.SelectedIndexChanged += comboBox_language_SelectedIndexChanged;
            // 
            // label_language
            // 
            label_language.AutoSize = true;
            label_language.Location = new System.Drawing.Point(7, 57);
            label_language.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_language.Name = "label_language";
            label_language.Size = new System.Drawing.Size(62, 15);
            label_language.TabIndex = 0;
            label_language.Text = "Language:";
            // 
            // label_number
            // 
            label_number.AutoSize = true;
            label_number.Location = new System.Drawing.Point(7, 88);
            label_number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_number.Name = "label_number";
            label_number.Size = new System.Drawing.Size(54, 15);
            label_number.TabIndex = 0;
            label_number.Text = "Number:";
            // 
            // comboBox_number
            // 
            comboBox_number.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_number.FormattingEnabled = true;
            comboBox_number.Location = new System.Drawing.Point(82, 84);
            comboBox_number.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox_number.Name = "comboBox_number";
            comboBox_number.Size = new System.Drawing.Size(56, 23);
            comboBox_number.TabIndex = 2;
            comboBox_number.SelectedIndexChanged += comboBox_number_SelectedIndexChanged;
            // 
            // pictureBox_text
            // 
            pictureBox_text.Location = new System.Drawing.Point(0, 0);
            pictureBox_text.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox_text.Name = "pictureBox_text";
            pictureBox_text.Size = new System.Drawing.Size(280, 92);
            pictureBox_text.TabIndex = 5;
            pictureBox_text.TabStop = false;
            // 
            // checkBox_newLine
            // 
            checkBox_newLine.AutoSize = true;
            checkBox_newLine.Location = new System.Drawing.Point(205, 53);
            checkBox_newLine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBox_newLine.Name = "checkBox_newLine";
            checkBox_newLine.Size = new System.Drawing.Size(102, 19);
            checkBox_newLine.TabIndex = 4;
            checkBox_newLine.Text = "Mark newlines";
            checkBox_newLine.UseVisualStyleBackColor = true;
            checkBox_newLine.CheckedChanged += checkBox_newLine_CheckedChanged;
            // 
            // checkBox_wordWrap
            // 
            checkBox_wordWrap.AutoSize = true;
            checkBox_wordWrap.Checked = true;
            checkBox_wordWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            checkBox_wordWrap.Location = new System.Drawing.Point(205, 22);
            checkBox_wordWrap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBox_wordWrap.Name = "checkBox_wordWrap";
            checkBox_wordWrap.Size = new System.Drawing.Size(84, 19);
            checkBox_wordWrap.TabIndex = 3;
            checkBox_wordWrap.Text = "Word wrap";
            checkBox_wordWrap.UseVisualStyleBackColor = true;
            checkBox_wordWrap.CheckedChanged += checkBox_wordWrap_CheckedChanged;
            // 
            // label_text
            // 
            label_text.AutoSize = true;
            label_text.Location = new System.Drawing.Point(7, 25);
            label_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_text.Name = "label_text";
            label_text.Size = new System.Drawing.Size(31, 15);
            label_text.TabIndex = 0;
            label_text.Text = "Text:";
            // 
            // comboBox_text
            // 
            comboBox_text.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_text.FormattingEnabled = true;
            comboBox_text.Location = new System.Drawing.Point(82, 22);
            comboBox_text.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox_text.Name = "comboBox_text";
            comboBox_text.Size = new System.Drawing.Size(104, 23);
            comboBox_text.TabIndex = 0;
            comboBox_text.SelectedIndexChanged += comboBox_text_SelectedIndexChanged;
            // 
            // textBox_offsetVal
            // 
            textBox_offsetVal.BorderColor = System.Drawing.Color.Black;
            textBox_offsetVal.Location = new System.Drawing.Point(58, 119);
            textBox_offsetVal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_offsetVal.Multiline = false;
            textBox_offsetVal.Name = "textBox_offsetVal";
            textBox_offsetVal.Padding = new System.Windows.Forms.Padding(4, 3, 1, 2);
            textBox_offsetVal.ReadOnly = true;
            textBox_offsetVal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            textBox_offsetVal.SelectionStart = 0;
            textBox_offsetVal.Size = new System.Drawing.Size(64, 23);
            textBox_offsetVal.TabIndex = 0;
            textBox_offsetVal.TabStop = false;
            textBox_offsetVal.WordWrap = true;
            // 
            // label_offset
            // 
            label_offset.AutoSize = true;
            label_offset.Location = new System.Drawing.Point(7, 119);
            label_offset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_offset.Name = "label_offset";
            label_offset.Size = new System.Drawing.Size(42, 15);
            label_offset.TabIndex = 0;
            label_offset.Text = "Offset:";
            // 
            // panel_gfx
            // 
            panel_gfx.AutoScroll = true;
            panel_gfx.Controls.Add(pictureBox_text);
            panel_gfx.Location = new System.Drawing.Point(7, 47);
            panel_gfx.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel_gfx.Name = "panel_gfx";
            panel_gfx.Size = new System.Drawing.Size(300, 92);
            panel_gfx.TabIndex = 32;
            // 
            // groupBox_options
            // 
            groupBox_options.Controls.Add(label_charPos);
            groupBox_options.Controls.Add(label_pos);
            groupBox_options.Controls.Add(button_close);
            groupBox_options.Controls.Add(button_apply);
            groupBox_options.Controls.Add(comboBox_text);
            groupBox_options.Controls.Add(comboBox_language);
            groupBox_options.Controls.Add(textBox_offsetVal);
            groupBox_options.Controls.Add(label_language);
            groupBox_options.Controls.Add(label_offset);
            groupBox_options.Controls.Add(comboBox_number);
            groupBox_options.Controls.Add(label_text);
            groupBox_options.Controls.Add(label_number);
            groupBox_options.Controls.Add(checkBox_newLine);
            groupBox_options.Controls.Add(checkBox_wordWrap);
            groupBox_options.Location = new System.Drawing.Point(14, 14);
            groupBox_options.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_options.Name = "groupBox_options";
            groupBox_options.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_options.Size = new System.Drawing.Size(329, 147);
            groupBox_options.TabIndex = 0;
            groupBox_options.TabStop = false;
            groupBox_options.Text = "Options";
            // 
            // label_charPos
            // 
            label_charPos.AutoSize = true;
            label_charPos.Location = new System.Drawing.Point(202, 84);
            label_charPos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_charPos.Name = "label_charPos";
            label_charPos.Size = new System.Drawing.Size(61, 15);
            label_charPos.TabIndex = 0;
            label_charPos.Text = "Character:";
            // 
            // label_pos
            // 
            label_pos.AutoSize = true;
            label_pos.Location = new System.Drawing.Point(274, 84);
            label_pos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_pos.Name = "label_pos";
            label_pos.Size = new System.Drawing.Size(13, 15);
            label_pos.TabIndex = 0;
            label_pos.Text = "0";
            // 
            // button_close
            // 
            button_close.Location = new System.Drawing.Point(240, 113);
            button_close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_close.Name = "button_close";
            button_close.Size = new System.Drawing.Size(82, 27);
            button_close.TabIndex = 6;
            button_close.Text = "Close";
            button_close.UseVisualStyleBackColor = true;
            button_close.Click += button_close_Click;
            // 
            // button_apply
            // 
            button_apply.Enabled = false;
            button_apply.Location = new System.Drawing.Point(152, 113);
            button_apply.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_apply.Name = "button_apply";
            button_apply.Size = new System.Drawing.Size(82, 27);
            button_apply.TabIndex = 5;
            button_apply.Text = "Apply";
            button_apply.UseVisualStyleBackColor = true;
            button_apply.Click += button_apply_Click;
            // 
            // groupBox_preview
            // 
            groupBox_preview.Controls.Add(button_editGfx);
            groupBox_preview.Controls.Add(button_update);
            groupBox_preview.Controls.Add(button_editPalette);
            groupBox_preview.Controls.Add(pictureBox_palette);
            groupBox_preview.Controls.Add(panel_gfx);
            groupBox_preview.Location = new System.Drawing.Point(350, 14);
            groupBox_preview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_preview.Name = "groupBox_preview";
            groupBox_preview.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_preview.Size = new System.Drawing.Size(391, 147);
            groupBox_preview.TabIndex = 1;
            groupBox_preview.TabStop = false;
            groupBox_preview.Text = "Preview";
            // 
            // button_editGfx
            // 
            button_editGfx.Location = new System.Drawing.Point(314, 115);
            button_editGfx.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_editGfx.Name = "button_editGfx";
            button_editGfx.Size = new System.Drawing.Size(70, 24);
            button_editGfx.TabIndex = 2;
            button_editGfx.Text = "Edit GFX";
            button_editGfx.UseVisualStyleBackColor = true;
            button_editGfx.Click += button_editGfx_Click;
            // 
            // button_update
            // 
            button_update.Location = new System.Drawing.Point(314, 47);
            button_update.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_update.Name = "button_update";
            button_update.Size = new System.Drawing.Size(70, 63);
            button_update.TabIndex = 1;
            button_update.Text = "Update";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // button_editPalette
            // 
            button_editPalette.Location = new System.Drawing.Point(314, 18);
            button_editPalette.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_editPalette.Name = "button_editPalette";
            button_editPalette.Size = new System.Drawing.Size(70, 24);
            button_editPalette.TabIndex = 0;
            button_editPalette.Text = "Edit";
            button_editPalette.UseVisualStyleBackColor = true;
            button_editPalette.Click += button_editPalette_Click;
            // 
            // pictureBox_palette
            // 
            pictureBox_palette.Location = new System.Drawing.Point(7, 21);
            pictureBox_palette.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox_palette.Name = "pictureBox_palette";
            pictureBox_palette.Size = new System.Drawing.Size(300, 20);
            pictureBox_palette.TabIndex = 35;
            pictureBox_palette.TabStop = false;
            // 
            // textBox
            // 
            textBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox.BorderColor = System.Drawing.Color.Black;
            textBox.Font = new System.Drawing.Font("Courier New", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox.Location = new System.Drawing.Point(14, 167);
            textBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 2);
            textBox.ReadOnly = false;
            textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textBox.SelectionStart = 0;
            textBox.Size = new System.Drawing.Size(727, 221);
            textBox.TabIndex = 0;
            textBox.TabStop = false;
            textBox.WordWrap = true;
            textBox.TextChanged += textBox_TextChanged;
            textBox.KeyUp += textBox_KeyUp;
            textBox.MouseClick += textBox_MouseClick;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { statusLabel_changes });
            statusStrip.Location = new System.Drawing.Point(0, 391);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStrip.Size = new System.Drawing.Size(755, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip";
            // 
            // statusLabel_changes
            // 
            statusLabel_changes.Name = "statusLabel_changes";
            statusLabel_changes.Size = new System.Drawing.Size(12, 17);
            statusLabel_changes.Text = "-";
            // 
            // FormText
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(755, 413);
            Controls.Add(statusStrip);
            Controls.Add(groupBox_preview);
            Controls.Add(groupBox_options);
            Controls.Add(textBox);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(771, 452);
            Name = "FormText";
            Text = "Text Editor";
            ((System.ComponentModel.ISupportInitialize)pictureBox_text).EndInit();
            panel_gfx.ResumeLayout(false);
            groupBox_options.ResumeLayout(false);
            groupBox_options.PerformLayout();
            groupBox_preview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_palette).EndInit();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private mage.Theming.CustomControls.FlatComboBox comboBox_language;
        private System.Windows.Forms.Label label_language;
        private System.Windows.Forms.Label label_number;
        private mage.Theming.CustomControls.FlatComboBox comboBox_number;
        private System.Windows.Forms.PictureBox pictureBox_text;
        private System.Windows.Forms.CheckBox checkBox_newLine;
        private System.Windows.Forms.CheckBox checkBox_wordWrap;
        private System.Windows.Forms.Label label_text;
        private mage.Theming.CustomControls.FlatComboBox comboBox_text;
        private mage.Theming.CustomControls.FlatTextBox textBox_offsetVal;
        private System.Windows.Forms.Label label_offset;
        private System.Windows.Forms.Panel panel_gfx;
        private System.Windows.Forms.GroupBox groupBox_options;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.GroupBox groupBox_preview;
        private System.Windows.Forms.Button button_update;
        private mage.Theming.CustomControls.FlatTextBox textBox;
        private System.Windows.Forms.Label label_pos;
        private System.Windows.Forms.Label label_charPos;
        private System.Windows.Forms.Button button_editPalette;
        private System.Windows.Forms.PictureBox pictureBox_palette;
        private System.Windows.Forms.Button button_editGfx;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_changes;
    }
}