using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using AuditTool.Tasks;

namespace AuditTool.Classes
{
    public class ArmoryScraper
    {
        private static Regex _reCharacterAudit = new Regex("This character passed the audit!", RegexOptions.Compiled);

        public bool GetCharacterAuditResult(string url)
        {
            bool result = false;

            NetworkUtils nu = new NetworkUtils();
            string pageContents = nu.GetWebpage(url);

            if (pageContents != "ERROR")
            {                
                Match auditMatch = _reCharacterAudit.Match(pageContents);
                if (auditMatch.Success)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
