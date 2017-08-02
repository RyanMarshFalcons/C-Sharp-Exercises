using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LitersToGallons;
using LitersToGallons_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var liters = utility.GetValidEntry();
            var gallons = utility.GetGallons(liters);
            Message.DisplayGallons(liters, gallons);
            Console.ReadLine();
        }
    }
}
