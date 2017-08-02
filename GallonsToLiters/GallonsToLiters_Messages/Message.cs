using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GallonsToLiters_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Gallons to Liters program. Enter a volume in gallons and I will\ntell you the volume in liters. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterVolume()
        {
            Console.Write("Please enter the number of gallons: ");
        }

        public static void NotAVolume(string input)
        {
            Console.Write($"\nSorry but {input} gallons is not a volume. Please input a valid number of\ngallons: ");
        }

        public static void CantBeNegative()
        {
            Console.Write("\nSorry but volumes cannot be negative. Please input a valid number of\ngallons: ");
        }

        public static void DisplayLiters(double numOfGallons, double numOfLiters)
        {
            Console.WriteLine($"\n{numOfGallons} gallons is equal to {numOfLiters} liters.");
        }
    }
}
