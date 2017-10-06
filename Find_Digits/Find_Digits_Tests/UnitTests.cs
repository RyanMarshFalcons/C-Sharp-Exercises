using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Find_Digits;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Find_Digits_Tests
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
        public void FortyFiveIsAnInteger()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("45");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EightIsNotAtLeastTen()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfAtLeastTen("8");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NineIsNotAtLeastTen()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfAtLeastTen("9");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TenIsAtLeastTen()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfAtLeastTen("10");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ElevenIsAtLeastTen()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfAtLeastTen("11");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExtractTheDigitsOfTen()
        {
            var expected = new int[] { 1, 0 };

            var utility = new Utility();
            var actual = utility.ExtractDigitsOfNum(10);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExtractTheDigitsOfTwoHundredSeventyFive()
        {
            var expected = new int[] { 2, 7, 5 };

            var utility = new Utility();
            var actual = utility.ExtractDigitsOfNum(275);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ExtractTheDigitsOfThreeThousandOneHundredThirteen()
        {
            var expected = new int[] { 3, 1, 1, 3 };

            var utility = new Utility();
            var actual = utility.ExtractDigitsOfNum(3113);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateDivisibleDigitsOfTen()
        {
            var expected = new int[] { 1 };

            var utility = new Utility();
            var actual = utility.CalculateDivisibleDigits(10);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateDivisibleDigitsOfTwentyThree()
        {
            var expected = new int[0];

            var utility = new Utility();
            var actual = utility.CalculateDivisibleDigits(23);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateDivisibleDigitsOfTwentyFour()
        {
            var expected = new int[] { 2, 4 };

            var utility = new Utility();
            var actual = utility.CalculateDivisibleDigits(24);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateDivisibleDigitsOfOneHundredTwentyThree()
        {
            var expected = new int[] { 1, 3 };

            var utility = new Utility();
            var actual = utility.CalculateDivisibleDigits(123);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateDivisibleDigitsOfOneThousandTwoHundredSixtyFour()
        {
            var expected = new int[] { 1, 2, 4 };

            var utility = new Utility();
            var actual = utility.CalculateDivisibleDigits(1264);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateDivisibleDigitsOfThreeThousandSeven()
        {
            var expected = new int[0];

            var utility = new Utility();
            var actual = utility.CalculateDivisibleDigits(3007);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
