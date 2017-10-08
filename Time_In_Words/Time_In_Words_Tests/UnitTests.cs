using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_In_Words;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Time_In_Words_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void InvalidTimeFormat()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidFormat("AB:CD");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidTimeFormat()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidFormat("12:34");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InvalidTime()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidTime("56:11");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidTime()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidTime("11:56");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OnTheHourVariant()
        {
            var expected = SpecialTime.On_The_Hour;

            var utility = new Utility();
            var actual = utility.DetermineTimeVariant(00);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneMinutePastVariant()
        {
            var expected = SpecialTime.One_Minute_Past;

            var utility = new Utility();
            var actual = utility.DetermineTimeVariant(01);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QuarterPastVariant()
        {
            var expected = SpecialTime.Quarter_Past;

            var utility = new Utility();
            var actual = utility.DetermineTimeVariant(15);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HalfPastVariant()
        {
            var expected = SpecialTime.Half_Past;

            var utility = new Utility();
            var actual = utility.DetermineTimeVariant(30);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QuarterToVariant()
        {
            var expected = SpecialTime.Quarter_To;

            var utility = new Utility();
            var actual = utility.DetermineTimeVariant(45);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneMinuteToVariant()
        {
            var expected = SpecialTime.One_Minute_To;

            var utility = new Utility();
            var actual = utility.DetermineTimeVariant(59);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RegularVariant()
        {
            var expected = SpecialTime.Regular;

            var utility = new Utility();
            var actual = utility.DetermineTimeVariant(13);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiveOClock()
        {
            var expected = "five o'clock";

            var utility = new Utility();
            var actual = utility.CalculateTimeInWords(00, 5, SpecialTime.On_The_Hour);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneMinutePastSix()
        {
            var expected = "one minute past six";

            var utility = new Utility();
            var actual = utility.CalculateTimeInWords(01, 6, SpecialTime.One_Minute_Past);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QuarterPastSeven()
        {
            var expected = "quarter past seven";

            var utility = new Utility();
            var actual = utility.CalculateTimeInWords(15, 7, SpecialTime.Quarter_Past);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HalfPastEight()
        {
            var expected = "half past eight";

            var utility = new Utility();
            var actual = utility.CalculateTimeInWords(30, 8, SpecialTime.Half_Past);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void QuarterToOne()
        {
            var expected = "quarter to one";

            var utility = new Utility();
            var actual = utility.CalculateTimeInWords(45, 12, SpecialTime.Quarter_To);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneMinuteToTen()
        {
            var expected = "one minute to ten";

            var utility = new Utility();
            var actual = utility.CalculateTimeInWords(59, 9, SpecialTime.One_Minute_To);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwentyEightMinutesPastThree()
        {
            var expected = "twenty-eight minutes past three";

            var utility = new Utility();
            var actual = utility.CalculateTimeInWords(28, 3, SpecialTime.Regular);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwentyEightMinutesToFour()
        {
            var expected = "twenty-eight minutes to four";

            var utility = new Utility();
            var actual = utility.CalculateTimeInWords(32, 3, SpecialTime.Regular);

            Assert.AreEqual(expected, actual);
        }
    }
}
