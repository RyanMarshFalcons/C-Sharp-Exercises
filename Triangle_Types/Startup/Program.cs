using System;
using ShapesUtility;
using Triangle_Messages;

namespace Startup
{
    public class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var side1 = utility.GetValidSideLength("first");
            var side2 = utility.GetValidSideLength("second");
            var side3 = utility.GetValidSideLength("third");
            var triangleType = utility.typeOfTriangle(side1, side2, side3);
            if (triangleType == TriangleType.Invalid)
            {
                Message.ErrorMessage();
            }
            else
            {
                Message.DisplayResults(triangleType.ToString());
            }
            Console.ReadLine();
        }
    }
}
