using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scores_Increasing;
using Scores_Increasing_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var scores = new int[5];
            scores[0] = utility.GetValidScore("first");
            scores[1] = utility.GetValidScore("second");
            scores[2] = utility.GetValidScore("third");
            scores[3] = utility.GetValidScore("fourth");
            scores[4] = utility.GetValidScore("fifth");
            var areIncreasing = utility.CheckIfIncreasing(scores);
            utility.DisplayResults(areIncreasing);
            Console.ReadLine();
        }
    }
}
