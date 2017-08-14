using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max_Mod_5_Messages;

namespace Max_Mod_5
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

        public bool CheckIfEqual(int num1, int num2)
        {
            return num1 == num2;
        }

        public int DetermineMorePowerful(int num1, int num2)
        {
            if (num1 > num2)
            {
                if ((num1 % 5) != (num2 % 5))
                {
                    return num1;
                }
                else
                {
                    return num2;
                }
            }
            else
            {
                if ((num2 % 5) != (num1 % 5))
                {
                    return num2;
                }
                else
                {
                    return num1;
                }
            }
        }
    }
}
