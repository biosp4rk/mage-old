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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_tileset = new System.Windows.Forms.TabPage();
            this.label_tilesetGfx = new System.Windows.Forms.Label();
            this.comboBox_tilesetGfxNum = new System.Windows.Forms.ComboBox();
            this.label_tilesetSlot = new System.Windows.Forms.Label();
            this.comboBox_tilesetSlot = new System.Windows.Forms.ComboBox();
            this.pictureBox_tileset = new System.Windows.Forms.PictureBox();
            this.comboBox_tilesetNum = new System.Windows.Forms.ComboBox();
            this.button_tilesetClose = new System.Windows.Forms.Button();
            this.button_tilesetApply = new System.Windows.Forms.Button();
            this.label_tilesetNum = new System.Windows.Forms.Label();
            this.tabPage_graphics = new System.Windows.Forms.TabPage();
            this.gfxView_gfx = new mage.GfxView();
            this.textBox_gfxPalOffset = new System.Windows.Forms.TextBox();
            this.label_gfxView = new System.Windows.Forms.Label();
            this.comboBox_gfxView = new System.Windows.Forms.ComboBox();
            this.button_gfxEdit = new System.Windows.Forms.Button();
            this.textBox_gfxStates = new System.Windows.Forms.TextBox();
            this.label_gfxStates = new System.Windows.Forms.Label();
            this.textBox_gfxDelay = new System.Windows.Forms.TextBox();
            this.label_gfxDelay = new System.Windows.Forms.Label();
            this.label_gfxDirection = new System.Windows.Forms.Label();
            this.comboBox_gfxDirection = new System.Windows.Forms.ComboBox();
            this.label_gfxNum = new System.Windows.Forms.Label();
            this.comboBox_gfxNum = new System.Windows.Forms.ComboBox();
            this.button_gfxClose = new System.Windows.Forms.Button();
            this.button_gfxApply = new System.Windows.Forms.Button();
            this.label_gfxPal = new System.Windows.Forms.Label();
            this.tabPage_palette = new System.Windows.Forms.TabPage();
            this.button_palEdit = new System.Windows.Forms.Button();
            this.textBox_palStates = new System.Windows.Forms.TextBox();
            this.label_palStates = new System.Windows.Forms.Label();
            this.textBox_palDelay = new System.Windows.Forms.TextBox();
            this.label_palDelay = new System.Windows.Forms.Label();
            this.label_palDirection = new System.Windows.Forms.Label();
            this.comboBox_palDirection = new System.Windows.Forms.ComboBox();
            this.label_palNum = new System.Windows.Forms.Label();
            this.button_palClose = new System.Windows.Forms.Button();
            this.button_palApply = new System.Windows.Forms.Button();
            this.comboBox_palNum = new System.Windows.Forms.ComboBox();
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
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Controls.Add(this.tabPage_tileset);
            this.tabControl.Controls.Add(this.tabPage_graphics);
            this.tabControl.Controls.Add(this.tabPage_palette);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage_tileset
            // 
            resources.ApplyResources(this.tabPage_tileset, "tabPage_tileset");
            this.tabPage_tileset.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_tileset.Controls.Add(this.label_tilesetGfx);
            this.tabPage_tileset.Controls.Add(this.comboBox_tilesetGfxNum);
            this.tabPage_tileset.Controls.Add(this.label_tilesetSlot);
            this.tabPage_tileset.Controls.Add(this.comboBox_tilesetSlot);
            this.tabPage_tileset.Controls.Add(this.pictureBox_tileset);
            this.tabPage_tileset.Controls.Add(this.comboBox_tilesetNum);
            this.tabPage_tileset.Controls.Add(this.button_tilesetClose);
            this.tabPage_tileset.Controls.Add(this.button_tilesetApply);
            this.tabPage_tileset.Controls.Add(this.label_tilesetNum);
            this.tabPage_tileset.Name = "tabPage_tileset";
            // 
            // label_tilesetGfx
            // 
            resources.ApplyResources(this.label_tilesetGfx, "label_tilesetGfx");
            this.label_tilesetGfx.Name = "label_tilesetGfx";
            // 
            // comboBox_tilesetGfxNum
            // 
            resources.ApplyResources(this.comboBox_tilesetGfxNum, "comboBox_tilesetGfxNum");
            this.comboBox_tilesetGfxNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tilesetGfxNum.FormattingEnabled = true;
            this.comboBox_tilesetGfxNum.Name = "comboBox_tilesetGfxNum";
            this.comboBox_tilesetGfxNum.SelectedIndexChanged += new System.EventHandler(this.comboBox_tilesetGfxNum_SelectedIndexChanged);
            // 
            // label_tilesetSlot
            // 
            resources.ApplyResources(this.label_tilesetSlot, "label_tilesetSlot");
            this.label_tilesetSlot.Name = "label_tilesetSlot";
            // 
            // comboBox_tilesetSlot
            // 
            resources.ApplyResources(this.comboBox_tilesetSlot, "comboBox_tilesetSlot");
            this.comboBox_tilesetSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tilesetSlot.FormattingEnabled = true;
            this.comboBox_tilesetSlot.Name = "comboBox_tilesetSlot";
            this.comboBox_tilesetSlot.SelectedIndexChanged += new System.EventHandler(this.comboBox_tilesetSlot_SelectedIndexChanged);
            // 
            // pictureBox_tileset
            // 
            resources.ApplyResources(this.pictureBox_tileset, "pictureBox_tileset");
            this.pictureBox_tileset.Name = "pictureBox_tileset";
            this.pictureBox_tileset.TabStop = false;
            // 
            // comboBox_tilesetNum
            // 
            resources.ApplyResources(this.comboBox_tilesetNum, "comboBox_tilesetNum");
            this.comboBox_tilesetNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tilesetNum.FormattingEnabled = true;
            this.comboBox_tilesetNum.Name = "comboBox_tilesetNum";
            this.comboBox_tilesetNum.SelectedIndexChanged += new System.EventHandler(this.comboBox_tilesetNum_SelectedIndexChanged);
            // 
            // button_tilesetClose
            // 
            resources.ApplyResources(this.button_tilesetClose, "button_tilesetClose");
            this.button_tilesetClose.Name = "button_tilesetClose";
            this.button_tilesetClose.UseVisualStyleBackColor = true;
            this.button_tilesetClose.Click += new System.EventHandler(this.button_tilesetClose_Click);
            // 
            // button_tilesetApply
            // 
            resources.ApplyResources(this.button_tilesetApply, "button_tilesetApply");
            this.button_tilesetApply.Name = "button_tilesetApply";
            this.button_tilesetApply.UseVisualStyleBackColor = true;
            this.button_tilesetApply.Click += new System.EventHandler(this.button_tilesetApply_Click);
            // 
            // label_tilesetNum
            // 
            resources.ApplyResources(this.label_tilesetNum, "label_tilesetNum");
            this.label_tilesetNum.Name = "label_tilesetNum";
            // 
            // tabPage_graphics
            // 
            resources.ApplyResources(this.tabPage_graphics, "tabPage_graphics");
            this.tabPage_graphics.Controls.Add(this.gfxView_gfx);
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
            this.tabPage_graphics.Controls.Add(this.label_gfxPal);
            this.tabPage_graphics.Name = "tabPage_graphics";
            // 
            // gfxView_gfx
            // 
            resources.ApplyResources(this.gfxView_gfx, "gfxView_gfx");
            this.gfxView_gfx.Name = "gfxView_gfx";
            this.gfxView_gfx.TabStop = false;
            // 
            // textBox_gfxPalOffset
            // 
            resources.ApplyResources(this.textBox_gfxPalOffset, "textBox_gfxPalOffset");
            this.textBox_gfxPalOffset.Name = "textBox_gfxPalOffset";
            this.textBox_gfxPalOffset.TextChanged += new System.EventHandler(this.textBox_gfxPalOffset_TextChanged);
            // 
            // label_gfxView
            // 
            resources.ApplyResources(this.label_gfxView, "label_gfxView");
            this.label_gfxView.Name = "label_gfxView";
            // 
            // comboBox_gfxView
            // 
            resources.ApplyResources(this.comboBox_gfxView, "comboBox_gfxView");
            this.comboBox_gfxView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gfxView.FormattingEnabled = true;
            this.comboBox_gfxView.Items.AddRange(new object[] {
            resources.GetString("comboBox_gfxView.Items"),
            resources.GetString("comboBox_gfxView.Items1")});
            this.comboBox_gfxView.Name = "comboBox_gfxView";
            this.comboBox_gfxView.SelectedIndexChanged += new System.EventHandler(this.comboBox_gfxView_SelectedIndexChanged);
            // 
            // button_gfxEdit
            // 
            resources.ApplyResources(this.button_gfxEdit, "button_gfxEdit");
            this.button_gfxEdit.Name = "button_gfxEdit";
            this.button_gfxEdit.UseVisualStyleBackColor = true;
            this.button_gfxEdit.Click += new System.EventHandler(this.button_gfxEdit_Click);
            // 
            // textBox_gfxStates
            // 
            resources.ApplyResources(this.textBox_gfxStates, "textBox_gfxStates");
            this.textBox_gfxStates.Name = "textBox_gfxStates";
            this.textBox_gfxStates.TextChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // label_gfxStates
            // 
            resources.ApplyResources(this.label_gfxStates, "label_gfxStates");
            this.label_gfxStates.Name = "label_gfxStates";
            // 
            // textBox_gfxDelay
            // 
            resources.ApplyResources(this.textBox_gfxDelay, "textBox_gfxDelay");
            this.textBox_gfxDelay.Name = "textBox_gfxDelay";
            this.textBox_gfxDelay.TextChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // label_gfxDelay
            // 
            resources.ApplyResources(this.label_gfxDelay, "label_gfxDelay");
            this.label_gfxDelay.Name = "label_gfxDelay";
            // 
            // label_gfxDirection
            // 
            resources.ApplyResources(this.label_gfxDirection, "label_gfxDirection");
            this.label_gfxDirection.Name = "label_gfxDirection";
            // 
            // comboBox_gfxDirection
            // 
            resources.ApplyResources(this.comboBox_gfxDirection, "comboBox_gfxDirection");
            this.comboBox_gfxDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gfxDirection.FormattingEnabled = true;
            this.comboBox_gfxDirection.Items.AddRange(new object[] {
            resources.GetString("comboBox_gfxDirection.Items"),
            resources.GetString("comboBox_gfxDirection.Items1"),
            resources.GetString("comboBox_gfxDirection.Items2")});
            this.comboBox_gfxDirection.Name = "comboBox_gfxDirection";
            this.comboBox_gfxDirection.SelectedIndexChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // label_gfxNum
            // 
            resources.ApplyResources(this.label_gfxNum, "label_gfxNum");
            this.label_gfxNum.Name = "label_gfxNum";
            // 
            // comboBox_gfxNum
            // 
            resources.ApplyResources(this.comboBox_gfxNum, "comboBox_gfxNum");
            this.comboBox_gfxNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gfxNum.FormattingEnabled = true;
            this.comboBox_gfxNum.Name = "comboBox_gfxNum";
            this.comboBox_gfxNum.SelectedIndexChanged += new System.EventHandler(this.comboBox_gfxNum_SelectedIndexChanged);
            // 
            // button_gfxClose
            // 
            resources.ApplyResources(this.button_gfxClose, "button_gfxClose");
            this.button_gfxClose.Name = "button_gfxClose";
            this.button_gfxClose.UseVisualStyleBackColor = true;
            this.button_gfxClose.Click += new System.EventHandler(this.button_gfxClose_Click);
            // 
            // button_gfxApply
            // 
            resources.ApplyResources(this.button_gfxApply, "button_gfxApply");
            this.button_gfxApply.Name = "button_gfxApply";
            this.button_gfxApply.UseVisualStyleBackColor = true;
            this.button_gfxApply.Click += new System.EventHandler(this.button_gfxApply_Click);
            // 
            // label_gfxPal
            // 
            resources.ApplyResources(this.label_gfxPal, "label_gfxPal");
            this.label_gfxPal.Name = "label_gfxPal";
            // 
            // tabPage_palette
            // 
            resources.ApplyResources(this.tabPage_palette, "tabPage_palette");
            this.tabPage_palette.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage_palette.Controls.Add(this.button_palEdit);
            this.tabPage_palette.Controls.Add(this.textBox_palStates);
            this.tabPage_palette.Controls.Add(this.label_palStates);
            this.tabPage_palette.Controls.Add(this.textBox_palDelay);
            this.tabPage_palette.Controls.Add(this.label_palDelay);
            this.tabPage_palette.Controls.Add(this.label_palDirection);
            this.tabPage_palette.Controls.Add(this.comboBox_palDirection);
            this.tabPage_palette.Controls.Add(this.button_palClose);
            this.tabPage_palette.Controls.Add(this.button_palApply);
            this.tabPage_palette.Controls.Add(this.comboBox_palNum);
            this.tabPage_palette.Controls.Add(this.pictureBox_pal);
            this.tabPage_palette.Controls.Add(this.label_palNum);
            this.tabPage_palette.Name = "tabPage_palette";
            // 
            // button_palEdit
            // 
            resources.ApplyResources(this.button_palEdit, "button_palEdit");
            this.button_palEdit.Name = "button_palEdit";
            this.button_palEdit.UseVisualStyleBackColor = true;
            this.button_palEdit.Click += new System.EventHandler(this.button_palEdit_Click);
            // 
            // textBox_palStates
            // 
            resources.ApplyResources(this.textBox_palStates, "textBox_palStates");
            this.textBox_palStates.Name = "textBox_palStates";
            this.textBox_palStates.TextChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // label_palStates
            // 
            resources.ApplyResources(this.label_palStates, "label_palStates");
            this.label_palStates.Name = "label_palStates";
            // 
            // textBox_palDelay
            // 
            resources.ApplyResources(this.textBox_palDelay, "textBox_palDelay");
            this.textBox_palDelay.Name = "textBox_palDelay";
            this.textBox_palDelay.TextChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // label_palDelay
            // 
            resources.ApplyResources(this.label_palDelay, "label_palDelay");
            this.label_palDelay.Name = "label_palDelay";
            // 
            // label_palDirection
            // 
            resources.ApplyResources(this.label_palDirection, "label_palDirection");
            this.label_palDirection.Name = "label_palDirection";
            // 
            // comboBox_palDirection
            // 
            resources.ApplyResources(this.comboBox_palDirection, "comboBox_palDirection");
            this.comboBox_palDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_palDirection.FormattingEnabled = true;
            this.comboBox_palDirection.Items.AddRange(new object[] {
            resources.GetString("comboBox_palDirection.Items"),
            resources.GetString("comboBox_palDirection.Items1"),
            resources.GetString("comboBox_palDirection.Items2")});
            this.comboBox_palDirection.Name = "comboBox_palDirection";
            this.comboBox_palDirection.SelectedIndexChanged += new System.EventHandler(this.control_ValueChanged);
            // 
            // label_palNum
            // 
            resources.ApplyResources(this.label_palNum, "label_palNum");
            this.label_palNum.Name = "label_palNum";
            // 
            // button_palClose
            // 
            resources.ApplyResources(this.button_palClose, "button_palClose");
            this.button_palClose.Name = "button_palClose";
            this.button_palClose.UseVisualStyleBackColor = true;
            this.button_palClose.Click += new System.EventHandler(this.button_palClose_Click);
            // 
            // button_palApply
            // 
            resources.ApplyResources(this.button_palApply, "button_palApply");
            this.button_palApply.Name = "button_palApply";
            this.button_palApply.UseVisualStyleBackColor = true;
            this.button_palApply.Click += new System.EventHandler(this.button_palApply_Click);
            // 
            // comboBox_palNum
            // 
            resources.ApplyResources(this.comboBox_palNum, "comboBox_palNum");
            this.comboBox_palNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_palNum.FormattingEnabled = true;
            this.comboBox_palNum.Name = "comboBox_palNum";
            this.comboBox_palNum.SelectedIndexChanged += new System.EventHandler(this.comboBox_paletteNum_SelectedIndexChanged);
            // 
            // pictureBox_pal
            // 
            resources.ApplyResources(this.pictureBox_pal, "pictureBox_pal");
            this.pictureBox_pal.Name = "pictureBox_pal";
            this.pictureBox_pal.TabStop = false;
            // 
            // statusStrip
            // 
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_changes});
            this.statusStrip.Name = "statusStrip";
            // 
            // statusLabel_changes
            // 
            resources.ApplyResources(this.statusLabel_changes, "statusLabel_changes");
            this.statusLabel_changes.Name = "statusLabel_changes";
            // 
            // FormAnimation
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAnimation";
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

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_tileset;
        private System.Windows.Forms.Button button_tilesetClose;
        private System.Windows.Forms.Button button_tilesetApply;
        private System.Windows.Forms.TabPage tabPage_graphics;
        private System.Windows.Forms.Button button_gfxClose;
        private System.Windows.Forms.Button button_gfxApply;
        private System.Windows.Forms.TabPage tabPage_palette;
        private System.Windows.Forms.ComboBox comboBox_tilesetNum;
        private System.Windows.Forms.PictureBox pictureBox_tileset;
        private System.Windows.Forms.Label label_tilesetSlot;
        private System.Windows.Forms.ComboBox comboBox_tilesetSlot;
        private System.Windows.Forms.Label label_tilesetNum;
        private System.Windows.Forms.PictureBox pictureBox_pal;
        private System.Windows.Forms.ComboBox comboBox_palNum;
        private System.Windows.Forms.ComboBox comboBox_tilesetGfxNum;
        private System.Windows.Forms.ComboBox comboBox_gfxNum;
        private System.Windows.Forms.Label label_gfxNum;
        private System.Windows.Forms.ComboBox comboBox_gfxDirection;
        private System.Windows.Forms.Label label_gfxDirection;
        private System.Windows.Forms.Button button_palClose;
        private System.Windows.Forms.Button button_palApply;
        private System.Windows.Forms.Label label_palNum;
        private System.Windows.Forms.TextBox textBox_gfxDelay;
        private System.Windows.Forms.Label label_gfxDelay;
        private System.Windows.Forms.TextBox textBox_gfxStates;
        private System.Windows.Forms.Label label_gfxStates;
        private System.Windows.Forms.TextBox textBox_palStates;
        private System.Windows.Forms.Label label_palStates;
        private System.Windows.Forms.TextBox textBox_palDelay;
        private System.Windows.Forms.Label label_palDelay;
        private System.Windows.Forms.Label label_palDirection;
        private System.Windows.Forms.ComboBox comboBox_palDirection;
        private System.Windows.Forms.Label label_tilesetGfx;
        private System.Windows.Forms.Button button_gfxEdit;
        private System.Windows.Forms.Button button_palEdit;
        private System.Windows.Forms.ComboBox comboBox_gfxView;
        private System.Windows.Forms.Label label_gfxView;
        private System.Windows.Forms.TextBox textBox_gfxPalOffset;
        private System.Windows.Forms.Label label_gfxPal;
        private GfxView gfxView_gfx;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_changes;
    }
}