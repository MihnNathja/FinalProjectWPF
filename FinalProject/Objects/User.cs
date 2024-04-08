using FinalProject.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProject.Objects
{
    public class User
    {
        UserDAO userDAO;
        private string iD;
        private string userName;
        private string password;
        private string type;
        public User() { }
        public User(string userName, string password)
        {
            //this.iD = userDAO.GetID();
            this.userName = userName;
            this.password = password;
        }


        protected string ID { get => iD; set => iD = value; }
        protected string UserName { get => userName; set => userName = value; }
        protected string Password { get => password; set => password = value; }
        public string Type { get => type; set => type = value; }

    }
}