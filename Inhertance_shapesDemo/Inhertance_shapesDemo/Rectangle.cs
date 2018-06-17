using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance_shapesDemo
{
    class Rectangle : Shape
    {
        public double Width { get; protected set; }
        public double Height { get; protected set; }

        public Rectangle(string name, double height, double width)
            : base(name)
        {
            Height = height;
            Width = width;
        }

        public override double Area
        {
            get 
            {
                return Width * Height;
            }
        }
    }
}
