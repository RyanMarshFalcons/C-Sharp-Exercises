using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tea_Party;
using Tea_Party_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var numTeaCups = utility.GetValidNumber("tea cups");
            var numCandyBars = utility.GetValidNumber("candy bars");
            var outcome = utility.CalculatePartyOutcome(numTeaCups, numCandyBars);
            Message.DisplayResults(outcome);
            Console.ReadLine();
        }
    }
}
