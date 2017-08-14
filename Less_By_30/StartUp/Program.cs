using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Less_By_30;
using Less_By_30_Messages;

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
            var count = utility.IsLessBy30(numsDiffs);
            Message.IsLessByThirty(count);
            Console.ReadLine();
        }
    }
}
