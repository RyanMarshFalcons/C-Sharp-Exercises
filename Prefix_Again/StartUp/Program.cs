using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prefix_Again;
using Prefix_Again_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetValidString();
            var num = utility.GetValidNumber(userString.Length/2);
            var prefix = utility.GetPrefix(userString, num);
            var doesRepeat = utility.CheckForMatch(userString, prefix, num);
            if (doesRepeat)
            {
                Message.AppearsAgain(prefix);
            }
            else
            {
                Message.DoesNotAppearAgain(prefix);
            }
            Console.ReadLine();
        }
    }
}
