using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AuditTool.Classes;

namespace AuditTool.Forms
{
    public partial class frmCharacterHistory : Form
    {
        private string _characterName;
        private string _realm;


        public string CharacterName { get; set; }
        public string Realm { get; set; }

        public frmCharacterHistory()
        {
            InitializeComponent();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCharacterHistory_VisibleChanged(object sender, EventArgs e)
        {
            lblCharName.Text = this.CharacterName;
            lblRealm.Text = this.Realm;

            DbHistoryDal dal = new DbHistoryDal();
            DataTable dt = dal.GetCharacterByNameRealm(this.CharacterName, this.Realm);
            if (dt != null && dt.Rows.Count > 0)
            {
                int charId = Int32.Parse(dt.Rows[0]["RowId"].ToString());
                List<WowCharacterHistory> history = dal.GetCharacterHistory(charId);


                olvColumn1.AspectGetter = delegate(object row) { return ((WowCharacterHistory)row).DateScanned.ToString("yyyy-MM-dd"); };
                olvColumn2.AspectGetter = delegate(object row) { return ((WowCharacterHistory)row).AverageILevel; };

                fdlvHistory.SetObjects(history);
                

            }
        }
    }
}
