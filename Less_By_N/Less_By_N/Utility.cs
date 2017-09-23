using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Less_By_N_Messages;

namespace Less_By_N
{
    public class Utility
    {
        public int GetValidNumber(string entryNum)
        {
            Message.EnterNumber(entryNum);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NotANumber(input, entryNum);
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
            numsDiffs[0] = nums[4] - nums[0];
            numsDiffs[1] = nums[4] - nums[1];
            numsDiffs[2] = nums[4] - nums[2];
            numsDiffs[3] = nums[4] - nums[3];
            return numsDiffs;
        }

        public int IsLessByN(int[] numsDiffs, int N)
        {
            return numsDiffs.Where(d => d >= N).Count();
        }
    }
}
