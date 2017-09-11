using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Counting_Sheep;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Counting_Sheep_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForSelectingA()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForSelectingB()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForSelectingC()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForSelectingD()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForSelectingE()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForSelectingF()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForSelectingG()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("G");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForSelectingH()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("H");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForSelectingI()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("I");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForSelectingJ()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("J");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForSelectingK()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfValidSelection("K");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsHalfSecondDelayForA()
        {
            var expected = Delay.Half_Second;

            var utility = new Utility();
            var actual = utility.ConvertLetterToDelay("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsOneSecondDelayForB()
        {
            var expected = Delay.One_Second;

            var utility = new Utility();
            var actual = utility.ConvertLetterToDelay("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsOneAndAHalfSecondDelayForC()
        {
            var expected = Delay.One_And_A_Half_Seconds;

            var utility = new Utility();
            var actual = utility.ConvertLetterToDelay("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTwoSecondDelayForD()
        {
            var expected = Delay.Two_Seconds;

            var utility = new Utility();
            var actual = utility.ConvertLetterToDelay("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTwoAndAHalfSecondDelayForE()
        {
            var expected = Delay.Two_And_A_Half_Seconds;

            var utility = new Utility();
            var actual = utility.ConvertLetterToDelay("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsThreeSecondDelayForF()
        {
            var expected = Delay.Three_Seconds;

            var utility = new Utility();
            var actual = utility.ConvertLetterToDelay("F");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsThreeAndAHalfSecondDelayForG()
        {
            var expected = Delay.Three_And_A_Half_Seconds;

            var utility = new Utility();
            var actual = utility.ConvertLetterToDelay("G");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFourSecondDelayForH()
        {
            var expected = Delay.Four_Seconds;

            var utility = new Utility();
            var actual = utility.ConvertLetterToDelay("H");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFourAndAHalfSecondDelayForI()
        {
            var expected = Delay.Four_And_A_Half_Seconds;

            var utility = new Utility();
            var actual = utility.ConvertLetterToDelay("I");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFiveSecondDelayForJ()
        {
            var expected = Delay.Five_Seconds;

            var utility = new Utility();
            var actual = utility.ConvertLetterToDelay("J");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns500MillisecondsForHalfSecondDelay()
        {
            var expected = 500;

            var utility = new Utility();
            var actual = utility.GetMillisecondDelayAsInt(Delay.Half_Second);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns1000MillisecondsForOneSecondDelay()
        {
            var expected = 1000;

            var utility = new Utility();
            var actual = utility.GetMillisecondDelayAsInt(Delay.One_Second);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns1500MillisecondsForOneAndAHalfSecondDelay()
        {
            var expected = 1500;

            var utility = new Utility();
            var actual = utility.GetMillisecondDelayAsInt(Delay.One_And_A_Half_Seconds);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2000MillisecondsForTwoSecondDelay()
        {
            var expected = 2000;

            var utility = new Utility();
            var actual = utility.GetMillisecondDelayAsInt(Delay.Two_Seconds);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2500MillisecondsForTwoAndAHalfSecondDelay()
        {
            var expected = 2500;

            var utility = new Utility();
            var actual = utility.GetMillisecondDelayAsInt(Delay.Two_And_A_Half_Seconds);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3000MillisecondsForThreeSecondDelay()
        {
            var expected = 3000;

            var utility = new Utility();
            var actual = utility.GetMillisecondDelayAsInt(Delay.Three_Seconds);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns3500MillisecondsForThreeAndAHalfSecondDelay()
        {
            var expected = 3500;

            var utility = new Utility();
            var actual = utility.GetMillisecondDelayAsInt(Delay.Three_And_A_Half_Seconds);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns4000MillisecondsForFourSecondDelay()
        {
            var expected = 4000;

            var utility = new Utility();
            var actual = utility.GetMillisecondDelayAsInt(Delay.Four_Seconds);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns4500MillisecondsForFourSecondDelay()
        {
            var expected = 4500;

            var utility = new Utility();
            var actual = utility.GetMillisecondDelayAsInt(Delay.Four_And_A_Half_Seconds);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns5000MillisecondsForFiveSecondDelay()
        {
            var expected = 5000;

            var utility = new Utility();
            var actual = utility.GetMillisecondDelayAsInt(Delay.Five_Seconds);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForEmptyString()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForP()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfTooShort("P");

            Assert.AreEqual(expected, actual);
        }
    }
}
