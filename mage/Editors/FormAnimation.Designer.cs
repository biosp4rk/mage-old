namespace mage
{
    partial class FormAnimation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnimation));
            this.tabControl = new mage.Theming.CustomControls.FlatTabControl();
            this.tabPage_tileset = new System.Windows.Forms.TabPage();
            this.label_tilesetGfx = new System.Windows.Forms.Label();
            this.comboBox_tilesetGfxNum = new mage.Theming.CustomControls.FlatComboBox();
            this.label_tilesetSlot = new System.Windows.Forms.Label();
            this.comboBox_tilesetSlot = new mage.Theming.CustomControls.FlatComboBox();
            this.label_tilesetNum = new System.Windows.Forms.Label();
            this.pictureBox_tileset = new System.Windows.Forms.PictureBox();
            this.comboBox_tilesetNum = new mage.Theming.CustomControls.FlatComboBox();
            this.button_tilesetClose = new System.Windows.Forms.Button();
            this.button_tilesetApply = new System.Windows.Forms.Button();
            this.tabPage_graphics = new System.Windows.Forms.TabPage();
            this.gfxView_gfx = new mage.GfxView();
            this.label_gfxPal = new System.Windows.Forms.Label();
            this.textBox_gfxPalOffset = new mage.Theming.CustomControls.FlatTextBox();
            this.label_gfxView = new System.Windows.Forms.Label();
            this.comboBox_gfxView = new mage.Theming.CustomControls.FlatComboBox();
            this.button_gfxEdit = new System.Windows.Forms.Button();
            this.textBox_gfxStates = new mage.Theming.CustomControls.FlatTextBox();
            this.label_gfxStates = new System.Windows.Forms.Label();
            this.textBox_gfxDelay = new mage.Theming.CustomControls.FlatTextBox();
            this.label_gfxDelay = new System.Windows.Forms.Label();
            this.label_gfxDirection = new System.Windows.Forms.Label();
            this.comboBox_gfxDirection = new mage.Theming.CustomControls.FlatComboBox();
            this.label_gfxNum = new System.Windows.Forms.Label();
            this.comboBox_gfxNum = new mage.Theming.CustomControls.FlatComboBox();
            this.button_gfxClose = new System.Windows.Forms.Button();
            this.button_gfxApply = new System.Windows.Forms.Button();
            this.tabPage_palette = new System.Windows.Forms.TabPage();
            this.button_palEdit = new System.Windows.Forms.Button();
            this.textBox_palStates = new mage.Theming.CustomControls.FlatTextBox();
            this.label_palStates = new System.Windows.Forms.Label();
            this.textBox_palDelay = new mage.Theming.CustomControls.FlatTextBox();
            this.label_palDelay = new System.Windows.Forms.Label();
            this.label_palDirection = new System.Windows.Forms.Label();
            this.comboBox_palDirection = new mage.Theming.CustomControls.FlatComboBox();
            this.label_palNum = new System.Windows.Forms.Label();
            this.button_palClose = new System.Windows.Forms.Button();
            this.button_palApply = new System.Windows.Forms.Button();
            this.comboBox_palNum = new mage.Theming.CustomControls.FlatComboBox();
            this.pictureBox_pal = new System.Windows.Forms.PictureBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel_changes = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl.SuspendLayout();
            this.tabPage_tileset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tileset)).BeginInit();
            this.tabPage_graphics.SuspendLayout();
            this.tabPage_palette.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pal)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_tileset);
            this.tabControl.Controls.Add(this.tabPage_graphics);
            this.tabControl.Controls.Add(this.tabPage_palette);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(289, 190);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage_tileset
            // 
            this.tabPage_tileset.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_tileset.Controls.Add(this.label_tilesetGfx);
            this.tabPage_tileset.Controls.Add(this.comboBox_tilesetGfxNum);
            this.tabPage_tileset.Controls.Add(this.label_tilesetSlot);
            this.tabPage_tileset.Controls.Add(this.comboBox_tilesetSlot);
            this.tabPage_tileset.Controls.Add(this.label_tilesetNum);
            this.tabPage_tileset.Controls.Add(this.pictureBox_tileset);
            this.tabPage_tileset.Controls.Add(this.comboBox_tilesetNum);
            this.tabPage_tileset.Controls.Add(this.button_tilesetClose);
            this.tabPage_tileset.Controls.Add(this.button_tilesetApply);
            this.tabPage_tileset.Location = new System.Drawing.Point(4, 22);
            this.tabPage_tileset.Name = "tabPage_tileset";
            this.tabPage_tileset.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_tileset.Size = new System.Drawing.Size(281, 164);
            this.tabPage_tileset.TabIndex = 0;
            this.tabPage_tileset.Text = "Tileset";
            // 
            // label_tilesetGfx
            // 
            this.label_tilesetGfx.AutoSize = true;
            this.label_tilesetGfx.Location = new System.Drawing.Point(9, 95);
            this.label_tilesetGfx.Name = "label_tilesetGfx";
            this.label_tilesetGfx.Size = new System.Drawing.Size(52, 13);
            this.label_tilesetGfx.TabIndex = 15;
            this.label_tilesetGfx.Text = "Graphics:";
            // 
            // comboBox_tilesetGfxNum
            // 
            this.comboBox_tilesetGfxNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tilesetGfxNum.FormattingEnabled = true;
            this.comboBox_tilesetGfxNum.Location = new System.Drawing.Point(67, 92);
            this.comboBox_tilesetGfxNum.Name = "comboBox_tilesetGfxNum";
            this.comboBox_tilesetGfxNum.Size = new System.Drawing.Size(50, 21);
            this.comboBox_tilesetGfxNum.TabIndex = 14;
            this.comboBox_tilesetGfxNum.SelectedIndexChanged += new System.EventHandler(this.comboBox_tilesetGfxNum_SelectedIndexChanged);
            // 
            // label_tilesetSlot
            // 
            this.label_tilesetSlot.AutoSize = true;
            this.label_tilesetSlot.Location = new System.Drawing.Point(9, 68);
            this.label_tilesetSlot.Name = "label_tilesetSlot";
            this.label_tilesetSlot.Size = new System.Drawing.Size(28, 13);
            this.label_tilesetSlot.TabIndex = 12;
            this.label_tilesetSlot.Text = "Slot:";
            // 
            // comboBox_tilesetSlot
            // 
            this.comboBox_tilesetSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tilesetSlot.FormattingEnabled = true;
            this.comboBox_tilesetSlot.Location = new System.Drawing.Point(67, 65);
            this.comboBox_tilesetSlot.Name = "comboBox_tilesetSlot";
            this.comboBox_tilesetSlot.Size = new System.Drawing.Size(50, 21);
            this.comboBox_tilesetSlot.TabIndex = 11;
            this.comboBox_tilesetSlot.SelectedIndexChanged += new System.EventHandler(this.comboBox_tilesetSlot_SelectedIndexChanged);
            // 
            // label_tilesetNum
            // 
            this.label_tilesetNum.AutoSize = true;
            this.label_tilesetNum.Location = new System.Drawing.Point(9, 41);
            this.label_tilesetNum.Name = "label_tilesetNum";
            this.label_tilesetNum.Size = new System.Drawing.Size(41, 13);
            this.label_tilesetNum.TabIndex = 10;
            this.label_tilesetNum.Text = "Tileset:";
            // 
            // pictureBox_tileset
            // 
            this.pictureBox_tileset.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_tileset.Name = "pictureBox_tileset";
            this.pictureBox_tileset.Size = new System.Drawing.Size(256, 16);
            this.pictureBox_tileset.TabIndex = 9;
            this.pictureBox_tileset.TabStop = false;
            // 
            // comboBox_tilesetNum
            // 
            this.comboBox_tilesetNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tilesetNum.FormattingEnabled = true;
            this.comboBox_tilesetNum.Location = new System.Drawing.Point(67, 38);
            this.comboBox_tilesetNum.Name = "comboBox_tilesetNum";
            this.comboBox_tilesetNum.Size = new System.Drawing.Size(50, 21);
            this.comboBox_tilesetNum.TabIndex = 8;
            this.comboBox_tilesetNum.SelectedIndexChanged += new System.EventHandler(this.comboBox_tilesetNum_SelectedIndexChanged);
            // 
            // button_tilesetClose
            // 
            this.button_tilesetClose.Location = new System.Drawing.Point(144, 90);
            this.button_tilesetClose.Name = "button_tilesetClose";
            this.button_tilesetClose.Size = new System.Drawing.Size(75, 23);
            this.button_tilesetClose.TabIndex = 7;
            this.button_tilesetClose.Text = "Close";
            this.button_tilesetClose.UseVisualStyleBackColor = true;
            this.button_tilesetClose.Click += new System.EventHandler(this.button_tilesetClose_Click);
            // 
            // button_tilesetApply
            // 
            this.button_tilesetApply.Enabled = false;
            this.button_tilesetApply.Location = new System.Drawing.Point(144, 61);
            this.button_tilesetApply.Name = "button_tilesetApply";
            this.button_tilesetApply.Size = new System.Drawing.Size(75, 23);
            this.button_tilesetApply.TabIndex = 6;
            this.button_tilesetApply.Text = "Apply";
            this.button_tilesetApply.UseVisualStyleBackColor = true;
            this.button_tilesetApply.Click += new System.EventHandler(this.button_tilesetApply_Click);
            // 
            // tabPage_graphics
            // 
            this.tabPage_graphics.Controls.Add(this.gfxView_gfx);
            this.tabPage_graphics.Controls.Add(this.label_gfxPal);
            this.tabPage_graphics.Controls.Add(this.textBox_gfxPalOffset);
            this.tabPage_graphics.Controls.Add(this.label_gfxView);
            this.tabPage_graphics.Controls.Add(this.comboBox_gfxView);
            this.tabPage_graphics.Controls.Add(this.button_gfxEdit);
            this.tabPage_graphics.Controls.Add(this.textBox_gfxStates);
            this.tabPage_graphics.Controls.Add(this.label_gfxStates);
            this.tabPage_graphics.Controls.Add(this.textBox_gfxDelay);
            this.tabPage_graphics.Controls.Add(this.label_gfxDelay);
            this.tabPage_graphics.Controls.Add(this.label_gfxDirection);
            this.tabPage_graphics.Controls.Add(this.comboBox_gfxDirection);
            this.tabPage_graphics.Controls.Add(this.label_gfxNum);
            this.tabPage_graphics.Controls.Add(this.comboBox_gfxNum);
            this.tabPage_graphics.Controls.Add(this.button_gfxClose);
            this.tabPage_graphics.Controls.Add(this.button_gfxApply);
            this.tabPage_graphics.Location = new System.Drawing.Point(4, 22);
            this.tabPage_graphics.Name = "tabPage_graphics";
            this.tabPage_graphics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_graphics.Size = new System.Drawing.Size(281, 164);
            this.tabPage_graphics.TabIndex = 1;
            this.tabPage_graphics.Text = "Graphics";
            // 
            // gfxView_gfx
            // 
            this.gfxView_gfx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gfxView_gfx.Location = new System.Drawing.Point(12, 12);
            this.gfxView_gfx.Name = "gfxView_gfx";
            this.gfxView_gfx.Size = new System.Drawing.Size(64, 32);
            this.gfxView_gfx.TabIndex = 29;
            this.gfxView_gfx.TabStop = false;
            // 
            // label_gfxPal
            // 
            this.label_gfxPal.AutoSize = true;
            this.label_gfxPal.Location = new System.Drawing.Point(131, 36);
            this.label_gfxPal.Name = "label_gfxPal";
            this.label_gfxPal.Size = new System.Drawing.Size(43, 13);
            this.label_gfxPal.TabIndex = 27;
            this.label_gfxPal.Text = "Palette:";
            // 
            // textBox_gfxPalOffset
            // 
            this.textBox_gfxPalOffset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.textBox_gfxPalOffset.Location = new System.Drawing.Point(180, 33);
            this.textBox_gfxPalOffset.Name = "textBox_gfxPalOffset";
            this.textBox_gfxPalOffset.Size = new System.Drawing.Size(55, 20);
            this.textBox_gfxPalOffset.TabIndex = 25;
            this.textBox_gfxPalOffset.TextChanged += new System.EventHandler(this.textBox_gfxPalOffset_TextChanged);
            // 
            // label_gfxView
            // 
            this.label_gfxView.AutoSize = true;
            this.label_gfxView.Location = new System.Drawing.Point(131, 9);
            this.label_gfxView.Name = "label_gfxView";
            this.label_gfxView.Size = new System.Drawing.Size(33, 13);
            this.label_gfxView.TabIndex = 24;
            this.label_gfxView.Text = "View:";
            // 
            // comboBox_gfxView
            // 
            this.comboBox_gfxView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gfxView.FormattingEnabled = true;
            this.comboBox_gfxView.Items.AddRange(new object[] {
            "2 x 2",
            "4 x 1"});
            this.comboBox_gfxView.Location = new System.Drawing.Point(180, 6);
            this.comboBox_gfxView.Name = "comboBox_gfxView";
            this.comboBox_gfxView.Size = new System.Drawing.Size(55, 21);
            this.comboBox_gfxView.TabIndex = 23;
            this.comboBox_gfxView.SelectedIndexChanged += new System.EventHandler(this.comboBox_gfxView_SelectedIndexChanged);
            // 
            // button_gfxEdit
            // 
            this.button_gfxEdit.Location = new System.Drawing.Point(160, 73);
            this.button_gfxEdit.Name = "button_gfxEdit";
            this.button_gfxEdit.Size = new System.Drawing.Size(75, 23);
            this.button_gfxEdit.TabIndex = 22;
            this.button_gfxEdit.Text = "Edit";
            this.button_gfxEdit.UseVisualStyleBackColor = true;
            this.button_gfxEdit.Click += new System.EventHandler(this.button_gfxEdit_Click);
            // 
            // textBox_gfxStates
            // 
            this.textBox_gfxStates.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.textBox_gfxStates.Location = new System.Drawing.Point(67, 134);
            this.textBox_gfxStates.Name = "textBox_gfxStates";
            this.textBox_gfxStates.Size = new System.Drawing.Size(35, 20);
            this.textBox_gfxStates.TabIndex = 21;
            this.textBox_gfxStates.TextChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // label_gfxStates
            // 
            this.label_gfxStates.AutoSize = true;
            this.label_gfxStates.Location = new System.Drawing.Point(9, 137);
            this.label_gfxStates.Name = "label_gfxStates";
            this.label_gfxStates.Size = new System.Drawing.Size(40, 13);
            this.label_gfxStates.TabIndex = 20;
            this.label_gfxStates.Text = "States:";
            // 
            // textBox_gfxDelay
            // 
            this.textBox_gfxDelay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.textBox_gfxDelay.Location = new System.Drawing.Point(67, 108);
            this.textBox_gfxDelay.Name = "textBox_gfxDelay";
            this.textBox_gfxDelay.Size = new System.Drawing.Size(35, 20);
            this.textBox_gfxDelay.TabIndex = 19;
            this.textBox_gfxDelay.TextChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // label_gfxDelay
            // 
            this.label_gfxDelay.AutoSize = true;
            this.label_gfxDelay.Location = new System.Drawing.Point(9, 111);
            this.label_gfxDelay.Name = "label_gfxDelay";
            this.label_gfxDelay.Size = new System.Drawing.Size(37, 13);
            this.label_gfxDelay.TabIndex = 18;
            this.label_gfxDelay.Text = "Delay:";
            // 
            // label_gfxDirection
            // 
            this.label_gfxDirection.AutoSize = true;
            this.label_gfxDirection.Location = new System.Drawing.Point(9, 84);
            this.label_gfxDirection.Name = "label_gfxDirection";
            this.label_gfxDirection.Size = new System.Drawing.Size(52, 13);
            this.label_gfxDirection.TabIndex = 16;
            this.label_gfxDirection.Text = "Direction:";
            // 
            // comboBox_gfxDirection
            // 
            this.comboBox_gfxDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gfxDirection.FormattingEnabled = true;
            this.comboBox_gfxDirection.Items.AddRange(new object[] {
            "None",
            "Normal",
            "Alternate"});
            this.comboBox_gfxDirection.Location = new System.Drawing.Point(67, 81);
            this.comboBox_gfxDirection.Name = "comboBox_gfxDirection";
            this.comboBox_gfxDirection.Size = new System.Drawing.Size(65, 21);
            this.comboBox_gfxDirection.TabIndex = 15;
            this.comboBox_gfxDirection.SelectedIndexChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // label_gfxNum
            // 
            this.label_gfxNum.AutoSize = true;
            this.label_gfxNum.Location = new System.Drawing.Point(9, 57);
            this.label_gfxNum.Name = "label_gfxNum";
            this.label_gfxNum.Size = new System.Drawing.Size(52, 13);
            this.label_gfxNum.TabIndex = 13;
            this.label_gfxNum.Text = "Graphics:";
            // 
            // comboBox_gfxNum
            // 
            this.comboBox_gfxNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gfxNum.FormattingEnabled = true;
            this.comboBox_gfxNum.Location = new System.Drawing.Point(67, 54);
            this.comboBox_gfxNum.Name = "comboBox_gfxNum";
            this.comboBox_gfxNum.Size = new System.Drawing.Size(45, 21);
            this.comboBox_gfxNum.TabIndex = 12;
            this.comboBox_gfxNum.SelectedIndexChanged += new System.EventHandler(this.comboBox_gfxNum_SelectedIndexChanged);
            // 
            // button_gfxClose
            // 
            this.button_gfxClose.Location = new System.Drawing.Point(160, 131);
            this.button_gfxClose.Name = "button_gfxClose";
            this.button_gfxClose.Size = new System.Drawing.Size(75, 23);
            this.button_gfxClose.TabIndex = 8;
            this.button_gfxClose.Text = "Close";
            this.button_gfxClose.UseVisualStyleBackColor = true;
            this.button_gfxClose.Click += new System.EventHandler(this.button_gfxClose_Click);
            // 
            // button_gfxApply
            // 
            this.button_gfxApply.Enabled = false;
            this.button_gfxApply.Location = new System.Drawing.Point(160, 102);
            this.button_gfxApply.Name = "button_gfxApply";
            this.button_gfxApply.Size = new System.Drawing.Size(75, 23);
            this.button_gfxApply.TabIndex = 7;
            this.button_gfxApply.Text = "Apply";
            this.button_gfxApply.UseVisualStyleBackColor = true;
            this.button_gfxApply.Click += new System.EventHandler(this.button_gfxApply_Click);
            // 
            // tabPage_palette
            // 
            this.tabPage_palette.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_palette.Controls.Add(this.button_palEdit);
            this.tabPage_palette.Controls.Add(this.textBox_palStates);
            this.tabPage_palette.Controls.Add(this.label_palStates);
            this.tabPage_palette.Controls.Add(this.textBox_palDelay);
            this.tabPage_palette.Controls.Add(this.label_palDelay);
            this.tabPage_palette.Controls.Add(this.label_palDirection);
            this.tabPage_palette.Controls.Add(this.comboBox_palDirection);
            this.tabPage_palette.Controls.Add(this.label_palNum);
            this.tabPage_palette.Controls.Add(this.button_palClose);
            this.tabPage_palette.Controls.Add(this.button_palApply);
            this.tabPage_palette.Controls.Add(this.comboBox_palNum);
            this.tabPage_palette.Controls.Add(this.pictureBox_pal);
            this.tabPage_palette.Location = new System.Drawing.Point(4, 22);
            this.tabPage_palette.Name = "tabPage_palette";
            this.tabPage_palette.Size = new System.Drawing.Size(281, 164);
            this.tabPage_palette.TabIndex = 2;
            this.tabPage_palette.Text = "Palette";
            // 
            // button_palEdit
            // 
            this.button_palEdit.Location = new System.Drawing.Point(158, 39);
            this.button_palEdit.Name = "button_palEdit";
            this.button_palEdit.Size = new System.Drawing.Size(75, 23);
            this.button_palEdit.TabIndex = 28;
            this.button_palEdit.Text = "Edit";
            this.button_palEdit.UseVisualStyleBackColor = true;
            this.button_palEdit.Click += new System.EventHandler(this.button_palEdit_Click);
            // 
            // textBox_palStates
            // 
            this.textBox_palStates.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.textBox_palStates.Location = new System.Drawing.Point(66, 119);
            this.textBox_palStates.Name = "textBox_palStates";
            this.textBox_palStates.Size = new System.Drawing.Size(35, 20);
            this.textBox_palStates.TabIndex = 27;
            this.textBox_palStates.TextChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // label_palStates
            // 
            this.label_palStates.AutoSize = true;
            this.label_palStates.Location = new System.Drawing.Point(8, 122);
            this.label_palStates.Name = "label_palStates";
            this.label_palStates.Size = new System.Drawing.Size(40, 13);
            this.label_palStates.TabIndex = 26;
            this.label_palStates.Text = "States:";
            // 
            // textBox_palDelay
            // 
            this.textBox_palDelay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.textBox_palDelay.Location = new System.Drawing.Point(66, 93);
            this.textBox_palDelay.Name = "textBox_palDelay";
            this.textBox_palDelay.Size = new System.Drawing.Size(35, 20);
            this.textBox_palDelay.TabIndex = 25;
            this.textBox_palDelay.TextChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // label_palDelay
            // 
            this.label_palDelay.AutoSize = true;
            this.label_palDelay.Location = new System.Drawing.Point(8, 96);
            this.label_palDelay.Name = "label_palDelay";
            this.label_palDelay.Size = new System.Drawing.Size(37, 13);
            this.label_palDelay.TabIndex = 24;
            this.label_palDelay.Text = "Delay:";
            // 
            // label_palDirection
            // 
            this.label_palDirection.AutoSize = true;
            this.label_palDirection.Location = new System.Drawing.Point(8, 69);
            this.label_palDirection.Name = "label_palDirection";
            this.label_palDirection.Size = new System.Drawing.Size(52, 13);
            this.label_palDirection.TabIndex = 23;
            this.label_palDirection.Text = "Direction:";
            // 
            // comboBox_palDirection
            // 
            this.comboBox_palDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_palDirection.FormattingEnabled = true;
            this.comboBox_palDirection.Items.AddRange(new object[] {
            "None",
            "Normal",
            "Alternate"});
            this.comboBox_palDirection.Location = new System.Drawing.Point(66, 66);
            this.comboBox_palDirection.Name = "comboBox_palDirection";
            this.comboBox_palDirection.Size = new System.Drawing.Size(65, 21);
            this.comboBox_palDirection.TabIndex = 22;
            this.comboBox_palDirection.SelectedIndexChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // label_palNum
            // 
            this.label_palNum.AutoSize = true;
            this.label_palNum.Location = new System.Drawing.Point(9, 42);
            this.label_palNum.Name = "label_palNum";
            this.label_palNum.Size = new System.Drawing.Size(43, 13);
            this.label_palNum.TabIndex = 14;
            this.label_palNum.Text = "Palette:";
            // 
            // button_palClose
            // 
            this.button_palClose.Location = new System.Drawing.Point(158, 116);
            this.button_palClose.Name = "button_palClose";
            this.button_palClose.Size = new System.Drawing.Size(75, 23);
            this.button_palClose.TabIndex = 13;
            this.button_palClose.Text = "Close";
            this.button_palClose.UseVisualStyleBackColor = true;
            this.button_palClose.Click += new System.EventHandler(this.button_palClose_Click);
            // 
            // button_palApply
            // 
            this.button_palApply.Enabled = false;
            this.button_palApply.Location = new System.Drawing.Point(158, 87);
            this.button_palApply.Name = "button_palApply";
            this.button_palApply.Size = new System.Drawing.Size(75, 23);
            this.button_palApply.TabIndex = 12;
            this.button_palApply.Text = "Apply";
            this.button_palApply.UseVisualStyleBackColor = true;
            this.button_palApply.Click += new System.EventHandler(this.button_palApply_Click);
            // 
            // comboBox_palNum
            // 
            this.comboBox_palNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_palNum.FormattingEnabled = true;
            this.comboBox_palNum.Location = new System.Drawing.Point(66, 39);
            this.comboBox_palNum.Name = "comboBox_palNum";
            this.comboBox_palNum.Size = new System.Drawing.Size(45, 21);
            this.comboBox_palNum.TabIndex = 11;
            this.comboBox_palNum.SelectedIndexChanged += new System.EventHandler(this.comboBox_paletteNum_SelectedIndexChanged);
            // 
            // pictureBox_pal
            // 
            this.pictureBox_pal.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_pal.Name = "pictureBox_pal";
            this.pictureBox_pal.Size = new System.Drawing.Size(257, 17);
            this.pictureBox_pal.TabIndex = 10;
            this.pictureBox_pal.TabStop = false;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_changes});
            this.statusStrip.Location = new System.Drawing.Point(0, 205);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(313, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel_changes
            // 
            this.statusLabel_changes.Name = "statusLabel_changes";
            this.statusLabel_changes.Size = new System.Drawing.Size(12, 17);
            this.statusLabel_changes.Text = "-";
            // 
            // FormAnimation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 227);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAnimation";
            this.Text = "Animation Editor";
            this.tabControl.ResumeLayout(false);
            this.tabPage_tileset.ResumeLayout(false);
            this.tabPage_tileset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_tileset)).EndInit();
            this.tabPage_graphics.ResumeLayout(false);
            this.tabPage_graphics.PerformLayout();
            this.tabPage_palette.ResumeLayout(false);
            this.tabPage_palette.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pal)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mage.Theming.CustomControls.FlatTabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_tileset;
        private System.Windows.Forms.Button button_tilesetClose;
        private System.Windows.Forms.Button button_tilesetApply;
        private System.Windows.Forms.TabPage tabPage_graphics;
        private System.Windows.Forms.Button button_gfxClose;
        private System.Windows.Forms.Button button_gfxApply;
        private System.Windows.Forms.TabPage tabPage_palette;
        private mage.Theming.CustomControls.FlatComboBox comboBox_tilesetNum;
        private System.Windows.Forms.PictureBox pictureBox_tileset;
        private System.Windows.Forms.Label label_tilesetSlot;
        private mage.Theming.CustomControls.FlatComboBox comboBox_tilesetSlot;
        private System.Windows.Forms.Label label_tilesetNum;
        private System.Windows.Forms.PictureBox pictureBox_pal;
        private mage.Theming.CustomControls.FlatComboBox comboBox_palNum;
        private mage.Theming.CustomControls.FlatComboBox comboBox_tilesetGfxNum;
        private mage.Theming.CustomControls.FlatComboBox comboBox_gfxNum;
        private System.Windows.Forms.Label label_gfxNum;
        private mage.Theming.CustomControls.FlatComboBox comboBox_gfxDirection;
        private System.Windows.Forms.Label label_gfxDirection;
        private System.Windows.Forms.Button button_palClose;
        private System.Windows.Forms.Button button_palApply;
        private System.Windows.Forms.Label label_palNum;
        private mage.Theming.CustomControls.FlatTextBox textBox_gfxDelay;
        private System.Windows.Forms.Label label_gfxDelay;
        private mage.Theming.CustomControls.FlatTextBox textBox_gfxStates;
        private System.Windows.Forms.Label label_gfxStates;
        private mage.Theming.CustomControls.FlatTextBox textBox_palStates;
        private System.Windows.Forms.Label label_palStates;
        private mage.Theming.CustomControls.FlatTextBox textBox_palDelay;
        private System.Windows.Forms.Label label_palDelay;
        private System.Windows.Forms.Label label_palDirection;
        private mage.Theming.CustomControls.FlatComboBox comboBox_palDirection;
        private System.Windows.Forms.Label label_tilesetGfx;
        private System.Windows.Forms.Button button_gfxEdit;
        private System.Windows.Forms.Button button_palEdit;
        private mage.Theming.CustomControls.FlatComboBox comboBox_gfxView;
        private System.Windows.Forms.Label label_gfxView;
        private mage.Theming.CustomControls.FlatTextBox textBox_gfxPalOffset;
        private System.Windows.Forms.Label label_gfxPal;
        private GfxView gfxView_gfx;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_changes;
    }
}