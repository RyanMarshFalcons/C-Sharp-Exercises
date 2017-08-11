using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Difference84;
using Difference84_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var num = utility.GetValidEntry();
            var isGreaterThan84 = utility.GreaterThan84(num);
            var DifferenceTo84 = utility.DifferenceTo84(num, isGreaterThan84);
            Message.DifferenceTo84(num, DifferenceTo84);
            Console.ReadLine();
        }
    }
}
