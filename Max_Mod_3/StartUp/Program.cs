using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max_Mod_3;
using Max_Mod_3_Messages;

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
                Message.NeitherMorePowerful(num1);
            }
            else
            {
                var morePowerful = utility.DetermineMorePowerful(num1, num2);
                Message.MorePowerful(morePowerful);
            }
            Console.ReadLine();
        }
    }
}
