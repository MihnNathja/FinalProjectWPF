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
    public partial class PageJob
    {
        JobDAO jobDAO = new JobDAO();

        public PageJob()
        {
            InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
            List<UCJobInfo> jobList = jobDAO.LoadPage();
            foreach (UCJobInfo job in jobList )
            {
<<<<<<< HEAD:FinalProject/Pages/PageJob.xaml.cs
                pnlJob.Children.Add(job);
=======
                UCJobInfo jobInfo = new UCJobInfo();
/*                foreach(UCJobInfo.Proper properties in jobInfo)
                {
                    hỏi cô về cách duyệt từng property trong object
                }*/
                jobInfo.Name.Content = row["Name"].ToString();
                jobInfo.CompanyName.Text = row["CompanyName"].ToString();
                jobInfo.Salary.Text = row["Salary"].ToString();
                jobInfo.Location.Text = row["Location"].ToString();
                pnlJob.Children.Add(jobInfo);
>>>>>>> 39e67f37b518986a202bad73f442d4bcd91aac0d:FinalProject/Page/PageJob.xaml.cs
            }
        }

}

}
}
