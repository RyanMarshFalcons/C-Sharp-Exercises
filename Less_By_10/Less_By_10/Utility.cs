using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Less_By_10_Messages;

namespace Less_By_10
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

        public int[] GetDiffs(int[] nums)
        {
            Array.Sort(nums);
            var numsDiffs = new int[2];
            numsDiffs[0] = nums[2] - nums[0];
            numsDiffs[1] = nums[2] - nums[1];
            return numsDiffs;
        }

        public int IsLessBy10(int[] numsDiffs)
        {
            var counter = 0;
            foreach (var diff in numsDiffs)
            {
                if (diff >= 10)
                {
                    counter += 1;
                }
            }
            return counter;
        }
    }
}
