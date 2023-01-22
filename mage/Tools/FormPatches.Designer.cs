namespace mage
{
    partial class FormPatches
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPatches));
            this.button_apply = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.listView_patches = new System.Windows.Forms.ListView();
            this.columnHeader_patches = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_applied = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button_apply
            // 
            this.button_apply.Enabled = false;
            this.button_apply.Location = new System.Drawing.Point(12, 182);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(75, 23);
            this.button_apply.TabIndex = 1;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(276, 182);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 2;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // listView_patches
            // 
            this.listView_patches.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_patches,
            this.columnHeader_author,
            this.columnHeader_applied});
            this.listView_patches.FullRowSelect = true;
            this.listView_patches.GridLines = true;
            this.listView_patches.Location = new System.Drawing.Point(12, 12);
            this.listView_patches.MultiSelect = false;
            this.listView_patches.Name = "listView_patches";
            this.listView_patches.Size = new System.Drawing.Size(339, 164);
            this.listView_patches.TabIndex = 0;
            this.listView_patches.UseCompatibleStateImageBehavior = false;
            this.listView_patches.View = System.Windows.Forms.View.Details;
            this.listView_patches.SelectedIndexChanged += new System.EventHandler(this.listView_patches_SelectedIndexChanged);
            // 
            // columnHeader_patches
            // 
            this.columnHeader_patches.Text = "Patches";
            this.columnHeader_patches.Width = 203;
            // 
            // columnHeader_author
            // 
            this.columnHeader_author.Text = "Author";
            this.columnHeader_author.Width = 80;
            // 
            // columnHeader_applied
            // 
            this.columnHeader_applied.Text = "Applied";
            this.columnHeader_applied.Width = 52;
            // 
            // FormPatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 217);
            this.Controls.Add(this.listView_patches);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_apply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPatches";
            this.Text = "Patches";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.ListView listView_patches;
        private System.Windows.Forms.ColumnHeader columnHeader_patches;
        private System.Windows.Forms.ColumnHeader columnHeader_applied;
        private System.Windows.Forms.ColumnHeader columnHeader_author;
    }
}