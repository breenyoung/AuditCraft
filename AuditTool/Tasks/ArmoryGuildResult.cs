using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WowDotNetAPI.Models;

namespace AuditTool.Tasks
{
    public class ArmoryGuildResult
    {
        public string RealmName { get; set; }
        public string GuildName { get; set; }
        public IEnumerable<GuildMember> GuildMembers { get; set; }
        public bool HasRequestEnded { get; set; }

        public ArmoryGuildResult()
        {
            this.HasRequestEnded = false;
        }
    }
}
