using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractionCalculatorDemo
{
    class Fraction
    {
        public class Fraction
        {
            public int Top { get; private set; }
            public int Bottom { get; private set; }

            public Fraction(int top = 0, int bottom = 1) { Top = top; Bottom = bottom; }

            public static Fraction operator +(Fraction left, Fraction right)
            {
                return new Fraction(left.Top * right.Bottom + right.Top * left.Bottom, left.Bottom * right.Bottom);
            }

            public static Fraction operator -(Fraction left, Fraction right)
            {
                return new Fraction(left.Top * right.Bottom - right.Top * left.Bottom, left.Bottom * right.Bottom);
            }

            public static Fraction operator *(Fraction left, Fraction right)
            {
                return new Fraction(left.Top * right.Top, right.Bottom * left.Bottom);
            }

            public static Fraction operator /(Fraction left, Fraction right)
            {
                return new Fraction(left.Top * right.Bottom, right.Top * left.Bottom);
            }

            public override string ToString()
            {
                return string.Format("[{0}, {1}]", Top, Bottom);
            }
        }

    }
}
