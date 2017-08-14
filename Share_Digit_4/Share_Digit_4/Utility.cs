using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Share_Digit_4_Messages;

namespace Share_Digit_4
{
    public class Utility
    {
        public int GetValidNumber()
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
                    if (!CheckIfBetween1000And9999(input))
                    {
                        Message.MustBe1000to9999();
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

        public bool CheckIfBetween1000And9999(string input)
        {
            return (int.Parse(input) >= 1000) && (int.Parse(input) <= 9999);
        }

        public int[] GetDigits(int num)
        {
            return new int[] { num / 1000, (num % 1000) / 100, ((num % 1000) % 100) / 10, num % 10 };
        }

        public bool MatchingDigits(int[] num1sDigits, int[] num2sDigits)
        {
            var isMatch = false;
            foreach (var digitnum1 in num1sDigits)
            {
                foreach (var digitnum2 in num2sDigits)
                {
                    if (digitnum1 == digitnum2)
                    {
                        isMatch = true;
                    }
                }
            }
            return isMatch;
        }

        public void DisplayResults(bool isMatch)
        {
            if (isMatch)
            {
                Message.DoShareDigit();
            }
            else
            {
                Message.DoNotShareDigit();
            }
        }
    }
}
