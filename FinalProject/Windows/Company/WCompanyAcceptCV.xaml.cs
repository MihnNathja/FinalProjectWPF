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
using System.Windows.Shapes;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for WCompanyAcceptCV.xaml
    /// </summary>
    public partial class WCompanyAcceptCV : Window
    {
        Company company = new Company();
        Job job = new Job();
        
        public Job Job { get => job; set => job = value; }
        public Company Company { get => company; set => company = value; }

        public WCompanyAcceptCV()
        {
            InitializeComponent();
        }
        public WCompanyAcceptCV(Company company, Job job)
        {
            InitializeComponent();
            Company = company;
            Job = job;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Reload();
        }
        public void Reload()
        {
            pnlCV.Children.Clear();
            CVDAO cvDAO = new CVDAO();
            List<UCCV> cvList = cvDAO.GetEmployeeCV(Job);

            foreach (UCCV cv in cvList)
            {
                cv.Job = job;
                pnlCV.Children.Add(cv);
            }
        }
    }
}
