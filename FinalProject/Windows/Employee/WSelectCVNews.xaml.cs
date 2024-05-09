using FinalProject.Database;
using FinalProject.User_Control;
using System;
using System.Collections;
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
    /// Interaction logic for WSelectCVNews.xaml
    /// </summary>
    public partial class WSelectCVNews : Window
    {
        CVDAO cVDAO = new CVDAO();
        Objects.Employee employee;
        public Objects.Employee Employee { get => employee; set => employee = value; }
        public WSelectCVNews()
        {
            InitializeComponent();
        }
        public WSelectCVNews(Objects.Employee employee)
        {
            InitializeComponent();
            Employee = employee;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            pnlCV.Children.Clear();
            
            List<UCCVApplyNews> data = cVDAO.GetEmployeeNewsCV(Employee);
            foreach (UCCVApplyNews cv in data)
            {
                pnlCV.Children.Add(cv);
            }
        }
       
        
    }
}
