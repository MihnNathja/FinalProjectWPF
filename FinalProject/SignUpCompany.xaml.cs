﻿using System;
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

        
        private void btnDangKy_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Đăng ký thành công, quay lại trang đăng nhập để đăng nhập");
            this.Close();
        }
    }
}