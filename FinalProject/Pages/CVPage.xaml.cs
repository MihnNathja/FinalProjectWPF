using FinalProject.Database;
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

namespace FinalProject.Page
{
    /// <summary>
    /// Interaction logic for CVPage.xaml
    /// </summary>
    public partial class CVPage : System.Windows.Controls.Page
    {
        public CVPage()
        {
            InitializeComponent();
        }

        private void btnCreateCV_Click(object sender, RoutedEventArgs e)
        {
            CVWindow cvWindow = new CVWindow();
            cvWindow.Show();
            Page_Loaded(sender, e);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CVList.Children.Clear();
            CVDAO cVDAO = new CVDAO();
            List<UCCV> data = cVDAO.LoadPage();
            foreach (UCCV cv in data)
            {
                
                CVList.Children.Add(cv);
            }
        }
    }
}
