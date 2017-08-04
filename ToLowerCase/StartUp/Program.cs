using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToLowerCase;
using ToLowerCase_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var input = utility.GetUserInput();
            var inputLowercased = utility.ToLowerCase(input);
            Message.DisplayResult(input, inputLowercased);
            Console.ReadLine();
        }
    }
}
