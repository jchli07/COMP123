using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance_shapesDemo
{
    class Circle : Square
    {
        public Circle(string name, double length)
            : base(name, length)
        {
        }

        public override double Area
        {
            get
            {
                return Math.PI * Length * Length;
            }
        }

    }
}
