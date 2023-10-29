using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7
{
    public class Rectangle : Geometry
    {
        // Auto-implemented properties
        private double _length { get; set; }
        private double _width { get; set; }

        // Constructor
        public Rectangle(double length = 3.0, double width = 5.0)
        {
            _length = length;
            _width = width;
        }

        // Area method for calculating area of a rectangle
        public override double Area()
        {
            return _length * _width;
        }

    }
}
