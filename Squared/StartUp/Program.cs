using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Squared;
using SquaredMessages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var input = utility.GetValidEntry();
            var numSquared = utility.GetNumberSquared(input);
            Message.NumberSquared(input, numSquared);
            Console.ReadLine();
        }
    }
}
