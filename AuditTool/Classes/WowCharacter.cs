using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuditTool.Classes
{
    public class WowCharacter
    {
        public string Name { get; set; }
        public string Guild { get; set; }
        public string Class { get; set; }
        public string Race { get; set; }
        public string Avatar { get; set; }
        public int AverageILevel { get; set; }
        public int AverageILevelEquipped { get; set; }
    }
}
