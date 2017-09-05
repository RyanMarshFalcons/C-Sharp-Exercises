using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prime_Factorization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prime_Factorization_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueFor3()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfInt("3");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForc()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfInt("c");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForNegative()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("-4");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForPositive()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfNegative("4");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor0()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfZeroOrOne("0");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor1()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfZeroOrOne("1");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor2()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfZeroOrOne("2");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns235711For12()
        {
            var expected = new List<int>() { 2, 3, 5, 7, 11 };

            var utility = new Utility();
            var actual = utility.GetPossiblePrimeFactors(12);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns235711For60()
        {
            var expected = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59 };

            var utility = new Utility();
            var actual = utility.GetPossiblePrimeFactors(60);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor5()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfPrime(5);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseFor6()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfPrime(6);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns223For12()
        {
            var expected = new List<int>() { 2, 2, 3 };

            var utility = new Utility();
            var actual = utility.GetPrimeFactors(12, new List<int>() { 2, 3, 5, 7, 11 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns223For60()
        {
            var expected = new List<int>() { 2, 2, 3, 5 };

            var utility = new Utility();
            var actual = utility.GetPrimeFactors(60, new List<int>() { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59 });

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertsListToString()
        {
            var expected = " 2 * 2 * 3 * 5";

            var utility = new Utility();
            var actual = utility.ListToString(new List<int> { 2, 2, 3, 5 });

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertsADifferentListToString()
        {
            var expected = " 3 * 5 * 5 * 7";

            var utility = new Utility();
            var actual = utility.ListToString(new List<int> { 3, 5, 5, 7 });

            Assert.AreEqual(expected, actual);
        }
    }
}
