using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Difference21_Messages;

namespace Difference21
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

        public bool GreaterThan21(int num)
        {
            return num > 21;
        }

        public int DifferenceTo21(int num, bool greaterThan21)
        {
            if (greaterThan21)
            {
                return (num - 21) * 2;
            }
            else
            {
                return 21 - num;
            }
        }
    }
}
