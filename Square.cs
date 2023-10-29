using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7
{
    public class Square : Geometry
    {
        // Auto-implemented properties
        private double _side { get; set; }

        // Constructor
        public Square(double side = 4.0)
        {
            _side = side;
        }

        // Area method for calculating area of a square
        public override double Area()
        {
            return _side * _side;
        }
    }
}
