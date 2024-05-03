using FinalProject.Database;
using FinalProject.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Interaction logic for PCalendar.xaml
    /// </summary>
    public partial class PCalendar : System.Windows.Controls.Page
    {
        List<DateTime> appointmentDates;
        Employee employee;
        EmployeeDAO EmployeeDAO = new EmployeeDAO();
        public Employee Employee { get => employee; set => employee = value; }
        public List<DateTime> AppointmentDates { get => appointmentDates; set => appointmentDates = value; }

        public PCalendar()
        {
            InitializeComponent();
        }
        public PCalendar(Employee employee)
        {
            InitializeComponent();
            Employee = employee;
            AppointmentDates = EmployeeDAO.GetAppointmentDate(employee);
        }

        private void calendar_Loaded(object sender, RoutedEventArgs e)
        {
            calendar.BlackoutDates.AddDatesInPast();
            foreach (var date in AppointmentDates)
            {
                MessageBox.Show(date.ToShortDateString());
                calendar.SelectedDate = date;

            }
        }
    }
}
