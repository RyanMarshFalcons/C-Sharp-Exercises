using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String_Count;
using String_Count_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetValidString();
            var letterCount = utility.CountLettersInString(userString);
            var numberCount = utility.CountNumbersInString(userString);
            var spaceCount = utility.CountSpacesInString(userString);
            var symbolCount = utility.CountSymbolsInString(userString);
            Message.DisplayCounts(letterCount, numberCount, spaceCount, symbolCount);
            Console.ReadLine();
        }
    }
}
