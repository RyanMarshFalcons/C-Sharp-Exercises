using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venus;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Venus_Tests
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
        public void ReturnsFalseForR()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsABCD("R");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForMexico()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("Mexico");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor101point258()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("101.258");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor64point87()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("64.87");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNegative64point87()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("-64.87");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns158point72For175()
        {
            var expected = 158.72;

            var utility = new Utility();
            var actual = utility.GetWeightOnVenus(175);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns14point33For13()
        {
            var expected = 14.33;

            var utility = new Utility();
            var actual = utility.GetVerticalLeapOnVenus(13);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns48point75For30()
        {
            var expected = 48.75;

            var utility = new Utility();
            var actual = utility.GetAgeOnVenus(30);

            Assert.AreEqual(expected, actual);
        }
    }
}
