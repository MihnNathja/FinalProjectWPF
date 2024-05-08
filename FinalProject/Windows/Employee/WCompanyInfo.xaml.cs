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

namespace FinalProject.Windows.Employee
{
    /// <summary>
    /// Interaction logic for WCompanyInfo.xaml
    /// </summary>
    public partial class WCompanyInfo : Window
    {
        Company company;

        public Company Company { get => company; set => company = value; }

        public WCompanyInfo(Company company)
        {
            InitializeComponent();
            Company = company;
            DataContext = Company;
        }

        public WCompanyInfo()
        {
            InitializeComponent();
        }
    }
}
