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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMinimap));
            this.label_area = new System.Windows.Forms.Label();
            this.comboBox_area = new mage.Theming.CustomControls.FlatComboBox();
            this.comboBox_view = new mage.Theming.CustomControls.FlatComboBox();
            this.label_view = new System.Windows.Forms.Label();
            this.label_palette = new System.Windows.Forms.Label();
            this.comboBox_palette = new mage.Theming.CustomControls.FlatComboBox();
            this.comboBox_type = new mage.Theming.CustomControls.FlatComboBox();
            this.label_type = new System.Windows.Forms.Label();
            this.checkBox_xflip = new System.Windows.Forms.CheckBox();
            this.checkBox_yflip = new System.Windows.Forms.CheckBox();
            this.button_apply = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.label_selSquare = new System.Windows.Forms.Label();
            this.groupBox_map = new System.Windows.Forms.GroupBox();
            this.groupBox_selection = new System.Windows.Forms.GroupBox();
            this.panel_black = new System.Windows.Forms.Panel();
            this.gfxView_sel = new mage.GfxView();
            this.button_editGFX = new System.Windows.Forms.Button();
            this.panel_squares = new System.Windows.Forms.Panel();
            this.gfxView_squares = new mage.GfxView();
            this.groupBox_tiles = new System.Windows.Forms.GroupBox();
            this.button_bgColor = new System.Windows.Forms.Button();
            this.toolTip_bgColor = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel_coor = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel_tile = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel_changes = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip_spring = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip_import = new System.Windows.Forms.ToolStripDropDownButton();
            this.statusStrip_importRaw = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_export = new System.Windows.Forms.ToolStripDropDownButton();
            this.statusStrip_exportRaw = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_exportImage = new System.Windows.Forms.ToolStripMenuItem();
            this.gfxView_map = new mage.GfxView();
            this.groupBox_map.SuspendLayout();
            this.groupBox_selection.SuspendLayout();
            this.panel_black.SuspendLayout();
            this.panel_squares.SuspendLayout();
            this.groupBox_tiles.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_area
            // 
            this.label_area.AutoSize = true;
            this.label_area.Location = new System.Drawing.Point(6, 23);
            this.label_area.Name = "label_area";
            this.label_area.Size = new System.Drawing.Size(32, 13);
            this.label_area.TabIndex = 0;
            this.label_area.Text = "Area:";
            // 
            // comboBox_area
            // 
            this.comboBox_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_area.FormattingEnabled = true;
            this.comboBox_area.Location = new System.Drawing.Point(45, 20);
            this.comboBox_area.Name = "comboBox_area";
            this.comboBox_area.Size = new System.Drawing.Size(85, 21);
            this.comboBox_area.TabIndex = 0;
            this.comboBox_area.SelectedIndexChanged += new System.EventHandler(this.comboBox_area_SelectedIndexChanged);
            // 
            // comboBox_view
            // 
            this.comboBox_view.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_view.FormattingEnabled = true;
            this.comboBox_view.Items.AddRange(new object[] {
            "Explored",
            "Downloaded"});
            this.comboBox_view.Location = new System.Drawing.Point(45, 51);
            this.comboBox_view.Name = "comboBox_view";
            this.comboBox_view.Size = new System.Drawing.Size(85, 21);
            this.comboBox_view.TabIndex = 1;
            this.comboBox_view.SelectedIndexChanged += new System.EventHandler(this.comboBox_view_SelectedIndexChanged);
            // 
            // label_view
            // 
            this.label_view.AutoSize = true;
            this.label_view.Location = new System.Drawing.Point(6, 54);
            this.label_view.Name = "label_view";
            this.label_view.Size = new System.Drawing.Size(33, 13);
            this.label_view.TabIndex = 0;
            this.label_view.Text = "View:";
            // 
            // label_palette
            // 
            this.label_palette.AutoSize = true;
            this.label_palette.Location = new System.Drawing.Point(6, 22);
            this.label_palette.Name = "label_palette";
            this.label_palette.Size = new System.Drawing.Size(43, 13);
            this.label_palette.TabIndex = 0;
            this.label_palette.Text = "Palette:";
            // 
            // comboBox_palette
            // 
            this.comboBox_palette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_palette.FormattingEnabled = true;
            this.comboBox_palette.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.comboBox_palette.Location = new System.Drawing.Point(55, 19);
            this.comboBox_palette.Name = "comboBox_palette";
            this.comboBox_palette.Size = new System.Drawing.Size(40, 21);
            this.comboBox_palette.TabIndex = 2;
            this.comboBox_palette.SelectedIndexChanged += new System.EventHandler(this.comboBox_palette_SelectedIndexChanged);
            // 
            // comboBox_type
            // 
            this.comboBox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Location = new System.Drawing.Point(43, 61);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(106, 21);
            this.comboBox_type.TabIndex = 2;
            this.comboBox_type.SelectedIndexChanged += new System.EventHandler(this.SelectedSquareChanged);
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(3, 64);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(34, 13);
            this.label_type.TabIndex = 0;
            this.label_type.Text = "Type:";
            // 
            // checkBox_xflip
            // 
            this.checkBox_xflip.AutoSize = true;
            this.checkBox_xflip.Location = new System.Drawing.Point(88, 17);
            this.checkBox_xflip.Name = "checkBox_xflip";
            this.checkBox_xflip.Size = new System.Drawing.Size(49, 17);
            this.checkBox_xflip.TabIndex = 0;
            this.checkBox_xflip.Text = "X flip";
            this.checkBox_xflip.UseVisualStyleBackColor = true;
            this.checkBox_xflip.CheckedChanged += new System.EventHandler(this.SelectedSquareChanged);
            // 
            // checkBox_yflip
            // 
            this.checkBox_yflip.AutoSize = true;
            this.checkBox_yflip.Location = new System.Drawing.Point(88, 38);
            this.checkBox_yflip.Name = "checkBox_yflip";
            this.checkBox_yflip.Size = new System.Drawing.Size(49, 17);
            this.checkBox_yflip.TabIndex = 1;
            this.checkBox_yflip.Text = "Y flip";
            this.checkBox_yflip.UseVisualStyleBackColor = true;
            this.checkBox_yflip.CheckedChanged += new System.EventHandler(this.SelectedSquareChanged);
            // 
            // button_apply
            // 
            this.button_apply.Enabled = false;
            this.button_apply.Location = new System.Drawing.Point(755, 107);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(75, 23);
            this.button_apply.TabIndex = 4;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(755, 136);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 5;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label_selSquare
            // 
            this.label_selSquare.AutoSize = true;
            this.label_selSquare.Location = new System.Drawing.Point(46, 28);
            this.label_selSquare.Name = "label_selSquare";
            this.label_selSquare.Size = new System.Drawing.Size(13, 13);
            this.label_selSquare.TabIndex = 0;
            this.label_selSquare.Text = "0";
            // 
            // groupBox_map
            // 
            this.groupBox_map.Controls.Add(this.comboBox_area);
            this.groupBox_map.Controls.Add(this.label_area);
            this.groupBox_map.Controls.Add(this.label_view);
            this.groupBox_map.Controls.Add(this.comboBox_view);
            this.groupBox_map.Location = new System.Drawing.Point(530, 12);
            this.groupBox_map.Name = "groupBox_map";
            this.groupBox_map.Size = new System.Drawing.Size(137, 89);
            this.groupBox_map.TabIndex = 0;
            this.groupBox_map.TabStop = false;
            this.groupBox_map.Text = "Map";
            // 
            // groupBox_selection
            // 
            this.groupBox_selection.Controls.Add(this.label_selSquare);
            this.groupBox_selection.Controls.Add(this.panel_black);
            this.groupBox_selection.Controls.Add(this.comboBox_type);
            this.groupBox_selection.Controls.Add(this.label_type);
            this.groupBox_selection.Controls.Add(this.checkBox_yflip);
            this.groupBox_selection.Controls.Add(this.checkBox_xflip);
            this.groupBox_selection.Location = new System.Drawing.Point(673, 12);
            this.groupBox_selection.Name = "groupBox_selection";
            this.groupBox_selection.Size = new System.Drawing.Size(156, 89);
            this.groupBox_selection.TabIndex = 1;
            this.groupBox_selection.TabStop = false;
            this.groupBox_selection.Text = "Selection";
            // 
            // panel_black
            // 
            this.panel_black.BackColor = System.Drawing.Color.Black;
            this.panel_black.Controls.Add(this.gfxView_sel);
            this.panel_black.Location = new System.Drawing.Point(6, 18);
            this.panel_black.Name = "panel_black";
            this.panel_black.Size = new System.Drawing.Size(34, 34);
            this.panel_black.TabIndex = 4;
            // 
            // gfxView_sel
            // 
            this.gfxView_sel.BackColor = System.Drawing.SystemColors.Control;
            this.gfxView_sel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gfxView_sel.Location = new System.Drawing.Point(1, 1);
            this.gfxView_sel.Name = "gfxView_sel";
            this.gfxView_sel.Size = new System.Drawing.Size(32, 32);
            this.gfxView_sel.TabIndex = 3;
            this.gfxView_sel.TabStop = false;
            // 
            // button_editGFX
            // 
            this.button_editGFX.Location = new System.Drawing.Point(109, 18);
            this.button_editGFX.Name = "button_editGFX";
            this.button_editGFX.Size = new System.Drawing.Size(70, 23);
            this.button_editGFX.TabIndex = 3;
            this.button_editGFX.Text = "Edit GFX";
            this.button_editGFX.UseVisualStyleBackColor = true;
            this.button_editGFX.Click += new System.EventHandler(this.button_editGFX_Click);
            // 
            // panel_squares
            // 
            this.panel_squares.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_squares.AutoScroll = true;
            this.panel_squares.Controls.Add(this.gfxView_squares);
            this.panel_squares.Location = new System.Drawing.Point(530, 165);
            this.panel_squares.Name = "panel_squares";
            this.panel_squares.Size = new System.Drawing.Size(301, 301);
            this.panel_squares.TabIndex = 8;
            // 
            // gfxView_squares
            // 
            this.gfxView_squares.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gfxView_squares.Location = new System.Drawing.Point(0, 0);
            this.gfxView_squares.Name = "gfxView_squares";
            this.gfxView_squares.Size = new System.Drawing.Size(284, 284);
            this.gfxView_squares.TabIndex = 7;
            this.gfxView_squares.TabStop = false;
            this.gfxView_squares.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gfxView_squares_MouseDown);
            this.gfxView_squares.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gfxView_squares_MouseMove);
            // 
            // groupBox_tiles
            // 
            this.groupBox_tiles.Controls.Add(this.button_bgColor);
            this.groupBox_tiles.Controls.Add(this.button_editGFX);
            this.groupBox_tiles.Controls.Add(this.comboBox_palette);
            this.groupBox_tiles.Controls.Add(this.label_palette);
            this.groupBox_tiles.Location = new System.Drawing.Point(530, 107);
            this.groupBox_tiles.Name = "groupBox_tiles";
            this.groupBox_tiles.Size = new System.Drawing.Size(214, 51);
            this.groupBox_tiles.TabIndex = 9;
            this.groupBox_tiles.TabStop = false;
            this.groupBox_tiles.Text = "Tiles";
            // 
            // button_bgColor
            // 
            this.button_bgColor.Image = global::mage.Properties.Resources.button_bg_color;
            this.button_bgColor.Location = new System.Drawing.Point(185, 18);
            this.button_bgColor.Name = "button_bgColor";
            this.button_bgColor.Size = new System.Drawing.Size(23, 23);
            this.button_bgColor.TabIndex = 4;
            this.toolTip_bgColor.SetToolTip(this.button_bgColor, "Change background color");
            this.button_bgColor.UseVisualStyleBackColor = false;
            this.button_bgColor.Click += new System.EventHandler(this.button_bgColor_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_coor,
            this.statusLabel_tile,
            this.statusLabel_changes,
            this.statusStrip_spring,
            this.statusStrip_import,
            this.statusStrip_export});
            this.statusStrip.Location = new System.Drawing.Point(0, 531);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(841, 24);
            this.statusStrip.TabIndex = 11;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel_coor
            // 
            this.statusLabel_coor.AutoSize = false;
            this.statusLabel_coor.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.statusLabel_coor.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.statusLabel_coor.Name = "statusLabel_coor";
            this.statusLabel_coor.Size = new System.Drawing.Size(70, 19);
            this.statusLabel_coor.Text = "(0, 0)";
            this.statusLabel_coor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusLabel_tile
            // 
            this.statusLabel_tile.AutoSize = false;
            this.statusLabel_tile.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.statusLabel_tile.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.statusLabel_tile.Name = "statusLabel_tile";
            this.statusLabel_tile.Size = new System.Drawing.Size(70, 19);
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
            this.statusStrip_spring.Size = new System.Drawing.Size(565, 19);
            this.statusStrip_spring.Spring = true;
            // 
            // statusStrip_import
            // 
            this.statusStrip_import.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusStrip_import.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip_importRaw});
            this.statusStrip_import.Name = "statusStrip_import";
            this.statusStrip_import.Size = new System.Drawing.Size(56, 22);
            this.statusStrip_import.Text = "Import";
            // 
            // statusStrip_importRaw
            // 
            this.statusStrip_importRaw.Name = "statusStrip_importRaw";
            this.statusStrip_importRaw.Size = new System.Drawing.Size(105, 22);
            this.statusStrip_importRaw.Text = "Raw...";
            this.statusStrip_importRaw.Click += new System.EventHandler(this.statusStrip_importRaw_Click);
            // 
            // statusStrip_export
            // 
            this.statusStrip_export.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusStrip_export.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip_exportRaw,
            this.statusStrip_exportImage});
            this.statusStrip_export.Name = "statusStrip_export";
            this.statusStrip_export.Size = new System.Drawing.Size(53, 22);
            this.statusStrip_export.Text = "Export";
            // 
            // statusStrip_exportRaw
            // 
            this.statusStrip_exportRaw.Name = "statusStrip_exportRaw";
            this.statusStrip_exportRaw.Size = new System.Drawing.Size(116, 22);
            this.statusStrip_exportRaw.Text = "Raw...";
            this.statusStrip_exportRaw.Click += new System.EventHandler(this.statusStrip_exportRaw_Click);
            // 
            // statusStrip_exportImage
            // 
            this.statusStrip_exportImage.Name = "statusStrip_exportImage";
            this.statusStrip_exportImage.Size = new System.Drawing.Size(116, 22);
            this.statusStrip_exportImage.Text = "Image...";
            this.statusStrip_exportImage.Click += new System.EventHandler(this.statusStrip_exportImage_Click);
            // 
            // gfxView_map
            // 
            this.gfxView_map.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gfxView_map.Location = new System.Drawing.Point(12, 12);
            this.gfxView_map.Name = "gfxView_map";
            this.gfxView_map.Size = new System.Drawing.Size(512, 512);
            this.gfxView_map.TabIndex = 6;
            this.gfxView_map.TabStop = false;
            this.gfxView_map.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gfxView_map_MouseDown);
            this.gfxView_map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gfxView_map_MouseMove);
            // 
            // FormMinimap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 555);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox_tiles);
            this.Controls.Add(this.panel_squares);
            this.Controls.Add(this.gfxView_map);
            this.Controls.Add(this.groupBox_selection);
            this.Controls.Add(this.groupBox_map);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_apply);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(857, 594);
            this.Name = "FormMinimap";
            this.Text = "Minimap Editor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMinimap_KeyDown);
            this.groupBox_map.ResumeLayout(false);
            this.groupBox_map.PerformLayout();
            this.groupBox_selection.ResumeLayout(false);
            this.groupBox_selection.PerformLayout();
            this.panel_black.ResumeLayout(false);
            this.panel_squares.ResumeLayout(false);
            this.groupBox_tiles.ResumeLayout(false);
            this.groupBox_tiles.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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