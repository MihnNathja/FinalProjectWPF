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
    /// Interaction logic for UCDay.xaml
    /// </summary>
    public partial class UCDay : UserControl
    {
        public UCDay()
        {
            InitializeComponent();
        }

        private void btnDay_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(btnDay.Content.ToString());
        }
    }
}
