using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messages;

namespace Guessing_Games
{
    public enum SideOfCoin { Heads, Tails};
    public class CoinFlip
    {
        public SideOfCoin ConvertToCoinFlipResult(int num)
        {
            if (num == 1)
            {
                return SideOfCoin.Heads;
            }
            else
            {
                return SideOfCoin.Tails;
            }
        }

        public GameResult GetGameResult(SideOfCoin guess, SideOfCoin actual)
        {
            if (guess == actual)
            {
                return GameResult.Won;
            }
            else
            {
                return GameResult.Lost;
            }
        }

        public void DisplayResults(GameResult gameResult, SideOfCoin guess, SideOfCoin actual)
        {
            if(gameResult == GameResult.Won)
            {
                Message.WonGame(guess.ToString(), actual.ToString(), "and the result of the coin toss was also");
            }
            else
            {
                Message.LostGame(guess.ToString(), actual.ToString(), "but the result of the coin toss was");
            }
        }
    }
}
