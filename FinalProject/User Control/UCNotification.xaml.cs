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
        string companyName;
        bool isAccepted;
        DateTime dateInterview;
        public UCNotification()
        {
            InitializeComponent();
        }
        public UCNotification(string companyName, bool isAccepted, DateTime dateInterview)
        {
            InitializeComponent();
            CompanyName = companyName;
            IsAccepted = isAccepted;
            DateInterview = dateInterview;
        }


        public bool IsAccepted { get => isAccepted; set => isAccepted = value; }
        public DateTime DateInterview { get => dateInterview; set => dateInterview = value; }
        public string CompanyName { get => companyName; set => companyName = value; }

        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Accept nè");
        }

        private void btnSee_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Coi sau nè");
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            txtbCompanyName.Text = CompanyName;
            if (IsAccepted == true)
            {
                txtbIsAccept.Text = "Đã được duyệt";
                txtbIsAccept.Foreground = Brushes.LightGreen;
                txtbDateInterview.Text = DateInterview.ToString();
            }
            else if (IsAccepted == false)
            {
                txtbIsAccept.Text = "Đã bị từ chối";
                txtbIsAccept.Foreground = Brushes.Red;
                txtbConfirmAnnoucement.Visibility = Visibility.Collapsed;
            }
        }
    }
}
