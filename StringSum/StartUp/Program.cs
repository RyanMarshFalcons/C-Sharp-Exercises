using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringSum;
using StringSum_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var input = utility.GetUserInput();
            var numList = utility.ExtractNumberCharacters(input);
            var sum = utility.GetSum(numList);
            Message.DisplayResults(numList.Count, sum);
            Console.ReadLine();
        }
    }
}
