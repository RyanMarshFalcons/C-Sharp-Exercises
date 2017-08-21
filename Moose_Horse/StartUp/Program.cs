using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moose_Horse;
using Moose_Horse_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetValidString();
            var mooseCount = utility.GetCount(userString, "moose");
            var horseCount = utility.GetCount(userString, "horse");
            Message.DisplayResult(mooseCount, horseCount);
            Console.ReadLine();
        }
    }
}
