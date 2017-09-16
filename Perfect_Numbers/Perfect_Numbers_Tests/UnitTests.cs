using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Perfect_Numbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Perfect_Numbers_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void UIsNotAnInteger()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("U");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void EighteenIsAnInteger()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("18");

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
        public void CalculatesFactorsOfSix()
        {
            var expected = new List<int>() { 1, 2, 3 };

            var utility = new Utility();
            var actual = utility.CalculateFactors(6);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatesFactorsOfTwelve()
        {
            var expected = new List<int>() { 1, 2, 3, 4, 6 };

            var utility = new Utility();
            var actual = utility.CalculateFactors(12);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatesFactorsOfEighteen()
        {
            var expected = new List<int>() { 1, 2, 3, 6, 9 };

            var utility = new Utility();
            var actual = utility.CalculateFactors(18);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatesFactorsOfOneHundred()
        {
            var expected = new List<int>() { 1, 2, 4, 5, 10, 20, 25, 50 };

            var utility = new Utility();
            var actual = utility.CalculateFactors(100);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatesSumOfFactorsOfSix()
        {
            var expected = 6;

            var utility = new Utility();
            var actual = utility.CalculateSumOfFactors(new List<int>() { 1, 2, 3 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatesSumOfFactorsOfTwelve()
        {
            var expected = 16;

            var utility = new Utility();
            var actual = utility.CalculateSumOfFactors(new List<int>() { 1, 2, 3, 4, 6 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatesSumOfFactorsOfEighteen()
        {
            var expected = 21;

            var utility = new Utility();
            var actual = utility.CalculateSumOfFactors(new List<int>() { 1, 2, 3, 6, 9 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculatesSumOfFactorsOfOneHundred()
        {
            var expected = 117;

            var utility = new Utility();
            var actual = utility.CalculateSumOfFactors(new List<int>() { 1, 2, 4, 5, 10, 20, 25, 50 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeterminesClassificationOfSix()
        {
            var expected = Classification.Perfect;

            var utility = new Utility();
            var actual = utility.DetermineClassifiation(6, 6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeterminesClassificationOfEight()
        {
            var expected = Classification.Deficient;

            var utility = new Utility();
            var actual = utility.DetermineClassifiation(8, 7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeterminesClassificationOfSixteen()
        {
            var expected = Classification.Abundant;

            var utility = new Utility();
            var actual = utility.DetermineClassifiation(12, 16);

            Assert.AreEqual(expected, actual);
        }
    }
}
