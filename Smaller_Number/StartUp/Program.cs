using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smaller_Number;
using Smaller_Number_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var num1 = utility.GetValidNumber();
            var num2 = utility.GetValidNumber();
            if (utility.CheckIfEqual(num1, num2))
            {
                Message.NumbersEqual(num1);
            }
            else
            {
                Message.SmallerNumber(utility.GetSmallerNumber(num1, num2));
            }
            Console.ReadLine();
        }
    }
}
