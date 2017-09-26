using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scrabble_Score;
using Scrabble_Score_Messages;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var userWord = utility.GetValidWord();
            var baseValues = utility.CalculateBaseValues(userWord);
            var squareTypes = utility.GetSquareTypes(userWord);
            var wordScore = utility.CalculateWordScore(baseValues, squareTypes);
            Message.DisplayWordScore(userWord, wordScore);
            Console.ReadLine();
        }
    }
}
