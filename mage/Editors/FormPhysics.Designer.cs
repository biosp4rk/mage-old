namespace mage
{
    partial class FormPhysics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhysics));
            this.listView_physics = new System.Windows.Forms.ListView();
            this.columnHeader_desc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_offset = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_bytes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_close = new System.Windows.Forms.Button();
            this.button_apply = new System.Windows.Forms.Button();
            this.label_value = new System.Windows.Forms.Label();
            this.textBox_value = new mage.Theming.CustomControls.FlatTextBox();
            this.SuspendLayout();
            // 
            // listView_physics
            // 
            this.listView_physics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_desc,
            this.columnHeader_offset,
            this.columnHeader_bytes,
            this.columnHeader_value});
            this.listView_physics.FullRowSelect = true;
            this.listView_physics.GridLines = true;
            this.listView_physics.Location = new System.Drawing.Point(12, 12);
            this.listView_physics.MultiSelect = false;
            this.listView_physics.Name = "listView_physics";
            this.listView_physics.Size = new System.Drawing.Size(311, 232);
            this.listView_physics.TabIndex = 0;
            this.listView_physics.UseCompatibleStateImageBehavior = false;
            this.listView_physics.View = System.Windows.Forms.View.Details;
            this.listView_physics.SelectedIndexChanged += new System.EventHandler(this.listView_physics_SelectedIndexChanged);
            // 
            // columnHeader_desc
            // 
            this.columnHeader_desc.Text = "Description";
            this.columnHeader_desc.Width = 150;
            // 
            // columnHeader_offset
            // 
            this.columnHeader_offset.Text = "Offset";
            this.columnHeader_offset.Width = 50;
            // 
            // columnHeader_bytes
            // 
            this.columnHeader_bytes.Text = "Bytes";
            this.columnHeader_bytes.Width = 40;
            // 
            // columnHeader_value
            // 
            this.columnHeader_value.Text = "Value";
            this.columnHeader_value.Width = 50;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(248, 250);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 1;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_apply
            // 
            this.button_apply.Enabled = false;
            this.button_apply.Location = new System.Drawing.Point(167, 250);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(75, 23);
            this.button_apply.TabIndex = 2;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // label_value
            // 
            this.label_value.AutoSize = true;
            this.label_value.Location = new System.Drawing.Point(12, 255);
            this.label_value.Name = "label_value";
            this.label_value.Size = new System.Drawing.Size(37, 13);
            this.label_value.TabIndex = 3;
            this.label_value.Text = "Value:";
            // 
            // textBox_value
            // 
            this.textBox_value.Enabled = false;
            this.textBox_value.Location = new System.Drawing.Point(55, 252);
            this.textBox_value.Name = "textBox_value";
            this.textBox_value.Size = new System.Drawing.Size(45, 20);
            this.textBox_value.TabIndex = 4;
            // 
            // FormPhysics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 285);
            this.Controls.Add(this.label_value);
            this.Controls.Add(this.textBox_value);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.listView_physics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPhysics";
            this.Text = "Physics Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_physics;
        private System.Windows.Forms.ColumnHeader columnHeader_desc;
        private System.Windows.Forms.ColumnHeader columnHeader_bytes;
        private System.Windows.Forms.ColumnHeader columnHeader_value;
        private System.Windows.Forms.ColumnHeader columnHeader_offset;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Label label_value;
        private mage.Theming.CustomControls.FlatTextBox textBox_value;

    }
}