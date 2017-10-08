using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Super_Reduced_String;
using Super_Reduced_String_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetUserString();
            var reducedString = utility.ReduceUserString(userString);
            utility.DisplayResults(reducedString);
            Console.ReadLine();
        }
    }
}
