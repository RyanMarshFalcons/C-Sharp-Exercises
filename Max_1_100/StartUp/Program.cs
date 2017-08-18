using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max_1_100;
using Max_1_100_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var num1 = utility.GetNumber("first");
            var num2 = utility.GetNumber("second");
            if ((!utility.CheckIfHasPower(num1)) && (!utility.CheckIfHasPower(num2)))
            {
                Message.NeitherHasPower(num1, num2);
            }
            else if ((utility.CheckIfHasPower(num1)) && (!utility.CheckIfHasPower(num2)))
            {
                Message.MorePowerful(num1, num2);
            }
            else if ((!utility.CheckIfHasPower(num1)) && (utility.CheckIfHasPower(num2)))
            {
                Message.MorePowerful(num2, num1);
            }
            else if (utility.CheckIfEqual(num1, num2))
            {
                Message.EquallyPowerful(num1);
            }
            else
            {
                utility.DisplayMorePowerful(num1, num2);
            }
            Console.ReadLine();
        }
    }
}
