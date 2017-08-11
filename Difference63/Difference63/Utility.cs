using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Difference63_Messages;

namespace Difference63
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

        public bool GreaterThan63(int num)
        {
            return num > 63;
        }

        public int DifferenceTo63(int num, bool greaterThan63)
        {
            if (greaterThan63)
            {
                return (num - 63) * 2;
            }
            else
            {
                return 63 - num;
            }
        }
    }
}
