using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leap_Year;
using Leap_Year_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var input = utility.GetValidEntry();
            if (utility.CheckIfLeapYear(input) == true)
            {
                Message.IsALeapYear(input);
            }
            else
            {
                Message.NotALeapYear(input);
            }
            Console.ReadLine();
        }
    }
}
