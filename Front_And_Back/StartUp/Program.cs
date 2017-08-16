using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Front_And_Back;
using Front_And_Back_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetString();
            var newString = utility.SwapFirstAndLast(userString);
            Message.DisplayNewString(newString);
            Console.ReadLine();
        }
    }
}
