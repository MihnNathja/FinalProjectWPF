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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for PNews.xaml
    /// </summary>
    public partial class PNews : System.Windows.Controls.Page
    {
        
        Employee employee;


        public Employee Employee { get => employee; set => employee = value; }
        public PNews()
        {
            InitializeComponent();
        }
        public PNews(Employee employee)
        {
            Employee = employee;
            InitializeComponent();
        }
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
