using FinalProject.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace FinalProject.Objects
{
    public class User
    {
        UserDAO userDAO = new UserDAO();
        private string iD;
        private string userName;
        private string password;
        private string type;
        private string tableName;
        public User() { }
        public User(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }
        public User(string userName, string password, string tableName)
        {
            TableName = tableName;
            this.userName = userName;
            this.password = password;
            this.iD = userDAO.GenerateID(TableName);
        }

        public string ID { get => iD; set => iD = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Type { get => type; set => type = value; }
        public string TableName { get => tableName; set => tableName = value; }
    }
}