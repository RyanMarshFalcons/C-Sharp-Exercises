using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Max_Mod_N;
using Max_Mod_N_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var num1 = utility.GetValidNumber("first");
            var num2 = utility.GetValidNumber("second");
            var mod = utility.GetValidNumber("Modulus");
            if (utility.CheckIfEqual(num1, num2))
            {
                Message.NeitherMorePowerful(num1);
            }
            else
            {
                var morePowerful = utility.DetermineMorePowerful(num1, num2, mod);
                Message.MorePowerful(morePowerful);
            }
            Console.ReadLine();
        }
    }
}
