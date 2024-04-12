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

namespace FinalProject.Pages
{
    /// <summary>
    /// Interaction logic for PCompany.xaml
    /// </summary>
    public partial class PCompany : System.Windows.Controls.Page
    {
        public PCompany()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CompanyDAO companyDAO = new CompanyDAO();
            pnlCompany.Children.Clear();
            List<UCCompanyInfo> companyList = companyDAO.LoadPage();
            foreach (UCCompanyInfo companyInfo in companyList)
            {
                pnlCompany.Children.Add(companyInfo);
            }
        }
    }
}
