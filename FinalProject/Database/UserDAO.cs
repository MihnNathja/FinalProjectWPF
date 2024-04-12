﻿using FinalProject.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public string GetID()
        {
            // chỗ này sau khi có database của user sẽ tiến hành lấy thông tin từ bảng rồi tạo một id mới
            return (Int32.Parse(Utility.GenerateGetID("user"))).ToString();
        }
        public string GenerateID()
        {
            MessageBox.Show(Utility.GenerateGetID("Users"));
            if(Utility.GenerateGetID("Users") == null)
            {
                return "1";
            }    
            return (Int32.Parse(Utility.GenerateGetID("Users")) + 1).ToString();
        }
        public bool checkExist(User user)
        {
            string SQL = $"SELECT Count(*) FROM  Users  WHERE UserName = {user.UserName} and Password = {user.Password} and Type = {user.Type}";
            MessageBox.Show(SQL);
            if (db.GetValue(SQL) > 0)
            {
                return true;
            }
            return false;
        }
    }
}