using FinalProject.Database;
using FinalProject.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace FinalProject.User_Control
{
    /// <summary>
    /// Interaction logic for UCCompanyJob.xaml
    /// </summary>
    public partial class UCCompanyJob : UserControl
    {
        Company company;
        string id;
        string type;
        public string ID { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public Company Company { get => company; set => company = value; }
        public UCCompanyJob()
        {
            InitializeComponent();
        }
        public UCCompanyJob(Job job)
        {
            CVDAO cVDAO = new CVDAO();
            InitializeComponent();
            ID = job.Id;
            NumberOfEmployee.Content = cVDAO.GetNumberCVOfJob(ID);
            CompanyName.Text = job.CompanyName;
            JobName.Content = job.JobName;
            Salary.Text = job.Salary;
            JobLocation.Text = job.JobLocation;
        }


        private void UserControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // hiển thị ra danh sách các CV apply vào công việc này
        }
    }
}
