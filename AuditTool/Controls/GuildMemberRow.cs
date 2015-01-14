using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AuditTool.Controls
{
    public partial class GuildMemberRow : UserControl
    {
        
        private string realm = string.Empty;

        public string MemberImage
        {
            set { pbAvatar.ImageLocation = value; }
        }

        public string ClassImage
        {
            set { pbClass.ImageLocation = value; }
        }

        public string Realm
        {
            set { this.realm = value; }
            get { return this.realm; }
        }

        public string MemberName 
        {
            get { return llName.Text; }
            set { llName.Text = value; }
        }                

        public string AverageILevel
        {
            set { lblAverageILevel.Text = value; }
        }

        public string AverageILevelEquipped
        {
            set { lblAverageILevelEquipped.Text = String.Format(lblAverageILevelEquipped.Text, value); }
        }

        public Color AverageILevelColor
        {
            set { lblAverageILevel.ForeColor = value; }
        }

        public bool ShowAudit
        {
            set { pbAuditResult.Visible = value; }
            get { return pbAuditResult.Visible; }
        }

        public string AuditImage
        {
            set { pbAuditResult.ImageLocation = value; }
        }

        public GuildMemberRow()
        {
            InitializeComponent();
        }

        private void llName_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(String.Format(ConfigurationManager.AppSettings["CHARACTER_URL"],
                                                           this.realm, this.MemberName));
        }
    }
}
