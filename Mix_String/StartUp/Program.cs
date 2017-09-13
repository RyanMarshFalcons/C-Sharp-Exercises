using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mix_String;
using Mix_String_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = "";
            var listOfUserStrings = new List<string>();
            do
            {
                userString = utility.GetValidString();
                listOfUserStrings.Add(userString);
            } while (utility.AskToAddAnotherString());
            var shortestLength = utility.GetShortestStringLength(listOfUserStrings);
            var newString = utility.MixStringsTogether(listOfUserStrings, shortestLength);
            Message.DisplayNewString(newString);
            Console.ReadLine();
        }
    }
}
