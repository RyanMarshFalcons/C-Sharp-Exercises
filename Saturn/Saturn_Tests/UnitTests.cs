using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saturn;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Saturn_Tests
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
        public void ReturnsFalseForP()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsABCD("P");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForBrazil()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("Brazil");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor104point58()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("104.58");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor71point89()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("71.89");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNegative71point89()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("-71.89");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns160point3For175()
        {
            var expected = 160.3;

            var utility = new Utility();
            var actual = utility.GetWeightOnSaturn(175);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns14point19For13()
        {
            var expected = 14.19;

            var utility = new Utility();
            var actual = utility.GetVerticalLeapOnSaturn(13);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns1point02For30()
        {
            var expected = 1.02;

            var utility = new Utility();
            var actual = utility.GetAgeOnSaturn(30);

            Assert.AreEqual(expected, actual);
        }
    }
}
