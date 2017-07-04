using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Guessing_Games;
using StartUp;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Guessing_Games_Tests
{
    [TestClass]
    public class Program_Test
    {
        [TestMethod]
        public void ReturnsCoinFlipWin()
        {
            var expectedGameResult = GameResult.Won;

            var coinFlip = new CoinFlip();
            var actualGameResult = coinFlip.GetGameResult(SideOfCoin.Heads, SideOfCoin.Heads);

            Assert.AreEqual(expectedGameResult, actualGameResult);
        }

        [TestMethod]
        public void ReturnsCoinFlipLoss()
        {
            var expectedGameResult = GameResult.Lost;

            var coinFlip = new CoinFlip();
            var actualGameResult = coinFlip.GetGameResult(SideOfCoin.Heads, SideOfCoin.Tails);

            Assert.AreEqual(expectedGameResult, actualGameResult);
        }

        [TestMethod]
        public void ReturnsRockPaperScissorsTie()
        {
            var expectedGameResult = GameResult.Tied;

            var rockPaperScissors = new RockPaperScissors();
            var actualGameResult = rockPaperScissors.GetGameResult(Throw.Paper, Throw.Paper);

            Assert.AreEqual(expectedGameResult, actualGameResult);
        }

        [TestMethod]
        public void RockBeatsScissors()
        {
            var expectedGameResult = GameResult.Won;

            var rockPaperScissors = new RockPaperScissors();
            var actualGameResult = rockPaperScissors.GetGameResult(Throw.Rock, Throw.Scissors);

            Assert.AreEqual(expectedGameResult, actualGameResult);
        }

        [TestMethod]
        public void ScissorsBeatsPaper()
        {
            var expectedGameResult = GameResult.Won;

            var rockPaperScissors = new RockPaperScissors();
            var actualGameResult = rockPaperScissors.GetGameResult(Throw.Scissors, Throw.Paper);

            Assert.AreEqual(expectedGameResult, actualGameResult);
        }

        [TestMethod]
        public void PaperBeatsRock()
        {
            var expectedGameResult = GameResult.Won;

            var rockPaperScissors = new RockPaperScissors();
            var actualGameResult = rockPaperScissors.GetGameResult(Throw.Paper, Throw.Rock);

            Assert.AreEqual(expectedGameResult, actualGameResult);
        }

        [TestMethod]
        public void IdentifiesGuessIsTooHigh()
        {
            var expectedGuess = Guess.TooHigh;

            var pickANumber = new PickANumber();
            var actualGuess = pickANumber.CompareNumbers(9, 5);

            Assert.AreEqual(expectedGuess, actualGuess);
        }

        [TestMethod]
        public void IdentifiesGuessIsTooLow()
        {
            var expectedGuess = Guess.TooLow;

            var pickANumber = new PickANumber();
            var actualGuess = pickANumber.CompareNumbers(5, 9);

            Assert.AreEqual(expectedGuess, actualGuess);
        }

        [TestMethod]
        public void IdentifiesGuessIsCorrectNumber()
        {
            var expectedGuess = Guess.Correct;

            var pickANumber = new PickANumber();
            var actualGuess = pickANumber.CompareNumbers(5, 5);

            Assert.AreEqual(expectedGuess, actualGuess);
        }

        [TestMethod]
        public void MondayIsADayApartFromTuesday()
        {
            var expectedDayGuess = DayGuess.WithinADay;

            var pickADay = new PickADay();
            var actualDayGuess = pickADay.CompareDays(Day.Monday, Day.Tuesday);

            Assert.AreEqual(expectedDayGuess, actualDayGuess);
        }

        [TestMethod]
        public void WednesDayIsMoreThanADayApartFromFrieday()
        {
            var expectedDayGuess = DayGuess.WayOff;

            var pickADay = new PickADay();
            var actualDayGuess = pickADay.CompareDays(Day.Wednesday, Day.Friday);

            Assert.AreEqual(expectedDayGuess, actualDayGuess);
        }

        [TestMethod]
        public void IdentifiesGuessIsCorrectDay()
        {
            var expectedDayGuess = DayGuess.Correct;

            var pickADay = new PickADay();
            var actualDayGuess = pickADay.CompareDays(Day.Thursday, Day.Thursday);

            Assert.AreEqual(expectedDayGuess, actualDayGuess);
        }










    }
}
