﻿using System;
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
            this.name = name;
            this.companyName = companyName;
            this.salary = salary;
            this.location = location;
        }

        public string Name { get => name; set => name = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public string Salary { get => salary; set => salary = value; }
        public string Location { get => location; set => location = value; }
    }
}
