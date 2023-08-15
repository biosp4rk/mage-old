namespace mage
{
    partial class FormAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd));
            this.tabControl = new mage.Theming.CustomControls.FlatTabControl();
            this.tabPage_bg = new System.Windows.Forms.TabPage();
            this.groupBox_bgOptions = new System.Windows.Forms.GroupBox();
            this.radioButton_bgBlank = new System.Windows.Forms.RadioButton();
            this.radioButton_bgCopy = new System.Windows.Forms.RadioButton();
            this.textBox_bgOffset = new mage.Theming.CustomControls.FlatTextBox();
            this.groupBox_bgSelect = new System.Windows.Forms.GroupBox();
            this.comboBox_bg = new mage.Theming.CustomControls.FlatComboBox();
            this.radioButton_bgLZ77 = new System.Windows.Forms.RadioButton();
            this.radioButton_bgRLE = new System.Windows.Forms.RadioButton();
            this.tabPage_roomSprites = new System.Windows.Forms.TabPage();
            this.label_enemySpriteset = new System.Windows.Forms.Label();
            this.radioButton_enemyBlank = new System.Windows.Forms.RadioButton();
            this.radioButton_enemyCopy = new System.Windows.Forms.RadioButton();
            this.textBox_enemyOffset = new mage.Theming.CustomControls.FlatTextBox();
            this.comboBox_enemySet = new mage.Theming.CustomControls.FlatComboBox();
            this.tabPage_room = new System.Windows.Forms.TabPage();
            this.label_roomArea = new System.Windows.Forms.Label();
            this.label_roomHeight = new System.Windows.Forms.Label();
            this.label_roomWidth = new System.Windows.Forms.Label();
            this.comboBox_roomCopyRoom = new mage.Theming.CustomControls.FlatComboBox();
            this.textBox_roomHeight = new mage.Theming.CustomControls.FlatTextBox();
            this.textBox_roomWidth = new mage.Theming.CustomControls.FlatTextBox();
            this.comboBox_roomCopyArea = new mage.Theming.CustomControls.FlatComboBox();
            this.comboBox_roomArea = new mage.Theming.CustomControls.FlatComboBox();
            this.radioButton_roomBlank = new System.Windows.Forms.RadioButton();
            this.radioButton_roomCopy = new System.Windows.Forms.RadioButton();
            this.tabPage_tileset = new System.Windows.Forms.TabPage();
            this.comboBox_tileset = new mage.Theming.CustomControls.FlatComboBox();
            this.radioButton_tilesetBlank = new System.Windows.Forms.RadioButton();
            this.radioButton_tilesetCopy = new System.Windows.Forms.RadioButton();
            this.tabPage_spriteset = new System.Windows.Forms.TabPage();
            this.comboBox_spriteset = new mage.Theming.CustomControls.FlatComboBox();
            this.radioButton_spritesetBlank = new System.Windows.Forms.RadioButton();
            this.radioButton_spritesetCopy = new System.Windows.Forms.RadioButton();
            this.tabPage_anim = new System.Windows.Forms.TabPage();
            this.groupBox_animOptions = new System.Windows.Forms.GroupBox();
            this.comboBox_animNum = new mage.Theming.CustomControls.FlatComboBox();
            this.radioButton_animBlank = new System.Windows.Forms.RadioButton();
            this.radioButton_animCopy = new System.Windows.Forms.RadioButton();
            this.groupBox_animSelect = new System.Windows.Forms.GroupBox();
            this.radioButton_animTileset = new System.Windows.Forms.RadioButton();
            this.radioButton_animGfx = new System.Windows.Forms.RadioButton();
            this.radioButton_animPalette = new System.Windows.Forms.RadioButton();
            this.button_add = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage_bg.SuspendLayout();
            this.groupBox_bgOptions.SuspendLayout();
            this.groupBox_bgSelect.SuspendLayout();
            this.tabPage_roomSprites.SuspendLayout();
            this.tabPage_room.SuspendLayout();
            this.tabPage_tileset.SuspendLayout();
            this.tabPage_spriteset.SuspendLayout();
            this.tabPage_anim.SuspendLayout();
            this.groupBox_animOptions.SuspendLayout();
            this.groupBox_animSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_bg);
            this.tabControl.Controls.Add(this.tabPage_roomSprites);
            this.tabControl.Controls.Add(this.tabPage_room);
            this.tabControl.Controls.Add(this.tabPage_tileset);
            this.tabControl.Controls.Add(this.tabPage_spriteset);
            this.tabControl.Controls.Add(this.tabPage_anim);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(245, 148);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage_bg
            // 
            this.tabPage_bg.Controls.Add(this.groupBox_bgOptions);
            this.tabPage_bg.Controls.Add(this.groupBox_bgSelect);
            this.tabPage_bg.Location = new System.Drawing.Point(4, 40);
            this.tabPage_bg.Name = "tabPage_bg";
            this.tabPage_bg.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_bg.Size = new System.Drawing.Size(237, 104);
            this.tabPage_bg.TabIndex = 0;
            this.tabPage_bg.Text = "Background";
            // 
            // groupBox_bgOptions
            // 
            this.groupBox_bgOptions.Controls.Add(this.radioButton_bgBlank);
            this.groupBox_bgOptions.Controls.Add(this.radioButton_bgCopy);
            this.groupBox_bgOptions.Controls.Add(this.textBox_bgOffset);
            this.groupBox_bgOptions.Location = new System.Drawing.Point(104, 6);
            this.groupBox_bgOptions.Name = "groupBox_bgOptions";
            this.groupBox_bgOptions.Size = new System.Drawing.Size(127, 92);
            this.groupBox_bgOptions.TabIndex = 9;
            this.groupBox_bgOptions.TabStop = false;
            this.groupBox_bgOptions.Text = "Options";
            // 
            // radioButton_bgBlank
            // 
            this.radioButton_bgBlank.AutoSize = true;
            this.radioButton_bgBlank.Location = new System.Drawing.Point(6, 19);
            this.radioButton_bgBlank.Name = "radioButton_bgBlank";
            this.radioButton_bgBlank.Size = new System.Drawing.Size(52, 17);
            this.radioButton_bgBlank.TabIndex = 2;
            this.radioButton_bgBlank.Text = "Blank";
            this.radioButton_bgBlank.UseVisualStyleBackColor = true;
            this.radioButton_bgBlank.CheckedChanged += new System.EventHandler(this.radioButton_option_CheckedChanged);
            // 
            // radioButton_bgCopy
            // 
            this.radioButton_bgCopy.AutoSize = true;
            this.radioButton_bgCopy.Location = new System.Drawing.Point(6, 44);
            this.radioButton_bgCopy.Name = "radioButton_bgCopy";
            this.radioButton_bgCopy.Size = new System.Drawing.Size(49, 17);
            this.radioButton_bgCopy.TabIndex = 3;
            this.radioButton_bgCopy.Text = "Copy";
            this.radioButton_bgCopy.UseVisualStyleBackColor = true;
            this.radioButton_bgCopy.CheckedChanged += new System.EventHandler(this.radioButton_option_CheckedChanged);
            // 
            // textBox_bgOffset
            // 
            this.textBox_bgOffset.Location = new System.Drawing.Point(61, 43);
            this.textBox_bgOffset.Name = "textBox_bgOffset";
            this.textBox_bgOffset.Size = new System.Drawing.Size(60, 20);
            this.textBox_bgOffset.TabIndex = 5;
            // 
            // groupBox_bgSelect
            // 
            this.groupBox_bgSelect.Controls.Add(this.comboBox_bg);
            this.groupBox_bgSelect.Controls.Add(this.radioButton_bgLZ77);
            this.groupBox_bgSelect.Controls.Add(this.radioButton_bgRLE);
            this.groupBox_bgSelect.Location = new System.Drawing.Point(6, 6);
            this.groupBox_bgSelect.Name = "groupBox_bgSelect";
            this.groupBox_bgSelect.Size = new System.Drawing.Size(92, 92);
            this.groupBox_bgSelect.TabIndex = 8;
            this.groupBox_bgSelect.TabStop = false;
            this.groupBox_bgSelect.Text = "Select";
            // 
            // comboBox_bg
            // 
            this.comboBox_bg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_bg.FormattingEnabled = true;
            this.comboBox_bg.Items.AddRange(new object[] {
            "BG 0",
            "BG 1",
            "BG 2",
            "BG 3",
            "Clipdata"});
            this.comboBox_bg.Location = new System.Drawing.Point(6, 19);
            this.comboBox_bg.Name = "comboBox_bg";
            this.comboBox_bg.Size = new System.Drawing.Size(80, 21);
            this.comboBox_bg.TabIndex = 0;
            this.comboBox_bg.SelectedIndexChanged += new System.EventHandler(this.comboBox_bg_SelectedIndexChanged);
            // 
            // radioButton_bgLZ77
            // 
            this.radioButton_bgLZ77.AutoSize = true;
            this.radioButton_bgLZ77.Location = new System.Drawing.Point(6, 69);
            this.radioButton_bgLZ77.Name = "radioButton_bgLZ77";
            this.radioButton_bgLZ77.Size = new System.Drawing.Size(50, 17);
            this.radioButton_bgLZ77.TabIndex = 7;
            this.radioButton_bgLZ77.TabStop = true;
            this.radioButton_bgLZ77.Text = "LZ77";
            this.radioButton_bgLZ77.UseVisualStyleBackColor = true;
            // 
            // radioButton_bgRLE
            // 
            this.radioButton_bgRLE.AutoSize = true;
            this.radioButton_bgRLE.Location = new System.Drawing.Point(6, 46);
            this.radioButton_bgRLE.Name = "radioButton_bgRLE";
            this.radioButton_bgRLE.Size = new System.Drawing.Size(46, 17);
            this.radioButton_bgRLE.TabIndex = 6;
            this.radioButton_bgRLE.TabStop = true;
            this.radioButton_bgRLE.Text = "RLE";
            this.radioButton_bgRLE.UseVisualStyleBackColor = true;
            // 
            // tabPage_roomSprites
            // 
            this.tabPage_roomSprites.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_roomSprites.Controls.Add(this.label_enemySpriteset);
            this.tabPage_roomSprites.Controls.Add(this.radioButton_enemyBlank);
            this.tabPage_roomSprites.Controls.Add(this.radioButton_enemyCopy);
            this.tabPage_roomSprites.Controls.Add(this.textBox_enemyOffset);
            this.tabPage_roomSprites.Controls.Add(this.comboBox_enemySet);
            this.tabPage_roomSprites.Location = new System.Drawing.Point(4, 40);
            this.tabPage_roomSprites.Name = "tabPage_roomSprites";
            this.tabPage_roomSprites.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_roomSprites.Size = new System.Drawing.Size(237, 104);
            this.tabPage_roomSprites.TabIndex = 5;
            this.tabPage_roomSprites.Text = "Room Sprites";
            // 
            // label_enemySpriteset
            // 
            this.label_enemySpriteset.AutoSize = true;
            this.label_enemySpriteset.Location = new System.Drawing.Point(6, 9);
            this.label_enemySpriteset.Name = "label_enemySpriteset";
            this.label_enemySpriteset.Size = new System.Drawing.Size(51, 13);
            this.label_enemySpriteset.TabIndex = 9;
            this.label_enemySpriteset.Text = "Spriteset:";
            // 
            // radioButton_enemyBlank
            // 
            this.radioButton_enemyBlank.AutoSize = true;
            this.radioButton_enemyBlank.Location = new System.Drawing.Point(6, 34);
            this.radioButton_enemyBlank.Name = "radioButton_enemyBlank";
            this.radioButton_enemyBlank.Size = new System.Drawing.Size(52, 17);
            this.radioButton_enemyBlank.TabIndex = 6;
            this.radioButton_enemyBlank.Text = "Blank";
            this.radioButton_enemyBlank.UseVisualStyleBackColor = true;
            this.radioButton_enemyBlank.CheckedChanged += new System.EventHandler(this.radioButton_option_CheckedChanged);
            // 
            // radioButton_enemyCopy
            // 
            this.radioButton_enemyCopy.AutoSize = true;
            this.radioButton_enemyCopy.Location = new System.Drawing.Point(6, 60);
            this.radioButton_enemyCopy.Name = "radioButton_enemyCopy";
            this.radioButton_enemyCopy.Size = new System.Drawing.Size(49, 17);
            this.radioButton_enemyCopy.TabIndex = 7;
            this.radioButton_enemyCopy.Text = "Copy";
            this.radioButton_enemyCopy.UseVisualStyleBackColor = true;
            this.radioButton_enemyCopy.CheckedChanged += new System.EventHandler(this.radioButton_option_CheckedChanged);
            // 
            // textBox_enemyOffset
            // 
            this.textBox_enemyOffset.Location = new System.Drawing.Point(61, 59);
            this.textBox_enemyOffset.Name = "textBox_enemyOffset";
            this.textBox_enemyOffset.Size = new System.Drawing.Size(60, 20);
            this.textBox_enemyOffset.TabIndex = 8;
            // 
            // comboBox_enemySet
            // 
            this.comboBox_enemySet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_enemySet.FormattingEnabled = true;
            this.comboBox_enemySet.Items.AddRange(new object[] {
            "Default",
            "First",
            "Second"});
            this.comboBox_enemySet.Location = new System.Drawing.Point(63, 6);
            this.comboBox_enemySet.Name = "comboBox_enemySet";
            this.comboBox_enemySet.Size = new System.Drawing.Size(70, 21);
            this.comboBox_enemySet.TabIndex = 0;
            // 
            // tabPage_room
            // 
            this.tabPage_room.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_room.Controls.Add(this.label_roomArea);
            this.tabPage_room.Controls.Add(this.label_roomHeight);
            this.tabPage_room.Controls.Add(this.label_roomWidth);
            this.tabPage_room.Controls.Add(this.comboBox_roomCopyRoom);
            this.tabPage_room.Controls.Add(this.textBox_roomHeight);
            this.tabPage_room.Controls.Add(this.textBox_roomWidth);
            this.tabPage_room.Controls.Add(this.comboBox_roomCopyArea);
            this.tabPage_room.Controls.Add(this.comboBox_roomArea);
            this.tabPage_room.Controls.Add(this.radioButton_roomBlank);
            this.tabPage_room.Controls.Add(this.radioButton_roomCopy);
            this.tabPage_room.Location = new System.Drawing.Point(4, 40);
            this.tabPage_room.Name = "tabPage_room";
            this.tabPage_room.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_room.Size = new System.Drawing.Size(237, 104);
            this.tabPage_room.TabIndex = 1;
            this.tabPage_room.Text = "Room";
            // 
            // label_roomArea
            // 
            this.label_roomArea.AutoSize = true;
            this.label_roomArea.Location = new System.Drawing.Point(6, 9);
            this.label_roomArea.Name = "label_roomArea";
            this.label_roomArea.Size = new System.Drawing.Size(32, 13);
            this.label_roomArea.TabIndex = 17;
            this.label_roomArea.Text = "Area:";
            // 
            // label_roomHeight
            // 
            this.label_roomHeight.AutoSize = true;
            this.label_roomHeight.Location = new System.Drawing.Point(152, 36);
            this.label_roomHeight.Name = "label_roomHeight";
            this.label_roomHeight.Size = new System.Drawing.Size(41, 13);
            this.label_roomHeight.TabIndex = 16;
            this.label_roomHeight.Text = "Height:";
            // 
            // label_roomWidth
            // 
            this.label_roomWidth.AutoSize = true;
            this.label_roomWidth.Location = new System.Drawing.Point(64, 36);
            this.label_roomWidth.Name = "label_roomWidth";
            this.label_roomWidth.Size = new System.Drawing.Size(38, 13);
            this.label_roomWidth.TabIndex = 15;
            this.label_roomWidth.Text = "Width:";
            // 
            // comboBox_roomCopyRoom
            // 
            this.comboBox_roomCopyRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_roomCopyRoom.FormattingEnabled = true;
            this.comboBox_roomCopyRoom.Location = new System.Drawing.Point(153, 59);
            this.comboBox_roomCopyRoom.Name = "comboBox_roomCopyRoom";
            this.comboBox_roomCopyRoom.Size = new System.Drawing.Size(45, 21);
            this.comboBox_roomCopyRoom.TabIndex = 14;
            // 
            // textBox_roomHeight
            // 
            this.textBox_roomHeight.Location = new System.Drawing.Point(197, 33);
            this.textBox_roomHeight.Name = "textBox_roomHeight";
            this.textBox_roomHeight.Size = new System.Drawing.Size(30, 20);
            this.textBox_roomHeight.TabIndex = 13;
            // 
            // textBox_roomWidth
            // 
            this.textBox_roomWidth.Location = new System.Drawing.Point(106, 33);
            this.textBox_roomWidth.Name = "textBox_roomWidth";
            this.textBox_roomWidth.Size = new System.Drawing.Size(30, 20);
            this.textBox_roomWidth.TabIndex = 12;
            // 
            // comboBox_roomCopyArea
            // 
            this.comboBox_roomCopyArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_roomCopyArea.FormattingEnabled = true;
            this.comboBox_roomCopyArea.Location = new System.Drawing.Point(67, 59);
            this.comboBox_roomCopyArea.Name = "comboBox_roomCopyArea";
            this.comboBox_roomCopyArea.Size = new System.Drawing.Size(80, 21);
            this.comboBox_roomCopyArea.TabIndex = 11;
            this.comboBox_roomCopyArea.SelectedIndexChanged += new System.EventHandler(this.comboBox_roomCopyArea_SelectedIndexChanged);
            // 
            // comboBox_roomArea
            // 
            this.comboBox_roomArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_roomArea.FormattingEnabled = true;
            this.comboBox_roomArea.Location = new System.Drawing.Point(44, 6);
            this.comboBox_roomArea.Name = "comboBox_roomArea";
            this.comboBox_roomArea.Size = new System.Drawing.Size(80, 21);
            this.comboBox_roomArea.TabIndex = 10;
            // 
            // radioButton_roomBlank
            // 
            this.radioButton_roomBlank.AutoSize = true;
            this.radioButton_roomBlank.Location = new System.Drawing.Point(6, 34);
            this.radioButton_roomBlank.Name = "radioButton_roomBlank";
            this.radioButton_roomBlank.Size = new System.Drawing.Size(52, 17);
            this.radioButton_roomBlank.TabIndex = 8;
            this.radioButton_roomBlank.Text = "Blank";
            this.radioButton_roomBlank.UseVisualStyleBackColor = true;
            this.radioButton_roomBlank.CheckedChanged += new System.EventHandler(this.radioButton_option_CheckedChanged);
            // 
            // radioButton_roomCopy
            // 
            this.radioButton_roomCopy.AutoSize = true;
            this.radioButton_roomCopy.Location = new System.Drawing.Point(6, 60);
            this.radioButton_roomCopy.Name = "radioButton_roomCopy";
            this.radioButton_roomCopy.Size = new System.Drawing.Size(49, 17);
            this.radioButton_roomCopy.TabIndex = 9;
            this.radioButton_roomCopy.Text = "Copy";
            this.radioButton_roomCopy.UseVisualStyleBackColor = true;
            this.radioButton_roomCopy.CheckedChanged += new System.EventHandler(this.radioButton_option_CheckedChanged);
            // 
            // tabPage_tileset
            // 
            this.tabPage_tileset.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_tileset.Controls.Add(this.comboBox_tileset);
            this.tabPage_tileset.Controls.Add(this.radioButton_tilesetBlank);
            this.tabPage_tileset.Controls.Add(this.radioButton_tilesetCopy);
            this.tabPage_tileset.Location = new System.Drawing.Point(4, 40);
            this.tabPage_tileset.Name = "tabPage_tileset";
            this.tabPage_tileset.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_tileset.Size = new System.Drawing.Size(237, 104);
            this.tabPage_tileset.TabIndex = 2;
            this.tabPage_tileset.Text = "Tileset";
            // 
            // comboBox_tileset
            // 
            this.comboBox_tileset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tileset.FormattingEnabled = true;
            this.comboBox_tileset.Location = new System.Drawing.Point(61, 29);
            this.comboBox_tileset.Name = "comboBox_tileset";
            this.comboBox_tileset.Size = new System.Drawing.Size(50, 21);
            this.comboBox_tileset.TabIndex = 11;
            // 
            // radioButton_tilesetBlank
            // 
            this.radioButton_tilesetBlank.AutoSize = true;
            this.radioButton_tilesetBlank.Location = new System.Drawing.Point(6, 6);
            this.radioButton_tilesetBlank.Name = "radioButton_tilesetBlank";
            this.radioButton_tilesetBlank.Size = new System.Drawing.Size(52, 17);
            this.radioButton_tilesetBlank.TabIndex = 9;
            this.radioButton_tilesetBlank.Text = "Blank";
            this.radioButton_tilesetBlank.UseVisualStyleBackColor = true;
            this.radioButton_tilesetBlank.CheckedChanged += new System.EventHandler(this.radioButton_option_CheckedChanged);
            // 
            // radioButton_tilesetCopy
            // 
            this.radioButton_tilesetCopy.AutoSize = true;
            this.radioButton_tilesetCopy.Location = new System.Drawing.Point(6, 30);
            this.radioButton_tilesetCopy.Name = "radioButton_tilesetCopy";
            this.radioButton_tilesetCopy.Size = new System.Drawing.Size(49, 17);
            this.radioButton_tilesetCopy.TabIndex = 10;
            this.radioButton_tilesetCopy.Text = "Copy";
            this.radioButton_tilesetCopy.UseVisualStyleBackColor = true;
            this.radioButton_tilesetCopy.CheckedChanged += new System.EventHandler(this.radioButton_option_CheckedChanged);
            // 
            // tabPage_spriteset
            // 
            this.tabPage_spriteset.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_spriteset.Controls.Add(this.comboBox_spriteset);
            this.tabPage_spriteset.Controls.Add(this.radioButton_spritesetBlank);
            this.tabPage_spriteset.Controls.Add(this.radioButton_spritesetCopy);
            this.tabPage_spriteset.Location = new System.Drawing.Point(4, 40);
            this.tabPage_spriteset.Name = "tabPage_spriteset";
            this.tabPage_spriteset.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_spriteset.Size = new System.Drawing.Size(237, 104);
            this.tabPage_spriteset.TabIndex = 3;
            this.tabPage_spriteset.Text = "Spriteset";
            // 
            // comboBox_spriteset
            // 
            this.comboBox_spriteset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_spriteset.FormattingEnabled = true;
            this.comboBox_spriteset.Location = new System.Drawing.Point(61, 29);
            this.comboBox_spriteset.Name = "comboBox_spriteset";
            this.comboBox_spriteset.Size = new System.Drawing.Size(50, 21);
            this.comboBox_spriteset.TabIndex = 14;
            // 
            // radioButton_spritesetBlank
            // 
            this.radioButton_spritesetBlank.AutoSize = true;
            this.radioButton_spritesetBlank.Location = new System.Drawing.Point(6, 6);
            this.radioButton_spritesetBlank.Name = "radioButton_spritesetBlank";
            this.radioButton_spritesetBlank.Size = new System.Drawing.Size(52, 17);
            this.radioButton_spritesetBlank.TabIndex = 12;
            this.radioButton_spritesetBlank.Text = "Blank";
            this.radioButton_spritesetBlank.UseVisualStyleBackColor = true;
            this.radioButton_spritesetBlank.CheckedChanged += new System.EventHandler(this.radioButton_option_CheckedChanged);
            // 
            // radioButton_spritesetCopy
            // 
            this.radioButton_spritesetCopy.AutoSize = true;
            this.radioButton_spritesetCopy.Location = new System.Drawing.Point(6, 30);
            this.radioButton_spritesetCopy.Name = "radioButton_spritesetCopy";
            this.radioButton_spritesetCopy.Size = new System.Drawing.Size(49, 17);
            this.radioButton_spritesetCopy.TabIndex = 13;
            this.radioButton_spritesetCopy.Text = "Copy";
            this.radioButton_spritesetCopy.UseVisualStyleBackColor = true;
            this.radioButton_spritesetCopy.CheckedChanged += new System.EventHandler(this.radioButton_option_CheckedChanged);
            // 
            // tabPage_anim
            // 
            this.tabPage_anim.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_anim.Controls.Add(this.groupBox_animOptions);
            this.tabPage_anim.Controls.Add(this.groupBox_animSelect);
            this.tabPage_anim.Location = new System.Drawing.Point(4, 40);
            this.tabPage_anim.Name = "tabPage_anim";
            this.tabPage_anim.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_anim.Size = new System.Drawing.Size(237, 104);
            this.tabPage_anim.TabIndex = 4;
            this.tabPage_anim.Text = "Animation";
            // 
            // groupBox_animOptions
            // 
            this.groupBox_animOptions.Controls.Add(this.comboBox_animNum);
            this.groupBox_animOptions.Controls.Add(this.radioButton_animBlank);
            this.groupBox_animOptions.Controls.Add(this.radioButton_animCopy);
            this.groupBox_animOptions.Location = new System.Drawing.Point(92, 6);
            this.groupBox_animOptions.Name = "groupBox_animOptions";
            this.groupBox_animOptions.Size = new System.Drawing.Size(121, 92);
            this.groupBox_animOptions.TabIndex = 10;
            this.groupBox_animOptions.TabStop = false;
            this.groupBox_animOptions.Text = "Options";
            // 
            // comboBox_animNum
            // 
            this.comboBox_animNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_animNum.FormattingEnabled = true;
            this.comboBox_animNum.Location = new System.Drawing.Point(61, 43);
            this.comboBox_animNum.Name = "comboBox_animNum";
            this.comboBox_animNum.Size = new System.Drawing.Size(50, 21);
            this.comboBox_animNum.TabIndex = 12;
            // 
            // radioButton_animBlank
            // 
            this.radioButton_animBlank.AutoSize = true;
            this.radioButton_animBlank.Location = new System.Drawing.Point(6, 19);
            this.radioButton_animBlank.Name = "radioButton_animBlank";
            this.radioButton_animBlank.Size = new System.Drawing.Size(52, 17);
            this.radioButton_animBlank.TabIndex = 2;
            this.radioButton_animBlank.Text = "Blank";
            this.radioButton_animBlank.UseVisualStyleBackColor = true;
            this.radioButton_animBlank.CheckedChanged += new System.EventHandler(this.radioButton_option_CheckedChanged);
            // 
            // radioButton_animCopy
            // 
            this.radioButton_animCopy.AutoSize = true;
            this.radioButton_animCopy.Location = new System.Drawing.Point(6, 44);
            this.radioButton_animCopy.Name = "radioButton_animCopy";
            this.radioButton_animCopy.Size = new System.Drawing.Size(49, 17);
            this.radioButton_animCopy.TabIndex = 3;
            this.radioButton_animCopy.Text = "Copy";
            this.radioButton_animCopy.UseVisualStyleBackColor = true;
            this.radioButton_animCopy.CheckedChanged += new System.EventHandler(this.radioButton_option_CheckedChanged);
            // 
            // groupBox_animSelect
            // 
            this.groupBox_animSelect.Controls.Add(this.radioButton_animTileset);
            this.groupBox_animSelect.Controls.Add(this.radioButton_animGfx);
            this.groupBox_animSelect.Controls.Add(this.radioButton_animPalette);
            this.groupBox_animSelect.Location = new System.Drawing.Point(6, 6);
            this.groupBox_animSelect.Name = "groupBox_animSelect";
            this.groupBox_animSelect.Size = new System.Drawing.Size(80, 92);
            this.groupBox_animSelect.TabIndex = 3;
            this.groupBox_animSelect.TabStop = false;
            this.groupBox_animSelect.Text = "Select";
            // 
            // radioButton_animTileset
            // 
            this.radioButton_animTileset.AutoSize = true;
            this.radioButton_animTileset.Location = new System.Drawing.Point(6, 19);
            this.radioButton_animTileset.Name = "radioButton_animTileset";
            this.radioButton_animTileset.Size = new System.Drawing.Size(56, 17);
            this.radioButton_animTileset.TabIndex = 0;
            this.radioButton_animTileset.TabStop = true;
            this.radioButton_animTileset.Text = "Tileset";
            this.radioButton_animTileset.UseVisualStyleBackColor = true;
            this.radioButton_animTileset.CheckedChanged += new System.EventHandler(this.radioButton_animation_CheckedChanged);
            // 
            // radioButton_animGfx
            // 
            this.radioButton_animGfx.AutoSize = true;
            this.radioButton_animGfx.Location = new System.Drawing.Point(6, 42);
            this.radioButton_animGfx.Name = "radioButton_animGfx";
            this.radioButton_animGfx.Size = new System.Drawing.Size(67, 17);
            this.radioButton_animGfx.TabIndex = 2;
            this.radioButton_animGfx.TabStop = true;
            this.radioButton_animGfx.Text = "Graphics";
            this.radioButton_animGfx.UseVisualStyleBackColor = true;
            this.radioButton_animGfx.CheckedChanged += new System.EventHandler(this.radioButton_animation_CheckedChanged);
            // 
            // radioButton_animPalette
            // 
            this.radioButton_animPalette.AutoSize = true;
            this.radioButton_animPalette.Location = new System.Drawing.Point(6, 65);
            this.radioButton_animPalette.Name = "radioButton_animPalette";
            this.radioButton_animPalette.Size = new System.Drawing.Size(58, 17);
            this.radioButton_animPalette.TabIndex = 1;
            this.radioButton_animPalette.TabStop = true;
            this.radioButton_animPalette.Text = "Palette";
            this.radioButton_animPalette.UseVisualStyleBackColor = true;
            this.radioButton_animPalette.CheckedChanged += new System.EventHandler(this.radioButton_animation_CheckedChanged);
            // 
            // button_add
            // 
            this.button_add.Enabled = false;
            this.button_add.Location = new System.Drawing.Point(97, 166);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 6;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(178, 166);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 7;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 201);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdd";
            this.Text = "Add";
            this.tabControl.ResumeLayout(false);
            this.tabPage_bg.ResumeLayout(false);
            this.groupBox_bgOptions.ResumeLayout(false);
            this.groupBox_bgOptions.PerformLayout();
            this.groupBox_bgSelect.ResumeLayout(false);
            this.groupBox_bgSelect.PerformLayout();
            this.tabPage_roomSprites.ResumeLayout(false);
            this.tabPage_roomSprites.PerformLayout();
            this.tabPage_room.ResumeLayout(false);
            this.tabPage_room.PerformLayout();
            this.tabPage_tileset.ResumeLayout(false);
            this.tabPage_tileset.PerformLayout();
            this.tabPage_spriteset.ResumeLayout(false);
            this.tabPage_spriteset.PerformLayout();
            this.tabPage_anim.ResumeLayout(false);
            this.groupBox_animOptions.ResumeLayout(false);
            this.groupBox_animOptions.PerformLayout();
            this.groupBox_animSelect.ResumeLayout(false);
            this.groupBox_animSelect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private mage.Theming.CustomControls.FlatTabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_bg;
        private System.Windows.Forms.TabPage tabPage_room;
        private mage.Theming.CustomControls.FlatComboBox comboBox_bg;
        private System.Windows.Forms.RadioButton radioButton_bgCopy;
        private System.Windows.Forms.RadioButton radioButton_bgBlank;
        private mage.Theming.CustomControls.FlatTextBox textBox_bgOffset;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TabPage tabPage_tileset;
        private System.Windows.Forms.TabPage tabPage_spriteset;
        private System.Windows.Forms.TabPage tabPage_anim;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.RadioButton radioButton_bgLZ77;
        private System.Windows.Forms.RadioButton radioButton_bgRLE;
        private System.Windows.Forms.GroupBox groupBox_bgSelect;
        private System.Windows.Forms.GroupBox groupBox_bgOptions;
        private System.Windows.Forms.TabPage tabPage_roomSprites;
        private mage.Theming.CustomControls.FlatComboBox comboBox_enemySet;
        private System.Windows.Forms.RadioButton radioButton_enemyBlank;
        private System.Windows.Forms.RadioButton radioButton_enemyCopy;
        private mage.Theming.CustomControls.FlatTextBox textBox_enemyOffset;
        private mage.Theming.CustomControls.FlatComboBox comboBox_roomArea;
        private System.Windows.Forms.RadioButton radioButton_roomBlank;
        private System.Windows.Forms.RadioButton radioButton_roomCopy;
        private mage.Theming.CustomControls.FlatComboBox comboBox_roomCopyArea;
        private mage.Theming.CustomControls.FlatTextBox textBox_roomHeight;
        private mage.Theming.CustomControls.FlatTextBox textBox_roomWidth;
        private mage.Theming.CustomControls.FlatComboBox comboBox_roomCopyRoom;
        private System.Windows.Forms.Label label_roomHeight;
        private System.Windows.Forms.Label label_roomWidth;
        private System.Windows.Forms.Label label_roomArea;
        private System.Windows.Forms.RadioButton radioButton_animGfx;
        private System.Windows.Forms.RadioButton radioButton_animPalette;
        private System.Windows.Forms.RadioButton radioButton_animTileset;
        private System.Windows.Forms.GroupBox groupBox_animSelect;
        private System.Windows.Forms.Label label_enemySpriteset;
        private mage.Theming.CustomControls.FlatComboBox comboBox_tileset;
        private System.Windows.Forms.RadioButton radioButton_tilesetBlank;
        private System.Windows.Forms.RadioButton radioButton_tilesetCopy;
        private mage.Theming.CustomControls.FlatComboBox comboBox_spriteset;
        private System.Windows.Forms.RadioButton radioButton_spritesetBlank;
        private System.Windows.Forms.RadioButton radioButton_spritesetCopy;
        private System.Windows.Forms.GroupBox groupBox_animOptions;
        private System.Windows.Forms.RadioButton radioButton_animBlank;
        private System.Windows.Forms.RadioButton radioButton_animCopy;
        private mage.Theming.CustomControls.FlatComboBox comboBox_animNum;
    }
}