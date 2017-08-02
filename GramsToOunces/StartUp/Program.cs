using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GramsToOunces;
using GramsToOunces_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var grams = utility.GetValidEntry();
            var ounces = utility.GetOunces(grams);
            Message.DisplayOunces(grams, ounces);
            Console.ReadLine();
        }
    }
}
