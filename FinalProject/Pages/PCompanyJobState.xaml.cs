using FinalProject.Database;
using FinalProject.Objects;
using FinalProject.User_Control;
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
    /// Interaction logic for PCompanyJobState.xaml
    /// </summary>
    public partial class PCompanyJobState : System.Windows.Controls.Page
    {
        Company company;
        public Company Company { get => company; set => company = value; }
        public PCompanyJobState()
        {
            InitializeComponent();
        }
        public PCompanyJobState(Company company)
        {
            InitializeComponent();
            Company = company;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            pnlJobState.Children.Clear();
            JobDAO jobDAO = new JobDAO();
            List<UCCompanyJob> jobList = jobDAO.GetCompanyJob(Company);
            foreach (UCCompanyJob job in jobList)
            {
                pnlJobState.Children.Add(job);
            }
        }
    }
}
