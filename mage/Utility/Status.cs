using System;
using System.Windows.Forms;

namespace mage
{
    public class Status
    {
        public bool UnsavedChanges { get; private set; }
        private ToolStripStatusLabel statusLabel;
        private Button applyButton;

        public Status(ToolStripStatusLabel statusLabel, Button applyButton = null)
        {
            this.statusLabel = statusLabel;
            this.applyButton = applyButton;
            UnsavedChanges = false;
        }

        public void ChangeMade()
        {
            if (!UnsavedChanges)
            {
                UnsavedChanges = true;
                //statusLabel.Text = "Unsaved changes";
                statusLabel.Text = Properties.Resources.Utility_Status_statusLabelUnsaveText;
                ToggleApplyButton(true);
            }
        }

        public void LoadNew()
        {
            if (UnsavedChanges)
            {
                UnsavedChanges = false;
                //statusLabel.Text = "Changes discarded";
                statusLabel.Text = Properties.Resources.Utility_Status_statusLabelDiscardText;
                ToggleApplyButton(false);
            }
            else
            {
                statusLabel.Text = "";
            }
        }

        public void Save()
        {
            if (UnsavedChanges)
            {
                UnsavedChanges = false;
                //statusLabel.Text = "Changes saved";
                statusLabel.Text = Properties.Resources.Utility_Status_statusLabelSaveText;
                ToggleApplyButton(false);
            }
            else
            {
                //statusLabel.Text = "No changes to save";
                statusLabel.Text = Properties.Resources.Utility_Status_statusLabelNoChangeText;
            }
        }

        public void Import()
        {
            UnsavedChanges = false;
            //statusLabel.Text = "Changes saved";
            statusLabel.Text = Properties.Resources.Utility_Status_statusLabelSaveText;
            ToggleApplyButton(false);
        }

        private void ToggleApplyButton(bool enable)
        {
            if (applyButton != null)
            {
                applyButton.Enabled = enable;
            }
        }


    }
}
