using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cubed;
using Cubed_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var input = utility.GetValidEntry();
            var numCubed = utility.GetNumberCubed(input);
            Message.NumberCubed(input, numCubed);
            Console.ReadLine();
        }
    }
}
