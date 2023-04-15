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
            this.comboBox_area = new System.Windows.Forms.ComboBox();
            this.comboBox_view = new System.Windows.Forms.ComboBox();
            this.label_view = new System.Windows.Forms.Label();
            this.label_palette = new System.Windows.Forms.Label();
            this.comboBox_palette = new System.Windows.Forms.ComboBox();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.label_type = new System.Windows.Forms.Label();
            this.checkBox_xflip = new System.Windows.Forms.CheckBox();
            this.checkBox_yflip = new System.Windows.Forms.CheckBox();
            this.button_apply = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.label_selSquare = new System.Windows.Forms.Label();
            this.groupBox_map = new System.Windows.Forms.GroupBox();
            this.groupBox_selection = new System.Windows.Forms.GroupBox();
            this.panel_black = new System.Windows.Forms.Panel();
            this.button_editGFX = new System.Windows.Forms.Button();
            this.panel_squares = new System.Windows.Forms.Panel();
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
            this.gfxView_sel = new mage.GfxView();
            this.gfxView_squares = new mage.GfxView();
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
            resources.ApplyResources(this.label_area, "label_area");
            this.label_area.Name = "label_area";
            this.toolTip_bgColor.SetToolTip(this.label_area, resources.GetString("label_area.ToolTip"));
            // 
            // comboBox_area
            // 
            resources.ApplyResources(this.comboBox_area, "comboBox_area");
            this.comboBox_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_area.FormattingEnabled = true;
            this.comboBox_area.Name = "comboBox_area";
            this.toolTip_bgColor.SetToolTip(this.comboBox_area, resources.GetString("comboBox_area.ToolTip"));
            this.comboBox_area.SelectedIndexChanged += new System.EventHandler(this.comboBox_area_SelectedIndexChanged);
            // 
            // comboBox_view
            // 
            resources.ApplyResources(this.comboBox_view, "comboBox_view");
            this.comboBox_view.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_view.FormattingEnabled = true;
            this.comboBox_view.Items.AddRange(new object[] {
            resources.GetString("comboBox_view.Items"),
            resources.GetString("comboBox_view.Items1")});
            this.comboBox_view.Name = "comboBox_view";
            this.toolTip_bgColor.SetToolTip(this.comboBox_view, resources.GetString("comboBox_view.ToolTip"));
            this.comboBox_view.SelectedIndexChanged += new System.EventHandler(this.comboBox_view_SelectedIndexChanged);
            // 
            // label_view
            // 
            resources.ApplyResources(this.label_view, "label_view");
            this.label_view.Name = "label_view";
            this.toolTip_bgColor.SetToolTip(this.label_view, resources.GetString("label_view.ToolTip"));
            // 
            // label_palette
            // 
            resources.ApplyResources(this.label_palette, "label_palette");
            this.label_palette.Name = "label_palette";
            this.toolTip_bgColor.SetToolTip(this.label_palette, resources.GetString("label_palette.ToolTip"));
            // 
            // comboBox_palette
            // 
            resources.ApplyResources(this.comboBox_palette, "comboBox_palette");
            this.comboBox_palette.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_palette.FormattingEnabled = true;
            this.comboBox_palette.Items.AddRange(new object[] {
            resources.GetString("comboBox_palette.Items"),
            resources.GetString("comboBox_palette.Items1"),
            resources.GetString("comboBox_palette.Items2")});
            this.comboBox_palette.Name = "comboBox_palette";
            this.toolTip_bgColor.SetToolTip(this.comboBox_palette, resources.GetString("comboBox_palette.ToolTip"));
            this.comboBox_palette.SelectedIndexChanged += new System.EventHandler(this.comboBox_palette_SelectedIndexChanged);
            // 
            // comboBox_type
            // 
            resources.ApplyResources(this.comboBox_type, "comboBox_type");
            this.comboBox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Name = "comboBox_type";
            this.toolTip_bgColor.SetToolTip(this.comboBox_type, resources.GetString("comboBox_type.ToolTip"));
            this.comboBox_type.SelectedIndexChanged += new System.EventHandler(this.SelectedSquareChanged);
            // 
            // label_type
            // 
            resources.ApplyResources(this.label_type, "label_type");
            this.label_type.Name = "label_type";
            this.toolTip_bgColor.SetToolTip(this.label_type, resources.GetString("label_type.ToolTip"));
            // 
            // checkBox_xflip
            // 
            resources.ApplyResources(this.checkBox_xflip, "checkBox_xflip");
            this.checkBox_xflip.Name = "checkBox_xflip";
            this.toolTip_bgColor.SetToolTip(this.checkBox_xflip, resources.GetString("checkBox_xflip.ToolTip"));
            this.checkBox_xflip.UseVisualStyleBackColor = true;
            this.checkBox_xflip.CheckedChanged += new System.EventHandler(this.SelectedSquareChanged);
            // 
            // checkBox_yflip
            // 
            resources.ApplyResources(this.checkBox_yflip, "checkBox_yflip");
            this.checkBox_yflip.Name = "checkBox_yflip";
            this.toolTip_bgColor.SetToolTip(this.checkBox_yflip, resources.GetString("checkBox_yflip.ToolTip"));
            this.checkBox_yflip.UseVisualStyleBackColor = true;
            this.checkBox_yflip.CheckedChanged += new System.EventHandler(this.SelectedSquareChanged);
            // 
            // button_apply
            // 
            resources.ApplyResources(this.button_apply, "button_apply");
            this.button_apply.Name = "button_apply";
            this.toolTip_bgColor.SetToolTip(this.button_apply, resources.GetString("button_apply.ToolTip"));
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // button_close
            // 
            resources.ApplyResources(this.button_close, "button_close");
            this.button_close.Name = "button_close";
            this.toolTip_bgColor.SetToolTip(this.button_close, resources.GetString("button_close.ToolTip"));
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label_selSquare
            // 
            resources.ApplyResources(this.label_selSquare, "label_selSquare");
            this.label_selSquare.Name = "label_selSquare";
            this.toolTip_bgColor.SetToolTip(this.label_selSquare, resources.GetString("label_selSquare.ToolTip"));
            // 
            // groupBox_map
            // 
            resources.ApplyResources(this.groupBox_map, "groupBox_map");
            this.groupBox_map.Controls.Add(this.comboBox_area);
            this.groupBox_map.Controls.Add(this.label_area);
            this.groupBox_map.Controls.Add(this.comboBox_view);
            this.groupBox_map.Controls.Add(this.label_view);
            this.groupBox_map.Name = "groupBox_map";
            this.groupBox_map.TabStop = false;
            this.toolTip_bgColor.SetToolTip(this.groupBox_map, resources.GetString("groupBox_map.ToolTip"));
            // 
            // groupBox_selection
            // 
            resources.ApplyResources(this.groupBox_selection, "groupBox_selection");
            this.groupBox_selection.Controls.Add(this.label_selSquare);
            this.groupBox_selection.Controls.Add(this.panel_black);
            this.groupBox_selection.Controls.Add(this.comboBox_type);
            this.groupBox_selection.Controls.Add(this.label_type);
            this.groupBox_selection.Controls.Add(this.checkBox_yflip);
            this.groupBox_selection.Controls.Add(this.checkBox_xflip);
            this.groupBox_selection.Name = "groupBox_selection";
            this.groupBox_selection.TabStop = false;
            this.toolTip_bgColor.SetToolTip(this.groupBox_selection, resources.GetString("groupBox_selection.ToolTip"));
            // 
            // panel_black
            // 
            resources.ApplyResources(this.panel_black, "panel_black");
            this.panel_black.BackColor = System.Drawing.Color.Black;
            this.panel_black.Controls.Add(this.gfxView_sel);
            this.panel_black.Name = "panel_black";
            this.toolTip_bgColor.SetToolTip(this.panel_black, resources.GetString("panel_black.ToolTip"));
            // 
            // button_editGFX
            // 
            resources.ApplyResources(this.button_editGFX, "button_editGFX");
            this.button_editGFX.Name = "button_editGFX";
            this.toolTip_bgColor.SetToolTip(this.button_editGFX, resources.GetString("button_editGFX.ToolTip"));
            this.button_editGFX.UseVisualStyleBackColor = true;
            this.button_editGFX.Click += new System.EventHandler(this.button_editGFX_Click);
            // 
            // panel_squares
            // 
            resources.ApplyResources(this.panel_squares, "panel_squares");
            this.panel_squares.Controls.Add(this.gfxView_squares);
            this.panel_squares.Name = "panel_squares";
            this.toolTip_bgColor.SetToolTip(this.panel_squares, resources.GetString("panel_squares.ToolTip"));
            // 
            // groupBox_tiles
            // 
            resources.ApplyResources(this.groupBox_tiles, "groupBox_tiles");
            this.groupBox_tiles.Controls.Add(this.button_bgColor);
            this.groupBox_tiles.Controls.Add(this.button_editGFX);
            this.groupBox_tiles.Controls.Add(this.comboBox_palette);
            this.groupBox_tiles.Controls.Add(this.label_palette);
            this.groupBox_tiles.Name = "groupBox_tiles";
            this.groupBox_tiles.TabStop = false;
            this.toolTip_bgColor.SetToolTip(this.groupBox_tiles, resources.GetString("groupBox_tiles.ToolTip"));
            // 
            // button_bgColor
            // 
            resources.ApplyResources(this.button_bgColor, "button_bgColor");
            this.button_bgColor.Image = global::mage.Properties.Resources.button_bg_color;
            this.button_bgColor.Name = "button_bgColor";
            this.toolTip_bgColor.SetToolTip(this.button_bgColor, resources.GetString("button_bgColor.ToolTip"));
            this.button_bgColor.UseVisualStyleBackColor = false;
            this.button_bgColor.Click += new System.EventHandler(this.button_bgColor_Click);
            // 
            // statusStrip
            // 
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_coor,
            this.statusLabel_tile,
            this.statusLabel_changes,
            this.statusStrip_spring,
            this.statusStrip_import,
            this.statusStrip_export});
            this.statusStrip.Name = "statusStrip";
            this.toolTip_bgColor.SetToolTip(this.statusStrip, resources.GetString("statusStrip.ToolTip"));
            // 
            // statusLabel_coor
            // 
            resources.ApplyResources(this.statusLabel_coor, "statusLabel_coor");
            this.statusLabel_coor.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.statusLabel_coor.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.statusLabel_coor.Name = "statusLabel_coor";
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
            this.statusStrip_importRaw});
            this.statusStrip_import.Name = "statusStrip_import";
            // 
            // statusStrip_importRaw
            // 
            resources.ApplyResources(this.statusStrip_importRaw, "statusStrip_importRaw");
            this.statusStrip_importRaw.Name = "statusStrip_importRaw";
            this.statusStrip_importRaw.Click += new System.EventHandler(this.statusStrip_importRaw_Click);
            // 
            // statusStrip_export
            // 
            resources.ApplyResources(this.statusStrip_export, "statusStrip_export");
            this.statusStrip_export.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusStrip_export.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip_exportRaw,
            this.statusStrip_exportImage});
            this.statusStrip_export.Name = "statusStrip_export";
            // 
            // statusStrip_exportRaw
            // 
            resources.ApplyResources(this.statusStrip_exportRaw, "statusStrip_exportRaw");
            this.statusStrip_exportRaw.Name = "statusStrip_exportRaw";
            this.statusStrip_exportRaw.Click += new System.EventHandler(this.statusStrip_exportRaw_Click);
            // 
            // statusStrip_exportImage
            // 
            resources.ApplyResources(this.statusStrip_exportImage, "statusStrip_exportImage");
            this.statusStrip_exportImage.Name = "statusStrip_exportImage";
            this.statusStrip_exportImage.Click += new System.EventHandler(this.statusStrip_exportImage_Click);
            // 
            // gfxView_sel
            // 
            resources.ApplyResources(this.gfxView_sel, "gfxView_sel");
            this.gfxView_sel.BackColor = System.Drawing.SystemColors.Control;
            this.gfxView_sel.Name = "gfxView_sel";
            this.gfxView_sel.TabStop = false;
            this.toolTip_bgColor.SetToolTip(this.gfxView_sel, resources.GetString("gfxView_sel.ToolTip"));
            // 
            // gfxView_squares
            // 
            resources.ApplyResources(this.gfxView_squares, "gfxView_squares");
            this.gfxView_squares.Name = "gfxView_squares";
            this.gfxView_squares.TabStop = false;
            this.toolTip_bgColor.SetToolTip(this.gfxView_squares, resources.GetString("gfxView_squares.ToolTip"));
            this.gfxView_squares.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gfxView_squares_MouseDown);
            this.gfxView_squares.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gfxView_squares_MouseMove);
            // 
            // gfxView_map
            // 
            resources.ApplyResources(this.gfxView_map, "gfxView_map");
            this.gfxView_map.Name = "gfxView_map";
            this.gfxView_map.TabStop = false;
            this.toolTip_bgColor.SetToolTip(this.gfxView_map, resources.GetString("gfxView_map.ToolTip"));
            this.gfxView_map.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gfxView_map_MouseDown);
            this.gfxView_map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gfxView_map_MouseMove);
            // 
            // FormMinimap
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox_tiles);
            this.Controls.Add(this.panel_squares);
            this.Controls.Add(this.gfxView_map);
            this.Controls.Add(this.groupBox_selection);
            this.Controls.Add(this.groupBox_map);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_apply);
            this.KeyPreview = true;
            this.Name = "FormMinimap";
            this.toolTip_bgColor.SetToolTip(this, resources.GetString("$this.ToolTip"));
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
        private System.Windows.Forms.ComboBox comboBox_area;
        private System.Windows.Forms.ComboBox comboBox_view;
        private System.Windows.Forms.Label label_view;
        private System.Windows.Forms.Label label_palette;
        private System.Windows.Forms.ComboBox comboBox_palette;
        private System.Windows.Forms.ComboBox comboBox_type;
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