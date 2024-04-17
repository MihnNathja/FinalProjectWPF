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
    /// Interaction logic for WJobInfoDetail.xaml
    /// </summary>
    public partial class WJobInfoDetail : Window
    {
        Job job = new Job();
        public WJobInfoDetail()
        {
            InitializeComponent();
            
        }

        public WJobInfoDetail(Job job)
        {
            InitializeComponent();
            this.DataContext = job;
            this.Job = job; 
        }

        public Job Job { get => job; set => job = value; }

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            CVDAO cVDAO = new CVDAO();
            /*cVDAO.Apply(Job, cv);*/
        }
    }
}
