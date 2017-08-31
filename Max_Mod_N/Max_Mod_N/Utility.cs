using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max_Mod_N_Messages;

namespace Max_Mod_N
{
    public class Utility
    {
        public int GetValidNumber(string firstSecondModulus)
        {
            Message.InputNumber(firstSecondModulus);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NotANumber(input, firstSecondModulus);
                }
                else
                {
                    if (CheckIfNotZero(input) == false)
                    {
                        Message.CantBeZero(firstSecondModulus);
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

        public bool CheckIfNotZero(string input)
        {
            return int.Parse(input) != 0;
        }
        public bool CheckIfEqual(int num1, int num2)
        {
            return num1 == num2;
        }

        public int DetermineMorePowerful(int num1, int num2, int mod)
        {
            if (num1 > num2)
            {
                if ((num1 % mod) != (num2 % mod))
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
                if ((num2 % mod) != (num1 % mod))
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
