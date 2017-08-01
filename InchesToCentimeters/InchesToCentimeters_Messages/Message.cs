using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchesToCentimeters_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Inches to Centimeters promgram. Enter a distance in inches and I\nwill tell you how far that distance is in centimeters. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterDistance()
        {
            Console.Write("Please enter the number of inches: ");
        }

        public static void NotADistance(string input)
        {
            Console.Write($"\nSorry but {input} inches is not a distance. Please input a valid number of\ninchess: ");
        }

        public static void CantBeNegative()
        {
            Console.Write("\nSorry but distances cannot be negative. Please input a valid number of\ninches: ");
        }

        public static void DisplayCentimeters(double numOfInches, double numOfCentimeters)
        {
            Console.WriteLine($"\n{numOfInches} inches is equal to {numOfCentimeters} centimeters.");
        }
    }
}
