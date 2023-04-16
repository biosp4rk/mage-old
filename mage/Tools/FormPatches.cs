using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace mage
{
    public partial class FormPatches : Form
    {
        public struct PatchItem
        {
            public string patchName;
            public string description;
            public string author;
        }

        // fields
        private List<PatchItem> patchList;

        // constructor
        public FormPatches()
        {
            InitializeComponent();

            InitializeList();
        }

        private void InitializeList()
        {
            // read resource file
            string[] patchFile = Version.PatchList;
            patchList = new List<PatchItem>(patchFile.Length);

            foreach (string line in patchFile)
            {
                string[] items = line.Split(',');

                PatchItem pi;
                pi.patchName = items[0];
                pi.description = items[1];
                pi.author = items[2];
                patchList.Add(pi);
            }

            // add patches to list view
            foreach (PatchItem pi in patchList)
            {
                listView_patches.Items.Add(pi.description);
            }

            int j = 0;
            foreach (ListViewItem item in listView_patches.Items)
            {
                PatchItem pi = patchList[j];

                // add author
                item.SubItems.Add(pi.author);

                // check if applied or not
                byte[] data;
                try
                {
                    data = (byte[])Properties.Resources.ResourceManager.GetObject(pi.patchName);
                }
                catch { continue; }

                Patch p = new Patch(data);
                //if (p.IsApplied()) { item.SubItems.Add("Yes"); }
                //else { item.SubItems.Add("No"); }
                if (p.IsApplied()) { item.SubItems.Add("✔️"); }
                else { item.SubItems.Add("✖️"); }
                j++;
            }
        }

        private void listView_patches_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_apply.Enabled = true;
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            int index = listView_patches.SelectedIndices[0];
            byte[] data;
            try
            {
                data = (byte[])Properties.Resources.ResourceManager.GetObject(patchList[index].patchName);
            }
            catch { return; }
            Patch p = new Patch(data);
            p.Apply();

            //listView_patches.Items[index].SubItems[2].Text = "Yes";
            listView_patches.Items[index].SubItems[2].Text = "✔️";
            button_apply.Enabled = false;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
