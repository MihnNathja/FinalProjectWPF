using FinalProject.Objects;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Database
{
    internal class CVDao
    {
        DBConnections db = new DBConnections();

        public void Them(CV cv)
        {
            string SQL = string.Format("INSERT INTO CV(Careergoals) VALUES ('{0}')", cv.CareerGoals);
            db.ThucThi(SQL);
        }
    }
}
