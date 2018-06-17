using System;

namespace DateDemo
{
    class Date
    {
        private int year;
        private int month;
        private int day;

        public Date(int m, int d, int y)
        {
            year = y;
            month = m;
            day = d;
            FixDate();
        }
        public override string ToString()
        {
            return string.Format("{0:d2}/{1:d2}/{2}", month, day, year);
        }
        public void AddDays(int howMany)
        {
            day += howMany;
            FixDate();
        }
        private void FixDate()
        {
            while (day > 30)
            {
                day -= 30;
                month++;
            }
            while (month > 12)
            {
                month -= 12;
                year++;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Date d1 = new Date(12, 01, 2015);
            Console.WriteLine(d1);

            Console.WriteLine("\nAdding 5 days");
            d1.AddDays(5);
            Console.WriteLine(d1);

            Console.WriteLine("\nAdding 65 days");
            d1.AddDays(65);
            Console.WriteLine(d1);
        }
    }
}




