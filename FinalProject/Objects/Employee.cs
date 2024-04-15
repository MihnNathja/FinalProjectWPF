using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Objects
{
    public class Employee : User
    {
        string employeeName;
        string gender;
        string employeeLocation;
        DateTime dateOfBirth;
        string cccd;
        public Employee() : base () 
        {
            Type = "Employee";
            TableName = "Employees";
        }
        public Employee(string userName, string password) : base(userName,password)
        {
            Type = "Employee";
            TableName = "Employees";
        }

        public Employee(string userName, string password, string employeeName, string gender, string employeeLocation, DateTime dateOfBirth, string cccd) 
            : base( userName, password, "Employees")
        {
            Type = "Employee";
            this.employeeName = employeeName;
            this.gender = gender;
            this.employeeLocation = employeeLocation;
            this.dateOfBirth = dateOfBirth;
            this.cccd = cccd;
        }

        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string EmployeeLocation { get => employeeLocation; set => employeeLocation = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Cccd { get => cccd; set => cccd = value; }
    }
}
