using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Four_As_One_Messages;

namespace Four_As_One
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
            return int.Parse(input);
        }

        public bool CheckIfInt(string input)
        {
            var num = 0;
            return int.TryParse(input, out num);
        }

        public int[] GetSumsOfNums(int[] nums)
        {
            var sumsOfNums = new int[5];
            sumsOfNums[0] = nums[0] + nums[1] + nums[2] + nums[3];
            sumsOfNums[1] = nums[0] + nums[1] + nums[2] + nums[4];
            sumsOfNums[2] = nums[0] + nums[1] + nums[3] + nums[4];
            sumsOfNums[3] = nums[0] + nums[2] + nums[3] + nums[4];
            sumsOfNums[4] = nums[1] + nums[2] + nums[3] + nums[4];
            return sumsOfNums;
        }

        public bool FourAsOnePossible(int[] nums, int[] sumsOfNums)
        {
            return nums.Intersect(sumsOfNums).Any();
        }

        public void DisplayResults(bool isPossible)
        {
            if (isPossible)
            {
                Message.IsPossible();
            }
            else
            {
                Message.NotPossible();
            }
        }
    }
}
