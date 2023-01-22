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
            this.button_close = new System.Windows.Forms.Button();
            this.button_apply = new System.Windows.Forms.Button();
            this.label_srcDoor = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.label_width = new System.Windows.Forms.Label();
            this.label_height = new System.Windows.Forms.Label();
            this.label_connectedDoor = new System.Windows.Forms.Label();
            this.label_xExitDistance = new System.Windows.Forms.Label();
            this.textBox_width = new System.Windows.Forms.TextBox();
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.textBox_connectedDoor = new System.Windows.Forms.TextBox();
            this.textBox_xExitDistance = new System.Windows.Forms.TextBox();
            this.label_dstRoom = new System.Windows.Forms.Label();
            this.label_srcRoom = new System.Windows.Forms.Label();
            this.textBox_ownerRoom = new System.Windows.Forms.TextBox();
            this.label_ownerRoom = new System.Windows.Forms.Label();
            this.checkBox_autoConnect = new System.Windows.Forms.CheckBox();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.checkBox_event = new System.Windows.Forms.CheckBox();
            this.checkBox_location = new System.Windows.Forms.CheckBox();
            this.label_source = new System.Windows.Forms.Label();
            this.label_destination = new System.Windows.Forms.Label();
            this.label_dstDoor = new System.Windows.Forms.Label();
            this.label_srcArea = new System.Windows.Forms.Label();
            this.label_dstArea = new System.Windows.Forms.Label();
            this.label_door = new System.Windows.Forms.Label();
            this.label_room = new System.Windows.Forms.Label();
            this.label_area = new System.Windows.Forms.Label();
            this.groupBox_info = new System.Windows.Forms.GroupBox();
            this.groupBox_edit = new System.Windows.Forms.GroupBox();
            this.textBox_yExitDistance = new System.Windows.Forms.TextBox();
            this.label_yExitDistance = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel_changes = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox_info.SuspendLayout();
            this.groupBox_edit.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(235, 221);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 1;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_apply
            // 
            this.button_apply.Enabled = false;
            this.button_apply.Location = new System.Drawing.Point(235, 192);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(75, 23);
            this.button_apply.TabIndex = 0;
            this.button_apply.Text = "Apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // label_srcDoor
            // 
            this.label_srcDoor.AutoSize = true;
            this.label_srcDoor.Location = new System.Drawing.Point(181, 37);
            this.label_srcDoor.Name = "label_srcDoor";
            this.label_srcDoor.Size = new System.Drawing.Size(13, 13);
            this.label_srcDoor.TabIndex = 0;
            this.label_srcDoor.Text = "0";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(6, 22);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(34, 13);
            this.label_type.TabIndex = 0;
            this.label_type.Text = "Type:";
            // 
            // label_width
            // 
            this.label_width.AutoSize = true;
            this.label_width.Location = new System.Drawing.Point(6, 96);
            this.label_width.Name = "label_width";
            this.label_width.Size = new System.Drawing.Size(38, 13);
            this.label_width.TabIndex = 0;
            this.label_width.Text = "Width:";
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.Location = new System.Drawing.Point(6, 122);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(41, 13);
            this.label_height.TabIndex = 0;
            this.label_height.Text = "Height:";
            // 
            // label_connectedDoor
            // 
            this.label_connectedDoor.AutoSize = true;
            this.label_connectedDoor.Location = new System.Drawing.Point(163, 48);
            this.label_connectedDoor.Name = "label_connectedDoor";
            this.label_connectedDoor.Size = new System.Drawing.Size(86, 13);
            this.label_connectedDoor.TabIndex = 12;
            this.label_connectedDoor.Text = "Connected door:";
            // 
            // label_xExitDistance
            // 
            this.label_xExitDistance.AutoSize = true;
            this.label_xExitDistance.Location = new System.Drawing.Point(163, 74);
            this.label_xExitDistance.Name = "label_xExitDistance";
            this.label_xExitDistance.Size = new System.Drawing.Size(79, 13);
            this.label_xExitDistance.TabIndex = 14;
            this.label_xExitDistance.Text = "X exit distance:";
            // 
            // textBox_width
            // 
            this.textBox_width.Location = new System.Drawing.Point(54, 93);
            this.textBox_width.Name = "textBox_width";
            this.textBox_width.Size = new System.Drawing.Size(35, 20);
            this.textBox_width.TabIndex = 3;
            this.textBox_width.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // textBox_height
            // 
            this.textBox_height.Location = new System.Drawing.Point(53, 119);
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(35, 20);
            this.textBox_height.TabIndex = 4;
            this.textBox_height.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // textBox_connectedDoor
            // 
            this.textBox_connectedDoor.Location = new System.Drawing.Point(255, 45);
            this.textBox_connectedDoor.Name = "textBox_connectedDoor";
            this.textBox_connectedDoor.Size = new System.Drawing.Size(35, 20);
            this.textBox_connectedDoor.TabIndex = 7;
            this.textBox_connectedDoor.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // textBox_xExitDistance
            // 
            this.textBox_xExitDistance.Location = new System.Drawing.Point(255, 71);
            this.textBox_xExitDistance.Name = "textBox_xExitDistance";
            this.textBox_xExitDistance.Size = new System.Drawing.Size(35, 20);
            this.textBox_xExitDistance.TabIndex = 8;
            this.textBox_xExitDistance.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label_dstRoom
            // 
            this.label_dstRoom.AutoSize = true;
            this.label_dstRoom.Location = new System.Drawing.Point(140, 58);
            this.label_dstRoom.Name = "label_dstRoom";
            this.label_dstRoom.Size = new System.Drawing.Size(13, 13);
            this.label_dstRoom.TabIndex = 0;
            this.label_dstRoom.Text = "0";
            // 
            // label_srcRoom
            // 
            this.label_srcRoom.AutoSize = true;
            this.label_srcRoom.Location = new System.Drawing.Point(140, 37);
            this.label_srcRoom.Name = "label_srcRoom";
            this.label_srcRoom.Size = new System.Drawing.Size(13, 13);
            this.label_srcRoom.TabIndex = 0;
            this.label_srcRoom.Text = "0";
            // 
            // textBox_ownerRoom
            // 
            this.textBox_ownerRoom.Location = new System.Drawing.Point(255, 19);
            this.textBox_ownerRoom.Name = "textBox_ownerRoom";
            this.textBox_ownerRoom.Size = new System.Drawing.Size(35, 20);
            this.textBox_ownerRoom.TabIndex = 6;
            this.textBox_ownerRoom.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label_ownerRoom
            // 
            this.label_ownerRoom.AutoSize = true;
            this.label_ownerRoom.Location = new System.Drawing.Point(163, 22);
            this.label_ownerRoom.Name = "label_ownerRoom";
            this.label_ownerRoom.Size = new System.Drawing.Size(67, 13);
            this.label_ownerRoom.TabIndex = 0;
            this.label_ownerRoom.Text = "Owner room:";
            // 
            // checkBox_autoConnect
            // 
            this.checkBox_autoConnect.AutoSize = true;
            this.checkBox_autoConnect.Location = new System.Drawing.Point(124, 123);
            this.checkBox_autoConnect.Name = "checkBox_autoConnect";
            this.checkBox_autoConnect.Size = new System.Drawing.Size(168, 17);
            this.checkBox_autoConnect.TabIndex = 5;
            this.checkBox_autoConnect.Text = "Auto connect destination door";
            // 
            // comboBox_type
            // 
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "Area connection",
            "No hatch",
            "Open hatch"});
            this.comboBox_type.Location = new System.Drawing.Point(44, 19);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(104, 21);
            this.comboBox_type.TabIndex = 0;
            this.comboBox_type.SelectedIndexChanged += new System.EventHandler(this.ValueChanged);
            // 
            // checkBox_event
            // 
            this.checkBox_event.AutoSize = true;
            this.checkBox_event.Location = new System.Drawing.Point(9, 46);
            this.checkBox_event.Name = "checkBox_event";
            this.checkBox_event.Size = new System.Drawing.Size(143, 17);
            this.checkBox_event.TabIndex = 1;
            this.checkBox_event.Text = "Loads event based room";
            this.checkBox_event.UseVisualStyleBackColor = true;
            this.checkBox_event.CheckedChanged += new System.EventHandler(this.ValueChanged);
            // 
            // checkBox_location
            // 
            this.checkBox_location.AutoSize = true;
            this.checkBox_location.Location = new System.Drawing.Point(9, 69);
            this.checkBox_location.Name = "checkBox_location";
            this.checkBox_location.Size = new System.Drawing.Size(134, 17);
            this.checkBox_location.TabIndex = 2;
            this.checkBox_location.Text = "Displays location name";
            this.checkBox_location.UseVisualStyleBackColor = true;
            this.checkBox_location.CheckedChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label_source
            // 
            this.label_source.AutoSize = true;
            this.label_source.Location = new System.Drawing.Point(6, 37);
            this.label_source.Name = "label_source";
            this.label_source.Size = new System.Drawing.Size(44, 13);
            this.label_source.TabIndex = 0;
            this.label_source.Text = "Current:";
            // 
            // label_destination
            // 
            this.label_destination.AutoSize = true;
            this.label_destination.Location = new System.Drawing.Point(6, 58);
            this.label_destination.Name = "label_destination";
            this.label_destination.Size = new System.Drawing.Size(63, 13);
            this.label_destination.TabIndex = 0;
            this.label_destination.Text = "Destination:";
            // 
            // label_dstDoor
            // 
            this.label_dstDoor.AutoSize = true;
            this.label_dstDoor.Location = new System.Drawing.Point(181, 58);
            this.label_dstDoor.Name = "label_dstDoor";
            this.label_dstDoor.Size = new System.Drawing.Size(13, 13);
            this.label_dstDoor.TabIndex = 0;
            this.label_dstDoor.Text = "0";
            // 
            // label_srcArea
            // 
            this.label_srcArea.AutoSize = true;
            this.label_srcArea.Location = new System.Drawing.Point(75, 37);
            this.label_srcArea.Name = "label_srcArea";
            this.label_srcArea.Size = new System.Drawing.Size(29, 13);
            this.label_srcArea.TabIndex = 0;
            this.label_srcArea.Text = "Area";
            // 
            // label_dstArea
            // 
            this.label_dstArea.AutoSize = true;
            this.label_dstArea.Location = new System.Drawing.Point(75, 58);
            this.label_dstArea.Name = "label_dstArea";
            this.label_dstArea.Size = new System.Drawing.Size(29, 13);
            this.label_dstArea.TabIndex = 0;
            this.label_dstArea.Text = "Area";
            // 
            // label_door
            // 
            this.label_door.AutoSize = true;
            this.label_door.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_door.Location = new System.Drawing.Point(181, 16);
            this.label_door.Name = "label_door";
            this.label_door.Size = new System.Drawing.Size(30, 13);
            this.label_door.TabIndex = 0;
            this.label_door.Text = "Door";
            // 
            // label_room
            // 
            this.label_room.AutoSize = true;
            this.label_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_room.Location = new System.Drawing.Point(140, 16);
            this.label_room.Name = "label_room";
            this.label_room.Size = new System.Drawing.Size(35, 13);
            this.label_room.TabIndex = 0;
            this.label_room.Text = "Room";
            // 
            // label_area
            // 
            this.label_area.AutoSize = true;
            this.label_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_area.Location = new System.Drawing.Point(75, 16);
            this.label_area.Name = "label_area";
            this.label_area.Size = new System.Drawing.Size(29, 13);
            this.label_area.TabIndex = 0;
            this.label_area.Text = "Area";
            // 
            // groupBox_info
            // 
            this.groupBox_info.Controls.Add(this.label_area);
            this.groupBox_info.Controls.Add(this.label_door);
            this.groupBox_info.Controls.Add(this.label_srcDoor);
            this.groupBox_info.Controls.Add(this.label_room);
            this.groupBox_info.Controls.Add(this.label_srcRoom);
            this.groupBox_info.Controls.Add(this.label_dstRoom);
            this.groupBox_info.Controls.Add(this.label_dstArea);
            this.groupBox_info.Controls.Add(this.label_source);
            this.groupBox_info.Controls.Add(this.label_srcArea);
            this.groupBox_info.Controls.Add(this.label_destination);
            this.groupBox_info.Controls.Add(this.label_dstDoor);
            this.groupBox_info.Location = new System.Drawing.Point(12, 164);
            this.groupBox_info.Name = "groupBox_info";
            this.groupBox_info.Size = new System.Drawing.Size(217, 80);
            this.groupBox_info.TabIndex = 0;
            this.groupBox_info.TabStop = false;
            this.groupBox_info.Text = "Info";
            // 
            // groupBox_edit
            // 
            this.groupBox_edit.Controls.Add(this.textBox_yExitDistance);
            this.groupBox_edit.Controls.Add(this.label_yExitDistance);
            this.groupBox_edit.Controls.Add(this.comboBox_type);
            this.groupBox_edit.Controls.Add(this.label_type);
            this.groupBox_edit.Controls.Add(this.checkBox_autoConnect);
            this.groupBox_edit.Controls.Add(this.checkBox_location);
            this.groupBox_edit.Controls.Add(this.textBox_height);
            this.groupBox_edit.Controls.Add(this.textBox_ownerRoom);
            this.groupBox_edit.Controls.Add(this.textBox_width);
            this.groupBox_edit.Controls.Add(this.label_height);
            this.groupBox_edit.Controls.Add(this.label_ownerRoom);
            this.groupBox_edit.Controls.Add(this.label_width);
            this.groupBox_edit.Controls.Add(this.checkBox_event);
            this.groupBox_edit.Controls.Add(this.textBox_xExitDistance);
            this.groupBox_edit.Controls.Add(this.label_connectedDoor);
            this.groupBox_edit.Controls.Add(this.textBox_connectedDoor);
            this.groupBox_edit.Controls.Add(this.label_xExitDistance);
            this.groupBox_edit.Location = new System.Drawing.Point(12, 12);
            this.groupBox_edit.Name = "groupBox_edit";
            this.groupBox_edit.Size = new System.Drawing.Size(298, 146);
            this.groupBox_edit.TabIndex = 0;
            this.groupBox_edit.TabStop = false;
            this.groupBox_edit.Text = "Edit";
            // 
            // textBox_yExitDistance
            // 
            this.textBox_yExitDistance.Location = new System.Drawing.Point(255, 97);
            this.textBox_yExitDistance.Name = "textBox_yExitDistance";
            this.textBox_yExitDistance.Size = new System.Drawing.Size(35, 20);
            this.textBox_yExitDistance.TabIndex = 15;
            this.textBox_yExitDistance.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label_yExitDistance
            // 
            this.label_yExitDistance.AutoSize = true;
            this.label_yExitDistance.Location = new System.Drawing.Point(163, 100);
            this.label_yExitDistance.Name = "label_yExitDistance";
            this.label_yExitDistance.Size = new System.Drawing.Size(79, 13);
            this.label_yExitDistance.TabIndex = 16;
            this.label_yExitDistance.Text = "Y exit distance:";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_changes});
            this.statusStrip.Location = new System.Drawing.Point(0, 247);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(322, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel_changes
            // 
            this.statusLabel_changes.Name = "statusLabel_changes";
            this.statusLabel_changes.Size = new System.Drawing.Size(12, 17);
            this.statusLabel_changes.Text = "-";
            // 
            // FormEditDoor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 269);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox_edit);
            this.Controls.Add(this.groupBox_info);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_apply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditDoor";
            this.Text = "Edit Door";
            this.groupBox_info.ResumeLayout(false);
            this.groupBox_info.PerformLayout();
            this.groupBox_edit.ResumeLayout(false);
            this.groupBox_edit.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox textBox_width;
        private System.Windows.Forms.TextBox textBox_height;
        private System.Windows.Forms.TextBox textBox_connectedDoor;
        private System.Windows.Forms.TextBox textBox_xExitDistance;
        private System.Windows.Forms.Label label_dstRoom;
        private System.Windows.Forms.Label label_srcRoom;
        private System.Windows.Forms.TextBox textBox_ownerRoom;
        private System.Windows.Forms.Label label_ownerRoom;
        private System.Windows.Forms.CheckBox checkBox_autoConnect;
        private System.Windows.Forms.ComboBox comboBox_type;
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
        private System.Windows.Forms.TextBox textBox_yExitDistance;
        private System.Windows.Forms.Label label_yExitDistance;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel_changes;
    }
}