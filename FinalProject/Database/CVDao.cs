using FinalProject.Objects;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Database
{
    internal class CVDAO
    {
        DBConnections db = new DBConnections();
        DataTable dataCV;
        string tableName = "CV";

        public DataTable DataCV { get => dataCV; set => dataCV = value; }
        public CVDAO()
        {
            dataCV = Load();
        }
        public DataTable Load()
        {
            string SQL = string.Format("SELECT *FROM CV");
            return db.Load(SQL);
        }
        public string GetID()
        {
            string SQL = string.Format("SELECT MAX(IdCV) FROM CV");
            return db.GetValue(SQL).ToString();
        }
        public string GetNextID()
        {
            string SQL = string.Format("SELECT MAX(IdCV) FROM CV");
            return (db.GetValue(SQL) + 1).ToString();
        }
        public void Them(CV cv)
        {
            string[] prop = { "" };
            List<SqlParameter> parameters = Utility.GetParameters(cv, prop);
            string SQL = Utility.GenerateInsertSql(tableName, parameters);
            db.ThucThi(SQL, parameters);
        }
       
    }
}
