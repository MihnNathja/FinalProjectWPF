using FinalProject.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
            
            DataTable jobTable = jobDAO.LoadPage();
            foreach (DataRow row in jobTable.Rows)
            {
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
            }
        }
    }
}
