using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lone_Sum;
using Lone_Sum_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var nums = new int[3];
            nums[0] = utility.GetValidNumber("first");
            nums[1] = utility.GetValidNumber("second");
            nums[2] = utility.GetValidNumber("third");
            var hasMatch = new bool[3];
            hasMatch[0] = utility.CheckIfMatch(nums[0], nums[1], nums[2]);
            hasMatch[1] = utility.CheckIfMatch(nums[1], nums[0], nums[2]);
            hasMatch[2] = utility.CheckIfMatch(nums[2], nums[0], nums[1]);
            var sum = utility.GetSum(nums, hasMatch);
            Message.DisplaySum(nums[0], nums[1], nums[2], sum);
            Console.ReadLine();
        }
    }
}
