using FinalProject.Database;
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

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for WNotification.xaml
    /// </summary>
    public partial class WNotification : Window
    {
        Employee employee = new Employee();
        Job job = new Job();
        CVDAO cVDAO = new CVDAO();
        public WNotification()
        {
            InitializeComponent();
        }
        public WNotification(Employee employee)
        {
            InitializeComponent();
            Employee = employee;
        }

        public Employee Employee { get => employee; set => employee = value; }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //pnlNotifi.Children.Clear();
            //List<UCNotification> notifiList = ;

            //foreach (UCNotification notifi in notifiList)
            //{

            //    pnlNotifi.Children.Add(notifi);
            //}
        }
    }
   
    
}
