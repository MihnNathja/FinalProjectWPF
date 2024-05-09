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

        private void btnPost_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSelectCV_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
