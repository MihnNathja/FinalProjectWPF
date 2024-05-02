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
using System.Windows.Shapes;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for WJobInfoDetail.xaml
    /// </summary>
    public partial class WJobInfoDetail : Window
    {
        User user;
        Job job;
        public WJobInfoDetail()
        {
            InitializeComponent();
            
        }

        public WJobInfoDetail(Job job)
        {
            InitializeComponent();
            DataContext = job;
            Job = job; 
        }
        public WJobInfoDetail(User user, Job job)
        {
            InitializeComponent();
            DataContext = job;
            Job = job;
            User = user;
        }
        public Job Job { get => job; set => job = value; }
        public User User { get => user; set => user = value; }

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            UserDAO userDAO = new UserDAO();
            Employee employee = new Employee();
            employee = userDAO.GetUser(employee, user);
            WSelectCV wSelectCV = new WSelectCV(employee,job);
            wSelectCV.ShowDialog();
            this.Close();
        }
    }
}
