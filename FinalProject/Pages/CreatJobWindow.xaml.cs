using FinalProject.Database;
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
    /// Interaction logic for CreatJobWindow.xaml
    /// </summary>
    public partial class CreatJobWindow
    {
        public CreatJobWindow()
        {
            InitializeComponent();
        }

        private void btnThemCongViec_Click(object sender, RoutedEventArgs e)
        {
            CreateJob createJob = new CreateJob();
            createJob.ShowDialog();
            Page_Loaded(sender, e);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            jobList.Children.Clear();
            JobDAO jobDAO = new JobDAO();
            List<UCJobInfo> data = jobDAO.LoadPage();
            foreach (UCJobInfo job in data )
            {
                jobList.Children.Add( job );
            }
        }

        
    }
}
