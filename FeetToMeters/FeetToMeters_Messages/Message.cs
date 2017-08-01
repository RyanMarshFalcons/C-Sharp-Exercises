using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeetToMeters_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Feet to Meters promgram. Enter a distance in feet and I will tell you how far that distance is in meters. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterDistance()
        {
            Console.Write("Please enter the number of feet: ");
        }

        public static void NotADistance(string input)
        {
            Console.Write($"\nSorry but {input} feet is not a distance. Please input a valid number of\nfeet: ");
        }

        public static void CantBeNegative()
        {
            Console.Write("\nSorry but distances cannot be negative. Please input a valid number of\nfeet: ");
        }

        public static void DisplayMeters(double numOfFeet, double numOfMeters)
        {
            Console.WriteLine($"\n{numOfFeet} feet is equal to {numOfMeters} meters.");
        }
    }
}
