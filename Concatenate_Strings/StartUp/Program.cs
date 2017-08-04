using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concatenate_Strings;
using Concatenate_Strings_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var firstInput = utility.GetUserInput("first");
            var secondInput = utility.GetUserInput("second");
            var combinedInput = utility.ConcatenateStrings(firstInput, secondInput);
            Message.DisplayResult(firstInput, secondInput, combinedInput);
            Console.ReadLine();
        }
    }
}
