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

namespace FinalProject.User_Control
{
    /// <summary>
    /// Interaction logic for UCCVApplyNews.xaml
    /// </summary>
    public partial class UCCVApplyNews : UserControl
    {
        CVDAO cVDAO = new CVDAO();
        CV cV;
        Job job;
        Employee employee;
        string idCV;
        public string IdCV { get => idCV; set => idCV = value; }
        public CV CV { get => cV; set => cV = value; }
        public Job Job { get => job; set => job = value; }
        public Employee Employee { get => employee; set => employee = value; }
        public UCCVApplyNews()
        {
            InitializeComponent();
        }
        public UCCVApplyNews(string idCV)
        {
            InitializeComponent();
            IdCV = idCV;
            CV = cVDAO.GetObject(IdCV);
            EmployeeDAO EmployeeDAO = new EmployeeDAO();
            Employee = EmployeeDAO.GetEmployee(CV.ID);
            DataContext = Employee;
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            cVDAO.ApplyCV(CV, Employee);
        }
    }
}
