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

namespace FinalProject.Windows.Employee
{
    /// <summary>
    /// Interaction logic for WNews.xaml
    /// </summary>
    public partial class WNews : Window
    {
        Objects.Employee employee;
        public Objects.Employee Employee { get => employee; set => employee = value; }
        string IdCV;
        CVDAO cVDAO = new CVDAO();
        NewsDAO newsDAO = new NewsDAO();
        public WNews(Objects.Employee employee)
        {
            InitializeComponent();
            Employee = employee;
        }
        public WNews()
        {
            InitializeComponent();
        }
        

        private void btnPost_Click(object sender, RoutedEventArgs e)
        {
            if (IdCV != null)
            {
                News news = new News(Employee.ID, IdCV, txtbJobName.Text, txtbExperience.Text, txtbLocation.Text, txtbSalary.Text, txtbDescription.Text, txtbBenefit.Text, txtbWorkTime.Text);
                newsDAO.SuaNews(news);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn CV!");
            }
            Reload_Page(employee);
        }

        private void btnSelectCV_Click(object sender, RoutedEventArgs e)
        {
            gridCV.Children.Clear();
            WSelectCVNews wSelectCVNews = new WSelectCVNews(Employee);
            wSelectCVNews.ShowDialog();
            IdCV = cVDAO.GetIdUCNews();
            UCCV uCCV = new UCCV(IdCV);
            uCCV.btnAccept.Visibility = Visibility.Collapsed;
            uCCV.btnReject.Visibility = Visibility.Collapsed;
            gridCV.Children.Add(uCCV);
        }
        private void Reload_Page(Objects.Employee employee)
        {
            // Lấy ra cửa sổ chứa UserControl hiện tại
            Window window = Window.GetWindow(this);

            // Kiểm tra xem window có tồn tại và có phải là MainWindow không
            if (window != null && window is WEmployee)
            {
                // Gọi phương thức tải lại trang trong MainWindow
                (window as WEmployee).Reload_page(employee);
            }
        }

    }
}
