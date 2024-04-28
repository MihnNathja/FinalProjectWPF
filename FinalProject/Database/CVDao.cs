using FinalProject.Objects;
using FinalProject.User_Control;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;

namespace FinalProject.Database
{
    internal class CVDAO
    {
        DBConnections db = new DBConnections();
        DataTable dataCV;
        string tableName = "CV";

        public DataTable DataCV { get => dataCV; set => dataCV = value; }
        public CVDAO()
        {
            dataCV = Load();
        }
        public DataTable Load()
        {
            string SQL = string.Format("SELECT *FROM CV");
            return db.Load(SQL);
        }
        public string GetID()
        {
            string SQL = string.Format("SELECT MAX(IdCV) FROM CV");
            return db.GetValue(SQL).ToString();
        }
        public string GetNextID()
        {
            string SQL = string.Format("SELECT MAX(IdCV) FROM CV");
            return (db.GetValue(SQL) + 1).ToString();
        }
        public void Them(CV cv)
        {
            string[] prop = {"IdCV", "ID", "CVTitle", "Careergoals", "Skill", "Presenter", "Experience", "Activitie", "Certificate", "Awards", "AddInformation"};
            List<SqlParameter> parameters = Utility.GetParameters(cv, prop);
            string SQL = Utility.GenerateInsertSql(tableName, parameters);
            db.ThucThi(SQL, parameters);
        }
        public void Xoa(CV cv)
        {
            string[] prop = { "IdCV"};
            List<SqlParameter> parameter = Utility.GetParameters(cv, prop);
            string SQL = Utility.GenerateDeleteSql(tableName, parameter);
            db.ThucThi(SQL, parameter);
        }

        public CV GetObject(string id)
        {
            string SQL = string.Format("SELECT * FROM CV WHERE IdCV = '{0}'", id);
            DataTable data = db.Load(SQL);
            CV cV = new CV();
            DataRow row = data.Rows[0];
            PropertyInfo[] properties = typeof(CV).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                property.SetValue(cV, row[property.Name].ToString(), null);
            }
            return cV;
        }
        public void Write(Job job, CV cv, Employee employee, DateOnly date)
        {
            string SQL = string.Format($"UPDATE ApplyCV SET Interview = {date} WHERE IdCV = {cv.IdCV} and ID = {job.Id} and IdEmployee = {employee.ID}");
            db.ThucThi(SQL);
        }

        public int GetAcceptValue(string id)
        {
            string SQL = string.Format("SELECT ACCEPT FROM ApplyCV WHERE IdCV = '{0}'", id);
            DataTable data = db.Load(SQL);

            if (data.Rows.Count > 0)
            {
                object acceptValue = data.Rows[0]["ACCEPT"];

                
                if (acceptValue != DBNull.Value)
                {
                    bool accept = (bool)acceptValue;
                    return accept ? 1 : 0;
                }
            }
            return -1;
        }

        //public List<UCNotification> LoadAcceptNotifi(Employee employee)
        //{
        //    List<UCNotification> list = new List<UCNotification>();
        //    string SQL = string.Format($"SELECT ACCEPT FROM ApplyCV WHERE IdEmployee = '{employee.ID}'");
        //    DataTable data = db.Load(SQL);
        //    foreach (DataRow row in data.Rows)
        //    {
        //        UCNotification notifi = new UCNotification();
        //        notifi.ID = row["IdCV"].ToString();

        //        list.Add(cv);
        //    }
        //    return list;
        //}

        public List<UCCV> LoadPage()
        {
            List<UCCV> list = new List<UCCV>();

            DataTable cvTable = DataCV;
            foreach (DataRow row in cvTable.Rows)
            {
                UCCV cv = new UCCV();
                cv.ID = row["IdCV"].ToString();
                
                list.Add(cv);
            }
            return list;
        }
        public List<UCCVApply> GetEmployeeCV(Employee employee)
        {
            List<UCCVApply> cvList = new List<UCCVApply>();
            DataTable cvTable = EmployeeCVData(employee);
            if(cvTable  != null) 
            {
                foreach (DataRow row in cvTable.Rows)
                {
                    UCCVApply cv = new UCCVApply(row["IdCV"].ToString());
                    cvList.Add(cv);
                }
            }  

            return cvList;
        }
        public List<UCCVEmployee> GetEmployeeCVToCreate(Employee employee)
        {
            List<UCCVEmployee> cvList = new List<UCCVEmployee>();
            DataTable cvTable = EmployeeCVData(employee);
            if (cvTable != null)
            {
                foreach (DataRow row in cvTable.Rows)
                {
                    UCCVEmployee cv = new UCCVEmployee(row["IdCV"].ToString());
                    cvList.Add(cv);
                }
            }
            else
            {
                MessageBox.Show("Người dùng chưa tạo CV xin việc, hãy tạo CV để ứng tuyển công việc!", "Thông báo");
            }

            return cvList;
        }
        public List<UCCV> GetEmployeeCV(Job job)
        {
            List<UCCV> cvList = new List<UCCV>();
            DataTable cvTable = JobCVData(job);
            foreach (DataRow row in cvTable.Rows)
            {
                UCCV cv = new UCCV(row["IdCV"].ToString());
                cvList.Add(cv);
            }
            return cvList;
        }
        public DataTable EmployeeCVData(Employee employee)
        {
            string SQL = string.Format($"SELECT *FROM CV WHERE ID = {employee.ID}");
            return db.Load(SQL);
        }
        public DataTable JobCVData(Job job)
        {
            string SQL = string.Format($"SELECT *FROM ApplyCV WHERE ID = {job.Id}");
            return db.Load(SQL);
        }
        public void Apply(Job job, CV cv, Employee employee)
        {
            string SQL = string.Format($"SELECT Count(*) FROM ApplyCV WHERE ID = {job.Id} and IdEmployee = {employee.ID}");
            if (int.Parse(db.GetValue(SQL)) > 0)
            {
                SQL = string.Format($"UPDATE ApplyCV SET IdCV = {cv.IdCV} WHERE ID = {job.Id} and IdEmployee = {employee.ID}");
                db.ThucThi(SQL);
            }
            else
            {
                SQL = string.Format($"INSERT INTO ApplyCV (ID, IdCV, IdEmployee) VALUES ('{job.Id}', '{cv.IdCV}', '{employee.ID}')");
                db.ThucThi(SQL);
            }
        }
        public void Accept(Job job, CV cv,Employee employee, int isAccepted)
        {
            string SQL = string.Format($"UPDATE ApplyCV SET ACCEPT = {isAccepted} WHERE ID = '{job.Id}' and IdCV = '{cv.IdCV}' and IdEmployee = '{employee.ID}'");
            db.ThucThi(SQL);
        }
        public string GetNumberCVOfJob(string id)
        {
            string SQL = string.Format($"SELECT COUNT(*) FROM ApplyCV WHERE ID = '{id}'");
            return db.GetValue(SQL);
        }
    }
}
