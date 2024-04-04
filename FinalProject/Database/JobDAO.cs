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

namespace FinalProject.Database
{
    internal class JobDAO
    {
        Utility utility = new Utility();
        DBConnections db = new DBConnections();
        DataTable dataJob;

        public DataTable DataJob { get => dataJob; set => dataJob = value; }

        public JobDAO() 
        {
            // mặc định, khi tạo đối tượng JobDAO, thì dữ liệu job sẽ được lấy tất cả từ database job xuống và truyền vào dataJob

            DataJob = Load();
        }
        public void Them(Job job)
        {
            string SQL = string.Format("INSERT INTO Jobs(ID, Name, CompanyName, Salary, Location) VALUES ('{0}','{1}', '{2}', '{3}', '{4}')", job.Id, job.Name, job.CompanyName, job.Salary, job.Location);
            db.ThucThi(SQL);
        }
        public void Xoa(Job job)
        {
            string SQL = string.Format("DELETE FROM Jobs WHERE ID = {0}", job.Id);
            db.ThucThi(SQL);
        }
        public void Sua(Job job)
        {
            string SQL = string.Format("UPDATE Jobs SET Name = '{1}', CompanyName = '{2}', Salary = '{3}', Location = '{4}' WHERE ID = {0}", job.Id, job.Name, job.CompanyName, job.Salary, job.Location);
            db.ThucThi(SQL);
        }
        public string GetID()
        {
            string SQL = string.Format("SELECT MAX(ID) FROM Jobs");
            return db.GetValue(SQL).ToString();
        }
        public string GetNextID()
        {
            return GetID() + 1;
        }
        public Job GetObject(string id)
        {
            string SQL = string.Format("SELECT * FROM Jobs WHERE ID = '{0}'", id);
            DataTable data = db.Load(SQL);
            Job job = new Job(id);
            DataRow row = data.Rows[0];
            Utility.SetItemFromRow(job, row);
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
                jobInfo.Name.Content = row["Name"].ToString();
                jobInfo.CompanyName.Text = row["CompanyName"].ToString();
                jobInfo.Salary.Text = row["Salary"].ToString();
                jobInfo.Location.Text = row["Location"].ToString();
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
