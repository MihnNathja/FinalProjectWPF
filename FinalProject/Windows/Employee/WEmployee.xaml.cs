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
    /// Interaction logic for WEmployee.xaml
    /// </summary>
    public partial class WEmployee : Window
    {
        Employee employee = new Employee();
        public WEmployee()
        {
            InitializeComponent();
           
        }
        public WEmployee(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            this.DataContext = employee;
            
        }
        private void WCompany_Loaded(object sender, RoutedEventArgs e)
        {
            PJob PJob = new PJob(employee);
            mainFarm.Navigate(PJob);
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
        private void btnThongBao_MouseEnter(object sender, MouseEventArgs e)
        {
            popupControl.IsPopupOpen = true;
            popupControl.PopupContent = "Thông Báo";
        }

        private void btnThongBao_MouseLeave(object sender, MouseEventArgs e)
        {
            popupControl.IsPopupOpen = false;
        }
        private void btnThongBao_Click(object sender, RoutedEventArgs e)
        {
            PNotification pNotification = new PNotification(employee);
            mainFarm.Navigate(pNotification);
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
            PJob PJob = new PJob(employee);
            mainFarm.Navigate(PJob);
        }

       

        private void mainFarm_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void btnHoSo_Click(object sender, RoutedEventArgs e)
        {
            PCV PCV = new PCV(employee);
            mainFarm.Navigate(PCV);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            PJob PJob = new PJob(employee);
            mainFarm.Navigate(PJob);
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void Reload(Employee employee)
        {
            mainFarm.Content = null;
            mainFarm.Content = new PCV(employee);

        }


        private void btnLichHen_Click(object sender, RoutedEventArgs e)
        {
            PCalendar pCalendar = new PCalendar(employee);
            mainFarm.Navigate(pCalendar);
        }
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("search");
        }
    }
}

