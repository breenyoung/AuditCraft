using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuditTool.Classes
{
    public class WowCharacterHistory
    {
        public long CharacterId { get; set; }
        public long AverageILevel { get; set; }
        public long AverageEquippedILevel { get; set; }
        public DateTime DateScanned { get; set; }
    }
}
