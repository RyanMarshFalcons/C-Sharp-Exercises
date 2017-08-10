using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Love_Twenty_Four_Messages;

namespace Love_Twenty_Four
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
            return int.Parse(input);
        }

        public bool CheckIfInt(string input)
        {
            var num = 0;
            return int.TryParse(input, out num);
        }

        public bool CheckIfTwentyFour(int num1, int num2)
        {
            return ((num1 == 24) || (num2 == 24));
        }

        public bool CheckIfSumIsTwentyFour(int num1, int num2)
        {
            return num1 + num2 == 24;
        }

        public bool CheckIfDifferenceIsTwentyFour(int num1, int num2)
        {
            return Math.Abs(num1 - num2) == 24;
        }

        public bool CheckIfProductIsTwentyFour(int num1, int num2)
        {
            return num1 * num2 == 24;
        }

        public bool CheckIfQuotientIsTwentyFour(int num1, int num2)
        {
            return ((num1 / num2 == 24) || (num2 / num1 == 24));
        }
    }
}
