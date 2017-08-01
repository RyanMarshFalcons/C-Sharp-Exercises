using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FeetToMeters;
using FeetToMeters_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var feet = utility.GetValidEntry();
            var meters = utility.GetMeters(feet);
            Message.DisplayMeters(feet, meters);
            Console.ReadLine();
        }
    }
}
