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
        string id;
        string type;
        public string ID { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public User User { get => user; set => user = value; }

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
            if (Type == "Employee")
            {
                btnDeleteJob.IsEnabled = false;
            }
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
                (window as WCompany).Reload("CreatJobWindow");
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

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
    }
}
