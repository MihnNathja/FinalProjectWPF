using FinalProject.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        public Employee GetEmployee(int id)
        {
            Employee emp = new Employee();
            return emp;
        }
        public DataTable Load()
        {
            string SQL = string.Format("SELECT *FROM Employees");
            return db.Load(SQL);
        }
    }
}
