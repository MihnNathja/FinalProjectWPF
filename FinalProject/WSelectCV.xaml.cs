using System;
using System.Collections.Generic;
using System.Linq;
using FinalProject.Objects;
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
using FinalProject.Database;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for WSelectCV.xaml
    /// </summary>
    public partial class WSelectCV : Window
    {
        Employee employee = new Employee();
        Job job = new Job();
        public WSelectCV()
        {
            InitializeComponent();
        }
        public WSelectCV(Employee employee, Job job)
        {
            InitializeComponent();
            Employee = employee;
            Job = job;
        }

        public Employee Employee { get => employee; set => employee = value; }
        public Job Job { get => job; set => job = value; }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            pnlCV.Children.Clear();
            CVDAO cvDAO = new CVDAO();
            List<UCCV> cvList = cvDAO.GetEmployeeCV(employee);
            foreach (UCCV cv in cvList)
            {
                pnlCV.Children.Add(cv);
            }
        }
    }
}
