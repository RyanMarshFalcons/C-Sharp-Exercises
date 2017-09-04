using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    public static class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my shapes program where you will select a shape and input the\nnecessary measurements so that I can calculate the area and the perimeter of\nyour shape for you. Press enter to continue.");
            Console.ReadLine();
        }
        public static void SelectShapeType()
        {
            Console.WriteLine($"Please select the shape you want to work with:\n(A) Square \n(B) Rectangle \n(C) Triangle\n(D) Trapezoid \n(E) Circle");
        }

        public static void InvalidShapeSelection(string input)
        {
            Console.WriteLine($"\nI'm sorry but {input} is not a valid selection.\nPlease select the shape you want to work with:\n(A) Square \n(B) Rectangle \n(C) Triangle\n(D) Trapezoid \n(E) Circle");
        }

        public static void PositiveDoubleWasNotInput(string lengthAsString)
        {
            Console.WriteLine($"I'm sorry but {lengthAsString} is not a valid entry of length");
        }

        public static void ProgramFlowIsIncorrect()
        {
            Console.WriteLine("If you're reading this message than something in the program design is way off.");
        }

        public static void DisplayResult(string typeOfShape, double area, double perimeter)
        {
            Console.WriteLine($"\nThe area of your {typeOfShape} is {area}");
            Console.WriteLine($"The perimeter of your {typeOfShape} is {perimeter}");
            Console.WriteLine("Press enter to close the progam.");
        }

        public static void DisplaySquareCharacteristics()
        {
            Console.WriteLine("\nA square has four sides of equal length with four right angles.");
        }
        public static void DisplayRectangleCharacteristics()
        {
            Console.WriteLine("\nA rectangle has two pairs of sides of equal length with four right angles.");
        }
        public static void DisplayTriangleCharacteristics()
        {
            Console.WriteLine("\nA triangle has three sides and the sum of its interior angles is 180 degrees.");
        }
        public static void DisplayTrapezoidCharacteristics()
        {
            Console.WriteLine("\nA trapezoid has a pair of parallel sides called bases and a pair of lateral \nsides called legs.");
        }
        public static void DisplayCircleCharacteristics()
        {
            Console.WriteLine("\nA circle is perfectly round. The radius is the unchanging length between any \npoint on the perimeter and the center of the circle.");
        }
    }
}
