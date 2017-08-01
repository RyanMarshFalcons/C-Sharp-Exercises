using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetersToFeet;
using MetersToFeet_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var meters = utility.GetValidEntry();
            var feet = utility.GetFeet(meters);
            Message.DisplayFeet(meters, feet);
            Console.ReadLine();
        }
    }
}
