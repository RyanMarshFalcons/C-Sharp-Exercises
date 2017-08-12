using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Five_As_One;
using Five_As_One_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var nums = new int[6];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = utility.GetValidNumber();
            }
            var sumsOfNums = utility.GetSumsOfNums(nums);
            var fiveAsOnePoss = utility.FiveAsOnePossible(nums, sumsOfNums);
            utility.DisplayResults(fiveAsOnePoss);
            Console.ReadLine();
        }
    }
}
