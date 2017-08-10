using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Love_Twelve_Messages;

namespace Love_Twelve
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

        public bool CheckIfTwelve(int num1, int num2)
        {
            return ((num1 == 12) || (num2 == 12));
        }

        public bool CheckIfSumIsTwelve(int num1, int num2)
        {
            return num1 + num2 == 12;
        }

        public bool CheckIfDifferenceIsTwelve(int num1, int num2)
        {
            return Math.Abs(num1 - num2) == 12;
        }

        public bool CheckIfProductIsTwelve(int num1, int num2)
        {
            return num1 * num2 == 12;
        }

        public bool CheckIfQuotientIsTwelve(int num1, int num2)
        {
            return ((num1 / num2 == 12) || (num2 / num1 == 12));
        }
    }
}
