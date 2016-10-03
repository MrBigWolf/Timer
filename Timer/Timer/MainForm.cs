using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class MainForm : Form
    {

        public Time time;

        public MainForm()
        {
            InitializeComponent();

            time = new Time();
        }

        public void PrintTime(Time time)
        {
            string time_string = "";
            if (time.GetHours() < 10) time_string += "0";
            time_string += time.GetHours();
            time_string += " : ";
            if (time.GetMinutes() < 10) time_string += "0";
            time_string += time.GetMinutes();
            time_string += " : ";
            if (time.GetSeconds() < 10) time_string += "0";
            time_string += time.GetSeconds();
            labelTime.Text = time_string;
        }

        private void EncreaseTime(int seconds)
        {
            time.Encrease(seconds);
            PrintTime(time);
        }

        private void DecreaseTime(int seconds)
        {
            time.Decrease(seconds);
            PrintTime(time);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            PrintTime(time);
            mainTimer.Enabled = true;
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            if (time.GetHours() > 0 || time.GetMinutes() > 0 || time.GetSeconds() > 0)
            {
                time.Decrease(1);
                PrintTime(time);
            }
            else
                mainTimer.Enabled = false;
        }

        private void buttonHoursPlus_Click(object sender, EventArgs e)
        {
            EncreaseTime(3600);
        }

        private void buttonMinutesPlus_Click(object sender, EventArgs e)
        {
            EncreaseTime(60);
        }

        private void buttonSecondsPlus_Click(object sender, EventArgs e)
        {
            EncreaseTime(1);
        }

        private void buttonHoursMinus_Click(object sender, EventArgs e)
        {
            DecreaseTime(3600);
        }

        private void buttonMinutesMinus_Click(object sender, EventArgs e)
        {
            DecreaseTime(60);
        }

        private void buttonSecondsMinus_Click(object sender, EventArgs e)
        {
            DecreaseTime(1);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            mainTimer.Enabled = false;
            PrintTime(time);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            time = new Time();
            PrintTime(time);
        }
    }
}
