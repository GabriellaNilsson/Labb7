using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7
{
    public class Ellipse : Geometry
    {
        // Auto-implemented properties
        private double _a { get; set; } // Half-length of the longer axis
        private double _b { get; set; } // Half-length of the shorter axis

        // Constructor
        public Ellipse(double a = 5.0, double b = 3.0)
        {
            _a = a;
            _b = b;
        }

        // Area method for calculating area of an ellipse
        public override double Area()
        {
            return Math.PI * _a * _b;
        }
    }
}
