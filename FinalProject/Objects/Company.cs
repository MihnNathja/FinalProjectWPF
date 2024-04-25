using System;
using FinalProject.Database;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Transactions;

namespace FinalProject.Objects
{
    public class Company : User
    {
        CompanyDAO companyDAO = new CompanyDAO();
        string companyName;
        string mst;
        string boss;
        string companyLocation;
        string phoneNumber;
        string email;
        string field;
        string description;
        public Company() 
        : base()
        {
            Type = "Company";
            TableName = "Companies";
        }
        public Company(string userName, string password)
        : base (userName, password)
        {
            Type = "Company"; 
            TableName = "Companies";
        }
        public Company(string userName, string password, string companyName, string mst, string companyLocation, string boss, string phoneNumber)
        : base ( userName, password, "Companies")
        {   
            Type = "Company";
            CompanyName = companyName;
            CompanyLocation = companyLocation;
            Mst = mst;
            Boss = boss;
            PhoneNumber = phoneNumber;
        }
        public Company(string userName, string password, string companyName, string mst, string companyLocation, string boss, string phoneNumber, string email, string field, string description)
        : base(userName, password, "Companies")
        {
            Type = "Company";
            CompanyName = companyName;
            CompanyLocation = companyLocation;
            Mst = mst;
            Boss = boss;
            PhoneNumber = phoneNumber;
            Email = email;
            Field = field;
            Description = description;
        }

        public string Mst { get => mst; set => mst = value; }
        public string Boss { get => boss; set => boss = value; }
        public string CompanyLocation { get => companyLocation; set => companyLocation = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Field { get => field; set => field = value; }
        public string Description { get => description; set => description = value; }
    }
}
