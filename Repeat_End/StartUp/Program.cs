using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repeat_End;
using Repeat_End_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetValidString();
            var num = utility.GetValidNumber(userString.Length);
            var newString = utility.CreateNewString(userString, num);
            Message.DisplayResults(newString);
            Console.ReadLine();
        }
    }
}
