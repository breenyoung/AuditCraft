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
    public partial class frmSilent : Form
    {
        public frmSilent()
        {
            InitializeComponent();

            SilentRun sr = new SilentRun(Environment.GetCommandLineArgs());
            sr.Run();
            Application.Exit();                

        }
    }
}
