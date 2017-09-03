using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeNumbers_Messages;

namespace PrimeNumbers
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
                    isValidInput = true;
                }
            }
            return Int32.Parse(input);
        }

        public bool CheckIfInt(string input)
        {
            var num = 0;
            return Int32.TryParse(input, out num);
        }

        public bool CheckIfNegative(int num)
        {
            return num < 0;
        }

        public List<int> GetFactors(int num)
        {
            var listNums = new List<int>();
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    listNums.Add(i);
                }
            }
            return listNums;
        }

        public bool CheckIfPrime(List<int> listNums)
        {
            return listNums.Count == 0;
        }

        public void DisplayResults(int num, bool isPrime, List<int> listOfFactors)
        {
            if (num == 0)
            {
                Message.CantBeZero();
            }
            else if (num == 1)
            {
                Message.CantBeOne();
            }
            else
            {
                if (isPrime == true)
                {
                    Message.IsAPrimeNumber(num);
                }
                else
                {
                    Message.IsNotAPrimeNumber(num, ListToString(listOfFactors));
                }
            }
        }

        public string ListToString(List<int> listOfFactors)
        {
            var stringOfFactors = "";
            foreach (var factor in listOfFactors)
            {
                stringOfFactors += ", ";
                stringOfFactors += factor;
            }
            return stringOfFactors + ",";
        }
    }
}
