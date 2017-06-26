using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {
        public double baseSide {get; set; }
        public double height { get; set; }
        public double side2 { get; set; }
        public double side3 { get; set; }


        public double CalculateArea()
        {
            return baseSide * height / 2;
        }

        public double CalculatePerimiter()
        {
            return baseSide + side2 + side3;
        }
    }
}
