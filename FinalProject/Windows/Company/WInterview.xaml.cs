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
    /// Interaction logic for WInterview.xaml
    /// </summary>
    public partial class WInterview : Window
    {
        CVDAO cVDAO = new CVDAO();
        CV cV;
        Job job;
        Employee employee;
        public CV CV { get => cV; set => cV = value; }
        public Job Job { get => job; set => job = value; }
        public Employee Employee { get => employee; set => employee = value; }
        public WInterview()
        {
            InitializeComponent();
        }
        public WInterview(Job job, CV cV, Employee employee)
        {
            InitializeComponent();
            CV = cV;
            Job = job;
            Employee = employee;
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            DateTime? selectedDate = calendar.SelectedDate;

            if (selectedDate.HasValue)
            {
                DateOnly date = DateOnly.FromDateTime(selectedDate.Value);
                cVDAO.Write(Job, CV, Employee, date);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
