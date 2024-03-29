using FinalProject.Database;
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

        public PageJob()
        {
            InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            pnlJob.Children.Clear();
            List<UCJobInfo> jobList = jobDAO.LoadPage();
            
            foreach (UCJobInfo job in jobList)
            {
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
               
                pnlJob.Children.Add(job);
            }
        }
    }
}

