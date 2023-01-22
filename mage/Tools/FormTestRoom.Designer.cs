namespace mage
{
    partial class FormTestRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTestRoom));
            this.button_go = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.checkBox_debug = new System.Windows.Forms.CheckBox();
            this.label_xPos = new System.Windows.Forms.Label();
            this.label_yPos = new System.Windows.Forms.Label();
            this.textBox_xPos = new System.Windows.Forms.TextBox();
            this.textBox_yPos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_go
            // 
            this.button_go.Location = new System.Drawing.Point(136, 20);
            this.button_go.Name = "button_go";
            this.button_go.Size = new System.Drawing.Size(75, 23);
            this.button_go.TabIndex = 3;
            this.button_go.Text = "Go";
            this.button_go.UseVisualStyleBackColor = true;
            this.button_go.Click += new System.EventHandler(this.button_go_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(136, 49);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // checkBox_debug
            // 
            this.checkBox_debug.AutoSize = true;
            this.checkBox_debug.Checked = true;
            this.checkBox_debug.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_debug.Location = new System.Drawing.Point(15, 64);
            this.checkBox_debug.Name = "checkBox_debug";
            this.checkBox_debug.Size = new System.Drawing.Size(87, 17);
            this.checkBox_debug.TabIndex = 2;
            this.checkBox_debug.Text = "Debug menu";
            this.checkBox_debug.UseVisualStyleBackColor = true;
            // 
            // label_xPos
            // 
            this.label_xPos.AutoSize = true;
            this.label_xPos.Location = new System.Drawing.Point(12, 16);
            this.label_xPos.Name = "label_xPos";
            this.label_xPos.Size = new System.Drawing.Size(56, 13);
            this.label_xPos.TabIndex = 0;
            this.label_xPos.Text = "X position:";
            // 
            // label_yPos
            // 
            this.label_yPos.AutoSize = true;
            this.label_yPos.Location = new System.Drawing.Point(12, 41);
            this.label_yPos.Name = "label_yPos";
            this.label_yPos.Size = new System.Drawing.Size(56, 13);
            this.label_yPos.TabIndex = 0;
            this.label_yPos.Text = "Y position:";
            // 
            // textBox_xPos
            // 
            this.textBox_xPos.Location = new System.Drawing.Point(74, 12);
            this.textBox_xPos.Name = "textBox_xPos";
            this.textBox_xPos.Size = new System.Drawing.Size(40, 20);
            this.textBox_xPos.TabIndex = 0;
            this.textBox_xPos.Text = "8";
            // 
            // textBox_yPos
            // 
            this.textBox_yPos.Location = new System.Drawing.Point(74, 38);
            this.textBox_yPos.Name = "textBox_yPos";
            this.textBox_yPos.Size = new System.Drawing.Size(40, 20);
            this.textBox_yPos.TabIndex = 1;
            this.textBox_yPos.Text = "8";
            // 
            // FormTestRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 93);
            this.Controls.Add(this.textBox_yPos);
            this.Controls.Add(this.textBox_xPos);
            this.Controls.Add(this.label_yPos);
            this.Controls.Add(this.label_xPos);
            this.Controls.Add(this.checkBox_debug);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_go);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTestRoom";
            this.Text = "Test Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_go;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.CheckBox checkBox_debug;
        private System.Windows.Forms.Label label_xPos;
        private System.Windows.Forms.Label label_yPos;
        private System.Windows.Forms.TextBox textBox_xPos;
        private System.Windows.Forms.TextBox textBox_yPos;
    }
}