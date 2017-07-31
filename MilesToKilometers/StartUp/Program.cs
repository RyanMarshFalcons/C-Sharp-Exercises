using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MilesToKilometers;
using MilesToKilometers_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var miles = utility.GetValidEntry();
            var kilometers = utility.GetKilometers(miles);
            Message.DisplayKilometers(kilometers, miles);
            Console.ReadLine();
        }
    }
}
