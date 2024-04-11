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

namespace FinalProject.Database
{
    internal class JobDAO : ObjectDAO
    {
        DBConnections db = new DBConnections();
        public JobDAO()
        {
            // mặc định, khi tạo đối tượng JobDAO, thì dữ liệu job sẽ được lấy tất cả từ database job xuống và truyền vào dataJob

            DataJob = Load();
            TableName = "Jobs";
        }
        public void Them(Job job)
        {
            string[] prop = { "Id", "JobName", "Company", "Salary", "JobLocation" };
            Them(job, prop);
        }
        public void Xoa(Job job)
        {
            string[] prop = { "Id" };
            Xoa(job, prop);
        }
        public void Sua(Job job)
        {
/*            string[] prop = { "" };
            string condition = "ID = ";
            List<SqlParameter> parameters = Utility.GetParameters(job, prop);
            string SQL = Utility.GenerateUpdateSql(tableName, parameters, condition);
            db.ThucThi(SQL, parameters);
            string SQL = string.Format("UPDATE Jobs SET Name = '{1}', CompanyName = '{2}', Salary = '{3}', Location = '{4}' WHERE ID = {0}", job.Id, job.JobName, job.CompanyName, job.Salary, job.JobLocation);
            db.ThucThi(SQL);*/
        }
        public string GetID()
        {
            string SQL = string.Format("SELECT MAX(ID) FROM Jobs");
            return db.GetValue(SQL).ToString();
        }
        public string GetNextID()
        {
            string SQL = string.Format("SELECT MAX(ID) FROM Jobs");
            return (db.GetValue(SQL) + 1).ToString();
        }
        public Job GetObject(string id)
        {
            string SQL = string.Format("SELECT * FROM Jobs WHERE ID = '{0}'", id);
            DataTable data = db.Load(SQL);
            Job job = new Job(id);
            DataRow row = data.Rows[0];
            PropertyInfo[] properties = typeof(Job).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                property.SetValue(job, row[property.Name].ToString(), null);
            }
            return job;
        }
        public List<UCJobInfo> LoadPage()
        {
            List<UCJobInfo> list = new List<UCJobInfo>();

            DataTable jobTable = DataJob;
            foreach (DataRow row in jobTable.Rows)
            {
                UCJobInfo jobInfo = new UCJobInfo();
                jobInfo.ID = row["ID"].ToString();
                jobInfo.JobName.Content = row["JobName"].ToString();
                jobInfo.CompanyName.Text = row["CompanyName"].ToString();
                jobInfo.Salary.Text = row["Salary"].ToString();
                jobInfo.JobLocation.Text = row["JobLocation"].ToString();
                //ImageBrush imageBrush = new ImageBrush();
                //imageBrush.ImageSource = new BitmapImage(new Uri("pack://application:,,,/FinalProjectWPF;Image/logosac-01.png", UriKind.Absolute));
                //jobInfo.Logo.Fill = imageBrush;
                list.Add(jobInfo);
            }
            return list;
        }
        public DataTable Load()
        {
            string SQL = string.Format("SELECT *FROM Jobs");
            return db.Load(SQL);
        }

        public DataTable Search(Filter filter)
        {
            // Phần bên dưới là duyệt từng property trong filter, sau này sẽ có thể sử dụng
            /*            string values = "";
                        Type type = filter.GetType();
                        foreach (PropertyInfo property in type.GetProperties())
                        {
                            values += "'" + property.GetValue(filter).ToString() + "'" + ",";
                        }*/
            string SQL = string.Format("SELECT *FROM Jobs WHERE Location = '{0}'", filter.Location);
            return db.Load(SQL);
        }
    }
}
