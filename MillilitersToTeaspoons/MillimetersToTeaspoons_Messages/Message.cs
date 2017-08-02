using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillilitersToTeaspoons_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Milliliters to Teaspoons program. Enter a volume in milliliters\nand I will tell you the volume in teaspoons. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterVolume()
        {
            Console.Write("Please enter the number of milliliters: ");
        }

        public static void NotAVolume(string input)
        {
            Console.Write($"\nSorry but {input} milliliters is not a volume. Please input a valid number of\nmilliliters: ");
        }

        public static void CantBeNegative()
        {
            Console.Write("\nSorry but volumes cannot be negative. Please input a valid number of\nmilliliters: ");
        }

        public static void DisplayTeaspoons(double numOfMilliliters, double numOfTeaspoons)
        {
            Console.WriteLine($"\n{numOfMilliliters} milliliters is equal to {numOfTeaspoons} teaspoons.");
        }
    }
}
