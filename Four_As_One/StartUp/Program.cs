using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Four_As_One;
using Four_As_One_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var nums = new int[5];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = utility.GetValidNumber();
            }
            var sumsOfNums = utility.GetSumsOfNums(nums);
            var fourAsOnePoss = utility.FourAsOnePossible(nums, sumsOfNums);
            utility.DisplayResults(fourAsOnePoss);
            Console.ReadLine();
        }
    }
}
