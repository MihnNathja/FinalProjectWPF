using FinalProject.Database;
using FinalProject.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for PCompanyCalendar.xaml
    /// </summary>
    public partial class PCompanyCalendar : System.Windows.Controls.Page
    {
        int nowMonth;
        int nowYear;
        int[] daysInMonth = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        Company company;

        public Company Company { get => company; set => company = value; }
        public int NowMonth { get => nowMonth; set => nowMonth = value; }
        public int NowYear { get => nowYear; set => nowYear = value; }

        public PCompanyCalendar()
        {
            InitializeComponent();
            NowMonth = DateTime.Now.Month;
            NowYear = DateTime.Now.Year;
        }
        public PCompanyCalendar(Company company)
        {
            InitializeComponent();
            NowMonth = DateTime.Now.Month;
            NowYear = DateTime.Now.Year;
            Company = company;
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            year.Text = NowYear.ToString();
            month.Text = NowMonth.ToString();
            Load_Day();
        }

        private void btnLeft_Click(object sender, RoutedEventArgs e)
        {
            if (NowMonth == 1)
            {
                NowMonth = 12;
                NowYear--;
                year.Text = NowYear.ToString();
            }
            else
            {
                NowMonth = NowMonth - 1;
            }
            month.Text = NowMonth.ToString();
            Load_Day();
        }

        private void btnRight_Click(object sender, RoutedEventArgs e)
        {

            if (NowMonth == 12)
            {
                NowMonth = 1;
                NowYear++;
                year.Text = NowYear.ToString();
            }
            else
            {
                NowMonth = NowMonth + 1;
                month.Text = NowMonth.ToString();
            }
            Load_Day();

        }
        public void Create_Day(int day)
        {
            wplDay.Children.Clear();
            month.Text = NowMonth.ToString();
            CompanyDAO companyDAO = new CompanyDAO();
            List<UCDay> calendar = companyDAO.GetInterviewDate(Company, day, NowMonth, NowYear);
            foreach (UCDay date in calendar)
            {
                date.StackPanelInterview = stpnlInterview;
                wplDay.Children.Add(date);
            }
        }
        public void Load_Day()
        {
            int day = daysInMonth[NowMonth - 1];
            if (((NowYear % 4 == 0 && NowYear % 100 != 0) || (NowYear % 400 == 0)) && NowMonth == 2)
            {
                day++;
            }
            Create_Day(day);
        }
    }
}

