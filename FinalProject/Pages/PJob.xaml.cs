﻿using FinalProject.Database;
using FinalProject.Objects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime;
using System.Runtime.CompilerServices;
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

namespace FinalProject.Page
{
    /// <summary>
    /// Interaction logic for PJob.xaml
    /// </summary>
    public partial class PJob : System.Windows.Controls.Page
    {
        
        JobDAO jobDAO = new JobDAO();
        Employee employee;

        
        public Employee Employee { get => employee; set => employee = value; }

        public PJob()
        {
            InitializeComponent();
           
            AddLocationToComboBox();
        }

       
        
        public PJob(Employee employee)
        {
            Employee = employee;
            InitializeComponent();
            AddLocationToComboBox();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            pnlJob.Children.Clear();
            List<UCJobInfo> jobList = jobDAO.LoadPage();
            
            foreach (UCJobInfo job in jobList)
            {
                job.User = employee;
                job.Type = Employee.Type;
               
                job.btnDeleteJob.Visibility = Visibility.Hidden;
                pnlJob.Children.Add(job);
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            PJob PJob = new PJob(Employee);
            search(cbbLocation.Text, cbbExperience.Text);


        }

        private void AddLocationToComboBox()
        {
            List<string> location = new List<string>
            {
                "Hà Nội", "Hồ Chí Minh", "Hải Phòng", "Cần Thơ", "Đà Nẵng",
                "Biên Hòa", "Nha Trang", "Buôn Ma Thuột", "Huế", "Long Xuyên",
                "Thái Nguyên", "Vũng Tàu", "Thanh Hóa", "Quy Nhơn", "Đà Lạt",
                "Nam Định", "Vinh", "Bắc Ninh", "Thái Bình", "Cà Mau",
                "Hải Dương", "Uông Bí", "Bắc Giang", "Bến Tre", "Quảng Ninh",
                "Trà Vinh", "Kiên Giang", "Vĩnh Long", "Ninh Bình", "Bình Phước",
                "Hà Nam", "Phan Thiết", "Đồng Hới", "Sóc Trăng", "Kon Tum",
                "Bạc Liêu", "Yên Bái", "Tuy Hòa", "Đồng Xoài", "Pleiku",
                "Hà Tĩnh", "Tây Ninh", "Lạng Sơn", "Hòa Bình", "Bắc Kạn",
                "Cao Bằng", "Sơn La", "Điện Biên", "Lai Châu", "Lào Cai",
                "Hà Giang", "Bắc Cạn", "Nước ngoài"
            };

            foreach (string tinh in location)
            {
                cbbLocation.Items.Add(tinh);
            }
        }
        public void search(string location, string experience)
        {
            pnlJob.Children.Clear();
            location = cbbLocation.SelectedItem.ToString();
            experience = cbbExperience.SelectedItem.ToString();


            List<UCJobInfo> joblist = jobDAO.Search(location, experience);
            foreach (UCJobInfo job in joblist)
            {
                job.User = employee;
                job.Type = Employee.Type;

                job.btnDeleteJob.Visibility = Visibility.Hidden;
                pnlJob.Children.Add(job);
            }
        }



        //public void search(string location, string experience)
        //{
        //    filter filter = new filter(location, experience);
        //    jobdao.datajob = jobdao.search(filter);
        //    pnljob.children.clear();
        //    list<ucjobinfo> joblist = jobdao.loadpage();
        //    foreach (ucjobinfo job in joblist)
        //    {
        //        job.user = user;
        //        job.type = user.type;
        //        pnljob.children.add(job);
        //    }
        //}
    }
}

