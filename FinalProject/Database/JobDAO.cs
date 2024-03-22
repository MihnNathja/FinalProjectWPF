using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Database
{
    internal class JobDAO
    {
        DBConnections db = new DBConnections();

        public void Them(Job job)
        {
            string SQL = string.Format("INSERT INTO Jobs(Name, CompanyName, Salary, Location) VALUES ('{0}','{1}', '{2}', '{3}')", job.Name, job.CompanyName, job.Salary, job.Location);
            db.ThucThi(SQL);
        }
        public DataTable LoadPage()
        {
            string SQL = string.Format("SELECT *FROM Jobs");
            return db.Load(SQL);
        }
    }
}
