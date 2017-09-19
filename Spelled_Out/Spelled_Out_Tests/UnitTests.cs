using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spelled_Out;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Spelled_Out_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void NIsNotAnInt()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("N");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwelveIsAnInt()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("12");

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
        public void OneBillionIsTooHigh()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooHigh("1000000000");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NineHundredMillionNineHundredNinetyNineThousandNineHundredNinetyNineIsNotTooHigh()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooHigh("999999999");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddsEightLeadingZeroesToOne()
        {
            var expected = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 1 };

            var utility = new Utility();
            var actual = utility.ConvertNumToIntArray(1);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddsFiveLeadingZeroesToFourThousandSevenHundredSixtyThreee()
        {
            var expected = new int[] { 0, 0, 0, 0, 0, 4, 7, 6, 3 };

            var utility = new Utility();
            var actual = utility.ConvertNumToIntArray(4763);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DoesNotAddUnnecessaryLeadingZeroes()
        {
            var expected = new int[] { 7, 5, 3, 2, 1, 4, 7, 7, 5 };

            var utility = new Utility();
            var actual = utility.ConvertNumToIntArray(753214775);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectlyTranslates7ToSeven()
        {
            var expected = "seven ";

            var utility = new Utility();
            var actual = utility.ConvertThreeDigits(new int[] { 0, 0, 7 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectlyTranslates13ToThirteen()
        {
            var expected = "thirteen ";

            var utility = new Utility();
            var actual = utility.ConvertThreeDigits(new int[] { 0, 1, 3 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CorrectlyTranslates59ToFiftyNine()
        {
            var expected = "fifty nine ";

            var utility = new Utility();
            var actual = utility.ConvertThreeDigits(new int[] { 0, 5, 9 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void CorrectlyTranslates832ToEightHundredThirtyTwo()
        {
            var expected = "eight hundred thirty two ";

            var utility = new Utility();
            var actual = utility.ConvertThreeDigits(new int[] { 8, 3, 2 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SpellsOutOneDigitNumber()
        {
            var expected = "four";

            var utility = new Utility();
            var actual = utility.SpellOutNumber(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 4 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SpellsOutTwoDigitNumber()
        {
            var expected = "sixteen";

            var utility = new Utility();
            var actual = utility.SpellOutNumber(new int[] { 0, 0, 0, 0, 0, 0, 0, 1, 6 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SpellsOutThreeDigitNumber()
        {
            var expected = "three hundred forty two";

            var utility = new Utility();
            var actual = utility.SpellOutNumber(new int[] { 0, 0, 0, 0, 0, 0, 3, 4, 2 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SpellsOutFourDigitNumber()
        {
            var expected = "eight thousand nine hundred sixty one";

            var utility = new Utility();
            var actual = utility.SpellOutNumber(new int[] { 0, 0, 0, 0, 0, 8, 9, 6, 1 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SpellsOutFiveDigitNumber()
        {
            var expected = "seventy thousand eight hundred nineteen";

            var utility = new Utility();
            var actual = utility.SpellOutNumber(new int[] { 0, 0, 0, 0, 7, 0, 8, 1, 9 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SpellsOutSixDigitNumber()
        {
            var expected = "eight hundred three thousand four hundred five";

            var utility = new Utility();
            var actual = utility.SpellOutNumber(new int[] { 0, 0, 0, 8, 0, 3, 4, 0, 5 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SpellsOutSevenDigitNumber()
        {
            var expected = "three million four hundred fifty thousand nine hundred fourteen";

            var utility = new Utility();
            var actual = utility.SpellOutNumber(new int[] { 0, 0, 3, 4, 5, 0, 9, 1, 4 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SpellsOutEightDigitNumber()
        {
            var expected = "sixty five million three hundred seventy one thousand five hundred thirty three";

            var utility = new Utility();
            var actual = utility.SpellOutNumber(new int[] { 0, 6, 5, 3, 7, 1, 5, 3, 3 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SpellsOutNineDigitNumber()
        {
            var expected = "one hundred twenty three million four hundred fifty six thousand seven hundred eighty nine";

            var utility = new Utility();
            var actual = utility.SpellOutNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            Assert.AreEqual(expected, actual);
        }
    }
}
