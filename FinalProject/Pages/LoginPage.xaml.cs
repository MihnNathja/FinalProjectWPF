﻿using FinalProject.Objects;
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
           

            if(rdCompany.IsChecked == true)
            {
                CompanyWindow comp = new CompanyWindow();
                comp.Show();
            }

            if (rdJobApplicant.IsChecked == true)
            {
                JobApplicantWindow job = new JobApplicantWindow();
                job.Show();
            }
        }
    }
}
