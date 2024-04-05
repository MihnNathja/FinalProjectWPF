using FinalProject.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Database
{
    internal class CompanyDAO
    {
        DBConnections db = new DBConnections();
        
        public void Them(Company company)
        {
            string SQL = string.Format("INSERT INTO Companies(CompanyName, Mst, LocationCompany, CompanyRepresentative, PhoneNumber) VALUES ('{0}','{1}', '{2}', '{3}', '{4}')", company.Name, company.Mst, company.Location, company.CompanyRepresentative, company.PhoneNumber);
            db.ThucThi(SQL);
        }
        public void Xoa(Company company)
        {
            string SQL = string.Format("DELETE FROM Companies WHERE Mst = {0}", company.Mst);
            db.ThucThi(SQL);
        }
/*        public void Sua(Company company)
        {
            string SQL = string.Format("UPDATE Companies SET Name = '{1}', CompanyName = '{2}', Salary = '{3}', Location = '{4}' WHERE ID = {0}", company.Name, company.Mst, company.Location, company.CompanyRepresentative, company.PhoneNumber);
            db.ThucThi(SQL);
        }*/
        public DataTable Load()
        {
            string SQL = string.Format("SELECT *FROM Companies");
            return db.Load(SQL);
        }
    }
}
