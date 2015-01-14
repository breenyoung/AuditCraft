using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using AuditTool.Classes;
using AuditTool.Forms;

namespace AuditTool
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (IsRunningSilent())
            {
                Application.Run(new frmSilent());
            }
            else
            {
                Application.Run(new frmHome());    
            }            
        }

        private static bool IsRunningSilent()
        {            
            bool silentRun = false;

            string[] args = Environment.GetCommandLineArgs();
            for (int i = 1; i < args.Length; i++)
            {
                if (args[i].ToLower().Contains("-scheduleguild"))
                {
                    silentRun = true;
                }
            }

            return silentRun;
        }


    }
}
