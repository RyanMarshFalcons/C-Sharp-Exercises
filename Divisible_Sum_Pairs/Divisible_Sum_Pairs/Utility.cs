using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Divisible_Sum_Pairs_Messages;

namespace Divisible_Sum_Pairs
{
    public class Utility
    {
        public int GetDivisibleNum()
        {
            Message.AskForDivisibleNum();
            var isValidInput = false;
            var input = "";
            while (!isValidInput)
            {
                input = Console.ReadLine();
                if (!CheckIfInt(input))
                {
                    Message.DivisibleNumIsNotANumber(input);
                }
                else
                {
                    if (!CheckIfGreaterThanOne(input))
                    {
                        Message.DivisibleNumMustBeMoreThanOne();
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return int.Parse(input);
        }

        public int GetNumForList(int placementOfNumber)
        {
            Message.AskForNumForList(placementOfNumber);
            var isValidInput = false;
            var input = "";
            while (!isValidInput)
            {
                input = Console.ReadLine();
                if (!CheckIfInt(input))
                {
                    Message.NumForListIsNotANumber(input, placementOfNumber);
                }
                else
                {
                    if (!CheckIfPositive(input))
                    {
                        Message.NumForListMustBePositive(placementOfNumber);
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

        public bool CheckIfGreaterThanOne(string input)
        {
            return int.Parse(input) > 1;
        }

        public bool CheckIfPositive(string input)
        {
            return int.Parse(input) > 0;
        }

        public bool AskToAddAnotherNumberToList()
        {
            var IsValidInput = false;
            var input = "";
            Message.AskToAddAnotherNumberToList();
            while (IsValidInput == false)
            {
                input = Console.ReadLine();
                if (!CheckIfyOrn(input))
                {
                    Message.NotyOrn();
                }
                else
                {
                    IsValidInput = true;
                }
            }
            return input == "y";
        }

        public bool CheckIfyOrn(string input)
        {
            return input == "y" || input == "n";
        }

        public List<Tuple<int, int>> CalculateDivisibleSumPairs(int divisibleNum, List<int> listOfNums)
        {
            var divisibleSumPairs = new List<Tuple<int, int>>();
            for (int i = 0; i < listOfNums.Count - 1; i++)
            {
                for (int j = i + 1; j < listOfNums.Count; j++)
                {
                    if ((listOfNums[i] + listOfNums[j]) % divisibleNum == 0)
                    {
                        divisibleSumPairs.Add(Tuple.Create(listOfNums[i], listOfNums[j]));
                    }
                }
            }
            return divisibleSumPairs;
        }

        public void DisplayResults(List<Tuple<int, int>> divisibleSumPairs, int divisibleNum)
        {
            if (divisibleSumPairs.Count == 0)
            {
                Message.NoDivisibleSumPairs(divisibleNum);
            }
            else
            {
                Message.DisplayDivisibleSumPairs(divisibleSumPairs, divisibleNum);
            }
        }
    }
}
