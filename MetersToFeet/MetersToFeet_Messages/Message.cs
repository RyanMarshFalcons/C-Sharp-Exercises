using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetersToFeet_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Meters to Feet promgram. Enter a distance in meters and I will\ntell you how far that distance is in feet. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterDistance()
        {
            Console.Write("Please enter the number of meters: ");
        }

        public static void NotADistance(string input)
        {
            Console.Write($"\nSorry but {input} meters is not a distance. Please input a valid number of\nmeters: ");
        }

        public static void CantBeNegative()
        {
            Console.Write("\nSorry but distances cannot be negative. Please input a valid number of\nmeters: ");
        }

        public static void DisplayFeet(double numOfMeters, double numOfFeet)
        {
            Console.WriteLine($"\n{numOfMeters} meters is equal to {numOfFeet} feet.");
        }
    }
}
