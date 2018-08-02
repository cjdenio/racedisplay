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

using System.Net;
using System.Net.Sockets;

namespace Stopwatch
{
    public partial class Form1 : Form
    {
        const string clockFilePath = "Output/clock.txt";
        const string ageGroupFilePath = "Output/ageGroup.txt";
        const string contestantFilePath = "Output/currentContestant.txt";
        const string savedTimesFilePath = "Output/savedTimes.txt";
        int rawTimerValue = 0;
        int minutes = 0;
        int seconds;
        string fullClockValue;

        PresentationForm presentationForm = new PresentationForm();

        public Form1()
        {
            InitializeComponent();
            fullClockValue = "00:00";
            /*if (!File.Exists(clockFilePath))
            {
                File.Create(clockFilePath);
            }*/
            Directory.CreateDirectory("Output");

            File.WriteAllText(clockFilePath, fullClockValue);

            presentationForm.Show();

            comboBox1.SelectedIndex = 0;
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
            File.WriteAllText(clockFilePath, fullClockValue);

            presentationForm.label1.Text = fullClockValue;
        }
        bool isActive = false;
        private void startButton_Click(object sender, EventArgs e)
        {
            startTimer();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            resetTimer();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            /*if (!File.Exists("C:/Users/cjden/Desktop/currentContestant.txt"))
            {
                File.Create("C:/Users/cjden/Desktop/currentContestant.txt");
            }
            if (!File.Exists("C:/Users/cjden/Desktop/ageGroup.txt"))
            {
                File.Create("C:/Users/cjden/Desktop/ageGroup.txt");
            }*/
            File.WriteAllText(contestantFilePath, contestantTextBox.Text);
            File.WriteAllText(ageGroupFilePath, ageGroupTextBox.Text);

            presentationForm.currentContestant.Text = contestantTextBox.Text;
            presentationForm.ageGroup.Text = ageGroupTextBox.Text;
        }
        private void saveTime()
        {
            // Who knew? File.AppendAllText automatically creates files.
            /*if (!File.Exists(savedTimesPath))
            {
                File.Create(savedTimesPath);
            }*/
            File.AppendAllText(savedTimesFilePath, contestantTextBox.Text + '\t' + ageGroupTextBox.Text + '\t' + clockText.Text + "\r\n");
        }

        private void saveTimeButton_Click(object sender, EventArgs e)
        {
            saveTime();
        }

        private void clearDataButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(savedTimesFilePath, "");
        }

        private void clearScreenButton_Click(object sender, EventArgs e)
        {
            contestantTextBox.Text = "";
            ageGroupTextBox.Text = "";
            File.WriteAllText(contestantFilePath, "");
            File.WriteAllText(ageGroupFilePath, "");

            presentationForm.currentContestant.Text = "";
            presentationForm.ageGroup.Text = "";
        }

        public void resetTimer()
        {
            isActive = false;
            startButton.Text = "Start";
            rawTimerValue = 0;
            minutes = 00;
            seconds = 00;
            timer.Stop();
            fullClockValue = "00:00";
            clockText.Text = fullClockValue;
            File.WriteAllText(clockFilePath, fullClockValue);

            presentationForm.label1.Text = "00:00";
        }

        public void startTimer()
        {
            if (this.InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate () {
                    startTimer();
                }));
            }
            isActive = !isActive;
            switch (isActive)
            {
                case true:
                    startButton.Text = "Stop";
                    timer.Start();
                    break;
                default:
                    startButton.Text = "Start";
                    timer.Stop();
                    break;
            }
            //startButton.Text = "";
        }

        private void outputButton_Click(object sender, EventArgs e)
        {
            if(outputButton.Text == "Output on")
            {
                outputButton.Text = "Output off";
                presentationForm.Hide();
            }
            else
            {
                outputButton.Text = "Output on";
                presentationForm.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Screen[] screens = Screen.AllScreens;
            int index = comboBox1.SelectedIndex;

            if(index < screens.Length)
            {
                presentationForm.Location = screens[index].Bounds.Location;
                presentationForm.Size = new Size(screens[index].Bounds.Width, screens[index].Bounds.Height);
            }
        }
    }
}
