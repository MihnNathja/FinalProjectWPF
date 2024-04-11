using FinalProject.Objects;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
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
        public void Xoa(Job job)
        {
            string[] prop = { };
            List<SqlParameter> parameter = Utility.GetParameters(job, prop);
            string SQL = Utility.GenerateDeleteSql(tableName, parameter);

            db.ThucThi(SQL, parameter);
        }

        public CV GetObject(string id)
        {
            string SQL = string.Format("SELECT * FROM CV WHERE IdCV = '{0}'", id);
            DataTable data = db.Load(SQL);
            CV cV = new CV(id);
            DataRow row = data.Rows[0];
            PropertyInfo[] properties = typeof(CV).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                property.SetValue(cV, row[property.Name].ToString(), null);
            }
            return cV;
        }

        public List<UCCV> LoadPage()
        {
            int index = 0;

            List<UCCV> list = new List<UCCV>();

            DataTable cvTable = DataCV;
            foreach (DataRow row in cvTable.Rows)
            {
                UCCV cv = new UCCV();
                cv.tbSTT.Text = (index + 1).ToString();
                cv.tbCVTitle.Text = row["CVTitle"].ToString();
                
                
                list.Add(cv);
            }
            return list;
        }
    }
}
