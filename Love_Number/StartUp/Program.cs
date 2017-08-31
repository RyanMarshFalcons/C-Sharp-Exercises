using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Love_Number;
using Love_Number_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var loveNum = utility.GetValidNumber("love");
            Message.RequestTwoMoreNums(loveNum);
            var num1 = utility.GetValidNumber("first");
            var num2 = utility.GetValidNumber("second");
            var doLoveNum = false;
            if (utility.CheckIfLoveNum(num1, num2, loveNum) || utility.CheckIfSumIsLoveNum(num1, num2, loveNum) || utility.CheckIfDifferenceIsLoveNum(num1, num2, loveNum) || utility.CheckIfProductIsLoveNum(num1, num2, loveNum) || utility.CheckIfQuotientIsLoveNum(num1, num2, loveNum))
            {
                doLoveNum = true;
            }
            utility.DisplayResults(doLoveNum, loveNum);
            Console.ReadLine();
        }
    }
}
