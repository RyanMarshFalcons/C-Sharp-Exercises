using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messages;
using System.Text.RegularExpressions;

namespace Guessing_Games
{
    public enum GameType { CoinFlip, RockPaperScissors, PickANumber, SkittlesColors, DayOfTheWeek };
    public enum GameResult { Won, Lost, Tied};

    public class Utility
    {
        public string GetGameTypeSelectionLetter()
        {
            var isValidInput = false;
            var input = "";
            while (isValidInput == false)
            {
                input = Console.ReadLine();
                if (CheckIfValidSelection(input) == false)
                {
                    Message.InvalidGameSelection(input);
                }
                else
                {
                    isValidInput = true;
                }
            }
            return input;
        }

        public bool CheckIfValidSelection(string input)
        {
            return (Regex.IsMatch(input, "^[A-E() ]+$") && input.Length == 1);
        }

        public GameType ConvertLetterToGameType(string gameSelectionLetter)
        {
            switch (gameSelectionLetter)
            {
                case "A":
                    return GameType.CoinFlip;
                    break;
                case "B":
                    return GameType.RockPaperScissors;
                    break;
                case "C":
                    return GameType.PickANumber;
                    break;
                case "D":
                    return GameType.SkittlesColors;
                    break;
                case "E":
                default:
                    return GameType.DayOfTheWeek;
                    break;
            }
        }
        
        public void StartTheGame(GameType gametype)
        {
            switch (gametype)
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

        public void PlayCoinFlip(int coinFlipResult)
        {
            var coinFlip = new CoinFlip();
            var actualSide = coinFlip.ConvertToCoinFlipResult(coinFlipResult);
            Message.SelectCoinSide();
            var validNums = new int[] { 1, 2 };
            var userSideAsString = GetUserInput(validNums);
            var userSideAsInt = ConvertToNum(userSideAsString);
            var userSide = coinFlip.ConvertToCoinFlipResult(userSideAsInt);
            var gameResult = coinFlip.GetGameResult(userSide, actualSide);
            coinFlip.DisplayResults(gameResult, userSide, actualSide);
        }

        public void PlayRockPaperScissors(int myThrow)
        {
            var rockPaperScissors = new RockPaperScissors();
            var houseThrow = rockPaperScissors.ConvertToThrow(myThrow);
            Message.SelectThrow();
            var validNums = new int[] { 1, 2, 3 };
            var userThrowAsString = GetUserInput(validNums);
            var userThrowAsInt = ConvertToNum(userThrowAsString);
            var userThrow = rockPaperScissors.ConvertToThrow(userThrowAsInt);
            var gameResult = rockPaperScissors.GetGameResult(userThrow, houseThrow);
            rockPaperScissors.DisplayResults(gameResult, userThrow, houseThrow);
        }

        public void PlayPickANumber(int correctNumber)
        {
            Message.GuessNumberIntro();
            var pickANumber = new PickANumber();
            var userGuess = pickANumber.MakeAGuess("first");
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

        public void PlaySkittlesColors(int houseColor)
        {
            Message.SkittlesIntro();
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

        public void PlayPickADay(int houseDay)
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

        public int ConvertToNum(string input)
        {
            var inputAsInt = 0;
            var result = int.TryParse(input, out inputAsInt);
            return inputAsInt;
        }

        public string GetUserInput(int [] validNums)
        {
            var validInput = false;
            var input = "";
            do
            {
                input = Console.ReadLine();
                var inputAsNum = ConvertToNum(input);
                if (DetermineIfInputWasValid(inputAsNum, validNums))
                {
                    validInput = true;
                }
                else
                {
                    Message.InvalidGuess(input);
                }
            } while (validInput == false);
            return input;
        }

        public bool DetermineIfInputWasValid (int input, int[] validSelections)
        {
            var wasInputValid = false;
            foreach (var num in validSelections)
            {
                if (input == num)
                {
                    wasInputValid = true;
                }
            }
            return wasInputValid;
        }
    }
}
