using FinalProject.Objects;
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
using System.Windows.Documents;
using System.Windows;

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
            string SQL = string.Format($"DELETE FROM News Where IdEmployee = '{news.IdEmployee}' and IdCV = '{news.IdCV}'");
            db.ThucThi(SQL);
        }
        public void SuaNews(News news)
        {
            string[] prop = { "JobName", "Salary", "Experience", "Location", "Description", "Require", "Benefit", "WorkTime" };
            string condition = $"IdEmployee = '{news.IdEmployee}' and IdCV = '{news.IdCV}'";
            Sua(news, prop, condition);
        }
        public void ThemHoacChinhSua(News news)
        {
            string SQL = string.Format($"SELECT Count(*) FROM News WHERE IdEmployee = {news.IdEmployee}");
            if (int.Parse(db.GetValue(SQL)) > 0)
            {
                SuaNews(news);
            }
            else
            {
                ThemNews(news);
            }
        }
        public News GetObject(string IdEmployee, string IdCV)
        {
            string SQL = string.Format($"SELECT * FROM News WHERE IdEmployee = '{IdEmployee}' and IdCV = '{IdCV}'");
            DataTable data = db.Load(SQL);
            News news= new News();
            foreach (DataRow row in data.Rows)
            {
                PropertyInfo[] properties = typeof(News).GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    property.SetValue(news, row[property.Name].ToString(), null);
                }
            }
            return news;

        }
        public List<UCNews> GetNews()
        {
            string SQL = string.Format("SELECT * FROM News");
            List<UCNews> listNews = GetNewsFromData(SQL);
            return listNews;
        }
        public List<UCNews> GetNews(Employee employee)
        {
            string SQL = string.Format($"SELECT * FROM News WHERE IdEmployee = '{employee.ID}'");
            List<UCNews> listNews = GetNewsFromData(SQL);
            return listNews;
        }
        public List<UCNews> GetCompanyInterestNews(Company company)
        {
            List<UCNews> listNews = new List<UCNews>();
            string SQL = string.Format($"SELECT * FROM CompanyInterestEmployees WHERE IdCompany = '{company.ID}'");
            DataTable data = db.Load(SQL);

            foreach (DataRow row in data.Rows)
            {
                UCNews info = new UCNews(GetObject(row["IdEmployee"].ToString(), row["IdCV"].ToString()));
                listNews.Add(info);
            }
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
            string SQL = string.Format($"INSERT INTO CompanyInterestEmployees (IdCompany, IdEmployee, IdCV) VALUES ('{IdCompany}', '{IdEmployee}', '{IdCV}')");
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

