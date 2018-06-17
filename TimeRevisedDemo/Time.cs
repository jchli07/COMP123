using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeRevisedDemo
{
    class Time
    {
        //static field
        private static TimeFormat TIME_FORMAT = TimeFormat.Hour12;
        //properities
        public int Hour { get; private set; }
        public int Minute { get; private set; }
        //constructor
        public Time(int Hour, int Minute)
        {
            this.Hour = Hour;
            this.Minute = Minute;
            if (Hour < 0 || Hour > 24)
                Hour = 0;
            if (Minute < 0 || Minute > 60)
                Minute = 0;
                   
        }
        public override string ToString()
        {
            string result;
            switch (TIME_FORMAT)
            {
                case TimeFormat.Mil:
                    result = string.Format("{0:d2}{1:d2}", Hour, Minute);
                    break;
                case TimeFormat.Hour24:
                    result = string.Format("{0:d2}:{1:d2}", Hour, Minute);
                    break;
                default:
                    result = string.Format("{0:d2}:{1:d2} {2}", Hour % 12, Minute, (Hour > 12) ? "PM" : "AM");
                    break;
            }
            return result;
        }
        public static void SetTimeFormat(TimeFormat newformat)
        {
            TIME_FORMAT = newformat;
        }
    }
 
}
