using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beautiful_Days_At_The_Movies;
using Beautiful_Days_At_The_Movies_Messages;

namespace StartUp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var firstDay = utility.GetValidDay("first");
            var lastDay = 0;
            while (!utility.CheckIfLastIsGreaterThanFirst(firstDay, lastDay))
            {
                lastDay = utility.GetValidDay("last");
                if (!utility.CheckIfLastIsGreaterThanFirst(firstDay, lastDay))
                {
                    Message.LastDayMustBeGreater();
                }
            }
            var divisor = utility.GetDivisor();
            var beautifulDays = utility.CalculateBeautifulDays(firstDay, lastDay, divisor);
            utility.DisplayResults(firstDay, lastDay, beautifulDays);
            Console.ReadLine();
        }
    }
}
