using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sleep_In;
using Sleep_In_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var dayOfWeek = utility.GetValidEntry();
            var isWeekend = utility.IsWeekEnd(dayOfWeek);
            var isVacation = utility.AskIfVacationDay();
            var canSleepIn = utility.CanSleepIn(isWeekend, isVacation);
            utility.DisplayResults(canSleepIn);
            Console.ReadLine();
        }
    }
}
