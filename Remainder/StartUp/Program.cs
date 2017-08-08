using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Remainder;
using Remainder_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var dividend = utility.GetValidEntry("dividend");
            var divisor = utility.GetValidEntry("divisor");
            var remainder = utility.GetRemainder(dividend, divisor);
            Message.DisplayResults(dividend, divisor, remainder);
            Console.ReadLine(); 
        }
    }
}
