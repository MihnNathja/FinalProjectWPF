﻿using FinalProject.Objects;
using FinalProject.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for WSignUpJobApplicant.xaml
    /// </summary>
    public partial class WSignUpJobApplicant : Window
    {
        public WSignUpJobApplicant()
        {
            InitializeComponent();
        }


        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            string gender = "";
            if (Male.IsChecked == true)
            {
                gender = "Male";
            }
            else if (Female.IsChecked == true)
            {
                gender = "Female";
            }
            Employee employee = new Employee(txtUserName.Text,pbPassword.Password,txtFullName.Text, gender,txtAddress.Text, dtpDateOfBirth.SelectedDate.Value, txtCCCD.Text);
            EmployeeDAO employeeDAO = new EmployeeDAO();
            employeeDAO.Them(employee);
            this.Close();
        }
    }
}