using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Front_Again_2;
using Front_Again_2_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetValidString();
            var begining = utility.GetBegining(userString);
            var ending = utility.GetEnding(userString);
            utility.DisplayResults(begining, ending);
            Console.ReadLine();
        }
    }
}
