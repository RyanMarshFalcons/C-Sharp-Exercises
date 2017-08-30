using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Locate_Characters;
using Locate_Characters_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetValidString();
            var character = ' ';
            var count = 0;
            do
            {
                character = utility.GetSpecificChar();
                count = utility.SearchForCharacter(userString, character);
                Message.DisplayResults(character, count);
            } while (utility.AskToContinue());
            Message.ThankYou();
            Console.ReadLine();
        }
    }
}
