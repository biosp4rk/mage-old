namespace mage
{
    partial class FormRoomOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoomOptions));
            textBox_width = new Theming.CustomControls.FlatTextBox();
            textBox_height = new Theming.CustomControls.FlatTextBox();
            label_width = new System.Windows.Forms.Label();
            label_height = new System.Windows.Forms.Label();
            button_resize = new System.Windows.Forms.Button();
            button_clearBG = new System.Windows.Forms.Button();
            checkBox_bg0 = new System.Windows.Forms.CheckBox();
            checkBox_bg1 = new System.Windows.Forms.CheckBox();
            checkBox_bg2 = new System.Windows.Forms.CheckBox();
            checkBox_clip = new System.Windows.Forms.CheckBox();
            groupBox_resize = new System.Windows.Forms.GroupBox();
            textbox_screenY = new Theming.CustomControls.FlatTextBox();
            textbox_screenX = new Theming.CustomControls.FlatTextBox();
            label_blocks = new System.Windows.Forms.Label();
            label_screens = new System.Windows.Forms.Label();
            groupBox_clear = new System.Windows.Forms.GroupBox();
            button_close = new System.Windows.Forms.Button();
            groupBox_resize.SuspendLayout();
            groupBox_clear.SuspendLayout();
            SuspendLayout();
            // 
            // textBox_width
            // 
            textBox_width.BorderColor = System.Drawing.Color.Black;
            textBox_width.Location = new System.Drawing.Point(62, 37);
            textBox_width.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_width.Multiline = false;
            textBox_width.Name = "textBox_width";
            textBox_width.Padding = new System.Windows.Forms.Padding(4, 3, 1, 2);
            textBox_width.ReadOnly = false;
            textBox_width.ScrollBars = System.Windows.Forms.ScrollBars.None;
            textBox_width.SelectionStart = 0;
            textBox_width.Size = new System.Drawing.Size(34, 23);
            textBox_width.TabIndex = 0;
            textBox_width.WordWrap = true;
            textBox_width.TextChanged += textBox_width_TextChanged;
            // 
            // textBox_height
            // 
            textBox_height.BorderColor = System.Drawing.Color.Black;
            textBox_height.Location = new System.Drawing.Point(62, 67);
            textBox_height.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_height.Multiline = false;
            textBox_height.Name = "textBox_height";
            textBox_height.Padding = new System.Windows.Forms.Padding(4, 3, 1, 2);
            textBox_height.ReadOnly = false;
            textBox_height.ScrollBars = System.Windows.Forms.ScrollBars.None;
            textBox_height.SelectionStart = 0;
            textBox_height.Size = new System.Drawing.Size(34, 23);
            textBox_height.TabIndex = 1;
            textBox_height.WordWrap = true;
            textBox_height.TextChanged += textBox_height_TextChanged;
            // 
            // label_width
            // 
            label_width.AutoSize = true;
            label_width.Location = new System.Drawing.Point(7, 40);
            label_width.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_width.Name = "label_width";
            label_width.Size = new System.Drawing.Size(42, 15);
            label_width.TabIndex = 0;
            label_width.Text = "Width:";
            // 
            // label_height
            // 
            label_height.AutoSize = true;
            label_height.Location = new System.Drawing.Point(7, 70);
            label_height.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_height.Name = "label_height";
            label_height.Size = new System.Drawing.Size(46, 15);
            label_height.TabIndex = 0;
            label_height.Text = "Height:";
            // 
            // button_resize
            // 
            button_resize.Location = new System.Drawing.Point(8, 97);
            button_resize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_resize.Name = "button_resize";
            button_resize.Size = new System.Drawing.Size(88, 27);
            button_resize.TabIndex = 2;
            button_resize.Text = "Resize";
            button_resize.UseVisualStyleBackColor = true;
            button_resize.Click += button_resize_Click;
            // 
            // button_clearBG
            // 
            button_clearBG.Location = new System.Drawing.Point(7, 128);
            button_clearBG.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_clearBG.Name = "button_clearBG";
            button_clearBG.Size = new System.Drawing.Size(88, 27);
            button_clearBG.TabIndex = 4;
            button_clearBG.Text = "Clear";
            button_clearBG.UseVisualStyleBackColor = true;
            button_clearBG.Click += button_clearBG_Click;
            // 
            // checkBox_bg0
            // 
            checkBox_bg0.AutoSize = true;
            checkBox_bg0.Location = new System.Drawing.Point(12, 22);
            checkBox_bg0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBox_bg0.Name = "checkBox_bg0";
            checkBox_bg0.Size = new System.Drawing.Size(50, 19);
            checkBox_bg0.TabIndex = 0;
            checkBox_bg0.Text = "BG 0";
            checkBox_bg0.UseVisualStyleBackColor = true;
            // 
            // checkBox_bg1
            // 
            checkBox_bg1.AutoSize = true;
            checkBox_bg1.Location = new System.Drawing.Point(12, 48);
            checkBox_bg1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBox_bg1.Name = "checkBox_bg1";
            checkBox_bg1.Size = new System.Drawing.Size(50, 19);
            checkBox_bg1.TabIndex = 1;
            checkBox_bg1.Text = "BG 1";
            checkBox_bg1.UseVisualStyleBackColor = true;
            // 
            // checkBox_bg2
            // 
            checkBox_bg2.AutoSize = true;
            checkBox_bg2.Location = new System.Drawing.Point(12, 75);
            checkBox_bg2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBox_bg2.Name = "checkBox_bg2";
            checkBox_bg2.Size = new System.Drawing.Size(50, 19);
            checkBox_bg2.TabIndex = 2;
            checkBox_bg2.Text = "BG 2";
            checkBox_bg2.UseVisualStyleBackColor = true;
            // 
            // checkBox_clip
            // 
            checkBox_clip.AutoSize = true;
            checkBox_clip.Location = new System.Drawing.Point(12, 102);
            checkBox_clip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBox_clip.Name = "checkBox_clip";
            checkBox_clip.Size = new System.Drawing.Size(70, 19);
            checkBox_clip.TabIndex = 3;
            checkBox_clip.Text = "Clipdata";
            checkBox_clip.UseVisualStyleBackColor = true;
            // 
            // groupBox_resize
            // 
            groupBox_resize.Controls.Add(textbox_screenY);
            groupBox_resize.Controls.Add(textbox_screenX);
            groupBox_resize.Controls.Add(label_blocks);
            groupBox_resize.Controls.Add(label_screens);
            groupBox_resize.Controls.Add(label_width);
            groupBox_resize.Controls.Add(textBox_width);
            groupBox_resize.Controls.Add(textBox_height);
            groupBox_resize.Controls.Add(label_height);
            groupBox_resize.Controls.Add(button_resize);
            groupBox_resize.Location = new System.Drawing.Point(122, 14);
            groupBox_resize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_resize.Name = "groupBox_resize";
            groupBox_resize.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_resize.Size = new System.Drawing.Size(172, 130);
            groupBox_resize.TabIndex = 1;
            groupBox_resize.TabStop = false;
            groupBox_resize.Text = "Resize Room";
            // 
            // textbox_screenY
            // 
            textbox_screenY.BorderColor = System.Drawing.Color.Black;
            textbox_screenY.Location = new System.Drawing.Point(116, 67);
            textbox_screenY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textbox_screenY.Multiline = false;
            textbox_screenY.Name = "textbox_screenY";
            textbox_screenY.Padding = new System.Windows.Forms.Padding(4, 3, 1, 2);
            textbox_screenY.ReadOnly = false;
            textbox_screenY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            textbox_screenY.SelectionStart = 0;
            textbox_screenY.Size = new System.Drawing.Size(34, 23);
            textbox_screenY.TabIndex = 4;
            textbox_screenY.WordWrap = true;
            // 
            // textbox_screenX
            // 
            textbox_screenX.BorderColor = System.Drawing.Color.Black;
            textbox_screenX.Location = new System.Drawing.Point(116, 37);
            textbox_screenX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textbox_screenX.Multiline = false;
            textbox_screenX.Name = "textbox_screenX";
            textbox_screenX.Padding = new System.Windows.Forms.Padding(4, 3, 1, 2);
            textbox_screenX.ReadOnly = false;
            textbox_screenX.ScrollBars = System.Windows.Forms.ScrollBars.None;
            textbox_screenX.SelectionStart = 0;
            textbox_screenX.Size = new System.Drawing.Size(34, 23);
            textbox_screenX.TabIndex = 3;
            textbox_screenX.WordWrap = true;
            // 
            // label_blocks
            // 
            label_blocks.AutoSize = true;
            label_blocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            label_blocks.Location = new System.Drawing.Point(58, 18);
            label_blocks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_blocks.Name = "label_blocks";
            label_blocks.Size = new System.Drawing.Size(39, 13);
            label_blocks.TabIndex = 0;
            label_blocks.Text = "Blocks";
            // 
            // label_screens
            // 
            label_screens.AutoSize = true;
            label_screens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            label_screens.Location = new System.Drawing.Point(111, 18);
            label_screens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_screens.Name = "label_screens";
            label_screens.Size = new System.Drawing.Size(46, 13);
            label_screens.TabIndex = 0;
            label_screens.Text = "Screens";
            // 
            // groupBox_clear
            // 
            groupBox_clear.Controls.Add(checkBox_bg0);
            groupBox_clear.Controls.Add(checkBox_bg1);
            groupBox_clear.Controls.Add(button_clearBG);
            groupBox_clear.Controls.Add(checkBox_bg2);
            groupBox_clear.Controls.Add(checkBox_clip);
            groupBox_clear.Location = new System.Drawing.Point(14, 14);
            groupBox_clear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_clear.Name = "groupBox_clear";
            groupBox_clear.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_clear.Size = new System.Drawing.Size(102, 162);
            groupBox_clear.TabIndex = 0;
            groupBox_clear.TabStop = false;
            groupBox_clear.Text = "Clear BG";
            // 
            // button_close
            // 
            button_close.Location = new System.Drawing.Point(206, 151);
            button_close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_close.Name = "button_close";
            button_close.Size = new System.Drawing.Size(88, 27);
            button_close.TabIndex = 2;
            button_close.Text = "Close";
            button_close.UseVisualStyleBackColor = true;
            button_close.Click += button_close_Click;
            // 
            // FormRoomOptions
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(308, 192);
            Controls.Add(button_close);
            Controls.Add(groupBox_clear);
            Controls.Add(groupBox_resize);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRoomOptions";
            Text = "Room Options";
            groupBox_resize.ResumeLayout(false);
            groupBox_resize.PerformLayout();
            groupBox_clear.ResumeLayout(false);
            groupBox_clear.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private mage.Theming.CustomControls.FlatTextBox textBox_width;
        private mage.Theming.CustomControls.FlatTextBox textBox_height;
        private System.Windows.Forms.Label label_width;
        private System.Windows.Forms.Label label_height;
        private System.Windows.Forms.Button button_resize;
        private System.Windows.Forms.Button button_clearBG;
        private System.Windows.Forms.CheckBox checkBox_bg0;
        private System.Windows.Forms.CheckBox checkBox_bg1;
        private System.Windows.Forms.CheckBox checkBox_bg2;
        private System.Windows.Forms.CheckBox checkBox_clip;
        private System.Windows.Forms.GroupBox groupBox_resize;
        private System.Windows.Forms.GroupBox groupBox_clear;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_blocks;
        private System.Windows.Forms.Label label_screens;
        private Theming.CustomControls.FlatTextBox textbox_screenY;
        private Theming.CustomControls.FlatTextBox textbox_screenX;
    }
}