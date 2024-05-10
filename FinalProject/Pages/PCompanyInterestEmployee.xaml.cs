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
    /// Interaction logic for PCompanyInterestEmployee.xaml
    /// </summary>
    public partial class PCompanyInterestEmployee : System.Windows.Controls.Page
    {
        public PCompanyInterestEmployee()
        {
            InitializeComponent();
        }
        Company company;
        public PCompanyInterestEmployee(Company company)
        {
            InitializeComponent();
            Company = company;
        }
        public Company Company { get => company; set => company = value; }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            pnlEmployeeInterest.Children.Clear();
            NewsDAO newsDAO = new NewsDAO();
            List<UCNews> listInterestEmployees = newsDAO.GetCompanyInterestNews(Company);
            foreach (UCNews news in listInterestEmployees)
            {
                news.Company = Company;
                news.Type = Company.Type;
                pnlEmployeeInterest.Children.Add(news);
            }
        }
    }
}
