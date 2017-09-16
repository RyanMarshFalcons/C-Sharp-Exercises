using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collatz_Conjecture_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Collatz Conjecture program. The Collatz Conjecture states that\nwhen you take any positive integer n, if n is even, divide n by 2 to get n / 2\nand if n is odd, multiply n by 3 and add 1 to get 3n + 1 and you repeat the\nprocess indefinitely then no matter which number you start with, you will alwaysreach 1 eventually. Once you input your starting number I will tell you how manysteps it will take for you to reach 1. Press enter to continue.");
            Console.ReadLine();
        }

        public static void InputNumber()
        {
            Console.Write("\nEnter the starting number: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please enter the starting number: ");
        }

        public static void MustBePositive()
        {
            Console.Write($"\nSorry but the starting number must be positive. Please enter the starting\nnumber: ");
        }

        public static void StepsListed(int startingNumber)
        {
            Console.WriteLine($"\nHere are the steps that it takes for {startingNumber} to reach 1:\n{startingNumber}");
        }

        public static void DisplayResults(int startingNumber, int numberOfSteps)
        {
            Console.WriteLine($"\nIt takes {numberOfSteps} stemps for the number {startingNumber} to reach the number 1 using the\nCollatz Conjecture. Press enter to close the program.");
        }
    }
}
