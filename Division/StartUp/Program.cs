using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Division;
using Division_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var num1 = utility.GetValidEntry();
            var num2 = utility.GetValidEntry();
            var quotient = utility.GetQuotient(num1, num2);
            Message.DisplayQuotient(num1, num2, quotient);
            Console.ReadLine();
        }
    }
}
