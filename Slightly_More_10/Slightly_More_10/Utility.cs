using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Slightly_More_10_Messages;

namespace Slightly_More_10
{
    public class Utility
    {
        public int GetValidNumber()
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
                    if (CheckIfNegative(input))
                    {
                        Message.CantBeNegative();
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

        public bool CheckIfNegative(string input)
        {
            return int.Parse(input) < 0;
        }

        public int GetRemainder(int num)
        {
            if (num > 10)
            {
                return num % 10;
            }
            else
            {
                return 0;
            }
        }

        public bool IsSlightlyMore(int remainder)
        {
            return (remainder == 1) || (remainder == 2);
        }

        public void DisplayResults(bool isSlightlyMore, int num)
        {
            if (isSlightlyMore)
            {
                Message.IsSlightlyMore(num);
            }
            else
            {
                Message.IsNotSlightlyMore(num);
            }
        }
    }
}
