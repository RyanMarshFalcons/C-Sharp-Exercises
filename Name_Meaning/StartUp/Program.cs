using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Name_Meaning;
using Name_Meaning_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userName = utility.GetUsersName();
            var modifiedUserName = utility.GetJustLetters(userName);
            var adjectiveDictionary = utility.GetAdjectiveDictionary();
            var nameDescription = utility.GetDescription(modifiedUserName, adjectiveDictionary);
            Message.DisplayResult(userName);
            foreach (var adjective in nameDescription)
            {
                Console.WriteLine(adjective);
            }
            Message.CloseProgram();
        }
    }
}
