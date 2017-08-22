using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC_There;
using ABC_There_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetValidString();
            var abcCount = utility.GetCount(userString, "abc");
            var ABCCount = utility.GetCount(userString, "ABC");
            Message.DisplayResult(abcCount, ABCCount);
            Console.ReadLine();
        }
    }
}
