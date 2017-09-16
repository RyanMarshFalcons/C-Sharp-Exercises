using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collatz_Conjecture;
using Collatz_Conjecture_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var startingNumber = utility.GetStartingNumber();
            var numSteps = utility.GetNumberOfSteps(startingNumber);
            Message.DisplayResults(startingNumber, numSteps);
            Console.ReadLine();
        }
    }
}
