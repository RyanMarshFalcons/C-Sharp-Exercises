using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReverseAString;
using Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            Message.EnterString();
            var userInput = Console.ReadLine();
            var utility = new Utility();
            var reversedInput = utility.inputInReverse(userInput);
            Message.DisplayStringInReverse(reversedInput);
            Console.ReadLine();
        }
    }
}
