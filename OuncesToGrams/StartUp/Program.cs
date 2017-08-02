using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OuncesToGrams;
using OuncesToGrams_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var ounces = utility.GetValidEntry();
            var grams = utility.GetGrams(ounces);
            Message.DisplayGrams(ounces, grams);
            Console.ReadLine();
        }
    }
}
