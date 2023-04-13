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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_bg = new System.Windows.Forms.TabPage();
            this.groupBox_bgOptions = new System.Windows.Forms.GroupBox();
            this.radioButton_bgBlank = new System.Windows.Forms.RadioButton();
            this.radioButton_bgCopy = new System.Windows.Forms.RadioButton();
            this.textBox_bgOffset = new System.Windows.Forms.TextBox();
            this.groupBox_bgSelect = new System.Windows.Forms.GroupBox();
            this.comboBox_bg = new System.Windows.Forms.ComboBox();
            this.radioButton_bgLZ77 = new System.Windows.Forms.RadioButton();
            this.radioButton_bgRLE = new System.Windows.Forms.RadioButton();
            this.tabPage_roomSprites = new System.Windows.Forms.TabPage();
            this.label_enemySpriteset = new System.Windows.Forms.Label();
            this.radioButton_enemyBlank = new System.Windows.Forms.RadioButton();
            this.radioButton_enemyCopy = new System.Windows.Forms.RadioButton();
            this.textBox_enemyOffset = new System.Windows.Forms.TextBox();
            this.comboBox_enemySet = new System.Windows.Forms.ComboBox();
            this.tabPage_room = new System.Windows.Forms.TabPage();
            this.label_roomArea = new System.Windows.Forms.Label();
            this.label_roomHeight = new System.Windows.Forms.Label();
            this.label_roomWidth = new System.Windows.Forms.Label();
            this.comboBox_roomCopyRoom = new System.Windows.Forms.ComboBox();
            this.textBox_roomHeight = new System.Windows.Forms.TextBox();
            this.textBox_roomWidth = new System.Windows.Forms.TextBox();
            this.comboBox_roomCopyArea = new System.Windows.Forms.ComboBox();
            this.comboBox_roomArea = new System.Windows.Forms.ComboBox();
            this.radioButton_roomBlank = new System.Windows.Forms.RadioButton();
            this.radioButton_roomCopy = new System.Windows.Forms.RadioButton();
            this.tabPage_tileset = new System.Windows.Forms.TabPage();
            this.comboBox_tileset = new System.Windows.Forms.ComboBox();
            this.radioButton_tilesetBlank = new System.Windows.Forms.RadioButton();
            this.radioButton_tilesetCopy = new System.Windows.Forms.RadioButton();
            this.tabPage_spriteset = new System.Windows.Forms.TabPage();
            this.comboBox_spriteset = new System.Windows.Forms.ComboBox();
            this.radioButton_spritesetBlank = new System.Windows.Forms.RadioButton();
            this.radioButton_spritesetCopy = new System.Windows.Forms.RadioButton();
            this.tabPage_anim = new System.Windows.Forms.TabPage();
            this.groupBox_animOptions = new System.Windows.Forms.GroupBox();
            this.comboBox_animNum = new System.Windows.Forms.ComboBox();
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
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Controls.Add(this.tabPage_bg);
            this.tabControl.Controls.Add(this.tabPage_roomSprites);
            this.tabControl.Controls.Add(this.tabPage_room);
            this.tabControl.Controls.Add(this.tabPage_tileset);
            this.tabControl.Controls.Add(this.tabPage_spriteset);
            this.tabControl.Controls.Add(this.tabPage_anim);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage_bg
            // 
            resources.ApplyResources(this.tabPage_bg, "tabPage_bg");
            this.tabPage_bg.Controls.Add(this.groupBox_bgOptions);
            this.tabPage_bg.Controls.Add(this.groupBox_bgSelect);
            this.tabPage_bg.Name = "tabPage_bg";
            // 
            // groupBox_bgOptions
            // 
            resources.ApplyResources(this.groupBox_bgOptions, "groupBox_bgOptions");
            this.groupBox_bgOptions.Controls.Add(this.radioButton_bgBlank);
            this.groupBox_bgOptions.Controls.Add(this.radioButton_bgCopy);
            this.groupBox_bgOptions.Controls.Add(this.textBox_bgOffset);
            this.groupBox_bgOptions.Name = "groupBox_bgOptions";
            this.groupBox_bgOptions.TabStop = false;
            // 
            // radioButton_bgBlank
            // 
            resources.ApplyResources(this.radioButton_bgBlank, "radioButton_bgBlank");
            this.radioButton_bgBlank.Name = "radioButton_bgBlank";
            this.radioButton_bgBlank.UseVisualStyleBackColor = true;
            this.radioButton_bgBlank.CheckedChanged += new System.EventHandler(this.radioButton_option_CheckedChanged);
            // 
            // radioButton_bgCopy
            // 
            resources.ApplyResources(this.radioButton_bgCopy, "radioButton_bgCopy");
            this.radioButton_bgCopy.Name = "radioButton_bgCopy";
            this.radioButton_bgCopy.UseVisualStyleBackColor = true;
            this.radioButton_bgCopy.CheckedChanged += new System.EventHandler(this.radioButton_option_CheckedChanged);
            // 
            // textBox_bgOffset
            // 
            resources.ApplyResources(this.textBox_bgOffset, "textBox_bgOffset");
            this.textBox_bgOffset.Name = "textBox_bgOffset";
            // 
            // groupBox_bgSelect
            // 
            resources.ApplyResources(this.groupBox_bgSelect, "groupBox_bgSelect");
            this.groupBox_bgSelect.Controls.Add(this.comboBox_bg);
            this.groupBox_bgSelect.Controls.Add(this.radioButton_bgLZ77);
            this.groupBox_bgSelect.Controls.Add(this.radioButton_bgRLE);
            this.groupBox_bgSelect.Name = "groupBox_bgSelect";
            this.groupBox_bgSelect.TabStop = false;
            // 
            // comboBox_bg
            // 
            resources.ApplyResources(this.comboBox_bg, "comboBox_bg");
            this.comboBox_bg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_bg.FormattingEnabled = true;
            this.comboBox_bg.Items.AddRange(new object[] {
            resources.GetString("comboBox_bg.Items"),
            resources.GetString("comboBox_bg.Items1"),
            resources.GetString("comboBox_bg.Items2"),
            resources.GetString("comboBox_bg.Items3"),
            resources.GetString("comboBox_bg.Items4")});
            this.comboBox_bg.Name = "comboBox_bg";
            this.comboBox_bg.SelectedIndexChanged += new System.EventHandler(this.comboBox_bg_SelectedIndexChanged);
            // 
            // radioButton_bgLZ77
            // 
            resources.ApplyResources(this.radioButton_bgLZ77, "radioButton_bgLZ77");
            this.radioButton_bgLZ77.Name = "radioButton_bgLZ77";
            this.radioButton_bgLZ77.TabStop = true;
            this.radioButton_bgLZ77.UseVisualStyleBackColor = true;
            // 
            // radioButton_bgRLE
            // 
            resources.ApplyResources(this.radioButton_bgRLE, "radioButton_bgRLE");
            this.radioButton_bgRLE.Name = "radioButton_bgRLE";
            this.radioButton_bgRLE.TabStop = true;
            this.radioButton_bgRLE.UseVisualStyleBackColor = true;
            // 
            // tabPage_roomSprites
            // 
            resources.ApplyResources(this.tabPage_roomSprites, "tabPage_roomSprites");
            this.tabPage_roomSprites.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_roomSprites.Controls.Add(this.radioButton_enemyBlank);
            this.tabPage_roomSprites.Controls.Add(this.radioButton_enemyCopy);
            this.tabPage_roomSprites.Controls.Add(this.textBox_enemyOffset);
            this.tabPage_roomSprites.Controls.Add(this.comboBox_enemySet);
            this.tabPage_roomSprites.Controls.Add(this.label_enemySpriteset);
            this.tabPage_roomSprites.Name = "tabPage_roomSprites";
            // 
            // label_enemySpriteset
            // 
            resources.ApplyResources(this.label_enemySpriteset, "label_enemySpriteset");
            this.label_enemySpriteset.Name = "label_enemySpriteset";
            // 
            // radioButton_enemyBlank
            // 
            resources.ApplyResources(this.radioButton_enemyBlank, "radioButton_enemyBlank");
            this.radioButton_enemyBlank.Name = "radioButton_enemyBlank";
            this.radioButton_enemyBlank.UseVisualStyleBackColor = true;
            this.radioButton_enemyBlank.CheckedChanged += new System.EventHandler(this.radioButton_option_CheckedChanged);
            // 
            // radioButton_enemyCopy
            // 
            resources.ApplyResources(this.radioButton_enemyCopy, "radioButton_enemyCopy");
            this.radioButton_enemyCopy.Name = "radioButton_enemyCopy";
            this.radioButton_enemyCopy.UseVisualStyleBackColor = true;
            this.radioButton_enemyCopy.CheckedChanged += new System.EventHandler(this.radioButton_option_CheckedChanged);
            // 
            // textBox_enemyOffset
            // 
            resources.ApplyResources(this.textBox_enemyOffset, "textBox_enemyOffset");
            this.textBox_enemyOffset.Name = "textBox_enemyOffset";
            // 
            // comboBox_enemySet
            // 
            resources.ApplyResources(this.comboBox_enemySet, "comboBox_enemySet");
            this.comboBox_enemySet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_enemySet.FormattingEnabled = true;
            this.comboBox_enemySet.Items.AddRange(new object[] {
            resources.GetString("comboBox_enemySet.Items"),
            resources.GetString("comboBox_enemySet.Items1"),
            resources.GetString("comboBox_enemySet.Items2")});
            this.comboBox_enemySet.Name = "comboBox_enemySet";
            // 
            // tabPage_room
            // 
            resources.ApplyResources(this.tabPage_room, "tabPage_room");
            this.tabPage_room.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_room.Controls.Add(this.label_roomHeight);
            this.tabPage_room.Controls.Add(this.label_roomWidth);
            this.tabPage_room.Controls.Add(this.comboBox_roomCopyRoom);
            this.tabPage_room.Controls.Add(this.textBox_roomHeight);
            this.tabPage_room.Controls.Add(this.textBox_roomWidth);
            this.tabPage_room.Controls.Add(this.comboBox_roomCopyArea);
            this.tabPage_room.Controls.Add(this.comboBox_roomArea);
            this.tabPage_room.Controls.Add(this.radioButton_roomBlank);
            this.tabPage_room.Controls.Add(this.radioButton_roomCopy);
            this.tabPage_room.Controls.Add(this.label_roomArea);
            this.tabPage_room.Name = "tabPage_room";
            // 
            // label_roomArea
            // 
            resources.ApplyResources(this.label_roomArea, "label_roomArea");
            this.label_roomArea.Name = "label_roomArea";
            // 
            // label_roomHeight
            // 
            resources.ApplyResources(this.label_roomHeight, "label_roomHeight");
            this.label_roomHeight.Name = "label_roomHeight";
            // 
            // label_roomWidth
            // 
            resources.ApplyResources(this.label_roomWidth, "label_roomWidth");
            this.label_roomWidth.Name = "label_roomWidth";
            // 
            // comboBox_roomCopyRoom
            // 
            resources.ApplyResources(this.comboBox_roomCopyRoom, "comboBox_roomCopyRoom");
            this.comboBox_roomCopyRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_roomCopyRoom.FormattingEnabled = true;
            this.comboBox_roomCopyRoom.Name = "comboBox_roomCopyRoom";
            // 
            // textBox_roomHeight
            // 
            resources.ApplyResources(this.textBox_roomHeight, "textBox_roomHeight");
            this.textBox_roomHeight.Name = "textBox_roomHeight";
            // 
            // textBox_roomWidth
            // 
            resources.ApplyResources(this.textBox_roomWidth, "textBox_roomWidth");
            this.textBox_roomWidth.Name = "textBox_roomWidth";
            // 
            // comboBox_roomCopyArea
            // 
            resources.ApplyResources(this.comboBox_roomCopyArea, "comboBox_roomCopyArea");
            this.comboBox_roomCopyArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_roomCopyArea.FormattingEnabled = true;
            this.comboBox_roomCopyArea.Name = "comboBox_roomCopyArea";
            this.comboBox_roomCopyArea.SelectedIndexChanged += new System.EventHandler(this.comboBox_roomCopyArea_SelectedIndexChanged);
            // 
            // comboBox_roomArea
            // 
            resources.ApplyResources(this.comboBox_roomArea, "comboBox_roomArea");
            this.comboBox_roomArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_roomArea.FormattingEnabled = true;
            this.comboBox_roomArea.Name = "comboBox_roomArea";
            // 
            // radioButton_roomBlank
            // 
            resources.ApplyResources(this.radioButton_roomBlank, "radioButton_roomBlank");
            this.radioButton_roomBlank.Name = "radioButton_roomBlank";
            this.radioButton_roomBlank.UseVisualStyleBackColor = true;
            this.radioButton_roomBlank.CheckedChanged += new System.EventHandler(this.radioButton_option_CheckedChanged);
            // 
            // radioButton_roomCopy
            // 
            resources.ApplyResources(this.radioButton_roomCopy, "radioButton_roomCopy");
            this.radioButton_roomCopy.Name = "radioButton_roomCopy";
            this.radioButton_roomCopy.UseVisualStyleBackColor = true;
            this.radioButton_roomCopy.CheckedChanged += new System.EventHandler(this.radioButton_option_CheckedChanged);
            // 
            // tabPage_tileset
            // 
            resources.ApplyResources(this.tabPage_tileset, "tabPage_tileset");
            this.tabPage_tileset.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_tileset.Controls.Add(this.comboBox_tileset);
            this.tabPage_tileset.Controls.Add(this.radioButton_tilesetBlank);
            this.tabPage_tileset.Controls.Add(this.radioButton_tilesetCopy);
            this.tabPage_tileset.Name = "tabPage_tileset";
            // 
            // comboBox_tileset
            // 
            resources.ApplyResources(this.comboBox_tileset, "comboBox_tileset");
            this.comboBox_tileset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tileset.FormattingEnabled = true;
            this.comboBox_tileset.Name = "comboBox_tileset";
            // 
            // radioButton_tilesetBlank
            // 
            resources.ApplyResources(this.radioButton_tilesetBlank, "radioButton_tilesetBlank");
            this.radioButton_tilesetBlank.Name = "radioButton_tilesetBlank";
            this.radioButton_tilesetBlank.UseVisualStyleBackColor = true;
            this.radioButton_tilesetBlank.CheckedChanged += new System.EventHandler(this.radioButton_option_CheckedChanged);
            // 
            // radioButton_tilesetCopy
            // 
            resources.ApplyResources(this.radioButton_tilesetCopy, "radioButton_tilesetCopy");
            this.radioButton_tilesetCopy.Name = "radioButton_tilesetCopy";
            this.radioButton_tilesetCopy.UseVisualStyleBackColor = true;
            this.radioButton_tilesetCopy.CheckedChanged += new System.EventHandler(this.radioButton_option_CheckedChanged);
            // 
            // tabPage_spriteset
            // 
            resources.ApplyResources(this.tabPage_spriteset, "tabPage_spriteset");
            this.tabPage_spriteset.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_spriteset.Controls.Add(this.comboBox_spriteset);
            this.tabPage_spriteset.Controls.Add(this.radioButton_spritesetBlank);
            this.tabPage_spriteset.Controls.Add(this.radioButton_spritesetCopy);
            this.tabPage_spriteset.Name = "tabPage_spriteset";
            // 
            // comboBox_spriteset
            // 
            resources.ApplyResources(this.comboBox_spriteset, "comboBox_spriteset");
            this.comboBox_spriteset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_spriteset.FormattingEnabled = true;
            this.comboBox_spriteset.Name = "comboBox_spriteset";
            // 
            // radioButton_spritesetBlank
            // 
            resources.ApplyResources(this.radioButton_spritesetBlank, "radioButton_spritesetBlank");
            this.radioButton_spritesetBlank.Name = "radioButton_spritesetBlank";
            this.radioButton_spritesetBlank.UseVisualStyleBackColor = true;
            this.radioButton_spritesetBlank.CheckedChanged += new System.EventHandler(this.radioButton_option_CheckedChanged);
            // 
            // radioButton_spritesetCopy
            // 
            resources.ApplyResources(this.radioButton_spritesetCopy, "radioButton_spritesetCopy");
            this.radioButton_spritesetCopy.Name = "radioButton_spritesetCopy";
            this.radioButton_spritesetCopy.UseVisualStyleBackColor = true;
            this.radioButton_spritesetCopy.CheckedChanged += new System.EventHandler(this.radioButton_option_CheckedChanged);
            // 
            // tabPage_anim
            // 
            resources.ApplyResources(this.tabPage_anim, "tabPage_anim");
            this.tabPage_anim.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_anim.Controls.Add(this.groupBox_animOptions);
            this.tabPage_anim.Controls.Add(this.groupBox_animSelect);
            this.tabPage_anim.Name = "tabPage_anim";
            // 
            // groupBox_animOptions
            // 
            resources.ApplyResources(this.groupBox_animOptions, "groupBox_animOptions");
            this.groupBox_animOptions.Controls.Add(this.comboBox_animNum);
            this.groupBox_animOptions.Controls.Add(this.radioButton_animBlank);
            this.groupBox_animOptions.Controls.Add(this.radioButton_animCopy);
            this.groupBox_animOptions.Name = "groupBox_animOptions";
            this.groupBox_animOptions.TabStop = false;
            // 
            // comboBox_animNum
            // 
            resources.ApplyResources(this.comboBox_animNum, "comboBox_animNum");
            this.comboBox_animNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_animNum.FormattingEnabled = true;
            this.comboBox_animNum.Name = "comboBox_animNum";
            // 
            // radioButton_animBlank
            // 
            resources.ApplyResources(this.radioButton_animBlank, "radioButton_animBlank");
            this.radioButton_animBlank.Name = "radioButton_animBlank";
            this.radioButton_animBlank.UseVisualStyleBackColor = true;
            this.radioButton_animBlank.CheckedChanged += new System.EventHandler(this.radioButton_option_CheckedChanged);
            // 
            // radioButton_animCopy
            // 
            resources.ApplyResources(this.radioButton_animCopy, "radioButton_animCopy");
            this.radioButton_animCopy.Name = "radioButton_animCopy";
            this.radioButton_animCopy.UseVisualStyleBackColor = true;
            this.radioButton_animCopy.CheckedChanged += new System.EventHandler(this.radioButton_option_CheckedChanged);
            // 
            // groupBox_animSelect
            // 
            resources.ApplyResources(this.groupBox_animSelect, "groupBox_animSelect");
            this.groupBox_animSelect.Controls.Add(this.radioButton_animTileset);
            this.groupBox_animSelect.Controls.Add(this.radioButton_animGfx);
            this.groupBox_animSelect.Controls.Add(this.radioButton_animPalette);
            this.groupBox_animSelect.Name = "groupBox_animSelect";
            this.groupBox_animSelect.TabStop = false;
            // 
            // radioButton_animTileset
            // 
            resources.ApplyResources(this.radioButton_animTileset, "radioButton_animTileset");
            this.radioButton_animTileset.Name = "radioButton_animTileset";
            this.radioButton_animTileset.TabStop = true;
            this.radioButton_animTileset.UseVisualStyleBackColor = true;
            this.radioButton_animTileset.CheckedChanged += new System.EventHandler(this.radioButton_animation_CheckedChanged);
            // 
            // radioButton_animGfx
            // 
            resources.ApplyResources(this.radioButton_animGfx, "radioButton_animGfx");
            this.radioButton_animGfx.Name = "radioButton_animGfx";
            this.radioButton_animGfx.TabStop = true;
            this.radioButton_animGfx.UseVisualStyleBackColor = true;
            this.radioButton_animGfx.CheckedChanged += new System.EventHandler(this.radioButton_animation_CheckedChanged);
            // 
            // radioButton_animPalette
            // 
            resources.ApplyResources(this.radioButton_animPalette, "radioButton_animPalette");
            this.radioButton_animPalette.Name = "radioButton_animPalette";
            this.radioButton_animPalette.TabStop = true;
            this.radioButton_animPalette.UseVisualStyleBackColor = true;
            this.radioButton_animPalette.CheckedChanged += new System.EventHandler(this.radioButton_animation_CheckedChanged);
            // 
            // button_add
            // 
            resources.ApplyResources(this.button_add, "button_add");
            this.button_add.Name = "button_add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_close
            // 
            resources.ApplyResources(this.button_close, "button_close");
            this.button_close.Name = "button_close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // FormAdd
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.tabControl);
            this.Name = "FormAdd";
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

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_bg;
        private System.Windows.Forms.TabPage tabPage_room;
        private System.Windows.Forms.ComboBox comboBox_bg;
        private System.Windows.Forms.RadioButton radioButton_bgCopy;
        private System.Windows.Forms.RadioButton radioButton_bgBlank;
        private System.Windows.Forms.TextBox textBox_bgOffset;
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
        private System.Windows.Forms.ComboBox comboBox_enemySet;
        private System.Windows.Forms.RadioButton radioButton_enemyBlank;
        private System.Windows.Forms.RadioButton radioButton_enemyCopy;
        private System.Windows.Forms.TextBox textBox_enemyOffset;
        private System.Windows.Forms.ComboBox comboBox_roomArea;
        private System.Windows.Forms.RadioButton radioButton_roomBlank;
        private System.Windows.Forms.RadioButton radioButton_roomCopy;
        private System.Windows.Forms.ComboBox comboBox_roomCopyArea;
        private System.Windows.Forms.TextBox textBox_roomHeight;
        private System.Windows.Forms.TextBox textBox_roomWidth;
        private System.Windows.Forms.ComboBox comboBox_roomCopyRoom;
        private System.Windows.Forms.Label label_roomHeight;
        private System.Windows.Forms.Label label_roomWidth;
        private System.Windows.Forms.Label label_roomArea;
        private System.Windows.Forms.RadioButton radioButton_animGfx;
        private System.Windows.Forms.RadioButton radioButton_animPalette;
        private System.Windows.Forms.RadioButton radioButton_animTileset;
        private System.Windows.Forms.GroupBox groupBox_animSelect;
        private System.Windows.Forms.Label label_enemySpriteset;
        private System.Windows.Forms.ComboBox comboBox_tileset;
        private System.Windows.Forms.RadioButton radioButton_tilesetBlank;
        private System.Windows.Forms.RadioButton radioButton_tilesetCopy;
        private System.Windows.Forms.ComboBox comboBox_spriteset;
        private System.Windows.Forms.RadioButton radioButton_spritesetBlank;
        private System.Windows.Forms.RadioButton radioButton_spritesetCopy;
        private System.Windows.Forms.GroupBox groupBox_animOptions;
        private System.Windows.Forms.RadioButton radioButton_animBlank;
        private System.Windows.Forms.RadioButton radioButton_animCopy;
        private System.Windows.Forms.ComboBox comboBox_animNum;
    }
}