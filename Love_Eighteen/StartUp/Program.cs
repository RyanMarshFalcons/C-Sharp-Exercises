using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Love_Eighteen;
using Love_Eighteen_Messages;

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
            var loveEighteen = false;
            if (utility.CheckIfEighteen(num1, num2))
            {
                loveEighteen = true;
            }
            if (utility.CheckIfSumIsEighteen(num1, num2))
            {
                loveEighteen = true;
            }
            if (utility.CheckIfDifferenceIsEighteen(num1, num2))
            {
                loveEighteen = true;
            }
            if (utility.CheckIfProductIsEighteen(num1, num2))
            {
                loveEighteen = true;
            }
            if (utility.CheckIfQuotientIsEighteen(num1, num2))
            {
                loveEighteen = true;
            }
            if (loveEighteen == true)
            {
                Message.DoLoveEighteen();
            }
            else
            {
                Message.DoNotLoveEighteen();
            }
            Console.ReadLine();
        }
    }
}
