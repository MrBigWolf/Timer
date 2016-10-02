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

        

        private void buttonStart_Click(object sender, EventArgs e)
        {
            time = new Time(100);
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
    }
}
