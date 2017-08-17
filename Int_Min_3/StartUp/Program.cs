using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Int_Min_3;
using Int_Min_3_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var num1 = utility.GetValidNumber("first");
            var num2 = utility.GetValidNumber("second");
            var num3 = utility.GetValidNumber("third");
            var minNum = utility.GetMin(num1, num2, num3);
            Message.DisplayHighest(minNum);
            Console.ReadLine();
        }
    }
}
