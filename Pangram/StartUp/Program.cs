using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pangram;
using Pangram_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetUserString();
            var justLetters = utility.RemoveNonLetters(userString);
            var allCaps = utility.CapitalizeAllLetters(justLetters);
            var uniqueLeters = utility.RemoveDuplicates(allCaps);
            var isPangram = utility.IsPangram(uniqueLeters);
            utility.DisplayResults(isPangram);
            Console.ReadLine();
        }
    }
}
