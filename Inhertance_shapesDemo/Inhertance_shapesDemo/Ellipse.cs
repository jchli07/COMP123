using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance_shapesDemo
{
    class Ellipse : Rectangle
    {
        public Ellipse(string name, double height, double width)
            : base(name, height, width)
        { 
        }

        public override double Area
        {
            get 
            {
                return Math.PI * Width * Height; 
            }
        }

    }
}
