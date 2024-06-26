﻿using FinalProject.Database;
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

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for WCreateJob.xaml
    /// </summary>
    public partial class WCreateJob : Window
    {
        JobDAO jobDAO = new JobDAO();
        string idJob;
        public string IdJob { get => idJob; set => idJob = value; }


        public WCreateJob()
        {
            InitializeComponent();
        }
        public WCreateJob(Company company)
        {
            InitializeComponent();
            DataContext = company;
        }
        public WCreateJob(Job job)
        {
            InitializeComponent();
            DataContext = job;
            txtbDescription.Text = job.Description;
        }


        private void btnPost_Click(object sender, RoutedEventArgs e)
        {
            Job job = new Job(jobDAO.GetNextID(),txtbJobName.Text,txtbCompanyName.Text,txtbSalary.Text,txtbExperience.Text,txtbLocation.Text,txtbDescription.Text,txtbRequire.Text, txtbBenefit.Text,txtbWorkTime.Text);
            jobDAO.Them(job);
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
/*            Job job = new Job(IdJob, txtbName.Text, txtbCompanyName.Text, cbbSalary.Text, txtbLocation.Text);
            jobDAO.Sua(job);*/
            this.Close();
        }
    }
}
