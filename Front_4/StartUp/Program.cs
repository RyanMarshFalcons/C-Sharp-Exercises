using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Front_4;
using Front_4_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetString();
            var newString = utility.CreateNewString(userString);
            Message.DisplayNewString(newString);
            Console.ReadLine();
        }
    }
}
