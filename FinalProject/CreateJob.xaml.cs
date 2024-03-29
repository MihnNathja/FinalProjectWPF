using FinalProject.Database;
using FinalProject.Objects;
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
using System.Windows.Shapes;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for CreateJob.xaml
    /// </summary>
    public partial class CreateJob : Window
    {
        JobDAO jobDAO = new JobDAO();
        int idJob;

        public int IdJob { get => idJob; set => idJob = value; }

        public CreateJob()
        {
            InitializeComponent();
        }
        public CreateJob(UCJobInfo uCJobInfo)
        {
            InitializeComponent();
            IdJob = uCJobInfo.ID;
            txtbName.Text = uCJobInfo.Name.Content.ToString();
            txtbCompanyName.Text = uCJobInfo.CompanyName.Text;
            cbbSalary.Text = uCJobInfo.Salary.Text;
            txtbLocation.Text = uCJobInfo.Location.Text;
        }


        private void btnPost_Click(object sender, RoutedEventArgs e)
        {
            Job job = new Job(jobDAO.GetNextID(),txtbName.Text,txtbCompanyName.Text,cbbSalary.Text,txtbLocation.Text);
            jobDAO.Them(job);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Job job = new Job(IdJob, txtbName.Text, txtbCompanyName.Text, cbbSalary.Text, txtbLocation.Text);
            jobDAO.Sua(job);
        }
    }
}
