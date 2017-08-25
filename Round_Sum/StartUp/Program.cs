using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Round_Sum;
using Round_Sum_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var num1 = utility.GetValidNumber("frist");
            var num2 = utility.GetValidNumber("second");
            var num3 = utility.GetValidNumber("third");
            var num1Rounded = utility.RoundToNearestTen(num1);
            var num2Rounded = utility.RoundToNearestTen(num2);
            var num3Rounded = utility.RoundToNearestTen(num3);
            var total = utility.SumOfNums(num1Rounded, num2Rounded, num3Rounded);
            Message.DisplayResult(total);
            Console.ReadLine();
        }
    }
}
