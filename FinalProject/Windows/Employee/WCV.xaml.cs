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
    /// Interaction logic for WCV.xaml
    /// </summary>
    public partial class WCV : Window
    {
        Employee employee;
        CVDAO cVDAO = new CVDAO();
        public WCV()
        {
            InitializeComponent();
        }
        public WCV(Employee employee)
        {
            InitializeComponent();
            this.DataContext = employee;
            Employee = employee;
            
        }
        public WCV(CV cV)
        {
            InitializeComponent();
            DataContext = cV;
            EmployeeDAO employeeDAO = new EmployeeDAO();
            Employee = employeeDAO.GetEmployee(cV.ID);
            this.IsEnabled = false;
            btnSave.Visibility = Visibility.Collapsed;
        }

        public Employee Employee { get => employee; set => employee = value; }

        private void Reload()
        {
            // Lấy ra cửa sổ chứa UserControl hiện tại
            Window window = Window.GetWindow(this);

            // Kiểm tra xem window có tồn tại và có phải là MainWindow không
            if (window != null && window is WEmployee)
            {
                // Gọi phương thức tải lại trang trong MainWindow
                (window as WEmployee).Reload(employee);
            }
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            CV cv = new CV(cVDAO.GetNextID(), Employee.ID, txtCVTitle.Text, txtCareerGoal.Text, txtSkill.Text, txtPresent.Text, txtExperience.Text, txtActivitie.Text, txtCertificate.Text, txtAward.Text, txtAddInformation.Text);
            cVDAO.Them(cv);
            this.Close();
            Reload();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dtpDateOfBirtday.Text = Employee.DateOfBirth.ToString();
            txtSDT.Text = Employee.Phone;
            txtAddress.Text = Employee.EmployeeLocation;
            txtCCCD.Text = Employee.Cccd;
            cbbGender.SelectedItem = Employee.Gender;
        }
    }
}
