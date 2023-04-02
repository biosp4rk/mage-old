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
            this.gfxView_gfx = new mage.GfxView();
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
            this.groupBox_imageControl.Controls.Add(this.checkBox_compressed);
            this.groupBox_imageControl.Controls.Add(this.button_imageGo);
            this.groupBox_imageControl.Controls.Add(this.label_height);
            this.groupBox_imageControl.Controls.Add(this.label_width);
            this.groupBox_imageControl.Controls.Add(this.numericUpDown_height);
            this.groupBox_imageControl.Controls.Add(this.numericUpDown_width);
            this.groupBox_imageControl.Controls.Add(this.textBox_imageOffset);
            this.groupBox_imageControl.Controls.Add(this.label_imageOffset);
            this.groupBox_imageControl.Location = new System.Drawing.Point(12, 27);
            this.groupBox_imageControl.Name = "groupBox_imageControl";
            this.groupBox_imageControl.Size = new System.Drawing.Size(270, 73);
            this.groupBox_imageControl.TabIndex = 0;
            this.groupBox_imageControl.TabStop = false;
            this.groupBox_imageControl.Text = "Image Control";
            // 
            // checkBox_compressed
            // 
            this.checkBox_compressed.AutoSize = true;
            this.checkBox_compressed.Location = new System.Drawing.Point(180, 21);
            this.checkBox_compressed.Name = "checkBox_compressed";
            this.checkBox_compressed.Size = new System.Drawing.Size(84, 17);
            this.checkBox_compressed.TabIndex = 2;
            this.checkBox_compressed.Text = "Compressed";
            this.checkBox_compressed.UseVisualStyleBackColor = true;
            this.checkBox_compressed.CheckedChanged += new System.EventHandler(this.checkBox_compressed_CheckedChanged);
            // 
            // button_imageGo
            // 
            this.button_imageGo.Location = new System.Drawing.Point(116, 18);
            this.button_imageGo.Name = "button_imageGo";
            this.button_imageGo.Size = new System.Drawing.Size(50, 22);
            this.button_imageGo.TabIndex = 1;
            this.button_imageGo.Text = "Go";
            this.button_imageGo.UseVisualStyleBackColor = true;
            this.button_imageGo.Click += new System.EventHandler(this.button_imageGo_Click);
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.Location = new System.Drawing.Point(113, 47);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(41, 13);
            this.label_height.TabIndex = 0;
            this.label_height.Text = "Height:";
            // 
            // label_width
            // 
            this.label_width.AutoSize = true;
            this.label_width.Location = new System.Drawing.Point(6, 47);
            this.label_width.Name = "label_width";
            this.label_width.Size = new System.Drawing.Size(38, 13);
            this.label_width.TabIndex = 0;
            this.label_width.Text = "Width:";
            // 
            // numericUpDown_height
            // 
            this.numericUpDown_height.Location = new System.Drawing.Point(157, 45);
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
            this.numericUpDown_height.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown_height.TabIndex = 4;
            this.numericUpDown_height.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown_height.ValueChanged += new System.EventHandler(this.numericUpDown_height_ValueChanged);
            // 
            // numericUpDown_width
            // 
            this.numericUpDown_width.Location = new System.Drawing.Point(50, 45);
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
            this.numericUpDown_width.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown_width.TabIndex = 3;
            this.numericUpDown_width.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDown_width.ValueChanged += new System.EventHandler(this.numericUpDown_width_ValueChanged);
            // 
            // textBox_imageOffset
            // 
            this.textBox_imageOffset.Location = new System.Drawing.Point(50, 19);
            this.textBox_imageOffset.Name = "textBox_imageOffset";
            this.textBox_imageOffset.Size = new System.Drawing.Size(60, 20);
            this.textBox_imageOffset.TabIndex = 0;
            // 
            // label_imageOffset
            // 
            this.label_imageOffset.AutoSize = true;
            this.label_imageOffset.Location = new System.Drawing.Point(6, 22);
            this.label_imageOffset.Name = "label_imageOffset";
            this.label_imageOffset.Size = new System.Drawing.Size(38, 13);
            this.label_imageOffset.TabIndex = 0;
            this.label_imageOffset.Text = "Offset:";
            // 
            // groupBox_image
            // 
            this.groupBox_image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_image.Controls.Add(this.panel_gfx);
            this.groupBox_image.Location = new System.Drawing.Point(12, 106);
            this.groupBox_image.Name = "groupBox_image";
            this.groupBox_image.Size = new System.Drawing.Size(562, 202);
            this.groupBox_image.TabIndex = 0;
            this.groupBox_image.TabStop = false;
            this.groupBox_image.Text = "Image";
            // 
            // panel_gfx
            // 
            this.panel_gfx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_gfx.AutoScroll = true;
            this.panel_gfx.Controls.Add(this.gfxView_gfx);
            this.panel_gfx.Location = new System.Drawing.Point(6, 19);
            this.panel_gfx.Name = "panel_gfx";
            this.panel_gfx.Size = new System.Drawing.Size(549, 177);
            this.panel_gfx.TabIndex = 0;
            // 
            // textBox_palOffset
            // 
            this.textBox_palOffset.Location = new System.Drawing.Point(50, 19);
            this.textBox_palOffset.Name = "textBox_palOffset";
            this.textBox_palOffset.Size = new System.Drawing.Size(60, 20);
            this.textBox_palOffset.TabIndex = 0;
            // 
            // label_paletteOffset
            // 
            this.label_paletteOffset.AutoSize = true;
            this.label_paletteOffset.Location = new System.Drawing.Point(6, 22);
            this.label_paletteOffset.Name = "label_paletteOffset";
            this.label_paletteOffset.Size = new System.Drawing.Size(38, 13);
            this.label_paletteOffset.TabIndex = 0;
            this.label_paletteOffset.Text = "Offset:";
            // 
            // groupBox_paletteControl
            // 
            this.groupBox_paletteControl.Controls.Add(this.button_editPal);
            this.groupBox_paletteControl.Controls.Add(this.button_minus);
            this.groupBox_paletteControl.Controls.Add(this.button_plus);
            this.groupBox_paletteControl.Controls.Add(this.button_paletteGo);
            this.groupBox_paletteControl.Controls.Add(this.pictureBox_palette);
            this.groupBox_paletteControl.Controls.Add(this.textBox_palOffset);
            this.groupBox_paletteControl.Controls.Add(this.label_paletteOffset);
            this.groupBox_paletteControl.Location = new System.Drawing.Point(288, 27);
            this.groupBox_paletteControl.Name = "groupBox_paletteControl";
            this.groupBox_paletteControl.Size = new System.Drawing.Size(285, 73);
            this.groupBox_paletteControl.TabIndex = 1;
            this.groupBox_paletteControl.TabStop = false;
            this.groupBox_paletteControl.Text = "Palette Control";
            // 
            // button_editPal
            // 
            this.button_editPal.Location = new System.Drawing.Point(234, 18);
            this.button_editPal.Name = "button_editPal";
            this.button_editPal.Size = new System.Drawing.Size(45, 22);
            this.button_editPal.TabIndex = 4;
            this.button_editPal.Text = "Edit";
            this.button_editPal.UseVisualStyleBackColor = true;
            this.button_editPal.Click += new System.EventHandler(this.button_editPal_Click);
            // 
            // button_minus
            // 
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minus.Location = new System.Drawing.Point(200, 18);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(22, 22);
            this.button_minus.TabIndex = 3;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_plus
            // 
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_plus.Location = new System.Drawing.Point(172, 18);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(22, 22);
            this.button_plus.TabIndex = 2;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_paletteGo
            // 
            this.button_paletteGo.Location = new System.Drawing.Point(116, 18);
            this.button_paletteGo.Name = "button_paletteGo";
            this.button_paletteGo.Size = new System.Drawing.Size(50, 22);
            this.button_paletteGo.TabIndex = 1;
            this.button_paletteGo.Text = "Go";
            this.button_paletteGo.UseVisualStyleBackColor = true;
            this.button_paletteGo.Click += new System.EventHandler(this.button_paletteGo_Click);
            // 
            // pictureBox_palette
            // 
            this.pictureBox_palette.Location = new System.Drawing.Point(6, 47);
            this.pictureBox_palette.Name = "pictureBox_palette";
            this.pictureBox_palette.Size = new System.Drawing.Size(273, 18);
            this.pictureBox_palette.TabIndex = 4;
            this.pictureBox_palette.TabStop = false;
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_coor,
            this.statusLabel_size,
            this.statusLabel_changes,
            this.statusStrip_spring,
            this.statusLabel_zoomLevel,
            this.statusStrip_zoom});
            this.statusStrip.Location = new System.Drawing.Point(0, 311);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(586, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip";
            // 
            // statusLabel_coor
            // 
            this.statusLabel_coor.AutoSize = false;
            this.statusLabel_coor.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.statusLabel_coor.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.statusLabel_coor.Name = "statusLabel_coor";
            this.statusLabel_coor.Size = new System.Drawing.Size(70, 17);
            this.statusLabel_coor.Text = "(0, 0)";
            this.statusLabel_coor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusLabel_size
            // 
            this.statusLabel_size.AutoSize = false;
            this.statusLabel_size.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.statusLabel_size.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.statusLabel_size.Name = "statusLabel_size";
            this.statusLabel_size.Size = new System.Drawing.Size(70, 17);
            this.statusLabel_size.Text = "0 x 0";
            this.statusLabel_size.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.statusStrip_spring.Size = new System.Drawing.Size(324, 17);
            this.statusStrip_spring.Spring = true;
            // 
            // statusLabel_zoomLevel
            // 
            this.statusLabel_zoomLevel.Name = "statusLabel_zoomLevel";
            this.statusLabel_zoomLevel.Size = new System.Drawing.Size(35, 17);
            this.statusLabel_zoomLevel.Text = "100%";
            // 
            // statusStrip_zoom
            // 
            this.statusStrip_zoom.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.statusStrip_zoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.statusStrip_zoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_zoom1600,
            this.toolStrip_zoom800,
            this.toolStrip_zoom400,
            this.toolStrip_zoom200,
            this.toolStrip_zoom100});
            this.statusStrip_zoom.Image = global::mage.Properties.Resources.toolbar_zoom;
            this.statusStrip_zoom.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.statusStrip_zoom.Name = "statusStrip_zoom";
            this.statusStrip_zoom.Size = new System.Drawing.Size(29, 20);
            this.statusStrip_zoom.Text = "Zoom";
            // 
            // toolStrip_zoom1600
            // 
            this.toolStrip_zoom1600.Name = "toolStrip_zoom1600";
            this.toolStrip_zoom1600.Size = new System.Drawing.Size(108, 22);
            this.toolStrip_zoom1600.Text = "1600%";
            this.toolStrip_zoom1600.Click += new System.EventHandler(this.toolStrip_zoom1600_Click);
            // 
            // toolStrip_zoom800
            // 
            this.toolStrip_zoom800.Name = "toolStrip_zoom800";
            this.toolStrip_zoom800.Size = new System.Drawing.Size(108, 22);
            this.toolStrip_zoom800.Text = "800%";
            this.toolStrip_zoom800.Click += new System.EventHandler(this.toolStrip_zoom800_Click);
            // 
            // toolStrip_zoom400
            // 
            this.toolStrip_zoom400.Name = "toolStrip_zoom400";
            this.toolStrip_zoom400.Size = new System.Drawing.Size(108, 22);
            this.toolStrip_zoom400.Text = "400%";
            this.toolStrip_zoom400.Click += new System.EventHandler(this.toolStrip_zoom400_Click);
            // 
            // toolStrip_zoom200
            // 
            this.toolStrip_zoom200.Name = "toolStrip_zoom200";
            this.toolStrip_zoom200.Size = new System.Drawing.Size(108, 22);
            this.toolStrip_zoom200.Text = "200%";
            this.toolStrip_zoom200.Click += new System.EventHandler(this.toolStrip_zoom200_Click);
            // 
            // toolStrip_zoom100
            // 
            this.toolStrip_zoom100.Name = "toolStrip_zoom100";
            this.toolStrip_zoom100.Size = new System.Drawing.Size(108, 22);
            this.toolStrip_zoom100.Text = "100%";
            this.toolStrip_zoom100.Click += new System.EventHandler(this.toolStrip_zoom100_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStrip_gfx,
            this.menuStrip_palette});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(586, 24);
            this.menuStrip.TabIndex = 0;
            // 
            // menuStrip_gfx
            // 
            this.menuStrip_gfx.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.menuItem_gfxExport});
            this.menuStrip_gfx.Name = "menuStrip_gfx";
            this.menuStrip_gfx.Size = new System.Drawing.Size(65, 20);
            this.menuStrip_gfx.Text = "Graphics";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_gfxImportRaw,
            this.menuItem_gfxImportImg});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // menuItem_gfxImportRaw
            // 
            this.menuItem_gfxImportRaw.Name = "menuItem_gfxImportRaw";
            this.menuItem_gfxImportRaw.Size = new System.Drawing.Size(116, 22);
            this.menuItem_gfxImportRaw.Text = "Raw...";
            this.menuItem_gfxImportRaw.Click += new System.EventHandler(this.menuItem_gfxImportRaw_Click);
            // 
            // menuItem_gfxImportImg
            // 
            this.menuItem_gfxImportImg.Name = "menuItem_gfxImportImg";
            this.menuItem_gfxImportImg.Size = new System.Drawing.Size(116, 22);
            this.menuItem_gfxImportImg.Text = "Image...";
            this.menuItem_gfxImportImg.Click += new System.EventHandler(this.menuItem_gfxImportImg_Click);
            // 
            // menuItem_gfxExport
            // 
            this.menuItem_gfxExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_gfxExportRaw,
            this.toolStripSeparator1,
            this.menuItem_gfxExportImg,
            this.menuItem_pixelFormat});
            this.menuItem_gfxExport.Name = "menuItem_gfxExport";
            this.menuItem_gfxExport.Size = new System.Drawing.Size(110, 22);
            this.menuItem_gfxExport.Text = "Export";
            // 
            // menuItem_gfxExportRaw
            // 
            this.menuItem_gfxExportRaw.Name = "menuItem_gfxExportRaw";
            this.menuItem_gfxExportRaw.Size = new System.Drawing.Size(140, 22);
            this.menuItem_gfxExportRaw.Text = "Raw...";
            this.menuItem_gfxExportRaw.Click += new System.EventHandler(this.menuItem_gfxExportRaw_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(137, 6);
            // 
            // menuItem_gfxExportImg
            // 
            this.menuItem_gfxExportImg.Name = "menuItem_gfxExportImg";
            this.menuItem_gfxExportImg.Size = new System.Drawing.Size(140, 22);
            this.menuItem_gfxExportImg.Text = "Image...";
            this.menuItem_gfxExportImg.Click += new System.EventHandler(this.menuItem_gfxExportImg_Click);
            // 
            // menuItem_pixelFormat
            // 
            this.menuItem_pixelFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_4bitIndexed,
            this.menuItem_24bitRGB,
            this.menuItem_32bitARGB});
            this.menuItem_pixelFormat.Name = "menuItem_pixelFormat";
            this.menuItem_pixelFormat.Size = new System.Drawing.Size(140, 22);
            this.menuItem_pixelFormat.Text = "Pixel Format";
            // 
            // menuItem_4bitIndexed
            // 
            this.menuItem_4bitIndexed.Name = "menuItem_4bitIndexed";
            this.menuItem_4bitIndexed.Size = new System.Drawing.Size(144, 22);
            this.menuItem_4bitIndexed.Text = "4-bit Indexed";
            this.menuItem_4bitIndexed.Click += new System.EventHandler(this.menuItem_pixelFormat_Click);
            // 
            // menuItem_24bitRGB
            // 
            this.menuItem_24bitRGB.Checked = true;
            this.menuItem_24bitRGB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuItem_24bitRGB.Name = "menuItem_24bitRGB";
            this.menuItem_24bitRGB.Size = new System.Drawing.Size(144, 22);
            this.menuItem_24bitRGB.Text = "24-bit RGB";
            this.menuItem_24bitRGB.Click += new System.EventHandler(this.menuItem_pixelFormat_Click);
            // 
            // menuItem_32bitARGB
            // 
            this.menuItem_32bitARGB.Name = "menuItem_32bitARGB";
            this.menuItem_32bitARGB.Size = new System.Drawing.Size(144, 22);
            this.menuItem_32bitARGB.Text = "32-bit ARGB";
            this.menuItem_32bitARGB.Click += new System.EventHandler(this.menuItem_pixelFormat_Click);
            // 
            // menuStrip_palette
            // 
            this.menuStrip_palette.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_palImport,
            this.menuItem_palExport});
            this.menuStrip_palette.Name = "menuStrip_palette";
            this.menuStrip_palette.Size = new System.Drawing.Size(55, 20);
            this.menuStrip_palette.Text = "Palette";
            // 
            // menuItem_palImport
            // 
            this.menuItem_palImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_palImport_raw,
            this.menuItem_palImport_tlp,
            this.menuItem_palImport_yychr});
            this.menuItem_palImport.Name = "menuItem_palImport";
            this.menuItem_palImport.Size = new System.Drawing.Size(110, 22);
            this.menuItem_palImport.Text = "Import";
            // 
            // menuItem_palImport_raw
            // 
            this.menuItem_palImport_raw.Name = "menuItem_palImport_raw";
            this.menuItem_palImport_raw.Size = new System.Drawing.Size(153, 22);
            this.menuItem_palImport_raw.Text = "Raw...";
            this.menuItem_palImport_raw.Click += new System.EventHandler(this.menuItem_palImport_raw_Click);
            // 
            // menuItem_palImport_tlp
            // 
            this.menuItem_palImport_tlp.Name = "menuItem_palImport_tlp";
            this.menuItem_palImport_tlp.Size = new System.Drawing.Size(153, 22);
            this.menuItem_palImport_tlp.Text = "Tile Layer Pro...";
            this.menuItem_palImport_tlp.Click += new System.EventHandler(this.menuItem_palImport_tlp_Click);
            // 
            // menuItem_palImport_yychr
            // 
            this.menuItem_palImport_yychr.Name = "menuItem_palImport_yychr";
            this.menuItem_palImport_yychr.Size = new System.Drawing.Size(153, 22);
            this.menuItem_palImport_yychr.Text = "YY-CHR...";
            this.menuItem_palImport_yychr.Click += new System.EventHandler(this.menuItem_palImport_yychr_Click);
            // 
            // menuItem_palExport
            // 
            this.menuItem_palExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_palExport_raw,
            this.menuItem_palExport_tlp,
            this.menuItem_palExport_yychr});
            this.menuItem_palExport.Name = "menuItem_palExport";
            this.menuItem_palExport.Size = new System.Drawing.Size(110, 22);
            this.menuItem_palExport.Text = "Export";
            // 
            // menuItem_palExport_raw
            // 
            this.menuItem_palExport_raw.Name = "menuItem_palExport_raw";
            this.menuItem_palExport_raw.Size = new System.Drawing.Size(153, 22);
            this.menuItem_palExport_raw.Text = "Raw...";
            this.menuItem_palExport_raw.Click += new System.EventHandler(this.menuItem_palExport_raw_Click);
            // 
            // menuItem_palExport_tlp
            // 
            this.menuItem_palExport_tlp.Name = "menuItem_palExport_tlp";
            this.menuItem_palExport_tlp.Size = new System.Drawing.Size(153, 22);
            this.menuItem_palExport_tlp.Text = "Tile Layer Pro...";
            this.menuItem_palExport_tlp.Click += new System.EventHandler(this.menuItem_palExport_tlp_Click);
            // 
            // menuItem_palExport_yychr
            // 
            this.menuItem_palExport_yychr.Name = "menuItem_palExport_yychr";
            this.menuItem_palExport_yychr.Size = new System.Drawing.Size(153, 22);
            this.menuItem_palExport_yychr.Text = "YY-CHR...";
            this.menuItem_palExport_yychr.Click += new System.EventHandler(this.menuItem_palExport_yychr_Click);
            // 
            // gfxView_gfx
            // 
            this.gfxView_gfx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gfxView_gfx.Location = new System.Drawing.Point(0, 0);
            this.gfxView_gfx.Name = "gfxView_gfx";
            this.gfxView_gfx.Size = new System.Drawing.Size(532, 160);
            this.gfxView_gfx.TabIndex = 0;
            this.gfxView_gfx.TabStop = false;
            this.gfxView_gfx.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gfxView_gfx_MouseMove);
            // 
            // FormGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 333);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.groupBox_paletteControl);
            this.Controls.Add(this.groupBox_image);
            this.Controls.Add(this.groupBox_imageControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(528, 343);
            this.Name = "FormGraphics";
            this.Text = "Graphics Editor";
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