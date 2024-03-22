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
    /// Interaction logic for CreateJob.xaml
    /// </summary>
    public partial class CreateJob : Window
    {
        public CreateJob()
        {
            InitializeComponent();
        }


        private void btnPost_Click(object sender, RoutedEventArgs e)
        {
            Job job = new Job(txtbName.Text,txtbCompanyName.Text,cbbSalary.Text,txtbLocation.Text);
            
        }
    }
}
