using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Save_The_Prisoner;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Save_The_Prisoner_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void MIsNotAnInteger()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("M");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FortyThreeIsAnInteger()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("43");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NegativeOneIsNotAtLeastOne()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfAtLeastOne("-1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZeroIsNotAtLeastOne()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfAtLeastOne("0");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneIsAtLeastOne()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfAtLeastOne("1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwoIsAtLeastOne()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfAtLeastOne("2");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZeroIsNotAtLeastTwo()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfAtLeastTwo("0");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneIsNotAtLeastTwo()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfAtLeastTwo("1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwoIsAtLeastTwo()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfAtLeastTwo("2");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ThreeoIsAtLeastTwo()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfAtLeastTwo("3");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrisonerIDOfFiveFourTotalPrisoners()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfIDIsGreaterThanNumPrisoners("5", 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrisonerIDOfFourFourTotalPrisoners()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfIDIsGreaterThanNumPrisoners("4", 4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PrisonerIDOfFourFiveTotalPrisoners()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfIDIsGreaterThanNumPrisoners("4", 5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiveTotalPrisonersStartWithIDNumberOneTwoSweets()
        {
            var expected = 2;

            var utility = new Utility();
            var actual = utility.CalculateIDOfPrisonerToWarn(5, 1, 2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiveTotalPrisonersStartWithIDNumberOneEightSweets()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.CalculateIDOfPrisonerToWarn(5, 1, 8);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiveTotalPrisonersStartWithIDNumberTwoEightSweets()
        {
            var expected = 4;

            var utility = new Utility();
            var actual = utility.CalculateIDOfPrisonerToWarn(5, 2, 8);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwelveTotalPrisonersStartWithIDNumberThreeSixSweets()
        {
            var expected = 8;

            var utility = new Utility();
            var actual = utility.CalculateIDOfPrisonerToWarn(12, 3, 6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwelveTotalPrisonersStartWithIDNumberSevenTenSweets()
        {
            var expected = 4;

            var utility = new Utility();
            var actual = utility.CalculateIDOfPrisonerToWarn(12, 7, 10);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneHundredTotalPrisonersStartWithIDNumberFortyFiveNineHundredNinetyNineSweets()
        {
            var expected = 43;

            var utility = new Utility();
            var actual = utility.CalculateIDOfPrisonerToWarn(100, 45, 999);

            Assert.AreEqual(expected, actual);
        }
    }
}
