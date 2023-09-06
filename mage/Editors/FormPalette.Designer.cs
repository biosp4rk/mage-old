namespace mage
{
    partial class FormPalette
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPalette));
            pictureBox_palette = new System.Windows.Forms.PictureBox();
            pictureBox_chosenColor = new System.Windows.Forms.PictureBox();
            comboBox_tileset = new Theming.CustomControls.FlatComboBox();
            groupBox_offset = new System.Windows.Forms.GroupBox();
            button_minus = new System.Windows.Forms.Button();
            button_plus = new System.Windows.Forms.Button();
            button_go = new System.Windows.Forms.Button();
            numericUpDown_rows = new Theming.CustomControls.FlatNumericUpDown();
            label_numOfRows = new System.Windows.Forms.Label();
            textBox_offset = new Theming.CustomControls.FlatTextBox();
            comboBox_sprite = new Theming.CustomControls.FlatComboBox();
            label_red = new System.Windows.Forms.Label();
            label_green = new System.Windows.Forms.Label();
            label_blue = new System.Windows.Forms.Label();
            numericUpDown_red = new Theming.CustomControls.FlatNumericUpDown();
            numericUpDown_green = new Theming.CustomControls.FlatNumericUpDown();
            numericUpDown_blue = new Theming.CustomControls.FlatNumericUpDown();
            button_apply = new System.Windows.Forms.Button();
            button_close = new System.Windows.Forms.Button();
            label_15bit = new System.Windows.Forms.Label();
            label_15bitVal = new System.Windows.Forms.Label();
            pictureBox_red = new System.Windows.Forms.PictureBox();
            pictureBox_green = new System.Windows.Forms.PictureBox();
            pictureBox_blue = new System.Windows.Forms.PictureBox();
            groupBox_color = new System.Windows.Forms.GroupBox();
            label_html_color = new System.Windows.Forms.Label();
            textBox_html_color = new Theming.CustomControls.FlatTextBox();
            groupBox_shortcuts = new System.Windows.Forms.GroupBox();
            label_sprite = new System.Windows.Forms.Label();
            label_tileset = new System.Windows.Forms.Label();
            label_24bitVal = new System.Windows.Forms.Label();
            label_24bit = new System.Windows.Forms.Label();
            groupBox_info = new System.Windows.Forms.GroupBox();
            statusStrip = new System.Windows.Forms.StatusStrip();
            statusLabel_changes = new System.Windows.Forms.ToolStripStatusLabel();
            statusStrip_spring = new System.Windows.Forms.ToolStripStatusLabel();
            statusStrip_import = new System.Windows.Forms.ToolStripDropDownButton();
            statusStrip_importRaw = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip_importTLP = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip_importYY = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip_export = new System.Windows.Forms.ToolStripDropDownButton();
            statusStrip_exportRaw = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip_exportTLP = new System.Windows.Forms.ToolStripMenuItem();
            statusStrip_exportYY = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox_palette).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_chosenColor).BeginInit();
            groupBox_offset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_rows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_red).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_green).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_blue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_red).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_green).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_blue).BeginInit();
            groupBox_color.SuspendLayout();
            groupBox_shortcuts.SuspendLayout();
            groupBox_info.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox_palette
            // 
            pictureBox_palette.Location = new System.Drawing.Point(14, 14);
            pictureBox_palette.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox_palette.Name = "pictureBox_palette";
            pictureBox_palette.Size = new System.Drawing.Size(318, 315);
            pictureBox_palette.TabIndex = 0;
            pictureBox_palette.TabStop = false;
            pictureBox_palette.MouseClick += pictureBox_palette_MouseClick;
            // 
            // pictureBox_chosenColor
            // 
            pictureBox_chosenColor.Location = new System.Drawing.Point(7, 21);
            pictureBox_chosenColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox_chosenColor.Name = "pictureBox_chosenColor";
            pictureBox_chosenColor.Size = new System.Drawing.Size(35, 35);
            pictureBox_chosenColor.TabIndex = 2;
            pictureBox_chosenColor.TabStop = false;
            // 
            // comboBox_tileset
            // 
            comboBox_tileset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_tileset.FormattingEnabled = true;
            comboBox_tileset.Location = new System.Drawing.Point(62, 22);
            comboBox_tileset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox_tileset.Name = "comboBox_tileset";
            comboBox_tileset.Size = new System.Drawing.Size(52, 23);
            comboBox_tileset.TabIndex = 0;
            comboBox_tileset.SelectedIndexChanged += comboBox_tileset_SelectedIndexChanged;
            // 
            // groupBox_offset
            // 
            groupBox_offset.Controls.Add(button_minus);
            groupBox_offset.Controls.Add(button_plus);
            groupBox_offset.Controls.Add(button_go);
            groupBox_offset.Controls.Add(numericUpDown_rows);
            groupBox_offset.Controls.Add(label_numOfRows);
            groupBox_offset.Controls.Add(textBox_offset);
            groupBox_offset.Location = new System.Drawing.Point(340, 14);
            groupBox_offset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_offset.Name = "groupBox_offset";
            groupBox_offset.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_offset.Size = new System.Drawing.Size(181, 84);
            groupBox_offset.TabIndex = 0;
            groupBox_offset.TabStop = false;
            groupBox_offset.Text = "Offset";
            // 
            // button_minus
            // 
            button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button_minus.Location = new System.Drawing.Point(40, 50);
            button_minus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_minus.Name = "button_minus";
            button_minus.Size = new System.Drawing.Size(26, 25);
            button_minus.TabIndex = 3;
            button_minus.Text = "-";
            button_minus.UseVisualStyleBackColor = true;
            button_minus.Click += button_minus_Click;
            // 
            // button_plus
            // 
            button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button_plus.Location = new System.Drawing.Point(7, 50);
            button_plus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_plus.Name = "button_plus";
            button_plus.Size = new System.Drawing.Size(26, 25);
            button_plus.TabIndex = 2;
            button_plus.Text = "+";
            button_plus.UseVisualStyleBackColor = true;
            button_plus.Click += button_plus_Click;
            // 
            // button_go
            // 
            button_go.Location = new System.Drawing.Point(107, 21);
            button_go.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_go.Name = "button_go";
            button_go.Size = new System.Drawing.Size(64, 25);
            button_go.TabIndex = 1;
            button_go.Text = "Go";
            button_go.UseVisualStyleBackColor = true;
            button_go.Click += button_go_Click;
            // 
            // numericUpDown_rows
            // 
            numericUpDown_rows.Hexadecimal = true;
            numericUpDown_rows.Location = new System.Drawing.Point(121, 52);
            numericUpDown_rows.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numericUpDown_rows.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            numericUpDown_rows.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_rows.Name = "numericUpDown_rows";
            numericUpDown_rows.Size = new System.Drawing.Size(49, 23);
            numericUpDown_rows.TabIndex = 4;
            numericUpDown_rows.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label_numOfRows
            // 
            label_numOfRows.AutoSize = true;
            label_numOfRows.Location = new System.Drawing.Point(75, 54);
            label_numOfRows.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_numOfRows.Name = "label_numOfRows";
            label_numOfRows.Size = new System.Drawing.Size(38, 15);
            label_numOfRows.TabIndex = 0;
            label_numOfRows.Text = "Rows:";
            // 
            // textBox_offset
            // 
            textBox_offset.BorderColor = System.Drawing.Color.FromArgb(188, 188, 188);
            textBox_offset.Location = new System.Drawing.Point(7, 22);
            textBox_offset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_offset.Multiline = false;
            textBox_offset.Name = "textBox_offset";
            textBox_offset.Padding = new System.Windows.Forms.Padding(4, 3, 1, 2);
            textBox_offset.ReadOnly = false;
            textBox_offset.ScrollBars = System.Windows.Forms.ScrollBars.None;
            textBox_offset.SelectionStart = 0;
            textBox_offset.Size = new System.Drawing.Size(93, 23);
            textBox_offset.TabIndex = 0;
            textBox_offset.WordWrap = true;
            // 
            // comboBox_sprite
            // 
            comboBox_sprite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox_sprite.FormattingEnabled = true;
            comboBox_sprite.Location = new System.Drawing.Point(62, 53);
            comboBox_sprite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox_sprite.Name = "comboBox_sprite";
            comboBox_sprite.Size = new System.Drawing.Size(52, 23);
            comboBox_sprite.TabIndex = 1;
            comboBox_sprite.SelectedIndexChanged += comboBox_sprite_SelectedIndexChanged;
            // 
            // label_red
            // 
            label_red.AutoSize = true;
            label_red.Location = new System.Drawing.Point(7, 24);
            label_red.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_red.Name = "label_red";
            label_red.Size = new System.Drawing.Size(30, 15);
            label_red.TabIndex = 0;
            label_red.Text = "Red:";
            // 
            // label_green
            // 
            label_green.AutoSize = true;
            label_green.Location = new System.Drawing.Point(7, 58);
            label_green.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_green.Name = "label_green";
            label_green.Size = new System.Drawing.Size(41, 15);
            label_green.TabIndex = 0;
            label_green.Text = "Green:";
            // 
            // label_blue
            // 
            label_blue.AutoSize = true;
            label_blue.Location = new System.Drawing.Point(7, 91);
            label_blue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_blue.Name = "label_blue";
            label_blue.Size = new System.Drawing.Size(33, 15);
            label_blue.TabIndex = 0;
            label_blue.Text = "Blue:";
            // 
            // numericUpDown_red
            // 
            numericUpDown_red.Hexadecimal = true;
            numericUpDown_red.Location = new System.Drawing.Point(57, 22);
            numericUpDown_red.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numericUpDown_red.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            numericUpDown_red.Name = "numericUpDown_red";
            numericUpDown_red.Size = new System.Drawing.Size(47, 23);
            numericUpDown_red.TabIndex = 0;
            numericUpDown_red.ValueChanged += numericUpDown_red_ValueChanged;
            // 
            // numericUpDown_green
            // 
            numericUpDown_green.Hexadecimal = true;
            numericUpDown_green.Location = new System.Drawing.Point(57, 55);
            numericUpDown_green.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numericUpDown_green.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            numericUpDown_green.Name = "numericUpDown_green";
            numericUpDown_green.Size = new System.Drawing.Size(47, 23);
            numericUpDown_green.TabIndex = 1;
            numericUpDown_green.ValueChanged += numericUpDown_green_ValueChanged;
            // 
            // numericUpDown_blue
            // 
            numericUpDown_blue.Hexadecimal = true;
            numericUpDown_blue.Location = new System.Drawing.Point(57, 89);
            numericUpDown_blue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numericUpDown_blue.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            numericUpDown_blue.Name = "numericUpDown_blue";
            numericUpDown_blue.Size = new System.Drawing.Size(47, 23);
            numericUpDown_blue.TabIndex = 2;
            numericUpDown_blue.ValueChanged += numericUpDown_blue_ValueChanged;
            // 
            // button_apply
            // 
            button_apply.Enabled = false;
            button_apply.Location = new System.Drawing.Point(527, 271);
            button_apply.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_apply.Name = "button_apply";
            button_apply.Size = new System.Drawing.Size(82, 27);
            button_apply.TabIndex = 3;
            button_apply.Text = "Apply";
            button_apply.UseVisualStyleBackColor = true;
            button_apply.Click += button_apply_Click;
            // 
            // button_close
            // 
            button_close.Location = new System.Drawing.Point(527, 304);
            button_close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_close.Name = "button_close";
            button_close.Size = new System.Drawing.Size(82, 27);
            button_close.TabIndex = 4;
            button_close.Text = "Close";
            button_close.UseVisualStyleBackColor = true;
            button_close.Click += button_close_Click;
            // 
            // label_15bit
            // 
            label_15bit.AutoSize = true;
            label_15bit.Location = new System.Drawing.Point(47, 21);
            label_15bit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_15bit.Name = "label_15bit";
            label_15bit.Size = new System.Drawing.Size(41, 15);
            label_15bit.TabIndex = 18;
            label_15bit.Text = "15-bit:";
            // 
            // label_15bitVal
            // 
            label_15bitVal.AutoSize = true;
            label_15bitVal.Location = new System.Drawing.Point(89, 21);
            label_15bitVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_15bitVal.Name = "label_15bitVal";
            label_15bitVal.Size = new System.Drawing.Size(43, 15);
            label_15bitVal.TabIndex = 19;
            label_15bitVal.Text = "0x0000";
            // 
            // pictureBox_red
            // 
            pictureBox_red.Location = new System.Drawing.Point(114, 22);
            pictureBox_red.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox_red.Name = "pictureBox_red";
            pictureBox_red.Size = new System.Drawing.Size(149, 23);
            pictureBox_red.TabIndex = 21;
            pictureBox_red.TabStop = false;
            pictureBox_red.MouseDown += pictureBox_red_MouseDown;
            pictureBox_red.MouseMove += pictureBox_red_MouseMove;
            // 
            // pictureBox_green
            // 
            pictureBox_green.Location = new System.Drawing.Point(114, 55);
            pictureBox_green.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox_green.Name = "pictureBox_green";
            pictureBox_green.Size = new System.Drawing.Size(149, 23);
            pictureBox_green.TabIndex = 22;
            pictureBox_green.TabStop = false;
            pictureBox_green.MouseDown += pictureBox_green_MouseDown;
            pictureBox_green.MouseMove += pictureBox_green_MouseMove;
            // 
            // pictureBox_blue
            // 
            pictureBox_blue.Location = new System.Drawing.Point(114, 89);
            pictureBox_blue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox_blue.Name = "pictureBox_blue";
            pictureBox_blue.Size = new System.Drawing.Size(149, 23);
            pictureBox_blue.TabIndex = 23;
            pictureBox_blue.TabStop = false;
            pictureBox_blue.MouseDown += pictureBox_blue_MouseDown;
            pictureBox_blue.MouseMove += pictureBox_blue_MouseMove;
            // 
            // groupBox_color
            // 
            groupBox_color.Controls.Add(label_html_color);
            groupBox_color.Controls.Add(textBox_html_color);
            groupBox_color.Controls.Add(label_red);
            groupBox_color.Controls.Add(pictureBox_blue);
            groupBox_color.Controls.Add(label_green);
            groupBox_color.Controls.Add(pictureBox_green);
            groupBox_color.Controls.Add(label_blue);
            groupBox_color.Controls.Add(pictureBox_red);
            groupBox_color.Controls.Add(numericUpDown_red);
            groupBox_color.Controls.Add(numericUpDown_green);
            groupBox_color.Controls.Add(numericUpDown_blue);
            groupBox_color.Enabled = false;
            groupBox_color.Location = new System.Drawing.Point(340, 105);
            groupBox_color.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_color.Name = "groupBox_color";
            groupBox_color.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_color.Size = new System.Drawing.Size(273, 155);
            groupBox_color.TabIndex = 2;
            groupBox_color.TabStop = false;
            groupBox_color.Text = "Color Selector";
            // 
            // label_html_color
            // 
            label_html_color.AutoSize = true;
            label_html_color.Location = new System.Drawing.Point(7, 127);
            label_html_color.Name = "label_html_color";
            label_html_color.Size = new System.Drawing.Size(42, 15);
            label_html_color.TabIndex = 25;
            label_html_color.Text = "HTML:";
            // 
            // textBox_html_color
            // 
            textBox_html_color.BorderColor = System.Drawing.Color.Black;
            textBox_html_color.Location = new System.Drawing.Point(57, 122);
            textBox_html_color.Multiline = false;
            textBox_html_color.Name = "textBox_html_color";
            textBox_html_color.Padding = new System.Windows.Forms.Padding(4, 3, 4, 2);
            textBox_html_color.ReadOnly = false;
            textBox_html_color.ScrollBars = System.Windows.Forms.ScrollBars.None;
            textBox_html_color.SelectionStart = 0;
            textBox_html_color.Size = new System.Drawing.Size(206, 23);
            textBox_html_color.TabIndex = 24;
            textBox_html_color.WordWrap = true;
            // 
            // groupBox_shortcuts
            // 
            groupBox_shortcuts.Controls.Add(label_sprite);
            groupBox_shortcuts.Controls.Add(label_tileset);
            groupBox_shortcuts.Controls.Add(comboBox_sprite);
            groupBox_shortcuts.Controls.Add(comboBox_tileset);
            groupBox_shortcuts.Location = new System.Drawing.Point(527, 14);
            groupBox_shortcuts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_shortcuts.Name = "groupBox_shortcuts";
            groupBox_shortcuts.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_shortcuts.Size = new System.Drawing.Size(124, 84);
            groupBox_shortcuts.TabIndex = 1;
            groupBox_shortcuts.TabStop = false;
            groupBox_shortcuts.Text = "Shortcuts";
            // 
            // label_sprite
            // 
            label_sprite.AutoSize = true;
            label_sprite.Location = new System.Drawing.Point(7, 57);
            label_sprite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_sprite.Name = "label_sprite";
            label_sprite.Size = new System.Drawing.Size(40, 15);
            label_sprite.TabIndex = 0;
            label_sprite.Text = "Sprite:";
            // 
            // label_tileset
            // 
            label_tileset.AutoSize = true;
            label_tileset.Location = new System.Drawing.Point(7, 25);
            label_tileset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_tileset.Name = "label_tileset";
            label_tileset.Size = new System.Drawing.Size(43, 15);
            label_tileset.TabIndex = 0;
            label_tileset.Text = "Tileset:";
            // 
            // label_24bitVal
            // 
            label_24bitVal.AutoSize = true;
            label_24bitVal.Location = new System.Drawing.Point(89, 38);
            label_24bitVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_24bitVal.Name = "label_24bitVal";
            label_24bitVal.Size = new System.Drawing.Size(37, 15);
            label_24bitVal.TabIndex = 27;
            label_24bitVal.Text = "0, 0, 0";
            // 
            // label_24bit
            // 
            label_24bit.AutoSize = true;
            label_24bit.Location = new System.Drawing.Point(47, 38);
            label_24bit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_24bit.Name = "label_24bit";
            label_24bit.Size = new System.Drawing.Size(41, 15);
            label_24bit.TabIndex = 26;
            label_24bit.Text = "24-bit:";
            // 
            // groupBox_info
            // 
            groupBox_info.Controls.Add(pictureBox_chosenColor);
            groupBox_info.Controls.Add(label_24bitVal);
            groupBox_info.Controls.Add(label_15bit);
            groupBox_info.Controls.Add(label_24bit);
            groupBox_info.Controls.Add(label_15bitVal);
            groupBox_info.Location = new System.Drawing.Point(341, 266);
            groupBox_info.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_info.Name = "groupBox_info";
            groupBox_info.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_info.Size = new System.Drawing.Size(180, 63);
            groupBox_info.TabIndex = 0;
            groupBox_info.TabStop = false;
            groupBox_info.Text = "Info";
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { statusLabel_changes, statusStrip_spring, statusStrip_import, statusStrip_export });
            statusStrip.Location = new System.Drawing.Point(0, 336);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStrip.Size = new System.Drawing.Size(665, 22);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "statusStrip";
            // 
            // statusLabel_changes
            // 
            statusLabel_changes.Name = "statusLabel_changes";
            statusLabel_changes.Size = new System.Drawing.Size(12, 17);
            statusLabel_changes.Text = "-";
            // 
            // statusStrip_spring
            // 
            statusStrip_spring.Name = "statusStrip_spring";
            statusStrip_spring.Size = new System.Drawing.Size(526, 17);
            statusStrip_spring.Spring = true;
            // 
            // statusStrip_import
            // 
            statusStrip_import.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            statusStrip_import.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { statusStrip_importRaw, statusStrip_importTLP, statusStrip_importYY });
            statusStrip_import.Name = "statusStrip_import";
            statusStrip_import.Size = new System.Drawing.Size(56, 20);
            statusStrip_import.Text = "Import";
            // 
            // statusStrip_importRaw
            // 
            statusStrip_importRaw.Name = "statusStrip_importRaw";
            statusStrip_importRaw.Size = new System.Drawing.Size(153, 22);
            statusStrip_importRaw.Text = "Raw...";
            statusStrip_importRaw.Click += statusStrip_importRaw_Click;
            // 
            // statusStrip_importTLP
            // 
            statusStrip_importTLP.Name = "statusStrip_importTLP";
            statusStrip_importTLP.Size = new System.Drawing.Size(153, 22);
            statusStrip_importTLP.Text = "Tile Layer Pro...";
            statusStrip_importTLP.Click += statusStrip_importTLP_Click;
            // 
            // statusStrip_importYY
            // 
            statusStrip_importYY.Name = "statusStrip_importYY";
            statusStrip_importYY.Size = new System.Drawing.Size(153, 22);
            statusStrip_importYY.Text = "YY-CHR...";
            statusStrip_importYY.Click += statusStrip_importYY_Click;
            // 
            // statusStrip_export
            // 
            statusStrip_export.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            statusStrip_export.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { statusStrip_exportRaw, statusStrip_exportTLP, statusStrip_exportYY });
            statusStrip_export.Name = "statusStrip_export";
            statusStrip_export.Size = new System.Drawing.Size(54, 20);
            statusStrip_export.Text = "Export";
            // 
            // statusStrip_exportRaw
            // 
            statusStrip_exportRaw.Name = "statusStrip_exportRaw";
            statusStrip_exportRaw.Size = new System.Drawing.Size(153, 22);
            statusStrip_exportRaw.Text = "Raw...";
            statusStrip_exportRaw.Click += statusStrip_exportRaw_Click;
            // 
            // statusStrip_exportTLP
            // 
            statusStrip_exportTLP.Name = "statusStrip_exportTLP";
            statusStrip_exportTLP.Size = new System.Drawing.Size(153, 22);
            statusStrip_exportTLP.Text = "Tile Layer Pro...";
            statusStrip_exportTLP.Click += statusStrip_exportTLP_Click;
            // 
            // statusStrip_exportYY
            // 
            statusStrip_exportYY.Name = "statusStrip_exportYY";
            statusStrip_exportYY.Size = new System.Drawing.Size(153, 22);
            statusStrip_exportYY.Text = "YY-CHR...";
            statusStrip_exportYY.Click += statusStrip_exportYY_Click;
            // 
            // FormPalette
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(665, 358);
            Controls.Add(statusStrip);
            Controls.Add(groupBox_info);
            Controls.Add(groupBox_shortcuts);
            Controls.Add(groupBox_color);
            Controls.Add(button_close);
            Controls.Add(button_apply);
            Controls.Add(groupBox_offset);
            Controls.Add(pictureBox_palette);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormPalette";
            Text = "Palette Editor";
            ((System.ComponentModel.ISupportInitialize)pictureBox_palette).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_chosenColor).EndInit();
            groupBox_offset.ResumeLayout(false);
            groupBox_offset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_rows).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_red).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_green).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_blue).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_red).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_green).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_blue).EndInit();
            groupBox_color.ResumeLayout(false);
            groupBox_color.PerformLayout();
            groupBox_shortcuts.ResumeLayout(false);
            groupBox_shortcuts.PerformLayout();
            groupBox_info.ResumeLayout(false);
            groupBox_info.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_palette;
        private System.Windows.Forms.PictureBox pictureBox_chosenColor;
        private mage.Theming.CustomControls.FlatComboBox comboBox_tileset;
        private System.Windows.Forms.GroupBox groupBox_offset;
        private System.Windows.Forms.Button button_go;
        private mage.Theming.CustomControls.FlatNumericUpDown numericUpDown_rows;
        private System.Windows.Forms.Label label_numOfRows;
        private mage.Theming.CustomControls.FlatTextBox textBox_offset;
        private mage.Theming.CustomControls.FlatComboBox comboBox_sprite;
        private System.Windows.Forms.Label label_red;
        private System.Windows.Forms.Label label_green;
        private System.Windows.Forms.Label label_blue;
        private mage.Theming.CustomControls.FlatNumericUpDown numericUpDown_red;
        private mage.Theming.CustomControls.FlatNumericUpDown numericUpDown_green;
        private mage.Theming.CustomControls.FlatNumericUpDown numericUpDown_blue;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_15bit;
        private System.Windows.Forms.Label label_15bitVal;
        private System.Windows.Forms.PictureBox pictureBox_red;
        private System.Windows.Forms.PictureBox pictureBox_green;
        private System.Windows.Forms.PictureBox pictureBox_blue;
        private System.Windows.Forms.GroupBox groupBox_color;
        private System.Windows.Forms.GroupBox groupBox_shortcuts;
        private System.Windows.Forms.Label label_sprite;
        private System.Windows.Forms.Label label_tileset;
        private System.Windows.Forms.Label label_24bitVal;
        private System.Windows.Forms.Label label_24bit;
        private System.Windows.Forms.GroupBox groupBox_info;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_changes;
        private System.Windows.Forms.ToolStripDropDownButton statusStrip_import;
        private System.Windows.Forms.ToolStripDropDownButton statusStrip_export;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip_spring;
        private System.Windows.Forms.ToolStripMenuItem statusStrip_importTLP;
        private System.Windows.Forms.ToolStripMenuItem statusStrip_importRaw;
        private System.Windows.Forms.ToolStripMenuItem statusStrip_importYY;
        private System.Windows.Forms.ToolStripMenuItem statusStrip_exportRaw;
        private System.Windows.Forms.ToolStripMenuItem statusStrip_exportTLP;
        private System.Windows.Forms.ToolStripMenuItem statusStrip_exportYY;
        private System.Windows.Forms.Label label_html_color;
        private Theming.CustomControls.FlatTextBox textBox_html_color;
    }
}