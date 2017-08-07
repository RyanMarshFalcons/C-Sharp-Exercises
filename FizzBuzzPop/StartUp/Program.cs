using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzPop;
using FizzBuzzPop_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            for (int num = 1; num < 251; num++)
            {
                Console.WriteLine(utility.EvaluateNumber(num));
            }
            Message.ThankYou();
            Console.ReadLine();
        }
    }
}
