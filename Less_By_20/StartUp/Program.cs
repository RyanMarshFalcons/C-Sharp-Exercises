using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Less_By_20;
using Less_By_20_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var nums = new int[3];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = utility.GetValidNumber();
            }
            var numsDiffs = utility.GetDiffs(nums);
            var count = utility.IsLessBy20(numsDiffs);
            Message.IsLessByTwentry(count);
            Console.ReadLine();
        }
    }
}
