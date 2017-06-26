using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Trapezoid : Shape
    {
        public double base1 { get; set; }

        public double base2 { get; set; }
        public double leg1 { get; set; }

        public double leg2 { get; set;  }

        public double height { get; set; }
        public double CalculateArea()
        {
            return height * ((base1 + base2) / 2);
        }

        public double CalculatePerimiter()
        {
            return base1 + base2 + leg1 + leg2;
        }
    }
}
