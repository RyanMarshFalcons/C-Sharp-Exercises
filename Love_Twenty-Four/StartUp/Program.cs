using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Love_Twenty_Four;
using Love_Twenty_Four_Messages;

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
            var loveTwentyFour = false;
            if (utility.CheckIfTwentyFour(num1, num2))
            {
                loveTwentyFour = true;
            }
            if (utility.CheckIfSumIsTwentyFour(num1, num2))
            {
                loveTwentyFour = true;
            }
            if (utility.CheckIfDifferenceIsTwentyFour(num1, num2))
            {
                loveTwentyFour = true;
            }
            if (utility.CheckIfProductIsTwentyFour(num1, num2))
            {
                loveTwentyFour = true;
            }
            if (utility.CheckIfQuotientIsTwentyFour(num1, num2))
            {
                loveTwentyFour = true;
            }
            if (loveTwentyFour == true)
            {
                Message.DoLoveTwentyFour();
            }
            else
            {
                Message.DoNotLoveTwentyFour();
            }
            Console.ReadLine();
        }
    }
}
