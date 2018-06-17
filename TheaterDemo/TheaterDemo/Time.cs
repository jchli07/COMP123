using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterDemo
{

    //this is the time data type
    class Time
    {
        public int Hours { get; private set; }
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }

        //constructor for time type
        public Time(int h, int m, int s) {
            Hours = h;
            Minutes = m;
            Seconds = s;
        }

        //
        public override string ToString()
        {
            return string.Format("{0:D2}:{1:D2}:{2:D2}",Hours,Minutes,Seconds);
        }

        //public static bool operator == (Time left, Time right) 
        //{
        //    return left.Hours == right.Hours;
        //}
        //public static bool operator != (Time left, Time right)
        //{
        //    return left.Hours != right.Hours;
        //}

    }
    
    enum MovieDay {Sun, Mon, Tue, Wed, Thu, Fri, Sat}

    [Flags]
    enum MovieGenre {
        Unrated = 0,
        Action = 1,
        Romance = 2,
        Documentary = 4,
        Mystery = 8,
        Musical = 16,
        Horror = 32,
        Comedy = 64 }
}
