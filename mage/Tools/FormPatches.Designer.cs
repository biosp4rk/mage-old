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
            resources.ApplyResources(this.button_apply, "button_apply");
            this.button_apply.Name = "button_apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // button_close
            // 
            resources.ApplyResources(this.button_close, "button_close");
            this.button_close.Name = "button_close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // listView_patches
            // 
            resources.ApplyResources(this.listView_patches, "listView_patches");
            this.listView_patches.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_patches,
            this.columnHeader_author,
            this.columnHeader_applied});
            this.listView_patches.FullRowSelect = true;
            this.listView_patches.GridLines = true;
            this.listView_patches.HideSelection = false;
            this.listView_patches.MultiSelect = false;
            this.listView_patches.Name = "listView_patches";
            this.listView_patches.UseCompatibleStateImageBehavior = false;
            this.listView_patches.View = System.Windows.Forms.View.Details;
            this.listView_patches.SelectedIndexChanged += new System.EventHandler(this.listView_patches_SelectedIndexChanged);
            // 
            // columnHeader_patches
            // 
            resources.ApplyResources(this.columnHeader_patches, "columnHeader_patches");
            // 
            // columnHeader_author
            // 
            resources.ApplyResources(this.columnHeader_author, "columnHeader_author");
            // 
            // columnHeader_applied
            // 
            resources.ApplyResources(this.columnHeader_applied, "columnHeader_applied");
            // 
            // FormPatches
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView_patches);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_apply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPatches";
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