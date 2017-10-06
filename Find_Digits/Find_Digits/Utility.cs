using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Find_Digits_Messages;

namespace Find_Digits
{
    public class Utility
    {
        public int GetUserNumber()
        {
            Message.EnterFindDigitsNumber();
            var isValidInput = false;
            var input = "";
            while (!isValidInput)
            {
                input = Console.ReadLine();
                if (!CheckIfInt(input))
                {
                    Message.FindDigitsNumberNotANumber(input);
                }
                else
                {
                    if (!CheckIfAtLeastTen(input))
                    {
                        Message.FindDigitsNumberMustBeAtLeastTen();
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

        public bool CheckIfAtLeastTen(string input)
        {
            return int.Parse(input) >= 10;
        }
        
        public int[] CalculateDivisibleDigits(int userNum)
        {
            var digits = ExtractDigitsOfNum(userNum);
            return digits.Where(d => d != 0 && userNum % d == 0).ToArray();
        }

        public int[] ExtractDigitsOfNum(int userNum)
        {
            var numAsString = userNum.ToString();
            var digits = new int[numAsString.Length];
            for (int i = 0; i < numAsString.Length; i++)
            {
                digits[i] = int.Parse(numAsString[i].ToString());
            }
            return digits;
        }

        public void DisplayResults(int userNum, int[] divisibleDigits)
        {
            if (divisibleDigits.Length == 0)
            {
                Message.NoDigitsEvenlyDivide(userNum);
            }
            else
            {
                Message.DisplayEvenlyDividingDigits(userNum, divisibleDigits);
            }
        }
    }
}
