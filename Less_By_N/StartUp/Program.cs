using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Less_By_N;
using Less_By_N_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var nums = new int[5];
            nums[0] = utility.GetValidNumber("first");
            nums[1] = utility.GetValidNumber("second");
            nums[2] = utility.GetValidNumber("third");
            nums[3] = utility.GetValidNumber("fourth");
            nums[4] = utility.GetValidNumber("fifth");
            var N = utility.GetValidNumber("N");
            var numsDiffs = utility.GetDiffs(nums);
            var count = utility.IsLessByN(numsDiffs, N);
            Message.IsLessByN(count, N);
            Console.ReadLine();
        }
    }
}
