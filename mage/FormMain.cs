using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using mage.Properties;

namespace mage
{
    public partial class FormMain : Form, Editor
    {
        
        #region properties

        public Room Room
        {
            get { return room; }
            set { room = value; }
        }
        public int EnemySet { get { return enemySet; } }
        public int SpritesetNum { get { return room.spritesets[enemySet].number; } }

        private bool EditBGs { get { return menuItem_editBGs.Checked; } }
        private bool EditBG0 { get { return checkBox_editBG0.Checked; } }
        private bool EditBG1 { get { return checkBox_editBG1.Checked; } }
        private bool EditBG2 { get { return checkBox_editBG2.Checked; } }
        private bool EditCLP { get { return checkBox_editCLP.Checked; } }
        private bool EditAnyBG
        {
            get
            {
                return (checkBox_editBG0.Checked || checkBox_editBG1.Checked
                    || checkBox_editBG2.Checked || checkBox_editCLP.Checked);
            }
        }
        
        public bool ViewSprites { get { return toolStrip_viewSprites.Checked; } }
        public bool OutlineSprites { get { return toolStrip_outlineSprites.Checked; } }
        public bool OutlineDoors { get { return toolStrip_outlineDoors.Checked; } }
        public bool OutlineScrolls { get { return toolStrip_outlineScrolls.Checked; } }
        public bool ViewCollision { get { return menuItem_viewClipCollision.Checked; } }
        public bool ViewBreakable { get { return menuItem_viewClipBreakable.Checked; } }
        public bool ViewValues { get { return menuItem_viewClipValues.Checked; } }
        public bool OutlineScreens { get { return menuItem_outlineScreens.Checked; } }
        public ushort Clipdata
        {
            get { return (ushort)comboBox_clipdata.SelectedIndex; }
            set { comboBox_clipdata.SelectedIndex = value; }
        }

        #endregion
        
        #region fields

        private PictureBox splash;

        // rom and file info
        private string filename;
        private string[] areaNames;
        private byte[] roomsPerArea;

        // related to current room
        private Room room;
        private bool skipEvents;
        private int enemySet;
        private UndoRedo undoRedo;
        private int zoom;
        private bool contextMenuOpen;

        #endregion

        public FormMain()
        {
            InitializeComponent();

            DisplayRecentFiles();
            InitializeSettings();
            ShowSplash();
        }


        #region opening/closing

        private void DisplayRecentFiles()
        {
            var recent = Settings.Default.recentFiles;
            if (recent == null)
            {
                recent = new System.Collections.Specialized.StringCollection();
                Settings.Default.recentFiles = recent;
            }
            if (recent.Count == 0)
            {
                menuItem_recentFiles.Enabled = false;
            }
            else
            {
                while (menuItem_recentFiles.DropDownItems.Count > 2)
                {
                    menuItem_recentFiles.DropDownItems.RemoveAt(2);
                }
                menuItem_recentFiles.Enabled = true;

                foreach (string file in recent)
                {
                    ToolStripMenuItem recentItem = new ToolStripMenuItem(file);
                    recentItem.Click += recentItem_Click;
                    menuItem_recentFiles.DropDownItems.Add(recentItem);
                }
            }
        }

        private void UpdateRecentFiles()
        {
            var recent = Settings.Default.recentFiles;
            int index = recent.IndexOf(filename);
            if (index != -1)
            {
                recent.RemoveAt(index);   
            }
            else
            {
                if (recent.Count >= 10)
                {
                    recent.RemoveAt(9);
                }
            }
            recent.Insert(0, filename);
            Settings.Default.Save();
            DisplayRecentFiles();
        }

        private void InitializeSettings()
        {
            menuItem_defaultBG0.Checked = Settings.Default.viewBG0;
            menuItem_defaultBG1.Checked = Settings.Default.viewBG1;
            menuItem_defaultBG2.Checked = Settings.Default.viewBG2;
            menuItem_defaultBG3.Checked = Settings.Default.viewBG3;
            menuItem_defaultClipCollision.Checked = Settings.Default.viewClipCollision;
            menuItem_defaultClipBreakable.Checked = Settings.Default.viewClipBreakable;
            menuItem_defaultClipValues.Checked = Settings.Default.viewClipValues;
            menuItem_defaultSprites.Checked = Settings.Default.viewSprites;
            menuItem_defaultSpriteOutlines.Checked = Settings.Default.viewSpriteOutlines;
            menuItem_defaultDoors.Checked = Settings.Default.viewDoors;
            menuItem_defaultScrolls.Checked = Settings.Default.viewScrolls;
            menuItem_defaultScreens.Checked = Settings.Default.viewScreenOutlines;
            menuItem_hexadecimal.Checked = Settings.Default.hexadecimal;
            menuItem_tooltips.Checked = Settings.Default.tooltips;

            zoom = Settings.Default.zoom;
            if (zoom == 0) { menuItem_zoom100.Checked = true; }
            else if (zoom == 1) { menuItem_zoom200.Checked = true; }
            else if (zoom == 2) { menuItem_zoom400.Checked = true; }
            else if (zoom == 3) { menuItem_zoom800.Checked = true; }
            roomView.UpdateZoom(zoom, false);
        }

        private void SaveSettings()
        {
            Settings.Default.viewBG0 = menuItem_defaultBG0.Checked;
            Settings.Default.viewBG1 = menuItem_defaultBG1.Checked;
            Settings.Default.viewBG2 = menuItem_defaultBG2.Checked;
            Settings.Default.viewBG3 = menuItem_defaultBG3.Checked;
            Settings.Default.viewClipCollision = menuItem_defaultClipCollision.Checked;
            Settings.Default.viewClipBreakable = menuItem_defaultClipBreakable.Checked;
            Settings.Default.viewClipValues = menuItem_defaultClipValues.Checked;
            Settings.Default.viewSprites = menuItem_defaultSprites.Checked;
            Settings.Default.viewSpriteOutlines = menuItem_defaultSpriteOutlines.Checked;
            Settings.Default.viewDoors = menuItem_defaultDoors.Checked;
            Settings.Default.viewScrolls = menuItem_defaultScrolls.Checked;
            Settings.Default.viewScreenOutlines = menuItem_defaultScreens.Checked;
            Settings.Default.hexadecimal = menuItem_hexadecimal.Checked;
            Settings.Default.tooltips = menuItem_tooltips.Checked;
            Settings.Default.zoom = zoom;
            Settings.Default.Save();
        }

        private void recentItem_Click(object sender, EventArgs e)
        {
            if (!CheckUnsaved()) { return; }

            // open ROM
            var recent = Properties.Settings.Default.recentFiles;
            var item = (ToolStripMenuItem)sender;
            OpenROM(item.Text);
        }

        private void ShowSplash()
        {
            splash = new PictureBox();
            //splash.BackColor = Color.Black;
            splash.Dock = DockStyle.Fill;
            //splash.BackgroundImage = new Bitmap(@"");
            splash.BackgroundImageLayout = ImageLayout.Center;
            Controls.Add(splash);
            splash.BringToFront();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CheckUnsaved()) { e.Cancel = true; }
            SaveSettings();
        }

        public bool FindOpenForm(Type t, bool close)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.GetType() == t)
                {
                    if (close) { frm.Close(); }
                    else { frm.Focus(); }
                    return true;
                }
            }
            return false;
        }

        #endregion
        

        #region menu strip

        // file
        private void menuItem_openROM_Click(object sender, EventArgs e)
        {
            OpenDialog();
        }

        private void menuItem_saveROM_Click(object sender, EventArgs e)
        {
            SaveROM();
        }

        private void menuItem_saveROMAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            //saveFile.Filter = "GBA ROM files (*.gba)|*.gba";
            saveFile.Filter = Resources.formMain_GBAFilterText;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                filename = saveFile.FileName;
                UpdateRecentFiles();
                SaveROM();
            }
        }

        private void menuItem_createBackup_Click(object sender, EventArgs e)
        {
            // add current room if not yet added
            room.SaveObjects();

            // get file name
            string directory = Path.GetDirectoryName(filename) + Path.DirectorySeparatorChar;
            string backup = directory + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".gba";

            // save backup
            byte[] copy = ROM.BackupData();
            ROM.SaveROM(backup, false);
            Version.SaveProject(backup);
            ROM.RestoreData(copy);
        }

        private void menuItem_clearRecentFiles_Click(object sender, EventArgs e)
        {
            Settings.Default.recentFiles.Clear();
            Settings.Default.Save();
            DisplayRecentFiles();
        }

        // edit
        private void menuItem_editMode_Click(object sender, EventArgs e)
        {
            ToggleEditMode();
        }

        private void menuItem_forceClipdata_Click(object sender, EventArgs e)
        {
            menuItem_forceClipdata.Checked = !menuItem_forceClipdata.Checked;
        }

        private void menuItem_undo_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void menuItem_redo_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void menuItem_editBG0_Click(object sender, EventArgs e)
        {
            checkBox_editBG0.Checked = !checkBox_editBG0.Checked;
        }

        private void menuItem_editBG1_Click(object sender, EventArgs e)
        {
            checkBox_editBG1.Checked = !checkBox_editBG1.Checked;
        }

        private void menuItem_editBG2_Click(object sender, EventArgs e)
        {
            checkBox_editBG2.Checked = !checkBox_editBG2.Checked;
        }

        private void menuItem_editCLP_Click(object sender, EventArgs e)
        {
            checkBox_editCLP.Checked = !checkBox_editCLP.Checked;
        }

        // view
        private void menuItem_viewBG0_Click(object sender, EventArgs e)
        {
            checkBox_viewBG0.Checked = !checkBox_viewBG0.Checked;
        }

        private void menuItem_viewBG1_Click(object sender, EventArgs e)
        {
            checkBox_viewBG1.Checked = !checkBox_viewBG1.Checked;
        }

        private void menuItem_viewBG2_Click(object sender, EventArgs e)
        {
            checkBox_viewBG2.Checked = !checkBox_viewBG2.Checked;
        }

        private void menuItem_viewBG3_Click(object sender, EventArgs e)
        {
            checkBox_viewBG3.Checked = !checkBox_viewBG3.Checked;
        }

        private void menuItem_viewClipToggle_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            if (!item.Checked)
            {
                var parent = (ToolStripMenuItem)item.OwnerItem;
                foreach (ToolStripMenuItem child in parent.DropDownItems)
                {
                    child.Checked = false;
                }
            }
            item.Checked = !item.Checked;
            roomView.RedrawAll();
        }

        private void menuItem_viewSprites_Click(object sender, EventArgs e)
        {
            menuItem_viewSprites.Checked = !menuItem_viewSprites.Checked;
            toolStrip_viewSprites.Checked = !toolStrip_viewSprites.Checked;
            roomView.RedrawAll();
        }

        private void menuItem_outlineSprites_Click(object sender, EventArgs e)
        {
            menuItem_outlineSprites.Checked = !menuItem_outlineSprites.Checked;
            toolStrip_outlineSprites.Checked = !toolStrip_outlineSprites.Checked;
            roomView.RedrawAll();
        }

        private void menuItem_outlineDoors_Click(object sender, EventArgs e)
        {
            menuItem_outlineDoors.Checked = !menuItem_outlineDoors.Checked;
            toolStrip_outlineDoors.Checked = !toolStrip_outlineDoors.Checked;
            roomView.RedrawAll();
        }

        private void menuItem_outlineScrolls_Click(object sender, EventArgs e)
        {
            menuItem_outlineScrolls.Checked = !menuItem_outlineScrolls.Checked;
            toolStrip_outlineScrolls.Checked = !toolStrip_outlineScrolls.Checked;
            roomView.RedrawAll();
        }

        private void menuItem_outlineScreens_Click(object sender, EventArgs e)
        {
            menuItem_outlineScreens.Checked = !menuItem_outlineScreens.Checked;
            roomView.RedrawAll();
        }

        private void menuItem_viewAnimPal_Click(object sender, EventArgs e)
        {
            menuItem_viewAnimPal.Checked = !menuItem_viewAnimPal.Checked;
            ROM.useAnimPalette = menuItem_viewAnimPal.Checked;
            ReloadRoom(false);
        }

        private void menuItem_motherShipHatches_Click(object sender, EventArgs e)
        {
            menuItem_motherShipHatches.Checked = !menuItem_motherShipHatches.Checked;
            ROM.useMotherShipHatches = menuItem_motherShipHatches.Checked;
            ReloadRoom(false);
        }

        private void menuItem_clipboard_Click(object sender, EventArgs e)
        {
            if (clipboard == null || !clipboard.Visible)
            {
                clipboard = new FormClipboard();
                clipboard.Show();
                UpdateClipboard();
            }
        }

        private void menuItem_zoom100_Click(object sender, EventArgs e)
        {
            UpdateZoom(0);
        }

        private void menuItem_zoom200_Click(object sender, EventArgs e)
        {
            UpdateZoom(1);
        }

        private void menuItem_zoom400_Click(object sender, EventArgs e)
        {
            UpdateZoom(2);
        }

        private void menuItem_zoom800_Click(object sender, EventArgs e)
        {
            UpdateZoom(3);
        }

        private void menuItem_zoomIn_Click(object sender, EventArgs e)
        {
            UpdateZoom(zoom + 1);
        }

        private void menuItem_zoomOut_Click(object sender, EventArgs e)
        {
            UpdateZoom(zoom - 1);
        }

        // editors
        private void menuItem_headerEditor_Click(object sender, EventArgs e)
        {
            if (!FindOpenForm(typeof(FormHeader), false))
            {
                FormHeader form = new FormHeader(this);
                form.Show();
            }
        }

        private void menuItem_tilesetEditor_Click(object sender, EventArgs e)
        {
            if (!FindOpenForm(typeof(FormTileset), false))
            {
                FormTileset form = new FormTileset(this, room.tileset.number);
                form.Show();
            }
        }

        private void menuItem_graphicsEditor_Click(object sender, EventArgs e)
        {
            if (!FindOpenForm(typeof(FormGraphics), false))
            {
                int gfxOffset = room.tileset.RLEgfx.Offset;
                int palOffset = room.tileset.palette.Offset + 0x20;
                FormGraphics form = new FormGraphics(this, gfxOffset, 32, 0, palOffset);
                form.Show();
            }
        }

        private void menuItem_paletteEditor_Click(object sender, EventArgs e)
        {
            if (!FindOpenForm(typeof(FormPalette), false))
            {
                FormPalette form = new FormPalette(this, true, room.tileset.number);
                form.Show();
            }
        }

        private void menuItem_tileTableEditor_Click(object sender, EventArgs e)
        {
            if (!FindOpenForm(typeof(FormTileTable), false))
            {
                FormTileTable form = new FormTileTable(this, room.tileset.number);
                form.Show();
            }
        }

        private void menuItem_animationEditor_Click(object sender, EventArgs e)
        {
            if (!FindOpenForm(typeof(FormAnimation), false))
            {
                FormAnimation form = new FormAnimation(this, 0, room.tileset.animTileset.number);
                form.Show();
            }
        }

        private void menuItem_spriteEditor_Click(object sender, EventArgs e)
        {
            if (!FindOpenForm(typeof(FormSprite), false))
            {
                FormSprite form = new FormSprite(this, 0x12);
                form.Show();
            }
        }

        private void menuItem_spritesetEditor_Click(object sender, EventArgs e)
        {
            if (!FindOpenForm(typeof(FormSpriteset), false))
            {
                byte spritesetNum = room.spritesets[enemySet].number;
                FormSpriteset form = new FormSpriteset(this, spritesetNum);
                form.Show();
            }
        }

        private void menuItem_connectionEditor_Click(object sender, EventArgs e)
        {
            if (!FindOpenForm(typeof(FormConnection), false))
            {
                FormConnection form = new FormConnection(this, 0);
                form.Show();
            }
        }

        private void menuItem_minimapEditor_Click(object sender, EventArgs e)
        {
            if (!FindOpenForm(typeof(FormMinimap), false))
            {
                FormMinimap form = new FormMinimap(this);
                form.Show();
            }
        }

        private void menuItem_textEditor_Click(object sender, EventArgs e)
        {
            if (!FindOpenForm(typeof(FormText), false))
            {
                FormText form = new FormText(this);
                form.Show();
            }
        }

        private void menuItem_demoEditor_Click(object sender, EventArgs e)
        {
            if (!FindOpenForm(typeof(FormDemo), false))
            {
                FormDemo form = new FormDemo();
                form.Show();
            }
        }

        private void menuItem_physicsEditor_Click(object sender, EventArgs e)
        {
            if (!FindOpenForm(typeof(FormPhysics), false))
            {
                FormPhysics form = new FormPhysics();
                form.Show();
            }
        }

        private void menuItem_weaponEditor_Click(object sender, EventArgs e)
        {
            if (!FindOpenForm(typeof(FormWeapon), false))
            {
                FormWeapon form = new FormWeapon(this);
                form.Show();
            }
        }

        // tools
        private void menuItem_roomOptions_Click(object sender, EventArgs e)
        {
            FormRoomOptions form = new FormRoomOptions(this);
            form.ShowDialog();
        }

        private void menuItem_testRoom_Click(object sender, EventArgs e)
        {
            FormTestRoom form = new FormTestRoom(this);
            form.ShowDialog();
        }

        private void menuItem_clipShortcuts_Click(object sender, EventArgs e)
        {
            if (!FindOpenForm(typeof(FormShortcuts), false))
            {
                FormShortcuts form = new FormShortcuts(this);
                form.Show();
            }
        }

        private void menuItem_importTileset_Click(object sender, EventArgs e)
        {
            OpenFileDialog tilesetFile = new OpenFileDialog();
            //tilesetFile.Filter = "MAGE tileset (*.mgt)|*.mgt|All files (*.*)|*.*";
            tilesetFile.Filter = Resources.form_TilesetFilterText;
            if (tilesetFile.ShowDialog() == DialogResult.OK)
            {
                FormImportTileset form = new FormImportTileset(this, tilesetFile.FileName);
                if (!form.IsDisposed)
                {
                    form.ShowDialog();
                }
            }
        }

        private void menuItem_importRLE_Click(object sender, EventArgs e)
        {
            FormPortBG form = new FormPortBG(this, 0);
            if (!form.IsDisposed) { form.ShowDialog(); }
        }

        private void menuItem_importLZ77_Click(object sender, EventArgs e)
        {
            FormPortBG form = new FormPortBG(this, 1);
            if (!form.IsDisposed) { form.ShowDialog(); }
        }

        private void menuItem_importRoom_Click(object sender, EventArgs e)
        {
            OpenFileDialog roomFile = new OpenFileDialog();
            //roomFile.Filter = "MAGE room (*.mgr)|*.mgr|All files (*.*)|*.*";
            roomFile.Filter = Resources.formMain_RoomFilterText;
            if (roomFile.ShowDialog() == DialogResult.OK)
            {
                FormImportRoom form = new FormImportRoom(this, roomFile.FileName);
                if (!form.IsDisposed)
                {
                    form.ShowDialog();
                }
            }
        }

        private void menuItem_importTilesetImage_Click(object sender, EventArgs e)
        {
            FormImportRLEBG form = new FormImportRLEBG(this);
            form.ShowDialog();
        }

        private void menuItem_importLZ77BGimage_Click(object sender, EventArgs e)
        {
            FormImportLZ77BG form = new FormImportLZ77BG(this);
            form.ShowDialog();
        }

        private void menuItem_importEnding_Click(object sender, EventArgs e)
        {
            if (!FindOpenForm(typeof(FormImportEnding), false))
            {
                FormImportEnding form = new FormImportEnding();
                form.Show();
            }
        }

        private void menuItem_exportTileset_Click(object sender, EventArgs e)
        {
            FormExportTileset form = new FormExportTileset(this);
            form.ShowDialog();
        }

        private void menuItem_exportBG_Click(object sender, EventArgs e)
        {
            FormPortBG form = new FormPortBG(this, 2);
            form.ShowDialog();
        }

        private void menuItem_exportRoom_Click(object sender, EventArgs e)
        {
            SaveFileDialog roomFile = new SaveFileDialog();
            //roomFile.Filter = "MAGE room (*.mgr)|*.mgr";
            roomFile.Filter = Resources.formMain_RoomFilterText;
            if (roomFile.ShowDialog() == DialogResult.OK)
            {
                room.Export(roomFile.FileName);
            }
        }

        private void menuItem_exportTilesetImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveTileset = new SaveFileDialog();
            //saveTileset.Filter = "PNG files (*.png)|*.png";
            saveTileset.Filter = Resources.form_PNGFilterText;
            if (saveTileset.ShowDialog() == DialogResult.OK)
            {
                room.vram.Image.Save(saveTileset.FileName);
            }
        }

        private void menuItem_exportBG0image_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveBG0 = new SaveFileDialog();
            //saveBG0.Filter = "PNG files (*.png)|*.png";
            saveBG0.Filter = Resources.form_PNGFilterText;
            if (saveBG0.ShowDialog() == DialogResult.OK)
            {
                room.backgrounds.BG0img.Save(saveBG0.FileName);
            }
        }

        private void menuItem_exportBG3image_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveBG3 = new SaveFileDialog();
            //saveBG3.Filter = "PNG files (*.png)|*.png";
            saveBG3.Filter = Resources.form_PNGFilterText;
            if (saveBG3.ShowDialog() == DialogResult.OK)
            {
                room.backgrounds.BG3img.Save(saveBG3.FileName);
            }
        }

        private void menuItem_exportRoomImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveRoom = new SaveFileDialog();
            //saveRoom.Filter = "PNG files (*.png)|*.png";
            saveRoom.Filter = Resources.form_PNGFilterText;
            if (saveRoom.ShowDialog() == DialogResult.OK)
            {
                roomView.BackgroundImage.Save(saveRoom.FileName);
            }
        }

        private void menuItem_LZ77comp_Click(object sender, EventArgs e)
        {
            CompressFile(true);
        }

        private void menuItem_LZ77decomp_Click(object sender, EventArgs e)
        {
            CompressFile(false);
        }

        private void menuItem_tileBuilder_Click(object sender, EventArgs e)
        {
            if (!FindOpenForm(typeof(FormTileBuilder), false))
            {
                FormTileBuilder form = new FormTileBuilder(this);
                form.Show();
            }
        }

        private void menuItem_addItem_Click(object sender, EventArgs e)
        {
            FindOpenForm(typeof(FormAdd), true);

            int index = menuItem_add.DropDownItems.IndexOf((ToolStripItem)sender);
            FormAdd form = new FormAdd(this, index);
            form.Show();
        }

        private void menuItem_patches_Click(object sender, EventArgs e)
        {
            if (!FindOpenForm(typeof(FormPatches), false))
            {
                FormPatches form = new FormPatches();
                form.Show();
            }
        }

        // options
        private void menuItem_defaultView_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            item.Checked = !item.Checked;
        }

        private void menuItem_defaultClipToggle_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            if (!item.Checked)
            {
                var parent = (ToolStripMenuItem)item.OwnerItem;
                foreach (ToolStripMenuItem child in parent.DropDownItems)
                {
                    child.Checked = false;
                }
            }
            item.Checked = !item.Checked;
        }

        private void menuItem_hexadecimal_Click(object sender, EventArgs e)
        {
            menuItem_hexadecimal.Checked = true;
            menuItem_decimal.Checked = false;
            Hex.ToHex = true;
            UpdateRoomNumbers();
        }

        private void menuItem_decimal_Click(object sender, EventArgs e)
        {
            menuItem_hexadecimal.Checked = false;
            menuItem_decimal.Checked = true;
            Hex.ToHex = false;
            UpdateRoomNumbers();
        }

        private void menuItem_tooltips_Click(object sender, EventArgs e)
        {
            menuItem_tooltips.Checked = !menuItem_tooltips.Checked;

            if (menuItem_tooltips.Checked)
            {
                roomTimer.Tick -= roomTimer_Tick;
                tileTimer.Tick -= tileTimer_Tick;
            }
            else
            {
                roomTimer.Tick += roomTimer_Tick;
                tileTimer.Tick += tileTimer_Tick;
            }
        }

        // help
        private void menuItem_viewHelp_Click(object sender, EventArgs e)
        {
            string path = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            path = Path.Combine(path, Resources.formMain_DocFileText);
            if (File.Exists(path))
            {
                System.Diagnostics.Process.Start(path);
            }
            else
            {
                //MessageBox.Show("Documentation file could not be found.",
                    //"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(Resources.formMain_DocNotExistText,
                    Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuItem_about_Click(object sender, EventArgs e)
        {
            if (!FindOpenForm(typeof(FormAbout), false))
            {
                FormAbout form = new FormAbout();
                form.Show();
            }
        }

        // methods
        private void CompressFile(bool compress)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            //openFile.Filter = "All files (*.*)|*.*";
            openFile.Filter = Resources.form_AllFilterText;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] inputData = File.ReadAllBytes(openFile.FileName);

                    SaveFileDialog saveFile = new SaveFileDialog();
                    //saveFile.Filter = "All files (*.*)|*.*";
                    saveFile.Filter = Resources.form_AllFilterText;
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        ByteStream inputStream = new ByteStream(inputData);
                        ByteStream outputStream = new ByteStream();

                        if (compress)
                        {
                            Compress.CompLZ77(inputStream, inputData.Length, outputStream);
                        }
                        else
                        {
                            Compress.DecompLZ77(inputStream, outputStream);
                        }

                        outputStream.Export(saveFile.FileName);
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Operation could not be completed.\n\n" + ex.Message,
                    //"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(Resources.formMain_OperationFailText + ex.Message,
                        Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion


        #region tool strip

        private void toolStrip_undo_DropDownOpening(object sender, EventArgs e)
        {
            PopulateUndoRedoList(toolStrip_undo, undoRedo.UndoStack);
        }

        private void toolStrip_redo_DropDownOpening(object sender, EventArgs e)
        {
            PopulateUndoRedoList(toolStrip_redo, undoRedo.RedoStack);
        }

        private void toolStrip_undo_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            int num = (int)e.ClickedItem.Tag;
            for (int i = 0; i < num; i++)
            {
                Undo();
            }
        }

        private void toolStrip_redo_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            int num = (int)e.ClickedItem.Tag;
            for (int i = 0; i < num; i++)
            {
                Redo();
            }
        }

        private void toolStrip_add_Click(object sender, EventArgs e)
        {
            FindOpenForm(typeof(FormAdd), true);
            FormAdd form = new FormAdd(this, 0);
            form.Show();
        }

        #endregion


        #region ROM handling

        private void OpenDialog()
        {
            if (!CheckUnsaved()) { return; }

            OpenFileDialog openFile = new OpenFileDialog();
            //openFile.Filter = "GBA ROM files (*.gba)|*.gba";
            openFile.Filter = Resources.formMain_GBAFilterText;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                OpenROM(openFile.FileName);
            }
        }

        public void OpenROM(string path)
        {
            try
            {
                byte[] file = File.ReadAllBytes(path);

                string result;
                if (!ROM.CheckROM(file, out result))
                {
                    //MessageBox.Show(result, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(result, Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                filename = path;
                ROM.Initialize(file);
                Version.LoadProject(filename);
            }
            catch (Exception e)
            {
                //MessageBox.Show("Error loading file.\n\n" + e.GetType().ToString() + '\n'
                    //+ e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(Resources.formMain_LoadFailText + e.GetType().ToString() + '\n'
                    + e.Message, Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InitializePart1();
        }

        private void SaveROM()
        {
            // save edited room objects
            room.SaveObjects();

            // save all edited lists and compress backgrounds
            ROM.SaveROM(filename, true);
            bool newProject = Version.SaveProject(filename);
            if (newProject)
            {
                //string message = "Project saved to " + Path.ChangeExtension(filename, ".proj");
                //message += "\n\nDo not modify or erase this file. It is necessary for tracking added data.";
                //MessageBox.Show(message, "New Project", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string message = Resources.formMain_ProjSaveText + Path.ChangeExtension(filename, ".proj");
                message += Resources.formMain_ProjSaveText1;
                MessageBox.Show(message, Resources.formMain_ProjSaveTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // rewrite file name
            this.Text = Path.GetFileName(filename) + " - MAGE";
        }

        private bool CheckUnsaved()
        {
            if (ROM.Stream != null && room != null)
            {
                if (room.IsEdited() || ROM.IsEdited())
                {
                    //var result = MessageBox.Show("Do you want to save changes to the ROM?",
                        //"Unsaved Changes", MessageBoxButtons.YesNoCancel);
                    var result = MessageBox.Show(Resources.formMain_UnsaveChangeText,
                        Resources.formMain_UnsaveChangeTitle, MessageBoxButtons.YesNoCancel);
                    if (result == System.Windows.Forms.DialogResult.Cancel) { return false; }
                    if (result == System.Windows.Forms.DialogResult.Yes) { SaveROM(); }
                }
            }
            return true;
        }

        private void InitializePart1()
        {
            // disable controls
            EnableControls(false);

            // close open forms
            FormCollection fc = Application.OpenForms;
            for (int i = fc.Count - 1; i >= 0; i--)
            {
                if (fc[i].GetType() != typeof(FormMain))
                {
                    fc[i].Close();
                }
            }

            // initialize edited lists
            room = null;
            ROM.ResetEditedLists();

            // viewing options
            menuItem_viewAnimPal.Checked = ROM.useAnimPalette = true;
            menuItem_motherShipHatches.Checked = ROM.useMotherShipHatches = false;
            menuItem_motherShipHatches.Visible = menuItem_motherShipHatches.Enabled = !Version.IsMF;

            // get area names and rooms per area
            areaNames = Version.AreaNames;
            roomsPerArea = Version.RoomsPerArea;
            comboBox_area.Items.Clear();
            comboBox_area.Items.AddRange(areaNames);

            // show file name
            this.Text = Path.GetFileName(filename) + " - MAGE";

            // update recent files
            UpdateRecentFiles();

            // load first room by default
            if (comboBox_area.SelectedIndex != 0)
            {
                comboBox_area.SelectedIndex = 0;
            }
            else { LoadRoom(0, 0, true); }

            // remove splash
            Controls.Remove(splash);
            splash.Dispose();
            groupBox_location.Enabled = true;
        }

        private void InitializePart2()
        {
            // room view
            roomView.Main = this;
            roomTimer = new Timer();
            roomTimer.Interval = 700;
            roomTip = new ToolTip();

            // tile view
            tileTimer = new Timer();
            tileTimer.Interval = 700;
            tileTip = new ToolTip();

            if (!menuItem_tooltips.Checked)
            {
                roomTimer.Tick += roomTimer_Tick;
                tileTimer.Tick += tileTimer_Tick;
            }

            // load clipdata list
            string[] clipdata = Version.Clipdata;
            char[] sep = new char[] { ' ' };
            comboBox_clipdata.Items.Clear();
            for (int i = 0; i < clipdata.Length; i++)
            {
                string line = Hex.ToString(i) + " - ";
                string[] sides = clipdata[i].Split(sep, 2);
                if (sides.Length > 1) { line += sides[1]; }
                comboBox_clipdata.Items.Add(line);
            }
            comboBox_clipdata.SelectedIndex = 0;

            // enable controls
            EnableControls(true);
            menuItem_editBGs.Checked = toolStrip_editBGs.Checked = true;
            menuItem_editObjects.Checked = toolStrip_editObjects.Checked = false;
        }

        private void EnableControls(bool val)
        {
            menuItem_saveROM.Enabled = val;
            menuItem_saveROMas.Enabled = val;
            menuItem_createBackup.Enabled = val;
            menuStrip_edit.Enabled = val;
            menuStrip_view.Enabled = val;
            menuStrip_options.Enabled = val;
            menuStrip_editors.Enabled = val;
            menuStrip_tools.Enabled = val;

            foreach (ToolStripItem item in toolStrip.Items)
            {
                if (item is ToolStripButton)
                {
                    item.Enabled = true;
                }
            }
            toolStrip_open.Enabled = true;

            label_spriteset.Enabled = val;
            comboBox_spriteset.Enabled = val;
            groupBox_viewBG.Enabled = val;
            groupBox_editBG.Enabled = val;
            groupBox_tileset.Enabled = val;
            groupBox_room.Enabled = val;
            statusStrip.Enabled = val;
        }

        private void FormMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void FormMain_DragDrop(object sender, DragEventArgs e)
        {
            if (!CheckUnsaved()) { return; }
            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop);
            OpenROM(paths[0]);
        }

        #endregion


        #region loading room methods

        public void ReloadRoom(bool reset)
        {
            LoadRoom(room.AreaID, room.RoomID, reset);
        }

        public void LoadAddedRoom(int a)
        {
            int r = Version.RoomsPerArea[a] - 1;
            if (comboBox_area.SelectedIndex == a)
            {
                string s = Hex.ToString(r);
                comboBox_room.Items.Add(s);
            }

            JumpToRoom(a, r);
        }

        public void JumpToRoom(int a, int r)
        {
            skipEvents = true;
            comboBox_area.SelectedIndex = a;
            comboBox_room.SelectedIndex = r;
            LoadRoom(a, r, true);
        }

        public void LoadRoom(int a, int r, bool reset)
        {
            skipEvents = true;

            try
            {
                if (room != null) { room.SaveObjects(); }
                room = new Room(a, r);
            }
            catch (CorruptDataException ex)
            {
                string fix;
                switch (ex.DataType)
                {
                    case Corrupt.BG0:
                    case Corrupt.BG1:
                    case Corrupt.BG2:
                        //fix = "Would you like to try disabling this background?";
                        fix = Resources.formMain_LoadRoomFixBG;
                        break;
                    default:
                        //fix = "Would you like to try replacing it with blank data?";
                        fix = Resources.formMain_LoadRoomFixDefault;
                        break;
                }
                //var result = MessageBox.Show("Room could not be loaded. " + ex.Message
                    //+ "\n\n" + fix, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                var result = MessageBox.Show(Resources.formMain_LoadRoomFailText + ex.Message
                    + "\n\n" + fix, Resources.form_ErrorMessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    ex.TryHandle(a, r);
                    LoadRoom(a, r, true);
                }

                skipEvents = false;
                return;
            }

            if (!groupBox_room.Enabled) { InitializePart2(); }

            if (reset)
            {
                SetViewOptions();
                ResetValues();
            }
            else
            {
                UpdateViewOptions();

                tileView.BackgroundImage = room.vram.Image;
                roomView.Room = room;
                UpdateBGs();
            }

            skipEvents = false;
        }

        private void ResetValues()
        {
            // tile and map view
            pivot = new Point(-1, -1);
            selection = new Rectangle(-1, -1, 1, 1);

            tileCursor = new Point(-1, -1);
            tileView.Reset();
            tileView.BackgroundImage = room.vram.Image;

            roomCursor = new Point(-1, -1);
            roomView.Reset();
            roomView.Room = room;

            ResetTileTip(false);
            ResetRoomTip(false);

            selEnemy = -1;
            selDoor = -1;
            selScroll = -1;

            if (clipboard != null) { clipboard.Clear(); }
            UpdateBGs();

            undoRedo = room.undoRedo;
            UpdateUndoRedo();

            enemySet = 0;

            statusLabel_coor.Text = "(0, 0)";
            statusLabel_sel.Text = "0 x 0";
            statusLabel_clip.Text = "";
        }

        private void SetViewOptions()
        {
            bool[] exists = room.backgrounds.GetExists();

            // BG viewing
            menuItem_viewBG0.Enabled = checkBox_viewBG0.Enabled = exists[0];
            menuItem_editBG0.Enabled = checkBox_editBG0.Enabled = room.BG0.IsRLE;
            menuItem_viewBG1.Enabled = menuItem_editBG1.Enabled = 
                checkBox_viewBG1.Enabled = checkBox_editBG1.Enabled = exists[1];
            menuItem_viewBG2.Enabled = menuItem_editBG2.Enabled = 
                checkBox_viewBG2.Enabled = checkBox_editBG2.Enabled = exists[2];
            menuItem_viewBG3.Enabled = checkBox_viewBG3.Enabled = exists[3];

            menuItem_viewBG0.Checked = checkBox_viewBG0.Checked = exists[0] && menuItem_defaultBG0.Checked;
            menuItem_viewBG1.Checked = checkBox_viewBG1.Checked = exists[1] && menuItem_defaultBG1.Checked;
            menuItem_viewBG2.Checked = checkBox_viewBG2.Checked = exists[2] && menuItem_defaultBG2.Checked;
            menuItem_viewBG3.Checked = checkBox_viewBG3.Checked = exists[3] && menuItem_defaultBG3.Checked;
            menuItem_viewClipCollision.Checked = menuItem_defaultClipCollision.Checked;
            menuItem_viewClipBreakable.Checked = menuItem_defaultClipBreakable.Checked;
            menuItem_viewClipValues.Checked = menuItem_defaultClipValues.Checked;

            menuItem_exportBG0image.Enabled = room.BG0.IsLZ77;

            // BG editing
            menuItem_editBG0.Checked = checkBox_editBG0.Checked = false;
            menuItem_editBG1.Checked = checkBox_editBG1.Checked = false;
            menuItem_editBG2.Checked = checkBox_editBG2.Checked = false;
            menuItem_editCLP.Checked = checkBox_editCLP.Checked = false;

            // sprites
            menuItem_outlineSprites.Enabled = menuItem_viewSprites.Enabled =
                toolStrip_outlineSprites.Enabled = toolStrip_viewSprites.Enabled = room.enemyList.Count > 0;
            menuItem_viewSprites.Checked = toolStrip_viewSprites.Checked = toolStrip_viewSprites.Enabled && menuItem_defaultSprites.Checked;
            menuItem_outlineSprites.Checked = toolStrip_outlineSprites.Checked = toolStrip_outlineSprites.Enabled && menuItem_defaultSpriteOutlines.Checked;

            // doors
            menuItem_outlineDoors.Enabled = toolStrip_outlineDoors.Enabled = room.doorList.Count > 0;
            menuItem_outlineDoors.Checked = toolStrip_outlineDoors.Checked = toolStrip_outlineDoors.Enabled && menuItem_defaultDoors.Checked;

            // scrolls
            menuItem_outlineScrolls.Enabled = toolStrip_outlineScrolls.Enabled = room.scrollList.Count > 0;
            menuItem_outlineScrolls.Checked = toolStrip_outlineScrolls.Checked = toolStrip_outlineScrolls.Enabled && menuItem_defaultScrolls.Checked;

            // screens
            menuItem_outlineScreens.Checked = menuItem_defaultScreens.Checked;

            // enemy sets
            SetSpritesetOptions();
        }

        private void UpdateViewOptions()
        {
            bool[] exists = room.backgrounds.GetExists();

            // BG viewing
            menuItem_viewBG0.Enabled = checkBox_viewBG0.Enabled = exists[0];
            menuItem_editBG0.Enabled = checkBox_editBG0.Enabled = room.BG0.IsRLE;
            menuItem_viewBG1.Enabled = menuItem_editBG1.Enabled =
                checkBox_viewBG1.Enabled = checkBox_editBG1.Enabled = exists[1];
            menuItem_viewBG2.Enabled = menuItem_editBG2.Enabled =
                checkBox_viewBG2.Enabled = checkBox_editBG2.Enabled = exists[2];
            menuItem_viewBG3.Enabled = checkBox_viewBG3.Enabled = exists[3];

            menuItem_viewBG0.Checked = checkBox_viewBG0.Checked &= exists[0];
            menuItem_viewBG1.Checked = checkBox_viewBG1.Checked &= exists[1];
            menuItem_viewBG2.Checked = checkBox_viewBG2.Checked &= exists[2];
            menuItem_viewBG3.Checked = checkBox_viewBG3.Checked &= exists[3];

            menuItem_exportBG0image.Enabled = room.BG0.IsLZ77;

            // sprites
            menuItem_outlineSprites.Enabled = menuItem_viewSprites.Enabled =
                toolStrip_outlineSprites.Enabled = toolStrip_viewSprites.Enabled = room.enemyList.Count > 0;
            menuItem_viewSprites.Checked = toolStrip_viewSprites.Checked &= toolStrip_viewSprites.Enabled;
            menuItem_outlineSprites.Checked = toolStrip_outlineSprites.Checked &= toolStrip_outlineSprites.Enabled;

            // doors
            menuItem_outlineDoors.Enabled = toolStrip_outlineDoors.Enabled = room.doorList.Count > 0;
            menuItem_outlineDoors.Checked = toolStrip_outlineDoors.Checked &= toolStrip_outlineDoors.Enabled;

            // scrolls
            menuItem_outlineScrolls.Enabled = toolStrip_outlineScrolls.Enabled = room.scrollList.Count > 0;
            menuItem_outlineScrolls.Checked = toolStrip_outlineScrolls.Checked &= toolStrip_outlineScrolls.Enabled;

            // enemy sets
            int index = comboBox_spriteset.SelectedIndex;
            comboBox_spriteset.Items.Clear();
            //comboBox_spriteset.Items.Add("Default");
            //if (room.header.spriteset1event > 0) { comboBox_spriteset.Items.Add("First"); }
            //if (room.header.spriteset2event > 0) { comboBox_spriteset.Items.Add("Second"); }
            comboBox_spriteset.Items.Add(Resources.formMain_SpritesetItem);
            if (room.header.spriteset1event > 0) { comboBox_spriteset.Items.Add(Resources.formMain_SpritesetItem1); }
            if (room.header.spriteset2event > 0) { comboBox_spriteset.Items.Add(Resources.formMain_SpritesetItem2); }

            if (index < comboBox_spriteset.Items.Count)
            {
                comboBox_spriteset.SelectedIndex = index;
                enemySet = index;
            }
            else
            {
                comboBox_spriteset.SelectedIndex = 0;
                enemySet = 0;
            }
        }

        public void SetSpritesetOptions()
        {
            comboBox_spriteset.Items.Clear();
            //comboBox_spriteset.Items.Add("Default");
            //if (room.header.spriteset1event > 0) { comboBox_spriteset.Items.Add("First"); }
            //if (room.header.spriteset2event > 0) { comboBox_spriteset.Items.Add("Second"); }
            comboBox_spriteset.Items.Add(Resources.formMain_SpritesetItem);
            if (room.header.spriteset1event > 0) { comboBox_spriteset.Items.Add(Resources.formMain_SpritesetItem1); }
            if (room.header.spriteset2event > 0) { comboBox_spriteset.Items.Add(Resources.formMain_SpritesetItem2); }
            comboBox_spriteset.SelectedIndex = 0;
        }

        private void comboBox_area_SelectedIndexChanged(object sender, EventArgs e)
        {
            // update number of rooms in area
            int area = comboBox_area.SelectedIndex;
            if (room != null && area == room.AreaID) { return; }

            int numOfRooms = roomsPerArea[area];
            int currNum = comboBox_room.Items.Count;
            if (numOfRooms > currNum)
            {
                for (int i = currNum; i < numOfRooms; i++)
                {
                    comboBox_room.Items.Add(Hex.ToString(i));
                }
            }
            else if (numOfRooms < currNum)
            {
                for (int i = currNum - 1; i >= numOfRooms; i--)
                {
                    comboBox_room.Items.RemoveAt(i);
                }
            }

            if (skipEvents) { return; }
            if (comboBox_room.SelectedIndex == 0) { LoadRoom(area, 0, true); }
            else { comboBox_room.SelectedIndex = 0; }
        }

        private void comboBox_room_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (skipEvents) { return; }
            int newRoom = comboBox_room.SelectedIndex;
            if (room != null && newRoom == room.RoomID) { return; }
            LoadRoom(comboBox_area.SelectedIndex, newRoom, true);
        }

        #endregion


        #region view/edit options

        public void ToggleEditMode()
        {
            // update UI
            bool val = toolStrip_editBGs.Checked;
            menuItem_editObjects.Checked = val;
            toolStrip_editObjects.Checked = val;

            val = !val;
            groupBox_editBG.Enabled = val;
            menuItem_editBGs.Checked = val;
            toolStrip_editBGs.Checked = val;

            // redraw cursor if necessary
            ResetRoomTip(false);
            Rectangle prev = roomView.redRect;
            if (EditBGs && selection.X != -1)
            {
                roomView.ResizeRed(selection.Width, selection.Height);
            }
            else
            {
                roomView.ResizeRed(1, 1);
            }
            roomView.Invalidate(Draw.Union(prev, roomView.redRect));
        }

        public static void UpdateEditors()
        {
            foreach (Form f in Application.OpenForms)
            {
                Editor editor = f as Editor;
                if (editor != null)
                {
                    editor.UpdateEditor();
                }
            }
        }

        public void UpdateEditor()
        {
            ReloadRoom(false);
        }

        private void UpdateZoom(int newZoom)
        {
            if (newZoom < 0) { zoom = 0; }
            else if (newZoom > 3) { zoom = 3; }
            else { zoom = newZoom; }

            menuItem_zoom100.Checked = zoom == 0;
            menuItem_zoom200.Checked = zoom == 1;
            menuItem_zoom400.Checked = zoom == 2;
            menuItem_zoom800.Checked = zoom == 3;

            if (!roomView.UpdateZoom(zoom, true)) { return; }

            if (roomCursor.X != -1)
            {
                roomView.MoveRed(roomCursor.X, roomCursor.Y);

                if (roomView.HasSelection)
                {
                    roomView.ResizeSelection(selection);
                }
            }
            if (selection.X != -1 && EditBGs)
            {
                roomView.ResizeRed(selection.Width, selection.Height);
            }
            else
            {
                roomView.ResizeRed(1, 1);
            }
        }

        private void UpdateBGs()
        {
            bool[] view = new bool[] { checkBox_viewBG0.Checked, checkBox_viewBG1.Checked, 
                checkBox_viewBG2.Checked, checkBox_viewBG3.Checked };
            room.backgrounds.View = view;
            roomView.RedrawAll();
        }

        private void checkBox_viewBG0_CheckedChanged(object sender, EventArgs e)
        {
            if (skipEvents) { return; }
            menuItem_viewBG0.Checked = !menuItem_viewBG0.Checked;
            UpdateBGs();
        }
        private void checkBox_viewBG1_CheckedChanged(object sender, EventArgs e)
        {
            if (skipEvents) { return; }
            menuItem_viewBG1.Checked = !menuItem_viewBG1.Checked;
            UpdateBGs();
        }
        private void checkBox_viewBG2_CheckedChanged(object sender, EventArgs e)
        {
            if (skipEvents) { return; }
            menuItem_viewBG2.Checked = !menuItem_viewBG2.Checked;
            UpdateBGs();
        }
        private void checkBox_viewBG3_CheckedChanged(object sender, EventArgs e)
        {
            if (skipEvents) { return; }
            menuItem_viewBG3.Checked = !menuItem_viewBG3.Checked;
            UpdateBGs();
        }

        private void checkBox_editBG0_CheckedChanged(object sender, EventArgs e)
        {
            menuItem_editBG0.Checked = !menuItem_editBG0.Checked;
            if (checkBox_editBG0.Checked)
            {
                menuItem_editBG1.Checked = checkBox_editBG1.Checked = false;
                menuItem_editBG2.Checked = checkBox_editBG2.Checked = false;
                menuItem_viewBG0.Checked = checkBox_viewBG0.Checked = true;
            }
        }
        private void checkBox_editBG1_CheckedChanged(object sender, EventArgs e)
        {
            menuItem_editBG1.Checked = !menuItem_editBG1.Checked;
            if (checkBox_editBG1.Checked)
            {
                menuItem_editBG0.Checked = checkBox_editBG0.Checked = false;
                menuItem_editBG2.Checked = checkBox_editBG2.Checked = false;
                menuItem_viewBG1.Checked = checkBox_viewBG1.Checked = true;
            }
        }
        private void checkBox_editBG2_CheckedChanged(object sender, EventArgs e)
        {
            menuItem_editBG2.Checked = !menuItem_editBG2.Checked;
            if (checkBox_editBG2.Checked)
            {
                menuItem_editBG0.Checked = checkBox_editBG0.Checked = false;
                menuItem_editBG1.Checked = checkBox_editBG1.Checked = false;
                menuItem_viewBG2.Checked = checkBox_viewBG2.Checked = true;
            }
        }
        private void checkBox_editCLP_CheckedChanged(object sender, EventArgs e)
        {
            menuItem_editCLP.Checked = !menuItem_editCLP.Checked;
        }

        private void comboBox_spriteset_SelectedIndexChanged(object sender, EventArgs e)
        {
            enemySet = comboBox_spriteset.SelectedIndex;
            room.SetEnemyList(enemySet);
            if (skipEvents) { return; }

            bool exists = (room.enemyList.Count > 0);
            menuItem_outlineSprites.Enabled = exists;
            menuItem_viewSprites.Enabled = exists;
            toolStrip_outlineSprites.Enabled = exists;
            toolStrip_viewSprites.Enabled = exists;
            menuItem_viewSprites.Checked = exists;
            toolStrip_viewSprites.Checked = exists;
            menuItem_outlineSprites.Checked = exists;
            toolStrip_outlineSprites.Checked = exists;
            room.vramObj = new VramObj(room.spritesets[enemySet]);
            roomView.RedrawAll();
        }
        
        private void UpdateRoomNumbers()
        {
            for (int i = 0; i < comboBox_room.Items.Count; i++)
            {
                comboBox_room.Items[i] = Hex.ToString(i);
            }
        }

        #endregion


        #region undo/redo actions

        public void PerformAction(Action a)
        {
            undoRedo.Do(a, room);
            UpdateUI(a);
            UpdateUndoRedo();
        }

        private void Undo()
        {
            Action a = undoRedo.Undo(room);
            UpdateUI(a);
            UpdateUndoRedo();
        }

        private void Redo()
        {
            Action a = undoRedo.Redo(room);
            UpdateUI(a);
            UpdateUndoRedo();
        }

        private void UpdateUI(Action a)
        {
            if (a is AddRemoveRoomObject)
            {
                //if (a.ActionText.Contains("sprite"))
                if (a.ActionText.Contains(Resources.Action_SpriteText))
                    {
                    menuItem_outlineSprites.Enabled = menuItem_viewSprites.Enabled = 
                        toolStrip_outlineSprites.Enabled = toolStrip_viewSprites.Enabled = room.enemyList.Count > 0;
                    menuItem_viewSprites.Checked = toolStrip_viewSprites.Checked = toolStrip_viewSprites.Enabled;
                    menuItem_outlineSprites.Checked = toolStrip_outlineSprites.Checked = toolStrip_outlineSprites.Enabled;
                }
                //else if (a.ActionText.Contains("door"))
                else if (a.ActionText.Contains(Resources.Action_DoorText))
                {
                    menuItem_outlineDoors.Enabled = toolStrip_outlineDoors.Enabled = room.doorList.Count > 0;
                    menuItem_outlineDoors.Checked = toolStrip_outlineDoors.Checked = toolStrip_outlineDoors.Enabled;
                }
                else
                {
                    menuItem_outlineScrolls.Enabled = toolStrip_outlineScrolls.Enabled = room.scrollList.Count > 0;
                    menuItem_outlineScrolls.Checked = toolStrip_outlineScrolls.Checked = toolStrip_outlineScrolls.Enabled;
                }
            }

            roomView.RedrawAll();
        }

        private void UpdateUndoRedo()
        {
            menuItem_undo.Enabled = toolStrip_undo.Enabled = undoRedo.CanUndo;
            if (toolStrip_undo.Enabled)
            {
                Action a = undoRedo.UndoStack.Peek();
                //toolStrip_undo.ToolTipText = "Undo \"" + a.ActionText + "\"";
                toolStrip_undo.ToolTipText = Resources.formMain_UndoToolTipText + "\"" + a.ActionText + "\"";
            }
            else
            {
                toolStrip_undo.ToolTipText = "";
            }

            menuItem_redo.Enabled = toolStrip_redo.Enabled = undoRedo.CanRedo;
            if (toolStrip_redo.Enabled)
            {
                Action a = undoRedo.RedoStack.Peek();
                //toolStrip_redo.ToolTipText = "Redo \"" + a.ActionText + "\"";
                toolStrip_redo.ToolTipText = Resources.formMain_RedoToolTipText + "\"" + a.ActionText + "\"";
            }
            else
            {
                toolStrip_redo.ToolTipText = "";
            }
        }

        private void PopulateUndoRedoList(ToolStripSplitButton button, DropOutStack<Action> stack)
        {
            int count = Math.Min(16, stack.Count);
            int lastIndex = stack.Count - 1;

            button.DropDownItems.Clear();
            for (int i = 0; i < count; i++)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Tag = i + 1;
                item.Text = stack[lastIndex - i].ActionText;
                button.DropDownItems.Add(item);
            }
        }

        #endregion


        #region map/tileset events

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            // check if roomView active
            if (room == null || roomCursor.X == -1) { return; }

            switch (e.KeyCode)
            {
                case Keys.W:
                case Keys.A:
                case Keys.S:
                case Keys.D:
                    ResizeDoor(e.KeyCode);
                    break;
                case Keys.T:
                    Test.Room(this, true, roomCursor.X, roomCursor.Y);
                    break;
                case Keys.G:
                    GoThroughDoor();
                    break;
                case Keys.Delete:
                    RemoveObject();
                    break;
                case Keys.OemOpenBrackets:
                    ChangeEnemyProperty(true);
                    break;
                case Keys.OemCloseBrackets:
                    ChangeEnemyProperty(false);
                    break;
            }
        }

        private void comboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ResizeDoor(Keys keyCode)
        {
            int selDoor = room.doorList.FindDoor(roomCursor);
            if (selDoor != -1)
            {
                Door door = (Door)room.doorList[selDoor].Copy();

                switch (keyCode)
                {
                    case Keys.W:
                        if (door.yEnd - door.yStart <= 0) { return; }
                        door.yEnd--;
                        break;
                    case Keys.A:
                        if (door.xEnd - door.xStart <= 0) { return; }
                        door.xEnd--;
                        break;
                    case Keys.S:
                        door.yEnd++;
                        break;
                    case Keys.D:
                        door.xEnd++;
                        break;
                }

                EditRoomObject a = new EditRoomObject(door, selDoor, false);
                PerformAction(a);
            }
        }

        private void GoThroughDoor()
        {
            // check for door and destination room
            int selObject = room.doorList.FindDoor(roomCursor);
            if (selObject == -1) { return; }

            Door dst = DoorData.GetDestinationDoor(room.doorList[selObject]);
            if (dst == null) { return; }
            if (dst.srcRoom >= Version.RoomsPerArea[dst.areaID]) { return; }

            JumpToRoom(dst.areaID, dst.srcRoom);
        }

        private void RemoveObject()
        {
            RoomObject obj;
            int selObject = FindObject(out obj);
            if (selObject == -1) { return; }

            AddRemoveRoomObject a = new AddRemoveRoomObject(obj, selObject);
            PerformAction(a);
            ResetRoomTip(true);
        }

        private void ChangeEnemyProperty(bool left)
        {
            int selEnemy = room.enemyList.FindEnemy(roomCursor);
            if (selEnemy != -1)
            {
                int cmp;
                if (left) { cmp = 1; }
                else { cmp = 0xF; }
                Enemy enemy = (Enemy)room.enemyList[selEnemy].Copy();

                if ((enemy.prop & 0xF) != cmp)
                {
                    if (left) { enemy.prop--; }
                    else { enemy.prop++; }
                    EditRoomObject a = new EditRoomObject(enemy, selEnemy, false);
                    PerformAction(a);
                    ResetRoomTip(true);
                }
            }
        }

        private int FindObject(out RoomObject obj)
        {
            int selObject = room.enemyList.FindEnemy(roomCursor);
            if (selObject != -1)
            {
                obj = room.enemyList[selObject];
                return selObject;
            }
            selObject = room.doorList.FindDoor(roomCursor);
            if (selObject != -1)
            {
                obj = room.doorList[selObject];
                return selObject;
            }
            selObject = room.scrollList.FindScroll(roomCursor);
            if (selObject != -1)
            {
                obj = room.scrollList[selObject / 6];
                return selObject;
            }

            obj = null;
            return -1;
        }

        private void UpdateStatusCoor()
        {
            int xPos = roomCursor.X;
            int yPos = roomCursor.Y;
            Block b = room.backgrounds.GetBlock(xPos, yPos);
            if (b.CLP != 0xFFFF)
            {
                statusLabel_clip.Text = (string)comboBox_clipdata.Items[b.CLP];
            }
            statusLabel_coor.Text = "(" + Hex.ToString(xPos) + ", " + Hex.ToString(yPos) + ")";
        }

        private void UpdateStatusSel()
        {
            int w = selection.Width;
            int h = selection.Height;
            statusLabel_sel.Text = Hex.ToString(w) + " x " + Hex.ToString(h);
        }

        #endregion


        #region mouse events

        private Point roomCursor;
        private Point tileCursor;

        private Point pivot;
        private Rectangle selection;
        private Block[,] blocks;
        private FormClipboard clipboard;

        private int selEnemy;
        private int selDoor;
        private int selScroll;

        private Timer roomTimer;
        private Timer tileTimer;
        private ToolTip roomTip;
        private ToolTip tileTip;

        private void ResizeSelection(Point pos)
        {
            int width = Math.Abs(pos.X - pivot.X) + 1;
            int height = Math.Abs(pos.Y - pivot.Y) + 1;

            int x = (pos.X >= pivot.X) ? pivot.X : pos.X;
            int y = (pos.Y >= pivot.Y) ? pivot.Y : pos.Y;
            selection = new Rectangle(x, y, width, height);
        }

        private void CopyBlocks()
        {
            int xStart = selection.X;
            int yStart = selection.Y;
            int width = selection.Width;
            int height = selection.Height;

            pivot = new Point(-1, -1);
            blocks = new Block[width, height];

            if (tileView.HasSelection)
            {
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        Block b;
                        b.BG0 = b.BG1 = b.BG2 = (ushort)((yStart + y) * 16 + (xStart + x));
                        b.CLP = 0xFFFF;
                        blocks[x, y] = b;
                    }
                }
            }
            else
            {
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        blocks[x, y] = room.backgrounds.GetBlock(xStart + x, yStart + y);
                    }
                }
            }

            UpdateClipboard();
        }

        private void PasteBlocks(bool combine)
        {
            int bgNum = -1;
            if (EditBG0) { bgNum = 0; }
            else if (EditBG1) { bgNum = 1; }
            else if (EditBG2) { bgNum = 2; }

            ushort clip = 0xFFFF;
            if (EditCLP)
            {
                if (tileView.HasSelection || menuItem_forceClipdata.Checked)
                {
                    clip = Clipdata;
                }
                else { clip = 0xFFFE; }
            }

            EditBlocks a = new EditBlocks(room.backgrounds, blocks, roomCursor, bgNum, clip, combine);
            PerformAction(a);
        }

        private void UpdateClipboard()
        {
            if (clipboard == null || !clipboard.Visible) { return; }

            if (tileView.HasSelection)
            {
                clipboard.UpdateImage((Bitmap)tileView.BackgroundImage, selection);
            }
            else if (roomView.HasSelection)
            {
                clipboard.UpdateImage((Bitmap)roomView.BackgroundImage, selection);
            }
            else
            {
                clipboard.Clear();
            }
        }

        private void SelectObjects()
        {
            if (ViewSprites || OutlineSprites)
            {
                selEnemy = room.enemyList.FindEnemy(roomCursor);
            }
            if (OutlineDoors)
            {
                selDoor = room.doorList.FindDoor(roomCursor);
            }
            if (OutlineScrolls)
            {
                selScroll = room.scrollList.FindScroll(roomCursor);
            }
        }

        private void ResetRoomTip(bool restart)
        {
            roomTimer.Stop();
            roomTip.RemoveAll();
            if (restart) { roomTimer.Start(); }
        }

        private void ResetTileTip(bool restart)
        {
            tileTimer.Stop();
            tileTip.RemoveAll();
            if (restart) { tileTimer.Start(); }
        }

        private void roomTimer_Tick(object sender, EventArgs e)
        {
            roomTimer.Stop();
            if (roomCursor.X == -1) { return; }

            string caption;
            int x = roomCursor.X << (4 + zoom);
            int y = ((roomCursor.Y + 1) << (4 + zoom)) + 8;

            if (EditBGs)
            {
                caption = room.backgrounds.GetBlock(roomCursor.X, roomCursor.Y).ToString();
                roomTip.Show(caption, roomView, x, y);
            }
            else
            {
                RoomObject obj;
                int selObject = FindObject(out obj);

                if (obj is Enemy)
                {
                    Enemy en = (Enemy)obj;
                    //caption = "Slot: " + Hex.ToString(en.SlotNum);
                    //caption += "\nProperty: " + Hex.ToString(en.Property);
                    caption = Resources.formMain_EnemyInfoSlotText + Hex.ToString(en.SlotNum);
                    caption += "\n" + Resources.formMain_EnemyInfoPropText + Hex.ToString(en.Property);
                    byte spriteID;
                    if (en.Property == 0) { spriteID = en.SlotNum; }
                    else
                    {
                        spriteID = room.spritesets[enemySet].GetSpriteID(en.SlotNum);
                    }
                    //caption += "\nSprite ID: " + Hex.ToString(spriteID);
                    caption += "\n" + Resources.formMain_EnemyInfoIDText + Hex.ToString(spriteID);
                    roomTip.Show(caption, roomView, x, y);
                }
                else if (obj is Door)
                {
                    Door src = (Door)obj;
                    //caption = "Current door: " + Hex.ToString(src.doorNum);
                    //caption += "\nDestination door: " + Hex.ToString(src.dstDoor);
                    caption = Resources.formMain_DoorInfoCurentText + Hex.ToString(src.doorNum);
                    caption += "\n" + Resources.formMain_DoorInfoDestDText + Hex.ToString(src.dstDoor);
                    Door dst = DoorData.GetDestinationDoor(src);
                    if (dst != null)
                    {
                        //caption += "\nDestination room: " + Hex.ToString(dst.srcRoom);
                        caption += "\n" + Resources.formMain_DoorInfoDestRText + Hex.ToString(dst.srcRoom);
                    }
                    int hatchNum = room.GetHatchNumber(src.doorNum);
                    if (hatchNum >= 0)
                    {
                        //caption += "\nHatch number: " + hatchNum;
                        caption += "\n" + Resources.formMain_DoorInfoHatchText + hatchNum;
                    }
                    roomTip.Show(caption, roomView, x, y);
                }
            }
        }

        private void tileTimer_Tick(object sender, EventArgs e)
        {
            tileTimer.Stop();
            if (tileCursor.X == -1) { return; }

            //string caption = "Block: " + Hex.ToString(tileCursor.Y * 16 + tileCursor.X);
            string caption = Resources.formMain_BlockInfoText + Hex.ToString(tileCursor.Y * 16 + tileCursor.X);
            tileTip.Show(caption, tileView, tileCursor.X * 16, tileCursor.Y * 16 + 24);
        }

        private void tileView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                // start new selection
                pivot = tileCursor;
                selection = new Rectangle(pivot.X, pivot.Y, 1, 1);

                // remove selection from room if necessary
                if (roomView.HasSelection)
                {
                    Rectangle rect1 = roomView.selRect;
                    rect1.Width++; rect1.Height++;
                    roomView.selRect = new Rectangle(-1, -1, 15, 15);
                    roomView.Invalidate(rect1);
                }
                // remove previous selection from tileset if necessary
                Rectangle rect2 = new Rectangle(pivot.X * 16, pivot.Y * 16, 16, 16);
                if (tileView.HasSelection)
                {
                    rect2 = Draw.Union(rect2, tileView.selRect);
                }
                tileView.ResizeSelection(selection);
                tileView.Invalidate(rect2);
                UpdateStatusSel();
            }
        }

        private void tileView_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X >> 4;
            int y = e.Y >> 4;
            if (x == tileCursor.X && y == tileCursor.Y) { return; }
            if (x < 0 || x >= 16 || y < 0 || y >= tileView.Height / 16) { return; }

            tileCursor.X = x;
            tileCursor.Y = y;
            ResetTileTip(true);

            // if any mouse button is pressed
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                if (tileView.HasSelection)
                {
                    // redraw selection using pivot
                    Rectangle rect = tileView.selRect;
                    ResizeSelection(tileCursor);
                    tileView.ResizeSelection(selection);
                    tileView.MoveRed(x, y);
                    rect = Draw.Union(rect, tileView.selRect);
                    tileView.Invalidate(rect);
                    UpdateStatusSel();
                }
            }
            else
            {
                // redraw red rectangle
                Rectangle rect = tileView.redRect;
                tileView.MoveRed(x, y);
                rect = Draw.Union(rect, tileView.redRect);
                tileView.Invalidate(rect);
            }
        }

        private void tileView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                if (tileView.HasSelection)
                {
                    CopyBlocks();
                    pivot = new Point(-1, -1);

                    if (EditBGs)
                    {
                        // redraw room's red rectangle
                        Rectangle rect = roomView.redRect;
                        roomView.ResizeRed(selection.Width, selection.Height);
                        rect = Draw.Union(rect, roomView.redRect);
                        roomView.Invalidate(rect);
                    }
                }
            }
        }

        private void tileView_MouseLeave(object sender, EventArgs e)
        {
            ResetTileTip(false);
        }

        private void roomView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (EditBGs)
                {
                    if (selection.X != -1)
                    {
                        PasteBlocks(false);
                        UpdateStatusCoor();
                    }
                }
                else
                {
                    SelectObjects();
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (EditBGs)
                {
                    // start new selection
                    pivot = roomCursor;
                    selection = new Rectangle(pivot.X, pivot.Y, 1, 1);

                    // remove selection from tileset if necessary
                    if (tileView.HasSelection)
                    {
                        Rectangle rect1 = tileView.selRect;
                        rect1.Width++; rect1.Height++;
                        tileView.selRect = new Rectangle(-1, -1, 15, 15);
                        tileView.Invalidate(rect1);
                    }
                    // remove previous selection from room if necessary
                    Rectangle rect2 = roomView.redRect;
                    if (roomView.HasSelection)
                    {
                        rect2 = Draw.Union(roomView.redRect, roomView.selRect);
                    }
                    else { rect2.Width++; rect2.Height++; }
                    roomView.ResizeSelection(selection);
                    roomView.ResizeRed(1, 1);
                    roomView.Invalidate(rect2);
                    UpdateStatusSel();
                }
                else
                {
                    SelectObjects();
                }
            }
            else if (e.Button == MouseButtons.Middle)
            {
                // if not making selection or moving object
                if (e.Button != MouseButtons.Left && e.Button != MouseButtons.Right)
                {
                    ToggleEditMode();
                }
            }
        }

        private void roomView_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X >> (4 + zoom);
            int y = e.Y >> (4 + zoom);
            if (x == roomCursor.X && y == roomCursor.Y) { return; }
            if (x < 0 || x >= room.Width || y < 0 || y >= room.Height) { return; }

            if (contextMenuOpen)
            {
                selEnemy = -1;
                selDoor = -1;
                selScroll = -1;
                contextMenuOpen = false;
                return;
            }

            Point prev = roomCursor;
            roomCursor.X = x;
            roomCursor.Y = y;
            ResetRoomTip(true);

            if (e.Button == MouseButtons.Left)
            {
                if (EditBGs)
                {
                    if (selection.X != -1 && EditAnyBG)
                    {
                        Rectangle rect = roomView.redRect;
                        rect.Width++; rect.Height++;
                        roomView.Invalidate(rect);
                        roomView.MoveRed(x, y);
                        PasteBlocks(true);
                        return;
                    }
                }
                else
                {
                    RoomObject obj = null;
                    int selObject = -1;
                    if (selEnemy != -1)
                    {
                        obj = room.enemyList[selEnemy];
                        selObject = selEnemy;
                    }
                    else if (selDoor != -1)
                    {
                        obj = room.doorList[selDoor];
                        selObject = selDoor;
                    }
                    else if (selScroll != -1)
                    {
                        obj = room.scrollList[selScroll / 6];
                        selObject = selScroll;                  
                    }

                    if (selObject != -1)
                    {
                        if (obj is Scroll)
                        {
                            obj = obj.Move(roomCursor, selObject);
                        }
                        else
                        {
                            Point diff = new Point(x - prev.X, y - prev.Y);
                            obj = obj.Move(diff, selObject);
                        }
                        roomView.MoveRed(x, y);
                        EditRoomObject a = new EditRoomObject(obj, selObject, true);
                        PerformAction(a);
                        UpdateStatusCoor();
                        return;
                    }
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (EditBGs && roomView.HasSelection)
                {
                    // redraw selection using pivot
                    Rectangle rect = roomView.selRect;
                    ResizeSelection(roomCursor);
                    roomView.ResizeSelection(selection);
                    roomView.MoveRed(x, y);
                    rect = Draw.Union(rect, roomView.selRect);
                    roomView.Invalidate(rect);
                    UpdateStatusSel();
                    UpdateStatusCoor();
                    return;
                }
            }

            // redraw red rectangle
            Rectangle rect2 = roomView.redRect;
            roomView.MoveRed(x, y);
            rect2 = Draw.Union(rect2, roomView.redRect);
            roomView.Invalidate(rect2);

            UpdateStatusCoor();
        }

        private void roomView_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                selEnemy = -1;
                selDoor = -1;
                selScroll = -1;
                undoRedo.FinalizePreviousAction();
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (EditBGs && roomView.HasSelection)
                {
                    CopyBlocks();
                    pivot = new Point(-1, -1);

                    Rectangle rect = roomView.redRect;
                    roomView.ResizeRed(selection.Width, selection.Height);
                    rect = Draw.Union(rect, roomView.redRect);
                    roomView.Invalidate(rect);
                }
            }
        }

        private void roomView_MouseLeave(object sender, EventArgs e)
        {
            ResetRoomTip(false);
        }

        #endregion


        #region right click menu

        private void contextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!menuItem_editObjects.Checked)
            {
                e.Cancel = true;
                return;
            }

            contextMenuOpen = true;

            // add sprite
            bool enable = (room.enemyList.Count < 24);
            contextMenu.Items[0].Enabled = enable;

            // edit/remove sprite
            enable = (selEnemy != -1);
            contextMenu.Items[1].Enabled = enable;
            contextMenu.Items[2].Enabled = enable;

            // add door
            enable = DoorData.CanAddDoor((byte)comboBox_area.SelectedIndex);
            contextMenu.Items[4].Enabled = enable;

            // edit/remove door
            enable = (selDoor != -1);
            contextMenu.Items[5].Enabled = enable;
            contextMenu.Items[6].Enabled = enable;

            // add scroll
            enable = (room.scrollList.Count < 16);
            contextMenu.Items[8].Enabled = enable;

            // edit/remove scroll
            enable = (selScroll != -1);
            contextMenu.Items[9].Enabled = enable;
            contextMenu.Items[10].Enabled = enable;
        }

        private void contextItem_addSprite_Click(object sender, EventArgs e)
        {
            AddRemoveRoomObject a = new AddRemoveRoomObject(room, typeof(Enemy), roomCursor);
            PerformAction(a);
        }

        private void contextItem_editSprite_Click(object sender, EventArgs e)
        {
            FindOpenForm(typeof(FormEditEnemy), true);

            FormEditEnemy form = new FormEditEnemy(this, selEnemy);
            form.Show();
            selEnemy = -1;
        }

        private void contextItem_removeSprite_Click(object sender, EventArgs e)
        {
            AddRemoveRoomObject a = new AddRemoveRoomObject(room.enemyList[selEnemy], selEnemy);
            PerformAction(a);
            selEnemy = -1;
        }

        private void contextItem_addDoor_Click(object sender, EventArgs e)
        {
            AddRemoveRoomObject a = new AddRemoveRoomObject(room, typeof(Door), roomCursor);
            PerformAction(a);
        }

        private void contextItem_editDoor_Click(object sender, EventArgs e)
        {
            FindOpenForm(typeof(FormEditDoor), true);

            FormEditDoor form = new FormEditDoor(this, selDoor);
            form.Show();
            selDoor = -1;
        }

        private void contextItem_removeDoor_Click(object sender, EventArgs e)
        {
            AddRemoveRoomObject a = new AddRemoveRoomObject(room.doorList[selDoor], selDoor);
            PerformAction(a);
            selDoor = -1;
        }

        private void contextItem_addScroll_Click(object sender, EventArgs e)
        {
            AddRemoveRoomObject a = new AddRemoveRoomObject(room, typeof(Scroll), roomCursor);
            PerformAction(a);
        }

        private void contextItem_editScroll_Click(object sender, EventArgs e)
        {
            FindOpenForm(typeof(FormEditScroll), true);

            FormEditScroll form = new FormEditScroll(this, selScroll);
            form.Show();
            selScroll = -1;
        }

        private void contextItem_removeScroll_Click(object sender, EventArgs e)
        {
            AddRemoveRoomObject a = new AddRemoveRoomObject(room.scrollList[selScroll / 6], selScroll);
            PerformAction(a);
            selScroll = -1;
        }

        private void contextItem_testRoom_Click(object sender, EventArgs e)
        {
            Test.Room(this, true, roomCursor.X, roomCursor.Y);
        }

        #endregion


    }
}
