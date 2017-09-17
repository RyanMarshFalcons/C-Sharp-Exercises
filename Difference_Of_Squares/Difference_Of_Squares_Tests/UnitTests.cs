using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Difference_Of_Squares;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Difference_Of_Squares_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void RIsNotAnInteger()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("R");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FifteenIsAnInteger()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("15");

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
        public void TwoHundredOneIsNotLessThanTwoHundred()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfLessThanTwoHundred("201");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwoHundredIsNotLessThanTwoHundred()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfLessThanTwoHundred("200");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneHundredNinetyNineIsLessThanTwoHundred()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfLessThanTwoHundred("199");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TheSquareOfTheSumOfTheFirst5NumbersIs225()
        {
            var expected = 225;

            var utility = new Utility();
            var actual = utility.CalculateSquareOfTheSum(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TheSquareOfTheSumOfTheFirst20NumbersIs44100()
        {
            var expected = 44100;

            var utility = new Utility();
            var actual = utility.CalculateSquareOfTheSum(20);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TheSquareOfTheSumOfTheFirst20NumbersIs396010000()
        {
            var expected = 396010000;

            var utility = new Utility();
            var actual = utility.CalculateSquareOfTheSum(199);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TheSumOfTheSquaresOfTheFirst5NumbersIs55()
        {
            var expected = 55;

            var utility = new Utility();
            var actual = utility.CalculateSumOfTheSquares(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TheSumOfTheSquaresOfTheFirst20NumbersIs2870()
        {
            var expected = 2870;

            var utility = new Utility();
            var actual = utility.CalculateSumOfTheSquares(20);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TheSumOfTheSquaresOfTheFirst199NumbersIs2646700()
        {
            var expected = 2646700;

            var utility = new Utility();
            var actual = utility.CalculateSumOfTheSquares(199);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TheDifferenceBetween225And55Is170()
        {
            var expected = 170;

            var utility = new Utility();
            var actual = utility.CalculateDifference(225, 55);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TheDifferenceBetween44100And2870Is41230()
        {
            var expected = 41230;

            var utility = new Utility();
            var actual = utility.CalculateDifference(44100, 2870);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TheDifferenceBetween396010000And2646700Is393363300()
        {
            var expected = 393363300;

            var utility = new Utility();
            var actual = utility.CalculateDifference(396010000, 2646700);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DoesNotAddUnnecesaryCommasToTinyNumber()
        {
            var expected = "383";

            var utility = new Utility();
            var actual = utility.AddCommasToNumber(383);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddsOneCommaToSmallNumber()
        {
            var expected = "8,425";

            var utility = new Utility();
            var actual = utility.AddCommasToNumber(8425);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddsTwoCommasToMediumNumber()
        {
            var expected = "4,547,693";

            var utility = new Utility();
            var actual = utility.AddCommasToNumber(4547693);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddsThreeCommasToHugeNumber()
        {
            var expected = "1,814,593,784";

            var utility = new Utility();
            var actual = utility.AddCommasToNumber(1814593784);

            Assert.AreEqual(expected, actual);
        }
    }
}
