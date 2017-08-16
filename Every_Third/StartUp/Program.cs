using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Every_Third;
using Every_Third_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetString();
            var newString = utility.FormStringFromEveryThirdChar(userString);
            Message.DisplayNewString(newString);
            Console.ReadLine();
        }
    }
}
