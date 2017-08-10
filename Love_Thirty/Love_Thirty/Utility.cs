using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Love_Thirty_Messages;

namespace Love_Thirty
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

        public bool CheckIfThirty(int num1, int num2)
        {
            return ((num1 == 30) || (num2 == 30));
        }

        public bool CheckIfSumIsThirty(int num1, int num2)
        {
            return num1 + num2 == 30;
        }

        public bool CheckIfDifferenceIsThirty(int num1, int num2)
        {
            return Math.Abs(num1 - num2) == 30;
        }

        public bool CheckIfProductIsThirty(int num1, int num2)
        {
            return num1 * num2 == 30;
        }

        public bool CheckIfQuotientIsThirty(int num1, int num2)
        {
            return ((num1 / num2 == 30) || (num2 / num1 == 30));
        }
    }
}
