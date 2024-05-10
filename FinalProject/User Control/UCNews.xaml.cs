
﻿using FinalProject.Objects;
using FinalProject.Windows.Company;

﻿using FinalProject.Database;


using FinalProject.Windows.Employee;
using MaterialDesignThemes.Wpf;
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

namespace FinalProject.User_Control
{
    /// <summary>
    /// Interaction logic for UCNews.xaml
    /// </summary>
    public partial class UCNews : UserControl
    {
        Company company;
        Employee employee;
        string id;
        string type;
        News news;
        public string ID { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public Employee Employee { get => employee; set => employee = value; }
        public News News { get => news; set => news = value; }
        public Company Company { get => company; set => company = value; }

        public UCNews()
        {
            InitializeComponent();
        }
        public UCNews(News news)
        {
            InitializeComponent();
            News = news;
            JobName.Text = news.JobName;
            WorkTime.Text = news.WorkTime;
            Location.Text = news.Location;
            Experience.Text = news.Experience;
            Salary.Text = news.Salary;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = News;
            if (Type == "Company")
            {
                btnDeleteJob.Visibility = Visibility.Collapsed;
                NewsDAO newsDAO = new NewsDAO();
                if (newsDAO.checkExistCompanyInterestEmployee(Company.ID, news.IdEmployee, news.IdCV))
                {
                    favorite.Foreground = Brushes.Red;
                }
                else
                {
                    favorite.Foreground = Brushes.Gray;
                }
            }
            else if (Type == "Employee")
            {
                btnInterest.Visibility = Visibility.Collapsed;
            }
        }
        private void btnDeleteJob_Click(object sender, RoutedEventArgs e)
        {
            NewsDAO newsDAO = new NewsDAO();
            newsDAO.XoaNews(News);
        }





        private void btnDetail_Click(object sender, RoutedEventArgs e)
        {
            WNewsDetail wNewsDetail = new WNewsDetail(News);
            wNewsDetail.Show();
        }
        private void btnInterest_Click(object sender, RoutedEventArgs e)
        {
            NewsDAO newsDAO = new NewsDAO();
            
            if (newsDAO.checkExistCompanyInterestEmployee(Company.ID, news.IdEmployee, news.IdCV))
            {
                newsDAO.XoaCompanyInterestEmployee(Company.ID, news.IdEmployee, news.IdCV);
            }
            else
            {
                newsDAO.ThemCompanyInterestEmployee(Company.ID, news.IdEmployee, news.IdCV);
            }
            this.UserControl_Loaded(sender, e);

        }
    }
}
