using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SquareRoot;
using SquareRoot_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var input = utility.GetValidEntry();
            if (utility.CheckIfNegative(input) == true)
            {
                Message.CantBeNegative();
            }
            else
            {
                var sqrtOfInput = utility.GetSquareRoot(input);
                Message.SquareRootOfNum(input, sqrtOfInput);
            }
            Console.ReadLine();
        }
    }
}
