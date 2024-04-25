using FinalProject.Objects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
        public void Sua<T>(T obj, string[] prop, string condition)
        {
            List<SqlParameter> parameters = Utility.GetParameters(obj, prop);
            string SQL = Utility.GenerateUpdateSql(tableName, parameters, condition);
            MessageBox.Show(SQL);
            db.ThucThi(SQL, parameters);
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
        public DataTable Load()
        {
            string SQL = string.Format($"SELECT *FROM {TableName}");
            return db.Load(SQL);
        }

    }
}
