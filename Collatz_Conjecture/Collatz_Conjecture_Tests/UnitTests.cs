using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collatz_Conjecture;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Collatz_Conjecture_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void SIsNotAnInteger()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("S");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SeventeenIsAnInteger()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("17");

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
        public void ZeroStepsForOne()
        {
            var expected = 0;

            var utility = new Utility();
            var actual = utility.GetNumberOfSteps(1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FourStepsForSixteen()
        {
            var expected = 4;

            var utility = new Utility();
            var actual = utility.GetNumberOfSteps(16);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NineStepsForTwelve()
        {
            var expected = 9;

            var utility = new Utility();
            var actual = utility.GetNumberOfSteps(12);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OneHundredFiftyTwoStepsForOneMillion()
        {
            var expected = 152;

            var utility = new Utility();
            var actual = utility.GetNumberOfSteps(1000000);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FourIsEven()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsEven(4);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiveIsNotEven()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsEven(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SixDividedByTwoIsThree()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.DivideByTwo(6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FourteenDividedByTwoIsSeven()
        {
            var expected = 7;

            var utility = new Utility();
            var actual = utility.DivideByTwo(14);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NineMultipliedByThreePlusOneIsTwentyEight()
        {
            var expected = 28;

            var utility = new Utility();
            var actual = utility.MultiplyByThreeAddOne(9);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FifteenMultipliedByThreePlusOneIsFortySix()
        {
            var expected = 46;

            var utility = new Utility();
            var actual = utility.MultiplyByThreeAddOne(15);

            Assert.AreEqual(expected, actual);
        }
    }
}
