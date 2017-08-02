using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KilogramsToPounds;
using KilogramsToPounds_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var kilograms = utility.GetValidEntry();
            var pounds = utility.GetPounds(kilograms);
            Message.DisplayPounds(kilograms, pounds);
            Console.ReadLine();
        }
    }
}
