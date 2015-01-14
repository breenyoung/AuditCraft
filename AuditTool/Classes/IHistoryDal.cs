using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace AuditTool.Classes
{
    public interface IHistoryDal
    {
        bool DoesCharacterExist(string characterName, string realm);
        bool DoesCharacterHistoryExist(int id, DateTime date);
        DataTable GetCharacterById(int id);
        DataTable GetCharacterByNameRealm(string characterName, string realm);
        bool IsAlt(int id);
        bool IsAlt(string characterName, string realm);
        bool HasLabel(int id, string label);
        bool HasLabel(string characterName, string realm, string label);
        int ClearLabel(string label);
        long InsertCharacter(string characterName, string realm);
        int UpdateCharacterAltStatus(long id, long isAlt);
        int UpdateCharacterAltStatus(string characterName, string realm, long isAlt);
        int UpdateCharacterLabel(long id, string label);
        int UpdateCharacterLabel(string characterName, string realm, string label);
        int DeleteCharacter(int id);
        int InsertCharacterHistory(int id, int iLevel, int equippedILevel, DateTime dateScanned);
        int DeleteCharacterHistory(int id);
        List<WowCharacterHistory> GetCharacterHistory(int id);
        bool ClearTable(String table);
        bool ClearDB();

    }
}
