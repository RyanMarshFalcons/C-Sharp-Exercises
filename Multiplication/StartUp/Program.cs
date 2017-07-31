using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multiplication;
using Multiplication_Messages;

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
            var product = utility.GetProduct(num1, num2);
            Message.DisplayProduct(num1, num2, product);
            Console.ReadLine();
        }
    }
}
