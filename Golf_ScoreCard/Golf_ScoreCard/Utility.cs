using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Golf_ScoreCard_Messages;

namespace Golf_ScoreCard
{
    public class Utility
    {
        public int GetValidEntry(int holeNumber, int par)
        {
            Message.EnterScore(holeNumber, par);
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfInt(input) == false)
                {
                    Message.NotANumber(input, holeNumber);
                }
                else
                {
                    if (IsPositive(input) == false)
                    {
                        Message.MustBePositive(holeNumber);
                    }
                    else
                    {
                        isValidInput = true;
                    }
                }
            }
            return int.Parse(input);
        }

        public bool CheckIfInt(string input)
        {
            var num = 0;
            return int.TryParse(input, out num);
        }

        public bool IsPositive(string input)
        {
            return int.Parse(input) > 0;
        }

        public int GetParForHole(int holeNum)
        {
            if ((holeNum == 2) || (holeNum == 6) || (holeNum == 11) || (holeNum == 15))
            {
                return 3;
            }
            else if ((holeNum == 4) || (holeNum == 8) || (holeNum == 13) || (holeNum == 17))
            {
                return 5;
            }
            else
            {
                return 4;
            }
        }

        public int GetTotalScore(List<int> scorecard)
        {
            var totalScore = 0;
            foreach (var score in scorecard)
            {
                totalScore += score;
            }
            return totalScore;
        }

        public void DisplayResults(int totalScore)
        {
            if (totalScore > 72)
            {
                Message.OverPar(totalScore, totalScore - 72);
            }
            else if (totalScore < 72)
            {
                Message.UnderPar(totalScore, 72 - totalScore);
            }
            else
            {
                Message.EvenPar();
            }
        }
    }
}
