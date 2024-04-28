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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalProject.Pages
{
    /// <summary>
    /// Interaction logic for PNotification.xaml
    /// </summary>
    public partial class PNotification : System.Windows.Controls.Page
    {
        Employee employee = new Employee();
        Job job = new Job();
        CVDAO cVDAO = new CVDAO();
        public PNotification()
        {
            InitializeComponent();
        }
        public PNotification(Employee employee)
        {
            InitializeComponent();
            Employee = employee;
        }

        public Employee Employee { get => employee; set => employee = value; }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            pnlNotifi.Children.Clear();
            List<UCNotification> notifiList = cVDAO.LoadAcceptNotifi(Employee);

            foreach (UCNotification notifi in notifiList)
            {
                pnlNotifi.Children.Add(notifi);
            }
        }
    }
}
