using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max_1_1000_Messages;

namespace Max_1_1000
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

        public bool CheckIfHasPower(int num)
        {
            return (num >= 1) && (num <= 1000);
        }

        public bool CheckIfEqual(int num1, int num2)
        {
            return num1 == num2;
        }

        public void DisplayMorePowerful(int num1, int num2)
        {
            if (num1 > num2)
            {
                Message.MorePowerful(num1, num2);
            }
            else
            {
                Message.MorePowerful(num2, num1);
            }
        }
    }
}
