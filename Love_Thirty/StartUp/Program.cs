using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Love_Thirty;
using Love_Thirty_Messages;

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
            var loveThirty = false;
            if (utility.CheckIfThirty(num1, num2))
            {
                loveThirty = true;
            }
            if (utility.CheckIfSumIsThirty(num1, num2))
            {
                loveThirty = true;
            }
            if (utility.CheckIfDifferenceIsThirty(num1, num2))
            {
                loveThirty = true;
            }
            if (utility.CheckIfProductIsThirty(num1, num2))
            {
                loveThirty = true;
            }
            if (utility.CheckIfQuotientIsThirty(num1, num2))
            {
                loveThirty = true;
            }
            if (loveThirty == true)
            {
                Message.DoLoveThirty();
            }
            else
            {
                Message.DoNotLoveThirty();
            }
            Console.ReadLine();
        }
    }
}
