using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Perfect_Numbers;
using Perfect_Numbers_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userNum = utility.GetUserNumber();
            var factors = utility.CalculateFactors(userNum);
            var sum = utility.CalculateSumOfFactors(factors);
            var classification = utility.DetermineClassifiation(userNum, sum);
            utility.DisplayResults(userNum, sum, classification);
            Console.ReadLine();
        }
    }
}
