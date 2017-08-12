using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Last_Digit_5_Messages;

namespace Last_Digit_5
{
    public class Utility
    {
        public int GetValidNumber()
        {
            Message.InputNumber();
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
                    if (CheckIfNegative(input))
                    {
                        Message.CantBeNegative();
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

        public int[] LastDigits(int[] nums)
        {
            var lastDigits = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                lastDigits[i] = GetLastDigit(nums[i]);
            }
            return lastDigits;
        }

        public int GetLastDigit(int num)
        {
            while (num > 9)
            {
                num = num % 10;
            }
            return num;
        }

        public bool CheckForMatch(int[] lastDigits)
        {
            return lastDigits.Distinct().Count() != lastDigits.Length;
        }

        public void DisplayResults(bool doMatch)
        {
            if (doMatch)
            {
                Message.DoMatch();
            }
            else
            {
                Message.DontMatch();
            }
        }
    }
}
