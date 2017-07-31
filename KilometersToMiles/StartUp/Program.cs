using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KilometersToMiles;
using KilometersToMiles_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var kilometers = utility.GetValidEntry();
            var miles = utility.GetMiles(kilometers);
            Message.DisplayMiles(kilometers, miles);
            Console.ReadLine();
        }
    }
}
