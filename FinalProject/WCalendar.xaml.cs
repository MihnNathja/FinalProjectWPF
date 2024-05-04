using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for WCalendar.xaml
    /// </summary>
    public partial class WCalendar : Window
    {

        int nowMonth;
        public WCalendar()
        {
            InitializeComponent();
            nowMonth = DateTime.Now.Month;
         
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Load_Day();
            
           
        }

        private void btnLeft_Click(object sender, RoutedEventArgs e)
        {
            if (nowMonth == 1)
            {
                btnLeft.IsEnabled = false;
            }
            else
            {
                btnRight.IsEnabled = true;
                
                nowMonth = nowMonth - 1;
                month.Text = nowMonth.ToString();
                Load_Day();
            }
        }

        private void btnRight_Click(object sender, RoutedEventArgs e)
        {

            if (nowMonth == 12)
            {
                btnRight.IsEnabled = false;
            }
            else
            {
                btnLeft.IsEnabled = true;
                nowMonth = nowMonth + 1;
                month.Text = nowMonth.ToString();
                Load_Day();
            }

        }
        public void Create_Day(int index)
        {
            wplDay.Children.Clear();
            month.Text = nowMonth.ToString();
            List<UCDay> calendar = new List<UCDay>();
            for (int i = 1; i <= index; i++)
            {
                UCDay day = new UCDay();
                day.btnDay.Content = i;
                calendar.Add(day);
            }
            foreach (UCDay day in calendar)
            {
                wplDay.Children.Add(day);
            }
        }
        public void Load_Day()
        {
            if(nowMonth == 2)
            {
                Create_Day(28);

            }
            else if(nowMonth == 4 || nowMonth == 6 || nowMonth == 9 || nowMonth == 11)
            {
                Create_Day(30);
            }
            else
            {
                Create_Day(31);
            }
        }
    }
}
