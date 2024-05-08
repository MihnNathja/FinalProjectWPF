using FinalProject.Objects;
using FinalProject.Windows.Employee;
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
    /// Interaction logic for UCCompanyInfo.xaml
    /// </summary>
    public partial class UCCompanyInfo : UserControl
    {
        Company company;

        public Company Company { get => company; set => company = value; }

        public UCCompanyInfo(Company company)
        {
            InitializeComponent();
            Company = company;
        }

        public UCCompanyInfo()
        {
            InitializeComponent();
        }

        private void btnDetail_Click(object sender, RoutedEventArgs e)
        {
            WCompanyInfo companyInfo = new WCompanyInfo(Company);
            companyInfo.ShowDialog();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = Company;
        }
    }
}
