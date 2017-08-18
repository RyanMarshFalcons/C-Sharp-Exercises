using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Make_ABBA;
using Make_ABBA_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString1 = utility.GetValidString();
            var userString2 = utility.GetValidString();
            var newString = utility.MakeNewString(userString1, userString2);
            Message.DisplayResults(newString);
            Console.ReadLine();
        }
    }
}
