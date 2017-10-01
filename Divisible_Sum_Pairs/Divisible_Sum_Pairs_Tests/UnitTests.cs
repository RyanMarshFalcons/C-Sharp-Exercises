using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Divisible_Sum_Pairs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Divisible_Sum_Pairs_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ThirtySevenIsAnInt()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("37");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TIsNotAnInt()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("T");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZeroIsNotGreaterThanOne()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfGreaterThanOne("0");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneIsNotGreaterThanOne()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfGreaterThanOne("1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwoIsGreaterThanOne()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfGreaterThanOne("2");

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
        public void ReturnsTrueFory()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("y");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForn()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("n");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForp()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("p");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NoDivisibleSumPairs()
        {
            var expected = new List<Tuple<int, int>>();

            var utility = new Utility();
            var actual = utility.CalculateDivisibleSumPairs(10, new List<int>() { 1, 2, 3, 4, 5 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ThreeDivisibleSumPairs()
        {
            var expected = new List<Tuple<int, int>>() { new Tuple<int, int>(3, 7), new Tuple<int, int>(4, 6), new Tuple<int, int>(5, 5) };

            var utility = new Utility();
            var actual = utility.CalculateDivisibleSumPairs(10, new List<int>() { 1, 2, 3, 4, 5, 5, 6, 7 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FourDivisibleSumPairsWithSameFirstNum()
        {
            var expected = new List<Tuple<int, int>>() { new Tuple<int, int>(1, 2), new Tuple<int, int>(1, 5), new Tuple<int, int>(1, 8), new Tuple<int, int>(1, 11) };

            var utility = new Utility();
            var actual = utility.CalculateDivisibleSumPairs(3, new List<int>() { 1, 2, 5, 8, 11 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FourDivisibleSumPairsWithThreeFirstNums()
        {
            var expected = new List<Tuple<int, int>>() { new Tuple<int, int>(2, 4), new Tuple<int, int>(2, 6), new Tuple<int, int>(3, 5), new Tuple<int, int>(4, 6) };

            var utility = new Utility();
            var actual = utility.CalculateDivisibleSumPairs(2, new List<int>() { 2, 3, 4, 5, 6 });

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
