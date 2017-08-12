using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Slightly_More_20;
using Slightly_More_20_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var input = utility.GetValidNumber();
            var amtOver = utility.GetRemainder(input);
            var isSlightlyMore = utility.IsSlightlyMore(amtOver);
            utility.DisplayResults(isSlightlyMore, input);
            Console.ReadLine();
        }
    }
}
