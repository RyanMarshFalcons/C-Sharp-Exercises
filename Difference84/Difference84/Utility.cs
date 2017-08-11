using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Difference84_Messages;

namespace Difference84
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

        public bool GreaterThan84(int num)
        {
            return num > 84;
        }

        public int DifferenceTo84(int num, bool greaterThan84)
        {
            if (greaterThan84)
            {
                return (num - 84) * 2;
            }
            else
            {
                return 84 - num;
            }
        }
    }
}
