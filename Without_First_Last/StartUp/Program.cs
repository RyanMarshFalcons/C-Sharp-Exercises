using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Without_First_Last;
using Without_First_Last_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetValidString();
            var newString = utility.MakeNewString(userString);
            Message.DisplayResults(newString);
            Console.ReadLine();
        }
    }
}
