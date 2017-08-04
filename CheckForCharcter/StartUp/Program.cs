using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckForCharcter;
using CheckForCharacter_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var text = utility.GetUserInput();
            var character = utility.GetSpecificChar();
            var count = utility.SearchForCharacter(text, character);
            Message.DisplayResults(text, character, count);
            Console.ReadLine();
        }
    }
}
