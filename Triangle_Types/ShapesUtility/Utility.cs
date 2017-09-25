using System;
using Triangle_Messages;

namespace ShapesUtility
{
    public enum TriangleType { Equilateral, Isosceles, Scalene, Invalid };

    public class Utility
    {
        public int GetValidSideLength (string sideNumber)
        {
            Message.InputNumber(sideNumber);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NotANumber(input, sideNumber);
                }
                else
                {
                    if (CheckIfPositive(input) == false)
                    {
                        Message.MustBePositive(sideNumber);
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return int.Parse(input);
        }

        public bool CheckIfInt(string input)
        {
            var num = 0;
            return int.TryParse(input, out num);
        }

        public bool CheckIfPositive(string input)
        {
            return int.Parse(input) > 0;
        }

        public TriangleType typeOfTriangle(double side1, double side2, double side3)
        {
            if (InvalidTraingle(side1, side2, side3))
            {
                return TriangleType.Invalid;
            }
            else if (Equilateral(side1, side2, side3))
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

        public bool InvalidTraingle(double side1, double side2, double side3)
        {
            return side1 > (side2 + side3) || side2 > (side1 + side3) || side3 > (side1 + side2) || side1 == 0 || side2 == 0 || side3 == 0;
        }

        public bool Equilateral(double side1, double side2, double side3)
        {
            return side1 == side2 && side1 == side3;  
        }

        public bool Isosceles(double side1, double side2, double side3)
        {
            return (side1 == side2 && side1 != side3) || (side2 == side3 && side2 != side1) || (side1 == side3 && side1 != side2);
        }
    }
}


