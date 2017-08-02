using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OuncesToGrams_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Ounces to Grams program. Enter a weight in ounces and I will\ntell you the weight in grams. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterWeight()
        {
            Console.Write("Please enter the number of ounces: ");
        }

        public static void NotAWeight(string input)
        {
            Console.Write($"\nSorry but {input} ounces is not a weight. Please input a valid number of\nounces: ");
        }

        public static void CantBeNegative()
        {
            Console.Write("\nSorry but weights cannot be negative. Please input a valid number of\nounces: ");
        }

        public static void DisplayGrams(double numOfOunces, double numOfGrams)
        {
            Console.WriteLine($"\n{numOfOunces} ounces is equal to {numOfGrams} grams.");
        }
    }
}
