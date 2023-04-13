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
            resources.ApplyResources(this.button_close, "button_close");
            this.button_close.Name = "button_close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_apply
            // 
            resources.ApplyResources(this.button_apply, "button_apply");
            this.button_apply.Name = "button_apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // label_srcDoor
            // 
            resources.ApplyResources(this.label_srcDoor, "label_srcDoor");
            this.label_srcDoor.Name = "label_srcDoor";
            // 
            // label_type
            // 
            resources.ApplyResources(this.label_type, "label_type");
            this.label_type.Name = "label_type";
            // 
            // label_width
            // 
            resources.ApplyResources(this.label_width, "label_width");
            this.label_width.Name = "label_width";
            // 
            // label_height
            // 
            resources.ApplyResources(this.label_height, "label_height");
            this.label_height.Name = "label_height";
            // 
            // label_connectedDoor
            // 
            resources.ApplyResources(this.label_connectedDoor, "label_connectedDoor");
            this.label_connectedDoor.Name = "label_connectedDoor";
            // 
            // label_xExitDistance
            // 
            resources.ApplyResources(this.label_xExitDistance, "label_xExitDistance");
            this.label_xExitDistance.Name = "label_xExitDistance";
            // 
            // textBox_width
            // 
            resources.ApplyResources(this.textBox_width, "textBox_width");
            this.textBox_width.Name = "textBox_width";
            this.textBox_width.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // textBox_height
            // 
            resources.ApplyResources(this.textBox_height, "textBox_height");
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // textBox_connectedDoor
            // 
            resources.ApplyResources(this.textBox_connectedDoor, "textBox_connectedDoor");
            this.textBox_connectedDoor.Name = "textBox_connectedDoor";
            this.textBox_connectedDoor.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // textBox_xExitDistance
            // 
            resources.ApplyResources(this.textBox_xExitDistance, "textBox_xExitDistance");
            this.textBox_xExitDistance.Name = "textBox_xExitDistance";
            this.textBox_xExitDistance.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label_dstRoom
            // 
            resources.ApplyResources(this.label_dstRoom, "label_dstRoom");
            this.label_dstRoom.Name = "label_dstRoom";
            // 
            // label_srcRoom
            // 
            resources.ApplyResources(this.label_srcRoom, "label_srcRoom");
            this.label_srcRoom.Name = "label_srcRoom";
            // 
            // textBox_ownerRoom
            // 
            resources.ApplyResources(this.textBox_ownerRoom, "textBox_ownerRoom");
            this.textBox_ownerRoom.Name = "textBox_ownerRoom";
            this.textBox_ownerRoom.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label_ownerRoom
            // 
            resources.ApplyResources(this.label_ownerRoom, "label_ownerRoom");
            this.label_ownerRoom.Name = "label_ownerRoom";
            // 
            // checkBox_autoConnect
            // 
            resources.ApplyResources(this.checkBox_autoConnect, "checkBox_autoConnect");
            this.checkBox_autoConnect.Name = "checkBox_autoConnect";
            // 
            // comboBox_type
            // 
            resources.ApplyResources(this.comboBox_type, "comboBox_type");
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            resources.GetString("comboBox_type.Items"),
            resources.GetString("comboBox_type.Items1"),
            resources.GetString("comboBox_type.Items2")});
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.SelectedIndexChanged += new System.EventHandler(this.ValueChanged);
            // 
            // checkBox_event
            // 
            resources.ApplyResources(this.checkBox_event, "checkBox_event");
            this.checkBox_event.Name = "checkBox_event";
            this.checkBox_event.UseVisualStyleBackColor = true;
            this.checkBox_event.CheckedChanged += new System.EventHandler(this.ValueChanged);
            // 
            // checkBox_location
            // 
            resources.ApplyResources(this.checkBox_location, "checkBox_location");
            this.checkBox_location.Name = "checkBox_location";
            this.checkBox_location.UseVisualStyleBackColor = true;
            this.checkBox_location.CheckedChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label_source
            // 
            resources.ApplyResources(this.label_source, "label_source");
            this.label_source.Name = "label_source";
            // 
            // label_destination
            // 
            resources.ApplyResources(this.label_destination, "label_destination");
            this.label_destination.Name = "label_destination";
            // 
            // label_dstDoor
            // 
            resources.ApplyResources(this.label_dstDoor, "label_dstDoor");
            this.label_dstDoor.Name = "label_dstDoor";
            // 
            // label_srcArea
            // 
            resources.ApplyResources(this.label_srcArea, "label_srcArea");
            this.label_srcArea.Name = "label_srcArea";
            // 
            // label_dstArea
            // 
            resources.ApplyResources(this.label_dstArea, "label_dstArea");
            this.label_dstArea.Name = "label_dstArea";
            // 
            // label_door
            // 
            resources.ApplyResources(this.label_door, "label_door");
            this.label_door.Name = "label_door";
            // 
            // label_room
            // 
            resources.ApplyResources(this.label_room, "label_room");
            this.label_room.Name = "label_room";
            // 
            // label_area
            // 
            resources.ApplyResources(this.label_area, "label_area");
            this.label_area.Name = "label_area";
            // 
            // groupBox_info
            // 
            resources.ApplyResources(this.groupBox_info, "groupBox_info");
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
            this.groupBox_info.Name = "groupBox_info";
            this.groupBox_info.TabStop = false;
            // 
            // groupBox_edit
            // 
            resources.ApplyResources(this.groupBox_edit, "groupBox_edit");
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
            this.groupBox_edit.Name = "groupBox_edit";
            this.groupBox_edit.TabStop = false;
            // 
            // textBox_yExitDistance
            // 
            resources.ApplyResources(this.textBox_yExitDistance, "textBox_yExitDistance");
            this.textBox_yExitDistance.Name = "textBox_yExitDistance";
            this.textBox_yExitDistance.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label_yExitDistance
            // 
            resources.ApplyResources(this.label_yExitDistance, "label_yExitDistance");
            this.label_yExitDistance.Name = "label_yExitDistance";
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
            // FormEditDoor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox_edit);
            this.Controls.Add(this.groupBox_info);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_apply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditDoor";
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