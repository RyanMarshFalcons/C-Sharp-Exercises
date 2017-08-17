using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Even Odd program. Enter a number and I will tell you whether that number is an even or an odd number. Press enter to continue.");
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

        public static void IsEven(int num)
        {
            Console.WriteLine($"\n{num} is an even number.");
        }

        public static void IsOdd(int num)
        {
            Console.WriteLine($"\n{num} is an odd number.");
        }
    }
}
