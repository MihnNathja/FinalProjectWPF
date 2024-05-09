using FinalProject.Objects;
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
using System.Windows.Shapes;

namespace FinalProject.Windows.Employee
{
    /// <summary>
    /// Interaction logic for WNews.xaml
    /// </summary>
    public partial class WNews : Window
    {
        Objects.Employee employee;
        User user;
        Job job;
        public Objects.Employee Employee { get => employee; set => employee = value; }

        public WNews(Objects.Employee employee)
        {
            InitializeComponent();
            Employee = employee;
        }
        public WNews()
        {
            InitializeComponent();
        }
        public Job Job { get => job; set => job = value; }
        public User User { get => user; set => user = value; }
        private void btnPost_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSelectCV_Click(object sender, RoutedEventArgs e)
        {
            //UserDAO userDAO = new UserDAO();
            //Employee employee = new Employee();
            //employee = userDAO.GetUser(employee, user);
            //WSelectCV wSelectCV = new WSelectCV(employee, job);
            //wSelectCV.ShowDialog();
            //this.Close();
        }
    }
}
