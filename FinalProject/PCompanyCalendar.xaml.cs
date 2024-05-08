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

        public PCompanyCalendar()
        {
            InitializeComponent();
            nowMonth = DateTime.Now.Month;
            nowYear = DateTime.Now.Year;
            year.Text = nowYear.ToString();
            month.Text = nowMonth.ToString();
            Create_Year();
            Create_Month();
        }
        public PCompanyCalendar(Company company)
        {
            InitializeComponent();
            nowMonth = DateTime.Now.Month;
            nowYear = DateTime.Now.Year;
            year.Text = nowYear.ToString();
            month.Text = nowMonth.ToString();
            Company = company;
            Create_Year();
            Create_Month();


        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Load_Day();

        }

        private void btnLeft_Click(object sender, RoutedEventArgs e)
        {
            if (nowMonth == 1)
            {
                nowMonth = 12;
                nowYear--;
                year.Text = nowYear.ToString();
            }
            else
            {
                nowMonth = nowMonth - 1;
            }
            month.Text = nowMonth.ToString();
            Load_Day();
        }

        private void btnRight_Click(object sender, RoutedEventArgs e)
        {

            if (nowMonth == 12)
            {
                nowMonth = 1;
                nowYear++;
                year.Text = nowYear.ToString();
            }
            else
            {
                nowMonth = nowMonth + 1;
                month.Text = nowMonth.ToString();
            }
            Load_Day();

        }

        private void month_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            wplDay.Children.Clear();
            Load_Day();
        }
        public void Create_Day(int day)
        {
            wplDay.Children.Clear();
            month.Text = nowMonth.ToString();
            CompanyDAO companyDAO = new CompanyDAO();
            List<UCDay> calendar = companyDAO.GetInterviewDate(Company, day, nowMonth, nowYear);
            foreach (UCDay date in calendar)
            {
                date.StackPanelInterview = stpnlInterview;
                wplDay.Children.Add(date);
            }
        }
        public void Load_Day()
        {
            int day = daysInMonth[nowMonth - 1];
            if (((nowYear % 4 == 0 && nowYear % 100 != 0) || (nowYear % 400 == 0)) && nowMonth == 2)
            {
                day++;
            }
            Create_Day(day);
        }
        public void Create_Year()
        {
            for (int cbbYear = 2024; cbbYear <= 2030; cbbYear++)
            {
                year.Items.Add(cbbYear);
            }
        }
        public void Create_Month()
        {
            for (int cbbMonth = 1; cbbMonth <= 12; cbbMonth++)
            {
                month.Items.Add(cbbMonth);
            }
        }
    }
}

