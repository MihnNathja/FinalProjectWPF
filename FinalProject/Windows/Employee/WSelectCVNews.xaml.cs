using FinalProject.Database;
using FinalProject.Objects;
using FinalProject.User_Control;
using System;
using System.Collections;
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
    /// Interaction logic for WSelectCVNews.xaml
    /// </summary>
    public partial class WSelectCVNews : Window
    {
        CVDAO cVDAO = new CVDAO();
        Objects.Employee employee;
        News news;
        Grid Grid {  get; set; }
        public Objects.Employee Employee { get => employee; set => employee = value; }
        public News News { get => news; set => news = value; }

        public WSelectCVNews()
        {
            InitializeComponent();
        }
        public WSelectCVNews(Objects.Employee employee, News news, Grid gridCV)
        {
            InitializeComponent();
            Employee = employee;
            News = news;
            Grid = gridCV;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            pnlCV.Children.Clear();
            List<UCCVApplyNews> data = cVDAO.GetEmployeeNewsCV(Employee);
            foreach (UCCVApplyNews cv in data)
            {
                cv.Grid = Grid;
                cv.News = News;
                pnlCV.Children.Add(cv);
            }
        }
       public void Close_Window()
        {
            this.Close();
        }
        
    }
}
