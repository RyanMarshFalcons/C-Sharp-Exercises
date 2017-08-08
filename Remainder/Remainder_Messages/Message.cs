using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remainder_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Remainder program where you will enter two numbers and I will tellyou what the remainder is when they are divided. Press enter to contine.");
            Console.ReadLine();
        }

        public static void EnterNumber(string dividendOrDivisor)
        {
            Console.Write($"\nPlease enter the {dividendOrDivisor}: ");
        }

        public static void NotANumber(string input)
        {
            Console.Write($"\nSorry but {input} is not a number. Please input a number: ");
        }

        public static void DisplayResults(int dividend, int divisor, int remainder)
        {
            Console.WriteLine($"\nWhen {dividend} is divided by {divisor} the remainder is {remainder}");
        }
    }
}
