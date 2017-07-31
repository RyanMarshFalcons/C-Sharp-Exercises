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
            Console.WriteLine("Welcome to my prime factorization program. Input a number and I will tell you\nwhat all of its prime number factors are. Press enter to continue.");
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
            Console.WriteLine($"\nSorry but {num} cannot be prime factorized because all prime numbers are positive.");
        }

        public static void CantBeZeroOrOne(int num)
        { 
            Console.WriteLine($"\n{num} cannot be prime factorized because {num} is smaller than the smallest prime number which is 2.");
        }

        public static void IsAPrimeNumber(int num)
        {
            Console.WriteLine($"\n{num} cannot be prime factorized because {num} itself is a prime number.");
        }

        public static void CanBeFactorized(int num, string primeFactors)
        {
            Console.WriteLine($"\n{num} is primary factored into:{primeFactors}");
        }
    }
}
