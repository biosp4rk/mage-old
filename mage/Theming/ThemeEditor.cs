using mage.Theming.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
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
            ThemeSwitcher.ProjectThemeName = key;
            selectedTheme = ThemeSwitcher.ProjectTheme;

            //Load name
            flatTextBox_name.Text = key;

            //Load color values
            flatTextBox_text.Text = ColorTranslator.ToHtml(selectedTheme.TextColor);
            flatTextBox_background.Text = ColorTranslator.ToHtml(selectedTheme.BackgroundColor);
            flatTextBox_primary.Text = ColorTranslator.ToHtml(selectedTheme.PrimaryOutline);
            flatTextBox_secondary.Text = ColorTranslator.ToHtml(selectedTheme.SecondaryOutline);
            flatTextBox_accent.Text = ColorTranslator.ToHtml(selectedTheme.AccentColor);

            button_apply.Enabled = false;

            //Prevent Mage Old from getting deleted
            if (key == "Mage Old")
            {
                btn_remove.Enabled = false;
                flatTextBox_name.Enabled = false;
                groupBox_colors.Enabled = false;
                return;
            }
            else
            {
                btn_remove.Enabled = true;
                flatTextBox_name.Enabled = true;
                groupBox_colors.Enabled = true;
            }
        }

        private void UpdateColorPreview()
        {
            foreach (Control c in panel_main.Controls)
            {
                if (!(c is Panel)) continue;
                Panel p = c as Panel;

                string key = p.Tag.ToString();
                p.BackColor = ThemeSwitcher.ProjectTheme.Colors[key];
            }
        }

        private void ColorValueChanged(object sender, EventArgs e)
        {
            FlatTextBox box = sender as FlatTextBox;
            Panel associate = this.Controls.Find(box.Tag.ToString(), true)[0] as Panel;

            //Do a Regex check if value is actually a hex number
            string text = box.Text;
            text = Regex.Match(text, @"[0-9a-fA-F]+").Value;
            if (text.Length != 6) return; //if 6 numbers are not given
            text = text.Insert(0, "#");

            associate.BackColor = ColorTranslator.FromHtml(text);
            button_apply.Enabled = true;
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            foreach(Control c in panel_main.Controls)
            {
                if (!(c is Panel)) continue;
                Panel p = c as Panel;

                string key = p.Tag.ToString();
                selectedTheme.Colors[key] = p.BackColor;
            }

            ThemeSwitcher.ProjectThemeName = comboBox_theme.Items[comboBox_theme.SelectedIndex].ToString();
            UpdateColorPreview();
            button_apply.Enabled = false;
        }
    }
}
