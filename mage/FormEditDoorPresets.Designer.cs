namespace mage
{
    partial class FormEditDoorPresets
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
            button_x_n1 = new System.Windows.Forms.Button();
            button_x_n2 = new System.Windows.Forms.Button();
            button_x1 = new System.Windows.Forms.Button();
            button_x2 = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            button_y2 = new System.Windows.Forms.Button();
            button_y1 = new System.Windows.Forms.Button();
            button_y_n2 = new System.Windows.Forms.Button();
            button_y_n1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_x_n1
            // 
            button_x_n1.Location = new System.Drawing.Point(65, 118);
            button_x_n1.Name = "button_x_n1";
            button_x_n1.Size = new System.Drawing.Size(47, 47);
            button_x_n1.TabIndex = 0;
            button_x_n1.Text = "-1 Tile";
            button_x_n1.UseVisualStyleBackColor = true;
            button_x_n1.Click += button_x_n1_Click;
            // 
            // button_x_n2
            // 
            button_x_n2.Location = new System.Drawing.Point(12, 118);
            button_x_n2.Name = "button_x_n2";
            button_x_n2.Size = new System.Drawing.Size(47, 47);
            button_x_n2.TabIndex = 1;
            button_x_n2.Text = "-2 Tile";
            button_x_n2.UseVisualStyleBackColor = true;
            button_x_n2.Click += button_x_n2_Click;
            // 
            // button_x1
            // 
            button_x1.Location = new System.Drawing.Point(171, 118);
            button_x1.Name = "button_x1";
            button_x1.Size = new System.Drawing.Size(47, 47);
            button_x1.TabIndex = 2;
            button_x1.Text = "1 Tile";
            button_x1.UseVisualStyleBackColor = true;
            button_x1.Click += button_x1_Click;
            // 
            // button_x2
            // 
            button_x2.Location = new System.Drawing.Point(224, 118);
            button_x2.Name = "button_x2";
            button_x2.Size = new System.Drawing.Size(47, 47);
            button_x2.TabIndex = 3;
            button_x2.Text = "2 Tile";
            button_x2.UseVisualStyleBackColor = true;
            button_x2.Click += button_x2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.toolbar_outline_doors;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            pictureBox1.Location = new System.Drawing.Point(118, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(47, 47);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button_y2
            // 
            button_y2.Location = new System.Drawing.Point(118, 171);
            button_y2.Name = "button_y2";
            button_y2.Size = new System.Drawing.Size(47, 47);
            button_y2.TabIndex = 8;
            button_y2.Text = "2 Tile";
            button_y2.UseVisualStyleBackColor = true;
            button_y2.Click += button_x2_Click;
            // 
            // button_y1
            // 
            button_y1.Location = new System.Drawing.Point(118, 224);
            button_y1.Name = "button_y1";
            button_y1.Size = new System.Drawing.Size(47, 47);
            button_y1.TabIndex = 7;
            button_y1.Text = "1 Tile";
            button_y1.UseVisualStyleBackColor = true;
            button_y1.Click += button_x1_Click;
            // 
            // button_y_n2
            // 
            button_y_n2.Location = new System.Drawing.Point(118, 65);
            button_y_n2.Name = "button_y_n2";
            button_y_n2.Size = new System.Drawing.Size(47, 47);
            button_y_n2.TabIndex = 6;
            button_y_n2.Text = "-2 Tile";
            button_y_n2.UseVisualStyleBackColor = true;
            button_y_n2.Click += button_x_n2_Click;
            // 
            // button_y_n1
            // 
            button_y_n1.Location = new System.Drawing.Point(118, 12);
            button_y_n1.Name = "button_y_n1";
            button_y_n1.Size = new System.Drawing.Size(47, 47);
            button_y_n1.TabIndex = 5;
            button_y_n1.Text = "-1 Tile";
            button_y_n1.UseVisualStyleBackColor = true;
            button_y_n1.Click += button_x_n1_Click;
            // 
            // FormEditDoorPresets
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(284, 284);
            Controls.Add(button_y2);
            Controls.Add(button_y1);
            Controls.Add(button_y_n2);
            Controls.Add(button_y_n1);
            Controls.Add(pictureBox1);
            Controls.Add(button_x2);
            Controls.Add(button_x1);
            Controls.Add(button_x_n2);
            Controls.Add(button_x_n1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEditDoorPresets";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Distance Presets";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button_x_n1;
        private System.Windows.Forms.Button button_x_n2;
        private System.Windows.Forms.Button button_x1;
        private System.Windows.Forms.Button button_x2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_y2;
        private System.Windows.Forms.Button button_y1;
        private System.Windows.Forms.Button button_y_n2;
        private System.Windows.Forms.Button button_y_n1;
    }
}