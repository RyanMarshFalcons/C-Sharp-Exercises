using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeNumbers;
using PrimeNumbers_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var input = utility.GetValidEntry();
            if (utility.CheckIfNegative(input) == true)
            {
                Message.CantBeNegative(input);
            }
            else
            {
                var listOfFactors = utility.GetFactors(input);
                var isPrime = utility.CheckIfPrime(listOfFactors);
                utility.DisplayResults(input, isPrime, listOfFactors);
            }
            Console.ReadLine();
        }
    }
}
