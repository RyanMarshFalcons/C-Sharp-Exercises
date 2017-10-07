using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cut_The_Sticks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cut_The_Sticks_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void AIsNotAnInteger()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FiftyTwoIsAnInteger()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("52");

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
        public void yIsEitheryOrn()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("y");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void nIsEitheryOrn()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("n");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void aIsNotEitheryOrn()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfyOrn("a");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AllOfTheSticksAreTwoInches()
        {
            var expected = 1;

            var utility = new Utility();
            var actual = utility.CalculateNumCuts(new List<int> { 2, 2, 2, 2, 2, 2 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AllOfTheSticksAreOneInchApart()
        {
            var expected = 5;

            var utility = new Utility();
            var actual = utility.CalculateNumCuts(new List<int> { 1, 2, 3, 4, 5 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AllOfTheSticksAreSpacedDifferentlyApart()
        {
            var expected = 4;

            var utility = new Utility();
            var actual = utility.CalculateNumCuts(new List<int> { 5, 7, 12, 20 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TwoOfTheSticksAreTheSameLength()
        {
            var expected = 3;

            var utility = new Utility();
            var actual = utility.CalculateNumCuts(new List<int> { 5, 7, 20, 20 });

            Assert.AreEqual(expected, actual);
        }
    }
}
