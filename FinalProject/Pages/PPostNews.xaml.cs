﻿using FinalProject.Objects;
using FinalProject.Windows.Employee;
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

namespace FinalProject.Pages
{
    /// <summary>
    /// Interaction logic for PPostNews.xaml
    /// </summary>
    public partial class PPostNews : System.Windows.Controls.Page
    {
        Employee employee;

        public Employee Employee { get => employee; set => employee = value; }

        public PPostNews(Employee employee)
        {
            InitializeComponent();
            Employee = employee;
        }

        public PPostNews()
        {
            InitializeComponent();
        }

        private void btnThemTin_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
