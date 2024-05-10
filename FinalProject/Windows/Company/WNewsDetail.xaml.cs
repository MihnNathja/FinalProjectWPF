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

namespace FinalProject.Windows.Company
{
    /// <summary>
    /// Interaction logic for WNewsDetail.xaml
    /// </summary>
    public partial class WNewsDetail : Window
    {
        News news;
        public WNewsDetail()
        {
            InitializeComponent();
        }
        public WNewsDetail(News news)
        {
            InitializeComponent();
            News = news;
            DataContext = News;
            UCCV uCCV = new UCCV(News.IdCV);
            uCCV.btnAccept.Visibility = Visibility.Collapsed;
            uCCV.btnReject.Visibility = Visibility.Collapsed;
            gridCV.Children.Add(uCCV);
        }

        public News News { get => news; set => news = value; }

    }
}
