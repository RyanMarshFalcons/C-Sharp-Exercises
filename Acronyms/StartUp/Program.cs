using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acronyms;
using Acronyms_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = "";
            var acronym = "";
            var listOfAcronyms = new List<string>();
            do
            {
            userString = utility.GetUserString();
            acronym = utility.ConvertToAcronym(userString);
            Message.DisplayAcronym(userString, acronym);
            listOfAcronyms.Add(acronym);
            } while (utility.AskToContinue());
            Message.DisplayAllAcronyms();
            foreach (var acronymEntry in listOfAcronyms)
            {
                Console.WriteLine(acronymEntry);
            }
            Message.ThankYou();
            Console.ReadLine();
        }
    }
}
