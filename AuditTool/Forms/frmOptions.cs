using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AuditTool.Classes;
using AuditTool.Properties;

namespace AuditTool.Forms
{
    public partial class frmOptions : Form
    {
        public delegate void SettingsSaveEventHandler(object sender, EventArgs e);

        public event SettingsSaveEventHandler SettingsSaveEvent;

        public virtual void RaiseSaveSettingsEvent()
        {
            SettingsSaveEvent(this, null);
        }

        public frmOptions()
        {
            InitializeComponent();

            LoadSettings();
        }

        private void LoadSettings()
        {
            if (!String.IsNullOrEmpty(Settings.Default["REGION"].ToString()))
            {
                cbRegion.SelectedItem = Settings.Default["REGION"].ToString();
            }

            if (!String.IsNullOrEmpty(Settings.Default["PREFERRED_REALM"].ToString()))
            {
                tbPreferredRealm.Text = Settings.Default["PREFERRED_REALM"].ToString();
            }

            string auditMode = "Character";
            if (!String.IsNullOrEmpty(Settings.Default["PREFERRED_AUDITMODE"].ToString()))
            {
                auditMode = Settings.Default["PREFERRED_AUDITMODE"].ToString();
            }
            cbPreferredAuditMode.SelectedItem = auditMode;

            if (Settings.Default["PREFERRED_MINLEVEL"] != null && (int)Settings.Default["PREFERRED_MINLEVEL"] != 0) { nudMinLevel.Value = (int)Settings.Default["PREFERRED_MINLEVEL"]; }
            if (Settings.Default["PREFERRED_MINILEVEL"] != null && (int)Settings.Default["PREFERRED_MINILEVEL"] != 0) { nudMinILevel.Value = (int)Settings.Default["PREFERRED_MINILEVEL"]; }
            if (Settings.Default["HISTORY_ENTRIES"] != null) { nudHistoryCount.Value = (int) Settings.Default["HISTORY_ENTRIES"]; }

            if (Settings.Default["LABELS"] == null)
            {
                Settings.Default["LABELS"] = new System.Collections.Specialized.StringCollection();
            }
            else
            {
                System.Collections.Specialized.StringCollection labels =
                    (System.Collections.Specialized.StringCollection)Settings.Default["LABELS"];

                ArrayList.Adapter(labels).Sort();                

                foreach (string l in labels)
                {
                    lbLabels.Items.Add(l);
                }
            }

            bool useCharCache = false;
            if (Settings.Default["CHAR_CACHE_ENABLE"] != null)
            {
                useCharCache = (bool) Settings.Default["CHAR_CACHE_ENABLE"];
            }
            ToggleCharCacheOptions(useCharCache);

            int charCacheDays = 0;
            if (Settings.Default["CHAR_CACHE_DAYS"] != null)
            {
                charCacheDays = (int) Settings.Default["CHAR_CACHE_DAYS"];
            }
            nudDays.Value = charCacheDays;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {            
            SaveSettings();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void SaveSettings()
        {

            Settings.Default["REGION"] = cbRegion.SelectedItem;
            Settings.Default["PREFERRED_REALM"] = tbPreferredRealm.Text;
            Settings.Default["PREFERRED_AUDITMODE"] = cbPreferredAuditMode.SelectedItem;
            Settings.Default["PREFERRED_MINLEVEL"] = (int)nudMinLevel.Value;
            Settings.Default["PREFERRED_MINILEVEL"] = (int)nudMinILevel.Value;
            Settings.Default["HISTORY_ENTRIES"] = (int) nudHistoryCount.Value;

            System.Collections.Specialized.StringCollection labels = new System.Collections.Specialized.StringCollection();
            foreach (string l in lbLabels.Items) { labels.Add(l); }
            Settings.Default["LABELS"] = labels;

            Settings.Default["CHAR_CACHE_ENABLE"] = cbUseCache.Checked;
            Settings.Default["CHAR_CACHE_DAYS"] = (int) nudDays.Value;

            Settings.Default.Save();

            RaiseSaveSettingsEvent();
        }

        private void btnClearDb_Click(object sender, EventArgs e)
        {
            DbHistoryDal dal = new DbHistoryDal();
            bool result = dal.ClearDB();

            if (result)
            {
                MessageBox.Show("Successfully cleared character database!");
            }
            else
            {
                MessageBox.Show("Error clearing character database!");
            }
        }

        private void btnDeleteLabel_Click(object sender, EventArgs e)
        {
            string selectedItem = (string)lbLabels.SelectedItem;
            lbLabels.Items.Remove(selectedItem);

            DbHistoryDal dal = new DbHistoryDal();
            dal.ClearLabel(selectedItem);
        }

        private void btnAddLabel_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbNewLabel.Text) && !lbLabels.Items.Contains(tbNewLabel.Text))
            {
                lbLabels.Items.Add(tbNewLabel.Text);
                tbNewLabel.Text = string.Empty;
            }
        }

        private void ToggleCharCacheOptions(bool enabled)
        {
            cbUseCache.Checked = enabled;
            lblDaysOld1.Enabled = enabled;
            lblDaysOld2.Enabled = enabled;
            nudDays.Enabled = enabled;
            
        }

        private void cbUseCache_CheckedChanged(object sender, EventArgs e)
        {
            ToggleCharCacheOptions(cbUseCache.Checked);
        }

    }
}
