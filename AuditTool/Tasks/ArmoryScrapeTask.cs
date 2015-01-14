using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AuditTool.Classes;

namespace AuditTool.Tasks
{
    public class ArmoryScrapeTask
    {

        private ArmoryScrapeStatus _testState;

        private delegate ArmoryScrapeResult ArmoryScrapeTaskDelegate(string url);
        public delegate void ArmoryRetrieveScrapeStatusEventHandler(object sender, ArmoryScrapePageEventArgs e);
        public delegate void ArmoryRetrieveScrapeProgressEventHandler(object sender, ArmoryScrapePageEventArgs e);


        public event ArmoryRetrieveScrapeStatusEventHandler ArmoryRetrieveScrapeStatusChanged;
        public event ArmoryRetrieveScrapeProgressEventHandler ArmoryRetrieveScrapeProgressChanged;

        public void StartArmoryCall(string url)
        {
            lock (this)
            {
                if (_testState == ArmoryScrapeStatus.NotRetrieving)
                {
                    // Create a delegate to the test method.
                    ArmoryScrapeTaskDelegate utd = new ArmoryScrapeTaskDelegate(GetPage);

                    // Start the test.
                    utd.BeginInvoke(url, new AsyncCallback(EndArmoryTask), utd);

                    // Update the calculation status.
                    _testState = ArmoryScrapeStatus.Retrieving;

                    // Fire a status changed event.
                    FireStatusChangedEvent(_testState, null);
                }
            }            
        }

        public void StopArmoryCall()
        {
            lock (this)
            {
                if (_testState == ArmoryScrapeStatus.Retrieving)
                {
                    // Update the calculation status.
                    _testState = ArmoryScrapeStatus.CancelPending;

                    // Fire a status changed event.
                    FireStatusChangedEvent(_testState, null);
                }
            }            
        }

        private void FireStatusChangedEvent(ArmoryScrapeStatus status, ArmoryScrapeResult ur)
        {
            if (ArmoryRetrieveScrapeStatusChanged != null)
            {
                ArmoryScrapePageEventArgs args = new ArmoryScrapePageEventArgs(status);
                if (ur != null) { args.Result = ur; }

                if (ArmoryRetrieveScrapeStatusChanged.Target is System.Windows.Forms.Control)
                {
                    System.Windows.Forms.Control targetForm = ArmoryRetrieveScrapeStatusChanged.Target as System.Windows.Forms.Control;
                    targetForm.Invoke(ArmoryRetrieveScrapeStatusChanged, new object[] { this, args });
                }
                else
                {
                    ArmoryRetrieveScrapeStatusChanged(this, args);
                }
            }            
        }

        private void FireProgressChangedEvent(int progress)
        {
            if (ArmoryRetrieveScrapeProgressChanged != null)
            {
                ArmoryScrapePageEventArgs args = new ArmoryScrapePageEventArgs(progress);
                if (ArmoryRetrieveScrapeProgressChanged.Target is System.Windows.Forms.Control)
                {
                    System.Windows.Forms.Control targetForm = ArmoryRetrieveScrapeProgressChanged.Target as System.Windows.Forms.Control;
                    targetForm.Invoke(ArmoryRetrieveScrapeProgressChanged, new object[] { this, args });
                }
                else
                {
                    ArmoryRetrieveScrapeProgressChanged(this, args);
                }
            }            
        }

        private void EndArmoryTask(IAsyncResult ar)
        {
            ArmoryScrapeTaskDelegate del = (ArmoryScrapeTaskDelegate)ar.AsyncState;
            ArmoryScrapeResult result = del.EndInvoke(ar);

            lock (this)
            {
                _testState = ArmoryScrapeStatus.NotRetrieving;
                FireStatusChangedEvent(_testState, result);
            }
        }


        private ArmoryScrapeResult GetPage(string url)
        {
            ArmoryScraper scraper = new ArmoryScraper();
            ArmoryScrapeResult result = scraper.GetCharacterAuditResult(url);

            FireProgressChangedEvent(1);

            return result;
        }
    }

    
    public class ArmoryScrapePageEventArgs : EventArgs
    {
        public ArmoryScrapeResult Result;
        public int Progress;
        public ArmoryScrapeStatus Status;

        public ArmoryScrapePageEventArgs(int progress)
        {
            this.Progress = progress;
            this.Status = ArmoryScrapeStatus.Retrieving;
        }

        public ArmoryScrapePageEventArgs(ArmoryScrapeStatus status)
        {
            this.Status = status;
        }
    }

    #region ArmoryScrapeStatus Enum
    public enum ArmoryScrapeStatus
    {
        NotRetrieving,
        Retrieving,
        CancelPending
    }
    #endregion
}
