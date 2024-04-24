﻿using FinalProject.Database;
using FinalProject.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for UCCompanyJob.xaml
    /// </summary>
    public partial class UCCompanyJob : UserControl
    {
        Company company;
        Job job;
        string id;
        public string ID { get => id; set => id = value; }
        public Company Company { get => company; set => company = value; }
        public Job Job { get => job; set => job = value; }

        public UCCompanyJob()
        {
            InitializeComponent();
        }
        public UCCompanyJob(Job job)
        {
            CVDAO cVDAO = new CVDAO();
            InitializeComponent();
            Job = job;
            ID = Job.Id;
            NumberOfEmployee.Content = cVDAO.GetNumberCVOfJob(ID);
            CompanyName.Text = Job.CompanyName;
            JobName.Content = Job.JobName;
            Salary.Text = Job.Salary;
            JobLocation.Text = Job.JobLocation;
        }


        private void UserControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // hiển thị ra danh sách các CV apply vào công việc này
            WCompanyAcceptCV wCompanyAcceptCV = new WCompanyAcceptCV(Company, Job);
            wCompanyAcceptCV.ShowDialog();
        }
    }
}
