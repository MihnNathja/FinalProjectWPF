using FinalProject.Database;
using FinalProject.Objects;
using FinalProject.Windows.Employee;
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
        Employee employee;
        News news;
        string idCV;
        public Grid Grid {  get; set; }
        public string IdCV { get => idCV; set => idCV = value; }
        public CV CV { get => cV; set => cV = value; }
        public Employee Employee { get => employee; set => employee = value; }
        public News News { get => news; set => news = value; }
       

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
            UCCV uCCV = new UCCV(IdCV);
            uCCV.btnAccept.Visibility = Visibility.Collapsed;
            uCCV.btnReject.Visibility = Visibility.Collapsed;
            Grid.Children.Add(uCCV);
            News.IdCV = IdCV;
            Close_Page();
        }
        private void Close_Page()
        {
            // Lấy ra cửa sổ chứa UserControl hiện tại
            Window window = Window.GetWindow(this);

            // Kiểm tra xem window có tồn tại và có phải là MainWindow không
            if (window != null && window is WSelectCVNews)
            {
                // Gọi phương thức tải lại trang trong MainWindow
                (window as WSelectCVNews).Close_Window();
            }
        }
    }
}
