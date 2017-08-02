using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KilogramsToPounds_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Kilograms to Pounds program. Enter a weight in kilograms and I\nwill tell you the weight in pounds. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterWeight()
        {
            Console.Write("Please enter the number of kilograms: ");
        }

        public static void NotAWeight(string input)
        {
            Console.Write($"\nSorry but {input} kilograms is not a weight. Please input a valid number of\nkilograms: ");
        }

        public static void CantBeNegative()
        {
            Console.Write("\nSorry but weights cannot be negative. Please input a valid number of\nkilograms: ");
        }

        public static void DisplayPounds(double numOfKilograms, double numOfPounds)
        {
            Console.WriteLine($"\n{numOfKilograms} kilograms is equal to {numOfPounds} pounds.");
        }
    }
}
