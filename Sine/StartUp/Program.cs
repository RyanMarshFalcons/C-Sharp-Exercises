using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sine;
using Sine_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var input = utility.GetValidEntry();
            var sineOfInput = utility.GetSine(input);
            Message.SineOfNum(input, sineOfInput);
            Console.ReadLine();
        }
    }
}
