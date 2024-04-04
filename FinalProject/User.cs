using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalProject
{
    public abstract class User
    {
        private string name;
        private string phoneNumber;
        private string userName;
        private string password;
        private string location;
        private string type;
        public User() { }
        protected User(string userName, string password, string name, string phoneNumber, string location)
        {
            this.userName = userName;
            this.password = password;
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.location = location;
        }

        public string Name { get => name; set => name = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password;}
        public string Location { get => location; set => location = value; }
        public string Type { get => type; set => type = value; }
    }
}