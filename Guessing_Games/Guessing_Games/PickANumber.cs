using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messages;

namespace Guessing_Games
{
    public enum Guess { TooHigh, TooLow, Correct };
    public class PickANumber
    {
        public Guess CompareNumbers(int userGuess, int actualNumber)
        {
            if (userGuess < actualNumber)
            {
                Message.NumberIsHigherOrLower("higher", userGuess.ToString());
                return Guess.TooLow;
            }
            else if (userGuess > actualNumber)
            {
                Message.NumberIsHigherOrLower("lower", userGuess.ToString());
                return Guess.TooHigh;
            }
            else
            {
                return Guess.Correct;
            }
        }

        public int MakeAGuess(string attempt)
        {
            var utility = new Utility();
            Message.SelectNumber(attempt);
            var validNums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var userGuessAsString = utility.GetUserInput(validNums);
            return utility.ConvertToNum(userGuessAsString);
        }

        public void DisplayResults(Guess guessResult, int userGuess, int actualNumber)
        {
            if (guessResult == Guess.Correct)
            {
                Message.WonGame(userGuess.ToString(), actualNumber.ToString(), "and the correct number was");
            }
            else
            {
                Message.LostGame(userGuess.ToString(), actualNumber.ToString(), "and the actual number was");
            }
        }
    }
}
