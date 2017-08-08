using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exponent_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my Exponent program where you will enter two numbers and I will tell you what the first number to the power of the second number equals. Press enter to contine.");
            Console.ReadLine();
        }

        public static void EnterNumber(string BaseExponent)
        {
            Console.Write($"\nPlease enter the {BaseExponent}: ");
        }

        public static void NotANumber(string input, string BaseExponent)
        {
            Console.Write($"\nSorry but {input} is not a number. Please input the {BaseExponent}: ");
        }

        public static void MustBePositive(string input, string BaseExponent)
        {
            Console.Write($"\nSorry but the input cannot be negative. Please input the {BaseExponent}: ");
        }

        public static void DisplayResults(int Base, int Exponent, int Product)
        {
            Console.WriteLine($"\n{Base} to the power of {Exponent} is {Product}");
        }
    }
}
