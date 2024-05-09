using FinalProject.Objects;
using FinalProject.Page;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
