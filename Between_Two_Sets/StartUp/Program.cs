using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Between_Two_Sets;
using Between_Two_Sets_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var firstSet = new int[3];
            var secondSet = new int[3];
            for (int i = 0; i < firstSet.Length; i++)
            {
                firstSet[i] = utility.GetValidNumber(i + 1, "first");
            }
            for (int i = 0; i < secondSet.Length; i++)
            {
                secondSet[i] = utility.GetValidNumber(i + 1, "second");
            }
            var numsBetween = utility.CalculateBetween(firstSet, secondSet);
            utility.DisplayResults(numsBetween);
            Console.ReadLine();
        }
    }
}
