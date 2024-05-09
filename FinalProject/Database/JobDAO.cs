using FinalProject.User_Control;
using FinalProject.User_Control;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Xml.Linq;
using System.Windows.Controls.Primitives;
using FinalProject.Objects;
using System.Runtime;
using System.Reflection;
using System.Windows.Documents;
using FinalProject.Page;

namespace FinalProject.Database
{
    internal class JobDAO : ObjectDAO
    {
        DBConnections db = new DBConnections();
        public JobDAO()
        {
            // mặc định, khi tạo đối tượng JobDAO, thì dữ liệu job sẽ được lấy tất cả từ database job xuống và truyền vào dataJob
            TableName = "Jobs";
            DataJob = Load();
        }
        public void Them(Job job)
        {

            string[] prop = { "Id", "JobName", "CompanyName", "Salary", "Experience", "JobLocation", "Description", "Require", "Benefit", "WorkTime" };
            Them(job, prop);
        }
        public void Xoa(Job job)
        {
            string[] prop = { "Id" };
            Xoa(job, prop);
        }
        public void Sua(Job job)
        {
            string[] prop = { "" };
            string condition = $"Id = '{job.Id}'";
            Sua(job, prop, condition);
        }
        public string GetID()
        {
            string SQL = string.Format("SELECT MAX(Id) FROM Jobs");
            return db.GetValue(SQL).ToString();
        }
        public string GetNextID()
        {
            string SQL = string.Format("SELECT MAX(Id) FROM Jobs");
            return (int.Parse(db.GetValue(SQL)) + 1).ToString();
        }
        public Job GetObject(string id)
        {
            string SQL = string.Format("SELECT * FROM Jobs WHERE Id = '{0}'", id);
            DataTable data = db.Load(SQL);
            Job job = new Job(id);
            foreach(DataRow row in data.Rows)
            {
                PropertyInfo[] properties = typeof(Job).GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    property.SetValue(job, row[property.Name].ToString(), null);
                }
            }
            return job;

        }
        public List<UCJobInfo> LoadPage()
        {
            List<UCJobInfo> list = new List<UCJobInfo>();

            DataTable jobTable = DataJob;
            foreach (DataRow row in jobTable.Rows)
            {
                Job job = new Job();
                PropertyInfo[] properties = typeof(Job).GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    property.SetValue(job, row[property.Name].ToString(), null);
                }
                UCJobInfo jobInfo = new UCJobInfo(job);
                //ImageBrush imageBrush = new ImageBrush();
                //imageBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/FinalProjectWPF;Image/logosac-01.png", UriKind.Absolute));
                //jobInfo.Logo.Fill = imageBrush;
                list.Add(jobInfo);
            }
            return list;
        }


        public List<UCJobInfo> Search(string keyword, string location, string experience, string salary, string time)
        {
            List<UCJobInfo> list = new List<UCJobInfo>();
            string SQL = string.Format("SELECT * FROM Jobs WHERE 1 = 1"); // Bắt đầu với điều kiện luôn đúng
            if(keyword != null)
            {
                SQL += $" AND JobName LIKE N'%{keyword}%'";
            }
            if (location != "Tất cả khu vực/tỉnh thành")
            {
                SQL += $" AND JobLocation LIKE N'%{location}%'";
            }
            if (experience != "Tất cả kinh nghiệm")
            {
                SQL += $" AND Experience LIKE N'%{experience}%'";
            }
            if (experience != "Tất cả mức lương")
            {
                SQL += $" AND Experience LIKE N'%{salary}%'";
            }
            if (experience != "Thời gian làm việc")
            {
                SQL += $" AND Experience LIKE N'%{time}%'";
            }
            DataTable dataSearch = db.Load(SQL);
            
            foreach (DataRow row in dataSearch.Rows)
            {
                Job job = new Job();
                PropertyInfo[] properties = typeof(Job).GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    property.SetValue(job, row[property.Name].ToString(), null);
                }

                UCJobInfo jobInfo = new UCJobInfo(job);
                list.Add(jobInfo);
            }
            return list;

        }
        public List<UCCompanyJob> GetCompanyJob(Company company)
        {
            List<UCCompanyJob> uCCVs = new List<UCCompanyJob>();
            string SQL = string.Format($"SELECT* FROM Jobs WHERE CompanyName = '{company.CompanyName}'");
            DataTable companyJobTable = db.Load(SQL);
            foreach (DataRow row in companyJobTable.Rows)
            {
                Job job = new Job();
                PropertyInfo[] properties = typeof(Job).GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    property.SetValue(job, row[property.Name].ToString(), null);
                }
                UCCompanyJob jobInfo = new UCCompanyJob(job);
                jobInfo.Company = company;
                uCCVs.Add(jobInfo);
            }
            return uCCVs;
        }
        public List<UCJobInfo> GetCompanyJobForLoad(Company company)
        {
            List<UCJobInfo> jobInfos = new List<UCJobInfo>();
            string SQL = string.Format($"SELECT* FROM Jobs WHERE CompanyName = '{company.CompanyName}'");
            DataTable companyJobTable = db.Load(SQL);
            foreach (DataRow row in companyJobTable.Rows)
            {
                Job job = new Job();
                PropertyInfo[] properties = typeof(Job).GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    property.SetValue(job, row[property.Name].ToString(), null);
                }
                MessageBox.Show(job.JobName);
                UCJobInfo jobInfo = new UCJobInfo(job);
                jobInfos.Add(jobInfo);
            }
            return jobInfos;
        }
    }
}
