using mage.Theming;
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

            ThemeSwitcher.ChangeTheme(Controls, this);
            ThemeSwitcher.InjectPaintOverrides(Controls);
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
