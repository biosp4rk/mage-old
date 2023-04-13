namespace mage
{
    partial class FormTileTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTileTable));
            this.button_apply = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.comboBox_bg = new System.Windows.Forms.ComboBox();
            this.label_tileset = new System.Windows.Forms.Label();
            this.comboBox_tileset = new System.Windows.Forms.ComboBox();
            this.label_size = new System.Windows.Forms.Label();
            this.comboBox_room = new System.Windows.Forms.ComboBox();
            this.comboBox_area = new System.Windows.Forms.ComboBox();
            this.panel_result = new System.Windows.Forms.Panel();
            this.gfxView_result = new mage.GfxView();
            this.panel_gfx = new System.Windows.Forms.Panel();
            this.gfxView_gfx = new mage.GfxView();
            this.button_hflipTL = new System.Windows.Forms.Button();
            this.button_hflipTR = new System.Windows.Forms.Button();
            this.button_hflipBR = new System.Windows.Forms.Button();
            this.button_hflipBL = new System.Windows.Forms.Button();
            this.button_vflipTR = new System.Windows.Forms.Button();
            this.button_vflipBR = new System.Windows.Forms.Button();
            this.button_vflipBL = new System.Windows.Forms.Button();
            this.button_vflipTL = new System.Windows.Forms.Button();
            this.button_palTR = new System.Windows.Forms.Button();
            this.button_palTL = new System.Windows.Forms.Button();
            this.button_palBL = new System.Windows.Forms.Button();
            this.button_palBR = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_tileset = new System.Windows.Forms.TabPage();
            this.label_height = new System.Windows.Forms.Label();
            this.numericUpDown_height = new System.Windows.Forms.NumericUpDown();
            this.tabPage_background = new System.Windows.Forms.TabPage();
            this.label_bg = new System.Windows.Forms.Label();
            this.label_room = new System.Windows.Forms.Label();
            this.label_area = new System.Windows.Forms.Label();
            this.comboBox_size = new System.Windows.Forms.ComboBox();
            this.tabPage_offset = new System.Windows.Forms.TabPage();
            this.numericUpDown_shift = new System.Windows.Forms.NumericUpDown();
            this.button_go = new System.Windows.Forms.Button();
            this.textBox_pal = new System.Windows.Forms.TextBox();
            this.textBox_gfx = new System.Windows.Forms.TextBox();
            this.textBox_ttb = new System.Windows.Forms.TextBox();
            this.label_palette = new System.Windows.Forms.Label();
            this.label_graphics = new System.Windows.Forms.Label();
            this.label_tileTable = new System.Windows.Forms.Label();
            this.label_shift = new System.Windows.Forms.Label();
            this.label_pal = new System.Windows.Forms.Label();
            this.comboBox_palette = new System.Windows.Forms.ComboBox();
            this.checkBox_copyPalette = new System.Windows.Forms.CheckBox();
            this.label_tileTL = new System.Windows.Forms.Label();
            this.label_tileBL = new System.Windows.Forms.Label();
            this.label_tileTR = new System.Windows.Forms.Label();
            this.label_tileBR = new System.Windows.Forms.Label();
            this.panel_text = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel_tile = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel_changes = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip_spring = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip_import = new System.Windows.Forms.ToolStripDropDownButton();
            this.statusStrip_importTileTable = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_export = new System.Windows.Forms.ToolStripDropDownButton();
            this.statusStrip_exportTileTable = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox_preserveData = new System.Windows.Forms.CheckBox();
            this.gfxView_tile = new mage.GfxView();
            this.panel_result.SuspendLayout();
            this.panel_gfx.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage_tileset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_height)).BeginInit();
            this.tabPage_background.SuspendLayout();
            this.tabPage_offset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_shift)).BeginInit();
            this.panel_text.SuspendLayout();
            this.statusStrip.SuspendLayout();
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
            // comboBox_bg
            // 
            resources.ApplyResources(this.comboBox_bg, "comboBox_bg");
            this.comboBox_bg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_bg.FormattingEnabled = true;
            this.comboBox_bg.Items.AddRange(new object[] {
            resources.GetString("comboBox_bg.Items"),
            resources.GetString("comboBox_bg.Items1")});
            this.comboBox_bg.Name = "comboBox_bg";
            this.comboBox_bg.SelectedIndexChanged += new System.EventHandler(this.comboBox_bg_SelectedIndexChanged);
            // 
            // label_tileset
            // 
            resources.ApplyResources(this.label_tileset, "label_tileset");
            this.label_tileset.Name = "label_tileset";
            // 
            // comboBox_tileset
            // 
            resources.ApplyResources(this.comboBox_tileset, "comboBox_tileset");
            this.comboBox_tileset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tileset.FormattingEnabled = true;
            this.comboBox_tileset.Name = "comboBox_tileset";
            this.comboBox_tileset.SelectedIndexChanged += new System.EventHandler(this.comboBox_tileset_SelectedIndexChanged);
            // 
            // label_size
            // 
            resources.ApplyResources(this.label_size, "label_size");
            this.label_size.Name = "label_size";
            // 
            // comboBox_room
            // 
            resources.ApplyResources(this.comboBox_room, "comboBox_room");
            this.comboBox_room.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_room.FormattingEnabled = true;
            this.comboBox_room.Name = "comboBox_room";
            this.comboBox_room.SelectedIndexChanged += new System.EventHandler(this.comboBox_bg_SelectedIndexChanged);
            // 
            // comboBox_area
            // 
            resources.ApplyResources(this.comboBox_area, "comboBox_area");
            this.comboBox_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_area.FormattingEnabled = true;
            this.comboBox_area.Name = "comboBox_area";
            this.comboBox_area.SelectedIndexChanged += new System.EventHandler(this.comboBox_area_SelectedIndexChanged);
            // 
            // panel_result
            // 
            resources.ApplyResources(this.panel_result, "panel_result");
            this.panel_result.Controls.Add(this.gfxView_result);
            this.panel_result.Name = "panel_result";
            // 
            // gfxView_result
            // 
            resources.ApplyResources(this.gfxView_result, "gfxView_result");
            this.gfxView_result.Name = "gfxView_result";
            this.gfxView_result.TabStop = false;
            this.gfxView_result.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gfxView_result_MouseDown);
            this.gfxView_result.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gfxView_result_MouseMove);
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
            this.gfxView_gfx.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gfxView_gfx_MouseDown);
            this.gfxView_gfx.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gfxView_gfx_MouseMove);
            // 
            // button_hflipTL
            // 
            resources.ApplyResources(this.button_hflipTL, "button_hflipTL");
            this.button_hflipTL.Name = "button_hflipTL";
            this.button_hflipTL.UseVisualStyleBackColor = true;
            this.button_hflipTL.Click += new System.EventHandler(this.button_hflip_Click);
            // 
            // button_hflipTR
            // 
            resources.ApplyResources(this.button_hflipTR, "button_hflipTR");
            this.button_hflipTR.Name = "button_hflipTR";
            this.button_hflipTR.UseVisualStyleBackColor = true;
            this.button_hflipTR.Click += new System.EventHandler(this.button_hflip_Click);
            // 
            // button_hflipBR
            // 
            resources.ApplyResources(this.button_hflipBR, "button_hflipBR");
            this.button_hflipBR.Name = "button_hflipBR";
            this.button_hflipBR.UseVisualStyleBackColor = true;
            this.button_hflipBR.Click += new System.EventHandler(this.button_hflip_Click);
            // 
            // button_hflipBL
            // 
            resources.ApplyResources(this.button_hflipBL, "button_hflipBL");
            this.button_hflipBL.Name = "button_hflipBL";
            this.button_hflipBL.UseVisualStyleBackColor = true;
            this.button_hflipBL.Click += new System.EventHandler(this.button_hflip_Click);
            // 
            // button_vflipTR
            // 
            resources.ApplyResources(this.button_vflipTR, "button_vflipTR");
            this.button_vflipTR.Name = "button_vflipTR";
            this.button_vflipTR.UseVisualStyleBackColor = true;
            this.button_vflipTR.Click += new System.EventHandler(this.button_vflip_Click);
            // 
            // button_vflipBR
            // 
            resources.ApplyResources(this.button_vflipBR, "button_vflipBR");
            this.button_vflipBR.Name = "button_vflipBR";
            this.button_vflipBR.UseVisualStyleBackColor = true;
            this.button_vflipBR.Click += new System.EventHandler(this.button_vflip_Click);
            // 
            // button_vflipBL
            // 
            resources.ApplyResources(this.button_vflipBL, "button_vflipBL");
            this.button_vflipBL.Name = "button_vflipBL";
            this.button_vflipBL.UseVisualStyleBackColor = true;
            this.button_vflipBL.Click += new System.EventHandler(this.button_vflip_Click);
            // 
            // button_vflipTL
            // 
            resources.ApplyResources(this.button_vflipTL, "button_vflipTL");
            this.button_vflipTL.Name = "button_vflipTL";
            this.button_vflipTL.UseVisualStyleBackColor = true;
            this.button_vflipTL.Click += new System.EventHandler(this.button_vflip_Click);
            // 
            // button_palTR
            // 
            resources.ApplyResources(this.button_palTR, "button_palTR");
            this.button_palTR.Name = "button_palTR";
            this.button_palTR.UseVisualStyleBackColor = true;
            this.button_palTR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_pal_MouseUp);
            // 
            // button_palTL
            // 
            resources.ApplyResources(this.button_palTL, "button_palTL");
            this.button_palTL.Name = "button_palTL";
            this.button_palTL.UseVisualStyleBackColor = true;
            this.button_palTL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_pal_MouseUp);
            // 
            // button_palBL
            // 
            resources.ApplyResources(this.button_palBL, "button_palBL");
            this.button_palBL.Name = "button_palBL";
            this.button_palBL.UseVisualStyleBackColor = true;
            this.button_palBL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_pal_MouseUp);
            // 
            // button_palBR
            // 
            resources.ApplyResources(this.button_palBR, "button_palBR");
            this.button_palBR.Name = "button_palBR";
            this.button_palBR.UseVisualStyleBackColor = true;
            this.button_palBR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_pal_MouseUp);
            // 
            // tabControl
            // 
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Controls.Add(this.tabPage_tileset);
            this.tabControl.Controls.Add(this.tabPage_background);
            this.tabControl.Controls.Add(this.tabPage_offset);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage_tileset
            // 
            resources.ApplyResources(this.tabPage_tileset, "tabPage_tileset");
            this.tabPage_tileset.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_tileset.Controls.Add(this.label_height);
            this.tabPage_tileset.Controls.Add(this.numericUpDown_height);
            this.tabPage_tileset.Controls.Add(this.comboBox_tileset);
            this.tabPage_tileset.Controls.Add(this.label_tileset);
            this.tabPage_tileset.Name = "tabPage_tileset";
            // 
            // label_height
            // 
            resources.ApplyResources(this.label_height, "label_height");
            this.label_height.Name = "label_height";
            // 
            // numericUpDown_height
            // 
            resources.ApplyResources(this.numericUpDown_height, "numericUpDown_height");
            this.numericUpDown_height.Hexadecimal = true;
            this.numericUpDown_height.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numericUpDown_height.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_height.Name = "numericUpDown_height";
            this.numericUpDown_height.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_height.ValueChanged += new System.EventHandler(this.numericUpDown_height_ValueChanged);
            // 
            // tabPage_background
            // 
            resources.ApplyResources(this.tabPage_background, "tabPage_background");
            this.tabPage_background.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_background.Controls.Add(this.label_bg);
            this.tabPage_background.Controls.Add(this.label_room);
            this.tabPage_background.Controls.Add(this.label_area);
            this.tabPage_background.Controls.Add(this.comboBox_size);
            this.tabPage_background.Controls.Add(this.comboBox_bg);
            this.tabPage_background.Controls.Add(this.comboBox_area);
            this.tabPage_background.Controls.Add(this.comboBox_room);
            this.tabPage_background.Controls.Add(this.label_size);
            this.tabPage_background.Name = "tabPage_background";
            // 
            // label_bg
            // 
            resources.ApplyResources(this.label_bg, "label_bg");
            this.label_bg.Name = "label_bg";
            // 
            // label_room
            // 
            resources.ApplyResources(this.label_room, "label_room");
            this.label_room.Name = "label_room";
            // 
            // label_area
            // 
            resources.ApplyResources(this.label_area, "label_area");
            this.label_area.Name = "label_area";
            // 
            // comboBox_size
            // 
            resources.ApplyResources(this.comboBox_size, "comboBox_size");
            this.comboBox_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_size.FormattingEnabled = true;
            this.comboBox_size.Items.AddRange(new object[] {
            resources.GetString("comboBox_size.Items"),
            resources.GetString("comboBox_size.Items1"),
            resources.GetString("comboBox_size.Items2")});
            this.comboBox_size.Name = "comboBox_size";
            this.comboBox_size.SelectedIndexChanged += new System.EventHandler(this.comboBox_size_SelectedIndexChanged);
            // 
            // tabPage_offset
            // 
            resources.ApplyResources(this.tabPage_offset, "tabPage_offset");
            this.tabPage_offset.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_offset.Controls.Add(this.numericUpDown_shift);
            this.tabPage_offset.Controls.Add(this.button_go);
            this.tabPage_offset.Controls.Add(this.textBox_pal);
            this.tabPage_offset.Controls.Add(this.textBox_gfx);
            this.tabPage_offset.Controls.Add(this.textBox_ttb);
            this.tabPage_offset.Controls.Add(this.label_palette);
            this.tabPage_offset.Controls.Add(this.label_graphics);
            this.tabPage_offset.Controls.Add(this.label_tileTable);
            this.tabPage_offset.Controls.Add(this.label_shift);
            this.tabPage_offset.Name = "tabPage_offset";
            // 
            // numericUpDown_shift
            // 
            resources.ApplyResources(this.numericUpDown_shift, "numericUpDown_shift");
            this.numericUpDown_shift.Hexadecimal = true;
            this.numericUpDown_shift.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numericUpDown_shift.Name = "numericUpDown_shift";
            // 
            // button_go
            // 
            resources.ApplyResources(this.button_go, "button_go");
            this.button_go.Name = "button_go";
            this.button_go.UseVisualStyleBackColor = true;
            this.button_go.Click += new System.EventHandler(this.button_go_Click);
            // 
            // textBox_pal
            // 
            resources.ApplyResources(this.textBox_pal, "textBox_pal");
            this.textBox_pal.Name = "textBox_pal";
            // 
            // textBox_gfx
            // 
            resources.ApplyResources(this.textBox_gfx, "textBox_gfx");
            this.textBox_gfx.Name = "textBox_gfx";
            // 
            // textBox_ttb
            // 
            resources.ApplyResources(this.textBox_ttb, "textBox_ttb");
            this.textBox_ttb.Name = "textBox_ttb";
            // 
            // label_palette
            // 
            resources.ApplyResources(this.label_palette, "label_palette");
            this.label_palette.Name = "label_palette";
            // 
            // label_graphics
            // 
            resources.ApplyResources(this.label_graphics, "label_graphics");
            this.label_graphics.Name = "label_graphics";
            // 
            // label_tileTable
            // 
            resources.ApplyResources(this.label_tileTable, "label_tileTable");
            this.label_tileTable.Name = "label_tileTable";
            // 
            // label_shift
            // 
            resources.ApplyResources(this.label_shift, "label_shift");
            this.label_shift.Name = "label_shift";
            // 
            // label_pal
            // 
            resources.ApplyResources(this.label_pal, "label_pal");
            this.label_pal.Name = "label_pal";
            // 
            // comboBox_palette
            // 
            resources.ApplyResources(this.comboBox_palette, "comboBox_palette");
            this.comboBox_palette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_palette.FormattingEnabled = true;
            this.comboBox_palette.Name = "comboBox_palette";
            this.comboBox_palette.SelectedIndexChanged += new System.EventHandler(this.comboBox_palette_SelectedIndexChanged);
            // 
            // checkBox_copyPalette
            // 
            resources.ApplyResources(this.checkBox_copyPalette, "checkBox_copyPalette");
            this.checkBox_copyPalette.Name = "checkBox_copyPalette";
            this.checkBox_copyPalette.UseVisualStyleBackColor = true;
            // 
            // label_tileTL
            // 
            resources.ApplyResources(this.label_tileTL, "label_tileTL");
            this.label_tileTL.Name = "label_tileTL";
            // 
            // label_tileBL
            // 
            resources.ApplyResources(this.label_tileBL, "label_tileBL");
            this.label_tileBL.Name = "label_tileBL";
            // 
            // label_tileTR
            // 
            resources.ApplyResources(this.label_tileTR, "label_tileTR");
            this.label_tileTR.Name = "label_tileTR";
            // 
            // label_tileBR
            // 
            resources.ApplyResources(this.label_tileBR, "label_tileBR");
            this.label_tileBR.Name = "label_tileBR";
            // 
            // panel_text
            // 
            resources.ApplyResources(this.panel_text, "panel_text");
            this.panel_text.Controls.Add(this.label_tileTL);
            this.panel_text.Controls.Add(this.label_tileBL);
            this.panel_text.Name = "panel_text";
            // 
            // statusStrip
            // 
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_tile,
            this.statusLabel_changes,
            this.statusStrip_spring,
            this.statusStrip_import,
            this.statusStrip_export});
            this.statusStrip.Name = "statusStrip";
            // 
            // statusLabel_tile
            // 
            resources.ApplyResources(this.statusLabel_tile, "statusLabel_tile");
            this.statusLabel_tile.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.statusLabel_tile.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.statusLabel_tile.Name = "statusLabel_tile";
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
            this.statusStrip_importTileTable});
            this.statusStrip_import.Name = "statusStrip_import";
            // 
            // statusStrip_importTileTable
            // 
            resources.ApplyResources(this.statusStrip_importTileTable, "statusStrip_importTileTable");
            this.statusStrip_importTileTable.Name = "statusStrip_importTileTable";
            this.statusStrip_importTileTable.Click += new System.EventHandler(this.statusStrip_importTileTable_Click);
            // 
            // statusStrip_export
            // 
            resources.ApplyResources(this.statusStrip_export, "statusStrip_export");
            this.statusStrip_export.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusStrip_export.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip_exportTileTable});
            this.statusStrip_export.Name = "statusStrip_export";
            // 
            // statusStrip_exportTileTable
            // 
            resources.ApplyResources(this.statusStrip_exportTileTable, "statusStrip_exportTileTable");
            this.statusStrip_exportTileTable.Name = "statusStrip_exportTileTable";
            this.statusStrip_exportTileTable.Click += new System.EventHandler(this.statusStrip_exportTileTable_Click);
            // 
            // checkBox_preserveData
            // 
            resources.ApplyResources(this.checkBox_preserveData, "checkBox_preserveData");
            this.checkBox_preserveData.Name = "checkBox_preserveData";
            this.checkBox_preserveData.UseVisualStyleBackColor = true;
            // 
            // gfxView_tile
            // 
            resources.ApplyResources(this.gfxView_tile, "gfxView_tile");
            this.gfxView_tile.Name = "gfxView_tile";
            this.gfxView_tile.TabStop = false;
            this.gfxView_tile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gfxView_tile_MouseDown);
            // 
            // FormTileTable
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox_preserveData);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panel_text);
            this.Controls.Add(this.label_tileBR);
            this.Controls.Add(this.label_tileTR);
            this.Controls.Add(this.checkBox_copyPalette);
            this.Controls.Add(this.comboBox_palette);
            this.Controls.Add(this.label_pal);
            this.Controls.Add(this.gfxView_tile);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.button_palBR);
            this.Controls.Add(this.button_palBL);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_palTL);
            this.Controls.Add(this.button_palTR);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.button_vflipBL);
            this.Controls.Add(this.button_vflipTL);
            this.Controls.Add(this.button_vflipBR);
            this.Controls.Add(this.button_vflipTR);
            this.Controls.Add(this.button_hflipBR);
            this.Controls.Add(this.button_hflipBL);
            this.Controls.Add(this.button_hflipTR);
            this.Controls.Add(this.button_hflipTL);
            this.Controls.Add(this.panel_gfx);
            this.Controls.Add(this.panel_result);
            this.Name = "FormTileTable";
            this.panel_result.ResumeLayout(false);
            this.panel_gfx.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage_tileset.ResumeLayout(false);
            this.tabPage_tileset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_height)).EndInit();
            this.tabPage_background.ResumeLayout(false);
            this.tabPage_background.PerformLayout();
            this.tabPage_offset.ResumeLayout(false);
            this.tabPage_offset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_shift)).EndInit();
            this.panel_text.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_size;
        private System.Windows.Forms.ComboBox comboBox_room;
        private System.Windows.Forms.ComboBox comboBox_area;
        private System.Windows.Forms.Label label_tileset;
        private System.Windows.Forms.ComboBox comboBox_tileset;
        private System.Windows.Forms.Panel panel_result;
        private System.Windows.Forms.Panel panel_gfx;
        private System.Windows.Forms.ComboBox comboBox_bg;
        private System.Windows.Forms.Button button_hflipTL;
        private System.Windows.Forms.Button button_hflipTR;
        private System.Windows.Forms.Button button_hflipBR;
        private System.Windows.Forms.Button button_hflipBL;
        private System.Windows.Forms.Button button_vflipTR;
        private System.Windows.Forms.Button button_vflipBR;
        private System.Windows.Forms.Button button_vflipBL;
        private System.Windows.Forms.Button button_vflipTL;
        private System.Windows.Forms.Button button_palTR;
        private System.Windows.Forms.Button button_palTL;
        private System.Windows.Forms.Button button_palBL;
        private System.Windows.Forms.Button button_palBR;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_background;
        private System.Windows.Forms.TabPage tabPage_tileset;
        private System.Windows.Forms.ComboBox comboBox_size;
        private System.Windows.Forms.Label label_height;
        private System.Windows.Forms.NumericUpDown numericUpDown_height;
        private System.Windows.Forms.TabPage tabPage_offset;
        private System.Windows.Forms.Label label_palette;
        private System.Windows.Forms.Label label_graphics;
        private System.Windows.Forms.Label label_tileTable;
        private System.Windows.Forms.TextBox textBox_pal;
        private System.Windows.Forms.TextBox textBox_gfx;
        private System.Windows.Forms.TextBox textBox_ttb;
        private System.Windows.Forms.Button button_go;
        private System.Windows.Forms.Label label_bg;
        private System.Windows.Forms.Label label_room;
        private System.Windows.Forms.Label label_area;
        private GfxView gfxView_gfx;
        private GfxView gfxView_tile;
        private GfxView gfxView_result;
        private System.Windows.Forms.Label label_pal;
        private System.Windows.Forms.ComboBox comboBox_palette;
        private System.Windows.Forms.CheckBox checkBox_copyPalette;
        private System.Windows.Forms.Label label_tileTL;
        private System.Windows.Forms.Label label_tileBL;
        private System.Windows.Forms.Label label_tileTR;
        private System.Windows.Forms.Label label_tileBR;
        private System.Windows.Forms.Panel panel_text;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_tile;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_changes;
        private System.Windows.Forms.CheckBox checkBox_preserveData;
        private System.Windows.Forms.NumericUpDown numericUpDown_shift;
        private System.Windows.Forms.Label label_shift;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip_spring;
        private System.Windows.Forms.ToolStripDropDownButton statusStrip_import;
        private System.Windows.Forms.ToolStripDropDownButton statusStrip_export;
        private System.Windows.Forms.ToolStripMenuItem statusStrip_importTileTable;
        private System.Windows.Forms.ToolStripMenuItem statusStrip_exportTileTable;
    }
}