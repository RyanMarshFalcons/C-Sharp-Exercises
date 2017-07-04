using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messages;

namespace Guessing_Games
{
    public enum Throw { Rock, Paper, Scissors};
    public class RockPaperScissors
    {
        public Throw ConvertToThrow(int num)
        {
            switch(num)
            {
                case 1:
                    return Throw.Rock; 
                    break;
                case 2:
                    return Throw.Paper;
                    break;
                case 3:
                default:
                    return Throw.Scissors;
                    break;
            }
        }

        public GameResult GetGameResult(Throw userThrow, Throw houseThrow)
        {
            if (userThrow == houseThrow)
            {
                return GameResult.Tied;
            }
            else if (((userThrow == Throw.Paper) && (houseThrow == Throw.Rock)) || ((userThrow == Throw.Rock) && (houseThrow == Throw.Scissors)) || ((userThrow == Throw.Scissors) && (houseThrow == Throw.Paper)))
            {
                return GameResult.Won;
            }
            else
            {
                return GameResult.Lost;
            }
        }

        public void DisplayResults(GameResult gameResult, Throw userThrow, Throw houseThrow)
        {
            if (gameResult == GameResult.Won)
            {
                Message.WonGame(userThrow.ToString(), houseThrow.ToString(), "which beat's the house's throw of");
            }
            else if (gameResult == GameResult.Lost)
            {
                Message.LostGame(userThrow.ToString(), houseThrow.ToString(), "which loses to the house's throw of");
            }
            else
            {
                Message.TiedGame(userThrow.ToString(), houseThrow.ToString(), "and the house also threw");
            }
        }
    }
}
