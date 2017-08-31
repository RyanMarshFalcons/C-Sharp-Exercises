using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evenly_Spaced_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Evenly Spaced program where you will enter five numbers and then Iwill tell you if they are evenly spaced or not. Press enter to continue.");
            Console.ReadLine();
        }

        public static void EnterNumber(string firstSecondThird)
        {
            Console.Write($"\nPlease enter the {firstSecondThird} number: ");
        }

        public static void NotANumber(string input, string firstSecondThird)
        {
            Console.Write($"\nSorry but {input} is not a number. Please input the {firstSecondThird} number: ");
        }

        public static void AreEvenlySpaced()
        {
            Console.WriteLine("\nCongratulations your numbers are evenly spaced!!! Press enter to close the\nprogram.");
        }

        public static void AreNotEvenlySpaced()
        {
            Console.WriteLine("\nUnfortunately your numbers are not evenly spaced. Press enter to close the\nprogram.");
        }
    }
}
