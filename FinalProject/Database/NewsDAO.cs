﻿using FinalProject.Objects;
using FinalProject.User_Control;
using FinalProject.Page;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Pages;

namespace FinalProject.Database
{
    public class NewsDAO : ObjectDAO
    {
        DBConnections db = new DBConnections();
        
        public NewsDAO() 
        {
            TableName = "News";
        }
        public void ThemNews(News news)
        {
            string[] prop = { "IdEmployee", "IdCV", "JobName", "Salary", "Experience", "Location", "Description", "Require", "Benefit", "WorkTime" };
            Them(news, prop);
        }
        public void XoaNews(News news)
        {
            string[] prop = { "IdEmployee", "IdCV" };

            Xoa(news, prop);
        }
        public void SuaNews(News news)
        {
            string[] prop = { "JobName", "Salary", "Experience", "Location", "Description", "Require", "Benefit", "WorkTime" };
            string condition = $"IdEmployee = '{news.IdEmployee}' and IdCV = '{news.IdCV}'";
            Sua(news, prop, condition);
        }
        public List<UCNews> GetNews()
        {
            List<UCNews> listNews = new List<UCNews>();
            string SQL = string.Format("SELECT * FROM News");
            listNews = GetNewsFromData(SQL);
            return listNews;
        }
        public List<UCNews> GetNews(Employee employee)
        {
            List<UCNews> listNews = new List<UCNews>();
            string SQL = string.Format($"SELECT * FROM News WHERE IdEmployee = '{employee.ID}'");
            listNews = GetNewsFromData(SQL);
            return listNews;
        }
        public List<UCNews> GetNewsFromData(string SQL)
        {
            List<UCNews> listNews = new List<UCNews>();
            DataTable data = db.Load(SQL);
            News news = new News();
            foreach (DataRow row in data.Rows)
            {
                PropertyInfo[] properties = typeof(News).GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    property.SetValue(news, row[property.Name].ToString(), null);
                }
                UCNews uCNews = new UCNews(news);
                listNews.Add(uCNews);
            }
            return listNews;
        }
        public void ThemCompanyInterestEmployee(string IdCompany, string IdEmployee, string IdCV)
        {
            string SQL = string.Format($"INSERT INTO CompanyInterestEmployees (IdCompany, IdEmployee, IdJob) VALUES ('{IdCompany}', '{IdEmployee}' and IdCV = ' {IdCV}')");
            db.ThucThi(SQL);
        }
        public void XoaCompanyInterestEmployee(string IdCompany, string IdEmployee, string IdCV)
        {
            string SQL = string.Format($"DELETE FROM CompanyInterestEmployees WHERE IdCompany = '{IdCompany}' and IdEmployee = '{IdEmployee}' and IdCV = '{IdCV}'");
            db.ThucThi(SQL);
        }
        public bool checkExistCompanyInterestEmployee(string IdCompany, string IdEmployee, string IdCV)
        {
            string SQL = string.Format($"SELECT COUNT(*) FROM CompanyInterestEmployees WHERE IdCompany = '{IdCompany}' and IdEmployee = '{IdEmployee}' and IdCV = '{IdCV}'");
            if (db.GetValue(SQL) != "0")
            {
                return true;
            }
            return false;
        }
    }
}

