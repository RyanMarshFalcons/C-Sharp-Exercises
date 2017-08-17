using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using String_Longest_5;
using String_Longest_5_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userStrings = new string[5];
            for (int i = 0; i < userStrings.Length; i++)
            {
                userStrings[i] = utility.GetString(i + 1);
            }
            var stringLengths = new int[5];
            for (int i = 0; i < userStrings.Length; i++)
            {
                stringLengths[i] = userStrings[i].Length;
            }
            var longestLength = utility.GetLongestLength(stringLengths);
            Message.DisplayLongest(longestLength);
            Console.ReadLine();
        }
    }
}
