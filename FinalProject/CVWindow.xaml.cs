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
        public CVWindow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD

            CV cv = new CV(txtCareerGoal.Text);

=======
/*            CV cv = new CV(txtSkillName.Text);
>>>>>>> 5dc7a870300befa3890ee160c0a46604bedad170
            CVDao cVDao = new CVDao();
            cVDao.Them(cv);*/
        }
    }
}
