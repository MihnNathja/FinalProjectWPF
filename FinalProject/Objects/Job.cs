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
        string experience;
        string jobLocation;
        string description;
        string require;
        string right;
        string workTime;

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
        public Job(string id, string jobName, string companyName, string salary, string experience, string jobLocation, string description, string require, string right, string workTime)
        {
            Id = id;
            JobName = jobName;
            CompanyName = companyName;
            Salary = salary;
            JobLocation = jobLocation;
            Description = description;
            Require = require;
            Right = right;
            WorkTime = workTime;
            Experience = experience;
        }
        public string Id { get => id; set => id = value; }
        public string JobName { get => jobName; set => jobName = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public string Salary { get => salary; set => salary = value; }
        public string JobLocation { get => jobLocation; set => jobLocation = value; }
        public string Description { get => description; set => description = value; }
        public string Require { get => require; set => require = value; }
        public string Right { get => right; set => right = value; }
        public string WorkTime { get => workTime; set => workTime = value; }
        public string Experience { get => experience; set => experience = value; }
    }
}
