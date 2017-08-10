using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Love_Six;
using Love_Six_Messages;

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
            var loveSix = false;
            if (utility.CheckIfSix(num1, num2))
            {
                loveSix = true;
            }
            if (utility.CheckIfSumIsSix(num1, num2))
            {
                loveSix = true;
            }
            if (utility.CheckIfDifferenceIsSix(num1, num2))
            {
                loveSix = true;
            }
            if (utility.CheckIfProductIsSix(num1, num2))
            {
                loveSix = true;
            }
            if (utility.CheckIfQuotientIsSix(num1, num2))
            {
                loveSix = true;
            }
            if (loveSix == true)
            {
                Message.DoLoveSix();
            }
            else
            {
                Message.DoNotLoveSix();
            }
            Console.ReadLine();
        }
    }
}
