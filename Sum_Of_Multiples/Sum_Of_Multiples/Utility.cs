using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sum_Of_Multiples_Messages;

namespace Sum_Of_Multiples
{
    public class Utility
    {
        public int GetValidNumber(string theceilinga)
        {
            Message.InputNumber(theceilinga);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NotANumber(input, theceilinga);
                }
                else
                {
                    if (CheckIfPositive(input) == false)
                    {
                        Message.MustBePostive(input, theceilinga);
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

        public bool CheckIfPositive(string input)
        {
            return int.Parse(input) > 0;
        }

        public bool AskToAddAnotherNumber()
        {
            var IsValidInput = false;
            var input = "";
            Message.AddAnotherNumber();
            while (IsValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfyOrn(input) == false)
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

        public List<int> GetAllMultiples(List<int> listOfNums, int ceilingNumber)
        {
            var individualListOfMultiples = new List<int>();
            var allMultiples = new List<int>();
            foreach (var userNumber in listOfNums)
            {
                individualListOfMultiples = GetMultiples(userNumber, ceilingNumber);
                foreach (var multiple in individualListOfMultiples)
                {
                    allMultiples.Add(multiple);
                }
            }
            return allMultiples;
        }

        public List<int> GetMultiples(int num, int ceilingNum)
        {
            var listOfMultiples = new List<int>();
            var newNum = num;
            while (newNum < ceilingNum)
            {
                listOfMultiples.Add(newNum);
                newNum += num;
            }
            return listOfMultiples;
        }

        public List<int> GetUniqueMultiples(List<int> allMultiples)
        {
            return (from m in allMultiples select m).Distinct().ToList();
        }

        public int CalculateSumOfMultiples(List<int> completeListOfMultiples, int ceilingNum)
        {
            var distinctMultiples = completeListOfMultiples.Distinct().ToList();
            return distinctMultiples.Sum();
        }
    }
}
