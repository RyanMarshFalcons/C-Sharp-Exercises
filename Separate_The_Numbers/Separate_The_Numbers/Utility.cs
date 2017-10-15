using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seperate_The_Numbers_Messages;

namespace Separate_The_Numbers
{
    public class Utility
    {
        public string GetUserNum()
        {
            Message.EnterNumber();
            var isValidInput = false;
            var input = "";
            while (!isValidInput)
            {
                input = Console.ReadLine();
                if (!CheckIfInt(input))
                {
                    Message.NotANumber(input);
                }
                else
                {
                    if (!CheckIfLargeEnough(input))
                    {
                        Message.NumberLessThanTwelve();
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return input;
        }

        public bool CheckIfInt(string input)
        {
            var num = 0;
            return int.TryParse(input, out num);
        }

        public bool CheckIfLargeEnough(string input)
        {
            return int.Parse(input) >= 12;
        }

        public string RemoveLeadingZeroes(string userNumAsString)
        {
            return int.Parse(userNumAsString).ToString();
        }

        public List<int> GetFirstTwoNumbers(string userNumAsString)
        {
            var firstNum = 0;
            var secondNum = 0;
            for (int i = 1; i < userNumAsString.Length; i++)
            {
                firstNum = int.Parse(userNumAsString.Substring(0, i));
                if (userNumAsString.Length >= i * 2 && int.Parse(userNumAsString.Substring(i, i)) == int.Parse(userNumAsString.Substring(0, i)) + 1)
                {
                    secondNum = int.Parse(userNumAsString.Substring(i, i));
                }
                if (userNumAsString.Length >= i * 2 + 1 && int.Parse(userNumAsString.Substring(i, i + 1)) == int.Parse(userNumAsString.Substring(0, i)) + 1)
                {
                    secondNum = int.Parse(userNumAsString.Substring(i, i + 1));
                }
            }
            return new List<int> { secondNum - 1, secondNum };
        }

        public string RemoveFirstTwoNumbersFromString(string userNumAsString, List<int> firstTwoNumbers)
        {
            return userNumAsString.Substring(firstTwoNumbers[0].ToString().Length + firstTwoNumbers[1].ToString().Length);
        }

        public List<int> GetRestOfNumbers(string remainderOfUserNum, List<int> separatedNumbers)
        {
            if (remainderOfUserNum.Length == 0)
            {
                return separatedNumbers;
            }
            var nextNumber = 0;
            while (remainderOfUserNum.Length >= (separatedNumbers.Last() + 1).ToString().Length)
            {
                nextNumber = separatedNumbers.Last() + 1;
                if (int.Parse(remainderOfUserNum.Substring(0, nextNumber.ToString().Length)) == nextNumber)
                {
                    separatedNumbers.Add(nextNumber);
                    remainderOfUserNum = remainderOfUserNum.Substring(nextNumber.ToString().Length);
                }
                else
                {
                    separatedNumbers.Add(-1);
                    return separatedNumbers;
                }
            }
            return separatedNumbers;
        }

        public void DisplayResults(List<int> separatedNumbers, string userNumAsString)
        {
            if (separatedNumbers.Last() == -1)
            {
                Message.UnableToSeparateTheNumbers(userNumAsString);
            }
            else
            {
                var separatedNumbersAsString = ConvertListToString(separatedNumbers);
                Message.DisplaySeparatedNumbers(userNumAsString, separatedNumbersAsString);
            }
        }

        public string ConvertListToString(List<int> separatedNumbers)
        {
            return string.Join(", ", separatedNumbers.ToArray());
        }
    }
}
