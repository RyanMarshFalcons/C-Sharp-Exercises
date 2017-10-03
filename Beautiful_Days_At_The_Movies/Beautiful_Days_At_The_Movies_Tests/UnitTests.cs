using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Beautiful_Days_At_The_Movies;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Beautiful_Days_At_The_Movies_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void xIsNotAnInt()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("x");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ThirtySevenIsAnInt()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("37");

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
        public void FourIsNotGreaterThanFive()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfLastIsGreaterThanFirst(5, 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiveIsNotGreaterThanFive()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfLastIsGreaterThanFirst(5, 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SixIsGreaterThanFive()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfLastIsGreaterThanFirst(5, 6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SingleDigitDaysAreAlwaysBeautiful()
        {
            var expected = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var utility = new Utility();
            var actual = utility.CalculateBeautifulDays(1, 9, 5);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EighteenAndZeroAreBothEvenlyDivisibleBySix()
        {
            var expected = new List<int>() { 20, 22 };

            var utility = new Utility();
            var actual = utility.CalculateBeautifulDays(20, 23, 6);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TheAbsoluteDifferenceBetweenSeventyFiveAndFiftySevenIsEighteen()
        {
            var expected = 18;

            var utility = new Utility();
            var actual = utility.GetAbsoluteDifference(75);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TheAbsoluteDifferenceBetweenNinetyOneAndNineteenIsSeventyTwo()
        {
            var expected = 72;

            var utility = new Utility();
            var actual = utility.GetAbsoluteDifference(91);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TheReverseOfThirtyFiveIsFiftyThree()
        {
            var expected = 53;

            var utility = new Utility();
            var actual = utility.GetReverseOfNum(35);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TheReverseOfFortyFourIsFourtyFour()
        {
            var expected = 44;

            var utility = new Utility();
            var actual = utility.GetReverseOfNum(44);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TheReverseOfOneThousandSeventyThreeIsThreeThousandSevenHundredOne()
        {
            var expected = 3701;

            var utility = new Utility();
            var actual = utility.GetReverseOfNum(1073);

            Assert.AreEqual(expected, actual);
        }
    }
}
