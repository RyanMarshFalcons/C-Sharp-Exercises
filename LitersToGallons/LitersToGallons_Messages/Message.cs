using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LitersToGallons_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Liters to Gallons program. Enter a volume in liters and I will\ntell you the volume in gallons. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterVolume()
        {
            Console.Write("Please enter the number of liters: ");
        }

        public static void NotAVolume(string input)
        {
            Console.Write($"\nSorry but {input} liters is not a volume. Please input a valid number of\nliters: ");
        }

        public static void CantBeNegative()
        {
            Console.Write("\nSorry but volumes cannot be negative. Please input a valid number of\nliters: ");
        }

        public static void DisplayGallons(double numOfLiters, double numOfGallons)
        {
            Console.WriteLine($"\n{numOfLiters} liters is equal to {numOfGallons} gallons.");
        }
    }
}
