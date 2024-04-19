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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalProject.User_Control
{
    /// <summary>
    /// Interaction logic for UCCVApply.xaml
    /// </summary>
    public partial class UCCVApply : UserControl
    {
        string id;
        Employee employee;
        Job job;
        CVDAO cVDAO = new CVDAO();
        CV cv;
        public string ID { get => id; set => id = value; }
        public Employee Employee { get => employee; set => employee = value; }
        public Job Job { get => job; set => job = value; }

        public UCCVApply()
        {
            InitializeComponent();
        }
        public UCCVApply(string id)
        {
            InitializeComponent();
            ID = id;
            cv = cVDAO.GetObject(ID);
            DataContext = cv;
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            cVDAO.Apply(Job, cv, Employee);
        }
    }
}
