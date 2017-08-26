using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Evenly_Spaced;
using Evenly_Spaced_Messages;

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
            var sortedNums = utility.SortNums(nums);
            var difference1 = utility.GetDifference(sortedNums[0], sortedNums[1]);
            var difference2 = utility.GetDifference(sortedNums[1], sortedNums[2]);
            var areEvenlySpaced = utility.CheckIfEvenlySpaced(difference1, difference2);
            utility.DisplayResults(areEvenlySpaced, sortedNums[0], sortedNums[1], sortedNums[2], difference1, difference2);
            Console.ReadLine();
        }
    }
}
