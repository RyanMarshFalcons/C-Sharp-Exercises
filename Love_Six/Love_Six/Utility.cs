using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Love_Six_Messages;

namespace Love_Six
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

        public bool CheckIfSix(int num1, int num2)
        {
            return ((num1 == 6) || (num2 == 6));
        }

        public bool CheckIfSumIsSix(int num1, int num2)
        {
            return num1 + num2 == 6;
        }

        public bool CheckIfDifferenceIsSix(int num1, int num2)
        {
            return Math.Abs(num1 - num2) == 6;
        }

        public bool CheckIfProductIsSix(int num1, int num2)
        {
            return num1 *num2 == 6;
        }

        public bool CheckIfQuotientIsSix(int num1, int num2)
        {
            return ((num1 / num2 == 6) || (num2 / num1 == 6));
        }
    }
}