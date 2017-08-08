using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Remainder_Messages;

namespace Remainder
{
    public class Utility
    {
        public int GetValidEntry(string dividendOrDivisor)
        {
            Message.EnterNumber(dividendOrDivisor);
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
            return Int32.Parse(input);
        }

        public bool CheckIfInt(string input)
        {
            var num = 0;
            return Int32.TryParse(input, out num);
        }

        public int GetRemainder(int dividend, int divisor)
        {
            return dividend % divisor;
        }
    }
}
