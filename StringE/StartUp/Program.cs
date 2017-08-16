using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringE;
using StringE_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetString();
            var isStringE = utility.CheckIfStringE(userString);
            utility.DisplayResults(isStringE);
            Console.ReadLine();
        }
    }
}
