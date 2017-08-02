using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MillilitersToTeaspoons;
using MillilitersToTeaspoons_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var milliliters = utility.GetValidEntry();
            var teaspoons = utility.GetTeaspoons(milliliters);
            Message.DisplayTeaspoons(milliliters, teaspoons);
            Console.ReadLine();
        }
    }
}
