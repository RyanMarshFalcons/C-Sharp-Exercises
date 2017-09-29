using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Between_Two_Sets;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Between_Two_Sets_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ThirtyThreeIsAnInt()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("33");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QIsNotAnInt()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("Q");

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
        public void EightSixteenAndThirtyTwoAreBetweenBothSets()
        {
            var expected = new List<int>() { 8, 16, 32 };

            var utility = new Utility();
            var actual = utility.CalculateBetween(new int[] { 2, 4, 8 }, new int[] { 32, 64, 96 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SixTwelveTwentyFourAndFortyEightAreBetweenBothSets()
        {
            var expected = new List<int>() { 6, 12, 24, 48 };

            var utility = new Utility();
            var actual = utility.CalculateBetween(new int[] { 1, 2, 3 }, new int[] { 48, 96, 144 } );

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NoNumbersBetweenBothSets()
        {
            var expected = new List<int>();

            var utility = new Utility();
            var actual = utility.CalculateBetween(new int[] { 3, 5, 7 }, new int[] { 9, 15, 21 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AlsoNoNumbersBetweenBothSets()
        {
            var expected = new List<int>();

            var utility = new Utility();
            var actual = utility.CalculateBetween(new int[] { 48, 96, 144 }, new int[] { 1, 2, 3 });

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
