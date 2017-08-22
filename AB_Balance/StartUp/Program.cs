using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AB_Balance;
using AB_Balance_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetValidString();
            var aCount = utility.GetCount(userString, "a");
            var ACount = utility.GetCount(userString, "A");
            var bCount = utility.GetCount(userString, "b");
            var BCount = utility.GetCount(userString, "B");
            if (utility.CheckIfBalance(aCount, ACount, bCount, BCount))
            {
                Message.WasABalance();
            }
            else
            {
                Message.WasNotABalance();
            }
            Console.ReadLine();
        }
    }
}
