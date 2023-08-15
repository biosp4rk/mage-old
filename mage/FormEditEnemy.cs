using mage.Theming;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace mage
{
    public partial class FormEditEnemy : Form
    {
        // fields 
        private EnemyList enemyList;
        private Spriteset spriteset;
        private VramObj vramObj;
        private int ssNum;
        private int enemyNum;

        private FormMain main;
        //private Room room;
        private Status status;
        private bool loading;

        // constructor
        public FormEditEnemy(FormMain main, int enemyNum)
        {
            InitializeComponent();

            ThemeSwitcher.ChangeTheme(Controls, this);
            ThemeSwitcher.InjectPaintOverrides(Controls);

            this.main = main;
            this.ssNum = main.EnemySet;
            this.enemyNum = enemyNum;

            Room room = main.Room;
            this.enemyList = room.enemyList;
            this.spriteset = room.spritesets[ssNum];
            this.vramObj = room.vramObj;
            
            Initialize();
        }

        private void Initialize()
        {
            status = new Status(statusLabel_changes, button_apply);
            status.LoadNew();

            Enemy enemy = enemyList[enemyNum];

            loading = true;
            comboBox_slot.SelectedIndex = enemy.SlotNum;
            comboBox_prop.SelectedIndex = enemy.prop >> 4;
            loading = false;
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            byte index = (byte)comboBox_slot.SelectedIndex;
            // get sprite ID
            byte spriteID;
            if (comboBox_prop.SelectedIndex == 0) { spriteID = index; }
            else { spriteID = spriteset.GetSpriteID(index); }
            label_IDval.Text = Hex.ToString(spriteID);

            // try drawing preview
            if (index < spriteset.spriteIDs.Count)
            {
                int gfxRow = spriteset.GetGfxRow(index);
                SpriteGFX sp = new SpriteGFX(vramObj, gfxRow, spriteID, true);
                Bitmap img = sp.previewImg;

                if (img != null)
                {
                    pictureBox_preview.Size = img.Size;
                    pictureBox_preview.Image = img;
                }
                else { pictureBox_preview.Image = null; }
            }  
            else { pictureBox_preview.Image = null; }

            if (!loading) { status.ChangeMade(); }
        }

        private void button_editSprite_Click(object sender, EventArgs e)
        {
            FormSprite form = new FormSprite(main, Hex.ToByte(label_IDval.Text));
            form.Show();
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            Enemy enemy = (Enemy)enemyList[enemyNum].Copy();
            enemy.prop = (byte)((comboBox_prop.SelectedIndex << 4) | (comboBox_slot.SelectedIndex + 1));

            EditRoomObject a = new EditRoomObject(enemy, enemyNum, false);
            main.PerformAction(a);

            status.Save();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
