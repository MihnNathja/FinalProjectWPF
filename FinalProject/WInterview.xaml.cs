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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for WInterview.xaml
    /// </summary>
    public partial class WInterview : Window
    {
        CVDAO cVDAO = new CVDAO();
        public WInterview()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            DateTime? selectedDate = calendar.SelectedDate;
            if (selectedDate.HasValue)
            {
                cVDAO.Write(selectedDate.Value);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
