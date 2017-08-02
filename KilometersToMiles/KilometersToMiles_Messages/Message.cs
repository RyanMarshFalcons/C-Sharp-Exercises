using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KilometersToMiles_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Kilometers to Miles program. Enter a distance in kilometers and I\nwill tell you how far that distance is in miles. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterDistance()
        {
            Console.Write("Please enter the number of kilometers: ");
        }

        public static void NotADistance(string input)
        {
            Console.Write($"\nSorry but {input} kilometers is not a distance. Please input the number\nof kilometers: ");
        }

        public static void CantBeNegative()
        {
            Console.Write("\nSorry but distances cannot be negative. Please input the number of\nkilometers: ");
        }

        public static void DisplayMiles(double numOfKilometers, double numOfMiles)
        {
            Console.WriteLine($"\n{numOfKilometers} kilometers is equal to {numOfMiles} miles.");
        }
    }
}
