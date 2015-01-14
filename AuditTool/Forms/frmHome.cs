using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

using AuditTool.Classes;
using AuditTool.Controls;
using AuditTool.Properties;
using AuditTool.Tasks;
using AuditTool.Resources;

using BrightIdeasSoftware;
using NLog;
using WowDotNetAPI.Models;

namespace AuditTool.Forms
{
    public partial class frmHome : Form
    {
        private static Logger logger = LogManager.GetLogger("frmHome");

        List<ArmoryCharacterResult> armoryResults = new List<ArmoryCharacterResult>(); 

        private int _membersToProcess = 0;

        private frmCharacterHistory _frmCharacterHistory;

        private string _selectedCharacter = string.Empty;

        public frmHome()
        {
            InitializeComponent();

            ReadSettings();

            _frmCharacterHistory = new frmCharacterHistory();

            if (!String.IsNullOrEmpty(Settings.Default["PREFERRED_AUDITMODE"].ToString()))
            {
                if (Settings.Default["PREFERRED_AUDITMODE"].ToString().Equals("Character"))
                { rbCharacter.Checked = true; }
                else { rbGuild.Checked = true; }
            }

            LoadQueryHistory();
        }

        #region Settings Load

        private void LoadQueryHistory()
        {
            if (Settings.Default["RECENT_QUERIES"] == null)
            {
                Settings.Default["RECENT_QUERIES"] = new System.Collections.Specialized.StringCollection();
            }
            else
            {
                // Populate history
                System.Collections.Specialized.StringCollection history =
                    (System.Collections.Specialized.StringCollection)Settings.Default["RECENT_QUERIES"];

                bool hasInvalidHistory = false;

                foreach (string s in history)
                {
                    string toolTipText = string.Empty;
                    string entryText = MakeHistoryMenuItem(s, out toolTipText);
                    if (!string.IsNullOrEmpty(entryText))
                    {
                        ToolStripMenuItem tsmi = new ToolStripMenuItem(entryText);
                        tsmi.ToolTipText = toolTipText;
                        tsmi.Click += (sender, args) => ExecuteHistorySearch(sender, args, s);
                        historyToolStripMenuItem.DropDownItems.Insert(0, tsmi);
                    }
                    else
                    {
                        hasInvalidHistory = true;
                        break;
                    }
                }

                if (hasInvalidHistory) { clearRecentHistoryToolStripMenuItem_Click(null, null); }
            }            
        }

        public void ReadSettings()
        {
            if (!String.IsNullOrEmpty(Settings.Default["PREFERRED_REALM"].ToString()))
            {
                tbRealm.Text = Settings.Default["PREFERRED_REALM"].ToString();
            }

            if (Settings.Default["PREFERRED_MINLEVEL"] != null && (int)Settings.Default["PREFERRED_MINLEVEL"] != 0) { nudMinLevel.Value = (int)Settings.Default["PREFERRED_MINLEVEL"]; }
            if (Settings.Default["PREFERRED_MINILEVEL"] != null && (int)Settings.Default["PREFERRED_MINILEVEL"] != 0) { nudMinILevel.Value = (int)Settings.Default["PREFERRED_MINILEVEL"]; }
            
            cbLabels.Items.Clear();
            cbLabels.Items.Add("Any Label");

            toolStripComboBox1.Items.Clear();
            toolStripComboBox1.Items.Add("No Label");
            toolStripComboBox1.SelectedIndex = 0;

            if (Settings.Default["LABELS"] != null)
            {
                System.Collections.Specialized.StringCollection labels =
                    (System.Collections.Specialized.StringCollection) Settings.Default["LABELS"];
                ArrayList.Adapter(labels).Sort();
                foreach (string l in labels)
                {
                    cbLabels.Items.Add(l);
                    toolStripComboBox1.Items.Add(l);
                }                
            }
            cbLabels.SelectedIndex = 0;

        }

        #endregion

        #region Result Processing

        private void LayoutResults()
        {
            armoryResults = armoryResults.OrderByDescending(a => a.CharacterData.Items.AverageItemLevel).ToList();          
            if (cbMatchILevel.Checked)
            {
                armoryResults =
                    armoryResults.Where(a => a.CharacterData.Items.AverageItemLevel >= (int) nudMinILevel.Value).ToList();
            }

            if (cbLabels.SelectedIndex > 0)
            {
                string label = cbLabels.Items[cbLabels.SelectedIndex].ToString();
                DbHistoryDal dal = new DbHistoryDal();
                List<ArmoryCharacterResult> filteredResults = new List<ArmoryCharacterResult>();
                foreach (ArmoryCharacterResult asr in armoryResults)
                {
                    if (dal.HasLabel(asr.CharacterName, asr.RealmName, label))
                    {
                        filteredResults.Add(asr);
                    }
                }

                armoryResults = filteredResults;
            }


            if (!cbIncludeAlts.Checked)
            {
                DbHistoryDal dal = new DbHistoryDal();
                List<ArmoryCharacterResult> filteredResults = new List<ArmoryCharacterResult>();
                foreach (ArmoryCharacterResult asr in armoryResults)
                {
                    if (!dal.IsAlt(asr.CharacterName, asr.RealmName))
                    {
                        filteredResults.Add(asr);
                    }
                }

                armoryResults = filteredResults;
            }



/*
                string thumbnail = ConfigurationManager.AppSettings["THUMBNAIL_CACHE_PATH"] + "\\" 
                                    +  Path.GetFileName(acr.CharacterData.Thumbnail);
                
                if(!FileUtils.DoesFileExist(thumbnail))
                {
                    bool result = FileUtils.RetrieveImageFromUrl(ConfigurationManager.AppSettings["THUMBNAIL_BASE_URL"] +
                                                   acr.CharacterData.Thumbnail, ConfigurationManager.AppSettings["THUMBNAIL_CACHE_PATH"], Path.GetFileName(acr.CharacterData.Thumbnail));
                    
                    if (!result) { thumbnail = ConfigurationManager.AppSettings["THUMBNAIL_NO_AVATAR"]; }
                }
*/
            
            
            olvColumn3.AspectGetter = delegate(object row)
            {
                    return ((ArmoryCharacterResult) row).AverageILevel;
            };
            
            olvColumn4.AspectGetter = delegate(object row)
            {
                    return ((ArmoryCharacterResult) row).AverageEquippedILevel;
            };

            olvColumn6.AspectGetter = delegate(object row) { return "class_" + ((ArmoryCharacterResult) row).Class.ToLower() ; };
            olvColumn6.Renderer = new MappedImageRenderer(new Object[] { "class_death_knight", CharacterClasses.class_death_knight, "class_druid", CharacterClasses.class_druid, "class_hunter", CharacterClasses.class_hunter, "class_mage", CharacterClasses.class_mage, "class_monk", CharacterClasses.class_monk, "class_paladin", CharacterClasses.class_paladin, "class_priest", CharacterClasses.class_priest, "class_rogue", CharacterClasses.class_rogue, "class_shaman", CharacterClasses.class_shaman, "class_warlock", CharacterClasses.class_warlock, "class_warrior", CharacterClasses.class_warrior  });
            
            //olvColumn6.AspectToStringConverter = delegate(object row) { return string.Empty; };

            olvColumn5.AspectGetter = delegate(object row)
                {
                    if (!cbIncludeAudit.Checked)
                    {
                        return "N/A";
                    }
                    else
                    {
                        bool result = ((ArmoryCharacterResult) row).HasPassedAudit;
                        if (result) { return "auditpass"; }
                        return "auditfail";
                        
                    }
                };
            olvColumn5.Renderer = new MappedImageRenderer(new Object[] { "auditpass", AuditIcons.auditpass, "auditfail", AuditIcons.auditfail });


            folvResults.SetObjects(armoryResults);

            tsslResultCount.Text = armoryResults.Count.ToString();
            tsslResultCount.Visible = true;
            tsslResultsText.Visible = true;

            StoreResults();
        }
        
        private void folvResults_FormatCell(object sender, FormatCellEventArgs e) 
        {
            if (e.ColumnIndex == this.olvColumn3.Index) 
            {
                ArmoryCharacterResult acr = (ArmoryCharacterResult)e.Model;
                if (acr.CharacterData.Items.AverageItemLevel >= (int)nudMinILevel.Value)
                {
                    e.SubItem.ForeColor = Color.Green;
                }
                else
                {
                    e.SubItem.ForeColor = Color.Red;
                }                 
            }
        }

        private void folvResults_IsHyperlink(object sender, IsHyperlinkEventArgs e)
        {

            e.Url = String.Format(ConfigurationManager.AppSettings["CHARACTER_URL"], tbRealm.Text, e.Text, Settings.Default["REGION"].ToString().ToLower());
        }

        #endregion

        #region Async Tasks methods

        private void ProcessResult(ArmoryCharacterResult result)
        {

            toolStripProgressBar1.PerformStep();

            if (result != null && result.CharacterData != null)
            {               
                armoryResults.Add(result);

                //toolStripProgressBar1.PerformStep();

                /*    
                if (toolStripProgressBar1.Value == _membersToProcess)
                {
                    toolStripProgressBar1.Visible = false;
                    gbSearchOptions.Enabled = true;
                    this.LayoutResults(); 
                }
                 */
            }

            if (toolStripProgressBar1.Value == _membersToProcess)
            {
                toolStripProgressBar1.Visible = false;
                gbSearchOptions.Enabled = true;
                this.LayoutResults();
            } 
            
        }

        private void OnArmoryTaskStatusChanged(object sender, ArmoryRetrieveEventArgs e)
        {
            switch (e.Status)
            {
                case ArmoryStatus.Retrieving:
                    gbSearchOptions.Enabled = false;
                    break;
                case ArmoryStatus.NotRetrieving:
                    ProcessResult(e.Result);
                    break;
                case ArmoryStatus.CancelPending:
                    break;
            }
        }

        private void OnArmoryTaskProgressChanged(object sender, ArmoryRetrieveEventArgs e)
        {
            /*
            pbProgress.PerformStep();
            if (pbProgress.Value == urlsToTest.Count)
            {
                pbProgress.Visible = false;
            }
             */
        }

        private void OnArmoryGuildTaskStatusChanged(object sender, ArmoryRetrieveGuildEventArgs e)
        {
            switch (e.Status)
            {
                case ArmoryGuildStatus.Retrieving:
                    gbSearchOptions.Enabled = false;
                    break;
                case ArmoryGuildStatus.NotRetrieving:
                    ProcessGuildMembers(e.Result);
                    break;
                case ArmoryGuildStatus.CancelPending:
                    break;
            }
        }

        private void ProcessGuildMembers(ArmoryGuildResult result)
        {
            if (result != null && result.GuildMembers != null)
            {
                _membersToProcess = result.GuildMembers.Count();
                toolStripProgressBar1.Maximum = _membersToProcess;
                
                foreach (GuildMember member in result.GuildMembers)
                {
                    ArmoryTask task = new ArmoryTask();
                    task.ArmoryRetrieveStatusChanged += new ArmoryTask.ArmoryRetrieveStatusEventHandler(OnArmoryTaskStatusChanged);
                    //task.ArmoryRetrieveProgressChanged += new ArmoryTask.ArmoryRetrieveProgressEventHandler(OnArmoryTaskProgressChanged);
                    task.StartArmoryCall(result.RealmName, member.Character.Name, cbIncludeAudit.Checked);
                } 
                
            }
            else
            {
                _membersToProcess = 0;
                toolStripProgressBar1.Maximum = 1;
                tsslResultCount.Text = armoryResults.Count.ToString();
                tsslResultCount.Visible = true;
                tsslResultsText.Visible = true;
                toolStripProgressBar1.Visible = false;
                gbSearchOptions.Enabled = true;
            }



        }

        #endregion

        private void btnAudit_Click(object sender, EventArgs e)
        {
            string queryType = string.Empty;
            if (rbCharacter.Checked)
            {
                ExecuteCharacterAudit(tbRealm.Text, tbName.Text);
                queryType = "C";
            }
            else
            {
                ExecuteGuildAudit(tbRealm.Text, tbName.Text, (int)nudMinLevel.Value);
                queryType = "G";
            }

            AddQueryToHistory(tbRealm.Text, tbName.Text, (int)nudMinLevel.Value, (int)nudMinILevel.Value, cbMatchILevel.Checked, cbIncludeAudit.Checked, cbIncludeAlts.Checked, cbLabels.SelectedItem.ToString(),  queryType);
        }

        #region Audit Calls
        private void ExecuteCharacterAudit(string realm, string name)
        {

            string[] charNames = ParseCharacterQuery(name);

            tsslResultCount.Visible = false;
            tsslResultsText.Visible = false;

            armoryResults = new List<ArmoryCharacterResult>();
            armoryResults.Clear();

            _membersToProcess = charNames.Length;

            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Step = 1;
            toolStripProgressBar1.Minimum = 0;
            toolStripProgressBar1.Maximum = _membersToProcess;
            toolStripProgressBar1.Visible = true;

            for (int i = 0; i < charNames.Length; i++)
            {
                ArmoryTask task = new ArmoryTask();
                task.ArmoryRetrieveStatusChanged += new ArmoryTask.ArmoryRetrieveStatusEventHandler(OnArmoryTaskStatusChanged);
                //task.ArmoryRetrieveProgressChanged += new ArmoryTask.ArmoryRetrieveProgressEventHandler(OnArmoryTaskProgressChanged);
                task.StartArmoryCall(realm, charNames[i], cbIncludeAudit.Checked);                            
            }

        }

        private void ExecuteGuildAudit(string realm, string name, int minLevel)
        {
            tsslResultCount.Visible = false;
            tsslResultsText.Visible = false;

            armoryResults = new List<ArmoryCharacterResult>();
            armoryResults.Clear();
            _membersToProcess = 0;

            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Step = 1;
            toolStripProgressBar1.Minimum = 0;
            toolStripProgressBar1.Visible = true;

            ArmoryGuildTask task = new ArmoryGuildTask();
            task.ArmoryRetrieveGuildStatusChanged += new ArmoryGuildTask.ArmoryRetrieveGuildStatusEventHandler(OnArmoryGuildTaskStatusChanged);
            task.StartArmoryCall(realm, name, minLevel);
        }
        #endregion

        #region Enter key event
        private void tbCharacterAudit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { btnAudit.PerformClick(); }
        }

        #endregion

        #region Menu Bar Events

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOptions options = new frmOptions();
            options.SettingsSaveEvent += options_SettingsSaveEvent;
            options.ShowDialog();
        }

        void options_SettingsSaveEvent(object sender, EventArgs e)
        {
            ReadSettings();

            /*
            // Trim history if setting is < history entries currently saved
            if (Settings.Default["RECENT_QUERIES"] != null && Settings.Default["HISTORY_ENTRIES"] != null)
            {
                System.Collections.Specialized.StringCollection history =
                    (System.Collections.Specialized.StringCollection)Settings.Default["RECENT_QUERIES"];

                if (history.Count > (int) Settings.Default["HISTORY_ENTRIES"])
                {
                    TrimHistory();
                }
            }
             */
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Query History

        private void TrimHistory()
        {
            System.Collections.Specialized.StringCollection history =
                (System.Collections.Specialized.StringCollection)Settings.Default["RECENT_QUERIES"];

            for (int i = 0; i < history.Count; i++)
            {
                if (i > (history.Count - 1))
                {                    
                    history.RemoveAt(i);
                }
            }

            Settings.Default["RECENT_QUERIES"] = history;
            Settings.Default.Save();

            //LoadQueryHistory();            
        }

        private string[] ParseCharacterQuery(string s)
        {
            if (!String.IsNullOrEmpty(s))
            {
                string[] charNames = s.Replace(" ", "").Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                return charNames;
            }

            return null;
        }

        private string MakeHistoryMenuItem(string entry, out string toolTipText)
        {
            toolTipText = string.Empty;
            string[] pieces = entry.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            if (pieces.Length != 9)
            {
                return string.Empty;
            }

            if (pieces[8].Equals("C"))
            {
                string[] charNames = ParseCharacterQuery(pieces[1]);
                if (charNames.Length > 1)
                {
                    toolTipText = pieces[1].Replace(" ", "");
                    return "Multiple Characters @" + pieces[0];
                }

                return "Character: " + pieces[1] + "@" + pieces[0];
            }

            return "Guild: " + pieces[1] + "@" + pieces[0];                
        }

        private void ExecuteHistorySearch(object sender, EventArgs e, string searchString)
        {
            string[] pieces = searchString.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            // If history is old format, dont execute and return
            if (pieces.Length != 9) { MessageBox.Show("Old format history item, please clear your history."); return; }

            tbRealm.Text = pieces[0];
            tbName.Text = pieces[1];
            nudMinLevel.Value = Int32.Parse(pieces[2]);
            nudMinILevel.Value = Int32.Parse(pieces[3]);
            cbMatchILevel.Checked = Boolean.Parse(pieces[4]);
            cbIncludeAudit.Checked = Boolean.Parse(pieces[5]);
            cbIncludeAlts.Checked = Boolean.Parse(pieces[6]);
            cbLabels.SelectedItem = pieces[7].ToString();

            if (pieces[8].Equals("C"))
            {
                rbCharacter.Checked = true;
                ExecuteCharacterAudit(pieces[0], pieces[1]);
            }
            else
            {
                rbGuild.Checked = true;
                ExecuteGuildAudit(pieces[0], pieces[1], (int)nudMinLevel.Value);
            }
        }

        private void AddQueryToHistory(string realm, string name, int level, int iLvl, bool matchILevel, bool includeCharAudit, bool includeAlts, string label, string type)
        {
            //
            if (Settings.Default["RECENT_QUERIES"] != null)
            {
                int maxHistory = 5;
                Int32.TryParse(Settings.Default["HISTORY_ENTRIES"].ToString(), out maxHistory);

                System.Collections.Specialized.StringCollection history = 
                    (System.Collections.Specialized.StringCollection)Settings.Default["RECENT_QUERIES"];

                string entry = realm + ";" + name.Replace(" ", "") + ";" + level + ";" + iLvl + ";" + matchILevel + ";" + includeCharAudit + ";" + includeAlts + ";" + label + ";"  + type;
                if (!history.Contains(entry))
                {
                    string toolTipText = string.Empty;
                    ToolStripMenuItem tsmi = new ToolStripMenuItem(MakeHistoryMenuItem(entry, out toolTipText));
                    tsmi.ToolTipText = toolTipText;
                    tsmi.Click += (sender, args) => ExecuteHistorySearch(sender, args, entry);

                    if(history.Count < maxHistory)
                    {
                        history.Add(entry);
                        historyToolStripMenuItem.DropDownItems.Insert(0, tsmi);
                    }
                    else
                    {
                        // History full, replace oldest
                        history.RemoveAt(0);
                        history.Add(entry);
                        historyToolStripMenuItem.DropDownItems.RemoveAt(maxHistory - 1);
                        historyToolStripMenuItem.DropDownItems.Insert(0, tsmi);
                    }
                }

                Settings.Default["RECENT_QUERIES"] = history;
                Settings.Default.Save();
            }
        }

        private void clearRecentHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear recent history

            while (historyToolStripMenuItem.DropDownItems.Count > 2)
            {
                historyToolStripMenuItem.DropDownItems.RemoveAt(0);
            }

            if (Settings.Default["RECENT_QUERIES"] != null)
            {
                ((System.Collections.Specialized.StringCollection)Settings.Default["RECENT_QUERIES"]).Clear();
                Settings.Default.Save();
            }
        }

        #endregion

        #region DB Calls

        private void StoreResults()
        {
            DbHistoryDal dal = new DbHistoryDal();

            foreach (ArmoryCharacterResult asr in armoryResults)
            {
                DataTable dt = dal.GetCharacterByNameRealm(asr.CharacterName, asr.RealmName);

                //MessageBox.Show(dal.IsAlt(asr.CharacterName, asr.RealmName).ToString());

                int charId = -1;
                if(dt.Rows.Count < 1)
                {
                    charId = (int)dal.InsertCharacter(asr.CharacterName, asr.RealmName);                    
                }
                else
                {
                    charId = Int32.Parse(dt.Rows[0]["RowId"].ToString());
                }

                if (charId > 0)
                {
                    if (!dal.DoesCharacterHistoryExist(charId, DateTime.Today))
                    {
                        dal.InsertCharacterHistory(charId, asr.AverageILevel, asr.AverageEquippedILevel, DateTime.Today);
                    }
                }
                
            }            
        }

        #endregion

        private void rbGuild_CheckedChanged(object sender, EventArgs e)
        {
            lblQueryType.Text = rbGuild.Text;
        }

        private void rbCharacter_CheckedChanged(object sender, EventArgs e)
        {
            lblQueryType.Text = rbCharacter.Text;
        }

        private void folvResults_CellRightClick(object sender, CellRightClickEventArgs e)
        {
            if (e.Model != null)
            {
                _selectedCharacter = ((ArmoryCharacterResult) e.Model).CharacterName;

                DbHistoryDal dal = new DbHistoryDal();
                if (dal.IsAlt(_selectedCharacter, tbRealm.Text))
                {
                    contextMenuStrip1.Items[1].Text = "Unmark As Alt";
                }
                else
                {
                    contextMenuStrip1.Items[1].Text = "Mark As Alt";
                }

                this.toolStripComboBox1.SelectedIndexChanged -= this.toolStripComboBox1_SelectedIndexChanged;

                toolStripComboBox1.SelectedIndex = 0;
                DataTable character = dal.GetCharacterByNameRealm(_selectedCharacter, tbRealm.Text);
                if (character.Rows.Count > 0 && !String.IsNullOrEmpty(character.Rows[0]["Label"].ToString()))
                {
                    string label = character.Rows[0]["Label"].ToString();
                    toolStripComboBox1.SelectedItem = label;
                }

                this.toolStripComboBox1.SelectedIndexChanged += this.toolStripComboBox1_SelectedIndexChanged;

                e.MenuStrip = contextMenuStrip1;

            }
            //e.MenuStrip = this.DecideRightClickMenu(e.Model, e.Column);
        }

        private void viewHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _frmCharacterHistory.Realm = tbRealm.Text;
            _frmCharacterHistory.CharacterName = _selectedCharacter;
            _frmCharacterHistory.ShowDialog();
        }

        private void markAsAltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DbHistoryDal dal = new DbHistoryDal();
            if (dal.IsAlt(_selectedCharacter, tbRealm.Text))
            {
                dal.UpdateCharacterAltStatus(_selectedCharacter, tbRealm.Text, 0);
                contextMenuStrip1.Items[1].Text = "Mark As Alt";
            }
            else
            {
                dal.UpdateCharacterAltStatus(_selectedCharacter, tbRealm.Text, 1);
                contextMenuStrip1.Items[1].Text = "Unmark As Alt";
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbHistoryDal dal = new DbHistoryDal();
            string label = toolStripComboBox1.SelectedIndex == 0 ? string.Empty : toolStripComboBox1.SelectedItem.ToString();
            dal.UpdateCharacterLabel(_selectedCharacter, tbRealm.Text, label);
        }






    }
}
