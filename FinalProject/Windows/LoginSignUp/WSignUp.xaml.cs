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
    /// Interaction logic for WSignUp.xaml
    /// </summary>
    public partial class WSignUp : Window
    {
        public WSignUp()
        {
            InitializeComponent();
        }

        private void btnWSignUpCompany_Click(object sender, RoutedEventArgs e)
        {
            WSignUpCompany WSignUpCompany = new WSignUpCompany();
            WSignUpCompany.Show();
            this.Close();
        }

        private void btnSignUpJobApplicant_Click(object sender, RoutedEventArgs e)
        {
            WSignUpEmployee sign=new WSignUpEmployee();
            sign.Show();
            this.Close();
        }
    }
}
