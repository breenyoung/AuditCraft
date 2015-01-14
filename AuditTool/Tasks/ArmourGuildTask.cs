using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuditTool.Classes;
using AuditTool.Properties;
using WowDotNetAPI.Models;

namespace AuditTool.Tasks
{
    public class ArmoryGuildTask
    {
        private ArmoryGuildStatus _testState;

        private delegate ArmoryGuildResult ArmoryGuildTaskDelegate(string realm, string guildName, int minimumLevel);
        public delegate void ArmoryRetrieveGuildStatusEventHandler(object sender, ArmoryRetrieveGuildEventArgs e);
        public delegate void ArmoryRetrieveGuildProgressEventHandler(object sender, ArmoryRetrieveGuildEventArgs e);


        public event ArmoryRetrieveGuildStatusEventHandler ArmoryRetrieveGuildStatusChanged;
        public event ArmoryRetrieveGuildProgressEventHandler ArmoryRetrieveGuildProgressChanged;

        public void StartArmoryCall(string realm, string guildName, int minimumLevel)
        {
            lock (this)
            {
                if (_testState == ArmoryGuildStatus.NotRetrieving)
                {
                    // Create a delegate to the test method.
                    ArmoryGuildTaskDelegate utd = new ArmoryGuildTaskDelegate(GetGuild);

                    // Start the test.
                    utd.BeginInvoke(realm, guildName, minimumLevel, new AsyncCallback(EndArmoryTask), utd);

                    // Update the calculation status.
                    _testState = ArmoryGuildStatus.Retrieving;

                    // Fire a status changed event.
                    FireStatusChangedEvent(_testState, null);
                }
            }            
        }

        public void StopArmoryCall()
        {
            lock (this)
            {
                if (_testState == ArmoryGuildStatus.Retrieving)
                {
                    // Update the calculation status.
                    _testState = ArmoryGuildStatus.CancelPending;

                    // Fire a status changed event.
                    FireStatusChangedEvent(_testState, null);
                }
            }            
        }

        private void FireStatusChangedEvent(ArmoryGuildStatus status, ArmoryGuildResult ur)
        {
            if (ArmoryRetrieveGuildStatusChanged != null)
            {
                ArmoryRetrieveGuildEventArgs args = new ArmoryRetrieveGuildEventArgs(status);
                if (ur != null) { args.Result = ur; }

                if (ArmoryRetrieveGuildStatusChanged.Target is System.Windows.Forms.Control)
                {
                    System.Windows.Forms.Control targetForm = ArmoryRetrieveGuildStatusChanged.Target as System.Windows.Forms.Control;
                    targetForm.Invoke(ArmoryRetrieveGuildStatusChanged, new object[] { this, args });
                }
                else
                {
                    ArmoryRetrieveGuildStatusChanged(this, args);
                }
            }            
        }

        private void FireProgressChangedEvent(int progress)
        {
            if (ArmoryRetrieveGuildProgressChanged != null)
            {
                ArmoryRetrieveGuildEventArgs args = new ArmoryRetrieveGuildEventArgs(progress);
                if (ArmoryRetrieveGuildProgressChanged.Target is System.Windows.Forms.Control)
                {
                    System.Windows.Forms.Control targetForm = ArmoryRetrieveGuildProgressChanged.Target as System.Windows.Forms.Control;
                    targetForm.Invoke(ArmoryRetrieveGuildProgressChanged, new object[] { this, args });
                }
                else
                {
                    ArmoryRetrieveGuildProgressChanged(this, args);
                }
            }            
        }


        private ArmoryGuildResult GetGuild(string realm, string guildName, int minimumLevel)
        {
            WowDotNetAPI.Region region = WowDotNetAPI.Region.US;
            WowDotNetAPI.Region.TryParse(Settings.Default["REGION"].ToString(), true, out region);

            WowdotnetDal dal = new WowdotnetDal(region);

            ArmoryGuildResult result = dal.GetGuildMembers(realm, guildName, minimumLevel);
            
            FireProgressChangedEvent(1);

            return result;
        }

        private void EndArmoryTask(IAsyncResult ar)
        {
            ArmoryGuildTaskDelegate del = (ArmoryGuildTaskDelegate)ar.AsyncState;
            ArmoryGuildResult result = del.EndInvoke(ar);

            lock (this)
            {
                _testState = ArmoryGuildStatus.NotRetrieving;
                FireStatusChangedEvent(_testState, result);
            }            
        }

    }

    #region UrlTestEventArgs EventArg
    public class ArmoryRetrieveGuildEventArgs : EventArgs
    {
        public ArmoryGuildResult Result;
        public int Progress;
        public ArmoryGuildStatus Status;

        public ArmoryRetrieveGuildEventArgs(int progress)
        {
            this.Progress = progress;
            this.Status = ArmoryGuildStatus.Retrieving;
        }

        public ArmoryRetrieveGuildEventArgs(ArmoryGuildStatus status)
        {
            this.Status = status;
        }
    }
    #endregion

    #region ArmoryGuildStatus Enum
    public enum ArmoryGuildStatus
    {
        NotRetrieving,
        Retrieving,
        CancelPending
    }
    #endregion

}
