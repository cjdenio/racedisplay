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
using System.Windows.Threading;
using System.Timers;

namespace RaceDisplay
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            InitializeComponent();
        }

        int milliseconds = 0;
        int seconds = 0;
        int minutes = 0;

        void timer_Tick(object sender, EventArgs e){
            milliseconds++;
            if(milliseconds >= 100)
            {
                milliseconds = 0;
                seconds++;
            }
            TimerLabel.Content = seconds.ToString()+"."+milliseconds.ToString();
        }
        
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            switch (StartButton.Content)
            {
                case "Start":
                    timer.Start();
                    StartButton.Content = "Stop";
                    break;
                case "Stop":
                    timer.Stop();
                    StartButton.Content = "Start";
                    break;
            }
        }
    }
}
