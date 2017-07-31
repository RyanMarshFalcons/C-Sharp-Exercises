using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reverse_A_Number;
using Reverse_A_Number_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var input = utility.GetValidEntry();
            var reversedInput = utility.InputInReverse(input);
            Message.DisplayNumberInReverse(input, reversedInput);
            Console.ReadLine();
        }
    }
}
