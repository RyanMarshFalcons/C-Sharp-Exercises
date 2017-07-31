using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my prime numbers program. Input a number and I will tell you whether or not it is a prime number and give your the reason why as well. Press enter tocontinue.");
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

        public static void CantBeNegative(int num)
        {
            Console.WriteLine($"\n{num} is not a prime number because negative numbers are not prime numbers.");
        }

        public static void CantBeZero()
        {
            Console.WriteLine($"\n0 is not only not a prime number, but 0 is not even divisible by 1.");
        }

        public static void CantBeOne()
        {
            Console.WriteLine($"\n1 is not a prime number because the only thing that 1 is divisible by is 1.");
        }

        public static void IsAPrimeNumber(int num)
        {
            Console.WriteLine($"\n{num} is a prime number because it is only divisible by 1 and {num}.");
        }

        public static void IsNotAPrimeNumber(int num, string factorsOfNum)
        {
            Console.WriteLine($"\n{num} is not a prime number because {num} is divisible by:\n1{factorsOfNum} and {num}");
        }
    }
}
