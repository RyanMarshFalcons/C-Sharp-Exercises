using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Shape
    {
        public double side { get; set; }
        public double CalculateArea()
        {
            return side * side; 
        }

        public double CalculatePerimiter()
        {
            return side * 4;
        }

      
    }
}
