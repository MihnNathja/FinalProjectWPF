using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Job
    {
        string name;
        string companyName;
        string salary;
        string location;

        public Job(string name, string companyName, string salary, string location) 
        {
            Name = name;
            CompanyName = companyName;
            Salary = salary;
            Location = location;
        }

        public string Name { get => name; set => name = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public string Salary { get => salary; set => salary = value; }
        public string Location { get => location; set => location = value; }
    }
}
