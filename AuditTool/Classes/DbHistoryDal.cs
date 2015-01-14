using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SQLite;
using System.Threading;
using AuditTool.Controls;

namespace AuditTool.Classes
{
    public class DbHistoryDal : IHistoryDal
    {
        private string _dbConnection = string.Empty;

        public DbHistoryDal()
        {
            _dbConnection = ConfigurationManager.AppSettings["CONN_STRING"];
        }


        public bool DoesCharacterExist(string characterName, string realm)
        {
            bool result = false;

            string sql = String.Format("SELECT COUNT(*) FROM Characters WHERE Name = '{0}' AND Realm = '{1}'", characterName, realm);

            SQLiteConnection conn = this.GetConnection();
            string returnVal = this.ExecuteScalar(conn, sql);
            if (!String.IsNullOrEmpty(returnVal) && returnVal.Equals("1"))
            {
                result = true;
            }

            return result;
        }

        public bool DoesCharacterHistoryExist(int id, DateTime date)
        {
            bool result = false;
            string sql = String.Format("SELECT * FROM CharacterHistory WHERE CharacterId = {0} AND DateScanned = '{1}'", id, date.ToString("yyyy-MM-dd"));
            
            SQLiteConnection conn = this.GetConnection();
            DataTable dt = this.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                result = true;
            }

            return result;
        }

        public DataTable GetCharacterById(int id)
        {
            string sql = String.Format("SELECT * FROM Characters WHERE RowId = {0}", id);
            DataTable dt = this.GetDataTable(sql);

            return dt;
        }

        public DataTable GetCharacterByNameRealm(string characterName, string realm)
        {
            string sql = String.Format("SELECT * FROM Characters WHERE Name = '{0}' AND Realm = '{1}'", characterName, realm);
            DataTable dt = this.GetDataTable(sql);

            return dt;            
        }

        public bool IsAlt(int id)
        {
            bool result = false;

            DataTable dt = this.GetCharacterById(id);
            if (dt.Rows.Count == 1)
            {
                if ((long) dt.Rows[0]["IsAlt"] == 1)
                {
                    result = true;
                }
            }

            return result;
        }

        public bool IsAlt(string characterName, string realm)
        {
            bool result = false;

            DataTable dt = this.GetCharacterByNameRealm(characterName, realm);
            if (dt.Rows.Count == 1)
            {
                if ((long)dt.Rows[0]["IsAlt"] == 1)
                {
                    result = true;
                }
            }

            return result;            
        }

        public bool HasLabel(int id, string label)
        {
            bool result = false;

            DataTable dt = this.GetCharacterById(id);
            if (dt.Rows.Count == 1)
            {
                if (dt.Rows[0]["Label"].ToString().Equals(label))
                {
                    result = true;
                }
            }

            return result;            
        }

        public bool HasLabel(string characterName, string realm, string label)
        {
            bool result = false;

            DataTable dt = this.GetCharacterByNameRealm(characterName, realm);
            if (dt.Rows.Count == 1)
            {
                if (dt.Rows[0]["Label"].ToString().Equals(label))
                {
                    result = true;
                }
            }

            return result;              
        }

        public int ClearLabel(string label)
        {
            Dictionary<String, String> data = new Dictionary<String, String>();
            data.Add("Label", string.Empty);

            try
            {
                SQLiteConnection conn = this.GetConnection();
                string sql = this.MakeUpdateSql("Characters", data, "Label = '" + label + "'");
                using (conn)
                {
                    conn.Open();
                    SQLiteCommand mycommand = new SQLiteCommand(conn);
                    mycommand.CommandText = sql;
                    int rowsAffected = mycommand.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }              
        }

        public long InsertCharacter(string characterName, string realm)
        {
            Dictionary<String, String> data = new Dictionary<String, String>();
            data.Add("Name", characterName);
            data.Add("Realm", realm);
            data.Add("IsAlt", "0");

            try
            {
                SQLiteConnection conn = this.GetConnection();
                string sql = this.MakeInsertSql("Characters", data);
                using (conn)
                {
                    conn.Open();
                    SQLiteCommand mycommand = new SQLiteCommand(conn);
                    mycommand.CommandText = sql;
                    mycommand.ExecuteNonQuery();
                    return conn.LastInsertRowId;
                }                
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }

        public int UpdateCharacterAltStatus(long id, long isAlt)
        {
            Dictionary<String, String> data = new Dictionary<String, String>();
            data.Add("IsAlt", isAlt.ToString());

            try
            {
                SQLiteConnection conn = this.GetConnection();
                string sql = this.MakeUpdateSql("Characters", data, "RowId = " + id);
                using (conn)
                {
                    conn.Open();
                    SQLiteCommand mycommand = new SQLiteCommand(conn);
                    mycommand.CommandText = sql;
                    int rowsAffected = mycommand.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }

        public int UpdateCharacterAltStatus(string characterName, string realm, long isAlt)
        {
            DataTable dt = this.GetCharacterByNameRealm(characterName, realm);
            if (dt != null && dt.Rows.Count == 1)
            {
                return this.UpdateCharacterAltStatus((long) dt.Rows[0]["RowId"], isAlt);
            }

            return -1;
        }

        public int UpdateCharacterLabel(long id, string label)
        {
            Dictionary<String, String> data = new Dictionary<String, String>();
            data.Add("Label", label);

            try
            {
                SQLiteConnection conn = this.GetConnection();
                string sql = this.MakeUpdateSql("Characters", data, "RowId = " + id);
                using (conn)
                {
                    conn.Open();
                    SQLiteCommand mycommand = new SQLiteCommand(conn);
                    mycommand.CommandText = sql;
                    int rowsAffected = mycommand.ExecuteNonQuery();
                    return rowsAffected;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }             
        }

        public int UpdateCharacterLabel(string characterName, string realm, string label)
        {
            DataTable dt = this.GetCharacterByNameRealm(characterName, realm);
            if (dt != null && dt.Rows.Count == 1)
            {
                return this.UpdateCharacterLabel((long)dt.Rows[0]["RowId"], label);
            }

            return -1;            
        }

        public int DeleteCharacter(int id)
        {
            SQLiteConnection conn = this.GetConnection();
            this.Delete(conn, "Characters", String.Format("RowId = {0}", id));
            this.Delete(conn, "CharacterHistory", String.Format("CharacterId = {0}", id));

            return 1;
        }

        public int InsertCharacterHistory(int id, int iLevel, int equippedILevel, DateTime dateScanned)
        {
            Dictionary<String, String> data = new Dictionary<String, String>();
            data.Add("CharacterId", id.ToString());
            data.Add("AverageILevel", iLevel.ToString());
            data.Add("AverageEquippedILevel", equippedILevel.ToString());
            data.Add("DateScanned", dateScanned.ToString("yyyy-MM-dd"));

            try
            {
                SQLiteConnection conn = this.GetConnection();
                conn.Open();
                string sql = this.MakeInsertSql("CharacterHistory", data);
                using (conn)
                {
                    SQLiteCommand mycommand = new SQLiteCommand(conn);
                    mycommand.CommandText = sql;
                    int rowsAffected = mycommand.ExecuteNonQuery();
                    return rowsAffected;
                }                                 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteCharacterHistory(int id)
        {
            SQLiteConnection conn = this.GetConnection();
            this.Delete(conn, "CharacterHistory", String.Format("CharacterId = {0}", id));

            return 1;
        }

        public List<WowCharacterHistory> GetCharacterHistory(int id)
        {
            string sql = String.Format("SELECT * FROM CharacterHistory WHERE CharacterId = {0} ORDER BY DateScanned", id);
            DataTable dt = this.GetDataTable(sql);

            List<WowCharacterHistory> history = new List<WowCharacterHistory>();
            foreach (DataRow r in dt.Rows)
            {
                WowCharacterHistory wch = new WowCharacterHistory();
                wch.CharacterId = (long)r["CharacterId"];                
                wch.AverageILevel = (long)r["AverageILevel"];
                wch.AverageEquippedILevel = (long)r["AverageEquippedILevel"];
                wch.DateScanned = (DateTime)r["DateScanned"];
                history.Add(wch);
            }

            return history;
        }

        public bool ClearTable(String table)
        {
            try
            {
                SQLiteConnection conn = this.GetConnection();
                this.ExecuteNonQuery(conn, String.Format("delete from {0};", table));
                return true;
            }
            catch
            {
                return false;
            }
        } 

        public bool ClearDB()
        {
            DataTable tables;
            try
            {
                tables = this.GetDataTable("select NAME from SQLITE_MASTER where type='table' order by NAME;");
                foreach (DataRow table in tables.Rows)
                {
                    this.ClearTable(table["NAME"].ToString());
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        #region Private SQLite Methods

        private SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(_dbConnection);
        }

        private int ExecuteNonQuery(SQLiteConnection cnn, string sql)
        {
            using (cnn)
            {
                cnn.Open();

                SQLiteCommand mycommand = new SQLiteCommand(cnn);
                mycommand.CommandText = sql;
                
                int rowsUpdated = mycommand.ExecuteNonQuery();

                return rowsUpdated;
            }
        }

        private string ExecuteScalar(SQLiteConnection cnn, string sql)
        {
            using (cnn)
            {                
                cnn.Open();

                SQLiteCommand mycommand = new SQLiteCommand(cnn);
                mycommand.CommandText = sql;

                object value = mycommand.ExecuteScalar();             
                if (value != null)
                {
                    return value.ToString();
                }

                return "";
            }
        }

        private DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SQLiteConnection cnn = new SQLiteConnection(_dbConnection);
                cnn.Open();
                SQLiteCommand mycommand = new SQLiteCommand(cnn);
                mycommand.CommandText = sql;
                SQLiteDataReader reader = mycommand.ExecuteReader();
                dt.Load(reader);
                reader.Close();
                cnn.Close();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return dt;
        }

        
        private string MakeUpdateSql(String tableName, Dictionary<String, String> data, String where)
        {
	        String vals = "";
	        Boolean returnCode = true;
	        if (data.Count >= 1)
	        {
	            foreach (KeyValuePair<String, String> val in data)
	            {
	                vals += String.Format(" {0} = '{1}',", val.Key.ToString(), val.Value.ToString());
	            }
	            vals = vals.Substring(0, vals.Length - 1);
	        }

            return String.Format("update {0} set {1} where {2};", tableName, vals, where);
        }
        

        private string MakeInsertSql(String tableName, Dictionary<String, String> data)
        {
            String columns = "";
            String values = "";
            Boolean returnCode = true;
            foreach (KeyValuePair<String, String> val in data)
            {
                columns += String.Format(" {0},", val.Key.ToString());
                values += String.Format(" '{0}',", val.Value);
            }

            columns = columns.Substring(0, columns.Length - 1);
            values = values.Substring(0, values.Length - 1);

            return String.Format("insert into {0}({1}) values({2});", tableName, columns, values);
        }

        private int Delete(SQLiteConnection cnn, String tableName, String where)
        {
            int rowsAffected = 0;
            try
            {
                rowsAffected = this.ExecuteNonQuery(cnn, String.Format("delete from {0} where {1};", tableName, where));
            }
            catch (Exception fail)
            {
                rowsAffected = -1;
            }

            return rowsAffected;
        }

        #endregion
    }
}
