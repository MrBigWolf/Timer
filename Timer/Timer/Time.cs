using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    public class Time
    {
        private uint seconds;
        private uint minutes;
        private uint hours;

        public Time() { seconds = 0; minutes = 0; hours = 0; }

        public Time(int seconds)
        {
            if (seconds < 0)
                seconds = 0;

            minutes = 0;
            hours = 0;

            while(seconds - 60 >= 0)
            {
                seconds -= 60;
                minutes++;

                if( minutes >= 60 )
                {
                    minutes = 0;
                    hours++;
                }

                if ( hours >= 24 )
                    hours = 0;
            }
            this.seconds = (uint)seconds;
        }

        public Time GetTime() { return this; }

        public int GetSeconds() { return (int)seconds; }
        public int GetMinutes() { return (int)minutes; }
        public int GetHours()   { return (int)hours; }

        public void Encrease(int seconds)
        {
            if (seconds < 0)
                seconds = 0;
            this.seconds += (uint)seconds;

            while ((int)(this.seconds) - 60 >= 0)
            {
                this.seconds -= 60;
                minutes++;

                if (minutes >= 60)
                {
                    minutes = 0;
                    hours++;
                }

                if (hours >= 24)
                    hours = 0;
            }
        }

        public void Decrease(int seconds)
        {
            if (seconds < 0)
                seconds = 0;

            while(seconds - this.seconds >= 0)
            {
                if (seconds > this.seconds)
                {
                    if (minutes > 0)
                    {
                        minutes--;
                        this.seconds += 60;
                    }
                    else if(hours > 0)
                    {
                        hours--;
                        this.minutes += 60;
                    }
                    else
                    {
                        seconds = (int)(this.seconds);
                        break;
                    }
                }
                else
                    this.seconds -= (uint)seconds;
            }
            this.seconds -= (uint)seconds;
        }
        
    }
}
