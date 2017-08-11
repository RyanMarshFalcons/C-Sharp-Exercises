using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Difference21;
using Difference21_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var num = utility.GetValidEntry();
            var isGreaterThan21 = utility.GreaterThan21(num);
            var DifferenceTo21 = utility.DifferenceTo21(num, isGreaterThan21);
            Message.DifferenceTo21(num, DifferenceTo21);
            Console.ReadLine();
        }
    }
}
