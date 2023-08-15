using mage.Theming;
using System;
using System.Windows.Forms;

namespace mage
{
    public partial class FormShortcuts : Form
    {
        // fields
        private bool isMF;
        private FormMain main;

        // constructor
        public FormShortcuts(FormMain main)
        {
            InitializeComponent();

            ThemeSwitcher.ChangeTheme(Controls, this);
            ThemeSwitcher.InjectPaintOverrides(Controls);

            ThemeSwitcher.ChangeTheme(this.Controls, this);
            ThemeSwitcher.InjectPaintOverrides(this.Controls);

            this.main = main;
            Initialize();
        }

        private void Initialize()
        {
            isMF = Version.IsMF;

            if (isMF)
            {
                groupBox_super.Enabled = false;
                button_lava_weak.Enabled = false;
                label_lava_weak.Enabled = false;
                button_lava_strong.Enabled = false;
                label_lava_strong.Enabled = false;
                button_acid.Enabled = false;
                label_acid.Enabled = false;
                button_crumble_slow.Enabled = false;
                label_crumble_slow.Enabled = false;
            }
        }

        private void button_air_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0;
        }

        private void button_solid_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0x10;
        }

        #region energy tanks
        private void button_energy_Click(object sender, EventArgs e)
        {
            if (isMF) { main.Clipdata = 0x63; }
            else { main.Clipdata = 0x5C; }
        }

        private void button_energy_hidden_Click(object sender, EventArgs e)
        {
            if (isMF) { main.Clipdata = 0x65; }
            else { main.Clipdata = 0x6C; }
        }

        private void button_energy_water_Click(object sender, EventArgs e)
        {
            if (isMF) { main.Clipdata = 0x67; }
            else { main.Clipdata = 0x7C; }
        }
        #endregion

        #region missiles
        private void button_missile_Click(object sender, EventArgs e)
        {
            if (isMF) { main.Clipdata = 0x62; }
            else { main.Clipdata = 0x5D; }
        }

        private void button_missile_hidden_Click(object sender, EventArgs e)
        {
            if (isMF) { main.Clipdata = 0x64; }
            else { main.Clipdata = 0x6D; }
        }

        private void button_missile_water_Click(object sender, EventArgs e)
        {
            if (isMF) { main.Clipdata = 0x66; }
            else { main.Clipdata = 0x7D; }
        }

        private void button_missile_block_no_Click(object sender, EventArgs e)
        {
            if (isMF) { main.Clipdata = 0x5E; }
            else { main.Clipdata = 0x68; }
        }

        private void button_missile_block_never_Click(object sender, EventArgs e)
        {
            if (isMF) { main.Clipdata = 0x54; }
            else { main.Clipdata = 0x58; }
        }
        #endregion

        #region super missiles
        private void button_super_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0x5E;
        }

        private void button_super_hidden_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0x6E;
        }

        private void button_super_water_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0x7E;
        }

        private void button_super_block_no_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0x69;
        }

        private void button_super_block_never_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0x59;
        }
        #endregion

        #region power bombs
        private void button_power_Click(object sender, EventArgs e)
        {
            if (isMF) { main.Clipdata = 0x68; }
            else { main.Clipdata = 0x5F; }
        }

        private void button_power_hidden_Click(object sender, EventArgs e)
        {
            if (isMF) { main.Clipdata = 0x69; }
            else { main.Clipdata = 0x6F; }
        }

        private void button_power_water_Click(object sender, EventArgs e)
        {
            if (isMF) { main.Clipdata = 0x6A; }
            else { main.Clipdata = 0x7F; }
        }

        private void button_power_block_never_Click(object sender, EventArgs e)
        {
            if (isMF) { main.Clipdata = 0x57; }
            else { main.Clipdata = 0x5B; }
        }
        #endregion

        #region liquids
        private void button_water_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0x1B;
        }

        private void button_lava_weak_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0xA0;
        }

        private void button_lava_strong_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0xA1;
        }

        private void button_acid_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0xA2;
        }
        #endregion

        #region transitions
        private void button_trans_door_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0x20;
        }

        private void button_trans_up_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0x27;
        }

        private void button_trans_down_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0x28;
        }
        #endregion

        #region slopes
        private void button_slope45_pos_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0x11;
        }

        private void button_slope45_neg_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0x12;
        }

        private void button_slope27_Lpos_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0x13;
        }

        private void button_slope27_Upos_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0x14;
        }

        private void button_slope27_Uneg_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0x15;
        }

        private void button_slope27_Lneg_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0x16;
        }
        #endregion

        #region ground
        private void button_dusty_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0x1D;
        }

        private void button_dusty_very_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0x2D;
        }

        private void button_wet_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0x1C;
        }

        private void button_bubbly_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0x2C;
        }
        #endregion

        #region breakable
        private void button_bomb_Click(object sender, EventArgs e)
        {
            if (isMF) { main.Clipdata = 0x56; }
            else { main.Clipdata = 0x67; }
        }

        private void button_bomb_never_Click(object sender, EventArgs e)
        {
            if (isMF) { main.Clipdata = 0x55; }
            else { main.Clipdata = 0x57; }
        }

        private void button_speed_Click(object sender, EventArgs e)
        {
            if (isMF) { main.Clipdata = 0x6B; }
            else { main.Clipdata = 0x6A; }
        }

        private void button_speed_no_Click(object sender, EventArgs e)
        {
            if (isMF) { main.Clipdata = 0x58; }
            else { main.Clipdata = 0x5A; }
        }

        private void button_screw_no_Click(object sender, EventArgs e)
        {
            if (isMF) { main.Clipdata = 0x59; }
            else { main.Clipdata = 0x6B; }
        }

        private void button_crumble_Click(object sender, EventArgs e)
        {
            if (isMF) { main.Clipdata = 0x5A; }
            else {main.Clipdata = 0x56; }
        }

        private void button_crumble_slow_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0x66;
        }
        #endregion

        #region shot
        private void button_shot_Click(object sender, EventArgs e)
        {
            if (isMF) { main.Clipdata = 0x53; }
            else { main.Clipdata = 0x62; }
        }

        private void button_shot_no_Click(object sender, EventArgs e)
        {
            if (isMF) { main.Clipdata = 0x5B; }
            else { main.Clipdata = 0x55; }
        }

        private void button_shot_never_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0x52;
        }

        private void button_shot_TL_no_Click(object sender, EventArgs e)
        {
            if (isMF) { main.Clipdata = 0x5C; }
            else { main.Clipdata = 0x53; }
        }

        private void button_shot_TR_no_Click(object sender, EventArgs e)
        {
            if (isMF) { main.Clipdata = 0x5D; }
            else { main.Clipdata = 0x54; }
        }

        private void button_shot_BL_no_Click(object sender, EventArgs e)
        {
            if (isMF) { main.Clipdata = 0x6C; }
            else { main.Clipdata = 0x63; }
        }

        private void button_shot_BR_no_Click(object sender, EventArgs e)
        {
            if (isMF) { main.Clipdata = 0x6D; }
            else { main.Clipdata = 0x64; }
        }

        private void button_shot_TL_never_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0x50;
        }

        private void button_shot_TR_never_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0x51;
        }

        private void button_shot_BL_never_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0x60;
        }

        private void button_shot_BR_never_Click(object sender, EventArgs e)
        {
            main.Clipdata = 0x61;
        }
        #endregion
        

    }
}
