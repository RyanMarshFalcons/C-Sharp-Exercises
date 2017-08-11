using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Difference42;
using Difference42_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var num = utility.GetValidEntry();
            var isGreaterThan42 = utility.GreaterThan42(num);
            var DifferenceTo42 = utility.DifferenceTo42(num, isGreaterThan42);
            Message.DifferenceTo42(num, DifferenceTo42);
            Console.ReadLine();
        }
    }
}
