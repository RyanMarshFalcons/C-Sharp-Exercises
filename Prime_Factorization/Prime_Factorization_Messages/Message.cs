using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Factorization_Messages
{
    public class Message
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome to my prime factorization program. Input a number and I will tell you\nwhat the smallest prime numbers that multiplied together are equal to your\nnumber. Press enter to continue.");
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
        public static void CantBeNegative(string input)
        {
            Console.Write($"\nSorry but {input} is not a valid entry because all prime numbers are positive.\nPlease input a number: ");
        }

        public static void CantBeZeroOrOne(string input)
        { 
            Console.Write($"\nSory but {input} is not a valid entry because the smallest prime number is 2. Please\ninput a number: ");
        }

        public static void IsAPrimeNumber(int num)
        {
            Console.WriteLine($"\nUnfortunately {num} cannot be prime factorized because {num} itself is a prime\nnumber. Press enter to close the program.");
        }

        public static void CanBeFactorized(int num, string primeFactors)
        {
            Console.WriteLine($"\n{num} is primary factored into:{primeFactors}\nPress enter to close the program.");
        }
    }
}
