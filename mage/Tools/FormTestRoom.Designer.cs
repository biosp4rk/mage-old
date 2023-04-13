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
            resources.ApplyResources(this.button_go, "button_go");
            this.button_go.Name = "button_go";
            this.button_go.UseVisualStyleBackColor = true;
            this.button_go.Click += new System.EventHandler(this.button_go_Click);
            // 
            // button_cancel
            // 
            resources.ApplyResources(this.button_cancel, "button_cancel");
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // checkBox_debug
            // 
            resources.ApplyResources(this.checkBox_debug, "checkBox_debug");
            this.checkBox_debug.Checked = true;
            this.checkBox_debug.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_debug.Name = "checkBox_debug";
            this.checkBox_debug.UseVisualStyleBackColor = true;
            // 
            // label_xPos
            // 
            resources.ApplyResources(this.label_xPos, "label_xPos");
            this.label_xPos.Name = "label_xPos";
            // 
            // label_yPos
            // 
            resources.ApplyResources(this.label_yPos, "label_yPos");
            this.label_yPos.Name = "label_yPos";
            // 
            // textBox_xPos
            // 
            resources.ApplyResources(this.textBox_xPos, "textBox_xPos");
            this.textBox_xPos.Name = "textBox_xPos";
            // 
            // textBox_yPos
            // 
            resources.ApplyResources(this.textBox_yPos, "textBox_yPos");
            this.textBox_yPos.Name = "textBox_yPos";
            // 
            // FormTestRoom
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_yPos);
            this.Controls.Add(this.textBox_xPos);
            this.Controls.Add(this.label_yPos);
            this.Controls.Add(this.label_xPos);
            this.Controls.Add(this.checkBox_debug);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_go);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTestRoom";
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