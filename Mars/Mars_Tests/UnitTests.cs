using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mars;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mars_Tests
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
        public void ReturnsFalseForVenezuela()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("Venezuela");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor98point328()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("98.328");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor43point31()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("43.31");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNegative43point31()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("-43.31");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns65point97For175()
        {
            var expected = 65.97;

            var utility = new Utility();
            var actual = utility.GetWeightOnMars(175);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns34point48For13()
        {
            var expected = 34.48;

            var utility = new Utility();
            var actual = utility.GetVerticalLeapOnMars(13);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns15point93For30()
        {
            var expected = 15.93;

            var utility = new Utility();
            var actual = utility.GetAgeOnMars(30);

            Assert.AreEqual(expected, actual);
        }
    }
}
