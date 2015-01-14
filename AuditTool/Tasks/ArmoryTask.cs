using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuditTool.Classes;
using AuditTool.Properties;

namespace AuditTool.Tasks
{
    public class ArmoryTask
    {
        private ArmoryStatus _testState;

        private delegate ArmoryCharacterResult ArmoryTaskDelegate(string realm, string characterName, bool includeAudit);
        public delegate void ArmoryRetrieveStatusEventHandler(object sender, ArmoryRetrieveEventArgs e);
        public delegate void ArmoryRetrieveProgressEventHandler(object sender, ArmoryRetrieveEventArgs e);


        public event ArmoryRetrieveStatusEventHandler ArmoryRetrieveStatusChanged;
        public event ArmoryRetrieveProgressEventHandler ArmoryRetrieveProgressChanged;

        public void StartArmoryCall(string realm, string characterName, bool includeAudit)
        {
            lock (this)
            {
                if (_testState == ArmoryStatus.NotRetrieving)
                {
                    // Create a delegate to the test method.
                    ArmoryTaskDelegate utd = new ArmoryTaskDelegate(GetCharacter);

                    // Start the test.
                    utd.BeginInvoke(realm, characterName, includeAudit, new AsyncCallback(EndArmoryTask), utd);

                    // Update the calculation status.
                    _testState = ArmoryStatus.Retrieving;

                    // Fire a status changed event.
                    FireStatusChangedEvent(_testState, null);
                }
            }            
        }

        public void StopArmoryCall()
        {
            lock (this)
            {
                if (_testState == ArmoryStatus.Retrieving)
                {
                    // Update the calculation status.
                    _testState = ArmoryStatus.CancelPending;

                    // Fire a status changed event.
                    FireStatusChangedEvent(_testState, null);
                }
            }            
        }

        private void FireStatusChangedEvent(ArmoryStatus status, ArmoryCharacterResult ur)
        {
            if (ArmoryRetrieveStatusChanged != null)
            {
                ArmoryRetrieveEventArgs args = new ArmoryRetrieveEventArgs(status);
                if (ur != null) { args.Result = ur; }

                if (ArmoryRetrieveStatusChanged.Target is System.Windows.Forms.Control)
                {
                    System.Windows.Forms.Control targetForm = ArmoryRetrieveStatusChanged.Target as System.Windows.Forms.Control;
                    targetForm.Invoke(ArmoryRetrieveStatusChanged, new object[] { this, args });
                }
                else
                {
                    ArmoryRetrieveStatusChanged(this, args);
                }
            }            
        }

        private void FireProgressChangedEvent(int progress)
        {
            if (ArmoryRetrieveProgressChanged != null)
            {
                ArmoryRetrieveEventArgs args = new ArmoryRetrieveEventArgs(progress);
                if (ArmoryRetrieveProgressChanged.Target is System.Windows.Forms.Control)
                {
                    System.Windows.Forms.Control targetForm = ArmoryRetrieveProgressChanged.Target as System.Windows.Forms.Control;
                    targetForm.Invoke(ArmoryRetrieveProgressChanged, new object[] { this, args });
                }
                else
                {
                    ArmoryRetrieveProgressChanged(this, args);
                }
            }            
        }


        private ArmoryCharacterResult GetCharacter(string realm, string characterName, bool includeAudit)
        {
            WowDotNetAPI.Region region = WowDotNetAPI.Region.US;                            
            WowDotNetAPI.Region.TryParse(Settings.Default["REGION"].ToString(), true, out region);

            WowdotnetDal dal = new WowdotnetDal(region);
            ArmoryCharacterResult result = dal.GetCharacter(realm, characterName);
            
            if (result != null && includeAudit)
            {
                ArmoryScraper scraper = new ArmoryScraper();
                result.HasPassedAudit 
                    = scraper.GetCharacterAuditResult(String.Format(ConfigurationManager.AppSettings["CHARACTER_URL"], realm,
                                                              characterName, Settings.Default["REGION"].ToString().ToLower()));
            }

            FireProgressChangedEvent(1);

            return result;
        }

        private void EndArmoryTask(IAsyncResult ar)
        {
            ArmoryTaskDelegate del = (ArmoryTaskDelegate)ar.AsyncState;
            ArmoryCharacterResult result = del.EndInvoke(ar);

            lock (this)
            {
                _testState = ArmoryStatus.NotRetrieving;
                FireStatusChangedEvent(_testState, result);
            }            
        }

    }

    #region UrlTestEventArgs EventArg
    public class ArmoryRetrieveEventArgs : EventArgs
    {
        public ArmoryCharacterResult Result;
        public int Progress;
        public ArmoryStatus Status;

        public ArmoryRetrieveEventArgs(int progress)
        {
            this.Progress = progress;
            this.Status = ArmoryStatus.Retrieving;
        }

        public ArmoryRetrieveEventArgs(ArmoryStatus status)
        {
            this.Status = status;
        }
    }
    #endregion

    #region ArmoryStatus Enum
    public enum ArmoryStatus
    {
        NotRetrieving,
        Retrieving,
        CancelPending
    }
    #endregion

}
