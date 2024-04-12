using System;
using FinalProject.Database;
using FinalProject.Objects;
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
using FinalProject.Pages;

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
            
        }


        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            WSignUp wSignUp = new WSignUp();
            wSignUp.ShowDialog();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if(rdCompany.IsChecked == true)
            {
                Company company = new Company(txtUserName.Text,pbPassword.Password, "FPT", "", "", "","");
                UserDAO userDAO = new UserDAO();
/*                if (userDAO.checkExist(company) == true)
                {

                }*/
                CompanyWindow comp = new CompanyWindow(company);
                comp.ShowDialog();
            }
            else if (rdJobApplicant.IsChecked == true)
            {
                Employee employee = new Employee(txtUserName.Text, pbPassword.Password);
                UserDAO userDAO = new UserDAO();
/*                if (userDAO.checkExist(employee) == true)
                {

                }*/
                JobApplicantWindow jobApplicant = new JobApplicantWindow(employee);
                jobApplicant.ShowDialog();
            }
        }

        private void pbPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            string password = pbPassword.Password;
        }
    }
}
