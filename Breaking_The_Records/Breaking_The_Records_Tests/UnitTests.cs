using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Breaking_The_Records;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Breaking_The_Records_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ThirtyFiveIsAnInt()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("35");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SIsNotAnInt()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("S");

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
        public void NegativeTwoIsNegative()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-2");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NegativeOneIsNegative()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZeroIsNotNegative()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("0");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneIsNotNegative()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PointsScoredIncreasedEachGame()
        {
            var expected = new int[] { 0, 4 };

            var utility = new Utility();
            var actual = utility.CalculateTheRecords(new int[] { 10, 15, 20, 25, 30 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PointsScoredDecreasedEachGame()
        {
            var expected = new int[] { 4, 0 };

            var utility = new Utility();
            var actual = utility.CalculateTheRecords(new int[] { 30, 25, 20, 15, 10 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PointsScoredWereTheSameEachGame()
        {
            var expected = new int[] { 0, 0 };

            var utility = new Utility();
            var actual = utility.CalculateTheRecords(new int[] { 10, 10, 10, 10, 10 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BrokeRecordsForLeastPointsAndMostPointsOnceEach()
        {
            var expected = new int[] { 1, 1 };

            var utility = new Utility();
            var actual = utility.CalculateTheRecords(new int[] { 10, 15, 5, 14, 15 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BrokeRecordForLeastPointsOnceAndMostPointsThreeTimes()
        {
            var expected = new int[] { 1, 3 };

            var utility = new Utility();
            var actual = utility.CalculateTheRecords(new int[] { 10, 15, 25, 30, 0, 3, 25 });

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
