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

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for UCJobInfo.xaml
    /// </summary>
    public partial class UCJobInfo : UserControl, INotifyPropertyChanged
    {
        private string url;
        int id;
        public UCJobInfo()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public string Url 
        { 
            get => url;
            set { 
                url = value; 
                OnPropertyChange(Url);
            }
        }

        public int ID { get => id; set => id = value; }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChange(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
