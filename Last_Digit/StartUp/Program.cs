using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Last_Digit;
using Last_Digit_Messages;

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
            var lastDigits = utility.LastDigits(nums);
            var isMatch = utility.CheckForMatch(lastDigits);
            utility.DisplayResults(isMatch);
            Console.ReadLine();
        }
    }
}
