using mage.Theming.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mage.Theming
{
    public partial class ThemeEditor : Form
    {
        bool init = false;
        ColorTheme selectedTheme;

        public ThemeEditor()
        {
            InitializeComponent();
            ThemeSwitcher.ChangeTheme(this.Controls, this);
            ThemeSwitcher.InjectPaintOverrides(this.Controls);

            loadAllThemes();
        }

        private void loadAllThemes()
        {
            init = true;
            foreach (KeyValuePair<string, ColorTheme> pair in ThemeSwitcher.Themes)
            {
                comboBox_theme.Items.Add(pair.Key);
            }

            init = false;

            comboBox_theme.SelectedIndex = comboBox_theme.Items.IndexOf(ThemeSwitcher.ProjectThemeName);
        }

        private void comboBox_theme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (init) return;
            string key = comboBox_theme.Items[comboBox_theme.SelectedIndex].ToString();
            selectedTheme = ThemeSwitcher.ProjectTheme = ThemeSwitcher.Themes[key];
            ThemeSwitcher.ProjectThemeName = key;

            //Load name
            flatTextBox_name.Text = key;

            //Load color values
            flatTextBox_text.Text = ColorTranslator.ToHtml(selectedTheme.TextColor);
            flatTextBox_background.Text = ColorTranslator.ToHtml(selectedTheme.BackgroundColor);
            flatTextBox_primary.Text = ColorTranslator.ToHtml(selectedTheme.PrimaryOutline);
            flatTextBox_secondary.Text = ColorTranslator.ToHtml(selectedTheme.SecondaryOutline);
            flatTextBox_accent.Text = ColorTranslator.ToHtml(selectedTheme.AccentColor);
        }

        private void ColorValueChanged(object sender, EventArgs e)
        {
            FlatTextBox box = sender as FlatTextBox;
            Panel associate = this.Controls.Find(box.Tag.ToString(), true)[0] as Panel;
            if (box.Text.Length < 7) return;
            associate.BackColor = ColorTranslator.FromHtml(box.Text);
        }
    }
}
