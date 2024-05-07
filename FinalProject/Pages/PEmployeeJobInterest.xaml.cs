using FinalProject.Database;
using FinalProject.Objects;
using FinalProject.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalProject.Pages
{
    /// <summary>
    /// Interaction logic for PEmployeeJobInterest.xaml
    /// </summary>
    public partial class PEmployeeJobInterest : System.Windows.Controls.Page
    {
        JobDAO jobDAO = new JobDAO();
        Employee employee;
        public PEmployeeJobInterest(Employee employee)
        {
            InitializeComponent();
            Employee = employee;
        }
        public Employee Employee { get => employee; set => employee = value; }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            pnlJobInterest.Children.Clear();
            EmployeeDAO employeeDAO = new EmployeeDAO();
            List<UCJobInfo> listInterestJobs = employeeDAO.GetEmployeeInterestJob(employee.ID);
            foreach (UCJobInfo job in listInterestJobs)
            {
                job.Employee = Employee;
                job.Type = Employee.Type;
                pnlJobInterest.Children.Add(job);
            }
        }
    }
}
