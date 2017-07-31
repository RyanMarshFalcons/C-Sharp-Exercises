using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToKilometers_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Miles to Kilometers promgram. Enter a distance in miles and I willtell you how far that distance is in kilometers. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterDistance()
        {
            Console.Write("Please enter the number of miles: ");
        }

        public static void NotADistance(string input)
        {
            Console.Write($"\nSorry but {input} miles is not a distance. Please input a valid number of\nmiles: ");
        }

        public static void CantBeNegative()
        {
            Console.Write("\nSorry but distances cannot be negative. Please input a valid number of\nmiles: ");
        }

        public static void DisplayKilometers(double numOfKilometers, double numOfMiles)
        {
            Console.WriteLine($"\n{numOfMiles} miles is equal to {numOfKilometers} kilometers.");
        }
    }
}
