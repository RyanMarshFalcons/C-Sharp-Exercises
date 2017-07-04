using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messages;

namespace Guessing_Games
{
    public enum Color { red, green, orange, yellow, purple, pink};
    public class SkittlesColors
    {
        public Color ConvertToSkittlesColor(int num)
        {
            switch (num)
            {
                case 1:
                    return Color.red;
                    break;
                case 2:
                    return Color.green;
                    break;
                case 3:
                    return Color.orange;
                    break;
                case 4:
                    return Color.yellow;
                    break;
                case 5:
                    return Color.purple;
                    break;
                case 6:
                default:
                    return Color.pink;
                    break;
            }
        }

        public Color MakeAGuess(string attempt)
        {
            Message.SelectColor(attempt);
            var validNums = new int[] { 1, 2, 3, 4, 5, 6 };
            var userGuessAsString = Universal.GetUserInput(validNums);
            var guessAsNum = Universal.ConvertToNum(userGuessAsString);
            return ConvertToSkittlesColor(guessAsNum);
        }

        public void DisplayResults(GameResult gameResult, Color guess, Color actual)
        {
            if (gameResult == GameResult.Won)
            {
                Message.WonGame(guess.ToString(), actual.ToString(), "and the actual color of the skittles candy was also");
            }
            else
            {
                Message.LostGame(guess.ToString(), actual.ToString(), "but the actual color of the skittles candy\nwas");
            }
        }
    }
}
