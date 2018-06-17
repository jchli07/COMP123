using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Rational
    {
        public int Numerator {get; private set;}
        public int Denominator { get; private set;}

        public Rational(int Numerator = 0, int Denominator = 1)
        {
            this.Numerator = Numerator;
            this.Denominator = Denominator;
        }
        //constructor
        public override string ToString()
        {
            return string.Format("{0}/{1}", Numerator, Denominator);
        }
        public void IncreaseBy(Rational other)
        {
            //Finding common denominator
            Numerator = (Numerator * other.Denominator) + (other.Numerator * Denominator);
            Denominator = Denominator * other.Denominator;
        }
        public void DecreaseBy(Rational other)
        {
            //Finding common denominator
            Numerator = (Numerator * other.Denominator) - (other.Numerator * Denominator);
            Denominator = Denominator * other.Denominator;
        }
    }
}
