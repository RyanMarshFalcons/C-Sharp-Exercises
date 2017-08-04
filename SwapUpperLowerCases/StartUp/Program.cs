using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwapUpperLowerCases;
using SwapUpperLowerCases_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var input = utility.GetUserInput();
            var inputCasesSwapped = utility.SwapCases(input);
            Message.DisplayResult(input, inputCasesSwapped);
            Console.ReadLine();
        }
    }
}
