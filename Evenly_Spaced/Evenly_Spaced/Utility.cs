using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evenly_Spaced_Messages;

namespace Evenly_Spaced
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

        public int[] GetDiffs(int[] nums)
        {
            Array.Sort(nums);
            var numsDiffs = new int[4];
            for (int i = 0; i < 4; i++)
            {
                numsDiffs[i] = nums[i + 1] - nums[i];
            }
            return numsDiffs;
        }

        public bool CheckIfEvenlySpaced(int[] differences)
        {
            return differences.Select(s => s.ToString()).Distinct().Count() == 1;
        }

        public void DisplayResults(bool areEvenlySpaced)
        {
            if (areEvenlySpaced)
            {
                Message.AreEvenlySpaced();
            }
            else
            {
                Message.AreNotEvenlySpaced();
            }
        }
    }
}
