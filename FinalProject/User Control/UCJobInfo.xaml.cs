using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FinalProject.Database;
using FinalProject.Objects;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for UCJobInfo.xaml
    /// </summary>
    public partial class UCJobInfo : UserControl, INotifyPropertyChanged
    {
        private string url;
        string id;
        string type;
        public string ID { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public UCJobInfo()
        {
            InitializeComponent();
            this.DataContext = this;
            if (Type == "Employee")
            {
                btnDeleteJob.IsEnabled = false;
            }
        }

        public string Url 
        { 
            get => url;
            set { 
                url = value; 
                OnPropertyChange(Url);
            }
        }



        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChange(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        private void btnDeleteJob_Click(object sender, RoutedEventArgs e)
        {
            JobDAO jobDAO = new JobDAO();
            Job job = new Job(this.ID);
            jobDAO.Xoa(job);
        }

        private void UCJobInfo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            JobDAO jobDAO = new JobDAO();
            Job job = jobDAO.GetObject(this.ID);
            if (Type == "Company")
            {
                CreateJob createJob = new CreateJob(job);
                createJob.ShowDialog();
            }
            else if (Type == "Employee")
            {
                WJobInfoDetail wJobInfoDetail = new WJobInfoDetail(job);
                wJobInfoDetail.ShowDialog();
            }
        }
    }
}
