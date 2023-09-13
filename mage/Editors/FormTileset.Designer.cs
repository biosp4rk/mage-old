namespace mage
{
    partial class FormTileset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTileset));
            this.textBox_offsetVal = new mage.Theming.CustomControls.FlatTextBox();
            this.label_offset = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.button_apply = new System.Windows.Forms.Button();
            this.textBox_rleGfx = new mage.Theming.CustomControls.FlatTextBox();
            this.textBox_palette = new mage.Theming.CustomControls.FlatTextBox();
            this.textBox_lz77gfx = new mage.Theming.CustomControls.FlatTextBox();
            this.textBox_tileTable = new mage.Theming.CustomControls.FlatTextBox();
            this.label_rleGfx = new System.Windows.Forms.Label();
            this.label_palette = new System.Windows.Forms.Label();
            this.label_lz77gfx = new System.Windows.Forms.Label();
            this.label_tileTable = new System.Windows.Forms.Label();
            this.textBox_animTileset = new mage.Theming.CustomControls.FlatTextBox();
            this.textBox_animPalette = new mage.Theming.CustomControls.FlatTextBox();
            this.label_animTileset = new System.Windows.Forms.Label();
            this.label_animPalette = new System.Windows.Forms.Label();
            this.label_tileset = new System.Windows.Forms.Label();
            this.comboBox_tileset = new mage.Theming.CustomControls.FlatComboBox();
            this.groupBox_data = new System.Windows.Forms.GroupBox();
            this.button_editTileTable = new System.Windows.Forms.Button();
            this.button_editAnimTileset = new System.Windows.Forms.Button();
            this.button_editLZ77 = new System.Windows.Forms.Button();
            this.button_editRLE = new System.Windows.Forms.Button();
            this.button_editPalette = new System.Windows.Forms.Button();
            this.button_editAnimPalette = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel_changes = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox_data.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_offsetVal
            // 
            this.textBox_offsetVal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_offsetVal.Location = new System.Drawing.Point(56, 227);
            this.textBox_offsetVal.Name = "textBox_offsetVal";
            this.textBox_offsetVal.ReadOnly = true;
            this.textBox_offsetVal.Size = new System.Drawing.Size(55, 13);
            this.textBox_offsetVal.TabIndex = 0;
            this.textBox_offsetVal.TabStop = false;
            this.textBox_offsetVal.Text = "000000";
            // 
            // label_offset
            // 
            this.label_offset.AutoSize = true;
            this.label_offset.Location = new System.Drawing.Point(10, 227);
            this.label_offset.Name = "label_offset";
            this.label_offset.Size = new System.Drawing.Size(38, 13);
            this.label_offset.TabIndex = 0;
            this.label_offset.Text = "Offset:";
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(149, 223);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 3;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_apply
            // 
            this.button_apply.Enabled = false;
            this.button_apply.Location = new System.Drawing.Point(149, 194);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(75, 23);
            this.button_apply.TabIndex = 2;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // textBox_rleGfx
            // 
            this.textBox_rleGfx.Location = new System.Drawing.Point(70, 19);
            this.textBox_rleGfx.Name = "textBox_rleGfx";
            this.textBox_rleGfx.Size = new System.Drawing.Size(65, 20);
            this.textBox_rleGfx.TabIndex = 0;
            this.textBox_rleGfx.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox_palette
            // 
            this.textBox_palette.Location = new System.Drawing.Point(70, 45);
            this.textBox_palette.Name = "textBox_palette";
            this.textBox_palette.Size = new System.Drawing.Size(65, 20);
            this.textBox_palette.TabIndex = 2;
            this.textBox_palette.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox_lz77gfx
            // 
            this.textBox_lz77gfx.Location = new System.Drawing.Point(70, 71);
            this.textBox_lz77gfx.Name = "textBox_lz77gfx";
            this.textBox_lz77gfx.Size = new System.Drawing.Size(65, 20);
            this.textBox_lz77gfx.TabIndex = 4;
            this.textBox_lz77gfx.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox_tileTable
            // 
            this.textBox_tileTable.Location = new System.Drawing.Point(70, 97);
            this.textBox_tileTable.Name = "textBox_tileTable";
            this.textBox_tileTable.Size = new System.Drawing.Size(65, 20);
            this.textBox_tileTable.TabIndex = 6;
            this.textBox_tileTable.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label_rleGfx
            // 
            this.label_rleGfx.AutoSize = true;
            this.label_rleGfx.Location = new System.Drawing.Point(6, 22);
            this.label_rleGfx.Name = "label_rleGfx";
            this.label_rleGfx.Size = new System.Drawing.Size(55, 13);
            this.label_rleGfx.TabIndex = 0;
            this.label_rleGfx.Text = "RLE GFX:";
            // 
            // label_palette
            // 
            this.label_palette.AutoSize = true;
            this.label_palette.Location = new System.Drawing.Point(6, 48);
            this.label_palette.Name = "label_palette";
            this.label_palette.Size = new System.Drawing.Size(43, 13);
            this.label_palette.TabIndex = 0;
            this.label_palette.Text = "Palette:";
            // 
            // label_lz77gfx
            // 
            this.label_lz77gfx.AutoSize = true;
            this.label_lz77gfx.Location = new System.Drawing.Point(5, 74);
            this.label_lz77gfx.Name = "label_lz77gfx";
            this.label_lz77gfx.Size = new System.Drawing.Size(59, 13);
            this.label_lz77gfx.TabIndex = 0;
            this.label_lz77gfx.Text = "LZ77 GFX:";
            // 
            // label_tileTable
            // 
            this.label_tileTable.AutoSize = true;
            this.label_tileTable.Location = new System.Drawing.Point(6, 100);
            this.label_tileTable.Name = "label_tileTable";
            this.label_tileTable.Size = new System.Drawing.Size(53, 13);
            this.label_tileTable.TabIndex = 0;
            this.label_tileTable.Text = "Tile table:";
            // 
            // textBox_animTileset
            // 
            this.textBox_animTileset.Location = new System.Drawing.Point(105, 123);
            this.textBox_animTileset.Name = "textBox_animTileset";
            this.textBox_animTileset.Size = new System.Drawing.Size(30, 20);
            this.textBox_animTileset.TabIndex = 7;
            this.textBox_animTileset.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBox_animPalette
            // 
            this.textBox_animPalette.Location = new System.Drawing.Point(105, 149);
            this.textBox_animPalette.Name = "textBox_animPalette";
            this.textBox_animPalette.Size = new System.Drawing.Size(30, 20);
            this.textBox_animPalette.TabIndex = 8;
            this.textBox_animPalette.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label_animTileset
            // 
            this.label_animTileset.AutoSize = true;
            this.label_animTileset.Location = new System.Drawing.Point(6, 126);
            this.label_animTileset.Name = "label_animTileset";
            this.label_animTileset.Size = new System.Drawing.Size(84, 13);
            this.label_animTileset.TabIndex = 0;
            this.label_animTileset.Text = "Animated tileset:";
            // 
            // label_animPalette
            // 
            this.label_animPalette.AutoSize = true;
            this.label_animPalette.Location = new System.Drawing.Point(6, 152);
            this.label_animPalette.Name = "label_animPalette";
            this.label_animPalette.Size = new System.Drawing.Size(89, 13);
            this.label_animPalette.TabIndex = 0;
            this.label_animPalette.Text = "Animated palette:";
            // 
            // label_tileset
            // 
            this.label_tileset.AutoSize = true;
            this.label_tileset.Location = new System.Drawing.Point(9, 198);
            this.label_tileset.Name = "label_tileset";
            this.label_tileset.Size = new System.Drawing.Size(41, 13);
            this.label_tileset.TabIndex = 0;
            this.label_tileset.Text = "Tileset:";
            // 
            // comboBox_tileset
            // 
            this.comboBox_tileset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_tileset.FormattingEnabled = true;
            this.comboBox_tileset.Location = new System.Drawing.Point(56, 195);
            this.comboBox_tileset.Name = "comboBox_tileset";
            this.comboBox_tileset.Size = new System.Drawing.Size(49, 21);
            this.comboBox_tileset.TabIndex = 1;
            this.comboBox_tileset.SelectedIndexChanged += new System.EventHandler(this.comboBox_tileset_SelectedIndexChanged);
            // 
            // groupBox_data
            // 
            this.groupBox_data.Controls.Add(this.button_editTileTable);
            this.groupBox_data.Controls.Add(this.button_editAnimTileset);
            this.groupBox_data.Controls.Add(this.button_editLZ77);
            this.groupBox_data.Controls.Add(this.button_editRLE);
            this.groupBox_data.Controls.Add(this.button_editPalette);
            this.groupBox_data.Controls.Add(this.button_editAnimPalette);
            this.groupBox_data.Controls.Add(this.label_rleGfx);
            this.groupBox_data.Controls.Add(this.textBox_rleGfx);
            this.groupBox_data.Controls.Add(this.textBox_palette);
            this.groupBox_data.Controls.Add(this.label_animPalette);
            this.groupBox_data.Controls.Add(this.textBox_lz77gfx);
            this.groupBox_data.Controls.Add(this.label_animTileset);
            this.groupBox_data.Controls.Add(this.textBox_tileTable);
            this.groupBox_data.Controls.Add(this.textBox_animPalette);
            this.groupBox_data.Controls.Add(this.label_palette);
            this.groupBox_data.Controls.Add(this.textBox_animTileset);
            this.groupBox_data.Controls.Add(this.label_lz77gfx);
            this.groupBox_data.Controls.Add(this.label_tileTable);
            this.groupBox_data.Location = new System.Drawing.Point(12, 11);
            this.groupBox_data.Name = "groupBox_data";
            this.groupBox_data.Size = new System.Drawing.Size(212, 177);
            this.groupBox_data.TabIndex = 0;
            this.groupBox_data.TabStop = false;
            this.groupBox_data.Text = "Data";
            // 
            // button_editTileTable
            // 
            this.button_editTileTable.Location = new System.Drawing.Point(141, 96);
            this.button_editTileTable.Name = "button_editTileTable";
            this.button_editTileTable.Size = new System.Drawing.Size(65, 22);
            this.button_editTileTable.TabIndex = 11;
            this.button_editTileTable.Text = "Edit";
            this.button_editTileTable.UseVisualStyleBackColor = true;
            this.button_editTileTable.Click += new System.EventHandler(this.button_editTileTable_Click);
            // 
            // button_editAnimTileset
            // 
            this.button_editAnimTileset.Location = new System.Drawing.Point(141, 122);
            this.button_editAnimTileset.Name = "button_editAnimTileset";
            this.button_editAnimTileset.Size = new System.Drawing.Size(65, 22);
            this.button_editAnimTileset.TabIndex = 10;
            this.button_editAnimTileset.Text = "Edit";
            this.button_editAnimTileset.UseVisualStyleBackColor = true;
            this.button_editAnimTileset.Click += new System.EventHandler(this.button_editAnimTileset_Click);
            // 
            // button_editLZ77
            // 
            this.button_editLZ77.Location = new System.Drawing.Point(141, 70);
            this.button_editLZ77.Name = "button_editLZ77";
            this.button_editLZ77.Size = new System.Drawing.Size(65, 22);
            this.button_editLZ77.TabIndex = 5;
            this.button_editLZ77.Text = "Edit";
            this.button_editLZ77.UseVisualStyleBackColor = true;
            this.button_editLZ77.Click += new System.EventHandler(this.button_editLZ77_Click);
            // 
            // button_editRLE
            // 
            this.button_editRLE.Location = new System.Drawing.Point(141, 18);
            this.button_editRLE.Name = "button_editRLE";
            this.button_editRLE.Size = new System.Drawing.Size(65, 22);
            this.button_editRLE.TabIndex = 1;
            this.button_editRLE.Text = "Edit";
            this.button_editRLE.UseVisualStyleBackColor = true;
            this.button_editRLE.Click += new System.EventHandler(this.button_editRLE_Click);
            // 
            // button_editPalette
            // 
            this.button_editPalette.Location = new System.Drawing.Point(141, 44);
            this.button_editPalette.Name = "button_editPalette";
            this.button_editPalette.Size = new System.Drawing.Size(65, 22);
            this.button_editPalette.TabIndex = 3;
            this.button_editPalette.Text = "Edit";
            this.button_editPalette.UseVisualStyleBackColor = true;
            this.button_editPalette.Click += new System.EventHandler(this.button_editPalette_Click);
            // 
            // button_editAnimPalette
            // 
            this.button_editAnimPalette.Location = new System.Drawing.Point(141, 148);
            this.button_editAnimPalette.Name = "button_editAnimPalette";
            this.button_editAnimPalette.Size = new System.Drawing.Size(65, 22);
            this.button_editAnimPalette.TabIndex = 9;
            this.button_editAnimPalette.Text = "Edit";
            this.button_editAnimPalette.UseVisualStyleBackColor = true;
            this.button_editAnimPalette.Click += new System.EventHandler(this.button_editAnimPalette_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_changes});
            this.statusStrip.Location = new System.Drawing.Point(0, 249);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(236, 22);
            this.statusStrip.TabIndex = 4;
            // 
            // statusLabel_changes
            // 
            this.statusLabel_changes.Name = "statusLabel_changes";
            this.statusLabel_changes.Size = new System.Drawing.Size(12, 17);
            this.statusLabel_changes.Text = "-";
            // 
            // FormTileset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 271);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox_data);
            this.Controls.Add(this.comboBox_tileset);
            this.Controls.Add(this.label_tileset);
            this.Controls.Add(this.textBox_offsetVal);
            this.Controls.Add(this.label_offset);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_apply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTileset";
            this.Text = "Tileset Editor";
            this.groupBox_data.ResumeLayout(false);
            this.groupBox_data.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mage.Theming.CustomControls.FlatTextBox textBox_offsetVal;
        private System.Windows.Forms.Label label_offset;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_apply;
        private mage.Theming.CustomControls.FlatTextBox textBox_rleGfx;
        private mage.Theming.CustomControls.FlatTextBox textBox_palette;
        private mage.Theming.CustomControls.FlatTextBox textBox_lz77gfx;
        private mage.Theming.CustomControls.FlatTextBox textBox_tileTable;
        private System.Windows.Forms.Label label_rleGfx;
        private System.Windows.Forms.Label label_palette;
        private System.Windows.Forms.Label label_lz77gfx;
        private System.Windows.Forms.Label label_tileTable;
        private mage.Theming.CustomControls.FlatTextBox textBox_animTileset;
        private mage.Theming.CustomControls.FlatTextBox textBox_animPalette;
        private System.Windows.Forms.Label label_animTileset;
        private System.Windows.Forms.Label label_animPalette;
        private System.Windows.Forms.Label label_tileset;
        private mage.Theming.CustomControls.FlatComboBox comboBox_tileset;
        private System.Windows.Forms.GroupBox groupBox_data;
        private System.Windows.Forms.Button button_editPalette;
        private System.Windows.Forms.Button button_editAnimPalette;
        private System.Windows.Forms.Button button_editLZ77;
        private System.Windows.Forms.Button button_editRLE;
        private System.Windows.Forms.Button button_editAnimTileset;
        private System.Windows.Forms.Button button_editTileTable;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_changes;
    }
}