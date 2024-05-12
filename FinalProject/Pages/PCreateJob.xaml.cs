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

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for PCreateJob.xaml
    /// </summary>
    public partial class PCreateJob : System.Windows.Controls.Page
    {
        Company company;
        public PCreateJob()
        {
            InitializeComponent();
        }
        public PCreateJob(Company company)
        {
            InitializeComponent();
            Company = company;
        }

        public Company Company { get => company; set => company = value; }

        private void btnThemCongViec_Click(object sender, RoutedEventArgs e)
        {
            WCreateJob WCreateJob = new WCreateJob(Company);
            WCreateJob.ShowDialog();
            ReloadPage(Company);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
            jobList.Children.Clear();
            JobDAO jobDAO = new JobDAO();
            List<UCJobInfo> data = jobDAO.GetCompanyJobForLoad(Company);
            foreach (UCJobInfo job in data )
            {
                job.Type = Company.Type;
                jobList.Children.Add( job );
            }
           
        }
        private void ReloadPage(Company company)
        {
            jobList.Children.Clear();
            JobDAO jobDAO = new JobDAO();
            List<UCJobInfo> data = jobDAO.GetCompanyJobForLoad(company);
            foreach (UCJobInfo job in data)
            {
                job.Type = Company.Type;
                jobList.Children.Add(job);
            }
        }
    }
}
