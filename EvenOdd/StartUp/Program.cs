using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvenOdd;
using EvenOdd_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var input = utility.GetValidEntry();
            if (utility.CheckIfEven(input) == true)
            {
                Message.IsEven(input);
            }
            else
            {
                Message.IsOdd(input);
            }
            Console.ReadLine();
        }
    }
}
