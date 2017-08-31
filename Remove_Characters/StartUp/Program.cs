using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Remove_Characters;
using Remove_Characters_Messages;

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
            do
            {
                character = utility.GetValidChar();
                userString = utility.RemoveCharacter(userString, character);
                Message.DisplayNewString(userString, character);
            } while (utility.AskToContinue(userString.Length));
            Message.ThankYou();
            Console.ReadLine();
        }
    }
}
