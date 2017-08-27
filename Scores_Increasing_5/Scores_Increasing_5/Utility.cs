using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scores_Increasing_5_Messages;

namespace Scores_Increasing_5
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
