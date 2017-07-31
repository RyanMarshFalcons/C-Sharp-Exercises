using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Addition;
using Addition_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var num1 = utility.GetValidEntry();
            var num2 = utility.GetValidEntry();
            var sum = utility.GetSum(num1, num2);
            Message.DisplaySum(num1, num2, sum);
            Console.ReadLine();
        }
    }
}
