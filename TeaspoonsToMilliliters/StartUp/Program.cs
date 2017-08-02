using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaspoonsToMilliliters;
using TeaspoonsToMilliliters_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var teaspoons = utility.GetValidEntry();
            var milliliters = utility.GetMilliliters(teaspoons);
            Message.DisplayMilliliters(teaspoons, milliliters);
            Console.ReadLine();
        }
    }
}
