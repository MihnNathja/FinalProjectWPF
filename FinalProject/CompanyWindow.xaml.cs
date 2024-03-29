using FinalProject.Database;
using FinalProject.Objects;
using FinalProject.Page;
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
    /// Interaction logic for CompanyWindow.xaml
    /// </summary>
    public partial class CompanyWindow : Window
    {
        // bên dưới sau này sẽ chuyển thành user, lớp cha của company và employee
        Company company = new Company();
        public CompanyWindow()
        {
            InitializeComponent();
        }
        public CompanyWindow(Company company)
        {
            InitializeComponent();
            this.company = company;
            txtbName.Text = company.CompanyName;
        }
        private void CompanyWindow_Loaded(object sender, RoutedEventArgs e)
        {
            mainFarm.Navigate(new System.Uri("Pages/PageJob.xaml", UriKind.RelativeOrAbsolute));
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
            mainFarm.Navigate(new System.Uri("Pages/CreatJobWindow.xaml", UriKind.RelativeOrAbsolute));
        }

        private void popupControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnViecLam_Click(object sender, RoutedEventArgs e)
        {
            mainFarm.Navigate(new System.Uri("Pages/PageJob.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            Filter filter = new Filter(cbbLocation.Text,cbbExperience.Text);
            JobDAO jobDAO = new JobDAO();
            jobDAO.DataJob =  jobDAO.Search(filter);
            var dataTransfer = jobDAO.LoadPage();
            
            mainFarm.Navigate(new System.Uri("Pages/CreatJobWindow.xaml", UriKind.RelativeOrAbsolute), dataTransfer);
        }
        // Hàm bên dưới vẫn đang trong quá trình phát triển
        // Mục đích: Chỉnh đối tượng nằm bên trong Frame để dùng được hàm search
/*        private void mainFarm_LoadCompleted(object sender, NavigationEventArgs e)
        {
            MessageBox.Show(this.GetVisualChild(1).ToString());
        }*/
    }
}
