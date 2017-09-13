using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Substring_Count;
using Substring_Count_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userString = utility.GetValidString("string");
            var userSubstring = utility.GetValidString("substring");
            var substringIsLonger = utility.CheckIfSubstringIsLonger(userString, userSubstring);
            var count = utility.GetCount(userString, userSubstring, substringIsLonger);
            Message.DisplayResult(count);
            Console.ReadLine();
        }
    }
}
