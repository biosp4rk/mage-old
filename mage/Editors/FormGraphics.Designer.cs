namespace mage
{
    partial class FormGraphics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGraphics));
            this.groupBox_imageControl = new System.Windows.Forms.GroupBox();
            this.checkBox_compressed = new System.Windows.Forms.CheckBox();
            this.button_imageGo = new System.Windows.Forms.Button();
            this.label_height = new System.Windows.Forms.Label();
            this.label_width = new System.Windows.Forms.Label();
            this.numericUpDown_height = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_width = new System.Windows.Forms.NumericUpDown();
            this.textBox_imageOffset = new System.Windows.Forms.TextBox();
            this.label_imageOffset = new System.Windows.Forms.Label();
            this.groupBox_image = new System.Windows.Forms.GroupBox();
            this.panel_gfx = new System.Windows.Forms.Panel();
            this.gfxView_gfx = new mage.GfxView();
            this.textBox_palOffset = new System.Windows.Forms.TextBox();
            this.label_paletteOffset = new System.Windows.Forms.Label();
            this.groupBox_paletteControl = new System.Windows.Forms.GroupBox();
            this.button_editPal = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_paletteGo = new System.Windows.Forms.Button();
            this.pictureBox_palette = new System.Windows.Forms.PictureBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel_coor = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel_size = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel_changes = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip_spring = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel_zoomLevel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip_zoom = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip_zoom1600 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_zoom800 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_zoom400 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_zoom200 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip_zoom100 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStrip_gfx = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_gfxImportRaw = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_gfxImportImg = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_gfxExport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_gfxExportRaw = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItem_gfxExportImg = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_pixelFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_4bitIndexed = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_24bitRGB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_32bitARGB = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip_palette = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_palImport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_palImport_raw = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_palImport_tlp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_palImport_yychr = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_palExport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_palExport_raw = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_palExport_tlp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_palExport_yychr = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_imageControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_width)).BeginInit();
            this.groupBox_image.SuspendLayout();
            this.panel_gfx.SuspendLayout();
            this.groupBox_paletteControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_palette)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_imageControl
            // 
            resources.ApplyResources(this.groupBox_imageControl, "groupBox_imageControl");
            this.groupBox_imageControl.Controls.Add(this.checkBox_compressed);
            this.groupBox_imageControl.Controls.Add(this.button_imageGo);
            this.groupBox_imageControl.Controls.Add(this.label_height);
            this.groupBox_imageControl.Controls.Add(this.label_width);
            this.groupBox_imageControl.Controls.Add(this.numericUpDown_height);
            this.groupBox_imageControl.Controls.Add(this.numericUpDown_width);
            this.groupBox_imageControl.Controls.Add(this.textBox_imageOffset);
            this.groupBox_imageControl.Controls.Add(this.label_imageOffset);
            this.groupBox_imageControl.Name = "groupBox_imageControl";
            this.groupBox_imageControl.TabStop = false;
            // 
            // checkBox_compressed
            // 
            resources.ApplyResources(this.checkBox_compressed, "checkBox_compressed");
            this.checkBox_compressed.Name = "checkBox_compressed";
            this.checkBox_compressed.UseVisualStyleBackColor = true;
            this.checkBox_compressed.CheckedChanged += new System.EventHandler(this.checkBox_compressed_CheckedChanged);
            // 
            // button_imageGo
            // 
            resources.ApplyResources(this.button_imageGo, "button_imageGo");
            this.button_imageGo.Name = "button_imageGo";
            this.button_imageGo.UseVisualStyleBackColor = true;
            this.button_imageGo.Click += new System.EventHandler(this.button_imageGo_Click);
            // 
            // label_height
            // 
            resources.ApplyResources(this.label_height, "label_height");
            this.label_height.Name = "label_height";
            // 
            // label_width
            // 
            resources.ApplyResources(this.label_width, "label_width");
            this.label_width.Name = "label_width";
            // 
            // numericUpDown_height
            // 
            resources.ApplyResources(this.numericUpDown_height, "numericUpDown_height");
            this.numericUpDown_height.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDown_height.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_height.Name = "numericUpDown_height";
            this.numericUpDown_height.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown_height.ValueChanged += new System.EventHandler(this.numericUpDown_height_ValueChanged);
            // 
            // numericUpDown_width
            // 
            resources.ApplyResources(this.numericUpDown_width, "numericUpDown_width");
            this.numericUpDown_width.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDown_width.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_width.Name = "numericUpDown_width";
            this.numericUpDown_width.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDown_width.ValueChanged += new System.EventHandler(this.numericUpDown_width_ValueChanged);
            // 
            // textBox_imageOffset
            // 
            resources.ApplyResources(this.textBox_imageOffset, "textBox_imageOffset");
            this.textBox_imageOffset.Name = "textBox_imageOffset";
            // 
            // label_imageOffset
            // 
            resources.ApplyResources(this.label_imageOffset, "label_imageOffset");
            this.label_imageOffset.Name = "label_imageOffset";
            // 
            // groupBox_image
            // 
            resources.ApplyResources(this.groupBox_image, "groupBox_image");
            this.groupBox_image.Controls.Add(this.panel_gfx);
            this.groupBox_image.Name = "groupBox_image";
            this.groupBox_image.TabStop = false;
            // 
            // panel_gfx
            // 
            resources.ApplyResources(this.panel_gfx, "panel_gfx");
            this.panel_gfx.Controls.Add(this.gfxView_gfx);
            this.panel_gfx.Name = "panel_gfx";
            // 
            // gfxView_gfx
            // 
            resources.ApplyResources(this.gfxView_gfx, "gfxView_gfx");
            this.gfxView_gfx.Name = "gfxView_gfx";
            this.gfxView_gfx.TabStop = false;
            this.gfxView_gfx.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gfxView_gfx_MouseMove);
            // 
            // textBox_palOffset
            // 
            resources.ApplyResources(this.textBox_palOffset, "textBox_palOffset");
            this.textBox_palOffset.Name = "textBox_palOffset";
            // 
            // label_paletteOffset
            // 
            resources.ApplyResources(this.label_paletteOffset, "label_paletteOffset");
            this.label_paletteOffset.Name = "label_paletteOffset";
            // 
            // groupBox_paletteControl
            // 
            resources.ApplyResources(this.groupBox_paletteControl, "groupBox_paletteControl");
            this.groupBox_paletteControl.Controls.Add(this.button_editPal);
            this.groupBox_paletteControl.Controls.Add(this.button_minus);
            this.groupBox_paletteControl.Controls.Add(this.button_plus);
            this.groupBox_paletteControl.Controls.Add(this.button_paletteGo);
            this.groupBox_paletteControl.Controls.Add(this.pictureBox_palette);
            this.groupBox_paletteControl.Controls.Add(this.textBox_palOffset);
            this.groupBox_paletteControl.Controls.Add(this.label_paletteOffset);
            this.groupBox_paletteControl.Name = "groupBox_paletteControl";
            this.groupBox_paletteControl.TabStop = false;
            // 
            // button_editPal
            // 
            resources.ApplyResources(this.button_editPal, "button_editPal");
            this.button_editPal.Name = "button_editPal";
            this.button_editPal.UseVisualStyleBackColor = true;
            this.button_editPal.Click += new System.EventHandler(this.button_editPal_Click);
            // 
            // button_minus
            // 
            resources.ApplyResources(this.button_minus, "button_minus");
            this.button_minus.Name = "button_minus";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_plus
            // 
            resources.ApplyResources(this.button_plus, "button_plus");
            this.button_plus.Name = "button_plus";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_paletteGo
            // 
            resources.ApplyResources(this.button_paletteGo, "button_paletteGo");
            this.button_paletteGo.Name = "button_paletteGo";
            this.button_paletteGo.UseVisualStyleBackColor = true;
            this.button_paletteGo.Click += new System.EventHandler(this.button_paletteGo_Click);
            // 
            // pictureBox_palette
            // 
            resources.ApplyResources(this.pictureBox_palette, "pictureBox_palette");
            this.pictureBox_palette.Name = "pictureBox_palette";
            this.pictureBox_palette.TabStop = false;
            // 
            // statusStrip
            // 
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_coor,
            this.statusLabel_size,
            this.statusLabel_changes,
            this.statusStrip_spring,
            this.statusLabel_zoomLevel,
            this.statusStrip_zoom});
            this.statusStrip.Name = "statusStrip";
            // 
            // statusLabel_coor
            // 
            resources.ApplyResources(this.statusLabel_coor, "statusLabel_coor");
            this.statusLabel_coor.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.statusLabel_coor.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.statusLabel_coor.Name = "statusLabel_coor";
            // 
            // statusLabel_size
            // 
            resources.ApplyResources(this.statusLabel_size, "statusLabel_size");
            this.statusLabel_size.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.statusLabel_size.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.statusLabel_size.Name = "statusLabel_size";
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
            // statusLabel_zoomLevel
            // 
            resources.ApplyResources(this.statusLabel_zoomLevel, "statusLabel_zoomLevel");
            this.statusLabel_zoomLevel.Name = "statusLabel_zoomLevel";
            // 
            // statusStrip_zoom
            // 
            resources.ApplyResources(this.statusStrip_zoom, "statusStrip_zoom");
            this.statusStrip_zoom.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.statusStrip_zoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.statusStrip_zoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_zoom1600,
            this.toolStrip_zoom800,
            this.toolStrip_zoom400,
            this.toolStrip_zoom200,
            this.toolStrip_zoom100});
            this.statusStrip_zoom.Image = global::mage.Properties.Resources.toolbar_zoom;
            this.statusStrip_zoom.Name = "statusStrip_zoom";
            // 
            // toolStrip_zoom1600
            // 
            resources.ApplyResources(this.toolStrip_zoom1600, "toolStrip_zoom1600");
            this.toolStrip_zoom1600.Name = "toolStrip_zoom1600";
            this.toolStrip_zoom1600.Click += new System.EventHandler(this.toolStrip_zoom1600_Click);
            // 
            // toolStrip_zoom800
            // 
            resources.ApplyResources(this.toolStrip_zoom800, "toolStrip_zoom800");
            this.toolStrip_zoom800.Name = "toolStrip_zoom800";
            this.toolStrip_zoom800.Click += new System.EventHandler(this.toolStrip_zoom800_Click);
            // 
            // toolStrip_zoom400
            // 
            resources.ApplyResources(this.toolStrip_zoom400, "toolStrip_zoom400");
            this.toolStrip_zoom400.Name = "toolStrip_zoom400";
            this.toolStrip_zoom400.Click += new System.EventHandler(this.toolStrip_zoom400_Click);
            // 
            // toolStrip_zoom200
            // 
            resources.ApplyResources(this.toolStrip_zoom200, "toolStrip_zoom200");
            this.toolStrip_zoom200.Name = "toolStrip_zoom200";
            this.toolStrip_zoom200.Click += new System.EventHandler(this.toolStrip_zoom200_Click);
            // 
            // toolStrip_zoom100
            // 
            resources.ApplyResources(this.toolStrip_zoom100, "toolStrip_zoom100");
            this.toolStrip_zoom100.Name = "toolStrip_zoom100";
            this.toolStrip_zoom100.Click += new System.EventHandler(this.toolStrip_zoom100_Click);
            // 
            // menuStrip
            // 
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_gfx,
            this.menuStrip_palette});
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            // 
            // menuStrip_gfx
            // 
            resources.ApplyResources(this.menuStrip_gfx, "menuStrip_gfx");
            this.menuStrip_gfx.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.menuItem_gfxExport});
            this.menuStrip_gfx.Name = "menuStrip_gfx";
            // 
            // importToolStripMenuItem
            // 
            resources.ApplyResources(this.importToolStripMenuItem, "importToolStripMenuItem");
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_gfxImportRaw,
            this.menuItem_gfxImportImg});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            // 
            // menuItem_gfxImportRaw
            // 
            resources.ApplyResources(this.menuItem_gfxImportRaw, "menuItem_gfxImportRaw");
            this.menuItem_gfxImportRaw.Name = "menuItem_gfxImportRaw";
            this.menuItem_gfxImportRaw.Click += new System.EventHandler(this.menuItem_gfxImportRaw_Click);
            // 
            // menuItem_gfxImportImg
            // 
            resources.ApplyResources(this.menuItem_gfxImportImg, "menuItem_gfxImportImg");
            this.menuItem_gfxImportImg.Name = "menuItem_gfxImportImg";
            this.menuItem_gfxImportImg.Click += new System.EventHandler(this.menuItem_gfxImportImg_Click);
            // 
            // menuItem_gfxExport
            // 
            resources.ApplyResources(this.menuItem_gfxExport, "menuItem_gfxExport");
            this.menuItem_gfxExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_gfxExportRaw,
            this.toolStripSeparator1,
            this.menuItem_gfxExportImg,
            this.menuItem_pixelFormat});
            this.menuItem_gfxExport.Name = "menuItem_gfxExport";
            // 
            // menuItem_gfxExportRaw
            // 
            resources.ApplyResources(this.menuItem_gfxExportRaw, "menuItem_gfxExportRaw");
            this.menuItem_gfxExportRaw.Name = "menuItem_gfxExportRaw";
            this.menuItem_gfxExportRaw.Click += new System.EventHandler(this.menuItem_gfxExportRaw_Click);
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // menuItem_gfxExportImg
            // 
            resources.ApplyResources(this.menuItem_gfxExportImg, "menuItem_gfxExportImg");
            this.menuItem_gfxExportImg.Name = "menuItem_gfxExportImg";
            this.menuItem_gfxExportImg.Click += new System.EventHandler(this.menuItem_gfxExportImg_Click);
            // 
            // menuItem_pixelFormat
            // 
            resources.ApplyResources(this.menuItem_pixelFormat, "menuItem_pixelFormat");
            this.menuItem_pixelFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_4bitIndexed,
            this.menuItem_24bitRGB,
            this.menuItem_32bitARGB});
            this.menuItem_pixelFormat.Name = "menuItem_pixelFormat";
            // 
            // menuItem_4bitIndexed
            // 
            resources.ApplyResources(this.menuItem_4bitIndexed, "menuItem_4bitIndexed");
            this.menuItem_4bitIndexed.Name = "menuItem_4bitIndexed";
            this.menuItem_4bitIndexed.Click += new System.EventHandler(this.menuItem_pixelFormat_Click);
            // 
            // menuItem_24bitRGB
            // 
            resources.ApplyResources(this.menuItem_24bitRGB, "menuItem_24bitRGB");
            this.menuItem_24bitRGB.Checked = true;
            this.menuItem_24bitRGB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuItem_24bitRGB.Name = "menuItem_24bitRGB";
            this.menuItem_24bitRGB.Click += new System.EventHandler(this.menuItem_pixelFormat_Click);
            // 
            // menuItem_32bitARGB
            // 
            resources.ApplyResources(this.menuItem_32bitARGB, "menuItem_32bitARGB");
            this.menuItem_32bitARGB.Name = "menuItem_32bitARGB";
            this.menuItem_32bitARGB.Click += new System.EventHandler(this.menuItem_pixelFormat_Click);
            // 
            // menuStrip_palette
            // 
            resources.ApplyResources(this.menuStrip_palette, "menuStrip_palette");
            this.menuStrip_palette.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_palImport,
            this.menuItem_palExport});
            this.menuStrip_palette.Name = "menuStrip_palette";
            // 
            // menuItem_palImport
            // 
            resources.ApplyResources(this.menuItem_palImport, "menuItem_palImport");
            this.menuItem_palImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_palImport_raw,
            this.menuItem_palImport_tlp,
            this.menuItem_palImport_yychr});
            this.menuItem_palImport.Name = "menuItem_palImport";
            // 
            // menuItem_palImport_raw
            // 
            resources.ApplyResources(this.menuItem_palImport_raw, "menuItem_palImport_raw");
            this.menuItem_palImport_raw.Name = "menuItem_palImport_raw";
            this.menuItem_palImport_raw.Click += new System.EventHandler(this.menuItem_palImport_raw_Click);
            // 
            // menuItem_palImport_tlp
            // 
            resources.ApplyResources(this.menuItem_palImport_tlp, "menuItem_palImport_tlp");
            this.menuItem_palImport_tlp.Name = "menuItem_palImport_tlp";
            this.menuItem_palImport_tlp.Click += new System.EventHandler(this.menuItem_palImport_tlp_Click);
            // 
            // menuItem_palImport_yychr
            // 
            resources.ApplyResources(this.menuItem_palImport_yychr, "menuItem_palImport_yychr");
            this.menuItem_palImport_yychr.Name = "menuItem_palImport_yychr";
            this.menuItem_palImport_yychr.Click += new System.EventHandler(this.menuItem_palImport_yychr_Click);
            // 
            // menuItem_palExport
            // 
            resources.ApplyResources(this.menuItem_palExport, "menuItem_palExport");
            this.menuItem_palExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_palExport_raw,
            this.menuItem_palExport_tlp,
            this.menuItem_palExport_yychr});
            this.menuItem_palExport.Name = "menuItem_palExport";
            // 
            // menuItem_palExport_raw
            // 
            resources.ApplyResources(this.menuItem_palExport_raw, "menuItem_palExport_raw");
            this.menuItem_palExport_raw.Name = "menuItem_palExport_raw";
            this.menuItem_palExport_raw.Click += new System.EventHandler(this.menuItem_palExport_raw_Click);
            // 
            // menuItem_palExport_tlp
            // 
            resources.ApplyResources(this.menuItem_palExport_tlp, "menuItem_palExport_tlp");
            this.menuItem_palExport_tlp.Name = "menuItem_palExport_tlp";
            this.menuItem_palExport_tlp.Click += new System.EventHandler(this.menuItem_palExport_tlp_Click);
            // 
            // menuItem_palExport_yychr
            // 
            resources.ApplyResources(this.menuItem_palExport_yychr, "menuItem_palExport_yychr");
            this.menuItem_palExport_yychr.Name = "menuItem_palExport_yychr";
            this.menuItem_palExport_yychr.Click += new System.EventHandler(this.menuItem_palExport_yychr_Click);
            // 
            // FormGraphics
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.groupBox_paletteControl);
            this.Controls.Add(this.groupBox_image);
            this.Controls.Add(this.groupBox_imageControl);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormGraphics";
            this.groupBox_imageControl.ResumeLayout(false);
            this.groupBox_imageControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_width)).EndInit();
            this.groupBox_image.ResumeLayout(false);
            this.panel_gfx.ResumeLayout(false);
            this.groupBox_paletteControl.ResumeLayout(false);
            this.groupBox_paletteControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_palette)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_imageControl;
        private System.Windows.Forms.Label label_height;
        private System.Windows.Forms.Label label_width;
        private System.Windows.Forms.NumericUpDown numericUpDown_height;
        private System.Windows.Forms.NumericUpDown numericUpDown_width;
        private System.Windows.Forms.TextBox textBox_palOffset;
        private System.Windows.Forms.Label label_paletteOffset;
        private System.Windows.Forms.TextBox textBox_imageOffset;
        private System.Windows.Forms.Label label_imageOffset;
        private System.Windows.Forms.GroupBox groupBox_image;
        private System.Windows.Forms.GroupBox groupBox_paletteControl;
        private System.Windows.Forms.PictureBox pictureBox_palette;
        private System.Windows.Forms.Button button_imageGo;
        private System.Windows.Forms.Button button_paletteGo;
        private System.Windows.Forms.Panel panel_gfx;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_coor;
        private System.Windows.Forms.ToolStripDropDownButton statusStrip_zoom;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_zoom1600;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_zoom400;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_zoom800;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_zoom200;
        private System.Windows.Forms.ToolStripMenuItem toolStrip_zoom100;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_zoomLevel;
        private System.Windows.Forms.CheckBox checkBox_compressed;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip_spring;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_gfx;
        private System.Windows.Forms.ToolStripMenuItem menuStrip_palette;
        private System.Windows.Forms.ToolStripMenuItem menuItem_gfxExport;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem_gfxExportImg;
        private System.Windows.Forms.ToolStripMenuItem menuItem_gfxExportRaw;
        private System.Windows.Forms.ToolStripMenuItem menuItem_gfxImportImg;
        private System.Windows.Forms.ToolStripMenuItem menuItem_gfxImportRaw;
        private System.Windows.Forms.ToolStripMenuItem menuItem_palExport;
        private System.Windows.Forms.ToolStripMenuItem menuItem_palImport;
        private System.Windows.Forms.Button button_editPal;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_size;
        private GfxView gfxView_gfx;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItem_pixelFormat;
        private System.Windows.Forms.ToolStripMenuItem menuItem_4bitIndexed;
        private System.Windows.Forms.ToolStripMenuItem menuItem_24bitRGB;
        private System.Windows.Forms.ToolStripMenuItem menuItem_32bitARGB;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_changes;
        private System.Windows.Forms.ToolStripMenuItem menuItem_palImport_raw;
        private System.Windows.Forms.ToolStripMenuItem menuItem_palImport_tlp;
        private System.Windows.Forms.ToolStripMenuItem menuItem_palImport_yychr;
        private System.Windows.Forms.ToolStripMenuItem menuItem_palExport_raw;
        private System.Windows.Forms.ToolStripMenuItem menuItem_palExport_tlp;
        private System.Windows.Forms.ToolStripMenuItem menuItem_palExport_yychr;
    }
}