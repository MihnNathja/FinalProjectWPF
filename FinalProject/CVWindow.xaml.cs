using FinalProject.Database;
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
    /// Interaction logic for CVWindow.xaml
    /// </summary>
    public partial class CVWindow : Window
    {
        CVDAO cVDAO = new CVDAO();
        public CVWindow()
        {
            InitializeComponent();
        }
        public CVWindow(Employee employee)
        {
            InitializeComponent();
            this.DataContext = employee;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {


            CV cv = new CV(cVDAO.GetNextID(),txtCVTitle.Text,txtCareerGoal.Text,txtSkill.Text, txtPresent.Text, txtExperience.Text, txtActivitie.Text, txtCertificate.Text, txtAward.Text, txtAddInformation.Text);


            
            cVDAO.Them(cv);
        }
    }
}
