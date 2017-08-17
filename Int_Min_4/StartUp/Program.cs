using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Int_Min_4;
using Int_Min_4_Messages;

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
            var num4 = utility.GetValidNumber("fourth");
            var minNum = utility.GetMin(num1, num2, num3, num4);
            Message.DisplayHighest(minNum);
            Console.ReadLine();
        }
    }
}
