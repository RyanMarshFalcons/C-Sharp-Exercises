using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Non_Start_3;
using Non_Start_3_Messages;

namespace Startup
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userStrings = new List<string>();
            for (int i = 1; i < 4; i++)
            {
                userStrings.Add(utility.GetValidString(i));
            }
            var newString = utility.MakeNewString(userStrings);
            Message.DisplayResults(newString);
            Console.ReadLine();
        }
    }
}
