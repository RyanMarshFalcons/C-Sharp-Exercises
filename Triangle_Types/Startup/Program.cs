using System;
using ShapesUtility;

namespace Startup
{
    public class Program
    {
        static void Main(string[] args)
        {
            TriangleType triangleType;

            Console.WriteLine("Let's find out what type of triangle you have. Press enter to continue.");
            Console.ReadLine();

            int side1 = GetSideLength(1);
            int side2 = GetSideLength(2);
            int side3 = GetSideLength(3);

            var userTriangle = new Triangle();

            try
            {
                triangleType = userTriangle.typeOfTriangle(side1, side2, side3);
                Console.WriteLine("\nYour triangle is " + triangleType);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            Console.ReadLine();
        }

        static int GetSideLength(int sideNumber)
        {
            bool validEntry = false;
            int sideLength = 0;
            while (validEntry == false){
                string Userinput = GetInput(sideNumber);
                validEntry = CheckIfValidSideLength(Userinput);
                if (validEntry == true) 
                {
                    sideLength = Int32.Parse(Userinput);
                }                        
            }
            return sideLength;
        }

        static string GetInput(int sideNumber)
        {
            Console.Write($"\nPlease input the length of side {sideNumber} of your triangle and then press \nenter: ");
            return Console.ReadLine();
        }

        public static bool CheckIfValidSideLength(string input)
        {
            if (CheckIfNotInt(input))
            {
                Console.WriteLine("\nThe length of your triangle's side must be a whole number.\n" + input + " is not a whole number.");
                return false;
            }
            int numberInput = Convert.ToInt32(input);
            if (CheckIfNegative(numberInput))
            {
                Console.WriteLine("\nThe length of your triangle's side must be a positive number.\n" + input + " is a negative number.");
                return false;
            }
            return true;

        }

        static bool CheckIfNotInt(string input)
        {
            int sideLength;
            bool isInt = Int32.TryParse(input, out sideLength);
            isInt = !isInt;
            return isInt;
        }

        static bool CheckIfNegative(int numberInput)
        {
            return numberInput < 0;
        }
    }
}
