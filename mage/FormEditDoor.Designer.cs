namespace mage
{
    partial class FormEditDoor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditDoor));
            button_close = new System.Windows.Forms.Button();
            button_apply = new System.Windows.Forms.Button();
            label_srcDoor = new System.Windows.Forms.Label();
            label_type = new System.Windows.Forms.Label();
            label_width = new System.Windows.Forms.Label();
            label_height = new System.Windows.Forms.Label();
            label_connectedDoor = new System.Windows.Forms.Label();
            label_xExitDistance = new System.Windows.Forms.Label();
            textBox_width = new Theming.CustomControls.FlatTextBox();
            textBox_height = new Theming.CustomControls.FlatTextBox();
            textBox_connectedDoor = new Theming.CustomControls.FlatTextBox();
            textBox_xExitDistance = new Theming.CustomControls.FlatTextBox();
            label_dstRoom = new System.Windows.Forms.Label();
            label_srcRoom = new System.Windows.Forms.Label();
            textBox_ownerRoom = new Theming.CustomControls.FlatTextBox();
            label_ownerRoom = new System.Windows.Forms.Label();
            checkBox_autoConnect = new System.Windows.Forms.CheckBox();
            comboBox_type = new Theming.CustomControls.FlatComboBox();
            checkBox_event = new System.Windows.Forms.CheckBox();
            checkBox_location = new System.Windows.Forms.CheckBox();
            label_source = new System.Windows.Forms.Label();
            label_destination = new System.Windows.Forms.Label();
            label_dstDoor = new System.Windows.Forms.Label();
            label_srcArea = new System.Windows.Forms.Label();
            label_dstArea = new System.Windows.Forms.Label();
            label_door = new System.Windows.Forms.Label();
            label_room = new System.Windows.Forms.Label();
            label_area = new System.Windows.Forms.Label();
            groupBox_info = new System.Windows.Forms.GroupBox();
            groupBox_edit = new System.Windows.Forms.GroupBox();
            textBox_yExitDistance = new Theming.CustomControls.FlatTextBox();
            label_yExitDistance = new System.Windows.Forms.Label();
            statusStrip = new System.Windows.Forms.StatusStrip();
            statusLabel_changes = new System.Windows.Forms.ToolStripStatusLabel();
            groupBox_info.SuspendLayout();
            groupBox_edit.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // button_close
            // 
            button_close.Location = new System.Drawing.Point(274, 255);
            button_close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_close.Name = "button_close";
            button_close.Size = new System.Drawing.Size(88, 27);
            button_close.TabIndex = 1;
            button_close.Text = "Close";
            button_close.UseVisualStyleBackColor = true;
            button_close.Click += button_close_Click;
            // 
            // button_apply
            // 
            button_apply.Enabled = false;
            button_apply.Location = new System.Drawing.Point(274, 222);
            button_apply.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button_apply.Name = "button_apply";
            button_apply.Size = new System.Drawing.Size(88, 27);
            button_apply.TabIndex = 0;
            button_apply.Text = "Apply";
            button_apply.UseVisualStyleBackColor = true;
            button_apply.Click += button_apply_Click;
            // 
            // label_srcDoor
            // 
            label_srcDoor.AutoSize = true;
            label_srcDoor.Location = new System.Drawing.Point(211, 43);
            label_srcDoor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_srcDoor.Name = "label_srcDoor";
            label_srcDoor.Size = new System.Drawing.Size(13, 15);
            label_srcDoor.TabIndex = 0;
            label_srcDoor.Text = "0";
            // 
            // label_type
            // 
            label_type.AutoSize = true;
            label_type.Location = new System.Drawing.Point(7, 25);
            label_type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_type.Name = "label_type";
            label_type.Size = new System.Drawing.Size(34, 15);
            label_type.TabIndex = 0;
            label_type.Text = "Type:";
            // 
            // label_width
            // 
            label_width.AutoSize = true;
            label_width.Location = new System.Drawing.Point(7, 111);
            label_width.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_width.Name = "label_width";
            label_width.Size = new System.Drawing.Size(42, 15);
            label_width.TabIndex = 0;
            label_width.Text = "Width:";
            // 
            // label_height
            // 
            label_height.AutoSize = true;
            label_height.Location = new System.Drawing.Point(7, 141);
            label_height.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_height.Name = "label_height";
            label_height.Size = new System.Drawing.Size(46, 15);
            label_height.TabIndex = 0;
            label_height.Text = "Height:";
            // 
            // label_connectedDoor
            // 
            label_connectedDoor.AutoSize = true;
            label_connectedDoor.Location = new System.Drawing.Point(190, 55);
            label_connectedDoor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_connectedDoor.Name = "label_connectedDoor";
            label_connectedDoor.Size = new System.Drawing.Size(96, 15);
            label_connectedDoor.TabIndex = 12;
            label_connectedDoor.Text = "Connected door:";
            // 
            // label_xExitDistance
            // 
            label_xExitDistance.AutoSize = true;
            label_xExitDistance.Location = new System.Drawing.Point(190, 85);
            label_xExitDistance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_xExitDistance.Name = "label_xExitDistance";
            label_xExitDistance.Size = new System.Drawing.Size(86, 15);
            label_xExitDistance.TabIndex = 14;
            label_xExitDistance.Text = "X exit distance:";
            // 
            // textBox_width
            // 
            textBox_width.BorderColor = System.Drawing.Color.Black;
            textBox_width.Location = new System.Drawing.Point(63, 107);
            textBox_width.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_width.Multiline = false;
            textBox_width.Name = "textBox_width";
            textBox_width.Padding = new System.Windows.Forms.Padding(4, 3, 1, 2);
            textBox_width.ReadOnly = false;
            textBox_width.ScrollBars = System.Windows.Forms.ScrollBars.None;
            textBox_width.SelectionStart = 0;
            textBox_width.Size = new System.Drawing.Size(41, 23);
            textBox_width.TabIndex = 3;
            textBox_width.WordWrap = true;
            textBox_width.TextChanged += ValueChanged;
            // 
            // textBox_height
            // 
            textBox_height.BorderColor = System.Drawing.Color.Black;
            textBox_height.Location = new System.Drawing.Point(62, 137);
            textBox_height.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_height.Multiline = false;
            textBox_height.Name = "textBox_height";
            textBox_height.Padding = new System.Windows.Forms.Padding(4, 3, 1, 2);
            textBox_height.ReadOnly = false;
            textBox_height.ScrollBars = System.Windows.Forms.ScrollBars.None;
            textBox_height.SelectionStart = 0;
            textBox_height.Size = new System.Drawing.Size(41, 23);
            textBox_height.TabIndex = 4;
            textBox_height.WordWrap = true;
            textBox_height.TextChanged += ValueChanged;
            // 
            // textBox_connectedDoor
            // 
            textBox_connectedDoor.BorderColor = System.Drawing.Color.Black;
            textBox_connectedDoor.Location = new System.Drawing.Point(298, 52);
            textBox_connectedDoor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_connectedDoor.Multiline = false;
            textBox_connectedDoor.Name = "textBox_connectedDoor";
            textBox_connectedDoor.Padding = new System.Windows.Forms.Padding(4, 3, 1, 2);
            textBox_connectedDoor.ReadOnly = false;
            textBox_connectedDoor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            textBox_connectedDoor.SelectionStart = 0;
            textBox_connectedDoor.Size = new System.Drawing.Size(41, 23);
            textBox_connectedDoor.TabIndex = 7;
            textBox_connectedDoor.WordWrap = true;
            textBox_connectedDoor.TextChanged += ValueChanged;
            // 
            // textBox_xExitDistance
            // 
            textBox_xExitDistance.BorderColor = System.Drawing.Color.Black;
            textBox_xExitDistance.Location = new System.Drawing.Point(298, 82);
            textBox_xExitDistance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_xExitDistance.Multiline = false;
            textBox_xExitDistance.Name = "textBox_xExitDistance";
            textBox_xExitDistance.Padding = new System.Windows.Forms.Padding(4, 3, 1, 2);
            textBox_xExitDistance.ReadOnly = false;
            textBox_xExitDistance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            textBox_xExitDistance.SelectionStart = 0;
            textBox_xExitDistance.Size = new System.Drawing.Size(41, 23);
            textBox_xExitDistance.TabIndex = 8;
            textBox_xExitDistance.WordWrap = true;
            textBox_xExitDistance.TextChanged += ValueChanged;
            // 
            // label_dstRoom
            // 
            label_dstRoom.AutoSize = true;
            label_dstRoom.Location = new System.Drawing.Point(163, 67);
            label_dstRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_dstRoom.Name = "label_dstRoom";
            label_dstRoom.Size = new System.Drawing.Size(13, 15);
            label_dstRoom.TabIndex = 0;
            label_dstRoom.Text = "0";
            // 
            // label_srcRoom
            // 
            label_srcRoom.AutoSize = true;
            label_srcRoom.Location = new System.Drawing.Point(163, 43);
            label_srcRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_srcRoom.Name = "label_srcRoom";
            label_srcRoom.Size = new System.Drawing.Size(13, 15);
            label_srcRoom.TabIndex = 0;
            label_srcRoom.Text = "0";
            // 
            // textBox_ownerRoom
            // 
            textBox_ownerRoom.BorderColor = System.Drawing.Color.Black;
            textBox_ownerRoom.Location = new System.Drawing.Point(298, 22);
            textBox_ownerRoom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_ownerRoom.Multiline = false;
            textBox_ownerRoom.Name = "textBox_ownerRoom";
            textBox_ownerRoom.Padding = new System.Windows.Forms.Padding(4, 3, 1, 2);
            textBox_ownerRoom.ReadOnly = false;
            textBox_ownerRoom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            textBox_ownerRoom.SelectionStart = 0;
            textBox_ownerRoom.Size = new System.Drawing.Size(41, 23);
            textBox_ownerRoom.TabIndex = 6;
            textBox_ownerRoom.WordWrap = true;
            textBox_ownerRoom.TextChanged += ValueChanged;
            // 
            // label_ownerRoom
            // 
            label_ownerRoom.AutoSize = true;
            label_ownerRoom.Location = new System.Drawing.Point(190, 25);
            label_ownerRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_ownerRoom.Name = "label_ownerRoom";
            label_ownerRoom.Size = new System.Drawing.Size(77, 15);
            label_ownerRoom.TabIndex = 0;
            label_ownerRoom.Text = "Owner room:";
            // 
            // checkBox_autoConnect
            // 
            checkBox_autoConnect.AutoSize = true;
            checkBox_autoConnect.Location = new System.Drawing.Point(145, 142);
            checkBox_autoConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBox_autoConnect.Name = "checkBox_autoConnect";
            checkBox_autoConnect.Size = new System.Drawing.Size(188, 19);
            checkBox_autoConnect.TabIndex = 5;
            checkBox_autoConnect.Text = "Auto connect destination door";
            // 
            // comboBox_type
            // 
            comboBox_type.FormattingEnabled = true;
            comboBox_type.Items.AddRange(new object[] { "Area connection", "No hatch", "Open hatch" });
            comboBox_type.Location = new System.Drawing.Point(51, 22);
            comboBox_type.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox_type.Name = "comboBox_type";
            comboBox_type.Size = new System.Drawing.Size(121, 23);
            comboBox_type.TabIndex = 0;
            comboBox_type.SelectedIndexChanged += ValueChanged;
            // 
            // checkBox_event
            // 
            checkBox_event.AutoSize = true;
            checkBox_event.Location = new System.Drawing.Point(10, 53);
            checkBox_event.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBox_event.Name = "checkBox_event";
            checkBox_event.Size = new System.Drawing.Size(155, 19);
            checkBox_event.TabIndex = 1;
            checkBox_event.Text = "Loads event based room";
            checkBox_event.UseVisualStyleBackColor = true;
            checkBox_event.CheckedChanged += ValueChanged;
            // 
            // checkBox_location
            // 
            checkBox_location.AutoSize = true;
            checkBox_location.Location = new System.Drawing.Point(10, 80);
            checkBox_location.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBox_location.Name = "checkBox_location";
            checkBox_location.Size = new System.Drawing.Size(148, 19);
            checkBox_location.TabIndex = 2;
            checkBox_location.Text = "Displays location name";
            checkBox_location.UseVisualStyleBackColor = true;
            checkBox_location.CheckedChanged += ValueChanged;
            // 
            // label_source
            // 
            label_source.AutoSize = true;
            label_source.Location = new System.Drawing.Point(7, 43);
            label_source.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_source.Name = "label_source";
            label_source.Size = new System.Drawing.Size(50, 15);
            label_source.TabIndex = 0;
            label_source.Text = "Current:";
            // 
            // label_destination
            // 
            label_destination.AutoSize = true;
            label_destination.Location = new System.Drawing.Point(7, 67);
            label_destination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_destination.Name = "label_destination";
            label_destination.Size = new System.Drawing.Size(70, 15);
            label_destination.TabIndex = 0;
            label_destination.Text = "Destination:";
            // 
            // label_dstDoor
            // 
            label_dstDoor.AutoSize = true;
            label_dstDoor.Location = new System.Drawing.Point(211, 67);
            label_dstDoor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_dstDoor.Name = "label_dstDoor";
            label_dstDoor.Size = new System.Drawing.Size(13, 15);
            label_dstDoor.TabIndex = 0;
            label_dstDoor.Text = "0";
            // 
            // label_srcArea
            // 
            label_srcArea.AutoSize = true;
            label_srcArea.Location = new System.Drawing.Point(88, 43);
            label_srcArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_srcArea.Name = "label_srcArea";
            label_srcArea.Size = new System.Drawing.Size(31, 15);
            label_srcArea.TabIndex = 0;
            label_srcArea.Text = "Area";
            // 
            // label_dstArea
            // 
            label_dstArea.AutoSize = true;
            label_dstArea.Location = new System.Drawing.Point(88, 67);
            label_dstArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_dstArea.Name = "label_dstArea";
            label_dstArea.Size = new System.Drawing.Size(31, 15);
            label_dstArea.TabIndex = 0;
            label_dstArea.Text = "Area";
            // 
            // label_door
            // 
            label_door.AutoSize = true;
            label_door.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            label_door.Location = new System.Drawing.Point(211, 18);
            label_door.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_door.Name = "label_door";
            label_door.Size = new System.Drawing.Size(30, 13);
            label_door.TabIndex = 0;
            label_door.Text = "Door";
            // 
            // label_room
            // 
            label_room.AutoSize = true;
            label_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            label_room.Location = new System.Drawing.Point(163, 18);
            label_room.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_room.Name = "label_room";
            label_room.Size = new System.Drawing.Size(35, 13);
            label_room.TabIndex = 0;
            label_room.Text = "Room";
            // 
            // label_area
            // 
            label_area.AutoSize = true;
            label_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            label_area.Location = new System.Drawing.Point(88, 18);
            label_area.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_area.Name = "label_area";
            label_area.Size = new System.Drawing.Size(29, 13);
            label_area.TabIndex = 0;
            label_area.Text = "Area";
            // 
            // groupBox_info
            // 
            groupBox_info.Controls.Add(label_area);
            groupBox_info.Controls.Add(label_door);
            groupBox_info.Controls.Add(label_srcDoor);
            groupBox_info.Controls.Add(label_room);
            groupBox_info.Controls.Add(label_srcRoom);
            groupBox_info.Controls.Add(label_dstRoom);
            groupBox_info.Controls.Add(label_dstArea);
            groupBox_info.Controls.Add(label_source);
            groupBox_info.Controls.Add(label_srcArea);
            groupBox_info.Controls.Add(label_destination);
            groupBox_info.Controls.Add(label_dstDoor);
            groupBox_info.Location = new System.Drawing.Point(14, 189);
            groupBox_info.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_info.Name = "groupBox_info";
            groupBox_info.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_info.Size = new System.Drawing.Size(253, 92);
            groupBox_info.TabIndex = 0;
            groupBox_info.TabStop = false;
            groupBox_info.Text = "Info";
            // 
            // groupBox_edit
            // 
            groupBox_edit.Controls.Add(textBox_yExitDistance);
            groupBox_edit.Controls.Add(label_yExitDistance);
            groupBox_edit.Controls.Add(comboBox_type);
            groupBox_edit.Controls.Add(label_type);
            groupBox_edit.Controls.Add(checkBox_autoConnect);
            groupBox_edit.Controls.Add(checkBox_location);
            groupBox_edit.Controls.Add(textBox_height);
            groupBox_edit.Controls.Add(textBox_ownerRoom);
            groupBox_edit.Controls.Add(textBox_width);
            groupBox_edit.Controls.Add(label_height);
            groupBox_edit.Controls.Add(label_ownerRoom);
            groupBox_edit.Controls.Add(label_width);
            groupBox_edit.Controls.Add(checkBox_event);
            groupBox_edit.Controls.Add(textBox_xExitDistance);
            groupBox_edit.Controls.Add(label_connectedDoor);
            groupBox_edit.Controls.Add(textBox_connectedDoor);
            groupBox_edit.Controls.Add(label_xExitDistance);
            groupBox_edit.Location = new System.Drawing.Point(14, 14);
            groupBox_edit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_edit.Name = "groupBox_edit";
            groupBox_edit.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox_edit.Size = new System.Drawing.Size(348, 168);
            groupBox_edit.TabIndex = 0;
            groupBox_edit.TabStop = false;
            groupBox_edit.Text = "Edit";
            // 
            // textBox_yExitDistance
            // 
            textBox_yExitDistance.BorderColor = System.Drawing.Color.Black;
            textBox_yExitDistance.Location = new System.Drawing.Point(298, 112);
            textBox_yExitDistance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox_yExitDistance.Multiline = false;
            textBox_yExitDistance.Name = "textBox_yExitDistance";
            textBox_yExitDistance.Padding = new System.Windows.Forms.Padding(4, 3, 1, 2);
            textBox_yExitDistance.ReadOnly = false;
            textBox_yExitDistance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            textBox_yExitDistance.SelectionStart = 0;
            textBox_yExitDistance.Size = new System.Drawing.Size(41, 23);
            textBox_yExitDistance.TabIndex = 15;
            textBox_yExitDistance.WordWrap = true;
            textBox_yExitDistance.TextChanged += ValueChanged;
            // 
            // label_yExitDistance
            // 
            label_yExitDistance.AutoSize = true;
            label_yExitDistance.Location = new System.Drawing.Point(190, 115);
            label_yExitDistance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label_yExitDistance.Name = "label_yExitDistance";
            label_yExitDistance.Size = new System.Drawing.Size(86, 15);
            label_yExitDistance.TabIndex = 16;
            label_yExitDistance.Text = "Y exit distance:";
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { statusLabel_changes });
            statusStrip.Location = new System.Drawing.Point(0, 288);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStrip.Size = new System.Drawing.Size(376, 22);
            statusStrip.TabIndex = 3;
            statusStrip.Text = "statusStrip1";
            // 
            // statusLabel_changes
            // 
            statusLabel_changes.Name = "statusLabel_changes";
            statusLabel_changes.Size = new System.Drawing.Size(12, 17);
            statusLabel_changes.Text = "-";
            // 
            // FormEditDoor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(376, 310);
            Controls.Add(statusStrip);
            Controls.Add(groupBox_edit);
            Controls.Add(groupBox_info);
            Controls.Add(button_close);
            Controls.Add(button_apply);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEditDoor";
            Text = "Edit Door";
            groupBox_info.ResumeLayout(false);
            groupBox_info.PerformLayout();
            groupBox_edit.ResumeLayout(false);
            groupBox_edit.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Label label_srcDoor;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_width;
        private System.Windows.Forms.Label label_height;
        private System.Windows.Forms.Label label_connectedDoor;
        private System.Windows.Forms.Label label_xExitDistance;
        private mage.Theming.CustomControls.FlatTextBox textBox_width;
        private mage.Theming.CustomControls.FlatTextBox textBox_height;
        private mage.Theming.CustomControls.FlatTextBox textBox_connectedDoor;
        private mage.Theming.CustomControls.FlatTextBox textBox_xExitDistance;
        private System.Windows.Forms.Label label_dstRoom;
        private System.Windows.Forms.Label label_srcRoom;
        private mage.Theming.CustomControls.FlatTextBox textBox_ownerRoom;
        private System.Windows.Forms.Label label_ownerRoom;
        private System.Windows.Forms.CheckBox checkBox_autoConnect;
        private mage.Theming.CustomControls.FlatComboBox comboBox_type;
        private System.Windows.Forms.CheckBox checkBox_event;
        private System.Windows.Forms.CheckBox checkBox_location;
        private System.Windows.Forms.Label label_source;
        private System.Windows.Forms.Label label_destination;
        private System.Windows.Forms.Label label_dstDoor;
        private System.Windows.Forms.Label label_srcArea;
        private System.Windows.Forms.Label label_dstArea;
        private System.Windows.Forms.Label label_door;
        private System.Windows.Forms.Label label_room;
        private System.Windows.Forms.Label label_area;
        private System.Windows.Forms.GroupBox groupBox_info;
        private System.Windows.Forms.GroupBox groupBox_edit;
        private mage.Theming.CustomControls.FlatTextBox textBox_yExitDistance;
        private System.Windows.Forms.Label label_yExitDistance;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_changes;
    }
}