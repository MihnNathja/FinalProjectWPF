﻿using FinalProject.Database;
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
using System.Windows.Shapes;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for SignUpCompany.xaml
    /// </summary>
    public partial class SignUpCompany : Window
    {
        public SignUpCompany()
        {
            InitializeComponent();
        }

       

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            Company company = new Company
                (txtUserName.Text,
                txtPassword.Password,
                txtCompanyName.Text,
                txtMST.Text,
                txtLocationCompany.Text,
                txtboss.Text,
                txtPhoneNumber.Text,
                txtEmail.Text,
                "",
                "");
            CompanyDAO companyDAO = new CompanyDAO();
            companyDAO.Them(company);
            this.Close();
        }
    }
}
