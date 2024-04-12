using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class JobViewModel : INotifyPropertyChanged
    {
        private string _companyName;
        public string CompanyName
        {
            get { return _companyName; }
            set
            {
                _companyName = value;
                OnPropertyChanged(nameof(CompanyName));
            }
        }

        private string _jobName;
        public string JobName
        {
            get { return _jobName; }
            set
            {
                _jobName = value;
                OnPropertyChanged(nameof(JobName));
            }
        }

        private string _location;
        public string Location
        {
            get { return _location; }
            set
            {
                _location = value;
                OnPropertyChanged(nameof(Location));
            }
        }

        // Khai báo các thuộc tính khác cần thiết và triển khai INotifyPropertyChanged
        // cho mỗi thuộc tính để thông báo khi giá trị thay đổi.

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
