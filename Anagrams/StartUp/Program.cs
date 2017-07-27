using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anagrams;
using Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var firstString = utility.GetUserInput("first");
            var adjustedFirstString = utility.AdjustString(firstString);
            var sortedFirstString = utility.InputSorted(adjustedFirstString);
            var secondString = utility.GetUserInput("second");
            var adjustedSecondString = utility.AdjustString(secondString);
            var sortedSecondString = utility.InputSorted(adjustedSecondString);
            var areAnagrams = utility.FindOutIfAnagram(sortedFirstString, sortedSecondString);
            utility.DisplayResults(firstString, secondString, areAnagrams);
            Console.ReadLine();
        }
    }
}
