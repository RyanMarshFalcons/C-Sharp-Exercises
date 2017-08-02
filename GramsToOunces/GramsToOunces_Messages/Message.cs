using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GramsToOunces_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Grams to Ounces program. Enter a weight in grams and I will tell\nyou the weight in ounces. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterWeight()
        {
            Console.Write("Please enter the number of grams: ");
        }

        public static void NotAWeight(string input)
        {
            Console.Write($"\nSorry but {input} grams is not a weight. Please input a valid number of\ngrams: ");
        }

        public static void CantBeNegative()
        {
            Console.Write("\nSorry but weights cannot be negative. Please input a valid number of\ngrams: ");
        }

        public static void DisplayOunces(double numOfGrams, double numOfOunces)
        {
            Console.WriteLine($"\n{numOfGrams} grams is equal to {numOfOunces} ounces.");
        }
    }
}
