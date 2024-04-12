using FinalProject.Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Database
{
    public class ObjectDAO
    {
        DBConnections db = new DBConnections();
        DataTable dataJob;
        string tableName;
        public DataTable DataJob { get => dataJob; set => dataJob = value; }
        public string TableName { get => tableName; set => tableName = value; }

        public ObjectDAO()
        {

        }
        public void Them<T>(T obj, string[] prop)
        {
            List<SqlParameter> parameters = Utility.GetParameters(obj, prop);
            string SQL = Utility.GenerateInsertSql(TableName, parameters);
            db.ThucThi(SQL, parameters);
        }
        public void Xoa<T>(T obj, string[] prop)
        {
            List<SqlParameter> parameter = Utility.GetParameters(obj, prop);
            string SQL = Utility.GenerateDeleteSql(TableName, parameter);
            db.ThucThi(SQL, parameter);
        }
        public void Sua<T>(T obj, string[] prop)
        {
            string condition = "ID = ";
            List<SqlParameter> parameters = Utility.GetParameters(obj, prop);
            string SQL = Utility.GenerateUpdateSql(tableName, parameters, condition);
            db.ThucThi(SQL, parameters);
           /* string SQL = string.Format("UPDATE Jobs SET Name = '{1}', CompanyName = '{2}', Salary = '{3}', Location = '{4}' WHERE ID = {0}", job.Id, job.JobName, job.CompanyName, job.Salary, job.JobLocation);*/
        }
        public string GetID()
        {
            string SQL = string.Format($"SELECT MAX(ID) FROM {TableName}");
            return db.GetValue(SQL).ToString();
        }
        public string GetNextID()
        {
            string SQL = string.Format($"SELECT MAX(ID) FROM {TableName}");
            return (db.GetValue(SQL) + 1).ToString();
        }

    }
}
