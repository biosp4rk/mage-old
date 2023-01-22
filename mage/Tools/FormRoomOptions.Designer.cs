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
            this.textBox_width = new System.Windows.Forms.TextBox();
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.label_width = new System.Windows.Forms.Label();
            this.label_height = new System.Windows.Forms.Label();
            this.button_resize = new System.Windows.Forms.Button();
            this.button_clearBG = new System.Windows.Forms.Button();
            this.checkBox_bg0 = new System.Windows.Forms.CheckBox();
            this.checkBox_bg1 = new System.Windows.Forms.CheckBox();
            this.checkBox_bg2 = new System.Windows.Forms.CheckBox();
            this.checkBox_clip = new System.Windows.Forms.CheckBox();
            this.groupBox_resize = new System.Windows.Forms.GroupBox();
            this.label_blocks = new System.Windows.Forms.Label();
            this.label_screenY = new System.Windows.Forms.Label();
            this.label_screenX = new System.Windows.Forms.Label();
            this.label_screens = new System.Windows.Forms.Label();
            this.groupBox_clear = new System.Windows.Forms.GroupBox();
            this.button_close = new System.Windows.Forms.Button();
            this.groupBox_resize.SuspendLayout();
            this.groupBox_clear.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_width
            // 
            this.textBox_width.Location = new System.Drawing.Point(53, 32);
            this.textBox_width.Name = "textBox_width";
            this.textBox_width.Size = new System.Drawing.Size(29, 20);
            this.textBox_width.TabIndex = 0;
            this.textBox_width.TextChanged += new System.EventHandler(this.textBox_width_TextChanged);
            // 
            // textBox_height
            // 
            this.textBox_height.Location = new System.Drawing.Point(53, 58);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(29, 20);
            this.textBox_height.TabIndex = 1;
            this.textBox_height.TextChanged += new System.EventHandler(this.textBox_height_TextChanged);
            // 
            // label_width
            // 
            this.label_width.AutoSize = true;
            this.label_width.Location = new System.Drawing.Point(6, 35);
            this.label_width.Name = "label_width";
            this.label_width.Size = new System.Drawing.Size(38, 13);
            this.label_width.TabIndex = 0;
            this.label_width.Text = "Width:";
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.Location = new System.Drawing.Point(6, 61);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(41, 13);
            this.label_height.TabIndex = 0;
            this.label_height.Text = "Height:";
            // 
            // button_resize
            // 
            this.button_resize.Location = new System.Drawing.Point(7, 84);
            this.button_resize.Name = "button_resize";
            this.button_resize.Size = new System.Drawing.Size(75, 23);
            this.button_resize.TabIndex = 2;
            this.button_resize.Text = "Resize";
            this.button_resize.UseVisualStyleBackColor = true;
            this.button_resize.Click += new System.EventHandler(this.button_resize_Click);
            // 
            // button_clearBG
            // 
            this.button_clearBG.Location = new System.Drawing.Point(6, 111);
            this.button_clearBG.Name = "button_clearBG";
            this.button_clearBG.Size = new System.Drawing.Size(75, 23);
            this.button_clearBG.TabIndex = 4;
            this.button_clearBG.Text = "Clear";
            this.button_clearBG.UseVisualStyleBackColor = true;
            this.button_clearBG.Click += new System.EventHandler(this.button_clearBG_Click);
            // 
            // checkBox_bg0
            // 
            this.checkBox_bg0.AutoSize = true;
            this.checkBox_bg0.Location = new System.Drawing.Point(10, 19);
            this.checkBox_bg0.Name = "checkBox_bg0";
            this.checkBox_bg0.Size = new System.Drawing.Size(50, 17);
            this.checkBox_bg0.TabIndex = 0;
            this.checkBox_bg0.Text = "BG 0";
            this.checkBox_bg0.UseVisualStyleBackColor = true;
            // 
            // checkBox_bg1
            // 
            this.checkBox_bg1.AutoSize = true;
            this.checkBox_bg1.Location = new System.Drawing.Point(10, 42);
            this.checkBox_bg1.Name = "checkBox_bg1";
            this.checkBox_bg1.Size = new System.Drawing.Size(50, 17);
            this.checkBox_bg1.TabIndex = 1;
            this.checkBox_bg1.Text = "BG 1";
            this.checkBox_bg1.UseVisualStyleBackColor = true;
            // 
            // checkBox_bg2
            // 
            this.checkBox_bg2.AutoSize = true;
            this.checkBox_bg2.Location = new System.Drawing.Point(10, 65);
            this.checkBox_bg2.Name = "checkBox_bg2";
            this.checkBox_bg2.Size = new System.Drawing.Size(50, 17);
            this.checkBox_bg2.TabIndex = 2;
            this.checkBox_bg2.Text = "BG 2";
            this.checkBox_bg2.UseVisualStyleBackColor = true;
            // 
            // checkBox_clip
            // 
            this.checkBox_clip.AutoSize = true;
            this.checkBox_clip.Location = new System.Drawing.Point(10, 88);
            this.checkBox_clip.Name = "checkBox_clip";
            this.checkBox_clip.Size = new System.Drawing.Size(64, 17);
            this.checkBox_clip.TabIndex = 3;
            this.checkBox_clip.Text = "Clipdata";
            this.checkBox_clip.UseVisualStyleBackColor = true;
            // 
            // groupBox_resize
            // 
            this.groupBox_resize.Controls.Add(this.label_blocks);
            this.groupBox_resize.Controls.Add(this.label_screenY);
            this.groupBox_resize.Controls.Add(this.label_screenX);
            this.groupBox_resize.Controls.Add(this.label_screens);
            this.groupBox_resize.Controls.Add(this.label_width);
            this.groupBox_resize.Controls.Add(this.textBox_width);
            this.groupBox_resize.Controls.Add(this.textBox_height);
            this.groupBox_resize.Controls.Add(this.label_height);
            this.groupBox_resize.Controls.Add(this.button_resize);
            this.groupBox_resize.Location = new System.Drawing.Point(105, 12);
            this.groupBox_resize.Name = "groupBox_resize";
            this.groupBox_resize.Size = new System.Drawing.Size(147, 113);
            this.groupBox_resize.TabIndex = 1;
            this.groupBox_resize.TabStop = false;
            this.groupBox_resize.Text = "Resize Room";
            // 
            // label_blocks
            // 
            this.label_blocks.AutoSize = true;
            this.label_blocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_blocks.Location = new System.Drawing.Point(50, 16);
            this.label_blocks.Name = "label_blocks";
            this.label_blocks.Size = new System.Drawing.Size(39, 13);
            this.label_blocks.TabIndex = 0;
            this.label_blocks.Text = "Blocks";
            // 
            // label_screenY
            // 
            this.label_screenY.AutoSize = true;
            this.label_screenY.Location = new System.Drawing.Point(95, 61);
            this.label_screenY.Name = "label_screenY";
            this.label_screenY.Size = new System.Drawing.Size(13, 13);
            this.label_screenY.TabIndex = 0;
            this.label_screenY.Text = "0";
            // 
            // label_screenX
            // 
            this.label_screenX.AutoSize = true;
            this.label_screenX.Location = new System.Drawing.Point(95, 35);
            this.label_screenX.Name = "label_screenX";
            this.label_screenX.Size = new System.Drawing.Size(13, 13);
            this.label_screenX.TabIndex = 0;
            this.label_screenX.Text = "0";
            // 
            // label_screens
            // 
            this.label_screens.AutoSize = true;
            this.label_screens.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_screens.Location = new System.Drawing.Point(95, 16);
            this.label_screens.Name = "label_screens";
            this.label_screens.Size = new System.Drawing.Size(46, 13);
            this.label_screens.TabIndex = 0;
            this.label_screens.Text = "Screens";
            // 
            // groupBox_clear
            // 
            this.groupBox_clear.Controls.Add(this.checkBox_bg0);
            this.groupBox_clear.Controls.Add(this.checkBox_bg1);
            this.groupBox_clear.Controls.Add(this.button_clearBG);
            this.groupBox_clear.Controls.Add(this.checkBox_bg2);
            this.groupBox_clear.Controls.Add(this.checkBox_clip);
            this.groupBox_clear.Location = new System.Drawing.Point(12, 12);
            this.groupBox_clear.Name = "groupBox_clear";
            this.groupBox_clear.Size = new System.Drawing.Size(87, 140);
            this.groupBox_clear.TabIndex = 0;
            this.groupBox_clear.TabStop = false;
            this.groupBox_clear.Text = "Clear BG";
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(177, 131);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 2;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // FormRoomOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 166);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.groupBox_clear);
            this.Controls.Add(this.groupBox_resize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRoomOptions";
            this.Text = "Room Options";
            this.groupBox_resize.ResumeLayout(false);
            this.groupBox_resize.PerformLayout();
            this.groupBox_clear.ResumeLayout(false);
            this.groupBox_clear.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_width;
        private System.Windows.Forms.TextBox textBox_height;
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
        private System.Windows.Forms.Label label_screenY;
        private System.Windows.Forms.Label label_screenX;
        private System.Windows.Forms.Label label_screens;
    }
}