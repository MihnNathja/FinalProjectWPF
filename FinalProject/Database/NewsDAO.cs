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
            string[] prop = { "IdEmployee", "JobName", "CompanyName", "Salary", "Experience", "JobLocation", "Description", "Require", "Benefit", "WorkTime" };
            Them(news, prop);
        }
        public void XoaNews(News news)
        {
            string[] prop = { "IdEmployee", "IdCV" };

            Xoa(news, prop);
        }
        public void SuaNews(News news)
        {
            string[] prop = { "" };
            string condition = $"IdEmployee = '{news.IdEmployee}' and IdCV = '{news.IdCV}'";
            Sua(news, prop, condition);
        }
        public List<UCNews> GetNews()
        {
            List<UCNews> listNews = new List<UCNews>();
            string SQL = string.Format("SELECT * FROM News");
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
    }
}

