using System;

namespace lab4.BL
{
    public class TimeDisplay
    {
        int seconds;
        int minutes;
        int hours;

        public int Seconds
        {
            get
            {
                return seconds;
            }
            set
            {
                if(value >= 0 && value <= 60)
                {
                    if (value == 60)
                    {
                        seconds = 0;
                        minutes++;
                        minutes = ValidateMinutesAndSeconds(minutes, out int period);
                        if (period > 0)
                        {
                            hours += period;
                            hours = ValidateHours(hours);
                        }
                    }
                    else
                        seconds = value;
                }
                else
                    throw new ArgumentException("Seconds should be from 0 to 60.");
            }
        }
        public int Minutes
        {
            get
            {
                return minutes;
            }
            set
            {
                if(value >= 0 && value <= 60)
                {
                    if(value == 60)
                    {
                        minutes = 0;
                        hours++;
                        hours = ValidateHours(hours);
                    }
                    else
                        minutes = value;
                }
                else
                    throw new ArgumentException("Minutes should be from 0 to 60.");
            }
        }
        public int Hours
        {
            get
            {
                return hours;
            }
            set
            {
                if (value >= 0 && value <= 24)
                {
                    if (value == 24)
                        hours = 0;
                    else
                        hours = value;
                }
                else
                    throw new ArgumentException("Hours should be from 0 to 24.");
            }
        }

        public TimeDisplay()
        {

        }
        public TimeDisplay(int seconds, int minutes, int hours)
        {
            seconds = ValidateMinutesAndSeconds(seconds, out int period);
            if (period > 0)
                minutes += period;
            this.seconds = seconds;
            minutes = ValidateMinutesAndSeconds(minutes, out period);
            if (period > 0)
                hours += period;
            this.minutes = minutes;
            hours = ValidateHours(hours);
            this.hours = hours;
        }
        public void ChangeHours(int hours)
        {
            this.hours += hours;
            this.hours = ValidateHours(this.hours);
        }
        public void ChangeMinutes(int minutes)
        {
            this.minutes += minutes;
            int period = this.minutes / 60;
            if(period > 0)
            {
                this.minutes -= 60 * period;
                hours += period;
                hours = ValidateHours(hours);
            }
        }
        public void ChangeSeconds(int seconds)
        {
            this.seconds += seconds;
            int period = this.seconds / 60;
            if(period > 0)
            {
                this.seconds -= 60 * period;
                minutes += period;
                int periodM = minutes / 60;
                if(periodM > 0)
                {
                    minutes -= 60 * period;
                    hours += periodM;
                    hours = ValidateHours(hours);
                }
            }
        }
        private int ValidateHours(int hours)
        {
            int period = hours / 24;
            if (period > 0)
                hours -= 24 * period;
            return hours;
        }
        private int ValidateMinutesAndSeconds(int time, out int period)
        {
            period = time / 60;
            if (period > 0)
                time -= 60 * period;
            return time;
        }
    }
}
