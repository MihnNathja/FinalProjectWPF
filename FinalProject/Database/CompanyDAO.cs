using FinalProject.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Database
{
    internal class CompanyDAO : ObjectDAO
    {
        DBConnections db = new DBConnections();

        public CompanyDAO()
        {
            TableName = "Companies";

        }

        public void Them(Company company)
        {
            string[] prop = { "ID","UserName" ,"Password", "Type" ,"CompanyName", "Mst", "CompanyLocation", "Boss", "PhoneNumber" };
            Them(company, prop);
        }
        /*        public void Xoa(Company company)
                {
                    string[] prop = {"Id"};
                    string SQL = string.Format("DELETE FROM Companies WHERE Mst = {0}", company);
                    db.ThucThi(SQL);
                }*/
        /*        public void Sua(Company company)
                {
                    string SQL = string.Format("UPDATE Companies SET Name = '{1}', CompanyName = '{2}', Salary = '{3}', Location = '{4}' WHERE ID = {0}", company.Name, company.Mst, company.Location, company.boss, company.PhoneNumber);
                    db.ThucThi(SQL);
                }*/
        public List<UCCompanyInfo> LoadPage()
        {
            List<UCCompanyInfo> list = new List<UCCompanyInfo>();

            DataTable companyTable = Load();
            foreach (DataRow row in companyTable.Rows)
            {
                UCCompanyInfo companyInfo = new UCCompanyInfo();
                companyInfo.CompanyName.Text = row["CompanyName"].ToString();
                companyInfo.Mst.Text = row["Mst"].ToString();
                companyInfo.CompanyLocation.Text = row["CompanyLocation"].ToString();
                /*companyInfo.Boss.Text = row["Boss"].ToString();*/
                companyInfo.PhoneNumber.Text = row["PhoneNumber"].ToString() ;
                list.Add(companyInfo);
            }
            return list;
        }
    }
}
