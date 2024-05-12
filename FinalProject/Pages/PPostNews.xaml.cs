using FinalProject.Database;
using FinalProject.Objects;
using FinalProject.User_Control;
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

namespace FinalProject.Pages
{
    /// <summary>
    /// Interaction logic for PPostNews.xaml
    /// </summary>
    public partial class PPostNews : System.Windows.Controls.Page
    {
        Employee employee;

        public Employee Employee { get => employee; set => employee = value; }

        public PPostNews(Employee employee)
        {
            InitializeComponent();
            Employee = employee;
        }

        public PPostNews()
        {
            InitializeComponent();
        }

        private void btnThemTin_Click(object sender, RoutedEventArgs e)
        {
            WNews wNews = new WNews(Employee);
            wNews.Show();
            ReloadPage();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            newsList.Children.Clear();
            NewsDAO newsDAO = new NewsDAO();
            List<UCNews> list = newsDAO.GetNews(Employee);
            foreach (UCNews item in list) 
            {
                item.Type = Employee.Type;
                item.Employee = Employee;
                newsList.Children.Add(item);
            }
        }
        private void ReloadPage()
        {
            newsList.Children.Clear();
            NewsDAO newsDAO = new NewsDAO();
            List<UCNews> list = newsDAO.GetNews(Employee);
            foreach (UCNews item in list)
            {
                item.Type = Employee.Type;
                item.Employee = Employee;
                newsList.Children.Add(item);
            }
        }
    }
}
