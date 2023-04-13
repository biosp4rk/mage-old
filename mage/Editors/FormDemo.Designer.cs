namespace mage
{
    partial class FormDemo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDemo));
            this.comboBox_demo = new System.Windows.Forms.ComboBox();
            this.listView_input = new System.Windows.Forms.ListView();
            this.columnHeader_frame = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_input = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItem_insert = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItem_cut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_pasteInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_pasteWrite = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.button_testDemo = new System.Windows.Forms.Button();
            this.button_apply = new System.Windows.Forms.Button();
            this.treeView_ram = new System.Windows.Forms.TreeView();
            this.textBox_ramVal = new System.Windows.Forms.TextBox();
            this.button_set = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel_changes = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip_spring = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip_import = new System.Windows.Forms.ToolStripDropDownButton();
            this.statusStrip_importDemo = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_export = new System.Windows.Forms.ToolStripDropDownButton();
            this.statusStrip_exportDemo = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_demo
            // 
            resources.ApplyResources(this.comboBox_demo, "comboBox_demo");
            this.comboBox_demo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_demo.FormattingEnabled = true;
            this.comboBox_demo.Name = "comboBox_demo";
            this.comboBox_demo.SelectedIndexChanged += new System.EventHandler(this.comboBox_demo_SelectedIndexChanged);
            // 
            // listView_input
            // 
            resources.ApplyResources(this.listView_input, "listView_input");
            this.listView_input.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_frame,
            this.columnHeader_input});
            this.listView_input.ContextMenuStrip = this.contextMenuStrip;
            this.listView_input.FullRowSelect = true;
            this.listView_input.GridLines = true;
            this.listView_input.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_input.HideSelection = false;
            this.listView_input.Name = "listView_input";
            this.listView_input.UseCompatibleStateImageBehavior = false;
            this.listView_input.View = System.Windows.Forms.View.Details;
            this.listView_input.SelectedIndexChanged += new System.EventHandler(this.listView_input_SelectedIndexChanged);
            // 
            // columnHeader_frame
            // 
            resources.ApplyResources(this.columnHeader_frame, "columnHeader_frame");
            // 
            // columnHeader_input
            // 
            resources.ApplyResources(this.columnHeader_input, "columnHeader_input");
            // 
            // contextMenuStrip
            // 
            resources.ApplyResources(this.contextMenuStrip, "contextMenuStrip");
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_insert,
            this.menuItem_delete,
            this.toolStripSeparator1,
            this.menuItem_cut,
            this.menuItem_copy,
            this.menuItem_pasteInsert,
            this.menuItem_pasteWrite});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // menuItem_insert
            // 
            resources.ApplyResources(this.menuItem_insert, "menuItem_insert");
            this.menuItem_insert.Name = "menuItem_insert";
            this.menuItem_insert.Click += new System.EventHandler(this.menuItem_insert_Click);
            // 
            // menuItem_delete
            // 
            resources.ApplyResources(this.menuItem_delete, "menuItem_delete");
            this.menuItem_delete.Name = "menuItem_delete";
            this.menuItem_delete.Click += new System.EventHandler(this.menuItem_delete_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // menuItem_cut
            // 
            resources.ApplyResources(this.menuItem_cut, "menuItem_cut");
            this.menuItem_cut.Name = "menuItem_cut";
            this.menuItem_cut.Click += new System.EventHandler(this.menuItem_cut_Click);
            // 
            // menuItem_copy
            // 
            resources.ApplyResources(this.menuItem_copy, "menuItem_copy");
            this.menuItem_copy.Name = "menuItem_copy";
            this.menuItem_copy.Click += new System.EventHandler(this.menuItem_copy_Click);
            // 
            // menuItem_pasteInsert
            // 
            resources.ApplyResources(this.menuItem_pasteInsert, "menuItem_pasteInsert");
            this.menuItem_pasteInsert.Name = "menuItem_pasteInsert";
            this.menuItem_pasteInsert.Click += new System.EventHandler(this.menuItem_pasteInsert_Click);
            // 
            // menuItem_pasteWrite
            // 
            resources.ApplyResources(this.menuItem_pasteWrite, "menuItem_pasteWrite");
            this.menuItem_pasteWrite.Name = "menuItem_pasteWrite";
            this.menuItem_pasteWrite.Click += new System.EventHandler(this.menuItem_pasteWrite_Click);
            // 
            // textBox_input
            // 
            resources.ApplyResources(this.textBox_input, "textBox_input");
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.TextChanged += new System.EventHandler(this.textBox_input_TextChanged);
            // 
            // button_testDemo
            // 
            resources.ApplyResources(this.button_testDemo, "button_testDemo");
            this.button_testDemo.Name = "button_testDemo";
            this.button_testDemo.UseVisualStyleBackColor = true;
            this.button_testDemo.Click += new System.EventHandler(this.button_testDemo_Click);
            // 
            // button_apply
            // 
            resources.ApplyResources(this.button_apply, "button_apply");
            this.button_apply.Name = "button_apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // treeView_ram
            // 
            resources.ApplyResources(this.treeView_ram, "treeView_ram");
            this.treeView_ram.Name = "treeView_ram";
            this.treeView_ram.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_ram_AfterSelect);
            // 
            // textBox_ramVal
            // 
            resources.ApplyResources(this.textBox_ramVal, "textBox_ramVal");
            this.textBox_ramVal.Name = "textBox_ramVal";
            this.textBox_ramVal.TextChanged += new System.EventHandler(this.textBox_ramVal_TextChanged);
            // 
            // button_set
            // 
            resources.ApplyResources(this.button_set, "button_set");
            this.button_set.Name = "button_set";
            this.button_set.UseVisualStyleBackColor = true;
            this.button_set.Click += new System.EventHandler(this.button_set_Click);
            // 
            // statusStrip
            // 
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_changes,
            this.statusStrip_spring,
            this.statusStrip_import,
            this.statusStrip_export});
            this.statusStrip.Name = "statusStrip";
            // 
            // statusLabel_changes
            // 
            resources.ApplyResources(this.statusLabel_changes, "statusLabel_changes");
            this.statusLabel_changes.Name = "statusLabel_changes";
            // 
            // statusStrip_spring
            // 
            resources.ApplyResources(this.statusStrip_spring, "statusStrip_spring");
            this.statusStrip_spring.Name = "statusStrip_spring";
            this.statusStrip_spring.Spring = true;
            // 
            // statusStrip_import
            // 
            resources.ApplyResources(this.statusStrip_import, "statusStrip_import");
            this.statusStrip_import.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusStrip_import.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip_importDemo});
            this.statusStrip_import.Name = "statusStrip_import";
            // 
            // statusStrip_importDemo
            // 
            resources.ApplyResources(this.statusStrip_importDemo, "statusStrip_importDemo");
            this.statusStrip_importDemo.Name = "statusStrip_importDemo";
            this.statusStrip_importDemo.Click += new System.EventHandler(this.statusStrip_importDemo_Click);
            // 
            // statusStrip_export
            // 
            resources.ApplyResources(this.statusStrip_export, "statusStrip_export");
            this.statusStrip_export.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusStrip_export.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip_exportDemo});
            this.statusStrip_export.Name = "statusStrip_export";
            // 
            // statusStrip_exportDemo
            // 
            resources.ApplyResources(this.statusStrip_exportDemo, "statusStrip_exportDemo");
            this.statusStrip_exportDemo.Name = "statusStrip_exportDemo";
            this.statusStrip_exportDemo.Click += new System.EventHandler(this.statusStrip_exportDemo_Click);
            // 
            // FormDemo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.button_set);
            this.Controls.Add(this.textBox_ramVal);
            this.Controls.Add(this.treeView_ram);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.button_testDemo);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.listView_input);
            this.Controls.Add(this.comboBox_demo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormDemo";
            this.contextMenuStrip.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_demo;
        private System.Windows.Forms.ListView listView_input;
        private System.Windows.Forms.ColumnHeader columnHeader_frame;
        private System.Windows.Forms.ColumnHeader columnHeader_input;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItem_insert;
        private System.Windows.Forms.ToolStripMenuItem menuItem_delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItem_cut;
        private System.Windows.Forms.ToolStripMenuItem menuItem_copy;
        private System.Windows.Forms.ToolStripMenuItem menuItem_pasteInsert;
        private System.Windows.Forms.ToolStripMenuItem menuItem_pasteWrite;
        private System.Windows.Forms.Button button_testDemo;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.TreeView treeView_ram;
        private System.Windows.Forms.TextBox textBox_ramVal;
        private System.Windows.Forms.Button button_set;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_changes;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip_spring;
        private System.Windows.Forms.ToolStripDropDownButton statusStrip_import;
        private System.Windows.Forms.ToolStripMenuItem statusStrip_importDemo;
        private System.Windows.Forms.ToolStripDropDownButton statusStrip_export;
        private System.Windows.Forms.ToolStripMenuItem statusStrip_exportDemo;
    }
}