using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToUpperCase;
using ToUpperCase_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var input = utility.GetUserInput();
            var inputUppercased = utility.ToUpperCase(input);
            Message.DisplayResult(input, inputUppercased);
            Console.ReadLine();
        }
    }
}
