using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mercury;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mercury_Tests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void ReturnsTrueForA()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsABCD("A");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForB()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsABCD("B");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForC()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsABCD("C");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueForD()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.IsABCD("D");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForE()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsABCD("E");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForCanada()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("Canada");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor98point327()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("98.327");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor43point29()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("43.29");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNegative43point29()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("-43.29");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns66point15For175()
        {
            var expected = 66.15;

            var utility = new Utility();
            var actual = utility.GetWeightOnMercury(175);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns34point39For13()
        {
            var expected = 34.39;

            var utility = new Utility();
            var actual = utility.GetVerticalLeapOnMercury(13);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns124point56For30()
        {
            var expected =124.56;

            var utility = new Utility();
            var actual = utility.GetAgeOnMercury(30);

            Assert.AreEqual(expected, actual);
        }
    }
}
