using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7
{
    public class Circle : Geometry
    {
        // Auto-implemented properties
        public double _radius { get; set; }

        // Constructor
        public Circle(double radius = 7.0)
        {
            _radius = radius;
        }

        // Area method for calculating area of a circle
        public override double Area()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

    }
}
