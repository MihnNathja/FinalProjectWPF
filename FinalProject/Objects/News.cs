using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Objects
{
    public class News
    {
        string idEmployee;
        string idCV;
        string jobName;
        string experience;
        string location;
        string salary;
        string description;
        string benefit;
        string workTime;
        public News() { }

        public News(string idEmployee, string idCV, string jobName, string experience, string location, string salary, string description, string benefit, string workTime)
        {
            IdEmployee = idEmployee;
            IdCV = idCV;
            JobName = jobName;
            Experience = experience;
            Location = location;
            Salary = salary;
            Description = description;
            Benefit = benefit;
            WorkTime = workTime;
        }

        public string IdEmployee { get => idEmployee; set => idEmployee = value; }
        public string IdCV { get => idCV; set => idCV = value; }
        public string JobName { get => jobName; set => jobName = value; }
        public string Experience { get => experience; set => experience = value; }
        public string Location { get => location; set => location = value; }
        public string Salary { get => salary; set => salary = value; }
        public string Description { get => description; set => description = value; }
        public string Benefit { get => benefit; set => benefit = value; }
        public string WorkTime { get => workTime; set => workTime = value; }
    }
}
