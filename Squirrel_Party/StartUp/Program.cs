using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Squirrel_Party;
using Squirrel_Party_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var numNuts = utility.GetValidNumber();
            var isAtLeast50 = utility.AtLeast50Nuts(numNuts);
            var dayOfWeek = utility.GetValidDay();
            var isWeekend = utility.IsWeekEnd(dayOfWeek);
            var isSuccesful = utility.IsSuccessful(isAtLeast50, isWeekend);
            utility.DisplayResults(isSuccesful);
            Console.ReadLine();
        }
    }
}
