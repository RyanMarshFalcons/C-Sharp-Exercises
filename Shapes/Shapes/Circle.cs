using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        const double pi = 3.14;
        public double radius { get; set; }
        public double CalculateArea()
        {
            return pi * radius * radius;
        }

        public double CalculatePerimiter()
        {
            return 2 * pi * radius;
        }
    }
}
