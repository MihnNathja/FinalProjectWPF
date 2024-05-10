using FinalProject.Database;
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
    /// Interaction logic for WCompany.xaml
    /// </summary>
    public partial class WCompany : Window
    {
        
        // bên dưới sau này sẽ chuyển thành user, lớp cha của company và employee
        Company company = new Company();
        public WCompany()
        {
            InitializeComponent();
        }
        public WCompany(Company company)
        {
            InitializeComponent();
            this.company = company;
            this.DataContext = company;
        }
        private void WCompany_Loaded(object sender, RoutedEventArgs e)
        {
            PCreateJob PCreateJob = new PCreateJob(company);
            mainFarm.Navigate(PCreateJob);
        }

        public void Reload(string page)
        {
            
            
            
            if(page == "PCreateJob")
            {
                mainFarm.Content = null;
                mainFarm.Content = new PCreateJob(company);
            }
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



        private void btnHoSo_MouseEnter(object sender, MouseEventArgs e)
        {
            popupControl.IsPopupOpen = true;
            popupControl.PopupContent = "Hồ sơ Công ty";
        }

        private void btnHoSo_MouseLeave(object sender, MouseEventArgs e)
        {
            popupControl.IsPopupOpen = false;
        }
        private void btnTin_Click(object sender, RoutedEventArgs e)
        {
            PNews pNews = new PNews(company);
            mainFarm.Navigate(pNews);
        }
        private void btnTin_MouseEnter(object sender, MouseEventArgs e)
        {
            popupControl.IsPopupOpen = true;
            popupControl.PopupContent = "Tin tìm việc";
        }
        private void btnTin_MouseLeave(object sender, MouseEventArgs e)
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

        private void btnTrangthai_MouseEnter(object sender, MouseEventArgs e)
        {
            popupControl.IsPopupOpen = true;
            popupControl.PopupContent = "Trạng thái";
        }

        private void btnTrangthai_MouseLeave(object sender, MouseEventArgs e)
        {
            popupControl.IsPopupOpen = false;
        }

        private void btnCongTy_Click(object sender, RoutedEventArgs e)
        {
            PCreateJob PCreateJob = new PCreateJob(company);
            mainFarm.Navigate(PCreateJob);
        }

        private void popupControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            

            //PJob PJob = new PJob(company);
            //PJob.search(cbbLocation.Text, cbbExperience.Text);
            //mainFarm.Navigate(PJob);
        }

       

        private void btnHoSo_Click(object sender, RoutedEventArgs e)
        {
            Page.PDocument PDocument = new Page.PDocument(company);
            mainFarm.Navigate(PDocument);
        }


        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnTrangThai_Click(object sender, RoutedEventArgs e)
        {
            PCompanyJobState pCompanyJobState = new PCompanyJobState(company);
            mainFarm.Navigate(pCompanyJobState);
        }
        private void btnLichHen_Click(object sender, RoutedEventArgs e)
        {
            PCompanyCalendar pCompanyCalendar = new PCompanyCalendar(company);
            mainFarm.Navigate(pCompanyCalendar);

        }

        private void btnQuanTam_Click(object sender, RoutedEventArgs e)
        {
            PCompanyInterestEmployee pCompanyInterest = new PCompanyInterestEmployee(company);
            mainFarm.Navigate(pCompanyInterest);
        }
    }
}
