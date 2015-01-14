using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WowDotNetAPI.Models;

namespace AuditTool.Tasks
{
    public class ArmoryCharacterResult
    {
        public string RealmName { get; set; }
        public string CharacterName { get; set; }
        public Character CharacterData { get; set; }
        public int Level { get; set; }
        public string Class { get; set; }
        public int AverageILevel { get; set; }
        public int AverageEquippedILevel { get; set; }
        public bool HasRequestEnded { get; set; }
        public bool HasPassedAudit { get; set; }
        public string Thumbnail { get; set; }

        public ArmoryCharacterResult()
        {
            this.HasRequestEnded = false;
        }
    }
}
