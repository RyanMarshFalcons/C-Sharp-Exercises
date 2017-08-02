using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GallonsToLiters;
using GallonsToLiters_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var gallons = utility.GetValidEntry();
            var liters = utility.GetLiters(gallons);
            Message.DisplayLiters(gallons, liters);
            Console.ReadLine();
        }
    }
}
