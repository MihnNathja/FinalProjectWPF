using FinalProject.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
            string[] prop = { "ID","UserName" ,"Password", "Type" ,"CompanyName", "Mst", "CompanyLocation", "Boss", "PhoneNumber", "Email", "Field", "Description" };
            Them(company, prop);
        }
        /*        public void Xoa(Company company)
                {
                    string[] prop = {"Id"};
                    string SQL = string.Format("DELETE FROM Companies WHERE Mst = {0}", company);
                    db.ThucThi(SQL);
                }*/
        public void Sua(Company company)
        {
            string[] props = {"CompanyName", "Mst", "CompanyLocation", "Boss", "PhoneNumber", "Email", "Field", "Description" };
            string condition = $"ID = '{company.ID}'";
            Sua(company,props, condition);   
        }
        public List<UCCompanyInfo> LoadPage()
        {
            List<UCCompanyInfo> list = new List<UCCompanyInfo>();

            DataTable companyTable = Load();
            foreach (DataRow row in companyTable.Rows)
            {
                UCCompanyInfo companyInfo = new UCCompanyInfo();
                companyInfo.CompanyName.Text = row["CompanyName"].ToString();
                companyInfo.CompanyLocation.Text = row["CompanyLocation"].ToString();
                companyInfo.PhoneNumber.Text = row["PhoneNumber"].ToString() ;
                companyInfo.CompanyDescription.Text = row["Description"].ToString() ;   
                list.Add(companyInfo);
            }
            return list;
        }
    }
}
