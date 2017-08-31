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
            numsDiffs[0] = nums[1] - nums[0];
            numsDiffs[1] = nums[2] - nums[1];
            numsDiffs[2] = nums[3] - nums[2];
            numsDiffs[3] = nums[4] - nums[3];
            return numsDiffs;
        }

        public bool CheckIfEvenlySpaced(int[] differences)
        {
            var firstDifference = differences[0];
            var evenlySpaced = true;
            for (int i = 1; i < differences.Length; i++)
            {
                if (differences[i] != firstDifference)
                {
                    evenlySpaced = false;
                }
            }
            return evenlySpaced;
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
