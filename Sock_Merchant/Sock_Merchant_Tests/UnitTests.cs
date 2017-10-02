using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sock_Merchant;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sock_Merchant_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TotalNumberOfSocksStartsAtZero()
        {
            var expected = 0;

            var sockTracker = new SockTracker() { MatchingPairs = new List<Color>(), UnmatchedSocks = new List<Color>() };

            var actual = sockTracker.TotalNumberOfSocks();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AMatchingPairCountsAsTwoSocks()
        {
            var expected = 4;

            var sockTracker = new SockTracker() { MatchingPairs = new List<Color>() { Color.Black, Color.Blue }, UnmatchedSocks = new List<Color>() };

            var actual = sockTracker.TotalNumberOfSocks();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AnUnmatchedSockCountsAsOneSock()
        {
            var expected = 2;

            var sockTracker = new SockTracker() { MatchingPairs = new List<Color>(), UnmatchedSocks = new List<Color>() { Color.Black, Color.Blue } };

            var actual = sockTracker.TotalNumberOfSocks();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MatchingPairsAndUnmatchedSocksAreBothCounted()
        {
            var expected = 5;

            var sockTracker = new SockTracker() { MatchingPairs = new List<Color>() { Color.Red }, UnmatchedSocks = new List<Color>() { Color.Green, Color.Blue, Color.Brown } };

            var actual = sockTracker.TotalNumberOfSocks();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AIsAValidSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BIsAValidSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CIsAValidSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DIsAValidSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EIsAValidSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FIsAValidSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GIsAValidSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("G");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HIsAValidSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("H");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IIsAValidSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("I");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void JIsAValidSelection()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("J");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void KIsNotAValidSelection()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("K");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ARepresentsTheColorGreen()
        {
            var expected = Color.Green;

            var utility = new Utility();
            var actual = utility.ConvertLetterToColor("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BRepresentsTheColorRed()
        {
            var expected = Color.Red;

            var utility = new Utility();
            var actual = utility.ConvertLetterToColor("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CRepresentsTheColorBlue()
        {
            var expected = Color.Blue;

            var utility = new Utility();
            var actual = utility.ConvertLetterToColor("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DRepresentsTheColorOrange()
        {
            var expected = Color.Orange;

            var utility = new Utility();
            var actual = utility.ConvertLetterToColor("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ERepresentsTheColorWhite()
        {
            var expected = Color.White;

            var utility = new Utility();
            var actual = utility.ConvertLetterToColor("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FRepresentsTheColorBlack()
        {
            var expected = Color.Black;

            var utility = new Utility();
            var actual = utility.ConvertLetterToColor("F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GRepresentsTheColorPurple()
        {
            var expected = Color.Purple;

            var utility = new Utility();
            var actual = utility.ConvertLetterToColor("G");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HRepresentsTheColorPink()
        {
            var expected = Color.Pink;

            var utility = new Utility();
            var actual = utility.ConvertLetterToColor("H");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IRepresentsTheColorYellow()
        {
            var expected = Color.Yellow;

            var utility = new Utility();
            var actual = utility.ConvertLetterToColor("I");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void JRepresentsTheColorBrown()
        {
            var expected = Color.Brown;

            var utility = new Utility();
            var actual = utility.ConvertLetterToColor("J");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void yIsEitheryOrn()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("y");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void nIsEitheryOrn()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("n");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void wIsNotEitheryOrn()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("w");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZeroMatchingPairsOneLooseSock()
        {
            var expected = new SockTracker() { MatchingPairs = new List<Color>(), UnmatchedSocks = new List<Color>() { Color.Yellow } };

            var utility = new Utility();
            var actual = utility.GetMatchingPairs(new List<Color>() { Color.Yellow });

            CollectionAssert.AreEqual(expected.MatchingPairs, actual.MatchingPairs);
            CollectionAssert.AreEqual(expected.UnmatchedSocks, actual.UnmatchedSocks);
        }

        [TestMethod]
        public void OneMatchingPairZeroLooseSocks()
        {
            var expected = new SockTracker() { MatchingPairs = new List<Color>() { Color.Pink }, UnmatchedSocks = new List<Color>() };

            var utility = new Utility();
            var actual = utility.GetMatchingPairs(new List<Color>() { Color.Pink, Color.Pink });

            CollectionAssert.AreEqual(expected.MatchingPairs, actual.MatchingPairs);
            CollectionAssert.AreEqual(expected.UnmatchedSocks, actual.UnmatchedSocks);
        }

        [TestMethod]
        public void OneMatchingPairTwoLooseSocks()
        {
            var expected = new SockTracker() { MatchingPairs = new List<Color>() { Color.Red }, UnmatchedSocks = new List<Color>() { Color.Blue, Color.Black } };

            var utility = new Utility();
            var actual = utility.GetMatchingPairs(new List<Color>() { Color.Red, Color.Black, Color.Blue, Color.Red });

            CollectionAssert.AreEqual(expected.MatchingPairs, actual.MatchingPairs);
            CollectionAssert.AreEqual(expected.UnmatchedSocks, actual.UnmatchedSocks);
        }

        [TestMethod]
        public void ThreeMatchingPairsFiveLooseSocks()
        {
            var expected = new SockTracker() { MatchingPairs = new List<Color>() { Color.Red, Color.Blue, Color.Orange }, UnmatchedSocks = new List<Color>() { Color.Green, Color.Orange, Color.Black, Color.Pink, Color.Brown } };

            var utility = new Utility();
            var actual = utility.GetMatchingPairs(new List<Color>() { Color.Green, Color.Orange, Color.Pink, Color.Brown, Color.Orange, Color.Blue, Color.Red, Color.Orange, Color.Black, Color.Blue, Color.Red });

            CollectionAssert.AreEqual(expected.MatchingPairs, actual.MatchingPairs);
            CollectionAssert.AreEqual(expected.UnmatchedSocks, actual.UnmatchedSocks);
        }
    }
}
