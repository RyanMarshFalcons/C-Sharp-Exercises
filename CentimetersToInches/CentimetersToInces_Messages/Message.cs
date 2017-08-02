using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentimetersToInches_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Centimeters to Inches program. Enter a distance in centimeters\nand I will tell you how far that distance is in inches. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterDistance()
        {
            Console.Write("Please enter the number of centimeters: ");
        }

        public static void NotADistance(string input)
        {
            Console.Write($"\nSorry but {input} centimeters is not a distance. Please input a valid number of\ncentimeters: ");
        }

        public static void CantBeNegative()
        {
            Console.Write("\nSorry but distances cannot be negative. Please input a valid number of\ncentimeters: ");
        }

        public static void DisplayInches(double numOfCentimeters, double numOfInches)
        {
            Console.WriteLine($"\n{numOfCentimeters} centimeters is equal to {numOfInches} inches.");
        }
    }
}
