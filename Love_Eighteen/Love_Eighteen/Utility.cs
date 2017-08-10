using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Love_Eighteen_Messages;

namespace Love_Eighteen
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

        public bool CheckIfEighteen(int num1, int num2)
        {
            return ((num1 == 18) || (num2 == 18));
        }

        public bool CheckIfSumIsEighteen(int num1, int num2)
        {
            return num1 + num2 == 18;
        }

        public bool CheckIfDifferenceIsEighteen(int num1, int num2)
        {
            return Math.Abs(num1 - num2) == 18;
        }

        public bool CheckIfProductIsEighteen(int num1, int num2)
        {
            return num1 * num2 == 18;
        }

        public bool CheckIfQuotientIsEighteen(int num1, int num2)
        {
            return ((num1 / num2 == 18) || (num2 / num1 == 18));
        }
    }
}
