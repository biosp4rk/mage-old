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
            this.textBox_value = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView_physics
            // 
            resources.ApplyResources(this.listView_physics, "listView_physics");
            this.listView_physics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_desc,
            this.columnHeader_offset,
            this.columnHeader_bytes,
            this.columnHeader_value});
            this.listView_physics.FullRowSelect = true;
            this.listView_physics.GridLines = true;
            this.listView_physics.HideSelection = false;
            this.listView_physics.MultiSelect = false;
            this.listView_physics.Name = "listView_physics";
            this.listView_physics.UseCompatibleStateImageBehavior = false;
            this.listView_physics.View = System.Windows.Forms.View.Details;
            this.listView_physics.SelectedIndexChanged += new System.EventHandler(this.listView_physics_SelectedIndexChanged);
            // 
            // columnHeader_desc
            // 
            resources.ApplyResources(this.columnHeader_desc, "columnHeader_desc");
            // 
            // columnHeader_offset
            // 
            resources.ApplyResources(this.columnHeader_offset, "columnHeader_offset");
            // 
            // columnHeader_bytes
            // 
            resources.ApplyResources(this.columnHeader_bytes, "columnHeader_bytes");
            // 
            // columnHeader_value
            // 
            resources.ApplyResources(this.columnHeader_value, "columnHeader_value");
            // 
            // button_close
            // 
            resources.ApplyResources(this.button_close, "button_close");
            this.button_close.Name = "button_close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_apply
            // 
            resources.ApplyResources(this.button_apply, "button_apply");
            this.button_apply.Name = "button_apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // label_value
            // 
            resources.ApplyResources(this.label_value, "label_value");
            this.label_value.Name = "label_value";
            // 
            // textBox_value
            // 
            resources.ApplyResources(this.textBox_value, "textBox_value");
            this.textBox_value.Name = "textBox_value";
            // 
            // FormPhysics
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_value);
            this.Controls.Add(this.textBox_value);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.listView_physics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPhysics";
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
        private System.Windows.Forms.TextBox textBox_value;

    }
}