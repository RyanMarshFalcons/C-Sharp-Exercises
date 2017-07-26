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
            var manipulation = new Manipulation();
            var firstString = manipulation.GetUserInput("first");
            var adjustedFirstString = manipulation.AdjustString(firstString);
            var sortedFirstString = manipulation.InputSorted(adjustedFirstString);
            var secondString = manipulation.GetUserInput("second");
            var adjustedSecondString = manipulation.AdjustString(secondString);
            var sortedSecondString = manipulation.InputSorted(adjustedSecondString);
            var areAnagrams = manipulation.FindOutIfAnagram(sortedFirstString, sortedSecondString);
            manipulation.DisplayResults(firstString, secondString, areAnagrams);
            Console.ReadLine();
        }
    }
}
