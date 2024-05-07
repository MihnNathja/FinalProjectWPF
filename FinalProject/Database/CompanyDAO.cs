using FinalProject.Objects;
using FinalProject.Pages;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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
        public List<UCDay> GetInterviewDate(Company company, int day, int month, int year)
        {
            List<UCDay> calendar = new List<UCDay>();
            for (int i = 1; i <= day; i++)
            {
                UCDay uCDay = new UCDay(i);
                calendar.Add(uCDay);
            }
            DateTime startDate = new DateTime(year, month, 1);
            DateTime endDate = new DateTime(year, month, day);
            string SQL = string.Format($"SELECT * FROM ApplyCV WHERE ID = '{company.ID}' and  ACCEPT = 'True' and Interview BETWEEN '{startDate}' and '{endDate}' ORDER BY Interview ASC");
            DataTable dataTable = db.Load(SQL);
            foreach (DataRow row in dataTable.Rows)
            {
                calendar.ElementAt(Convert.ToDateTime(row["Interview"]).Day - 1).HasEvent = true;
                TextBlock infoDate = new TextBlock();
                infoDate.Text = "Bạn có một cuộc hẹn với CV số " + row["IdCV"];
                calendar.ElementAt(Convert.ToDateTime(row["Interview"]).Day - 1).TxtbInterviewDates.Add(infoDate);
            }
            return calendar;
        }
    }
}
