using FinalProject.Database;
using FinalProject.Objects;
using FinalProject.User_Control;
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
    /// Interaction logic for PCV.xaml
    /// </summary>
    public partial class PCV : System.Windows.Controls.Page
    {
        Employee employee;
        public Employee Employee { get => employee; set => employee = value; }
        public PCV()
        {
            InitializeComponent();
        }
        public PCV(Employee employee)
        {
            InitializeComponent();
            
            Employee = employee;
        }


        private void btnCreateCV_Click(object sender, RoutedEventArgs e)
        {
            
            WCV WCV = new WCV(Employee);
            WCV.ShowDialog();
            Page_Loaded(sender, e);

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CVList.Children.Clear();
            CVDAO cVDAO = new CVDAO();
            List<UCCVEmployee> data = cVDAO.GetEmployeeCVToCreate(Employee);
            foreach (UCCVEmployee cv in data)
            {
                CVList.Children.Add(cv);
            }
        }


    }
}
