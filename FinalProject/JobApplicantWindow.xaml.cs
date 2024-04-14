using FinalProject.Objects;
using FinalProject.Page;
using FinalProject.Pages;
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
    /// Interaction logic for JobApplicantWindow.xaml
    /// </summary>
    public partial class JobApplicantWindow : Window
    {
        Employee employee = new Employee();
        public JobApplicantWindow()
        {
            InitializeComponent();
        }
        public JobApplicantWindow(Employee employee)
        {
            InitializeComponent();
            MessageBox.Show(employee.EmployeeName);
            this.employee = employee;
            this.DataContext = employee;
        }
        private void CompanyWindow_Loaded(object sender, RoutedEventArgs e)
        {
            PageJob pageJob = new PageJob(employee);
            mainFarm.Navigate(pageJob);
        }
        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }
        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        private void btnViecLam_MouseEnter(object sender, MouseEventArgs e)
        {
            popupControl.IsPopupOpen = true;
            popupControl.PopupContent = "Việc làm";
        }

        private void btnViecLam_MouseLeave(object sender, MouseEventArgs e)
        {
            popupControl.IsPopupOpen = false;
        }

        private void btnHoSo_MouseEnter(object sender, MouseEventArgs e)
        {
            popupControl.IsPopupOpen = true;
            popupControl.PopupContent = "Hồ sơ và CV";
        }

        private void btnHoSo_MouseLeave(object sender, MouseEventArgs e)
        {
            popupControl.IsPopupOpen = false;
        }
        private void btnCongty_MouseEnter(object sender, MouseEventArgs e)
        {
            popupControl.IsPopupOpen = true;
            popupControl.PopupContent = "Công ty";
        }

        private void btnCongTy_MouseLeave(object sender, MouseEventArgs e)
        {
            popupControl.IsPopupOpen = false;
        }
        private void btnQuanTam_MouseEnter(object sender, MouseEventArgs e)
        {
            popupControl.IsPopupOpen = true;
            popupControl.PopupContent = "Công Việc Quan Tâm";
        }

        private void btnQuanTam_MouseLeave(object sender, MouseEventArgs e)
        {
            popupControl.IsPopupOpen = false;
        }

        private void btnCongTy_Click(object sender, RoutedEventArgs e)
        {
            PCompany pCompany = new PCompany();
            mainFarm.Navigate(pCompany);
        }

        private void popupControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnViecLam_Click(object sender, RoutedEventArgs e)
        {
            PageJob pageJob = new PageJob(employee);
            mainFarm.Navigate(pageJob);
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            PageJob pageJob = new PageJob(employee);
            pageJob.search(cbbLocation.Text, cbbExperience.Text);
            mainFarm.Navigate(pageJob);
        }

        private void mainFarm_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void btnHoSo_Click(object sender, RoutedEventArgs e)
        {
            CVPage cVPage = new CVPage(employee);
            mainFarm.Navigate(cVPage);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PageJob pageJob = new PageJob(employee);
            mainFarm.Navigate(pageJob);
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

