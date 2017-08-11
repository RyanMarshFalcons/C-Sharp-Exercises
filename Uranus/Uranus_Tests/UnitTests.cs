using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uranus;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Uranus_Tests
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
        public void ReturnsFalseForQ()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.IsABCD("Q");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForCanada()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("Panama");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor13point42()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfDouble("13.42");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsTrueFor28point19()
        {
            var expected = true;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("28.19");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReturnsFalseForNegative28point19()
        {
            var expected = false;

            var utility = new Utility();
            var actual = utility.CheckIfPositive("-28.19");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns155point57For175()
        {
            var expected = 155.57;

            var utility = new Utility();
            var actual = utility.GetWeightOnUranus(175);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns14point62For13()
        {
            var expected = 14.62;

            var utility = new Utility();
            var actual = utility.GetVerticalLeapOnUranus(13);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns0point36For30()
        {
            var expected = 0.36;

            var utility = new Utility();
            var actual = utility.GetAgeOnUranus(30);

            Assert.AreEqual(expected, actual);
        }
    }
}
