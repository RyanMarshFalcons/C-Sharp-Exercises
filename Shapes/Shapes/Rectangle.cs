using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public double width { get; set; }
        public double height { get; set; }
        public double CalculateArea()
        {
            return width * height;
        }

        public double CalculatePerimiter()
        {
            return width * 2 + height * 2;
        }
    }
}
