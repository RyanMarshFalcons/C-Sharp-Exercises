using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Luhn_Formula_Messages;

namespace Luhn_Formula
{
    public class Utility
    {
        public string GetUserNumberAsString()
        {
            var userInput = "";
            Message.RequestUserNumber();
            var validInput = false;
            while (validInput == false)
            {
                userInput = Console.ReadLine();
                if (IsTooShort(userInput))
                {
                    Message.NotLongEnough();
                }
                else
                {
                    if (DoesContainLettersOrSymbols(userInput))
                    {
                        Message.ContainsLettersOrSymbols();
                    }
                    else
                    {
                        validInput = true;
                    }
                }
            }
            return userInput;
        }

        public bool IsTooShort(string input)
        {
            return RemoveSpaces(input).Length < 2;
        }

        public string RemoveSpaces(string input)
        {
            return input.Replace(" ", "");
        }

        public bool DoesContainLettersOrSymbols(string input)
        {
            var containsLettersOrSymbols = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (!Char.IsNumber(input[i]) && input[i] != ' ')
                {
                    containsLettersOrSymbols = true;
                }
            }
            return containsLettersOrSymbols;
        }

        public bool StringLengthIsEven(string userString)
        {
            return userString.Length % 2 == 0;
        }

        public string DoubleEverySecondDigitFromRight(string userNumAsString, bool stringLengthIsEven)
        {
            var newString = "";
            if (!stringLengthIsEven)
            {
                userNumAsString = "0" + userNumAsString;
            }
            for (int i = 0; i < userNumAsString.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (int.Parse(userNumAsString[i].ToString()) <= 4)
                    {
                        newString += char.Parse((int.Parse(userNumAsString[i].ToString()) * 2).ToString());
                    }
                    else
                    {
                        newString += char.Parse((int.Parse(userNumAsString[i].ToString()) * 2 - 9).ToString());
                    }
                }
                else
                {
                    newString += userNumAsString[i]; 
                }
            }
            if (!stringLengthIsEven)
            {
                newString = newString.Substring(1);
            }
            return newString;
        }

        public int GetSumOfDigits(string userNumAsString)
        {
            return userNumAsString.Sum(n => n - '0');
        }

        public void DisplayResults(int sum)
        {
            if (IsValidNumber(sum))
            {
                Message.IsValid();
            }
            else
            {
                Message.IsNotValid();
            }
        }

        public bool IsValidNumber(int sum)
        {
            return sum % 10 == 0;
        }
    }
}
