using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jupiter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jupiter_Tests
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
        public void ReturnsFalseForG()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsABCD("G");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForChile()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("Chile");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor102point367()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("102.367");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor64point15()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("64.15");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNegative64point15()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("-64.15");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns413For175()
        {
            var expected = 413;

            var utility = new Utility();
            var actual = utility.GetWeightOnJupiter(175);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns5point51For13()
        {
            var expected = 5.51;

            var utility = new Utility();
            var actual = utility.GetVerticalLeapOnJupiter(13);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns2point53For30()
        {
            var expected = 2.53;

            var utility = new Utility();
            var actual = utility.GetAgeOnJupiter(30);

            Assert.AreEqual(expected, actual);
        }
    }
}
