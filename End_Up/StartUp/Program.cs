using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using End_Up;
using End_Up_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetString();
            var newString = utility.MakeEndUpperCase(userString);
            Message.DisplayNewString(newString);
            Console.ReadLine();
        }
    }
}
