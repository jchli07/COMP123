using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhertance_shapesDemo
{
    abstract class Shape
    {
        public string Name { get; protected set; }
        public abstract double Area { get; }

        public Shape(string Name)
        {
            this.Name = Name;
        }

        public override string ToString()
        {
            return string.Format("Shape: {0} | Area = {1}", Name, Area);
        }
    }
}
