using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Difference63;
using Difference63_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var num = utility.GetValidEntry();
            var isGreaterThan63 = utility.GreaterThan63(num);
            var DifferenceTo63 = utility.DifferenceTo63(num, isGreaterThan63);
            Message.DifferenceTo63(num, DifferenceTo63);
            Console.ReadLine();
        }
    }
}
