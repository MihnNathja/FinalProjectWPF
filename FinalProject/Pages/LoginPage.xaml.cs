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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage 
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(UserName.Text == "FPT")
                {
                    Company company = new Company(UserName.Text, "test", "test", "test", "test");
                    CompanyWindow comp = new CompanyWindow(company);
                    comp.Show();
                }
                else
                {
                    CompanyWindow comp = new CompanyWindow();
                    comp.Show();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
