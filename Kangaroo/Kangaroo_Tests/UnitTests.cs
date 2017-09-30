using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kangaroo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kangaroo_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ThirtyFourIsAnInt()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("34");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RIsNotAnInt()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("R");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NegativeOneIsNotPositive()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("-1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZeroIsNotPositive()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("0");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneIsPositive()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwoIsPositive()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("2");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FourFeetIsNotFartherThanFiveFeet()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfFartherThanFirst("4", 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiveFeetIsNotFartherThanFiveFeet()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfFartherThanFirst("5", 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiveFeetIsFartherThanFourFeet()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfFartherThanFirst("5", 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FirstKangarooHalfTheStartingDistanceTwiceTheJumpingDistance()
        {
            var expected = 5;

            var utility = new Utility();
            var actual = utility.NumJumpsToReachSameSpot(5, 2, 10, 1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FirstKangarooHalfTheStartingDistanceSameJumpingDistance()
        {
            var expected = -1;

            var utility = new Utility();
            var actual = utility.NumJumpsToReachSameSpot(5, 2, 10, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FirstKangarooLessThanAThirdTheStartingDistanceOneAndAHalfTheJumpingDistance()
        {
            var expected = 7;

            var utility = new Utility();
            var actual = utility.NumJumpsToReachSameSpot(6, 6, 20, 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FirstKangarooLessThanHalfTheStartingDistanceOneAndAHalfTheJumpingDistance()
        {
            var expected = -1;

            var utility = new Utility();
            var actual = utility.NumJumpsToReachSameSpot(9, 6, 20, 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StartsAt5FeetJumps2Feet5Times()
        {
            var expected = 15;

            var utility = new Utility();
            var actual = utility.CalculateSameSpotDistance(5, 2, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StartsAt6FeetJumpps6Feet7Times()
        {
            var expected = 48;

            var utility = new Utility();
            var actual = utility.CalculateSameSpotDistance(6, 6, 7);

            Assert.AreEqual(expected, actual);
        }
    }
}
