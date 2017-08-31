using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Replace_Characters;
using Replace_Characters_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetString();
            var maxIndex = utility.GetMaxIndex(userString);
            do
            {
                var userCharacter = utility.GetCharacter();
                var index = utility.GetIndex(maxIndex, userCharacter);
                userString = utility.GetNewString(userString, index, userCharacter);
                Message.DisplayNewString(userString, userCharacter, index);
            } while (utility.AskToContinue());
            Message.ThankYou();
            Console.ReadLine();
        }
    }
}
