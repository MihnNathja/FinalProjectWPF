using FinalProject.Objects;
using FinalProject.Pages;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace FinalProject.Database
{
    public class UserDAO
    {
        DBConnections db = new DBConnections();
        public UserDAO() { }
        public string GetID(string TableName)
        {
            // chỗ này sau khi có database của user sẽ tiến hành lấy thông tin từ bảng rồi tạo một id mới
            return (Int32.Parse(Utility.GenerateGetID(TableName))).ToString();
        }
        public string GenerateID(string TableName)
        {
            if(Utility.GenerateGetID(TableName) == null)
            {
                return "1";
            }    
            return (Int32.Parse(Utility.GenerateGetID(TableName)) + 1).ToString();
        }
        public bool checkExist(User user)
        {
            string SQL = $"SELECT Count(*) FROM  {user.TableName}  WHERE UserName = '{user.UserName}' and Password = '{user.Password}' and Type = '{user.Type}'";
            if (Convert.ToInt32(db.GetValue(SQL)) > 0)
            {
                return true;
            }
            return false;
        }
        public T GetUser <T>(T person,User user)
        {
            string SQL = $"SELECT* FROM  {user.TableName}  WHERE UserName = '{user.UserName}' and Password = '{user.Password}' and Type = '{user.Type}'";
            DataTable data = db.Load(SQL);
            DataRow row = data.Rows[0];
            PropertyInfo[] properties = typeof(T).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (property.Name != "TableName")
                {
                    property.SetValue(person, row[property.Name], null);
                }
            }
            return person;
        }
    }
}
