using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prime_Factorization;
using Prime_Factorization_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var input = utility.GetValidEntry();
            var possiblePrimeFactors = utility.GetPossiblePrimeFactors(input);
            var primeFactors = utility.GetPrimeFactors(input, possiblePrimeFactors);
            var isPrime = utility.CheckIfPrime(input);
            utility.DisplayResults(input, isPrime, primeFactors);
            Console.ReadLine();
        }
    }
}
