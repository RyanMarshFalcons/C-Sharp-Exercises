using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pluto;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pluto_Tests
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
        public void ReturnsFalseForK()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsABCD("K");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForArgentina()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("Argentina");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor12point85()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("12.85");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor72point88()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("72.88");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNegative72point88()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("-72.88");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns12point42For175()
        {
            var expected = 12.42;

            var utility = new Utility();
            var actual = utility.GetWeightOnPluto(175);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns183point1For13()
        {
            var expected = 183.1;

            var utility = new Utility();
            var actual = utility.GetVerticalLeapOnPluto(13);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0point12For30()
        {
            var expected = 0.12;

            var utility = new Utility();
            var actual = utility.GetAgeOnPluto(30);

            Assert.AreEqual(expected, actual);
        }
    }
}
