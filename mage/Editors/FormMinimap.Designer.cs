namespace mage
{
    partial class FormMinimap
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMinimap));
            label_area = new System.Windows.Forms.Label();
            comboBox_area = new Theming.CustomControls.FlatComboBox();
            comboBox_view = new Theming.CustomControls.FlatComboBox();
            label_view = new System.Windows.Forms.Label();
            label_palette = new System.Windows.Forms.Label();
            comboBox_palette = new Theming.CustomControls.FlatComboBox();
            comboBox_type = new Theming.CustomControls.FlatComboBox();
            label_type = new System.Windows.Forms.Label();
            checkBox_xflip = new System.Windows.Forms.CheckBox();
            checkBox_yflip = new System.Windows.Forms.CheckBox();
            button_apply = new System.Windows.Forms.Button();
            button_close = new System.Windows.Forms.Button();
            label_selSquare = new System.Windows.Forms.Label();
            groupBox_map = new System.Windows.Forms.GroupBox();
            groupBox_selection = new System.Windows.Forms.GroupBox();
            panel_black = new System.Windows.Forms.Panel();
            gfxView_sel = new GfxView();
            button_editGFX = new System.Windows.Forms.Button();
            panel_squares = new System.Windows.Forms.Panel();
            gfxView_squares = new GfxView();
            groupBox_tiles = new System.Windows.Forms.GroupBox();
            button_bgColor = new System.Windows.Forms.Button();
            toolTip_bgColor = new System.Windows.Forms.ToolTip(components);
            statusStrip = new System.Windows.Forms.StatusStrip();
            statusLabel_coor = new System.Windows.Forms.ToolStripStatusLabel();
            statusLabel_tile = new System.Windows.Forms.ToolStripStatusLabel();
            statusLabel_changes = new System.Windows.Forms.ToolStripStatusLabel();
            statusStrip_spring = new System.Windows.Forms.ToolStripStatusLabel();
            statusStrip_import = new System.Windows.Forms.ToolStripDropDownButton();
            statusStrip_importRaw = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip_export = new System.Windows.Forms.ToolStripDropDownButton();
            statusStrip_exportRaw = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip_exportImage = new System.Windows.Forms.ToolStripMenuItem();
            gfxView_map = new GfxView();
            groupBox_map.SuspendLayout();
            groupBox_selection.SuspendLayout();
            panel_black.SuspendLayout();
            panel_squares.SuspendLayout();
            groupBox_tiles.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // label_area
            // 
            label_area.AutoSize = true;
            label_area.Location = new System.Drawing.Point(7, 27);
            label_area.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_area.Name = "label_area";
            label_area.Size = new System.Drawing.Size(34, 15);
            label_area.TabIndex = 0;
            label_area.Text = "Area:";
            // 
            // comboBox_area
            // 
            comboBox_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_area.FormattingEnabled = true;
            comboBox_area.Location = new System.Drawing.Point(52, 23);
            comboBox_area.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox_area.Name = "comboBox_area";
            comboBox_area.Size = new System.Drawing.Size(98, 23);
            comboBox_area.TabIndex = 0;
            comboBox_area.SelectedIndexChanged += comboBox_area_SelectedIndexChanged;
            // 
            // comboBox_view
            // 
            comboBox_view.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_view.FormattingEnabled = true;
            comboBox_view.Items.AddRange(new object[] { "Explored", "Downloaded" });
            comboBox_view.Location = new System.Drawing.Point(52, 59);
            comboBox_view.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox_view.Name = "comboBox_view";
            comboBox_view.Size = new System.Drawing.Size(98, 23);
            comboBox_view.TabIndex = 1;
            comboBox_view.SelectedIndexChanged += comboBox_view_SelectedIndexChanged;
            // 
            // label_view
            // 
            label_view.AutoSize = true;
            label_view.Location = new System.Drawing.Point(7, 62);
            label_view.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_view.Name = "label_view";
            label_view.Size = new System.Drawing.Size(35, 15);
            label_view.TabIndex = 0;
            label_view.Text = "View:";
            // 
            // label_palette
            // 
            label_palette.AutoSize = true;
            label_palette.Location = new System.Drawing.Point(7, 25);
            label_palette.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_palette.Name = "label_palette";
            label_palette.Size = new System.Drawing.Size(46, 15);
            label_palette.TabIndex = 0;
            label_palette.Text = "Palette:";
            // 
            // comboBox_palette
            // 
            comboBox_palette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_palette.FormattingEnabled = true;
            comboBox_palette.Items.AddRange(new object[] { "0", "1", "2" });
            comboBox_palette.Location = new System.Drawing.Point(64, 22);
            comboBox_palette.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox_palette.Name = "comboBox_palette";
            comboBox_palette.Size = new System.Drawing.Size(46, 23);
            comboBox_palette.TabIndex = 2;
            comboBox_palette.SelectedIndexChanged += comboBox_palette_SelectedIndexChanged;
            // 
            // comboBox_type
            // 
            comboBox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_type.FormattingEnabled = true;
            comboBox_type.Location = new System.Drawing.Point(50, 70);
            comboBox_type.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox_type.Name = "comboBox_type";
            comboBox_type.Size = new System.Drawing.Size(123, 23);
            comboBox_type.TabIndex = 2;
            comboBox_type.SelectedIndexChanged += SelectedSquareChanged;
            // 
            // label_type
            // 
            label_type.AutoSize = true;
            label_type.Location = new System.Drawing.Point(4, 74);
            label_type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_type.Name = "label_type";
            label_type.Size = new System.Drawing.Size(34, 15);
            label_type.TabIndex = 0;
            label_type.Text = "Type:";
            // 
            // checkBox_xflip
            // 
            checkBox_xflip.AutoSize = true;
            checkBox_xflip.Location = new System.Drawing.Point(103, 20);
            checkBox_xflip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBox_xflip.Name = "checkBox_xflip";
            checkBox_xflip.Size = new System.Drawing.Size(53, 19);
            checkBox_xflip.TabIndex = 0;
            checkBox_xflip.Text = "X flip";
            checkBox_xflip.UseVisualStyleBackColor = true;
            checkBox_xflip.CheckedChanged += SelectedSquareChanged;
            // 
            // checkBox_yflip
            // 
            checkBox_yflip.AutoSize = true;
            checkBox_yflip.Location = new System.Drawing.Point(103, 44);
            checkBox_yflip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBox_yflip.Name = "checkBox_yflip";
            checkBox_yflip.Size = new System.Drawing.Size(53, 19);
            checkBox_yflip.TabIndex = 1;
            checkBox_yflip.Text = "Y flip";
            checkBox_yflip.UseVisualStyleBackColor = true;
            checkBox_yflip.CheckedChanged += SelectedSquareChanged;
            // 
            // button_apply
            // 
            button_apply.Enabled = false;
            button_apply.Location = new System.Drawing.Point(882, 121);
            button_apply.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_apply.Name = "button_apply";
            button_apply.Size = new System.Drawing.Size(88, 27);
            button_apply.TabIndex = 4;
            button_apply.Text = "Apply";
            button_apply.UseVisualStyleBackColor = true;
            button_apply.Click += button_apply_Click;
            // 
            // button_close
            // 
            button_close.Location = new System.Drawing.Point(882, 155);
            button_close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_close.Name = "button_close";
            button_close.Size = new System.Drawing.Size(88, 27);
            button_close.TabIndex = 5;
            button_close.Text = "Close";
            button_close.UseVisualStyleBackColor = true;
            button_close.Click += button_close_Click;
            // 
            // label_selSquare
            // 
            label_selSquare.AutoSize = true;
            label_selSquare.Location = new System.Drawing.Point(54, 32);
            label_selSquare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_selSquare.Name = "label_selSquare";
            label_selSquare.Size = new System.Drawing.Size(13, 15);
            label_selSquare.TabIndex = 0;
            label_selSquare.Text = "0";
            // 
            // groupBox_map
            // 
            groupBox_map.Controls.Add(comboBox_area);
            groupBox_map.Controls.Add(label_area);
            groupBox_map.Controls.Add(label_view);
            groupBox_map.Controls.Add(comboBox_view);
            groupBox_map.Location = new System.Drawing.Point(619, 12);
            groupBox_map.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_map.Name = "groupBox_map";
            groupBox_map.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_map.Size = new System.Drawing.Size(160, 103);
            groupBox_map.TabIndex = 0;
            groupBox_map.TabStop = false;
            groupBox_map.Text = "Map";
            // 
            // groupBox_selection
            // 
            groupBox_selection.Controls.Add(label_selSquare);
            groupBox_selection.Controls.Add(panel_black);
            groupBox_selection.Controls.Add(comboBox_type);
            groupBox_selection.Controls.Add(label_type);
            groupBox_selection.Controls.Add(checkBox_yflip);
            groupBox_selection.Controls.Add(checkBox_xflip);
            groupBox_selection.Location = new System.Drawing.Point(786, 12);
            groupBox_selection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_selection.Name = "groupBox_selection";
            groupBox_selection.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_selection.Size = new System.Drawing.Size(182, 103);
            groupBox_selection.TabIndex = 1;
            groupBox_selection.TabStop = false;
            groupBox_selection.Text = "Selection";
            // 
            // panel_black
            // 
            panel_black.BackColor = System.Drawing.Color.Black;
            panel_black.Controls.Add(gfxView_sel);
            panel_black.Location = new System.Drawing.Point(7, 21);
            panel_black.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel_black.Name = "panel_black";
            panel_black.Size = new System.Drawing.Size(40, 39);
            panel_black.TabIndex = 4;
            // 
            // gfxView_sel
            // 
            gfxView_sel.BackColor = System.Drawing.SystemColors.Control;
            gfxView_sel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            gfxView_sel.Location = new System.Drawing.Point(1, 1);
            gfxView_sel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gfxView_sel.Name = "gfxView_sel";
            gfxView_sel.Size = new System.Drawing.Size(37, 37);
            gfxView_sel.TabIndex = 3;
            gfxView_sel.TabStop = false;
            // 
            // button_editGFX
            // 
            button_editGFX.Location = new System.Drawing.Point(127, 21);
            button_editGFX.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_editGFX.Name = "button_editGFX";
            button_editGFX.Size = new System.Drawing.Size(82, 27);
            button_editGFX.TabIndex = 3;
            button_editGFX.Text = "Edit GFX";
            button_editGFX.UseVisualStyleBackColor = true;
            button_editGFX.Click += button_editGFX_Click;
            // 
            // panel_squares
            // 
            panel_squares.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panel_squares.AutoScroll = true;
            panel_squares.Controls.Add(gfxView_squares);
            panel_squares.Location = new System.Drawing.Point(619, 188);
            panel_squares.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel_squares.Name = "panel_squares";
            panel_squares.Size = new System.Drawing.Size(351, 347);
            panel_squares.TabIndex = 8;
            // 
            // gfxView_squares
            // 
            gfxView_squares.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            gfxView_squares.Location = new System.Drawing.Point(0, 0);
            gfxView_squares.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gfxView_squares.Name = "gfxView_squares";
            gfxView_squares.Size = new System.Drawing.Size(351, 328);
            gfxView_squares.TabIndex = 7;
            gfxView_squares.TabStop = false;
            gfxView_squares.MouseDown += gfxView_squares_MouseDown;
            gfxView_squares.MouseMove += gfxView_squares_MouseMove;
            // 
            // groupBox_tiles
            // 
            groupBox_tiles.Controls.Add(button_bgColor);
            groupBox_tiles.Controls.Add(button_editGFX);
            groupBox_tiles.Controls.Add(comboBox_palette);
            groupBox_tiles.Controls.Add(label_palette);
            groupBox_tiles.Location = new System.Drawing.Point(619, 121);
            groupBox_tiles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_tiles.Name = "groupBox_tiles";
            groupBox_tiles.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_tiles.Size = new System.Drawing.Size(250, 59);
            groupBox_tiles.TabIndex = 9;
            groupBox_tiles.TabStop = false;
            groupBox_tiles.Text = "Tiles";
            // 
            // button_bgColor
            // 
            button_bgColor.Image = Properties.Resources.button_bg_color;
            button_bgColor.Location = new System.Drawing.Point(216, 21);
            button_bgColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_bgColor.Name = "button_bgColor";
            button_bgColor.Size = new System.Drawing.Size(27, 27);
            button_bgColor.TabIndex = 4;
            toolTip_bgColor.SetToolTip(button_bgColor, "Change background color");
            button_bgColor.UseVisualStyleBackColor = false;
            button_bgColor.Click += button_bgColor_Click;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { statusLabel_coor, statusLabel_tile, statusLabel_changes, statusStrip_spring, statusStrip_import, statusStrip_export });
            statusStrip.Location = new System.Drawing.Point(0, 619);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStrip.Size = new System.Drawing.Size(983, 24);
            statusStrip.TabIndex = 11;
            statusStrip.Text = "statusStrip1";
            // 
            // statusLabel_coor
            // 
            statusLabel_coor.AutoSize = false;
            statusLabel_coor.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            statusLabel_coor.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            statusLabel_coor.Name = "statusLabel_coor";
            statusLabel_coor.Size = new System.Drawing.Size(70, 19);
            statusLabel_coor.Text = "(0, 0)";
            statusLabel_coor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusLabel_tile
            // 
            statusLabel_tile.AutoSize = false;
            statusLabel_tile.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            statusLabel_tile.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            statusLabel_tile.Name = "statusLabel_tile";
            statusLabel_tile.Size = new System.Drawing.Size(70, 19);
            statusLabel_tile.Text = "Tile:";
            statusLabel_tile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusLabel_changes
            // 
            statusLabel_changes.Name = "statusLabel_changes";
            statusLabel_changes.Size = new System.Drawing.Size(12, 19);
            statusLabel_changes.Text = "-";
            // 
            // statusStrip_spring
            // 
            statusStrip_spring.Name = "statusStrip_spring";
            statusStrip_spring.Size = new System.Drawing.Size(704, 19);
            statusStrip_spring.Spring = true;
            // 
            // statusStrip_import
            // 
            statusStrip_import.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            statusStrip_import.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { statusStrip_importRaw });
            statusStrip_import.Name = "statusStrip_import";
            statusStrip_import.Size = new System.Drawing.Size(56, 22);
            statusStrip_import.Text = "Import";
            // 
            // statusStrip_importRaw
            // 
            statusStrip_importRaw.Name = "statusStrip_importRaw";
            statusStrip_importRaw.Size = new System.Drawing.Size(105, 22);
            statusStrip_importRaw.Text = "Raw...";
            statusStrip_importRaw.Click += statusStrip_importRaw_Click;
            // 
            // statusStrip_export
            // 
            statusStrip_export.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            statusStrip_export.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { statusStrip_exportRaw, statusStrip_exportImage });
            statusStrip_export.Name = "statusStrip_export";
            statusStrip_export.Size = new System.Drawing.Size(54, 22);
            statusStrip_export.Text = "Export";
            // 
            // statusStrip_exportRaw
            // 
            statusStrip_exportRaw.Name = "statusStrip_exportRaw";
            statusStrip_exportRaw.Size = new System.Drawing.Size(116, 22);
            statusStrip_exportRaw.Text = "Raw...";
            statusStrip_exportRaw.Click += statusStrip_exportRaw_Click;
            // 
            // statusStrip_exportImage
            // 
            statusStrip_exportImage.Name = "statusStrip_exportImage";
            statusStrip_exportImage.Size = new System.Drawing.Size(116, 22);
            statusStrip_exportImage.Text = "Image...";
            statusStrip_exportImage.Click += statusStrip_exportImage_Click;
            // 
            // gfxView_map
            // 
            gfxView_map.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            gfxView_map.Location = new System.Drawing.Point(14, 14);
            gfxView_map.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gfxView_map.Name = "gfxView_map";
            gfxView_map.Size = new System.Drawing.Size(597, 591);
            gfxView_map.TabIndex = 6;
            gfxView_map.TabStop = false;
            gfxView_map.MouseDown += gfxView_map_MouseDown;
            gfxView_map.MouseMove += gfxView_map_MouseMove;
            // 
            // FormMinimap
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(983, 643);
            Controls.Add(statusStrip);
            Controls.Add(groupBox_tiles);
            Controls.Add(panel_squares);
            Controls.Add(gfxView_map);
            Controls.Add(groupBox_selection);
            Controls.Add(groupBox_map);
            Controls.Add(button_close);
            Controls.Add(button_apply);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(906, 608);
            Name = "FormMinimap";
            Text = "Minimap Editor";
            KeyDown += FormMinimap_KeyDown;
            groupBox_map.ResumeLayout(false);
            groupBox_map.PerformLayout();
            groupBox_selection.ResumeLayout(false);
            groupBox_selection.PerformLayout();
            panel_black.ResumeLayout(false);
            panel_squares.ResumeLayout(false);
            groupBox_tiles.ResumeLayout(false);
            groupBox_tiles.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label_area;
        private mage.Theming.CustomControls.FlatComboBox comboBox_area;
        private mage.Theming.CustomControls.FlatComboBox comboBox_view;
        private System.Windows.Forms.Label label_view;
        private System.Windows.Forms.Label label_palette;
        private mage.Theming.CustomControls.FlatComboBox comboBox_palette;
        private mage.Theming.CustomControls.FlatComboBox comboBox_type;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.CheckBox checkBox_xflip;
        private System.Windows.Forms.CheckBox checkBox_yflip;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_selSquare;
        private System.Windows.Forms.GroupBox groupBox_map;
        private System.Windows.Forms.GroupBox groupBox_selection;
        private System.Windows.Forms.Button button_editGFX;
        private GfxView gfxView_map;
        private GfxView gfxView_squares;
        private GfxView gfxView_sel;
        private System.Windows.Forms.Panel panel_squares;
        private System.Windows.Forms.Panel panel_black;
        private System.Windows.Forms.GroupBox groupBox_tiles;
        private System.Windows.Forms.Button button_bgColor;
        private System.Windows.Forms.ToolTip toolTip_bgColor;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_coor;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_tile;
        private System.Windows.Forms.ToolStripDropDownButton statusStrip_export;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip_spring;
        private System.Windows.Forms.ToolStripMenuItem statusStrip_exportImage;
        private System.Windows.Forms.ToolStripDropDownButton statusStrip_import;
        private System.Windows.Forms.ToolStripMenuItem statusStrip_importRaw;
        private System.Windows.Forms.ToolStripMenuItem statusStrip_exportRaw;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_changes;
    }
}