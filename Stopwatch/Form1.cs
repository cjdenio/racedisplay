using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Stopwatch
{
    public partial class Form1 : Form
    {
        string filePath = "C:/Users/cjden/Desktop/clock.txt";
        int rawTimerValue = 0;
        int minutes = 0;
        int seconds;
        string fullClockValue;

        public Form1()
        {
            InitializeComponent();
            fullClockValue = "00:00";
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }
            File.WriteAllText(filePath, fullClockValue);
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            rawTimerValue++;
            if(seconds < 59)
            {
                seconds++;
            }
            else
            {
                seconds = 0;
                minutes++;
            }
            //Ternary operator used to add a 0 before values with only one character
            fullClockValue = (minutes.ToString().Length == 1 ? "0" + minutes.ToString() : minutes.ToString()) + ":" + (seconds.ToString().Length == 1 ? "0"+seconds.ToString() : seconds.ToString());
            clockText.Text = fullClockValue;
            File.WriteAllText("C:/Users/cjden/Desktop/clock.txt", fullClockValue);
        }
        bool isActive = false;
        private void startButton_Click(object sender, EventArgs e)
        {
            isActive = !isActive;
            switch (isActive)
            {
                case true: startButton.Text = "Stop";
                    timer.Start();
                    break;
                default: startButton.Text = "Start";
                    timer.Stop();
                    break;
            }
            //startButton.Text = "";
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            isActive = false;
            startButton.Text = "Start";
            rawTimerValue = 0;
            minutes = 00;
            seconds = 00;
            timer.Stop();
            fullClockValue = "00:00";
            clockText.Text = fullClockValue;
            File.WriteAllText("C:/Users/cjden/Desktop/clock.txt", fullClockValue);
        }
    }
}
