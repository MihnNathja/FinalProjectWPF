using FinalProject.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
            
            string[] prop = { "ID","UserName","Password","Type" ,"EmployeeName", "Gender", "EmployeeLocation", "DateOfBirth", "Cccd", "Phone" };
            Them(employee, prop);
        }
        public Employee GetEmployee(string id)
        {
            Employee employee = new Employee();
            employee.TableName = "Employees";
            string SQL = string.Format($"SELECT * FROM Employees WHERE ID = '{id}'");
            DataTable data = db.Load(SQL);
            foreach (DataRow row in data.Rows)
            {
                PropertyInfo[] properties = typeof(Employee).GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    if (property.Name != "TableName")
                    {
                        if (property.Name != "DateOfBirth")
                        {
                            property.SetValue(employee, row[property.Name].ToString(), null);
                        }
                        else
                        {
                            property.SetValue(employee, row[property.Name], null);
                        }
                    }
                    
                }
            }
            return employee;
        }
        public List<DateTime> GetAppointmentDate(Employee employee)
        {
            string SQL = string.Format($"SELECT Interview FROM ApplyCV WHERE IdEmployee = '{employee.ID}' and Confirm = '1'");
            DataTable data = db.Load(SQL);
            List<DateTime> list = new List<DateTime>();
            foreach (DataRow row in data.Rows)
            {
                DateTime dateTime = Convert.ToDateTime(row["Interview"]);
                list.Add(dateTime);
            }
            return list;
        }
        public DataTable Load()
        {
            string SQL = string.Format("SELECT *FROM Employees");
            return db.Load(SQL);
        }
    }
}
