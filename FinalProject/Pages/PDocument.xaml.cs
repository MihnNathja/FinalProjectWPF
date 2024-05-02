using FinalProject.Objects;
using FinalProject.Database;
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
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalProject.Page
{
    /// <summary>
    /// Interaction logic for PDocument.xaml
    /// </summary>
    public partial class PDocument : System.Windows.Controls.Page
    {
        Company company;
        public PDocument()
        {
            InitializeComponent();
        }
        public PDocument(Company company)
        {
            InitializeComponent();
            Company = company;
            DataContext = Company;
        }

        public Company Company { get => company; set => company = value; }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Company.Field = txtLinhVuc.Text;
            Company.Description = txtMoTa.Text;
            CompanyDAO companyDAO = new CompanyDAO();
            companyDAO.Sua(Company);
        }
    }
}
