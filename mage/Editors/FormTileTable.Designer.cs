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
            this.comboBox_bg = new mage.Theming.CustomControls.FlatComboBox();
            this.label_tileset = new System.Windows.Forms.Label();
            this.comboBox_tileset = new mage.Theming.CustomControls.FlatComboBox();
            this.label_size = new System.Windows.Forms.Label();
            this.comboBox_room = new mage.Theming.CustomControls.FlatComboBox();
            this.comboBox_area = new mage.Theming.CustomControls.FlatComboBox();
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
            this.tabControl = new mage.Theming.CustomControls.FlatTabControl();
            this.tabPage_tileset = new System.Windows.Forms.TabPage();
            this.label_height = new System.Windows.Forms.Label();
            this.numericUpDown_height = new mage.Theming.CustomControls.FlatNumericUpDown();
            this.tabPage_background = new System.Windows.Forms.TabPage();
            this.label_bg = new System.Windows.Forms.Label();
            this.label_room = new System.Windows.Forms.Label();
            this.label_area = new System.Windows.Forms.Label();
            this.comboBox_size = new mage.Theming.CustomControls.FlatComboBox();
            this.tabPage_offset = new System.Windows.Forms.TabPage();
            this.label_shift = new System.Windows.Forms.Label();
            this.numericUpDown_shift = new mage.Theming.CustomControls.FlatNumericUpDown();
            this.button_go = new System.Windows.Forms.Button();
            this.textBox_pal = new mage.Theming.CustomControls.FlatTextBox();
            this.textBox_gfx = new mage.Theming.CustomControls.FlatTextBox();
            this.textBox_ttb = new mage.Theming.CustomControls.FlatTextBox();
            this.label_palette = new System.Windows.Forms.Label();
            this.label_graphics = new System.Windows.Forms.Label();
            this.label_tileTable = new System.Windows.Forms.Label();
            this.label_pal = new System.Windows.Forms.Label();
            this.comboBox_palette = new mage.Theming.CustomControls.FlatComboBox();
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
            this.statusStrip_export = new System.Windows.Forms.ToolStripDropDownButton();
            this.checkBox_preserveData = new System.Windows.Forms.CheckBox();
            this.gfxView_tile = new mage.GfxView();
            this.statusStrip_importTileTable = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_exportTileTable = new System.Windows.Forms.ToolStripMenuItem();
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
            this.button_apply.Enabled = false;
            this.button_apply.Location = new System.Drawing.Point(226, 60);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(70, 23);
            this.button_apply.TabIndex = 2;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(226, 89);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(70, 23);
            this.button_close.TabIndex = 3;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // comboBox_bg
            // 
            this.comboBox_bg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_bg.FormattingEnabled = true;
            this.comboBox_bg.Items.AddRange(new object[] {
            "BG0",
            "BG3"});
            this.comboBox_bg.Location = new System.Drawing.Point(142, 19);
            this.comboBox_bg.Name = "comboBox_bg";
            this.comboBox_bg.Size = new System.Drawing.Size(45, 21);
            this.comboBox_bg.TabIndex = 8;
            this.comboBox_bg.SelectedIndexChanged += new System.EventHandler(this.comboBox_bg_SelectedIndexChanged);
            // 
            // label_tileset
            // 
            this.label_tileset.AutoSize = true;
            this.label_tileset.Location = new System.Drawing.Point(6, 14);
            this.label_tileset.Name = "label_tileset";
            this.label_tileset.Size = new System.Drawing.Size(41, 13);
            this.label_tileset.TabIndex = 6;
            this.label_tileset.Text = "Tileset:";
            // 
            // comboBox_tileset
            // 
            this.comboBox_tileset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tileset.FormattingEnabled = true;
            this.comboBox_tileset.Location = new System.Drawing.Point(53, 11);
            this.comboBox_tileset.Name = "comboBox_tileset";
            this.comboBox_tileset.Size = new System.Drawing.Size(45, 21);
            this.comboBox_tileset.TabIndex = 7;
            this.comboBox_tileset.SelectedIndexChanged += new System.EventHandler(this.comboBox_tileset_SelectedIndexChanged);
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.Location = new System.Drawing.Point(6, 50);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(30, 13);
            this.label_size.TabIndex = 0;
            this.label_size.Text = "Size:";
            // 
            // comboBox_room
            // 
            this.comboBox_room.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_room.FormattingEnabled = true;
            this.comboBox_room.Location = new System.Drawing.Point(91, 19);
            this.comboBox_room.Name = "comboBox_room";
            this.comboBox_room.Size = new System.Drawing.Size(45, 21);
            this.comboBox_room.TabIndex = 1;
            this.comboBox_room.SelectedIndexChanged += new System.EventHandler(this.comboBox_bg_SelectedIndexChanged);
            // 
            // comboBox_area
            // 
            this.comboBox_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_area.FormattingEnabled = true;
            this.comboBox_area.Location = new System.Drawing.Point(8, 19);
            this.comboBox_area.Name = "comboBox_area";
            this.comboBox_area.Size = new System.Drawing.Size(77, 21);
            this.comboBox_area.TabIndex = 0;
            this.comboBox_area.SelectedIndexChanged += new System.EventHandler(this.comboBox_area_SelectedIndexChanged);
            // 
            // panel_result
            // 
            this.panel_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_result.AutoScroll = true;
            this.panel_result.Controls.Add(this.gfxView_result);
            this.panel_result.Location = new System.Drawing.Point(547, 12);
            this.panel_result.Name = "panel_result";
            this.panel_result.Size = new System.Drawing.Size(273, 406);
            this.panel_result.TabIndex = 9;
            // 
            // gfxView_result
            // 
            this.gfxView_result.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gfxView_result.Location = new System.Drawing.Point(0, 0);
            this.gfxView_result.Name = "gfxView_result";
            this.gfxView_result.Size = new System.Drawing.Size(256, 389);
            this.gfxView_result.TabIndex = 0;
            this.gfxView_result.TabStop = false;
            this.gfxView_result.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gfxView_result_MouseDown);
            this.gfxView_result.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gfxView_result_MouseMove);
            // 
            // panel_gfx
            // 
            this.panel_gfx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_gfx.AutoScroll = true;
            this.panel_gfx.Controls.Add(this.gfxView_gfx);
            this.panel_gfx.Location = new System.Drawing.Point(12, 145);
            this.panel_gfx.Name = "panel_gfx";
            this.panel_gfx.Size = new System.Drawing.Size(529, 273);
            this.panel_gfx.TabIndex = 10;
            // 
            // gfxView_gfx
            // 
            this.gfxView_gfx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gfxView_gfx.Location = new System.Drawing.Point(0, 0);
            this.gfxView_gfx.Name = "gfxView_gfx";
            this.gfxView_gfx.Size = new System.Drawing.Size(512, 256);
            this.gfxView_gfx.TabIndex = 0;
            this.gfxView_gfx.TabStop = false;
            this.gfxView_gfx.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gfxView_gfx_MouseDown);
            this.gfxView_gfx.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gfxView_gfx_MouseMove);
            // 
            // button_hflipTL
            // 
            this.button_hflipTL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_hflipTL.Location = new System.Drawing.Point(380, 12);
            this.button_hflipTL.Margin = new System.Windows.Forms.Padding(0);
            this.button_hflipTL.Name = "button_hflipTL";
            this.button_hflipTL.Size = new System.Drawing.Size(40, 20);
            this.button_hflipTL.TabIndex = 12;
            this.button_hflipTL.UseVisualStyleBackColor = true;
            this.button_hflipTL.Click += new System.EventHandler(this.button_hflip_Click);
            // 
            // button_hflipTR
            // 
            this.button_hflipTR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_hflipTR.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hflipTR.Location = new System.Drawing.Point(420, 12);
            this.button_hflipTR.Margin = new System.Windows.Forms.Padding(0);
            this.button_hflipTR.Name = "button_hflipTR";
            this.button_hflipTR.Size = new System.Drawing.Size(40, 20);
            this.button_hflipTR.TabIndex = 13;
            this.button_hflipTR.UseVisualStyleBackColor = true;
            this.button_hflipTR.Click += new System.EventHandler(this.button_hflip_Click);
            // 
            // button_hflipBR
            // 
            this.button_hflipBR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_hflipBR.Location = new System.Drawing.Point(420, 112);
            this.button_hflipBR.Margin = new System.Windows.Forms.Padding(0);
            this.button_hflipBR.Name = "button_hflipBR";
            this.button_hflipBR.Size = new System.Drawing.Size(40, 20);
            this.button_hflipBR.TabIndex = 15;
            this.button_hflipBR.UseVisualStyleBackColor = true;
            this.button_hflipBR.Click += new System.EventHandler(this.button_hflip_Click);
            // 
            // button_hflipBL
            // 
            this.button_hflipBL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_hflipBL.Location = new System.Drawing.Point(380, 112);
            this.button_hflipBL.Margin = new System.Windows.Forms.Padding(0);
            this.button_hflipBL.Name = "button_hflipBL";
            this.button_hflipBL.Size = new System.Drawing.Size(40, 20);
            this.button_hflipBL.TabIndex = 14;
            this.button_hflipBL.UseVisualStyleBackColor = true;
            this.button_hflipBL.Click += new System.EventHandler(this.button_hflip_Click);
            // 
            // button_vflipTR
            // 
            this.button_vflipTR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_vflipTR.Location = new System.Drawing.Point(460, 32);
            this.button_vflipTR.Margin = new System.Windows.Forms.Padding(0);
            this.button_vflipTR.Name = "button_vflipTR";
            this.button_vflipTR.Size = new System.Drawing.Size(20, 40);
            this.button_vflipTR.TabIndex = 16;
            this.button_vflipTR.UseVisualStyleBackColor = true;
            this.button_vflipTR.Click += new System.EventHandler(this.button_vflip_Click);
            // 
            // button_vflipBR
            // 
            this.button_vflipBR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_vflipBR.Location = new System.Drawing.Point(460, 72);
            this.button_vflipBR.Margin = new System.Windows.Forms.Padding(0);
            this.button_vflipBR.Name = "button_vflipBR";
            this.button_vflipBR.Size = new System.Drawing.Size(20, 40);
            this.button_vflipBR.TabIndex = 17;
            this.button_vflipBR.UseVisualStyleBackColor = true;
            this.button_vflipBR.Click += new System.EventHandler(this.button_vflip_Click);
            // 
            // button_vflipBL
            // 
            this.button_vflipBL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_vflipBL.Location = new System.Drawing.Point(360, 72);
            this.button_vflipBL.Margin = new System.Windows.Forms.Padding(0);
            this.button_vflipBL.Name = "button_vflipBL";
            this.button_vflipBL.Size = new System.Drawing.Size(20, 40);
            this.button_vflipBL.TabIndex = 19;
            this.button_vflipBL.UseVisualStyleBackColor = true;
            this.button_vflipBL.Click += new System.EventHandler(this.button_vflip_Click);
            // 
            // button_vflipTL
            // 
            this.button_vflipTL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_vflipTL.Location = new System.Drawing.Point(360, 32);
            this.button_vflipTL.Margin = new System.Windows.Forms.Padding(0);
            this.button_vflipTL.Name = "button_vflipTL";
            this.button_vflipTL.Size = new System.Drawing.Size(20, 40);
            this.button_vflipTL.TabIndex = 18;
            this.button_vflipTL.UseVisualStyleBackColor = true;
            this.button_vflipTL.Click += new System.EventHandler(this.button_vflip_Click);
            // 
            // button_palTR
            // 
            this.button_palTR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_palTR.Location = new System.Drawing.Point(460, 12);
            this.button_palTR.Margin = new System.Windows.Forms.Padding(0);
            this.button_palTR.Name = "button_palTR";
            this.button_palTR.Size = new System.Drawing.Size(20, 20);
            this.button_palTR.TabIndex = 20;
            this.button_palTR.UseVisualStyleBackColor = true;
            this.button_palTR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_pal_MouseUp);
            // 
            // button_palTL
            // 
            this.button_palTL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_palTL.Location = new System.Drawing.Point(360, 12);
            this.button_palTL.Margin = new System.Windows.Forms.Padding(0);
            this.button_palTL.Name = "button_palTL";
            this.button_palTL.Size = new System.Drawing.Size(20, 20);
            this.button_palTL.TabIndex = 21;
            this.button_palTL.UseVisualStyleBackColor = true;
            this.button_palTL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_pal_MouseUp);
            // 
            // button_palBL
            // 
            this.button_palBL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_palBL.Location = new System.Drawing.Point(360, 112);
            this.button_palBL.Margin = new System.Windows.Forms.Padding(0);
            this.button_palBL.Name = "button_palBL";
            this.button_palBL.Size = new System.Drawing.Size(20, 20);
            this.button_palBL.TabIndex = 22;
            this.button_palBL.UseVisualStyleBackColor = true;
            this.button_palBL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_pal_MouseUp);
            // 
            // button_palBR
            // 
            this.button_palBR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_palBR.Location = new System.Drawing.Point(460, 112);
            this.button_palBR.Margin = new System.Windows.Forms.Padding(0);
            this.button_palBR.Name = "button_palBR";
            this.button_palBR.Size = new System.Drawing.Size(20, 20);
            this.button_palBR.TabIndex = 23;
            this.button_palBR.UseVisualStyleBackColor = true;
            this.button_palBR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_pal_MouseUp);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_tileset);
            this.tabControl.Controls.Add(this.tabPage_background);
            this.tabControl.Controls.Add(this.tabPage_offset);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(208, 100);
            this.tabControl.TabIndex = 24;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage_tileset
            // 
            this.tabPage_tileset.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_tileset.Controls.Add(this.label_height);
            this.tabPage_tileset.Controls.Add(this.numericUpDown_height);
            this.tabPage_tileset.Controls.Add(this.comboBox_tileset);
            this.tabPage_tileset.Controls.Add(this.label_tileset);
            this.tabPage_tileset.Location = new System.Drawing.Point(4, 22);
            this.tabPage_tileset.Name = "tabPage_tileset";
            this.tabPage_tileset.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_tileset.Size = new System.Drawing.Size(200, 74);
            this.tabPage_tileset.TabIndex = 1;
            this.tabPage_tileset.Text = "Tileset";
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.Location = new System.Drawing.Point(6, 42);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(41, 13);
            this.label_height.TabIndex = 9;
            this.label_height.Text = "Height:";
            // 
            // numericUpDown_height
            // 
            this.numericUpDown_height.Enabled = false;
            this.numericUpDown_height.Hexadecimal = true;
            this.numericUpDown_height.Location = new System.Drawing.Point(53, 40);
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
            this.numericUpDown_height.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown_height.TabIndex = 8;
            this.numericUpDown_height.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_height.ValueChanged += new System.EventHandler(this.numericUpDown_height_ValueChanged);
            // 
            // tabPage_background
            // 
            this.tabPage_background.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_background.Controls.Add(this.label_bg);
            this.tabPage_background.Controls.Add(this.label_room);
            this.tabPage_background.Controls.Add(this.label_area);
            this.tabPage_background.Controls.Add(this.comboBox_size);
            this.tabPage_background.Controls.Add(this.comboBox_bg);
            this.tabPage_background.Controls.Add(this.comboBox_area);
            this.tabPage_background.Controls.Add(this.comboBox_room);
            this.tabPage_background.Controls.Add(this.label_size);
            this.tabPage_background.Location = new System.Drawing.Point(4, 22);
            this.tabPage_background.Name = "tabPage_background";
            this.tabPage_background.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_background.Size = new System.Drawing.Size(200, 74);
            this.tabPage_background.TabIndex = 0;
            this.tabPage_background.Text = "Background";
            // 
            // label_bg
            // 
            this.label_bg.AutoSize = true;
            this.label_bg.Location = new System.Drawing.Point(139, 3);
            this.label_bg.Name = "label_bg";
            this.label_bg.Size = new System.Drawing.Size(25, 13);
            this.label_bg.TabIndex = 12;
            this.label_bg.Text = "BG:";
            // 
            // label_room
            // 
            this.label_room.AutoSize = true;
            this.label_room.Location = new System.Drawing.Point(88, 3);
            this.label_room.Name = "label_room";
            this.label_room.Size = new System.Drawing.Size(38, 13);
            this.label_room.TabIndex = 11;
            this.label_room.Text = "Room:";
            // 
            // label_area
            // 
            this.label_area.AutoSize = true;
            this.label_area.Location = new System.Drawing.Point(5, 3);
            this.label_area.Name = "label_area";
            this.label_area.Size = new System.Drawing.Size(32, 13);
            this.label_area.TabIndex = 10;
            this.label_area.Text = "Area:";
            // 
            // comboBox_size
            // 
            this.comboBox_size.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_size.Enabled = false;
            this.comboBox_size.FormattingEnabled = true;
            this.comboBox_size.Items.AddRange(new object[] {
            "256 x 256",
            "512 x 256",
            "256 x 512"});
            this.comboBox_size.Location = new System.Drawing.Point(42, 46);
            this.comboBox_size.Name = "comboBox_size";
            this.comboBox_size.Size = new System.Drawing.Size(75, 21);
            this.comboBox_size.TabIndex = 9;
            this.comboBox_size.SelectedIndexChanged += new System.EventHandler(this.comboBox_size_SelectedIndexChanged);
            // 
            // tabPage_offset
            // 
            this.tabPage_offset.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_offset.Controls.Add(this.label_shift);
            this.tabPage_offset.Controls.Add(this.numericUpDown_shift);
            this.tabPage_offset.Controls.Add(this.button_go);
            this.tabPage_offset.Controls.Add(this.textBox_pal);
            this.tabPage_offset.Controls.Add(this.textBox_gfx);
            this.tabPage_offset.Controls.Add(this.textBox_ttb);
            this.tabPage_offset.Controls.Add(this.label_palette);
            this.tabPage_offset.Controls.Add(this.label_graphics);
            this.tabPage_offset.Controls.Add(this.label_tileTable);
            this.tabPage_offset.Location = new System.Drawing.Point(4, 22);
            this.tabPage_offset.Name = "tabPage_offset";
            this.tabPage_offset.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_offset.Size = new System.Drawing.Size(200, 74);
            this.tabPage_offset.TabIndex = 2;
            this.tabPage_offset.Text = "Offset";
            // 
            // label_shift
            // 
            this.label_shift.AutoSize = true;
            this.label_shift.Location = new System.Drawing.Point(6, 48);
            this.label_shift.Name = "label_shift";
            this.label_shift.Size = new System.Drawing.Size(31, 13);
            this.label_shift.TabIndex = 10;
            this.label_shift.Text = "Shift:";
            // 
            // numericUpDown_shift
            // 
            this.numericUpDown_shift.Hexadecimal = true;
            this.numericUpDown_shift.Location = new System.Drawing.Point(43, 46);
            this.numericUpDown_shift.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numericUpDown_shift.Name = "numericUpDown_shift";
            this.numericUpDown_shift.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown_shift.TabIndex = 9;
            // 
            // button_go
            // 
            this.button_go.Location = new System.Drawing.Point(117, 45);
            this.button_go.Name = "button_go";
            this.button_go.Size = new System.Drawing.Size(75, 23);
            this.button_go.TabIndex = 6;
            this.button_go.Text = "Go";
            this.button_go.UseVisualStyleBackColor = true;
            this.button_go.Click += new System.EventHandler(this.button_go_Click);
            // 
            // textBox_pal
            // 
            this.textBox_pal.Location = new System.Drawing.Point(134, 19);
            this.textBox_pal.Name = "textBox_pal";
            this.textBox_pal.Size = new System.Drawing.Size(58, 20);
            this.textBox_pal.TabIndex = 5;
            // 
            // textBox_gfx
            // 
            this.textBox_gfx.Location = new System.Drawing.Point(70, 19);
            this.textBox_gfx.Name = "textBox_gfx";
            this.textBox_gfx.Size = new System.Drawing.Size(58, 20);
            this.textBox_gfx.TabIndex = 4;
            // 
            // textBox_ttb
            // 
            this.textBox_ttb.Location = new System.Drawing.Point(6, 19);
            this.textBox_ttb.Name = "textBox_ttb";
            this.textBox_ttb.Size = new System.Drawing.Size(58, 20);
            this.textBox_ttb.TabIndex = 3;
            // 
            // label_palette
            // 
            this.label_palette.AutoSize = true;
            this.label_palette.Location = new System.Drawing.Point(131, 3);
            this.label_palette.Name = "label_palette";
            this.label_palette.Size = new System.Drawing.Size(43, 13);
            this.label_palette.TabIndex = 2;
            this.label_palette.Text = "Palette:";
            // 
            // label_graphics
            // 
            this.label_graphics.AutoSize = true;
            this.label_graphics.Location = new System.Drawing.Point(67, 3);
            this.label_graphics.Name = "label_graphics";
            this.label_graphics.Size = new System.Drawing.Size(52, 13);
            this.label_graphics.TabIndex = 1;
            this.label_graphics.Text = "Graphics:";
            // 
            // label_tileTable
            // 
            this.label_tileTable.AutoSize = true;
            this.label_tileTable.Location = new System.Drawing.Point(3, 3);
            this.label_tileTable.Name = "label_tileTable";
            this.label_tileTable.Size = new System.Drawing.Size(53, 13);
            this.label_tileTable.TabIndex = 0;
            this.label_tileTable.Text = "Tile table:";
            // 
            // label_pal
            // 
            this.label_pal.AutoSize = true;
            this.label_pal.Location = new System.Drawing.Point(13, 121);
            this.label_pal.Name = "label_pal";
            this.label_pal.Size = new System.Drawing.Size(43, 13);
            this.label_pal.TabIndex = 26;
            this.label_pal.Text = "Palette:";
            // 
            // comboBox_palette
            // 
            this.comboBox_palette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_palette.Enabled = false;
            this.comboBox_palette.FormattingEnabled = true;
            this.comboBox_palette.Location = new System.Drawing.Point(62, 118);
            this.comboBox_palette.Name = "comboBox_palette";
            this.comboBox_palette.Size = new System.Drawing.Size(40, 21);
            this.comboBox_palette.TabIndex = 27;
            this.comboBox_palette.SelectedIndexChanged += new System.EventHandler(this.comboBox_palette_SelectedIndexChanged);
            // 
            // checkBox_copyPalette
            // 
            this.checkBox_copyPalette.AutoSize = true;
            this.checkBox_copyPalette.Location = new System.Drawing.Point(125, 120);
            this.checkBox_copyPalette.Name = "checkBox_copyPalette";
            this.checkBox_copyPalette.Size = new System.Drawing.Size(95, 17);
            this.checkBox_copyPalette.TabIndex = 28;
            this.checkBox_copyPalette.Text = "Copy palette #";
            this.checkBox_copyPalette.UseVisualStyleBackColor = true;
            // 
            // label_tileTL
            // 
            this.label_tileTL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_tileTL.Location = new System.Drawing.Point(7, 14);
            this.label_tileTL.Name = "label_tileTL";
            this.label_tileTL.Size = new System.Drawing.Size(30, 13);
            this.label_tileTL.TabIndex = 29;
            this.label_tileTL.Text = "–";
            this.label_tileTL.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_tileBL
            // 
            this.label_tileBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_tileBL.Location = new System.Drawing.Point(7, 54);
            this.label_tileBL.Name = "label_tileBL";
            this.label_tileBL.Size = new System.Drawing.Size(30, 13);
            this.label_tileBL.TabIndex = 30;
            this.label_tileBL.Text = "–";
            this.label_tileBL.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_tileTR
            // 
            this.label_tileTR.AutoSize = true;
            this.label_tileTR.Location = new System.Drawing.Point(487, 46);
            this.label_tileTR.Name = "label_tileTR";
            this.label_tileTR.Size = new System.Drawing.Size(12, 13);
            this.label_tileTR.TabIndex = 31;
            this.label_tileTR.Text = "–";
            // 
            // label_tileBR
            // 
            this.label_tileBR.AutoSize = true;
            this.label_tileBR.Location = new System.Drawing.Point(487, 86);
            this.label_tileBR.Name = "label_tileBR";
            this.label_tileBR.Size = new System.Drawing.Size(12, 13);
            this.label_tileBR.TabIndex = 32;
            this.label_tileBR.Text = "–";
            // 
            // panel_text
            // 
            this.panel_text.Controls.Add(this.label_tileTL);
            this.panel_text.Controls.Add(this.label_tileBL);
            this.panel_text.Location = new System.Drawing.Point(317, 32);
            this.panel_text.Name = "panel_text";
            this.panel_text.Size = new System.Drawing.Size(40, 80);
            this.panel_text.TabIndex = 33;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_tile,
            this.statusLabel_changes,
            this.statusStrip_spring,
            this.statusStrip_import,
            this.statusStrip_export});
            this.statusStrip.Location = new System.Drawing.Point(0, 419);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(832, 24);
            this.statusStrip.TabIndex = 34;
            // 
            // statusLabel_tile
            // 
            this.statusLabel_tile.AutoSize = false;
            this.statusLabel_tile.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.statusLabel_tile.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.statusLabel_tile.Name = "statusLabel_tile";
            this.statusLabel_tile.Size = new System.Drawing.Size(80, 19);
            this.statusLabel_tile.Text = "Tile:";
            this.statusLabel_tile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusLabel_changes
            // 
            this.statusLabel_changes.Name = "statusLabel_changes";
            this.statusLabel_changes.Size = new System.Drawing.Size(12, 19);
            this.statusLabel_changes.Text = "-";
            // 
            // statusStrip_spring
            // 
            this.statusStrip_spring.Name = "statusStrip_spring";
            this.statusStrip_spring.Size = new System.Drawing.Size(585, 19);
            this.statusStrip_spring.Spring = true;
            // 
            // statusStrip_import
            // 
            this.statusStrip_import.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusStrip_import.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip_importTileTable});
            this.statusStrip_import.Name = "statusStrip_import";
            this.statusStrip_import.Size = new System.Drawing.Size(56, 22);
            this.statusStrip_import.Text = "Import";
            // 
            // statusStrip_export
            // 
            this.statusStrip_export.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusStrip_export.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip_exportTileTable});
            this.statusStrip_export.Name = "statusStrip_export";
            this.statusStrip_export.Size = new System.Drawing.Size(53, 22);
            this.statusStrip_export.Text = "Export";
            // 
            // checkBox_preserveData
            // 
            this.checkBox_preserveData.AutoSize = true;
            this.checkBox_preserveData.Location = new System.Drawing.Point(226, 24);
            this.checkBox_preserveData.Name = "checkBox_preserveData";
            this.checkBox_preserveData.Size = new System.Drawing.Size(85, 30);
            this.checkBox_preserveData.TabIndex = 35;
            this.checkBox_preserveData.Text = "Preserve\r\nexisting data";
            this.checkBox_preserveData.UseVisualStyleBackColor = true;
            // 
            // gfxView_tile
            // 
            this.gfxView_tile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gfxView_tile.Location = new System.Drawing.Point(380, 32);
            this.gfxView_tile.Name = "gfxView_tile";
            this.gfxView_tile.Size = new System.Drawing.Size(80, 80);
            this.gfxView_tile.TabIndex = 25;
            this.gfxView_tile.TabStop = false;
            this.gfxView_tile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gfxView_tile_MouseDown);
            // 
            // statusStrip_importTileTable
            // 
            this.statusStrip_importTileTable.Name = "statusStrip_importTileTable";
            this.statusStrip_importTileTable.Size = new System.Drawing.Size(152, 22);
            this.statusStrip_importTileTable.Text = "Tile Table...";
            this.statusStrip_importTileTable.Click += new System.EventHandler(this.statusStrip_importTileTable_Click);
            // 
            // statusStrip_exportTileTable
            // 
            this.statusStrip_exportTileTable.Name = "statusStrip_exportTileTable";
            this.statusStrip_exportTileTable.Size = new System.Drawing.Size(152, 22);
            this.statusStrip_exportTileTable.Text = "Tile Table...";
            this.statusStrip_exportTileTable.Click += new System.EventHandler(this.statusStrip_exportTileTable_Click);
            // 
            // FormTileTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 443);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(848, 482);
            this.Name = "FormTileTable";
            this.Text = "Tile Table Editor";
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
        private mage.Theming.CustomControls.FlatComboBox comboBox_room;
        private mage.Theming.CustomControls.FlatComboBox comboBox_area;
        private System.Windows.Forms.Label label_tileset;
        private mage.Theming.CustomControls.FlatComboBox comboBox_tileset;
        private System.Windows.Forms.Panel panel_result;
        private System.Windows.Forms.Panel panel_gfx;
        private mage.Theming.CustomControls.FlatComboBox comboBox_bg;
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
        private mage.Theming.CustomControls.FlatTabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_background;
        private System.Windows.Forms.TabPage tabPage_tileset;
        private mage.Theming.CustomControls.FlatComboBox comboBox_size;
        private System.Windows.Forms.Label label_height;
        private mage.Theming.CustomControls.FlatNumericUpDown numericUpDown_height;
        private System.Windows.Forms.TabPage tabPage_offset;
        private System.Windows.Forms.Label label_palette;
        private System.Windows.Forms.Label label_graphics;
        private System.Windows.Forms.Label label_tileTable;
        private mage.Theming.CustomControls.FlatTextBox textBox_pal;
        private mage.Theming.CustomControls.FlatTextBox textBox_gfx;
        private mage.Theming.CustomControls.FlatTextBox textBox_ttb;
        private System.Windows.Forms.Button button_go;
        private System.Windows.Forms.Label label_bg;
        private System.Windows.Forms.Label label_room;
        private System.Windows.Forms.Label label_area;
        private GfxView gfxView_gfx;
        private GfxView gfxView_tile;
        private GfxView gfxView_result;
        private System.Windows.Forms.Label label_pal;
        private mage.Theming.CustomControls.FlatComboBox comboBox_palette;
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
        private mage.Theming.CustomControls.FlatNumericUpDown numericUpDown_shift;
        private System.Windows.Forms.Label label_shift;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip_spring;
        private System.Windows.Forms.ToolStripDropDownButton statusStrip_import;
        private System.Windows.Forms.ToolStripDropDownButton statusStrip_export;
        private System.Windows.Forms.ToolStripMenuItem statusStrip_importTileTable;
        private System.Windows.Forms.ToolStripMenuItem statusStrip_exportTileTable;
    }
}