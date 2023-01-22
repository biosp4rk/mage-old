using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace mage
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void linkLabel_forum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel_forum.Text);
        }

        private void linkLabel_silk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkLabel_silk.Text);
        }

    }
}
