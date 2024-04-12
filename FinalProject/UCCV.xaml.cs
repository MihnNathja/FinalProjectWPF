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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for UCCV.xaml
    /// </summary>
    public partial class UCCV : UserControl
    {

        string id;
        public string ID { get => id; set => id = value; }
        public UCCV()
        {
            InitializeComponent();
        }

        private void UCCV_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CVDAO cVDAO = new CVDAO();
            MessageBox.Show(ID);
            CV cV = cVDAO.GetObject(this.ID);

            CVWindow cVWindow = new CVWindow();
            cVWindow.DataContext = cV;
            cVWindow.Show();
        }
    }
}