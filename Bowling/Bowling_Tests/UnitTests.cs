using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bowling;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bowling_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TenPinsOnFirstRollIsAStrikeAndNotASpare()
        {
            var frame = new Frame() { FirstRoll = 10 };

            var expected1 = false;
            var actual1 = frame.WasSpare();

            var expected2 = true;
            var actual2 = frame.WasStrike();

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void FourPinsOnFirstRollIsNotAStrikeOrASpare()
        {
            var frame = new Frame() { FirstRoll = 4 };

            var expected1 = false;
            var actual1 = frame.WasSpare();

            var expected2 = false;
            var actual2 = frame.WasStrike();

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void TenPinsOnSecondRollIsASpareAndNotAStrike()
        {
            var frame = new Frame() { FirstRoll = 0, SecondRoll = 10 };

            var expected1 = true;
            var actual1 = frame.WasSpare();

            var expected2 = false;
            var actual2 = frame.WasStrike();

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void TenPinsInTwoRollsIsASpareAndNotAStrike()
        {
            var frame = new Frame() { FirstRoll = 8, SecondRoll = 2 };

            var expected1 = true;
            var actual1 = frame.WasSpare();

            var expected2 = false;
            var actual2 = frame.WasStrike();

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void NinePinsInTwoRollsIsNotAStrikeOrASpare()
        {
            var frame = new Frame() { FirstRoll = 8, SecondRoll = 1 };

            var expected1 = false;
            var actual1 = frame.WasSpare();

            var expected2 = false;
            var actual2 = frame.WasStrike();

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void TwentyTwoIsAnInteger()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("22");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FIsNotAnInteger()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NegativeOneIsOutOfRange()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfOutOfRange("-1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZeroIsNotOutOfRange()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfOutOfRange("0");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ElevenIsOutOfRange()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfOutOfRange("11");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TenIsNotOutOfRange()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfOutOfRange("10");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ThereAreNotAtLeastFourPinsLeftIfIAlreadyKnockedSevenOver()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfEnoughPinsLeft("4", 7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ThereAreAtLeastFourPinsLeftIfIAlreadyKnockedSixOver()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfEnoughPinsLeft("4", 6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ThereAreNotAtLeastFivePinsLeftIfIAlreadyKnockedEightOver()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfEnoughPinsLeft("5", 8);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ThereAreAtLeastFivePinsLeftIfIAlreadyKnockedThreeOver()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfEnoughPinsLeft("5", 3);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddsTheNextRollAfterASpare()
        {
            var expected = 27;

            var utility = new Utility();
            var actual = utility.CalculateScore(new List<Frame>() { new Frame { FirstRoll = 6, SecondRoll = 4 }, new Frame { FirstRoll = 8, SecondRoll = 1 },  new Frame { FirstRoll = 0, SecondRoll = 0 }, new Frame { FirstRoll = 0, SecondRoll = 0 }, new Frame { FirstRoll = 0, SecondRoll = 0 }, new Frame { FirstRoll = 0, SecondRoll = 0 }, new Frame { FirstRoll = 0, SecondRoll = 0 }, new Frame { FirstRoll = 0, SecondRoll = 0 }, new Frame { FirstRoll = 0, SecondRoll = 0 }, new Frame { FirstRoll = 0, SecondRoll = 0 } } );

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddsTheNextTwoRollsAfterAStrike()
        {
            var expected = 28;

            var utility = new Utility();
            var actual = utility.CalculateScore(new List<Frame>() { new Frame { FirstRoll = 10 }, new Frame { FirstRoll = 8, SecondRoll = 1 }, new Frame { FirstRoll = 0, SecondRoll = 0 }, new Frame { FirstRoll = 0, SecondRoll = 0 }, new Frame { FirstRoll = 0, SecondRoll = 0 }, new Frame { FirstRoll = 0, SecondRoll = 0 }, new Frame { FirstRoll = 0, SecondRoll = 0 }, new Frame { FirstRoll = 0, SecondRoll = 0 }, new Frame { FirstRoll = 0, SecondRoll = 0 }, new Frame { FirstRoll = 0, SecondRoll = 0 } });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void APerfectGameIs300()
        {
            var expected = 300;

            var utility = new Utility();
            var actual = utility.CalculateScore(new List<Frame>() { new Frame { FirstRoll = 10 }, new Frame { FirstRoll = 10 }, new Frame { FirstRoll = 10 }, new Frame { FirstRoll = 10 }, new Frame { FirstRoll = 10 }, new Frame { FirstRoll = 10 }, new Frame { FirstRoll = 10 }, new Frame { FirstRoll = 10 }, new Frame { FirstRoll = 10 }, new Frame { FirstRoll = 10 }, new Frame { FirstRoll = 10, SecondRoll = 10 } });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AGameWithTwoStrikesAndTwoSpares()
        {
            var expected = 116;

            var utility = new Utility();
            var actual = utility.CalculateScore(new List<Frame>() { new Frame { FirstRoll = 6, SecondRoll = 4 }, new Frame { FirstRoll = 8, SecondRoll = 1 }, new Frame { FirstRoll = 10 }, new Frame { FirstRoll = 0, SecondRoll = 6 }, new Frame { FirstRoll = 8, SecondRoll = 2 }, new Frame { FirstRoll = 3, SecondRoll = 6 }, new Frame { FirstRoll = 10 }, new Frame { FirstRoll = 4, SecondRoll = 5 }, new Frame { FirstRoll = 5, SecondRoll = 3 }, new Frame { FirstRoll = 8, SecondRoll = 1 } });

            Assert.AreEqual(expected, actual);
        }
    }
}
