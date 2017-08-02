using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaspoonsToMilliliters_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Teaspoons to Milliliters program. Enter a volume in teaspoons and I will tell you the volume in milliliters. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterVolume()
        {
            Console.Write("Please enter the number of teaspoons: ");
        }

        public static void NotAVolume(string input)
        {
            Console.Write($"\nSorry but {input} teaspoons is not a volume. Please input a valid number of\nteaspoons: ");
        }

        public static void CantBeNegative()
        {
            Console.Write("\nSorry but volumes cannot be negative. Please input a valid number of\nteaspoons: ");
        }

        public static void DisplayMilliliters(double numOfTeaspoons, double numOfMilliliters)
        {
            Console.WriteLine($"\n{numOfTeaspoons} teaspoons is equal to {numOfMilliliters} milliliters.");
        }
    }
}
