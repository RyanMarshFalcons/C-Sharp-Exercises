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
            var userString = utility.GetUserString();
            var acronym = utility.ConvertToAcronym(userString);
            Message.DisplayResult(userString, acronym);
            Console.ReadLine();
        }
    }
}
