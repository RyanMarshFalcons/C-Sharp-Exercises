using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slightly_More_20_Messages
{
    public class Message
    {

        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Slightly More 20 program. Enter a number and I will tell you\nwhether or not your number is slightly more than a multiple of 20. Press enter\nto continue.");
            Console.ReadLine();
        }

        public static void EnterNumber()
        {
            Console.Write("Please enter a number: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please input a number: ");
        }

        public static void CantBeNegative()
        {
            Console.Write("\nSorry but the number cannot be negative. Please input a number: ");
        }

        public static void IsSlightlyMore(int num)
        {
            Console.WriteLine($"\nCongratulations {num} is slightly more than a multiple of 20!!!");
        }

        public static void IsNotSlightlyMore(int num)
        {
            Console.WriteLine($"\nUnfortunately {num} is not slightly more than a multiple of 20.");
        }
    }
}
