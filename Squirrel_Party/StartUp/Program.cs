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
            var numNuts = utility.GetValidNumber("nuts");
            var numSodas = utility.GetValidNumber("sodas");
            var enoughNuts = utility.EnoughNuts(numNuts);
            var enoughSodas = utility.EnoughSodas(numSodas);
            var dayOfWeek = utility.GetValidDay();
            var isWeekend = utility.IsWeekEnd(dayOfWeek);
            var isSuccesful = utility.IsSuccessful(enoughNuts, enoughSodas, isWeekend);
            utility.DisplayResults(isSuccesful);
            Console.ReadLine();
        }
    }
}
