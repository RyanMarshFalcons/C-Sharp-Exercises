using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrimeNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PrimeNumbers_Tests
{
    [TestClass]
    public class UnitTesting
    {
        [TestMethod]
        public void ReturnsTrueFor5()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("5");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFore()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("e");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative(-7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForPositive()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative(7);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns23561015For30()
        {
            var expected = new List<int>() { 2, 3, 5, 6, 10, 15 };

            var utility = new Utility();
            var actual = utility.GetFactors(30);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns251025For50()
        {
            var expected = new List<int>() { 2, 5, 10, 25 };

            var utility = new Utility();
            var actual = utility.GetFactors(50);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForEmptyList()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfPrime(new List<int>());

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForPopulatedList()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfPrime(new List<int>() { 2, 3, 4, 6 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertsListToString()
        {
            var expected = " 2 3 4 6 8 12";

            var utility = new Utility();
            var actual = utility.ListToString(new List<int> { 2, 3, 4, 6, 8, 12 });

            Assert.AreEqual(expected, actual);
        }
    }
}
