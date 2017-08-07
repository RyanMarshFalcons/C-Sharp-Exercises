using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Golf_ScoreCard;
using Golf_ScoreCard_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var scoreCard = new List<int>();
            var score = 0;
            var par = 0;
            for (int holeNum = 1; holeNum < 19; holeNum++)
            {
                par = utility.GetParForHole(holeNum);
                score = utility.GetValidEntry(holeNum, par);
                scoreCard.Add(score);
            }
            var totalScore = utility.GetTotalScore(scoreCard);
            utility.DisplayResults(totalScore);
            Console.ReadLine();
        }
    }
}
