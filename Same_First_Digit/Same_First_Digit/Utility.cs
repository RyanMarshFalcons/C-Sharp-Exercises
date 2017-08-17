using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Same_First_Digit_Messages;

namespace Same_First_Digit
{
    public class Utility
    {
        public int GetNumber(string firstSecond)
        {
            Message.EnterNumber(firstSecond);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NotANumber(input, firstSecond);
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

        public int GetFirstDigit(int num)
        {
            return Convert.ToInt32(Math.Abs(num).ToString().Substring(0, 1));
        }

        public bool CheckIfSame(int digit1, int digit2)
        {
            return digit1 == digit2;
        }

        public void DisplayResults(bool areSame, int digit1, int digit2)
        {
            if (areSame)
            {
                Message.AreTheSame(digit1);
            }
            else
            {
                Message.AreNotTheSame(digit1, digit2);
            }
        }

    }
}
