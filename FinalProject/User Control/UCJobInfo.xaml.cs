using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FinalProject.Database;
using FinalProject.Objects;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for UCJobInfo.xaml
    /// </summary>
    public partial class UCJobInfo : UserControl
    {
        User user;
        Employee employee;
        string id;
        string type;

        public string ID { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public User User { get => user; set => user = value; }
        public Employee Employee { get => employee; set => employee = value; }

        public event PropertyChangedEventHandler? PropertyChanged;


        public UCJobInfo()
        {
            InitializeComponent();
            this.DataContext = this;
            if (Type == "Employee")
            {
                btnDeleteJob.IsEnabled = false;
            }
        }
        public UCJobInfo(Job job)
        {
            InitializeComponent();
            ID = job.Id;
            CompanyName.Text = job.CompanyName;
            JobName.Text = job.JobName;
            Salary.Text = job.Salary;
            JobLocation.Text = job.JobLocation;
            WorkTime.Text = job.WorkTime;

        }
        private void btnDeleteJob_Click(object sender, RoutedEventArgs e)
        {
            JobDAO jobDAO = new JobDAO();
            Job job = new Job(this.ID);
            jobDAO.Xoa(job);
            Reload();
        }

        private void Reload()
        {
            // Lấy ra cửa sổ chứa UserControl hiện tại
            Window window = Window.GetWindow(this);
            // Kiểm tra xem window có tồn tại và có phải là MainWindow không
            if (window != null && window is WCompany)
            {
                // Gọi phương thức tải lại trang trong MainWindow
                (window as WCompany).Reload("PCreateJob");
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        { 
            if (Type == "Employee")
            {
                btnDeleteJob.Visibility = Visibility.Collapsed;
                EmployeeDAO employeeDAO = new EmployeeDAO();
                if (employeeDAO.checkExistEmployeeInterestJob(employee.ID, ID))
                {
                    favorite.Foreground = Brushes.Red;
                }
                else
                {
                    favorite.Foreground = Brushes.Gray;
                }
            }
            else if (Type == "Company")
            {
                btnInterestJob.Visibility = Visibility.Collapsed;
            }
        }

        private void btnDetail_Click(object sender, RoutedEventArgs e)
        {
            JobDAO jobDAO = new JobDAO();
            Job job = jobDAO.GetObject(this.ID);
            if (Type == "Company")
            {
                WCreateJob WCreateJob = new WCreateJob(job);
                WCreateJob.ShowDialog();
            }
            else if (Type == "Employee")
            {
                WJobInfoDetail wJobInfoDetail = new WJobInfoDetail(User, job);
                wJobInfoDetail.ShowDialog();
            }
        }

        private void btnInterestJob_Click(object sender, RoutedEventArgs e)
        {
            EmployeeDAO employeeDAO = new EmployeeDAO();
            if (employeeDAO.checkExistEmployeeInterestJob(employee.ID, ID))
            {
                employeeDAO.XoaEmployeeInterestJob(Employee.ID, ID);
                //favorite.Foreground = Brushes.Gray;
            }
            else
            {
                employeeDAO.ThemEmployeeInterestJob(Employee.ID, ID);
                //favorite.Foreground = Brushes.Red;
            }
            this.UserControl_Loaded(sender, e);
        }
    }
}
