using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Symbol_Count;
using Symbol_Count_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var input = utility.GetUserInput();
            var inputArr = utility.ConvertToCharArray(input);
            var symbolCount = utility.CountSymbolsInArray(inputArr);
            Message.DisplayCount(symbolCount);
            Console.ReadLine();
        }
    }
}
