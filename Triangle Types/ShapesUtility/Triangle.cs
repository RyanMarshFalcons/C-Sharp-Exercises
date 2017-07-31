using System;

namespace ShapesUtility
{
    public enum TriangleType { Equilateral, Isosceles, Scalene };

    public class Triangle
    {
        public TriangleType typeOfTriangle(double side1, double side2, double side3)
        {
            InvalidTraingle(side1, side2, side3);
            
            if (Equilateral(side1, side2, side3))
            {
                return TriangleType.Equilateral;
            }
            else if (Isosceles(side1, side2, side3))
            {
                return TriangleType.Isosceles;
            }
            else
            {
                return TriangleType.Scalene;
            }
        }

        private void InvalidTraingle(double side1, double side2, double side3)
        {
            if ((side1 > (side2 + side3)) || (side2 > (side1 + side3)) || (side3 > (side1 + side2)) || (side1 == 0 || side2 == 0 ||side3 ==0)) 
            {
                throw new System.ArgumentException(Constants.InvalidTriangleDimentions);
            }
        }

        private bool Equilateral(double side1, double side2, double side3)
        {
            return ((side1 == side2) && (side1 == side3));  
        }

        private bool Isosceles(double side1, double side2, double side3)
        {
            if (((side1 == side2) && (side1 != side3)) || ((side2 == side3) && (side2 != side1)) || ((side1 == side3) && (side1 != side2)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}


