using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterDemo
{
    class Show
    {
        public MovieDay Day { get; set; }
        public Movie movie { get; set; }
        public double Price { get; set; }
        public Time time { get; set; }

        public Show(Movie m, MovieDay d, double p, Time t) {
            movie = m;
            Day = d;
            Price = p;
            time = t;
        }

        public override string ToString()
        {
            return string.Format("{0}. Day: {1}. Time: {2}. Price: {3:c}",movie, Day, time, Price);
        }

    }
}
