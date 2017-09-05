using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prime_Factorization_Messages;

namespace Prime_Factorization
{
    public class Utility
    {
        public int GetValidEntry()
        {
            Message.EnterNumber();
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NotANumber(input);
                }
                else
                {
                    if(CheckIfNegative(input))
                    {
                        Message.CantBeNegative(input);
                    }
                    else if (CheckIfZeroOrOne(input))
                    {
                        Message.CantBeZeroOrOne(input);
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return int.Parse(input);
        }

        public bool CheckIfInt(string input)
        {
            var num = 0;
            return int.TryParse(input, out num);
        }

        public bool CheckIfNegative(string input)
        {
            return int.Parse(input) < 0;
        }

        public bool CheckIfZeroOrOne(string input)
        {
            return int.Parse(input) == 0 || int.Parse(input) == 1;
        }

        public List<int> GetPossiblePrimeFactors(int num)
        {
            var listOfNums = new List<int>();
            for (int i = 2; i < num; i++)
            {
                if (CheckIfPrime(i) == true)
                {
                    listOfNums.Add(i);
                }
            }
            return listOfNums;
        }

        public bool CheckIfPrime(int num)
        {
            var isPrime = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                }
            }
            return isPrime;
        }

        public List<int> GetPrimeFactors(int num, List<int> PossiblePrimeFactors)
        {
            var primeFactors = new List<int>();
            foreach (var factor in PossiblePrimeFactors)
            {
                while (num % factor == 0)
                {
                    primeFactors.Add(factor);
                    num = num / factor;
                }
            }
            return primeFactors;
        }

        public void DisplayResults(int num, bool isPrime, List<int> primeFactors)
        {

            if (isPrime == true)
            {
                Message.IsAPrimeNumber(num);
            }
            else
            {
                Message.CanBeFactorized(num, ListToString(primeFactors));
            }
        }

        public string ListToString(List<int> primeFactors)
        {
            var stringOfFactors = "";
            foreach (var factor in primeFactors)
            {
                stringOfFactors += " * ";
                stringOfFactors += factor;
            }
            return stringOfFactors.Substring(2, stringOfFactors.Length-2);
        }
    }
}
