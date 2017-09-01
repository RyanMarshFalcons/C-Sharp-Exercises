using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scores_Increasing_Messages;

namespace Scores_Increasing
{
    public class Utility
    {
        public int GetValidScore(string firstSecondThird)
        {
            Message.EnterScore(firstSecondThird);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NotAScore(input, firstSecondThird);
                }
                else
                {
                    if (CheckIfNegative(input))
                    {
                        Message.CantBeNegative(firstSecondThird);
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

        public bool CheckIfIncreasing(int[] nums)
        {
            var areIncreasing = true;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < nums[i - 1])
                {
                    areIncreasing = false;
                }
            }
            return areIncreasing;
        }

        public void DisplayResults(bool areIncreasing)
        {
            if (areIncreasing)
            {
                Message.AreIncreasing();
            }
            else
            {
                Message.AreNotIncreasing();
            }
        }
    }
}
