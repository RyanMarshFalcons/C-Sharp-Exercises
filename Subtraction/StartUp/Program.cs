using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Subtraction;
using Subtraction_Messages;

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
            var difference = utility.GetDifference(num1, num2);
            Message.DisplayDifference(num1, num2, difference);
            Console.ReadLine();
        }
    }
}
