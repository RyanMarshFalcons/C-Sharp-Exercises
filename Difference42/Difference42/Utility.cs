using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Difference42_Messages;

namespace Difference42
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

        public bool GreaterThan42(int num)
        {
            return num > 42;
        }

        public int DifferenceTo42(int num, bool greaterThan42)
        {
            if (greaterThan42)
            {
                return (num - 42) * 2;
            }
            else
            {
                return 42 - num;
            }
        }
    }
}
