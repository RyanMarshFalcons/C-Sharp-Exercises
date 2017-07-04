using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messages;
using Guessing_Games;

namespace StartUp
{
    public enum GameType { CoinFlip, RockPaperScissors, PickANumber, SkittlesColors, DayOfTheWeek};

    class Program
    {
        static void Main(string[] args)
        {
            Message.Welcome();
            var gameType = GetGameType();
            StartTheGame(gameType);
            Console.ReadLine();
        }

        public static GameType GetGameType()
        {
            var validNums = new int[] { 1, 2, 3, 4, 5 };
            var userSelectionAsString = Universal.GetUserInput(validNums);
            var userSectionAsInt = Universal.ConvertToNum(userSelectionAsString);
            var gameType = GameType.CoinFlip;
            switch (userSectionAsInt)
            {
                case 1:
                    gameType = GameType.CoinFlip;
                    break;
                case 2:
                    gameType = GameType.RockPaperScissors;
                    break;
                case 3:
                    gameType = GameType.PickANumber;
                    break;
                case 4:
                    gameType = GameType.SkittlesColors;
                    break;
                case 5:
                    gameType = GameType.DayOfTheWeek;
                    break;
            }
            return gameType;
        }

        public static void StartTheGame(GameType gametype)
        {
            
            switch(gametype)
            {
                case GameType.CoinFlip:
                    var randomCoinFlip = new Random();
                    var coinFlipResult = randomCoinFlip.Next(1, 3);
                    PlayCoinFlip(coinFlipResult);
                    break;
                case GameType.RockPaperScissors:
                    var randomRPSThrow = new Random();
                    var RPSThrowResult = randomRPSThrow.Next(1, 4);
                    PlayRockPaperScissors(RPSThrowResult);
                    break;
                case GameType.PickANumber:
                    var randomNumber = new Random();
                    var numberChosen = randomNumber.Next(1, 11);
                    PlayPickANumber(numberChosen);
                    break;
                case GameType.SkittlesColors:
                    var randomColor = new Random();
                    var colorChosen = randomColor.Next(1, 7);
                    PlaySkittlesColors(colorChosen);
                    break;
                case GameType.DayOfTheWeek:
                    var randomDay = new Random();
                    var dayOfTheWeek = randomDay.Next(1, 8);
                    PlayPickADay(dayOfTheWeek);
                    break;
            }     
        }

        public static void PlayCoinFlip(int coinFlipResult)
        {
            var coinFlip = new CoinFlip();
            var actualSide = coinFlip.ConvertToCoinFlipResult(coinFlipResult);
            Message.SelectCoinSide();
            var validNums = new int[] { 1, 2 };
            var userSideAsString = Universal.GetUserInput(validNums);
            var userSideAsInt = Universal.ConvertToNum(userSideAsString);
            var userSide = coinFlip.ConvertToCoinFlipResult(userSideAsInt);
            var gameResult = coinFlip.GetGameResult(userSide, actualSide);
            coinFlip.DisplayResults(gameResult, userSide, actualSide);
            
        }

        public static void PlayRockPaperScissors(int myThrow)
        {
            var rockPaperScissors = new RockPaperScissors();
            var houseThrow = rockPaperScissors.ConvertToThrow(myThrow);
            Message.SelectThrow();
            var validNums = new int[] { 1, 2, 3 };
            var userThrowAsString = Universal.GetUserInput(validNums);
            var userThrowAsInt = Universal.ConvertToNum(userThrowAsString);
            var userThrow = rockPaperScissors.ConvertToThrow(userThrowAsInt);
            var gameResult = rockPaperScissors.GetGameResult(userThrow, houseThrow);
            rockPaperScissors.DisplayResults(gameResult, userThrow, houseThrow);
        }

        public static void PlayPickANumber(int correctNumber)
        {
            var pickANumber = new PickANumber();
            var userGuess= pickANumber.MakeAGuess("first");
            var guessResult = pickANumber.CompareNumbers(userGuess, correctNumber);
            if (guessResult != Guess.Correct)
            {
                userGuess = pickANumber.MakeAGuess("second");
                guessResult = pickANumber.CompareNumbers(userGuess, correctNumber);
            }
            if (guessResult != Guess.Correct)
            {
                userGuess = pickANumber.MakeAGuess("third");
                guessResult = pickANumber.CompareNumbers(userGuess, correctNumber);
            }
            pickANumber.DisplayResults(guessResult, userGuess, correctNumber);
        }

        public static void PlaySkittlesColors(int houseColor)
        {
            var skittlesColors = new SkittlesColors();
            var actualColor = skittlesColors.ConvertToSkittlesColor(houseColor);
            var gameResult = GameResult.Lost;
            var userGuess = skittlesColors.MakeAGuess("first");
            if (userGuess != actualColor)
            {
                Message.IncorrectColor(userGuess.ToString());
                userGuess = skittlesColors.MakeAGuess("second");
            }
            if (userGuess != actualColor)
            {
                Message.IncorrectColor(userGuess.ToString());
                userGuess = skittlesColors.MakeAGuess("third");
            }
            if (userGuess == actualColor)
            {
                gameResult = GameResult.Won;
            }
            skittlesColors.DisplayResults(gameResult, userGuess, actualColor);
        }

        public static void PlayPickADay (int houseDay)
        {
            var pickADay = new PickADay();
            var actualDay = pickADay.ConvertToDay(houseDay);
            var userGuess = pickADay.MakeAGuess("first");
            var gameResult = pickADay.CompareDays(userGuess, actualDay);
            if (userGuess != actualDay)
            {
                userGuess = pickADay.MakeAGuess("second");
                gameResult = pickADay.CompareDays(userGuess, actualDay);
            }
            if (userGuess != actualDay)
            {
                userGuess = pickADay.MakeAGuess("third");
                gameResult = pickADay.CompareDays(userGuess, actualDay);

            }
            if (userGuess == actualDay)
            {
                gameResult = DayGuess.Correct;
            }
            pickADay.DisplayResults(gameResult, userGuess, actualDay);
        }
    }
}
