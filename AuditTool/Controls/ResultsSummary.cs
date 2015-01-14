using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AuditTool.Controls
{
    public partial class ResultsSummary : UserControl
    {
        private int _resultCount = 0;

        public int ResultCount
        {
            set { this._resultCount = value;
                lblNumResults.Text = value.ToString();
            }
            get { return this._resultCount; }
        }

        public ResultsSummary()
        {
            InitializeComponent();
        }
    }
}
