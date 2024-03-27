using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace FinalProject.Database
{
    internal class JobDAO
    {
        DBConnections db = new DBConnections();
        DataTable dataJob;

        public DataTable DataJob { get => dataJob; set => dataJob = value; }

        public JobDAO() 
        {
            // mặc định, khi tạo đối tượng JobDAO, thì dữ liệu job sẽ được lấy tất cả từ database job xuống và truyền vào dataJob
            this.dataJob = Load();
        }
        public void Them(Job job)
        {
            string SQL = string.Format("INSERT INTO Jobs(Name, CompanyName, Salary, Location) VALUES ('{0}','{1}', '{2}', '{3}')", job.Name, job.CompanyName, job.Salary, job.Location);
            db.ThucThi(SQL);
        }
        public List<UCJobInfo> LoadPage()
        {
            List<UCJobInfo> list = new List<UCJobInfo>();
            DataTable jobTable = DataJob;
            foreach (DataRow row in jobTable.Rows)
            {
                UCJobInfo jobInfo = new UCJobInfo();
                jobInfo.Name.Content = row["Name"].ToString();
                jobInfo.CompanyName.Content = row["CompanyName"].ToString();
                jobInfo.Salary.Content = row["Salary"].ToString();
                jobInfo.Location.Content = row["Location"].ToString();
                list.Append(jobInfo);
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
            // Phần bên dưới là duyệt từng property trong filter
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
