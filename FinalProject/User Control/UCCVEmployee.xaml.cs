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
    /// Interaction logic for UCCVEmployee.xaml
    /// </summary>
    public partial class UCCVEmployee : UserControl
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
        public UCCVEmployee()
        {
            InitializeComponent();
        }
        public UCCVEmployee(string id)
        {
            InitializeComponent();
            InitializeComponent();
            ID = id;
            CV = cVDAO.GetObject(ID);
            EmployeeDAO EmployeeDAO = new EmployeeDAO();
            Employee = EmployeeDAO.GetEmployee(CV.ID);
            DataContext = Employee;
        }


        private void btnCVDetail_Click(object sender, RoutedEventArgs e)
        {
            WCV WCV = new WCV(CV);
            WCV.Show();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            CVDAO cVDAO= new CVDAO();
            cVDAO.Xoa(CV);
            
            Reload();
        }
        private void Reload()
        {
            // Lấy ra cửa sổ chứa UserControl hiện tại
            Window window = Window.GetWindow(this);

            // Kiểm tra xem window có tồn tại và có phải là MainWindow không
            if (window != null && window is WEmployee)
            {
                // Gọi phương thức tải lại trang trong MainWindow
                (window as WEmployee).Reload(employee);
            }
        }
    }
}
