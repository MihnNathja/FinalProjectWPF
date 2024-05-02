using System;
using FinalProject.Database;
using FinalProject.Objects;
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
using FinalProject.Pages;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for WLogin.xaml
    /// </summary>
    public partial class WLogin : Window
    {
        public WLogin()
        {
            InitializeComponent();
            
        }


        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            OptionsPopup.IsOpen = true;
        }
        private void btnCompany_Click(object sender, RoutedEventArgs e)
        {
            WSignUpCompany WSignUpCompany = new WSignUpCompany();
            WSignUpCompany.Show();
            OptionsPopup.IsOpen= false;
        }
        private void btnEmployee_Click(object sender, RoutedEventArgs e)
        {
            WSignUpEmployee sign = new WSignUpEmployee();
            sign.Show();
            OptionsPopup.IsOpen = false;
        }

        
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            /*Khởi tạo đối tượng User và DAO của nó*/
            User user = new User();
            UserDAO userDAO = new UserDAO();

            /*Xét xem User được khởi tạo là kiểu lớp nào*/
            if (rdCompany.IsChecked == true)
            {
                user = new Company(txtUserName.Text, pbPassword.Password);
            }
            else if (rdJobApplicant.IsChecked == true)
            {
                user = new Employee(txtUserName.Text, pbPassword.Password);
            }

            /*Kiểm tra xem User có tồn tại hay không*/
            if (userDAO.checkExist(user) == true)
            {

                /*Nếu có, ứng với từng đối tượng, lấy thông tin của đối tượng đó từ database và gọi ra window tương ứng*/

                if (user.Type == "Company")
                {
                    Company company = new Company();
                    company = userDAO.GetUser(company, user);
                    WCompany comp = new WCompany(company);
                    comp.ShowDialog();
                }
                else if (user.Type == "Employee")
                {
                    Employee employee = new Employee();
                    employee = userDAO.GetUser(employee, user);
                    WEmployee jobApplicant = new WEmployee(employee);
                    jobApplicant.ShowDialog();
                }
            }
        }
    }
}
