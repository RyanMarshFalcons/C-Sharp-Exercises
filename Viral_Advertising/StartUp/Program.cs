using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Viral_Advertising;
using Viral_Advertising_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var initialNumPeople = utility.GetInitialNumberOfPeople();
            var numDays = utility.GetNumberOfDays();
            var totalLikes = utility.CaluclateTotalLikes(initialNumPeople, numDays);
            Message.DisplayResult(initialNumPeople, numDays, totalLikes);
            Console.ReadLine();
        }
    }
}
