using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7
{
    public class Parallelogram : Geometry
    {
        // Auto-implemented properties
        private double _base { get; set; }
        private double _height { get; set; }

        // Constructor
        public Parallelogram(double Base = 2.0, double height = 4.0)
        {
            _base = Base;
            _height = height;
        }

        // Area method for calculating area of a parallelogram
        public override double Area()
        {
            return _base * _height;
        }
    }
}
