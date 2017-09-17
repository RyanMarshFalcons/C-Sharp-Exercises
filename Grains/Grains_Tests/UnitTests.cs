using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grains;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grains_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void WIsNotAnInteger()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("W");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SixteenIsAnInteger()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("16");

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
        public void SixtyThreeIsNotMoreThanSixtyFour()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfMoreThan64("63");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SixtyFourIsNotMoreThanSixtyFour()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfMoreThan64("64");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SixtyFiveIsMoreThanSixtyFour()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfMoreThan64("65");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatesForOneSquare()
        {
            var expected = 1UL;

            var utility = new Utility();
            var actual = utility.CalculateGrains(1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatesForTwoSquares()
        {
            var expected = 3UL;

            var utility = new Utility();
            var actual = utility.CalculateGrains(2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatesForSevenSquares()
        {
            var expected = 127UL;

            var utility = new Utility();
            var actual = utility.CalculateGrains(7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatesForThirtyFiveSquares()
        {
            var expected = 34359738367UL;

            var utility = new Utility();
            var actual = utility.CalculateGrains(35);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatesForSixtyFourSquares()
        {
            var expected = 18446744073709551615UL;

            var utility = new Utility();
            var actual = utility.CalculateGrains(64);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DoesNotAddUnnecesaryCommasToTinyNumber()
        {
            var expected = "264";

            var utility = new Utility();
            var actual = utility.AddCommasToNumber(264UL);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddsOneCommaToSmallNumber()
        {
            var expected = "8,127";

            var utility = new Utility();
            var actual = utility.AddCommasToNumber(8127UL);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddsTwoCommasToMediumNumber()
        {
            var expected = "3,453,178";

            var utility = new Utility();
            var actual = utility.AddCommasToNumber(3453178UL);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddsSixCommasToHugeNumber()
        {
            var expected = "18,446,744,073,709,551,615";

            var utility = new Utility();
            var actual = utility.AddCommasToNumber(18446744073709551615UL);

            Assert.AreEqual(expected, actual);
        }
    }
}
