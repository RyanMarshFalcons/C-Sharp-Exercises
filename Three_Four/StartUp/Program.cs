using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Three_Four;
using Three_Four_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetValidString();
            var newString = utility.CreateNewString(userString);
            Message.DisplayResult(newString);
            Console.ReadLine();
        }
    }
}
