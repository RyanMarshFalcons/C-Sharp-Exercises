using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Luhn_Formula;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Luhn_Formula_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void OneDigitIsTooShort()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsTooShort("7");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneSpaceAndOneDigitIsTooShort()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsTooShort(" 7");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwoDigitsIsLongEnough()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsTooShort("77");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemovesSpacesFromString()
        {
            var expected = "494625126189";

            var utility = new Utility();
            var actual = utility.RemoveSpaces(" 4946 2512 6189 ");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CatchesThatFIsALetterOrSymbol()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.DoesContainLettersOrSymbols("59F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CatchesThatDashIsALetterOrSymbol()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.DoesContainLettersOrSymbols("59-");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AcceptsSpaceAsValidCharacter()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.DoesContainLettersOrSymbols("59 ");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectlyDoublesEverySecondNumberFromRightTwoDigits()
        {
            var expected = "67";

            var utility = new Utility();
            var actual = utility.DoubleEverySecondDigitFromRight("37", true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectlyDoublesEverySecondNumberFromRightThreeDigits()
        {
            var expected = "567";

            var utility = new Utility();
            var actual = utility.DoubleEverySecondDigitFromRight("537", false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectlyDoublesEverySecondNumberFromRightFourDigits()
        {
            var expected = "1358";

            var utility = new Utility();
            var actual = utility.DoubleEverySecondDigitFromRight("5378", true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectlyDoublesEverySecondNumberFromRightFiveDigits()
        {
            var expected = "56774";

            var utility = new Utility();
            var actual = utility.DoubleEverySecondDigitFromRight("53784", false);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectlyDoublesEverySecondNumberFromRightSixteenDigits()
        {
            var expected = "8569247803833437";

            var utility = new Utility();
            var actual = utility.DoubleEverySecondDigitFromRight("4539148803436467", true);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatesSumOfDigitsOfFiveDigitNumber()
        {
            var expected = 24;

            var utility = new Utility();
            var actual = utility.GetSumOfDigits("13587");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatesSumOfDigitsOfEightDigitNumber()
        {
            var expected = 45;

            var utility = new Utility();
            var actual = utility.GetSumOfDigits("13897458");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatesSumOfDigitsOfSixteenDigitNumber()
        {
            var expected = 75;

            var utility = new Utility();
            var actual = utility.GetSumOfDigits("4539148803436467");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TenIsAValidNumber()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsValidNumber(10);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneHundredTwentyIsAValidNumber()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsValidNumber(120);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneThousandTwoHundredThirtyIsAValidNumber()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsValidNumber(1230);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwelveIsAnInvalidNumber()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsValidNumber(12);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneHundredTwentyThreeIsAnInvalidNumber()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsValidNumber(123);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneThousandTwoHundredThirtyFourIsAnInvalidNumber()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsValidNumber(1234);

            Assert.AreEqual(expected, actual);
        }
    }
}
