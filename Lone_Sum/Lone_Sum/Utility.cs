using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lone_Sum_Messages;

namespace Lone_Sum
{
    public class Utility
    {
        public int GetValidNumber(string firstSecondThird)
        {
            Message.EnterNumber(firstSecondThird);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NotANumber(input, firstSecondThird);
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

        public bool CheckIfMatch(int numChecking, int otherNum1, int othernum2)
        {
            return numChecking == otherNum1 || numChecking == othernum2;
        }

        public int GetSum(int[] nums, bool[] hasMatch)
        {
            var sum = 0;
            for (int i = 0; i < 3; i++)
            {
                if (hasMatch[i] == false)
                {
                    sum += nums[i];
                }
            }
            return sum;
        }
    }
}
