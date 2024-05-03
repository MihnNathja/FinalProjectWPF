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
    /// Interaction logic for UCNotification.xaml
    /// </summary>
    public partial class UCNotification : UserControl
    {
        string isAccepted;
        DateTime dateInterview;
        Employee employee;
        Job job;
        public UCNotification()
        {
            InitializeComponent();
        }
        public UCNotification( string isAccepted, DateTime dateInterview)
        {
            InitializeComponent();
            IsAccepted = isAccepted;
            DateInterview = dateInterview;
        }


        public string IsAccepted { get => isAccepted; set => isAccepted = value; }
        public DateTime DateInterview { get => dateInterview; set => dateInterview = value; }
        public Employee Employee { get => employee; set => employee = value; }
        public Job Job { get => job; set => job = value; }

        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {
            CVDAO cVDAO = new CVDAO();
            cVDAO.Confirm(Job, Employee, 1);
        }

        private void btnSee_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Coi sau nè");
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            txtbCompanyName.Text = Job.CompanyName;
            if (IsAccepted == "True")
            {
                txtbIsAccept.Text = "Đã được duyệt";
                txtbIsAccept.Foreground = Brushes.LightGreen;
                txtbDateInterview.Text = DateInterview.ToShortDateString();
                txtbConfirmAnnoucement.Visibility = Visibility.Visible;
                txtbAnnoucement.Visibility = Visibility.Visible;
            }
            else if (IsAccepted == "False")
            {
                txtbIsAccept.Text = "Đã bị từ chối";
                txtbIsAccept.Foreground = Brushes.Red;
            }
            else
            {
                txtbIsAccept.Text = "Hồ sơ chưa được duyệt";
                txtbIsAccept.Foreground = Brushes.Gray;
            }    
        }

    }
}
