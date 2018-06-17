using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeRevisedDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Time a = new Time(9, 35);
            Console.WriteLine(a);

            Time b = new Time(18, 5);
            Console.WriteLine(b);

            Time c = new Time(28, 500);
            Console.WriteLine(c);

            //change the format of the output
            Time.SetTimeFormat(TimeFormat.Mil);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            //change the format of the output
            Time.SetTimeFormat(TimeFormat.Hour24);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
