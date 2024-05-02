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

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for UCCV.xaml
    /// </summary>
    public partial class UCCV : UserControl
    {
        
        CVDAO cVDAO = new CVDAO();
        CV cV;
        Job job;
        Employee employee;
        string id;
        public string ID { get => id; set => id = value; }
        public CV CV { get => cV; set => cV = value; }
        public Job Job { get => job; set => job = value; }
        public Employee Employee { get => employee; set => employee = value; }

        public UCCV()
        {
            InitializeComponent();
        }
        public UCCV(string id)
        {
            InitializeComponent();
            ID = id;
            CV = cVDAO.GetObject(ID);
            EmployeeDAO EmployeeDAO = new EmployeeDAO();
            Employee = EmployeeDAO.GetEmployee(CV.ID);
            int accept = cVDAO.GetAcceptValue(id);
            if(accept == 0)
            {
                btnReject.IsEnabled = false;
                btnReject.Content = "ĐÃ TỪ CHỐI";
            }
            if (accept == 1)
            {
                btnAccept.IsEnabled = false;
                btnAccept.Content = "ĐÃ DUYỆT";
            }
            DataContext = Employee;
        }

        private void btnCVDetail_Click(object sender, RoutedEventArgs e)
        {
            WCV WCV = new WCV();
            WCV.DataContext = CV;
            WCV.Show();
        }

        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {

            cVDAO.Accept(Job, CV, Employee, 1);
            WInterview wInterview = new WInterview(Job, CV, Employee);
            wInterview.Show();
            
        }

        private void btnReject_Click(object sender, RoutedEventArgs e)
        {
            cVDAO.Accept(Job, CV, Employee, 0);
           
        }
    }
}
