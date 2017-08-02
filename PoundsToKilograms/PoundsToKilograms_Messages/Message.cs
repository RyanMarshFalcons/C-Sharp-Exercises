using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoundsToKilograms_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Pounds to Kilograms program. Enter a weight in pounds and I will\ntell you the weight in kilograms. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterWeight()
        {
            Console.Write("Please enter the number of pounds: ");
        }

        public static void NotAWeight(string input)
        {
            Console.Write($"\nSorry but {input} pounds is not a weight. Please input a valid number of\npounds: ");
        }

        public static void CantBeNegative()
        {
            Console.Write("\nSorry but weights cannot be negative. Please input a valid number of\npounds: ");
        }

        public static void DisplayKilograms(double numOfPounds, double numOfKilograms)
        {
            Console.WriteLine($"\n{numOfPounds} pounds is equal to {numOfKilograms} kilograms.");
        }
    }
}
