using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance_shapesDemo
{
    class Triangle : Rectangle
    {
        public Triangle(string name, double width, double height)
            : base(name, width, height)
        {
            
        }

        public override double Area
        {
            get
            {
                 return Width * Height * 0.5;
            }
 
        }
    }
}
