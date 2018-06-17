using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction_UnityDemo
{
    class Fraction
    {
        public int top { get; private set; }
        public int bottom { get; private set; }

        public Fraction(int top = 0, int bottom = 1);

        public static Fraction operator +(Fraction left, Fraction right)
        {
            return new Fraction(left.top + right.top, left.bottom + right.bottom);
        }
        public static Fraction operator -(Fraction left, Fraction right)
        {
            if( > )
                throw new Exception ("ERROR: Right is larger than left!");

            return new Fraction(left.top - right.top, left.bottom - right.bottom);
        }

        public override string ToString()
        {
            return string.Format("{0}{1}", top, bottom);
        }
    }
}
