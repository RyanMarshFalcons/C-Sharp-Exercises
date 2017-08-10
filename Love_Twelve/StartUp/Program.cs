using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Love_Twelve;
using Love_Twelve_Messages;

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
            var loveTwelve = false;
            if (utility.CheckIfTwelve(num1, num2))
            {
                loveTwelve = true;
            }
            if (utility.CheckIfSumIsTwelve(num1, num2))
            {
                loveTwelve = true;
            }
            if (utility.CheckIfDifferenceIsTwelve(num1, num2))
            {
                loveTwelve = true;
            }
            if (utility.CheckIfProductIsTwelve(num1, num2))
            {
                loveTwelve = true;
            }
            if (utility.CheckIfQuotientIsTwelve(num1, num2))
            {
                loveTwelve = true;
            }
            if (loveTwelve == true)
            {
                Message.DoLoveTwelve();
            }
            else
            {
                Message.DoNotLoveTwelve();
            }
            Console.ReadLine();
        }
    }
}
