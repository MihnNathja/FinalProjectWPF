using FinalProject.Database;
using FinalProject.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime;
using System.Runtime.CompilerServices;
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

namespace FinalProject.Page
{
    /// <summary>
    /// Interaction logic for PageJob.xaml
    /// </summary>
    public partial class PageJob : System.Windows.Controls.Page
    {
        
        JobDAO jobDAO = new JobDAO();
        User user;
        public User User { get => user; set => user = value; }

        public PageJob()
        {
            InitializeComponent();
            
        }

       
        
        public PageJob(User user)
        {
            User = user;
            InitializeComponent();
            
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            pnlJob.Children.Clear();
            List<UCJobInfo> jobList = jobDAO.LoadPage();
            
            foreach (UCJobInfo job in jobList)
            {
                job.User = user;
                job.Type = User.Type;
                if (job.Type == "Employee")
                    job.btnDeleteJob.Visibility = Visibility.Hidden;
                pnlJob.Children.Add(job);
            }
        }

       



        public void search(string location, string experience)
        {
            Filter filter = new Filter(location, experience);
            jobDAO.DataJob = jobDAO.Search(filter);
            pnlJob.Children.Clear();
            List<UCJobInfo> jobList = jobDAO.LoadPage();
            foreach (UCJobInfo job in jobList)
            {
                job.User = user;
                job.Type = User.Type;
                pnlJob.Children.Add(job);
            }
        }
    }
}

