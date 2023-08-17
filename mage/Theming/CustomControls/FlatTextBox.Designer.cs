using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mage.Theming.CustomControls
{
    partial class FlatTextBox : UserControl
    {
        private TextBox textBox;

        private void InitializeComponent()
        {
            textBox = new TextBox();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox.BorderStyle = BorderStyle.None;
            textBox.Location = new Point(3, 3);
            textBox.Name = "textBox";
            textBox.Size = new Size(96, 16);
            textBox.TabIndex = 0;
            // 
            // FlatTextBox
            // 
            Controls.Add(textBox);
            Name = "FlatTextBox";
            Padding = new Padding(3, 3, 1, 2);
            Size = new Size(100, 23);
            MouseDown += FlatTextBox_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
