using FinalProject.Objects;
using FinalProject.Windows.Employee;
using MaterialDesignThemes.Wpf;
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
    /// Interaction logic for UCNews.xaml
    /// </summary>
    public partial class UCNews : UserControl
    {
        User user;
        Employee employee;
        string id;
        string type;

        public string ID { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public User User { get => user; set => user = value; }
        public Employee Employee { get => employee; set => employee = value; }
        public UCNews()
        {
            InitializeComponent();
        }
        

        private void btnDeleteJob_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDetail_Click(object sender, RoutedEventArgs e)
        {
            WNews wNews = new WNews();
            wNews.ShowDialog();
        }
    }
}
