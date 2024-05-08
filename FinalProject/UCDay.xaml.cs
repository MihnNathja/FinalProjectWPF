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
    /// Interaction logic for UCDay.xaml
    /// </summary>
    public partial class UCDay : UserControl
    {
        StackPanel stackPanelInterview;
        int day;
        bool hasEvent;
        List<TextBlock> txtbInterviewDates = new List<TextBlock>();
        public UCDay()
        {
            InitializeComponent();
        }
        public UCDay(int day)
        {
            InitializeComponent();
            Day = day;
            btnDay.Content = Day.ToString();
            HasEvent = false;
        }

        public StackPanel StackPanelInterview { get => stackPanelInterview; set => stackPanelInterview = value; }
        public int Day { get => day; set => day = value; }
        public bool HasEvent { get => hasEvent; set => hasEvent = value; }
        public List<TextBlock> TxtbInterviewDates { get => txtbInterviewDates; set => txtbInterviewDates = value; }

        private void btnDay_Click(object sender, RoutedEventArgs e)
        {
            StackPanelInterview.Children.Clear();
            foreach (TextBlock txt in txtbInterviewDates)
            {
                StackPanelInterview.Children.Add(txt);
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (HasEvent)
            {
                btnDay.Background = Brushes.LightCoral;
            }
        }
    }
}
