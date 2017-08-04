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
            var input = utility.GetUserInput();
            var acronym = utility.ConvertToAcronym(input);
            utility.DisplayResults(input, acronym);
            Console.ReadLine();
        }
    }
}
