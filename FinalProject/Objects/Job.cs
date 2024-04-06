using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Objects
{
    public class Job
    {
        string id;
        string jobName;
        string companyName;
        string salary;
        string jobLocation;

        public Job() { }
        public Job(string id)
        {
            this.id = id;
        }
        public Job(string id, string jobName, string companyName, string salary, string jobLocation)
        {
            this.id = id;
            this.jobName = jobName;
            this.companyName = companyName;
            this.salary = salary;
            this.jobLocation = jobLocation;
        }
        public string Id { get => id; }
        public string JobName { get => jobName; set => jobName = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public string Salary { get => salary; set => salary = value; }
        public string JobLocation { get => jobLocation; set => jobLocation = value; }

    }
}
