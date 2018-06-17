using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexDemo
{
    class Complex
    {
        public double Argument { get; }
        public int Imaginary { get; set; }
        public double Modulus { get; }
        public int Real { get; set; }

        public Complex(int Real, int Imaginary)
        {
            this.Real = Real;
            this.Imaginary = Imaginary;

        }
    }

}
