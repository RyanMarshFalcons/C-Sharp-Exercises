using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messages;
using Guessing_Games;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var utility = new Utility();
            var gameTypeLetter = utility.GetGameTypeSelectionLetter();
            var gameType = utility.ConvertLetterToGameType(gameTypeLetter);
            utility.StartTheGame(gameType);
            Console.ReadLine();
        }
    }
}
