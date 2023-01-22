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
            this.comboBox_demo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_demo.FormattingEnabled = true;
            this.comboBox_demo.Location = new System.Drawing.Point(12, 12);
            this.comboBox_demo.Name = "comboBox_demo";
            this.comboBox_demo.Size = new System.Drawing.Size(56, 21);
            this.comboBox_demo.TabIndex = 0;
            this.comboBox_demo.SelectedIndexChanged += new System.EventHandler(this.comboBox_demo_SelectedIndexChanged);
            // 
            // listView_input
            // 
            this.listView_input.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_frame,
            this.columnHeader_input});
            this.listView_input.ContextMenuStrip = this.contextMenuStrip;
            this.listView_input.FullRowSelect = true;
            this.listView_input.GridLines = true;
            this.listView_input.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_input.HideSelection = false;
            this.listView_input.Location = new System.Drawing.Point(12, 39);
            this.listView_input.Name = "listView_input";
            this.listView_input.Size = new System.Drawing.Size(175, 311);
            this.listView_input.TabIndex = 4;
            this.listView_input.UseCompatibleStateImageBehavior = false;
            this.listView_input.View = System.Windows.Forms.View.Details;
            this.listView_input.SelectedIndexChanged += new System.EventHandler(this.listView_input_SelectedIndexChanged);
            // 
            // columnHeader_frame
            // 
            this.columnHeader_frame.Text = "Frame";
            // 
            // columnHeader_input
            // 
            this.columnHeader_input.Text = "Input";
            this.columnHeader_input.Width = 91;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_insert,
            this.menuItem_delete,
            this.toolStripSeparator1,
            this.menuItem_cut,
            this.menuItem_copy,
            this.menuItem_pasteInsert,
            this.menuItem_pasteWrite});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(176, 142);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // menuItem_insert
            // 
            this.menuItem_insert.Name = "menuItem_insert";
            this.menuItem_insert.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.menuItem_insert.Size = new System.Drawing.Size(175, 22);
            this.menuItem_insert.Text = "Insert";
            this.menuItem_insert.Click += new System.EventHandler(this.menuItem_insert_Click);
            // 
            // menuItem_delete
            // 
            this.menuItem_delete.Name = "menuItem_delete";
            this.menuItem_delete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.menuItem_delete.Size = new System.Drawing.Size(175, 22);
            this.menuItem_delete.Text = "Delete";
            this.menuItem_delete.Click += new System.EventHandler(this.menuItem_delete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(172, 6);
            // 
            // menuItem_cut
            // 
            this.menuItem_cut.Name = "menuItem_cut";
            this.menuItem_cut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuItem_cut.Size = new System.Drawing.Size(175, 22);
            this.menuItem_cut.Text = "Cut";
            this.menuItem_cut.Click += new System.EventHandler(this.menuItem_cut_Click);
            // 
            // menuItem_copy
            // 
            this.menuItem_copy.Name = "menuItem_copy";
            this.menuItem_copy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuItem_copy.Size = new System.Drawing.Size(175, 22);
            this.menuItem_copy.Text = "Copy";
            this.menuItem_copy.Click += new System.EventHandler(this.menuItem_copy_Click);
            // 
            // menuItem_pasteInsert
            // 
            this.menuItem_pasteInsert.Name = "menuItem_pasteInsert";
            this.menuItem_pasteInsert.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.menuItem_pasteInsert.Size = new System.Drawing.Size(175, 22);
            this.menuItem_pasteInsert.Text = "Paste Insert";
            this.menuItem_pasteInsert.Click += new System.EventHandler(this.menuItem_pasteInsert_Click);
            // 
            // menuItem_pasteWrite
            // 
            this.menuItem_pasteWrite.Name = "menuItem_pasteWrite";
            this.menuItem_pasteWrite.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.menuItem_pasteWrite.Size = new System.Drawing.Size(175, 22);
            this.menuItem_pasteWrite.Text = "Paste Write";
            this.menuItem_pasteWrite.Click += new System.EventHandler(this.menuItem_pasteWrite_Click);
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(107, 13);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(80, 20);
            this.textBox_input.TabIndex = 1;
            this.textBox_input.TextChanged += new System.EventHandler(this.textBox_input_TextChanged);
            // 
            // button_testDemo
            // 
            this.button_testDemo.Location = new System.Drawing.Point(368, 10);
            this.button_testDemo.Name = "button_testDemo";
            this.button_testDemo.Size = new System.Drawing.Size(75, 23);
            this.button_testDemo.TabIndex = 3;
            this.button_testDemo.Text = "Test Demo";
            this.button_testDemo.UseVisualStyleBackColor = true;
            this.button_testDemo.Click += new System.EventHandler(this.button_testDemo_Click);
            // 
            // button_apply
            // 
            this.button_apply.Enabled = false;
            this.button_apply.Location = new System.Drawing.Point(213, 10);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(75, 23);
            this.button_apply.TabIndex = 2;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // treeView_ram
            // 
            this.treeView_ram.Location = new System.Drawing.Point(213, 39);
            this.treeView_ram.Name = "treeView_ram";
            this.treeView_ram.Size = new System.Drawing.Size(230, 285);
            this.treeView_ram.TabIndex = 5;
            this.treeView_ram.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_ram_AfterSelect);
            // 
            // textBox_ramVal
            // 
            this.textBox_ramVal.Location = new System.Drawing.Point(213, 330);
            this.textBox_ramVal.Name = "textBox_ramVal";
            this.textBox_ramVal.Size = new System.Drawing.Size(60, 20);
            this.textBox_ramVal.TabIndex = 6;
            this.textBox_ramVal.TextChanged += new System.EventHandler(this.textBox_ramVal_TextChanged);
            // 
            // button_set
            // 
            this.button_set.Enabled = false;
            this.button_set.Location = new System.Drawing.Point(279, 329);
            this.button_set.Name = "button_set";
            this.button_set.Size = new System.Drawing.Size(70, 22);
            this.button_set.TabIndex = 7;
            this.button_set.Text = "Set";
            this.button_set.UseVisualStyleBackColor = true;
            this.button_set.Click += new System.EventHandler(this.button_set_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_changes,
            this.statusStrip_spring,
            this.statusStrip_import,
            this.statusStrip_export});
            this.statusStrip.Location = new System.Drawing.Point(0, 353);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(455, 22);
            this.statusStrip.TabIndex = 0;
            // 
            // statusLabel_changes
            // 
            this.statusLabel_changes.Name = "statusLabel_changes";
            this.statusLabel_changes.Size = new System.Drawing.Size(12, 17);
            this.statusLabel_changes.Text = "-";
            // 
            // statusStrip_spring
            // 
            this.statusStrip_spring.Name = "statusStrip_spring";
            this.statusStrip_spring.Size = new System.Drawing.Size(319, 17);
            this.statusStrip_spring.Spring = true;
            // 
            // statusStrip_import
            // 
            this.statusStrip_import.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusStrip_import.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip_importDemo});
            this.statusStrip_import.Name = "statusStrip_import";
            this.statusStrip_import.Size = new System.Drawing.Size(56, 20);
            this.statusStrip_import.Text = "Import";
            // 
            // statusStrip_importDemo
            // 
            this.statusStrip_importDemo.Name = "statusStrip_importDemo";
            this.statusStrip_importDemo.Size = new System.Drawing.Size(115, 22);
            this.statusStrip_importDemo.Text = "Demo...";
            this.statusStrip_importDemo.Click += new System.EventHandler(this.statusStrip_importDemo_Click);
            // 
            // statusStrip_export
            // 
            this.statusStrip_export.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusStrip_export.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip_exportDemo});
            this.statusStrip_export.Name = "statusStrip_export";
            this.statusStrip_export.Size = new System.Drawing.Size(53, 20);
            this.statusStrip_export.Text = "Export";
            // 
            // statusStrip_exportDemo
            // 
            this.statusStrip_exportDemo.Name = "statusStrip_exportDemo";
            this.statusStrip_exportDemo.Size = new System.Drawing.Size(115, 22);
            this.statusStrip_exportDemo.Text = "Demo...";
            this.statusStrip_exportDemo.Click += new System.EventHandler(this.statusStrip_exportDemo_Click);
            // 
            // FormDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 375);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDemo";
            this.Text = "Demo Editor";
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