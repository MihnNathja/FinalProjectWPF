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
        string idJob;
        public string IdJob { get => idJob; set => idJob = value; }


        public CreateJob()
        {
            InitializeComponent();
        }
        public CreateJob(Company company)
        {
            InitializeComponent();
            DataContext = company;
        }
        public CreateJob(Job job)
        {
            InitializeComponent(); 
            this.DataContext = job;
        }


        private void btnPost_Click(object sender, RoutedEventArgs e)
        {
            Job job = new Job(jobDAO.GetNextID(),txtbName.Text,txtbCompanyName.Text,txtbSalary.Text,txtbExperience.Text,txtbLocation.Text,txtbDescription.Text,txtbRequire.Text,txtbRight.Text,txtbWorkTime.Text);
            
            jobDAO.Them(job);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
/*            Job job = new Job(IdJob, txtbName.Text, txtbCompanyName.Text, cbbSalary.Text, txtbLocation.Text);
            jobDAO.Sua(job);*/
        }
    }
}
