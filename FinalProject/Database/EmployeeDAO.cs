using FinalProject.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Database
{
    internal class EmployeeDAO : ObjectDAO
    {
        DBConnections db = new DBConnections();
        public EmployeeDAO()
        {
            TableName = "Employees";
        }

        public void Them(Employee employee)
        {
            string[] prop = { "ID","UserName","Password","Type" ,"EmployeeName", "Gender", "EmployeeLocation", "DateOfBirth", "Cccd" };
            Them(employee, prop);
        }
        public Employee GetEmployee(string id)
        {
            Employee employee = new Employee();
            string SQL = string.Format($"SELECT * FROM Jobs WHERE ID = '{id}'");
            DataTable data = db.Load(SQL);
            foreach (DataRow row in data.Rows)
            {
                PropertyInfo[] properties = typeof(Employee).GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    property.SetValue(employee, row[property.Name].ToString(), null);
                }
            }
            return employee;
        }
        public DataTable Load()
        {
            string SQL = string.Format("SELECT *FROM Employees");
            return db.Load(SQL);
        }
    }
}
