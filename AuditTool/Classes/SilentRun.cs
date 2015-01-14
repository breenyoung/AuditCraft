using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Configuration;
using System.Text;
using AuditTool.Properties;
using AuditTool.Tasks;
using WowDotNetAPI.Models;

namespace AuditTool.Classes
{
    public class SilentRun
    {
        private string[] _args;
        private string _taskType = string.Empty;
        private int _membersToProcess = 0;
        private bool _includeCharacterAudit = false;

        public SilentRun(string[] args)
        {
            this._args = args;

            for (int i = 1; i < _args.Length; i++)
            {
                if (_args[i].ToLower().Contains("-scheduleguild"))
                {
                    this._taskType = "GAUDIT";
                }
            }                
        }

        public void Run()
        {
            switch (this._taskType)
            {
                case "GAUDIT":
                    ExecuteGuildAudit();
                    break;
            }
        }

        private void ExecuteGuildAudit()
        {
            for (int i = 1; i < _args.Length; i++)
            {
                if (_args[i].ToLower().Contains("-scheduleguild"))
                {
                    string[] argProps = this._args[i].Split(":".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                    if (argProps.Length == 2)
                    {
                        string[] searchParams = argProps[1].Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                        if (searchParams.Length == 3)
                        {
                            string realm = searchParams[0];
                            string guild = searchParams[1];
                            int minLevel = Int32.Parse(searchParams[2]);

                            WowDotNetAPI.Region region = WowDotNetAPI.Region.US;
                            WowDotNetAPI.Region.TryParse(Settings.Default["REGION"].ToString(), true, out region);

                            WowdotnetDal dal = new WowdotnetDal(region);

                            ArmoryGuildResult result = dal.GetGuildMembers(realm, guild, minLevel);
                            foreach (GuildMember member in result.GuildMembers)
                            {
                                ArmoryCharacterResult acr = dal.GetCharacter(realm, member.Character.Name);

                                DbHistoryDal historyDal = new DbHistoryDal();
                                DataTable dt = historyDal.GetCharacterByNameRealm(acr.CharacterName, acr.RealmName);
                                int charId = -1;
                                if (dt.Rows.Count < 1)
                                {
                                    charId = (int)historyDal.InsertCharacter(acr.CharacterName, acr.RealmName);
                                }
                                else
                                {
                                    charId = Int32.Parse(dt.Rows[0]["RowId"].ToString());
                                }

                                if (charId > 0)
                                {
                                    if (!historyDal.DoesCharacterHistoryExist(charId, DateTime.Today))
                                    {
                                        historyDal.InsertCharacterHistory(charId, acr.AverageILevel, acr.AverageEquippedILevel, DateTime.Today);
                                    }
                                }
                            }
                        }
                    }                
                }
            }
        }


    }
}
