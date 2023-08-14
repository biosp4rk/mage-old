namespace mage.Theming
{
    partial class ThemeEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemeEditor));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.comboBox_theme = new mage.Theming.CustomControls.FlatComboBox();
            this.groupBox_colors = new System.Windows.Forms.GroupBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_accent = new System.Windows.Forms.Panel();
            this.panel_secondary = new System.Windows.Forms.Panel();
            this.panel_primary = new System.Windows.Forms.Panel();
            this.panel_background = new System.Windows.Forms.Panel();
            this.panel_text = new System.Windows.Forms.Panel();
            this.flatTextBox_accent = new mage.Theming.CustomControls.FlatTextBox();
            this.flatTextBox_secondary = new mage.Theming.CustomControls.FlatTextBox();
            this.flatTextBox_primary = new mage.Theming.CustomControls.FlatTextBox();
            this.flatTextBox_background = new mage.Theming.CustomControls.FlatTextBox();
            this.flatTextBox_text = new mage.Theming.CustomControls.FlatTextBox();
            this.label_accent = new System.Windows.Forms.Label();
            this.label_secondary_outline = new System.Windows.Forms.Label();
            this.label_primary_outline = new System.Windows.Forms.Label();
            this.label_background = new System.Windows.Forms.Label();
            this.label_text = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.button_apply = new System.Windows.Forms.Button();
            this.flatTextBox_name = new mage.Theming.CustomControls.FlatTextBox();
            this.groupBox_colors.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 252);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(299, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // comboBox_theme
            // 
            this.comboBox_theme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_theme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_theme.FormattingEnabled = true;
            this.comboBox_theme.Location = new System.Drawing.Point(12, 12);
            this.comboBox_theme.Name = "comboBox_theme";
            this.comboBox_theme.Size = new System.Drawing.Size(143, 21);
            this.comboBox_theme.TabIndex = 1;
            this.comboBox_theme.SelectedIndexChanged += new System.EventHandler(this.comboBox_theme_SelectedIndexChanged);
            // 
            // groupBox_colors
            // 
            this.groupBox_colors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_colors.Controls.Add(this.panel_main);
            this.groupBox_colors.Location = new System.Drawing.Point(12, 65);
            this.groupBox_colors.Name = "groupBox_colors";
            this.groupBox_colors.Size = new System.Drawing.Size(275, 150);
            this.groupBox_colors.TabIndex = 2;
            this.groupBox_colors.TabStop = false;
            this.groupBox_colors.Text = "Colors";
            // 
            // panel_main
            // 
            this.panel_main.AutoScroll = true;
            this.panel_main.Controls.Add(this.panel_accent);
            this.panel_main.Controls.Add(this.panel_secondary);
            this.panel_main.Controls.Add(this.panel_primary);
            this.panel_main.Controls.Add(this.panel_background);
            this.panel_main.Controls.Add(this.panel_text);
            this.panel_main.Controls.Add(this.flatTextBox_accent);
            this.panel_main.Controls.Add(this.flatTextBox_secondary);
            this.panel_main.Controls.Add(this.flatTextBox_primary);
            this.panel_main.Controls.Add(this.flatTextBox_background);
            this.panel_main.Controls.Add(this.flatTextBox_text);
            this.panel_main.Controls.Add(this.label_accent);
            this.panel_main.Controls.Add(this.label_secondary_outline);
            this.panel_main.Controls.Add(this.label_primary_outline);
            this.panel_main.Controls.Add(this.label_background);
            this.panel_main.Controls.Add(this.label_text);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(3, 16);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(269, 131);
            this.panel_main.TabIndex = 0;
            // 
            // panel_accent
            // 
            this.panel_accent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_accent.Location = new System.Drawing.Point(246, 107);
            this.panel_accent.Name = "panel_accent";
            this.panel_accent.Size = new System.Drawing.Size(20, 20);
            this.panel_accent.TabIndex = 14;
            this.panel_accent.Tag = "AccentColor";
            // 
            // panel_secondary
            // 
            this.panel_secondary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_secondary.Location = new System.Drawing.Point(246, 81);
            this.panel_secondary.Name = "panel_secondary";
            this.panel_secondary.Size = new System.Drawing.Size(20, 20);
            this.panel_secondary.TabIndex = 13;
            this.panel_secondary.Tag = "SecondaryOutline";
            // 
            // panel_primary
            // 
            this.panel_primary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_primary.Location = new System.Drawing.Point(246, 55);
            this.panel_primary.Name = "panel_primary";
            this.panel_primary.Size = new System.Drawing.Size(20, 20);
            this.panel_primary.TabIndex = 12;
            this.panel_primary.Tag = "PrimaryOutline";
            // 
            // panel_background
            // 
            this.panel_background.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_background.Location = new System.Drawing.Point(246, 29);
            this.panel_background.Name = "panel_background";
            this.panel_background.Size = new System.Drawing.Size(20, 20);
            this.panel_background.TabIndex = 11;
            this.panel_background.Tag = "BackgroundColor";
            // 
            // panel_text
            // 
            this.panel_text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_text.Location = new System.Drawing.Point(246, 3);
            this.panel_text.Name = "panel_text";
            this.panel_text.Size = new System.Drawing.Size(20, 20);
            this.panel_text.TabIndex = 10;
            this.panel_text.Tag = "TextColor";
            // 
            // flatTextBox_accent
            // 
            this.flatTextBox_accent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatTextBox_accent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.flatTextBox_accent.Location = new System.Drawing.Point(106, 107);
            this.flatTextBox_accent.Name = "flatTextBox_accent";
            this.flatTextBox_accent.Size = new System.Drawing.Size(134, 20);
            this.flatTextBox_accent.TabIndex = 9;
            this.flatTextBox_accent.Tag = "panel_accent";
            this.flatTextBox_accent.TextChanged += new System.EventHandler(this.ColorValueChanged);
            // 
            // flatTextBox_secondary
            // 
            this.flatTextBox_secondary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatTextBox_secondary.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.flatTextBox_secondary.Location = new System.Drawing.Point(106, 81);
            this.flatTextBox_secondary.Name = "flatTextBox_secondary";
            this.flatTextBox_secondary.Size = new System.Drawing.Size(134, 20);
            this.flatTextBox_secondary.TabIndex = 8;
            this.flatTextBox_secondary.Tag = "panel_secondary";
            this.flatTextBox_secondary.TextChanged += new System.EventHandler(this.ColorValueChanged);
            // 
            // flatTextBox_primary
            // 
            this.flatTextBox_primary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatTextBox_primary.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.flatTextBox_primary.Location = new System.Drawing.Point(106, 55);
            this.flatTextBox_primary.Name = "flatTextBox_primary";
            this.flatTextBox_primary.Size = new System.Drawing.Size(134, 20);
            this.flatTextBox_primary.TabIndex = 7;
            this.flatTextBox_primary.Tag = "panel_primary";
            this.flatTextBox_primary.TextChanged += new System.EventHandler(this.ColorValueChanged);
            // 
            // flatTextBox_background
            // 
            this.flatTextBox_background.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatTextBox_background.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.flatTextBox_background.Location = new System.Drawing.Point(106, 29);
            this.flatTextBox_background.Name = "flatTextBox_background";
            this.flatTextBox_background.Size = new System.Drawing.Size(134, 20);
            this.flatTextBox_background.TabIndex = 6;
            this.flatTextBox_background.Tag = "panel_background";
            this.flatTextBox_background.TextChanged += new System.EventHandler(this.ColorValueChanged);
            // 
            // flatTextBox_text
            // 
            this.flatTextBox_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatTextBox_text.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.flatTextBox_text.Location = new System.Drawing.Point(106, 3);
            this.flatTextBox_text.Name = "flatTextBox_text";
            this.flatTextBox_text.Size = new System.Drawing.Size(134, 20);
            this.flatTextBox_text.TabIndex = 5;
            this.flatTextBox_text.Tag = "panel_text";
            this.flatTextBox_text.TextChanged += new System.EventHandler(this.ColorValueChanged);
            // 
            // label_accent
            // 
            this.label_accent.AutoSize = true;
            this.label_accent.Location = new System.Drawing.Point(3, 110);
            this.label_accent.Name = "label_accent";
            this.label_accent.Size = new System.Drawing.Size(44, 13);
            this.label_accent.TabIndex = 4;
            this.label_accent.Text = "Accent:";
            // 
            // label_secondary_outline
            // 
            this.label_secondary_outline.AutoSize = true;
            this.label_secondary_outline.Location = new System.Drawing.Point(3, 84);
            this.label_secondary_outline.Name = "label_secondary_outline";
            this.label_secondary_outline.Size = new System.Drawing.Size(97, 13);
            this.label_secondary_outline.TabIndex = 3;
            this.label_secondary_outline.Text = "Secondary Outline:";
            // 
            // label_primary_outline
            // 
            this.label_primary_outline.AutoSize = true;
            this.label_primary_outline.Location = new System.Drawing.Point(3, 58);
            this.label_primary_outline.Name = "label_primary_outline";
            this.label_primary_outline.Size = new System.Drawing.Size(80, 13);
            this.label_primary_outline.TabIndex = 2;
            this.label_primary_outline.Text = "Primary Outline:";
            // 
            // label_background
            // 
            this.label_background.AutoSize = true;
            this.label_background.Location = new System.Drawing.Point(3, 32);
            this.label_background.Name = "label_background";
            this.label_background.Size = new System.Drawing.Size(68, 13);
            this.label_background.TabIndex = 1;
            this.label_background.Text = "Background:";
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Location = new System.Drawing.Point(3, 6);
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(31, 13);
            this.label_text.TabIndex = 0;
            this.label_text.Text = "Text:";
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Location = new System.Drawing.Point(161, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(60, 21);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_remove
            // 
            this.btn_remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_remove.Location = new System.Drawing.Point(227, 12);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(60, 21);
            this.btn_remove.TabIndex = 4;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = true;
            // 
            // button_apply
            // 
            this.button_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_apply.Location = new System.Drawing.Point(212, 221);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(75, 23);
            this.button_apply.TabIndex = 5;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // flatTextBox_name
            // 
            this.flatTextBox_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatTextBox_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.flatTextBox_name.Location = new System.Drawing.Point(12, 39);
            this.flatTextBox_name.Name = "flatTextBox_name";
            this.flatTextBox_name.Size = new System.Drawing.Size(272, 20);
            this.flatTextBox_name.TabIndex = 6;
            // 
            // ThemeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 274);
            this.Controls.Add(this.flatTextBox_name);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.groupBox_colors);
            this.Controls.Add(this.comboBox_theme);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThemeEditor";
            this.Text = "Themes";
            this.groupBox_colors.ResumeLayout(false);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private CustomControls.FlatComboBox comboBox_theme;
        private System.Windows.Forms.GroupBox groupBox_colors;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.Label label_secondary_outline;
        private System.Windows.Forms.Label label_primary_outline;
        private System.Windows.Forms.Label label_background;
        private System.Windows.Forms.Label label_accent;
        private CustomControls.FlatTextBox flatTextBox_accent;
        private CustomControls.FlatTextBox flatTextBox_secondary;
        private CustomControls.FlatTextBox flatTextBox_primary;
        private CustomControls.FlatTextBox flatTextBox_background;
        private CustomControls.FlatTextBox flatTextBox_text;
        private System.Windows.Forms.Panel panel_text;
        private System.Windows.Forms.Panel panel_accent;
        private System.Windows.Forms.Panel panel_secondary;
        private System.Windows.Forms.Panel panel_primary;
        private System.Windows.Forms.Panel panel_background;
        private CustomControls.FlatTextBox flatTextBox_name;
    }
}