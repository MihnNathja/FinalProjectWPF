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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            LoginPage loginPage = new LoginPage();
            LoginFrame.Navigate(loginPage);
        }

        public void NavigateToLoginPage()
        {
            LoginPage loginPage = new LoginPage();
            LoginFrame.Navigate(loginPage);
        }
        private void btnDangKy_Click(object sender, RoutedEventArgs e)
        {
            // Điều hướng đến trang đăng nhập
            NavigateToLoginPage();
        }
        private void btnDangKyDN_Click(object sender, RoutedEventArgs e)
        {
            SignUpCompany signUpCompany = new SignUpCompany();
            signUpCompany.ShowDialog();
        }

        private void btnDangKyUV_Click(object sender, RoutedEventArgs e)
        {
            SignUpPage signUpPage = new SignUpPage();
            LoginFrame.Navigate(signUpPage);

        }
    }
}
