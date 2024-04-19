using FinalProject.Objects;
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
            MessageBox.Show(cv.ID);
            string[] prop = {"IdCV", "ID", "CVTitle", "Careergoals", "Skill", "Presenter", "Experience", "Activitie", "Certificate", "Awards", "AddInformation"};
            List<SqlParameter> parameters = Utility.GetParameters(cv, prop);
            string SQL = Utility.GenerateInsertSql(tableName, parameters);
            MessageBox.Show(SQL);
            db.ThucThi(SQL, parameters);
        }
        public void Xoa(Job job)
        {
            string[] prop = { "ID"};
            List<SqlParameter> parameter = Utility.GetParameters(job, prop);
            string SQL = Utility.GenerateDeleteSql(tableName, parameter);

            db.ThucThi(SQL, parameter);
        }

        public CV GetObject(string id)
        {
            string SQL = string.Format("SELECT * FROM CV WHERE IdCV = '{0}'", id);
            DataTable data = db.Load(SQL);
            CV cV = new CV(id);
            DataRow row = data.Rows[0];
            PropertyInfo[] properties = typeof(CV).GetProperties();
            foreach (PropertyInfo property in properties)
            {
                property.SetValue(cV, row[property.Name].ToString(), null);
            }
            return cV;
        }

        public List<UCCV> LoadPage()
        {
            int index = 0;

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
        public List<UCCV> GetEmployeeCV(Employee employee)
        {
            int index = 0;
            List<UCCV> cvList = new List<UCCV>();
            DataTable cvTable = EmployeeCVData(employee);
            foreach (DataRow row in cvTable.Rows)
            {
                UCCV cv = new UCCV();
                cv.ID = row["IdCV"].ToString();
/*                cv.tbSTT.Text = (index + 1).ToString();
                cv.tbCVTitle.Text = row["CVTitle"].ToString();*/
                cvList.Add(cv);
            }
            return cvList;
        }
        public DataTable EmployeeCVData(Employee employee)
        {
            string SQL = string.Format($"SELECT *FROM CV WHERE ID = {employee.ID}");
            return db.Load(SQL);
        }
        public void Apply(Job job, CV cv)
        {
            string SQL = string.Format($"INSERT INTO ApplyCV (ID, IdCV, Accept) VALUE ('{job.Id}', {cv.IdCV}, {null}");
            db.ThucThi(SQL);
        }
        public void Accept(Job job, CV cv, bool isAccepted)
        {
            string SQL = string.Format($"UPDATE ApplyCV SET ACCEPT = {isAccepted} WHERE ID = {job.Id} and IdCV = {cv.IdCV}");
            db.ThucThi(SQL);
        }
        
    }
}
