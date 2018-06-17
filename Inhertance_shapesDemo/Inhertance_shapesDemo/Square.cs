using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance_shapesDemo
{
    class Square : Shape
    {
        public double Length { get; protected set; }

        public Square(string name, double Length)
            : base(name) 
        {
            this.Length = Length;
        }
        public override double Area
        {
            get
            {
                return Length * Length;
            }
        }
            
    }
}
