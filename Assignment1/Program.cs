//Rational Assignment
//James Li
//Brandon Koo
//Janurary 23, 2017

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            Rational fraction1 = new Rational(1, 2);
            Rational fraction2 = new Rational(5, 6);
            Rational fraction3 = new Rational(2, 5);
            Rational fraction4 = new Rational(5, 12);

            Console.WriteLine("Fraction 1: {0}, Fraction 2: {1}, Fraction 3: {2}, Fraction 4: {3}",fraction1,fraction2,fraction3,fraction4);

            fraction1.IncreaseBy(fraction2);
            Console.WriteLine("\nAdding Fraction 1 with Fraction 2: {0}",fraction1);

            fraction3.DecreaseBy(fraction4);
            Console.WriteLine("\nSubtraction Fraction 3 by Fraction 4: {0}", fraction3);
        }
    }
}
