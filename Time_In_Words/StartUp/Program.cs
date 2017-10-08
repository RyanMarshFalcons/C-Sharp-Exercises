using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_In_Words;
using Time_In_Words_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var timeAsNumerals = utility.GetTimeAsNumerals();
            var hours = int.Parse(timeAsNumerals[0]);
            var minutes = int.Parse(timeAsNumerals[1]);
            var timeVariant = utility.DetermineTimeVariant(minutes);
            var timeInWords = utility.CalculateTimeInWords(minutes, hours, timeVariant);
            Message.DisplayTimeInWords(timeInWords);
            Console.ReadLine();
        }
    }
}
