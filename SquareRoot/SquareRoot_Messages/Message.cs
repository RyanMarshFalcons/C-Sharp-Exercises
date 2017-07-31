using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Square Root program. Enter a number and I will tell you what that number's square root is. Press enter to contine.");
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
            Console.WriteLine($"\nSorry but negative numbers can't have square roots because a negative times a\nnegative is a positive.");
        }

        public static void SquareRootOfNum(double num, double sqrrootOfNum)
        {
            Console.WriteLine($"\nThe square root of {num} is {sqrrootOfNum}");
        }
    }
}
