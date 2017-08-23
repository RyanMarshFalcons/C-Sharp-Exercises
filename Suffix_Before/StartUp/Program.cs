using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Suffix_Before;
using Suffix_Before_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetValidString();
            var num = utility.GetValidNumber(userString.Length / 2);
            var suffix = utility.GetSuffix(userString, num);
            var doesRepeat = utility.CheckForMatch(userString, suffix, num);
            if (doesRepeat)
            {
                Message.AppearsAgain(suffix);
            }
            else
            {
                Message.DoesNotAppearAgain(suffix);
            }
            Console.ReadLine();
        }
    }
}
